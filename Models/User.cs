using System.ComponentModel.DataAnnotations;

namespace LoginService.Models
{
    public class User
    {
        [Key]
        public string userName{get; set;}
        public string password {get;set;}
        public int age {get; set;}
    }
}