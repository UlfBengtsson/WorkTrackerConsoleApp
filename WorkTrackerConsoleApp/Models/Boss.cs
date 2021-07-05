using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Models
{
    class Boss : Employee
    {
        Employee[] manageEmplyees;

        public Boss(int id, string name, int salery, Employee[] manageEmplyees) : base(id, name, salery)
        {
            this.manageEmplyees = manageEmplyees;
        }

        public override string[] WorkToDo()
        {
            string[] workToDo = new string[workLoad.Length];
            workLoad.CopyTo(workToDo,0);
            Array.Resize(ref workToDo, manageEmplyees.Length + workToDo.Length);

            int index = workLoad.Length;
            foreach (Employee employee in manageEmplyees)
            {
                workToDo[index] = "Manage: " + employee.Name;
                index++;
            }

            return workToDo;
        }
    }
}
