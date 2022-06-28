using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEmpty
{
    /*
     * MVC 패턴
     * M (Model)        데이터
     * V (View)         UI
     * C (Controller)    Controller 액션
     * 
     * 
     * Razor
     * M        모델
     * VC       뷰컨트롤러
     * M - V -VM
     * 
     * WebAPI
     * M
     * C
     * 
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
