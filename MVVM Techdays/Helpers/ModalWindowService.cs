using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Techdays.Helpers
{
    public static class ModalWindowService
    {
        public static bool? Show(object item)
        {
            ModalWindow modalWindow = new ModalWindow { DataContext = item };
            return modalWindow.ShowDialog();
        }
    }
}
