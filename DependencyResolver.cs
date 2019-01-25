using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace DIMVCPracticeUpdated
{
    public class DependencyResolver : IDependencyResolver
    {

        //sample video https://www.youtube.com/watch?v=i4q_zHothhw
        readonly IUnityContainer _container;
        
        public DependencyResolver(IUnityContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType) => !_container.IsRegistered(serviceType) ? null : _container.Resolve(serviceType);

        public IEnumerable<object> GetServices(Type serviceType) => !_container.IsRegistered(serviceType) ? new List<object>() : _container.ResolveAll(serviceType);
    }
}