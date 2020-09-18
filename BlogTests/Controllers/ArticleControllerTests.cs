using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Principal;
using BlogContext;
using BlogData.Entities;
using BlogData.ViewModels;
using BlogFakes;
using BlogMvc.Controllers;
using BlogServices;
using FakeItEasy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace BlogTests.Controllers
{
    public class ArticleControllerTests
    {
        private readonly User user = new User { Id = 1, Email = "q@q.com", Password = "lalalala1!" };
        private readonly Article article = new Article { Id = 1, UserId = 1, Author = "q@q.com", Content = "test-article-content", Date = DateTime.Now, Title = "test-article-title" };
        private readonly Comment comment = new Comment { Id = 1, ArticleId = 1, UserId = 1, Date = DateTime.Now, Content = "test-comment-content", Author = "q@q.com" };
        
        private List<User> Users => new List<User> { user };
        private List<Article> Articles => new List<Article> { article };
        private List<Comment> Comments => new List<Comment> { comment };

        private IBlogDbContext fakeBlog;
        private IHttpContextAccessor httpContextAccessor;
        private DefaultHttpContext context;
        private GenericIdentity fakeIdentity;
        private GenericPrincipal principal;

        private ArticleController articleController;

        [SetUp]
        public void Setup()
        {  
            var fakeUserDbSet = new FakeUserDbSet() { data = new ObservableCollection<User>(Users) };
            var fakeArticleDbSet = new FakeArticleDbSet() { data = new ObservableCollection<Article>(Articles) };
            var fakeCommentDbSet = new FakeCommentDbSet() { data = new ObservableCollection<Comment>(Comments) };

            fakeBlog = A.Fake<IBlogDbContext>();
            httpContextAccessor = A.Fake<IHttpContextAccessor>();
            context = new DefaultHttpContext();
            fakeIdentity = A.Fake<GenericIdentity>();
            principal = A.Fake<GenericPrincipal>();

            A.CallTo(() => fakeBlog.Users).Returns(fakeUserDbSet);
            A.CallTo(() => fakeBlog.Articles).Returns(fakeArticleDbSet);
            A.CallTo(() => fakeBlog.Comments).Returns(fakeCommentDbSet);

            A.CallTo(() => principal.Identity).Returns(fakeIdentity);

            // test something

            A.CallTo(() => fakeIdentity.Name).Returns("1");
            context.User = principal;
            A.CallTo(() => httpContextAccessor.HttpContext).Returns(context);

            articleController = new ArticleController(fakeBlog)
            {
                ControllerContext = new ControllerContext { HttpContext = httpContextAccessor.HttpContext }
            };
        }

        [Test]
        public void GET_Add_GetArticleView_ShouldReturnView()
        {
            var result = articleController.Add() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void POST_Add_AddValidArticle_ShouldReturnRedirectToAction()
        {
            var article = new Article { Id = 2, UserId = 2, Author = "q2@q.com", Content = "test-article-content2", Date = DateTime.Now, Title = "test-article-title2" };

            var result = articleController.Add(article) as RedirectToActionResult;

            Assert.IsInstanceOf<RedirectToActionResult>(result);
            Assert.AreEqual("GetById", result.ActionName);
            Assert.AreEqual("User", result.ControllerName);
        }

        [Test]
        public void GET_Update_ArticleDoesNotExistInDb_ShouldReturnNotFound()
        {
            var result = articleController.Update(11) as NotFoundResult;

            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        // public IActionResult Update(int id)
        // {
        //     var article = _blogDbContext.Articles.Find(id);
        //     if (article == null || !article.UserId.ToString().Equals(User.Identity.Name))
        //         return NotFound();
            
        //     return View(article);
        // }

    }
}