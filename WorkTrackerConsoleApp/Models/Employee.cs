using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Models
{
    //      child       parent
    class Employee : Person
    {
        int salery;
        public int Salery { get { return salery; } set { salery = value; } }

        protected string[] workLoad;

        public Employee(int id, string name, int salery) : base(id, name)
        {
            workLoad = new string[0];
            this.salery = salery;
        }

        public new string Info()
        {
            return base.Info() + $"Salery: {salery} per/month\n";
        }

        public virtual string[] WorkToDo()
        {
            return workLoad;
        }

        public void AddWorkTask(string newTask)
        {
            Array.Resize(ref workLoad, workLoad.Length + 1);
            workLoad[workLoad.Length - 1] = newTask;
        }
    }
}
