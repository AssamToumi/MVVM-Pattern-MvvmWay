namespace Mvvm.Session01.Command
{
    using System;
    using System.Windows.Input;
    public class MVVMCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public MVVMCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentException("Execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public MVVMCommand(Action execute)
            : this(execute, null)
        { }
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute();
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }
        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
