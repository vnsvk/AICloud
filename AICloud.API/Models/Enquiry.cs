using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AICloud.API.Models
{
	public class Enquiry
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public int Mobile { get; set; }
		public string Message { get; set; }
	}
}