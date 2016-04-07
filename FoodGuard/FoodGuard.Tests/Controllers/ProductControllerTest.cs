using FoodGuard.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetCartTypes()
        {
            // Arrange
            ProductController controller = new ProductController();
            var result = controller.GetProducts();

            //// Assert
            Assert.IsNotNull(result);
        }
    }
}
