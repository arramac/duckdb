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
        public StoredProcedureFeed StoredProcedures { get; private set; }

        public DocumentCollection(string databaseId, string collectionId)
        {
            this.StoredProcedures = new StoredProcedureFeed();
        }

        public async Task<bool> ExistsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> CreateAsync(
            PartitioningPolicy partitioningPolicy,
            int throughputRequestUnits,
            IndexingPolicy indexingPolicy = null)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> CreateAsync(
            OfferName offerName,
            IndexingPolicy indexingPolicy = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> UpdateIndexingPolicy(
            IndexingPolicy policy)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.DocumentCollection>> UpdateThroughput(
            int throughputRequestUnits)
        {
            throw new NotImplementedException();
        }

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
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<dynamic>> ExecuteQuerySegmentedAsync<T>(IQueryable<T> query, FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }

        public async Task<StoredProcedureResponse<T>> ExecuteStoredProcedureAsync<T>(IQueryable<T> query, params object[] args)
        {
            throw new NotImplementedException();
        }
    }

    public enum OfferName
    {
        S1, S2, S3
    }

#pragma warning disable 0169
#pragma warning restore 1998
}
