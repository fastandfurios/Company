using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Models;
using Prism.Mvvm;

namespace Company.ViewModels
{
    public class EmployeeViewModel : BindableBase
    {
		#region Prop and fields
		private readonly Employee _employee = new Employee();

		private string _surname;
		public string Surname
		{
			get => _surname;
			set
			{
				_surname = value;
				RaisePropertyChanged(Surname);
			}
		}
		public string Name { get; set; }
		public string Patronymic { get; set; }
		public DateTime Date { get; set; }
		public Enum Gender { get; set; }
		public Division Division { get; set; }
		#endregion


	}
}
