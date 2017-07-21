// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.Core.Utilities;
using AutoRest.Core.Model;
using AutoRest.Extensions;
using System.Text;

namespace AutoRest.Go.Model
{
    public class PropertyGo : Property
    {
        public PropertyGo()
        {

        }

        public bool IsInParamGroup { get { return Extensions.ContainsKey(SwaggerExtensions.ParameterGroupExtension); } }

        public string Tag(bool omitEmpty = true)
        {
            if (IsInParamGroup)
            {
                return string.Empty;
            }

            if (this.Parent.CodeModel.ShouldGenerateXmlSerialization)
            {
                var sb = new StringBuilder("`xml:\"");

                bool hasParent = false;
                if (Parent is CompositeTypeGo && !((CompositeTypeGo)Parent).IsWrapperType)
                {
                    sb.Append(XmlName);
                    hasParent = true;
                }

                if (XmlIsWrapped)
                {
                    if (hasParent)
                    {
                        sb.Append('>');
                    }

                    var asSequence = ModelType as SequenceTypeGo;
                    sb.Append(asSequence.ElementXmlName);
                }
                else if (XmlIsAttribute)
                {
                    sb.Append(",attr");
                }

                sb.Append("\"`");
                return sb.ToString();
            }

            return string.Format("`json:\"{0}{1}\"`", SerializedName, omitEmpty ? ",omitempty" : "");
        }
    }
}
