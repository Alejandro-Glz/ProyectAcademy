﻿using Acadamy.Core.BussinesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy.Core.RepositoryInterfaces
{
    public interface ITodosRepository
    {

        IList<Todo> GetAllTodos();

    }
}