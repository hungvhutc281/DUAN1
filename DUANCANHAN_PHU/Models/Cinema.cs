using System.ComponentModel.DataAnnotations;

namespace DUANMVC.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo Cinema")]
        public string Logo { get; set; }
        [Display(Name = "Name Cinema")]
        public string Name { get; set; }

        [Display(Name = "Description Cinema")]
        public string Description { get; set; }

        //Mối quan hệ 
        public List<Movie> Movies { get; set; }
    }
}
