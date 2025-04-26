using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Give your diary a title")]
        //[StringLength(100, MinimumLength=3 , ErrorMessage ="Title must be 3 to 100 charachters")]
        public required string Title { get; set; }
        [StringLength(700, MinimumLength = 25, ErrorMessage = "Content should have at-least 25 characters")]
        [Required(ErrorMessage = "Content is required")]
        public required string Content { get; set; }
        [Required(ErrorMessage = "Select a date")]
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
