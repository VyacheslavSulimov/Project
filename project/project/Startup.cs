﻿using Microsoft.Owin;
using Owin;
// test 
[assembly: OwinStartupAttribute(typeof(project.Startup))]
namespace project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
