using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }
        public int UserID { get; set; }

        public override string ToString()
        {
            return $"ID:[{TaskID}] | {Name}, {Description}, {Priority}, {IsCompleted}";
        }
    }
}
