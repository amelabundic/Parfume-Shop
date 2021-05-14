using ParfumeOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeOnlineShop.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Parfume> ParfumesOfTheMonth { get; set; }
    }
}
