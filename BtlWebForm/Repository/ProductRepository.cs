using BtlWebForm.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWebForm.Repository
{
    public class ProductRepository
    {
        FileIO fileIO = new FileIO();
        public List<ProductEntity> FindAllProducts()
        {
            string productsJson = fileIO.ReadFileJson(Constant.DATA_PRODUCTS);
            if (productsJson != null)
            {
                List<ProductEntity> products = JsonConvert.DeserializeObject<List<ProductEntity>>(productsJson);
                return products;
            }
            return null;
        }

        public List<ProductEntity> FindProductsLikeName(string name)
        {
            List<ProductEntity> products = FindAllProducts();
            if (name == null || "".Equals(name))
            {
                return products;
            }

            if (products != null) // tránh exception trong foreach
            {
                List<ProductEntity> results = new List<ProductEntity>();
                foreach (ProductEntity product in products)
                {
                    if (product.Name.ToLower().Contains(name.ToLower()))
                        results.Add(product);
                }
                return results;
            }
            return null;
        }

        public ProductEntity FindProductByID(int ID)
        {
            List<ProductEntity> products = FindAllProducts();
            if (products == null)
                return null;
            foreach (ProductEntity product in products)
            {
                if (product.ID == ID)
                    return product; 
            }
            return null;
        }
    }
}