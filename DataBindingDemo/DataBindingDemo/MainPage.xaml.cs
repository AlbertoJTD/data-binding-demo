using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			//string message = "Hello";
			//List<string> names = new List<string>
			//{
			//	"John",
			//	"Jhonny",
			//	"Sonya",
			//	"Jason"
			//};

			var person = new Person()
			{
				Name = "John",
				Address = "Great Av.",
				Age = 67,
				LastName = "Wick",
				Phone = "5550010999"
			};

			this.BindingContext = person;
		}
	}
}
