using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Shops
{
    public class Session
    {
        public bool IsLogin { get; set; } = false;
        public User CurrentUser { get; set; } = new User();
    }
}