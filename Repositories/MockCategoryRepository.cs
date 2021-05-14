using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1,CategoryName="Man parfumes",Description="Short description" },
                     new Category{CategoryId=2,CategoryName="Women parfumes",Description="Short description" }

                };
            }
        }
    }
}
