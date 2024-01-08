using JetBrains.Annotations;

namespace Patterns.Command
{
    public class AddEmployeeToManagerList : ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private readonly int _manageId;
        [CanBeNull] private readonly Employee _employee;

        public AddEmployeeToManagerList(
            IEmployeeManagerRepository employeeManagerRepository,
            int manageId,
            [CanBeNull] Employee employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _manageId = manageId;
            _employee = employee;
        }

        public void Execute()
        {
            if (_employee == null)
            {
                return;
            }
            _employeeManagerRepository.AddEmployee(_manageId, _employee);
        }

        public void Undo()
        {
            if (_employee == null)
            {
                return;
            }
            _employeeManagerRepository.RemoveEmployee(_manageId, _employee);
        }

        public bool CanExecute()
        {
            if (_employee == null)
            {
                return false;
            }

            if (_employeeManagerRepository.HasEmployee(_manageId, _employee.Id))
            {
                return false;
            }

            return true;
        }
    }
}