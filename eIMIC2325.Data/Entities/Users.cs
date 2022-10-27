using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord{ get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FullName { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
