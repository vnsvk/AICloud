using AICloud.API.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AICloud.API.Models
{
	public class Job
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string TotalPrice { get; set; }
		public string Notes { get; set; }

		[ForeignKey("Customer")] public int Customer_Id { get; set; }
		public Customer Customer { get; set; }

		[ForeignKey("Employee")] public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

	}
}