using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core
{
    internal class ObservalObject : INotifyPropertyChanged
    {
        // изменение пользовательского элемента при привязке
        public event PropertyChangedEventHandler PropertyChanged;
        // изменение свойств

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
