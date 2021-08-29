using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class KeyValue
    {
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";
        public KeyValue() { }
        public KeyValue(string key, string value)
        {
            Key = key;
            Value = value;
        }
            
    }
}
