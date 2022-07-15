using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace SystemKontrolka.Models
{
    internal class Part
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DisplayName("Waga")]
        public float Weight { get; set; }
    }
}
