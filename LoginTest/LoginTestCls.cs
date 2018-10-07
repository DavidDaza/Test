
using NUnit.Framework;
using Login;

namespace LoginTest
{
    [TestFixture]
    public class LoginTestCls
    {
        [TestCase]
        public void Autenticacion_de_usuario_correcta()
        {
            var login = new LoginCls();

            Assert.AreEqual("Autenticacion de usuario correcta.", login.autenticacionDeUsuarios("uswe","Pass1258/*"));

        }

    }
}
