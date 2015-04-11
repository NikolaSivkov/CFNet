using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public abstract class CFAction
    {
        public virtual string act { get; private set; }

        public Dictionary<string, string> ToParams()
        {
            var props = new Dictionary<string, string>();
            PropertyInfo[] PInfos = this.GetType().GetProperties();

            foreach (PropertyInfo pi in PInfos)
            {

                var keyName = pi.Name;

                var hasSerializeAs = Attribute.IsDefined(pi, typeof(SerializeAsAttribute));

                if (hasSerializeAs)
                {
                    var serializeAs = (SerializeAsAttribute)Attribute.GetCustomAttribute(pi, typeof(SerializeAsAttribute));

                    keyName = serializeAs.Name;
                }

                props.Add(keyName, this.GetType().GetProperty(pi.Name).GetValue(this).ToString());
            }

            return props;
        }
    }
}
