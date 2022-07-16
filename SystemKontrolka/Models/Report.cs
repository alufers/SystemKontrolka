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

        public string Description { get; set; }

        public User User { get; set; }

        public Part Part { get; set; }

    }
}
