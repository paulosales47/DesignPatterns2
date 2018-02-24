﻿using DesignPatterns2.Aula05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula04
{
    public interface IExpressao
    {
        double Avalia();

        void Aceita(IVisitor visitor);

    }
}
