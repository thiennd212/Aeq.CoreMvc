using Microsoft.AspNetCore.Builder;
using Aeq.CoreMvc;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Aeq.CoreMvc.Web.csproj");
await builder.RunAbpModuleAsync<CoreMvcWebTestModule>(applicationName: "Aeq.CoreMvc.Web" );

public partial class Program
{
}
