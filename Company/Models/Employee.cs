using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
	public class Employee
    {
	    public int Id { get; set; }
	    public string Surname { get; set; }
	    public string Name { get; set; }
	    public string Patronymic { get; set; }
	    public DateTime Date { get; set; }
		[NotMapped]
	    public Enum Gender { get; set; }
	    public Division Division { get; set; }
    }
}
