using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspTest.AnimalDb.Tables
{
    public class Animal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AnimalId { get; set; }

        [Display(Name = "Column Name")]
        public string Name { get; set; }
    }
}
