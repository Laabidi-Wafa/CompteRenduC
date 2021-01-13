using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TP01.Models
{   [Table("User")]
    public class User
    {
        [PrimaryKey , AutoIncrement]
        public int ID { get; set; }

        [MaxLength(30) , Unique]
        public string Email { get; set; }

        [MaxLength(30)]
        public string Password { get; set; }
    }
}
