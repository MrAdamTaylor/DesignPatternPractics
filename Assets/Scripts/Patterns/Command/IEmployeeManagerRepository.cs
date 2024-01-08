using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Patterns.Command
{
    public interface IEmployeeManagerRepository
    {
        void AddEmployee(int managerId, Employee employee);

        void RemoveEmployee(int managerId, Employee employee);

        bool HasEmployee(int managerId, int emloyeeId);

        void WriteDataStore();
    }

    class EmployeeManagerRepository : IEmployeeManagerRepository
    {
        private List<Manager> _managers = new List<Manager>()
            {new Manager(1, "Katie"), new Manager(2, "Geoff")};
    
        public void AddEmployee(int managerId, Employee employee)
        {
            _managers.First(m => m.Id == managerId).Employees.Add(employee);
        }

        public void RemoveEmployee(int managerId, Employee employee)
        {
            _managers.First(m => m.Id == managerId).Employees.Remove(employee);
        }

        public bool HasEmployee(int managerId, int emloyeeId)
        {
            return _managers.First(m => m.Id == managerId)
                .Employees.Any(e => e.Id == emloyeeId);
        }

        public void WriteDataStore()
        {
            foreach (var manager in _managers)
            {
                Debug.Log($"Менеджер: {manager.Id},{manager.Name}");
                if (manager.Employees.Any())
                {
                    foreach (var employe in manager.Employees)
                    {
                        Debug.Log($"Сотрудник {employe.Id}, {employe.Name}");
                    }
                }
                else
                {
                    Debug.Log($"Нет сотрудников");
                }
            }
        }
    }
}