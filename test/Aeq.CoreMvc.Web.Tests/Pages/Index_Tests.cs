using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Aeq.CoreMvc.Pages;

public class Index_Tests : CoreMvcWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
