using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSound
{
    public class Results
    {
      //  public string Sold_id { get; set; }
        public int Exam_id { get; set; }
        public string Name { get; set; }
       // public int Full_mark { get; set; }
       // public int Exam_duration { get; set; }
      //  public List<Answers> ListAnswers { get; set; }

      //  public string Barcode { get; set; }

        public int Total { get; set; }
        public int Noticed { get; set; }
        public int Downfull { get; set; }

        public int ID { get; set; }
    }
}
