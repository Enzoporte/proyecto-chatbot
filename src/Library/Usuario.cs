namespace Chatbot
{
    public abstract class Usuario : IReputacion, IDatosPersonales, IInfoContacto
    {
        public string NombreCompleto { get; set; }
        public int Cedula { get; set; }
        public int NumeroTelefono { get; set; }
        public string CorreoElectronico { get; set; }
        public float ValorReputacion { get; set; }
        public int NumeroValoraciones { get; set; }
    }
}