using System;
namespace RrecetaGatimi.Data.Model
{
    public class Receta
    {
        public int Id { get; set; }
        public string Titulli { get; set; }
        public string Pershkrimi { get; set; }
        public string Autori { get; set; }
        public string EmailiAutorit { get; set; }
        public DateTime DataPublikimit { get; set; }
    }
}

