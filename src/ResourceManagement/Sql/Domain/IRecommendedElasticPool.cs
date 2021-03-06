// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Sql.Fluent.Models;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// An immutable client-side representation of an Azure SQL Recommended ElasticPool.
    /// </summary>
    public interface IRecommendedElasticPool  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.Sql.Fluent.IRecommendedElasticPool>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<Models.RecommendedElasticPoolInner>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasResourceGroup,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasName,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasId,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasManager<Microsoft.Azure.Management.Sql.Fluent.ISqlManager>,
        Microsoft.Azure.Management.Sql.Fluent.IRecommendedElasticPoolBeta
    {
        /// <summary>
        /// Gets the list of Azure SQL Databases in this pool. Expanded property.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase> Databases { get; }

        /// <summary>
        /// Gets the maximum DTU for the database.
        /// </summary>
        double DatabaseDtuMax { get; }

        /// <summary>
        /// Gets the DTU for the SQL Azure Recommended Elastic Pool.
        /// </summary>
        double Dtu { get; }

        /// <summary>
        /// Gets name of the SQL Server to which this database belongs.
        /// </summary>
        string SqlServerName { get; }

        /// <summary>
        /// Gets maximum observed DTU.
        /// </summary>
        double MaxObservedDtu { get; }

        /// <summary>
        /// Fetches list of databases by making call to Azure.
        /// </summary>
        /// <return>List of the databases in recommended elastic pool.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase> ListDatabases();

        /// <summary>
        /// Gets maximum observed storage in megabytes.
        /// </summary>
        double MaxObservedStorageMB { get; }

        /// <summary>
        /// Gets the observation period start (ISO8601 format).
        /// </summary>
        System.DateTime? ObservationPeriodEnd { get; }

        /// <summary>
        /// Gets the minimum DTU for the database.
        /// </summary>
        double DatabaseDtuMin { get; }

        /// <summary>
        /// Get a specific database in the recommended database.
        /// </summary>
        /// <param name="databaseName">Name of the database to be fetched.</param>
        /// <return>Information on the database recommended in recommended elastic pool.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase GetDatabase(string databaseName);

        /// <summary>
        /// Fetches list of metrics information by making call to Azure.
        /// </summary>
        /// <return>List of the databases in recommended elastic pool.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.IRecommendedElasticPoolMetric> ListMetrics();

        /// <summary>
        /// Gets the observation period start (ISO8601 format).
        /// </summary>
        System.DateTime? ObservationPeriodStart { get; }

        /// <summary>
        /// Gets storage size in megabytes.
        /// </summary>
        double StorageMB { get; }
    }
}