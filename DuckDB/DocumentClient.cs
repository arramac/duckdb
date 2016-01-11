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
    public class DocumentClient
    {
        public DocumentClient(Uri endpoint, string authKey, ConnectionPolicy connectionPolicy = null, RetryPolicy retryPolicy = null)
        {

        }

        public Database GetDatabaseReference(string databaseId)
        {
            throw new NotImplementedException();
        }

        public DocumentCollection GetCollectionReference(string databaseId, string collectionId)
        {
            throw new NotImplementedException();
        }

        public async Task<FeedResponse<Microsoft.Azure.Documents.Database>> ListDatabasesAsync<T>(FeedOptions queryOptions = null)
        {
            throw new NotImplementedException();
        }
    }
#pragma warning restore 1998
}
