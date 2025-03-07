﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookify_data.Entities
{
	public class Wishlist
	{
		public int WishlistId { get; set; }
		public int CustomerId { get; set; }

		// Navigation properties
		public Customer? Customer { get; set; }
		public List<WishlistDetail> WishlistDetails { get; set; } = new List<WishlistDetail>();
	}
}
