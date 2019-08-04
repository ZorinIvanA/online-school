using OnlineSchool.DataBinding.Enums;
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
            if (commandParam == null)
                return;

            Debug.WriteLine(commandParam?.CompleteDate);
            Debug.WriteLine(commandParam?.ActionName ?? NOT_FOUND);
            Debug.WriteLine(commandParam?.Description ?? NOT_FOUND);

            switch (commandParam.ActionType)
            {
                case ActionType.Private:
                    Debug.WriteLine("Личное");
                    break;
                case ActionType.Job:
                    {
                        Debug.WriteLine("Рабочее");
                    }
                    break;
                case ActionType.Education:
                    {
                        Debug.WriteLine("Учёба");
                    }
                    break;
                default:
                    {
                        Debug.WriteLine("Неизвестно");
                    }
                    break;
            }
        }
    }
}
