using BtlWebForm.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWebForm.Entity
{
    public class CartEntity
    {
        public int IDCart { get; set; }
        public List<ProductEntity> ListProduct { get; set; }
        public int IDUser { get; set; }
    }
}