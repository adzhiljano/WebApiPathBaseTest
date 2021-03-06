﻿using Owin;
using System;
using System.Web.Http;

namespace WebApi.OwinSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>("http://localhost:9002/test api"))
            {
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}
