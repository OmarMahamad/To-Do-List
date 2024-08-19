using System.ComponentModel.DataAnnotations;

namespace To_Do_List.Models
{
    public class UserModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public ICollection<TaskModel> taskModels { get; set; }

    }
}
