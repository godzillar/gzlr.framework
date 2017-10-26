using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Gzlr.Framework.Commands;
using Gzlr.Framework.Interfaces;
using Gzlr.Service.Interfaces;

namespace Gzlr.Framework.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private readonly IClass1 _class1;
        private int x;

        public string Name
        {
            get => _class1.Name;
            set
            {
                _class1.Name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public ICommand Command => new CommandHandler(Action, true);

        public MainViewModel(IClass1 class1)
        {
            _class1 = class1;
            x = 0;
        }

        public void Action()
        {
            Name = $"Something else {x++}";
        }
    }
}