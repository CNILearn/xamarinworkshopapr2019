using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TheBestMVVMLibraryInTown
{
    public class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public DelegateCommand(Action execute)
            : this(execute, null)
        {
        }

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;
        public void Execute(object parameter) => _execute();

        public void OnExecuteChanged() => CanExecuteChanged?.Invoke(this, new EventArgs());
    }
}
