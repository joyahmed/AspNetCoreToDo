﻿using AspNetCoreToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreToDo.ViewModels
{
    public class TodoViewModel
    {
        public TodoItem[] Items { get; set; }
    }
}
