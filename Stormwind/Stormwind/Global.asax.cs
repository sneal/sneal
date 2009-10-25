﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Web;
using Autofac;
using Autofac.Integration.Web.Mvc;
using System.Reflection;

namespace Stormwind
{
    public class MvcApplication : HttpApplication, IContainerProviderAccessor
    {
        private static Bootstrap _bootstrap = new Bootstrap();

        protected void Application_Start()
        {
            lock (typeof(MvcApplication))
            {
                _bootstrap
                    .DependencyInjectionContainer()
                    .MvcRoutes();
            }
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            // Is this handled by the Autofac ContainerDisposalModule?
            ContainerProvider.EndRequestLifetime();
        }

        public IContainerProvider ContainerProvider
        {
            get { return _bootstrap.ContainerProvider; }
        }
    }
}