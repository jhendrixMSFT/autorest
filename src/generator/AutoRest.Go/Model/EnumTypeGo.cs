// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;

namespace AutoRest.Go.Model
{
    public class EnumTypeGo : EnumType
    {
        public EnumTypeGo()
        {
            // the default value for unnamed enums is "enum"
            Name.OnGet += v => v == "enum" ? "string" : FormatName(v);
        }

        public EnumTypeGo(EnumType source) : this()
        {
            this.LoadFrom(source);
        }

        public string GetEmptyCheck(string valueReference, bool required, bool asEmpty)
        {
            var comp = asEmpty ? "==" : "!=";
            var logiclOp = asEmpty ? "||" : "&&";
            var deref = required ? string.Empty : "*";

            return string.Format("{0} {1} nil {2} len({3}{0}) {1} 0", valueReference, comp, logiclOp, deref);
        }

        public bool IsNamed => Name != "string" && Values.Any();

        public IDictionary<string, string> Constants
        {
            get
            {
                var constants = new Dictionary<string, string>();
                Values
                    .ForEach(v =>
                    {
                        constants.Add(FormatValue(v.Name), v.SerializedName);
                    });

                return constants;
            }
        }

        public string Documentation { get; set; }

        private string FormatName(string rawName)
        {
            if (!rawName.EndsWith("Type"))
            {
                return $"{rawName}Type";
            }
            return rawName;
        }

        private string FormatValue(string rawValue)
        {
            // remove "Type" from the end of the name
            // then append the value name to this string
            var nameAsString = Name.ToString();
            return $"{nameAsString.Substring(0, nameAsString.Length - 4)}{rawValue}";
        }
    }
}
