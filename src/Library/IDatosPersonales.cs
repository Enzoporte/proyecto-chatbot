namespace Chatbot
{
    internal interface IDatosPersonales
    {
        int NumeroTelefono { get; set; }
        string CorreoElectronico { get; set; }
        string NombreCompleto { get; set; }
        int Cedula { get; set; }
        float Calificacion { get; set; }
    }
}