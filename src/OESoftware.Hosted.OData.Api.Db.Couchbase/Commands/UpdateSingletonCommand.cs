﻿// Copyright (C) 2015 Michael Norgate

// This software may be modified and distributed under the terms of 
// the Creative Commons Attribution Non-commercial license.  See the LICENSE file for details.

#region usings

using System.Threading.Tasks;
using System.Web.OData;
using Microsoft.OData.Edm;
using Newtonsoft.Json.Linq;

#endregion

namespace OESoftware.Hosted.OData.Api.Db.Couchbase.Commands
{
    /// <summary>
    /// Updates an singleton value
    /// </summary>
    public class UpdateSingletonCommand : IDbCommand
    {
        private readonly EdmEntityObject _entity;
        private readonly IEdmModel _model;
        private readonly IEdmSingleton _singleton;

        /// <summary>
        /// Default Construtor
        /// </summary>
        /// <param name="entity"><see cref="EdmEntityObject"/> to insert</param>
        /// <param name="singleton">The <see cref="IEdmSingleton"/></param>
        /// <param name="model">The <see cref="IEdmModel"/> containing the type</param>
        public UpdateSingletonCommand(EdmEntityObject entity, IEdmSingleton singleton, IEdmModel model)
        {
            _entity = entity;
            _singleton = singleton;
            _model = model;
        }

        Task IDbCommand.Execute(string tenantId)
        {
            return Execute(tenantId);
        }

        /// <summary>
        /// Execute this command
        /// </summary>
        /// <param name="tenantId">The id of the tenant</param>
        /// <returns><see cref="EdmEntityObject"/></returns>
        public async Task<EdmEntityObject> Execute(string tenantId)
        {
            using (var bucket = BucketProvider.GetBucket())
            {
                //Convert entity to document
                var id = Helpers.CreateSingletonId(tenantId, _singleton);

                var converter = new EntityObjectConverter(new ValueGenerator());

                //Get the current version
                var find = await bucket.GetDocumentAsync<JObject>(id);

                if (!find.Success)
                {
                    return
                        await
                            CommandHelpers.InsertSingletonAsync(converter, _entity, tenantId, _singleton, _model, id,
                                bucket);
                }
                var document =
                    await
                        converter.ToDocument(_entity, tenantId, _singleton.EntityType(), ConvertOptions.CopyOnlySet,
                            _model);
                var mergeSettings = new JsonMergeSettings
                {
                    MergeArrayHandling = MergeArrayHandling.Union
                };

                //Replace the existing values with the new ones
                find.Content.Merge(document, mergeSettings);

                var result = await bucket.ReplaceAsync(find.Document);
                if (!result.Success)
                {
                    throw ExceptionCreator.CreateDbException(result);
                }

                //Convert document back to entity
                var output = converter.ToEdmEntityObject(find.Content, tenantId, _singleton.EntityType());

                return output;
            }
        }
    }
}