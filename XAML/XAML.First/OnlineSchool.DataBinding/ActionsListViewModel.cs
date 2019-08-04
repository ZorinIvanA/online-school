using OnlineSchool.DataBinding.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace OnlineSchool.DataBinding
{
    public class ActionsListViewModel
    {
        public ObservableCollection<ActionViewModel> Actions { get; set; }
        public ICommand AddElement { get; set; }
        public ActionsListViewModel()
        {
            AddElement = new AddActionCommand();
            Actions = new ObservableCollection<ActionViewModel>();
            Actions.Add(new ActionViewModel
            {
                ActionName = "Действие 1",
                CompleteDate = DateTime.Parse("2050-01-01")
            });
            Actions.Add(new ActionViewModel
            {
                ActionName = "Действие 2",
                CompleteDate = DateTime.Now
            });
            Actions.Add(new ActionViewModel
            {
                ActionName = "Действие 3",
                CompleteDate = new DateTime(1900, 1, 1)
            });

            foreach (var action in Actions)
            {
                if (action.CompleteDate.Date < DateTime.Now.Date)
                    action.PassedColor = new SolidColorBrush(Colors.Red);
                else if (action.CompleteDate.Date == DateTime.Now.Date)
                    action.PassedColor = new SolidColorBrush(Colors.Yellow);
                else
                    action.PassedColor = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
