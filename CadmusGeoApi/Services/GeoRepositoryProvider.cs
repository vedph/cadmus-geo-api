﻿using System.Reflection;
using Cadmus.Core;
using Cadmus.Core.Config;
using Cadmus.Core.Storage;
using Cadmus.Mongo;
using Cadmus.General.Parts;
using Cadmus.Geo.Parts;

namespace CadmusGeoApi.Services;

/// <summary>
/// Cadmus Geo repository provider.
/// </summary>
/// <seealso cref="IRepositoryProvider" />
public sealed class GeoRepositoryProvider : IRepositoryProvider
{
    private readonly IPartTypeProvider _partTypeProvider;

    /// <summary>
    /// The connection string.
    /// </summary>
    public string ConnectionString { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeoRepositoryProvider"/>
    /// class.
    /// </summary>
    public GeoRepositoryProvider()
    {
        ConnectionString = "";
        TagAttributeToTypeMap map = new();
        map.Add(new[]
        {
            // Cadmus.General.Parts
            typeof(NotePart).GetTypeInfo().Assembly,
            // Cadmus.Geo.Parts
            typeof(AssertedLocationsPart).GetTypeInfo().Assembly,
        });

        _partTypeProvider = new StandardPartTypeProvider(map);
    }

    /// <summary>
    /// Gets the part type provider.
    /// </summary>
    /// <returns>part type provider</returns>
    public IPartTypeProvider GetPartTypeProvider()
    {
        return _partTypeProvider;
    }

    /// <summary>
    /// Creates a Cadmus repository.
    /// </summary>
    /// <returns>repository</returns>
    public ICadmusRepository CreateRepository()
    {
        // create the repository (no need to use container here)
        MongoCadmusRepository repository = new(_partTypeProvider,
                new StandardItemSortKeyBuilder());

        repository.Configure(new MongoCadmusRepositoryOptions
        {
            ConnectionString = ConnectionString ??
            throw new InvalidOperationException(
                "No connection string set for IRepositoryProvider implementation")
        });

        return repository;
    }
}
