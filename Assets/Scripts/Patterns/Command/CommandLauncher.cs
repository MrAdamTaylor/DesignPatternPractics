using UnityEngine;

namespace Patterns.Command
{
    public class CommandLauncher : DesignPatternLauncher 
    {
        public override void Launch()
        {
            Debug.Log("Паттерн комманда: ");
        
            CommandManager commandManager = new();
            IEmployeeManagerRepository repository = new EmployeeManagerRepository();
        
            commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(111,"Kevin")));
            repository.WriteDataStore();
        
            commandManager.Undo();
            repository.WriteDataStore();
        
            commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(222,"Sarah")));
            repository.WriteDataStore();
        
            commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(333,"Oleg")));
            repository.WriteDataStore();
        
            commandManager.UndoAll();
            repository.WriteDataStore();
        }
    }
}