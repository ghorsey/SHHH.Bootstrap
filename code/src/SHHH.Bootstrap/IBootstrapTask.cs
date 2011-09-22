
namespace SHHH.Bootstrap
{
    public interface IBootstrapTask
    {
        int Order { get; }
        void Execute(Bootstrapper bootstrapper);
    }
}
