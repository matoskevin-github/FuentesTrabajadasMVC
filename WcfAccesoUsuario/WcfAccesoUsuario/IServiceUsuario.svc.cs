using WcfAccesoUsuario.model;

namespace WcfAccesoUsuario
{
    public class IServiceUsuario : IIServiceUsuario
    {
        public UsuarioBE getUsuario()
        {
            var oUsuarioBE = new UsuarioBE();       
            oUsuarioBE.Login = "vmatosse";
            oUsuarioBE.Password = "Peru123.";
            return oUsuarioBE;
        }
    }
}
