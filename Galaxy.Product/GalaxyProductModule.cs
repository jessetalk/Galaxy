using Galaxy.Product.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Galaxy.Product
{
    [DependsOn(typeof(GalaxyProductAbstractionModule))]
    public class GalaxyProductModule: AbpModule
    {

    }
}
