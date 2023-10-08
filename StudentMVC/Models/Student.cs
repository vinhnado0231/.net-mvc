using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTHDV.StudentMVC.Models
{
    [Table("Students")]
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        [StringLength(256)]
        public string Address { get; set; } = null!;
    }
}