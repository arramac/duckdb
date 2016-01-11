using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace DuckDB
{
#pragma warning disable 1998
#pragma warning disable 0169
    public class StoredProcedureFeed
    {
        public async Task<ResourceResponse<StoredProcedure>> CreateStoredProcedureAsync(
            StoredProcedure procedure,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<StoredProcedure>> ReplaceStoredProcedureAsync(
            StoredProcedure procedure,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<StoredProcedure>> DeleteStoredProcedureAsync(
            string storedProcedureId,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<StoredProcedure>> ReadStoredProcedureAsync(
            string storedProcedureId,
            RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<StoredProcedure>> ListStoredProceduresAsync<T>(FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<StoredProcedure>> ExecuteQueryAsync<T>(IQueryable<T> query, FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<StoredProcedure>> ExecuteQuerySegmentedAsync<T>(IQueryable<T> query, FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }
    }
#pragma warning restore 1998
#pragma warning restore 0169
}
