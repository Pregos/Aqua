using System.Linq;

namespace AquaApi.Models
{
    public class EFRybkaRepository : IRybkaRepository
    {
        private DypAquaContext dbcontext;

        public EFRybkaRepository(DypAquaContext ctx) => dbcontext = ctx;

        //public Rybki this[int id] => dbcontext.Rybki.Where(p => p.Idrybka == id) as Rybki;
        public Rybki this[int id]
        {
            get
            {
                return dbcontext.Rybki.FirstOrDefault(p => p.Idrybka == id);
            }
        }
        public IQueryable<Rybki> Rybki => dbcontext.Rybki;
    }
}
