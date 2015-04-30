﻿//---------------------------------------------------------------------
// <copyright file="EdmConstants.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace OESoftware.Hosted.OData.Api
{
    /// <summary>
    /// Constant values used in the EDM.
    /// </summary>
    public static class EdmConstants
    {
        #region Edm Primitive Type Names -----------------------------------------------------------------------------/

        /// <summary>namespace for edm primitive types.</summary>
        public const string EdmNamespace = "Edm";

        /// <summary>edm binary primitive type name</summary>
        public const string EdmBinaryTypeName = "Edm.Binary";

        /// <summary>edm boolean primitive type name</summary>
        public const string EdmBooleanTypeName = "Edm.Boolean";

        /// <summary>edm byte primitive type name</summary>
        public const string EdmByteTypeName = "Edm.Byte";

        /// <summary>edm date primitive type name</summary>
        public const string EdmDateTypeName = "Edm.Date";

        /// <summary>Represents a Time instance as an interval measured in milliseconds from an instance of DateTime.</summary>
        public const string EdmDateTimeOffsetTypeName = "Edm.DateTimeOffset";

        /// <summary>edm decimal primitive type name</summary>
        public const string EdmDecimalTypeName = "Edm.Decimal";

        /// <summary>edm double primitive type name</summary>
        public const string EdmDoubleTypeName = "Edm.Double";

        /// <summary>edm guid primitive type name</summary>
        public const string EdmGuidTypeName = "Edm.Guid";

        /// <summary>edm single primitive type name</summary>
        public const string EdmSingleTypeName = "Edm.Single";

        /// <summary>edm sbyte primitive type name</summary>
        public const string EdmSByteTypeName = "Edm.SByte";

        /// <summary>edm int16 primitive type name</summary>
        public const string EdmInt16TypeName = "Edm.Int16";

        /// <summary>edm int32 primitive type name</summary>
        public const string EdmInt32TypeName = "Edm.Int32";

        /// <summary>edm int64 primitive type name</summary>
        public const string EdmInt64TypeName = "Edm.Int64";

        /// <summary>edm string primitive type name</summary>
        public const string EdmStringTypeName = "Edm.String";

        /// <summary>Represents an interval measured in milliseconds.</summary>
        public const string EdmDurationTypeName = "Edm.Duration";

        /// <summary>edm stream primitive type name</summary>
        public const string EdmStreamTypeName = "Edm.Stream";

        /// <summary>edm timeOfDay primitive type name</summary>
        public const string EdmTimeOfDayTypeName = "Edm.TimeOfDay";

        /// <summary>edm geography primitive type name</summary>
        public const string EdmGeographyTypeName = "Edm.Geography";

        /// <summary>Represents a geography Point type.</summary>
        public const string EdmPointTypeName = "Edm.GeographyPoint";

        /// <summary>Represents a geography LineString type.</summary>
        public const string EdmLineStringTypeName = "Edm.GeographyLineString";

        /// <summary>Represents a geography Polygon type.</summary>
        public const string EdmPolygonTypeName = "Edm.GeographyPolygon";

        /// <summary>Represents a geography GeomCollection type.</summary>
        public const string EdmGeographyCollectionTypeName = "Edm.GeographyCollection";

        /// <summary>Represents a geography MultiPolygon type.</summary>
        public const string EdmMultiPolygonTypeName = "Edm.GeographyMultiPolygon";

        /// <summary>Represents a geography MultiLineString type.</summary>
        public const string EdmMultiLineStringTypeName = "Edm.GeographyMultiLineString";

        /// <summary>Represents a geography MultiPoint type.</summary>
        public const string EdmMultiPointTypeName = "Edm.GeographyMultiPoint";

        /// <summary>Represents an arbitrary Geometry type.</summary>
        public const string EdmGeometryTypeName = "Edm.Geometry";

        /// <summary>Represents a geometry Point type.</summary>
        public const string EdmGeometryPointTypeName = "Edm.GeometryPoint";

        /// <summary>Represents a geometry LineString type.</summary>
        public const string EdmGeometryLineStringTypeName = "Edm.GeometryLineString";

        /// <summary>Represents a geometry Polygon type.</summary>
        public const string EdmGeometryPolygonTypeName = "Edm.GeometryPolygon";

        /// <summary>Represents a geometry GeomCollection type.</summary>
        public const string EdmGeometryCollectionTypeName = "Edm.GeometryCollection";

        /// <summary>Represents a geometry MultiPolygon type.</summary>
        public const string EdmGeometryMultiPolygonTypeName = "Edm.GeometryMultiPolygon";

        /// <summary>Represents a geometry MultiLineString type.</summary>
        public const string EdmGeometryMultiLineStringTypeName = "Edm.GeometryMultiLineString";

        /// <summary>Represents a geometry MultiPoint type.</summary>
        public const string EdmGeometryMultiPointTypeName = "Edm.GeometryMultiPoint";

        #endregion Edm Primitive Type Names

        #region CSDL serialization constants

        /// <summary>
        /// The namespace for Oasis verion of Edmx
        /// </summary>
        internal const string EdmxOasisNamespace = "http://docs.oasis-open.org/odata/ns/edmx";

        /// <summary>The element name of the top-level &lt;Edmx&gt; metadata envelope.</summary>
        internal const string EdmxName = "Edmx";

        #endregion

        #region Paths

        internal const string EntitySetPath = "~/entityset";

        internal const string EntityNavigationPath = "~/entityset/key/navigation";

        internal const string EntityPath = "~/entityset/key";

        internal const string EntityPropertyPath = "~/entityset/key/(property(/?))+";

        internal const string EntityRawPropertyPath = "~/entityset/key/(property(/?))+/\\$value";

        #endregion
    }
}