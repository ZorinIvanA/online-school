using System;
using System.Diagnostics;
using System.Windows.Input;

namespace OnlineSchool.DataBinding.Commands
{
    public class CancelCommand : ICommand
    {
        const string NOT_FOUND = "Не определено";
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine("Command executed");
            var commandParam = parameter as ActionViewModel;

            Debug.WriteLine(commandParam?.CompleteDate);
            Debug.WriteLine(commandParam?.ActionName ?? NOT_FOUND);
            Debug.WriteLine(commandParam?.Description ?? NOT_FOUND);
        }
    }
}
