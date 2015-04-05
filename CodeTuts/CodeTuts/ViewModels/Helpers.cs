using CodeTuts.Model.Models;
using CodeTuts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTuts.Web.ViewModels
{
    public static class Helpers
    {
        public static User UserVMToModel(UserViewModel UserVM)
        {
            User user = new User();

            user.RealName = UserVM.RealName;
            user.DOB = UserVM.DOB;
            user.Email = UserVM.Email;
            user.ObjectState = UserVM.ObjectState;

            return user;
        }

        public static UserViewModel UserModelToVM(User user)
        {
            UserViewModel UserVM = new UserViewModel();

            UserVM.RealName = user.RealName;
            UserVM.DOB = user.DOB;
            UserVM.Email = user.Email;
            UserVM.ObjectState = user.ObjectState;

            return UserVM;
        }

        public static NewsPost NewsPostVMToNewsPost(NewsPostViewModel newsVM)
        {
            NewsPost news = new NewsPost();

            news.NewsId = newsVM.NewsId;
            news.NewsContent = newsVM.NewsContent;
            news.NewsAuthor = newsVM.NewsAuthor;
            news.UserId = newsVM.UserId;
            news.ObjectState = newsVM.ObjectState;
            news.LogDate = newsVM.LogDate;

            return news;
        }

        public static NewsPostViewModel NewsPostToNewsPostVM(NewsPost news)
        {
            NewsPostViewModel newsVM = new NewsPostViewModel();

            newsVM.NewsId = news.NewsId;
            newsVM.NewsContent = news.NewsContent;
            newsVM.NewsAuthor = news.NewsAuthor;
            newsVM.UserId = news.UserId;
            newsVM.ObjectState = news.ObjectState;
            newsVM.LogDate = news.LogDate;

            return newsVM;
        }
    }
}