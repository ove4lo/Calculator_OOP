using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_Simple.Commands
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> _executeAction; //инкапсулирует метод, который принимает один параметр и не возвращает значения

        public RelayCommand(Action<object> excutionAction)
        {
            _executeAction = excutionAction;
        }
        public bool CanExecute(object parameter) => true; //проверка на возможность выполнения

        public void Execute(object parameter) => _executeAction(parameter); //определение метода, при вызове данной команды

        public event EventHandler CanExecuteChanged //метод, обрабатывающий события без данных
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }
    }
}
