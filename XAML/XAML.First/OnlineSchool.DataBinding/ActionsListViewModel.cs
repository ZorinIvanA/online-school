using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.DataBinding
{
    public class ActionsListViewModel
    {
        public ActionViewModel[] Actions { get; set; }
        public int[,] Actions2 { get; set; }

        public ActionsListViewModel()
        {
            Actions2 = new int[4, 7];
            Actions2[3,1] = 2; 

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
        }
    }
}
