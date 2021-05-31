using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Order
    {
	    public int OrderId { get; set; }
	    public string Counteragent { get; set; }
	    public DateTime Date { get; set; }
	    public Employee Author { get; set; }
    }
}
