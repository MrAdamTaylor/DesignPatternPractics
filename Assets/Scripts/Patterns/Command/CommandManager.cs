using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Patterns.Command
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();
        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                command.Execute();
                _commands.Push(command);
            }
        }

        public void Undo()
        {
            Debug.Log("Использована команда: Отменить!");
            if (_commands.Any())
            {
                _commands.Pop()?.Undo();
            }
        }

        public void UndoAll()
        {
            Debug.Log("Использована команда: Отменить всё!");
            while (_commands.Any())
            {
                _commands.Pop()?.Undo();
            }
        }
    }
}