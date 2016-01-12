using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace DuckDB
{
#pragma warning disable 1998
#pragma warning disable 0169
    public class DocumentCollection
    {
        private string collLink;

        /// <summary>
        /// Create a reference to a DocumnentDB collection.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="collectionId"></param>
        /// <param name="client"></param>
        public DocumentCollection(string databaseId, string collectionId, DocumentClient client)
        {
            // DISCUSS: Effectively a collection "context". Borrowed from Tables
        }

        /// <summary>
        /// Check if a collection exists.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ExistsAsync()
        {
            // DISCUSS: Tables implements Exists, Create, CreateIfNotExists, Delete, DeleteIfExists. This is a nice
            // way to simplify creation without constructing LINQ queries. They just offer wrappers to check the HttpStatusCode
            // and e.g. ignore NotFound
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a collection - the primary interface for elastic collections
        /// </summary>
        /// <param name="partitioningPolicy"></param>
        /// <param name="throughputRequestUnits"></param>
        /// <param name="indexingPolicy"></param>
        /// <returns></returns>
        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> CreateAsync(
            PartitioningPolicy partitioningPolicy,
            
            int throughputRequestUnits,
            IndexingPolicy indexingPolicy = null)
        {
            // DISCUSS: required parameters are partitioningPolicy and throughputRequestUnits
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a fixed size collection. Marked obsolete.
        /// </summary>
        /// <param name="offerName"></param>
        /// <param name="indexingPolicy"></param>
        /// <returns></returns>
        [Obsolete]
        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> CreateAsync(
            OfferName offerName,
            IndexingPolicy indexingPolicy = null)
        {
            // DISCUSS: create enum for S1,S2,S3 now that it isn't going to grow. Support this, but
            // mark obsolete for the future.
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update the indexing policy for a collection.
        /// </summary>
        /// <param name="policy"></param>
        /// <returns></returns>
        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> UpdateIndexingPolicyAsync(
            IndexingPolicy policy)
        {
            // DISCUSS: moving this into its own method. Seems in line with being a method on collection, and because
            // some other properties are better immutable.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update the RUs on a collection.
        /// </summary>
        /// <param name="throughputRequestUnits"></param>
        /// <returns></returns>
        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> UpdateThroughputAsync(
            int throughputRequestUnits)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update between S1/S2/S3.
        /// </summary>
        /// <param name="offerName"></param>
        /// <returns></returns>
        [Obsolete]
        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> UpdateThroughput(
            OfferName offerName)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Document>> CreateDocumentAsync(
            object document,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Document>> ReplaceDocumentAsync(
            object document,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Document>> DeleteDocumentAsync(
            object partitionKey,
            string documentKey,
            RequestOptions options = null)
        {
            // DISCUSS: Like the idea of having partitionKey as a required parameter to guide best practices.
            // We should also consider disallowing in the REST API.
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Document>> ReadDocumentAsync(
            object partitionKey,
            string documentKey,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<dynamic>> ListDocumentsAsync<T>(FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<dynamic>> ExecuteQueryAsync<T>(IQueryable<T> query, FeedOptions queryOptions = null)
        {
            // DISCUSS: Borrowed from Tables. Addresses the "DocumentDB doesn't support async query" complaint because it's
            // more explicit and familiar.
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<dynamic>> ExecuteQuerySegmentedAsync<T>(IQueryable<T> query, FeedOptions queryOptions = null)
        {
            // DISCUSS: Borrowed from Tables. Addresses the how to paginate complaint.
            throw new NotImplementedException();
        }

        public async Task<StoredProcedureResponse<T>> ExecuteStoredProcedureAsync<T>(IQueryable<T> query, params object[] args)
        {
            // DISCUSS: Like execute sproc as a first class method
            throw new NotImplementedException();
        }

        /// <summary>
        /// DISCUSS: To reduce the profileration of methods, create namespaces for lesser used feeds like Conflicts, StoredProcedures, Triggers
        /// Arguably We can do the same for documents.
        /// </summary>
        public StoredProcedureFeed StoredProcedures { get; private set; }

    }

    public enum OfferName
    {
        S1, S2, S3
    }

#pragma warning disable 0169
#pragma warning restore 1998
}
