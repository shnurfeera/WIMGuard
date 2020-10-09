using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Project.WIM.Pages
{
    public class Index_Tests : WIMWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
