using System.Runtime.Serialization;

namespace WcfAccesoUsuario.model
{
    [DataContract]
    public class UsuarioBE
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }     
    }
}