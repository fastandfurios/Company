using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Employee
    {
	    public string Surname { get; set; }
	    public string Name { get; set; }
	    public string Patronymic { get; set; }
	    public DateTime Date { get; set; }
	    public Enum Gender { get; set; }
	    public Division Division { get; set; }
    }
}
