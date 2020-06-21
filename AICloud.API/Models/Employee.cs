using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace AICloud.API.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Mobile { get; set; }
		public string Email { get; set; }
		public int WorkPhone { get; set; }
		public string Designation { get; set; }
		public string HouseNumber { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string County { get; set; }
		public string Country { get; set; }
		public int Pin { get; set; }
		public string LoginType { get; set; }
		public int WorkingStart { get; set; }
		public int WorkingEnd { get; set; }
	}
}