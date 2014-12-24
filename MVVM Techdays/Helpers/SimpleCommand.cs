using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Techdays.Helpers
{
    public class SimpleCommand : ICommand
    {
        private Action action;
        
        public SimpleCommand(Action action)
        {
            this.action = action;
        }
        
        public virtual bool CanExecute(object parameter)
        {
            return true;
        }
        
        public void RaiseCanExecuteChanged()
        {
            if(CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public event System.EventHandler CanExecuteChanged;
        
        public virtual void Execute(object parameter)
        {
            this.action();
        }
    }
}
