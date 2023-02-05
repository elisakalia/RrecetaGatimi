using System;
using System.Runtime.ConstrainedExecution;
using RrecetaGatimi.Data.Model;
using RrecetaGatimi.Data.VM;

namespace RrecetaGatimi.Services
{
    public interface IRecetaService
    {
        public string UpdateReceta(RecetaVM Receta);
        public string DeleteReceta(string titulli);
        public Receta GetReceten(string titulli);
        public List<Receta> Recetat();
        public string Create(RecetaVM Receta);
    }
}

