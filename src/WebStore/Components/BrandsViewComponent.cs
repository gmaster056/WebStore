using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Services.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProduct _Product;

        public BrandsViewComponent(IProduct Product) => _Product = Product;

        public IViewComponentResult Invoke()
        {
            var brands = _Product.GetBrands()
                .OrderBy(b => b.Order)
                .Select(b => new BrandViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                });

            return View(brands);
        }
    }
}