// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;

using AutoRest.Core.ClientModel;
using AutoRest.Core.Utilities;

namespace AutoRest.Go.TemplateModels
{
    public class EnumTemplateModel : EnumType
    {
        public struct Entry
        {
            public string Name;
            public string Value;
        }

        public bool HasUniqueNames { get; set; }

        public EnumTemplateModel(EnumType source)
        {
            this.LoadFrom(source);

            // Assume members have unique names
            HasUniqueNames = true;

            // provide a default documentation comment
            // TODO: seems like the swagger description can be used here?
            Documentation = string.Format("{0} enumerates the values for {1}.", Name, Name.ToPhrase());
        }

        public IReadOnlyList<Entry> Constants
        {
            get
            {
                // populate the list of enum values.  each entry is a tuple
                // containing the name of the enum and its corresponding value.
                var constants = new List<Entry>(Values.Count);
                for (int i = 0; i < Values.Count; ++i)
                {
                    var entry = new Entry();
                    entry.Name = HasUniqueNames ? Values[i].Name : $"{Name}{Values[i].Name}";
                    entry.Value = Values[i].SerializedName;

                    constants.Add(entry);
                }

                return constants;
            }
        }

        public string Documentation { get; set; }
    }
}
