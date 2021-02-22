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
                if (results.Count == 0)
                    return null;
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

        // Dùng hàm này để tránh mở file nhiều lần
        public List<ProductEntity> FindProductByListID(List<int> ID)
        {
            List<ProductEntity> products = FindAllProducts();
            List<ProductEntity> result = new List<ProductEntity>();

            foreach (int id in ID)
            {
                foreach (ProductEntity product in products)
                    if (product.ID == id)
                    {
                        result.Add(product);
                        break;
                    } 
            }

            return result;
        }


        /* 
             các loại tham số của category: san-pham, san-pham-khuyen-mai, may-tinh, phu-kien
        */
        public List<ProductEntity> FindProductCategory(string category)
        {
            
            if ("san-pham".Equals(category))
                return FindAllProducts();

            List<ProductEntity> products = new List<ProductEntity>();

            
            foreach (ProductEntity product in FindAllProducts())
            {
                if ((product.Sale > 0 && "san-pham-khuyen-mai".Equals(category)) || product.Category.Equals(category))
                    products.Add(product);
            }
            
            return products;
        }

        public ProductEntity FindProductBySlug(string slug)
        {
            foreach (ProductEntity product in FindAllProducts())
            {
                if (product.Slug.Equals(slug))
                    return product;
            }
            return null;
        }
    }
}