using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AICloud.API.Models
{
	public class Material
	{
		public int Id { get; set; }
		public string MaterialName { get; set; }
		public int Quantity { get; set; }
		public string Description { get; set; }
		public string Amount { get; set; }

		[ForeignKey("Job")] public int Job_Id { get; set; }
		public Job Job { get; set; }

		[ForeignKey("Item")] public int Item_Id { get; set; }
		public Item Item { get; set; }
	}
}