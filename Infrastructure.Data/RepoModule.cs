using Ninject.Modules;

namespace Infrastructure.Data
{
    public class RepoModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(MarryDBContext)).To(typeof(MarryRepository<>));
        }
        
    }
}
