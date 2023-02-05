using System;
using System.Runtime.ConstrainedExecution;
using RrecetaGatimi.Data;
using RrecetaGatimi.Data.Model;
using RrecetaGatimi.Data.VM;

namespace RrecetaGatimi.Services
{
    public class RecetaService : IRecetaService
    {
        readonly AppDbContext _dbContext;
        public RecetaService(AppDbContext db)
        {
            _dbContext = db;
        }

        public string Create(RecetaVM Receta)
        {
            _dbContext.Receta.Add(new Receta
            {
                Titulli = Receta.Titulli,
                Pershkrimi = Receta.Pershkrimi,
                Autori = Receta.Autori,
                EmailiAutorit = Receta.EmailiAutorit,
                DataPublikimit = Receta.DataPublikimit
            });

            _dbContext.SaveChanges();

            return "Receta u ruajt me sukses";
        }

        public string DeleteReceta(string titulli)
        {
            var receta = _dbContext.Receta.FirstOrDefault(r => r.Titulli == titulli);

            _dbContext.Receta.Remove(receta!);

            return "Receta u fshi me suksess";
        }

        public Receta GetReceten(string titulli)
        {
            var receta = _dbContext.Receta.FirstOrDefault(r => r.Titulli == titulli);

            return receta!;
        }

        public List<Receta> Recetat()
        {
            return _dbContext.Receta.ToList();
        }

        public string UpdateReceta(RecetaVM Receta)
        {
            var receta = _dbContext.Receta.FirstOrDefault(r => r.Titulli == Receta.Titulli);

            receta!.Titulli = Receta.Titulli;
            receta!.Pershkrimi = Receta.Pershkrimi;
            receta!.Autori = Receta.Autori;
            receta!.EmailiAutorit = Receta.EmailiAutorit;
            receta!.DataPublikimit = Receta.DataPublikimit;

            _dbContext.Receta.Update(receta!);

            _dbContext.SaveChanges();

            return "Receta u ndryshua me sukses";
        }
    }
}

