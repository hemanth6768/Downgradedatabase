using System.ComponentModel.DataAnnotations;

namespace Downgradedatabase.Model
{
    public class Student1
    {

        public string name { get; set; }

        [Key]
        public int rollnumber { get; set; } 

        //public string section { get; set; }
    }
}
