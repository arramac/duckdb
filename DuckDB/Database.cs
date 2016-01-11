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
    public class Database
    {
        private string databaseLink;

        public Database(string databaseId, string collectionId)
        {
            
        }

        public async Task<bool> ExistsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.Database>> CreateAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResourceResponse<Microsoft.Azure.Documents.Database>> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<Microsoft.Azure.Documents.DocumentCollection>> ListDocumentCollectionsAsync<T>(FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }
    }
#pragma warning restore 1998
#pragma warning restore 0169
}
