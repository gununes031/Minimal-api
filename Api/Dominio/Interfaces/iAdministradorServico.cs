using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces
{
    public interface iAdministradorServico
    {
        Administrador? Login(loginDTO loginDTO);
        Administrador Incluir(Administrador administrador);
        Administrador BuscaPorId(int id);
        List<Administrador> Todos(int? pagina);
        
    }


}