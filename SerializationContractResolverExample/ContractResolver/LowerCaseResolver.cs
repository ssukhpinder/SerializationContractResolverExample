using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SerializationContractResolverExample.ContractResolver
{
    public class LowerCaseResolver<T> : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            if (property.DeclaringType == typeof(T))
            {
                property.PropertyName = property.PropertyName.ToLower();
            }

            return property;
        }

    }
}
