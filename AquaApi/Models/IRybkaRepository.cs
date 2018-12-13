using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaApi.Models
{
    public interface IRybkaRepository
    {
        IQueryable<Rybki> Rybki { get; }

        Rybki this[int id] { get; }

    }
}
