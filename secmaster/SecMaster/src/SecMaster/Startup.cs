using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Xml;
using Microsoft.Framework.ConfigurationModel;

namespace SecMaster
{
    public class Startup
    {
        public Startup()
        {
            Configuration = new Configuration()
            .AddJsonFile("config.json")
            .AddEnvironmentVariables();
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();// (Configuration);

            // one a few ways to remove XML formatters or force JSON
            // see http://blogs.msdn.com/b/webdev/archive/2014/11/24/content-negotiation-in-mvc-5-or-how-can-i-just-write-json.aspx
            services.Configure<MvcOptions>(options =>
                                                options
                                                    .OutputFormatters
                                                    .ToList()
                                                    .RemoveAll(formatter => formatter.Instance is XmlDataContractSerializerOutputFormatter)
                                           );

            //configure the options <classname> and bind from the configuration, uses the IOptions interface Microsoft.Framework.OptionsModel
            services.Configure<Settings>(Configuration);

            //add the security repository to the service collection
            services.AddSingleton<ISecurityRespository, SecurityRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseWelcomePage();
        }
    }
}
