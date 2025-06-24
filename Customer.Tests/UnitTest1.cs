using Xunit;
using Bunit;

namespace Customer.Tests
{
    public class BlazorUiTests : TestContext
    {
        [Fact]
        public void HomePage_Renders()
        {
            var cut = RenderComponent<Customer.Components.Pages.Home>();
            cut.MarkupMatches("<h1>Hello, world!</h1>"); // Adjust as needed for actual markup
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }
}