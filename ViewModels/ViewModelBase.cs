using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Simple.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged //возвращает изменения
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string properyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));

    }
}
