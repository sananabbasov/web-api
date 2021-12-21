using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public static class SeetDatabase
    {
        public static void Seed()
        {
            var context = new GiftDbContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
                
            }
            context.SaveChanges();
        }

        private static Category[] Categories ={
            new Category() { Name = "Kişi üçün"},
            new Category() { Name = "Qadın üçün"},
            new Category() { Name = "Ad günü"},
            new Category() { Name = "Sevgililər üçün"},
            new Category() { Name = "Smart saatlar"},

        };

        private static Product[] Products ={
            new Product() { Name = "Apple Watch Series 7", Price = 1100, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            new Product() { Name = "Huawei Watch Gt 2 Pro Black", Price = 690, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            new Product() { Name = "AMAZFIT GTS 3 IVORY White", Price = 339.99, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            new Product() { Name = "Paltaryuyan Toshiba TWD-BK90S2GE(SK)(gümüşü)", Price = 1049.99, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            new Product() { Name = "Aspirator Gorenje TH62E3X", Price = 179.99, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},

        };

        private static ProductCategory[] ProductCategories = {
            new ProductCategory{ Product= Products[0], Category = Categories[0]},
            new ProductCategory{ Product= Products[0], Category = Categories[3]},
            new ProductCategory{ Product= Products[4], Category = Categories[0]},
            new ProductCategory{ Product= Products[4], Category = Categories[3]},
            new ProductCategory{ Product= Products[1], Category = Categories[3]},
            new ProductCategory{ Product= Products[2], Category = Categories[3]},
            new ProductCategory{ Product= Products[3], Category = Categories[3]},
        };

    }
}
