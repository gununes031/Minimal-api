using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Infraestrutura.Db;

namespace Test.Domain.Servico;


    [TestClass]
    public class AdministradorServicoTest
    {  
        private DbContexto CriarContextoDeTeste()
        {
            var options = new DbContextOptionsBuilder<DbContexto>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .options;

            return new DbContexto(options);
        }

        [TestMethod]
        public void TestandoSalvarAdministrador()
        {
        // arrange
        var adm = new Administrador();
        adm.Id = 1;
        adm.Email = "teste@teste.com.br";
        adm.Senha = "1234rs";
        adm.Perfil = "Adm";

        // act

        var context = new CriarContextoDeTeste();

        // Assert

        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com.br", adm.Email);
        Assert.AreEqual("1234rs", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
        }
        
    }
