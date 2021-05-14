using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;
using ParfumeOnlineShop.ViewModel;

namespace ParfumeOnlineShop.Controllers
{
    public class ParfumeController : Controller
    {
        private readonly IParfumeRepository _parfumeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ParfumeController(IParfumeRepository parfumeRepository, ICategoryRepository categoryRepository)
        {
            _parfumeRepository = parfumeRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            //ViewBag.Category = "Women";            //1.put
            //return View(_parfumeRepository.Parfumes);

            //ParfumeListViewModel parfumeListViewModel = new ParfumeListViewModel();  //2.put
            //parfumeListViewModel.Parfumes = _parfumeRepository.Parfumes;
            //parfumeListViewModel.CurrentCategory = "Women parfumes";

            //return View(parfumeListViewModel);

            IEnumerable<Parfume> parfumes;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                parfumes = _parfumeRepository.Parfumes.OrderBy(p => p.ParfumeId);
                currentCategory = "All parfumes";
            }
            else
            {
                parfumes = _parfumeRepository.Parfumes.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ParfumeId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            return View(new ParfumeListViewModel
            {
                Parfumes = parfumes,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var parfume = _parfumeRepository.GetParfumeById(id);

            if (parfume == null)
            {
                return NotFound();
            }
            return View(parfume);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}