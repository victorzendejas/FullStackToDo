﻿using FullStackToDo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FullStackToDo.Data
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base("Todo")
        {

        }
        public IDbSet<Todo> Todoes { get; set; }


    }
}