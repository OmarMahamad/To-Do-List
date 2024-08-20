using System.ComponentModel.DataAnnotations;

namespace To_Do_List.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public string? Status { get; set; }

        public Boolean IsCompleted { get; set; }
        [Required]
        public DateOnly Start { get; set; }

        [Required] 
        public DateOnly End { get; set; }

        //navigate
        public UserModel? UserModel { get; set; }



        public enum StateEnum
        {
            Work,
            Life,
            Study
        }



    }
    
}
