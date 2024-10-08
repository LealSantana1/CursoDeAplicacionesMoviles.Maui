﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Services
{
    public interface IDepartamentoService

    {

        Task<Departamento> GetDepartamentoAsync(int id);

        Task<IEnumerable<Departamento>> GetAllDepartamentosAsync();

        Task<bool> AddDepartamentoAsync(Departamento departamento);

        Task<bool> UpdateDepartamentoAsync(Departamento departamento);

        Task<bool> DeleteDepartamentoAsync(int id);

    }
}
