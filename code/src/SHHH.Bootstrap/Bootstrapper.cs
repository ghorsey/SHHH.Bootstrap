using System.Collections.Generic;
using Microsoft.Practices.ServiceLocation;
using System.Linq;
namespace SHHH.Bootstrap
{
    public class Bootstrapper
    {
        private readonly object Container;

        public Bootstrapper(object container)
        {
            Container = container;
        }
        public T GetContainer<T>() where T : class
        {
            return Container as T;
        }

        public void Run()
        {
            foreach (IBootstrapTask task in ServiceLocator.Current.GetAllInstances<IBootstrapTask>().OrderBy(x=>x.Order))
                task.Execute(this);
        }
    }
}
