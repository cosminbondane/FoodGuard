using FoodGuard.Email.Provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Tests.Email
{
    [TestClass]
    public class EmailTest
    {
        public EmailTest()
        {
            DependencyServiceInjection.RegisterType(typeof(BaseDapperRepository<>), typeof(BaseDapperRepository<>));
        }

        [TestMethod]
        public void SingleEmailTest()
        {
            CharityEmailProvider CharityEmailProvider = new CharityEmailProvider();
            CharityEmailProvider.StartForOne("cbondane@smallfootprint.com");

        }
    }
}
