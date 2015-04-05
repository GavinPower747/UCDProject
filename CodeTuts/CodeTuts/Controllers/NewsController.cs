using CodeTuts.DataLayer;
using CodeTuts.ViewModels;
using CodeTuts.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using CodeTuts.Web.Models;
using CodeTuts.Model.Models;

namespace CodeTuts.Web.Controllers
{
    public class NewsController : ApiController
    {
        private TutsContext _tutsContext;

        public NewsController()
        {
            _tutsContext = new TutsContext();
        }

        [HttpGet]
        [Authorize]
        public List<NewsPostViewModel> Get()
        {
            List<NewsPostViewModel> newsVM = new List<NewsPostViewModel>();

            foreach(NewsPost news in _tutsContext.NewsPosts)
            {
                NewsPostViewModel VM = ViewModels.Helpers.NewsPostToNewsPostVM(news);
                newsVM.Add(VM);
            }

            return newsVM;
        }

        [HttpPost]
        [Authorize]
        public string Insert(NewsPostViewModel news)
        {
            return "Passed";
        }

        [HttpDelete]
        [Authorize]
        public void Delete(NewsPostViewModel news)
        {

        }

        private string save(NewsPostViewModel news)
        {
            return "Passed";
        }
    }
}