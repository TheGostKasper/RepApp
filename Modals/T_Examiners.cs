using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSound.Modals
{
    public class T_Examiners
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string Sold_Id { get; set; }
    }

    public class TResults
    {
        public int ID { get; set; }
        public string Ex_name { get; set; }
        public int Rs_results { get; set; }
        public string  Rs_date { get; set; }
    }
}
