using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public enum E_Gender
    {
        Male, Female, Other
    }
    public class Employee
    {
        public int E_Id { get; set; }

        public string E_Name { get; set; }

        public string E_Email { get; set; }

        public string E_Phone { get; set; }

        public E_Gender E_Gender { get; set; }

        public string E_Address { get; set; }
    }
}
