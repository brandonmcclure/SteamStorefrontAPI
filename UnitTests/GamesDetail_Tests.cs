using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using SteamStorefrontAPI.Classes.userdetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    class GamesSummary_Tests
    {
        [TestMethod]
        public void GetAsync_CanSerializeJSONResultToOurModel()
        {
            //https://gingter.org/2018/07/26/how-to-mock-httpclient-in-your-net-c-unit-tests/


            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
               .Protected()
               // Setup the PROTECTED method to mock
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>()
               )
               // prepare the expected response of the mocked http call
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(@"{'response':{'game_count':2,'games':[{'appid':1,'playtime_forever':5},{'appid':2,'playtime_forever':10}]}}"),
               })
               .Verifiable();

            HttpClient hClient = new HttpClient(handlerMock.Object) { BaseAddress = new Uri("http://www.test.com") };
            var actual = UserDetails.GetAsync("nonsenseAPI", 123456, false, false, hClient).Result;

            var expected = new GamesSummary() { game_count = 2, games = new UserGameStat[] { new UserGameStat() { appid = 1, playtime_forever = 5 }, new UserGameStat() { appid = 2, playtime_forever = 10 } } };

            Assert.AreEqual(expected.game_count, actual.game_count);
        }
    }
}
