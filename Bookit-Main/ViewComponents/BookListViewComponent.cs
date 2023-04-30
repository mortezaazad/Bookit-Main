using Bookit_Main.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookit_Main.ViewComponents
{
    public class BookListViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public BookListViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           var model= _db.Books.Take(4).ToList();
            return View(model);
        }
    }
}
