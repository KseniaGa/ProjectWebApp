using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class Expense
	{
		public Expense (int quantity, int pricePerItem)
		{
			Quantity = quantity;
			PricePerItem = pricePerItem;

			OverallPrice = quantity * pricePerItem;
		}

		public int Id { get; set; }
		public string Item { get; set; }

		public int Quantity { get; set; }

		public int PricePerItem { get; set; }

		public string Purpose { get; set; }
		public string Unit { get; set; }

		

		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }


		public int OverallPrice;



	}
}
