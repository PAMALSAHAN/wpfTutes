using System;
using System.Collections.Generic;
using System.Text;

namespace WPFTest.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        //passe add karapu 
        public DateTime DatedJoin { get; set; }
        public string Password { get; set; }
    }
}
