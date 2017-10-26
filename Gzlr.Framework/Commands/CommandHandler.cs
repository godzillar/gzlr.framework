using System;
using System.Windows.Input;

namespace Gzlr.Framework.Commands
{
    public class CommandHandler : ICommand
    {
        private Action _action;
        private bool _canExecute;

        /// <summary>
        /// Creates a new instance of the <see cref="CommandHandler"/>
        /// </summary>
        /// <param name="action"></param>
        /// <param name="canExecute"></param>
        public CommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }
    }
}