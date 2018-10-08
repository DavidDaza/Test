
using NUnit.Framework;


namespace LoginTest
{
    [TestFixture]
    public class LoginTestCls
    {
        [TestCase]
        public void Autenticacion_de_usuario_correcta()
        {
            var login = new LoginCls();
//jjjjjjjjj
            Assert.AreEqual("Autenticacion de usuario correca.", login.autenticacionDeUsuarios("uswe","Pass1258/*"));

        }

    }
}
