using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    public class FromDatabaseModel : PageModel
    {
        private readonly ILogger<FromDatabaseModel> _logger;
        private readonly ProductContext _context;
        public IList<Product> ProductsList { get; set; }

        public FromDatabaseModel(ILogger<FromDatabaseModel> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;
            ProductsList = _context.Products.ToList();
        }

        public void OnGet()
        { }
    }
}
