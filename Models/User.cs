using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("user")]
    public class User
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}