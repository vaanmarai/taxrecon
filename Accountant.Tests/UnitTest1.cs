using Xunit;
using Bunit;

namespace Accountant.Tests
{
    public class BlazorUiTests : TestContext
    {
        [Fact]
        public void HomePage_Renders()
        {
            var cut = RenderComponent<Accountant.Components.Pages.Home>();
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