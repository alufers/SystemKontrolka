using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace SystemKontrolka.Models
{
    public class Report
    {
        [DisplayName("ID")]
        public int Id { get; set; }


        public DateTime Date { get; set; }

        [DisplayName("Waga")]
        public float Weight { get; set; }
    }
}
