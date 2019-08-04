using OnlineSchool.DataBinding.Commands;
using OnlineSchool.DataBinding.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OnlineSchool.DataBinding
{
    public class ActionViewModel : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private DateTimeOffset completeDate;
        public ActionType ActionType { get; set; }
        public ICommand CancelCommand { get; set; }

        public ActionViewModel()
        {
            CancelCommand = new CancelCommand();
        }

        public string ActionName
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(ActionName)));
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(Description)));
            }
        }
        public DateTimeOffset CompleteDate
        {
            get => completeDate;
            set
            {
                completeDate = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(CompleteDate)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
