﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fusonic.Web.Mvc.RuntimeController;
using System.Web.Mvc;
using Ninject;

namespace Hotwist.Web.Infra
{
    public class RuntimeDependencyInjector : IDependencyInjector
    {
        public IKernel Kernel { get; private set; }

        public RuntimeDependencyInjector()
        {
            Kernel = new StandardKernel(new HotwistNinjectModule());
        }

        public IController CreateControllerInstance(Type controllerType)
        {
            if (controllerType == null)
            {
                return null;
            }
            return Kernel.Get(controllerType) as IController;
        }
    }
}