using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemKontrolka.Models
{
    public class LoginHistoryEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public string Action { get; set; }
    }
}
