using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemKontrolka.Models
{
    
    /// <summary>
    /// THis is the model that represents a user that can log in into the system.
    /// </summary>
    public class User
    {

            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public bool CanEditUsers { get; set; }
            public bool CanEditReports { get; set; }

            public bool CanEditParts { get; set; }

            public bool CanEditDefectTypes { get; set; }
        
    }
}
