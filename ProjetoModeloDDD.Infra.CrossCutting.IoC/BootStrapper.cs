using System;
using System.Collections.Generic;
using System.Text;
using SimpleInjector;

namespace ProjetoModeloDDD.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //container.Register<ApplicationDbContext>(Lifestyle.Scoped);
        }
    }
}
