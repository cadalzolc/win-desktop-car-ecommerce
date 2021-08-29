using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class Payment_Mode
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Card_Type { get; set; } = "";
        public string Card_No { get; set; } = "";
        public string Card_Pin { get; set; } = "";
        public string Card_Expiry { get; set; } = "";
        public Payment_Mode() { }
        public Payment_Mode(string _ID, string _Name, string _Card_Type, string _Card_No, string _Card_Pin, string _Card_Expiry)
        {
            ID = _ID;
            Name = _Name;
            Card_Type = _Card_Type;
            Card_No = _Card_No;
            Card_Pin = _Card_Pin;
            Card_Expiry = _Card_Expiry;
        }
    }
}