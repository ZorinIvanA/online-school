using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OnlineSchool.DataBinding.Commands
{
    public class AddActionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var actionsList = parameter as ObservableCollection<ActionViewModel>;
            if (actionsList == null)
                return;

            actionsList.Add(new ActionViewModel());
        }
    }
}
