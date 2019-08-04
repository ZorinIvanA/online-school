using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace OnlineSchool.DataBinding
{
    public class ActionsListViewModel
    {
        public ActionViewModel[] Actions { get; set; }

        public ActionsListViewModel()
        {
            Actions = new ActionViewModel[3];
            Actions[0] = new ActionViewModel
            {
                ActionName = "Действие 1",
                CompleteDate = DateTime.Parse("2050-01-01")
            };
            Actions[1] = new ActionViewModel
            {
                ActionName = "Действие 2",
                CompleteDate = DateTime.Now
            };
            Actions[2] = new ActionViewModel
            {
                ActionName = "Действие 3",
                CompleteDate = new DateTime(1900, 1, 1)
            };

            for (int i = 0; i < Actions.Length; i++)
            {
                if (Actions[i].CompleteDate.Date < DateTime.Now.Date)
                    Actions[i].PassedColor = new SolidColorBrush(Colors.Red);
                else if (Actions[i].CompleteDate.Date == DateTime.Now.Date)
                    Actions[i].PassedColor = new SolidColorBrush(Colors.Yellow);
                else
                    Actions[i].PassedColor = new SolidColorBrush(Colors.Green);              
            }
        }
    }
}
