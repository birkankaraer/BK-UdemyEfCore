﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst.DAL
{
    [Index(nameof(Name))]
    public class Product
    {
        public int Id { get; set; }
        //[StringLength(100,MinimumLength =20)]Hem veri tabanı etkisi hem de validation etkisi
        public string Name { get; set; }
        [Precision(9, 2)]
        public decimal Price { get; set; }
        [Precision(9, 2)]
        public decimal DiscountPrice { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductFeature ProductFeature { get; set; }

    }
}
