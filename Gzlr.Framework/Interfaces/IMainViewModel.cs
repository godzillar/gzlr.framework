using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace Gzlr.Framework.Interfaces
{
    public interface IMainViewModel
    {
        string Name { get; }

        ICommand Command { get; }
    }
}