using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AICloud.API.Models
{
	public class Installment
	{
		public int Id { get; set; }
		public int InstallmentNo { get; set; }
		public float InstallmentAmount { get; set; }
		[ForeignKey("Invoice")] public int Invoice_Id { get; set; }
		public Invoice Invoice { get; set; }

		[ForeignKey("Customer")] public int Customer_Id { get; set; }
		public Customer Customer { get; set; }

		[ForeignKey("Job")] public int Job_Id { get; set; }
		public Job Job { get; set; }
		public DateTime Date { get; set; }

	}
}