using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PokerBoard
{
    public class RelayCommand : ICommand
    {
        private Action mAction;

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object?)"/> value has changed
        /// </summary>
        public event EventHandler? CanExecuteChanged = (sender, e) => { };
        //Default Constructor
        public RelayCommand(Action action) 
        { 
            mAction = action;
        }


        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            mAction();
        }
    }
}
