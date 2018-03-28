// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DiskCreateOptionTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiskCreateOptionTypes
    {
        [EnumMember(Value = "FromImage")]
        FromImage,
        [EnumMember(Value = "Empty")]
        Empty,
        [EnumMember(Value = "Attach")]
        Attach
    }
    internal static class DiskCreateOptionTypesEnumExtension
    {
        internal static string ToSerializedValue(this DiskCreateOptionTypes? value)
        {
            return value == null ? null : ((DiskCreateOptionTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DiskCreateOptionTypes value)
        {
            switch( value )
            {
                case DiskCreateOptionTypes.FromImage:
                    return "FromImage";
                case DiskCreateOptionTypes.Empty:
                    return "Empty";
                case DiskCreateOptionTypes.Attach:
                    return "Attach";
            }
            return null;
        }

        internal static DiskCreateOptionTypes? ParseDiskCreateOptionTypes(this string value)
        {
            switch( value )
            {
                case "FromImage":
                    return DiskCreateOptionTypes.FromImage;
                case "Empty":
                    return DiskCreateOptionTypes.Empty;
                case "Attach":
                    return DiskCreateOptionTypes.Attach;
            }
            return null;
        }
    }
}
