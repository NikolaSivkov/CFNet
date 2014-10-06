using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
                props.Add(pi.Name, this.GetType().GetProperty(pi.Name).GetValue(this).ToString());
            }

            return props;
        }
    }
}
