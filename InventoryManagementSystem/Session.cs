using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Session
    {
        public static string? Username { get; set; }
        public static string? Name { get; set; }
        public static bool IsAdmin { get; set; }
    }
}
