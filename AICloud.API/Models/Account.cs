using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AICloud.API.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string SubscriptionType { get; set; }
		public float SubscriptionAmount { get; set; }
		public string SubscriptionStatus { get; set; }
	}
}