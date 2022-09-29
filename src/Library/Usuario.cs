namespace Chatbot
{
    public abstract class Usuario : ICalificable, IDatosPersonales
    {
        public string NombreCompleto { get; set; }
        public int Cedula { get; set; }
        public int NumeroTelefono { get; set; }
        public string CorreoElectronico { get; set; }
        public float ValorReputacion { get; set; }
        public int NumeroValoraciones { get; set; }
        public float Calificacion { get; set;}
    }
}