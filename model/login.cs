using System.ComponentModel.DataAnnotations;

namespace api_assignment.model
{
    public class login
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

   