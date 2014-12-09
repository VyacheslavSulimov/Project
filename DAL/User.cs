using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public int id { get; set; }     
        public string UserName { get; set; }  
        public string MiddleName { get; set; }
        public string Forename { get; set; } 
        public string email { get; set; }
        public string PasswordCashe { get; set; }
        public int RoleId { get; set; }
        protected Roles Roles { get; set; }  
        public int Thanks { get; set; }    
        public bool IsApproved { get; set; }       
   
    }
}
