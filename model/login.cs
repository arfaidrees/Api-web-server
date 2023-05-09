using System.ComponentModel.DataAnnotations;

namespace api_assignment.model
{
    public class login
    {
        [Key]

    
        public string uname { get; set; }
        public string upass { get; set; }

    }
}

   