﻿using DDDProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Domain.Interfaces.Services
{
    public interface IMovimentoManualService : IServiceBase<MovimentoManual>
    {
        IEnumerable<MovimentoManual> SearchName(string name);
    }
}
