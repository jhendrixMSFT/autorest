// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;

using AutoRest.Core.ClientModel;
using AutoRest.Core.Utilities;

namespace AutoRest.Go.TemplateModels
{
    public class EnumMethodTemplateModel
    {
        public EnumMethodTemplateModel(IEnumerable<EnumTemplateModel> enums, string packageName)
        {
            PackageName = packageName;
            Enums = enums;
        }

        public string PackageName { get; }

        public IEnumerable<EnumTemplateModel> Enums { get; }
    }
}
