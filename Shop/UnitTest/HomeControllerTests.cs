using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shop.WebUI.Controllers;
using Shop.Core.Contracts;
using Shop.Core.Models;
using System.Web.Mvc;
using Shop.Core.View_Model;

namespace UnitTest
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexPageDoesReturnProduct()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategoryContext = new Mocks.MockContext<ProductCategory>();
            HomeController controller = new HomeController(productContext, productCategoryContext);

            var result = controller.Index() as ViewResult;
            var viewModel = (ProductListViewModel) result.ViewData.Model;
        }
    }
}
