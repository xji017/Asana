namespace Asano.Api.Resolvers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Asano.Api.DataLoaders;
    using Asano.Api.Models;
    using Asano.Api.Repositories;
    using HotChocolate;

    public class QueryResolver
    {
        public Task<IQueryable<Droid>> GetDroidsAsync(
            [Service] IDroidRepository droidRepository,
            CancellationToken cancellationToken) =>
            droidRepository.GetDroidsAsync(cancellationToken);

        public Task<IReadOnlyList<Droid>> GetDroidByIdsAsync(
            IDroidDataLoader droidDataLoader,
            List<Guid> ids,
            CancellationToken cancellationToken) =>
            droidDataLoader.LoadAsync(ids, cancellationToken);

        public Task<IQueryable<Human>> GetHumansAsync(
            [Service] IHumanRepository humanRepository,
            CancellationToken cancellationToken) =>
            humanRepository.GetHumansAsync(cancellationToken);

        public Task<IReadOnlyList<Human>> GetHumansByIdsAsync(
            IHumanDataLoader humanDataLoader,
            List<Guid> ids,
            CancellationToken cancellationToken) =>
            humanDataLoader.LoadAsync(ids, cancellationToken);
    }
}