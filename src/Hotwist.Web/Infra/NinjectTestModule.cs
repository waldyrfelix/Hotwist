using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;

namespace Hotwist.Web.Infra
{
    public class HotwistNinjectModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IMessageProvider>().To<MessageProvider>();
        }
    }
}