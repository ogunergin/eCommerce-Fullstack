﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class BasketDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductName { get; set; }
        public string MainPhotoUrl { get; set; }
    }
}
