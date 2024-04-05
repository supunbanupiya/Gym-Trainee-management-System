using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gtm_Mgt_Demo.Models
{
    public class GymTrainee
    {
        [Key]
        [Column(TypeName ="int")]
        public int TraineeId { get; set; }

        [Required]
        [Column(TypeName="varchar(50)")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contact No")]
        public string ContactNo { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Height")]
        public int Height { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Weight")]
        public int Weight { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Gender")]
        public string Gender { get; set; } = "Male";

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        public DateTime CreationDate { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile Image {  get; set; }

    }
}
