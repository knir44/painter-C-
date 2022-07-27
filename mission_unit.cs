using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    public class mission_unit//to divide the task into class
    {
        int id;// ID for each Shape
        int task_number; // which task we need to undo  || Delete = 1  || Add = 2 || Move = 3 || color = 4

        //getters and setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Task_number
        {
            get { return task_number; }
            set { task_number = value; }
        }

    }
}
