
using System.Collections.Generic;


namespace BtlWebForm.Entity
{
    public class OrderEntity
    {
        public int IDOrder { get; set; }
        public List<ProductEntity> ListProduct { get; set; }
        public int IDUser { get; set; }
        public OrderEntity() { }
        public OrderEntity(int IDCart, int IDProduct, int Quantity)
        {
            this.IDOrder = IDCart;
            ProductEntity product = new ProductEntity();
            product.ID = IDProduct;
            product.Quantity = Quantity;
            ListProduct = new List<ProductEntity>();
            ListProduct.Add(product);
        }
    }
}