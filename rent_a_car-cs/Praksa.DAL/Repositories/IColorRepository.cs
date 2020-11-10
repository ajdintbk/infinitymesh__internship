using Praksa.DAL.ViewModel;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Praksa.DAL.Repositories
{
    public interface IColorRepository
    {
        Task<ColorViewModel> Get(CancellationToken cancellationToken = default);
        Task<int> Save(ColorDto color, CancellationToken cancellationToken = default);
        void Delete(int id, CancellationToken cancellationToken = default);

    }
}
