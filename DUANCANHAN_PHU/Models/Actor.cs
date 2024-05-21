using System.ComponentModel.DataAnnotations;

namespace DUANMVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile  Picture  Url")]
        public string ProfilePictureUrl { get; set; }


        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Mối liên hệ 

        public List<Actor_Movie> Actor_Movies { get; set; }


    }
}
