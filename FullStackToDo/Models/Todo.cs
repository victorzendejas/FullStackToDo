using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackToDo.Models
{
    public class Todo
    {
        //primary key
        public int ToDoID { get; set; }
        //additional columns
        public string name { get; set; }
        public int priority { get; set; }
    }
}