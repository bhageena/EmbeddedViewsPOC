using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using RazorLight;

namespace RazorClassLibary
{
    public class Forecaster
    {


        public async Task<string> Get()
        {


            // Embedded Path 
            // Works when dependecy is reffered as package or dll reference
            var engine = new RazorLightEngineBuilder()
                .UseEmbeddedResourcesProject(typeof(Forecaster))
                .UseMemoryCachingProvider()
                .EnableDebugMode(true)
                .Build();
            var result = await engine.CompileRenderAsync<object>("Views.MyFeature.page", new object());


            // File based path   
            // Works when dependecy is reffered as project reference
            // string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Views");
            // var engine = new RazorLightEngineBuilder()
            //           .UseFileSystemProject(path)
            //           .UseMemoryCachingProvider()
            //           .Build();

            // var result = await engine.CompileRenderAsync(Path.Combine(path, "MyFeature", "page.cshtml"), new object());

            return result;
        }
    }
}
