﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CartitemDto
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public int cartId { get; set; }
        public string ProductName { get; set;  }
        public string ProductDescription { get; set; }
        public string ProductImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set;}
        public int Qty { get; set; }
    } 
}
