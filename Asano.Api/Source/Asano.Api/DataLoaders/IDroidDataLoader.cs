namespace Asano.Api.DataLoaders
{
    using System;
    using Asano.Api.Models;
    using GreenDonut;

    public interface IDroidDataLoader : IDataLoader<Guid, Droid>
    {
    }
}