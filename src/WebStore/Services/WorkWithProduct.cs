using System.Collections.Generic;
using System.Linq;
using WebStore.Data.MockData;
using WebStore.Domain;
using WebStore.Domain.Entities;
using WebStore.Services.Interfaces;

namespace WebStore.Services
{
    public class WorkWithProduct : IProduct
    {
        public IEnumerable<Brand> GetBrands() => MockData.Brands;


        public IEnumerable<Section> GetSections() => MockData.Sections;

        public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        {
            IEnumerable<Product> query = MockData.Products;

            if (Filter?.SectionId is { } sectionId)
                query = query.Where(product => product.SectionId == sectionId);

            if (Filter?.BrandId is { } brandId)
                query = query.Where(product => product.BrandId == brandId);

            return query;
        }
    }
}
