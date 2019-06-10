﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api2.Models
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> GetAll();
        Produto Get(int id);
        Produto Add(Produto item);
        void Remove(int id);
        bool Update(Produto item);
    }
}