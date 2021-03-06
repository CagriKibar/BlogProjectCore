using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetBlogByWriter(1);
                return View(values);

        }
    }
}
