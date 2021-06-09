namespace Asano.Api.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Asano.Api.Models;

    public interface IHumanRepository
    {
        Task<Human> AddHumanAsync(Human human, CancellationToken cancellationToken);

        Task<List<Character>> GetFriendsAsync(Human human, CancellationToken cancellationToken);

        Task<IQueryable<Human>> GetHumansAsync(CancellationToken cancellationToken);

        Task<IEnumerable<Human>> GetHumansAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken);
    }
}