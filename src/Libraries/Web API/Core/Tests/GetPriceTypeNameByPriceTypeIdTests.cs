// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetPriceTypeNameByPriceTypeIdTests
    {
        public static GetPriceTypeNameByPriceTypeIdController Fixture()
        {
            GetPriceTypeNameByPriceTypeIdController controller = new GetPriceTypeNameByPriceTypeIdController(new GetPriceTypeNameByPriceTypeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetPriceTypeNameByPriceTypeIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}