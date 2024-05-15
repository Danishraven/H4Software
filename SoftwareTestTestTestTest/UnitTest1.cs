

using Bunit;
using Bunit.TestDoubles;
using H4Software.Components.Pages;

namespace SoftwareTestTestTestTest
{
    public class UnitTest1
    {
        [Fact]
        public void AuthenticationView()
        {
            //Arange
            var ctx = new TestContext();
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("");

            //Act
            var cut = ctx.RenderComponent<Home>();

            //Assert
            cut.MarkupMatches("<h1>Hello, world!</h1>\r\n<br />\r\n<div>Hello again</div>");
        }
    }
}