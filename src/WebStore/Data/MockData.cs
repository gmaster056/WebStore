using System.Collections.Generic;
using WebStore.Domain.Entities;
using WebStore.Models;

namespace WebStore.Data.MockData
{
    public class MockData
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Александр", LastName = "Амелькин", MiddleName = "Алексеевич", Age = 33, City = "Moscow", Email = "gmaster056@gmail.com", Job = "Product Owner"},
            new Employee { Id = 2, FirstName = "Николай", LastName = "Хрипаев", MiddleName = "Владимирович", Age = 30, City = "Balashikha", Email = "nikolay@gmail.com", Job = "Product Manager"},
            new Employee { Id = 3, FirstName = "Маским", LastName = "Верчинко", MiddleName = "Александрович", Age = 29, City = "Nicosia", Email = "iosdeveloper@gmail.com", Job = "Middle Developer"},
            new Employee { Id = 4, FirstName = "Роман", LastName = "Кузнецов", MiddleName = "Юрьевич", Age = 27, City = "Murmansk", Email = "saintera@gmail.com", Job = "Senior Developer"},
            new Employee { Id = 5, FirstName = "Дмитрий", LastName = "Штойцман", MiddleName = "Анатольевич", Age = 31, City = "Rostov-on-Don", Email = "bmwclub@gmail.com", Job = "Junior Developer"},
            new Employee { Id = 6, FirstName = "Андрей", LastName = "Лебедев", MiddleName = "Владимирович", Age = 43, City = "Orenburg", Email = "builder@gmail.com", Job = "Team Lead"}
        };

        public static IEnumerable<Section> Sections { get; } = new[]
        {
              new Section { Id = 1, Name = "Sport", Order = 0 },
              new Section { Id = 2, Name = "Nike", Order = 0, ParentId = 1 },
              new Section { Id = 3, Name = "Under Armour", Order = 1, ParentId = 1 },
              new Section { Id = 4, Name = "Adidas", Order = 2, ParentId = 1 },
              new Section { Id = 5, Name = "Puma", Order = 3, ParentId = 1 },
              new Section { Id = 6, Name = "ASICS", Order = 4, ParentId = 1 },
              new Section { Id = 7, Name = "Men", Order = 1 },
              new Section { Id = 8, Name = "Fendi", Order = 0, ParentId = 7 },
              new Section { Id = 9, Name = "Guess", Order = 1, ParentId = 7 },
              new Section { Id = 10, Name = "Valentino", Order = 2, ParentId = 7 },
              new Section { Id = 11, Name = "Dior", Order = 3, ParentId = 7 },
              new Section { Id = 12, Name = "Versace", Order = 4, ParentId = 7 },
              new Section { Id = 13, Name = "Armani", Order = 5, ParentId = 7 },
              new Section { Id = 14, Name = "Prada", Order = 6, ParentId = 7 },
              new Section { Id = 15, Name = "Dolce and Gabbana", Order = 7, ParentId = 7 },
              new Section { Id = 16, Name = "Chanel", Order = 8, ParentId = 7 },
              new Section { Id = 17, Name = "Gucci", Order = 9, ParentId = 7 },
              new Section { Id = 18, Name = "Women", Order = 2 },
              new Section { Id = 19, Name = "Fendi", Order = 0, ParentId = 18 },
              new Section { Id = 20, Name = "Guess", Order = 1, ParentId = 18 },
              new Section { Id = 21, Name = "Valentino", Order = 2, ParentId = 18 },
              new Section { Id = 22, Name = "Dior", Order = 3, ParentId = 18 },
              new Section { Id = 23, Name = "Versace", Order = 4, ParentId = 18 },
              new Section { Id = 24, Name = "Kids", Order = 3 },
              new Section { Id = 25, Name = "Fashion", Order = 4 },
              new Section { Id = 26, Name = "Home", Order = 5 },
              new Section { Id = 27, Name = "Interior", Order = 6 },
              new Section { Id = 28, Name = "Сlothing", Order = 7 },
              new Section { Id = 29, Name = "Handbags", Order = 8 },
              new Section { Id = 30, Name = "Shoes", Order = 9 },
        };

        public static IEnumerable<Brand> Brands { get; } = new[]
        {
            new Brand { Id = 1, Name = "Acne", Order = 0 },
            new Brand { Id = 2, Name = "Grune Erde", Order = 1 },
            new Brand { Id = 3, Name = "Albiro", Order = 2 },
            new Brand { Id = 4, Name = "Ronhill", Order = 3 },
            new Brand { Id = 5, Name = "Oddmolly", Order = 4 },
            new Brand { Id = 6, Name = "Boudestijn", Order = 5 },
            new Brand { Id = 7, Name = "Rosch creative culture", Order = 6 },
        };

        public static IEnumerable<Product> Products { get; } = new[]
        {
            new Product { Id = 1, Name = "Белое платье", Price = 1025, ImageUrl = "product1.jpg", Order = 0, SectionId = 2, BrandId = 1 },
            new Product { Id = 2, Name = "Розовое платье", Price = 1025, ImageUrl = "product2.jpg", Order = 1, SectionId = 2, BrandId = 1 },
            new Product { Id = 3, Name = "Красное платье", Price = 1025, ImageUrl = "product3.jpg", Order = 2, SectionId = 2, BrandId = 1 },
            new Product { Id = 4, Name = "Джинсы", Price = 1025, ImageUrl = "product4.jpg", Order = 3, SectionId = 2, BrandId = 1 },
            new Product { Id = 5, Name = "Лёгкая майка", Price = 1025, ImageUrl = "product5.jpg", Order = 4, SectionId = 2, BrandId = 2 },
            new Product { Id = 6, Name = "Лёгкое голубое поло", Price = 1025, ImageUrl = "product6.jpg", Order = 5, SectionId = 2, BrandId = 1 },
            new Product { Id = 7, Name = "Платье белое", Price = 1025, ImageUrl = "product7.jpg", Order = 6, SectionId = 2, BrandId = 1 },
            new Product { Id = 8, Name = "Костюм кролика", Price = 1025, ImageUrl = "product8.jpg", Order = 7, SectionId = 25, BrandId = 1 },
            new Product { Id = 9, Name = "Красное китайское платье", Price = 1025, ImageUrl = "product9.jpg", Order = 8, SectionId = 25, BrandId = 1 },
            new Product { Id = 10, Name = "Женские джинсы", Price = 1025, ImageUrl = "product10.jpg", Order = 9, SectionId = 25, BrandId = 3 },
            new Product { Id = 11, Name = "Джинсы женские", Price = 1025, ImageUrl = "product11.jpg", Order = 10, SectionId = 25, BrandId = 3 },
            new Product { Id = 12, Name = "Летний костюм", Price = 1025, ImageUrl = "product12.jpg", Order = 11, SectionId = 25, BrandId = 3 },
        };
    }
}
