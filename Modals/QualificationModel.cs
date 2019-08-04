using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSound.Modals
{
    public class QualificationModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int High { get; set; }
        public int ncdHigh { get; set; }
        public int dnHigh { get; set; }
        public int Medium { get; set; }
        public int ncdMedium { get; set; }
        public int dnMedium { get; set; }
        public int AboveMedium { get; set; }
        public int ncdAboveMedium { get; set; }
        public int dnAboveMedium { get; set; }
        public int Low { get; set; }
        public int ncdLow { get; set; }
        public int dnLow { get; set; }
    }
}
