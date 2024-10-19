using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

public class AdministradorTest 
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // arrange
        var adm = new Administrador();

        // act
        adm.Id = 1;
        adm.Email = "teste@teste.com.br";
        adm.Senha = "1234rs";
        adm.Perfil = "Adm";

        // Assert

        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com.br", adm.Email);
        Assert.AreEqual("1234rs", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}