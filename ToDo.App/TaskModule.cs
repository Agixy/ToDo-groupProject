using Ninject.Modules;
using ToDo.App.ViewModels;

namespace ToDo.App
{
    public class TaskModule : NinjectModule

    {
        public override void Load()
        {
            Bind<ITaskMapper>().To<TaskMapper>();
        }
    }
}
