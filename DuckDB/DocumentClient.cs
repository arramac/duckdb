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
        /// <summary>
        /// Initialize a DocumentDB client.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="authKey"></param>
        /// <param name="connectionPolicy"></param>
        /// <param name="retryPolicy"></param>
        public DocumentClient(Uri endpoint, string authKey, ConnectionPolicy connectionPolicy = null, RetryPolicy retryPolicy = null)
        {
            // DISCUSS: Addition of retry policy. Default policy must have retries with introduction of elastic collections because:
            // 1) It is expected by developers experienced with Tables/DynamoDB.
            // 2) We'll have more skewed mixes of storage and throughput.
            // 3) We can now change behavior of # of retries within the SDK to something inline with customer expectations.
        }

        /// <summary>
        /// Gets a reference to the DocumentDB collection.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="collectionId"></param>
        /// <returns></returns>
        public DocumentCollection GetCollectionReference(string databaseId, string collectionId)
        {
            // DISCUSS: Borrowed idea from Tables's CloudTable class. This reduces the number of arguments required with e.g. ReadDocumentAsync.
            // The idea is most developers will use a single database/collection. 
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a reference to the DocumentDB database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <returns></returns>
        public Database GetDatabaseReference(string databaseId)
        {
            // DISCUSS: Arguably this can be removed in favor of the collection one,
            // but we need this to setup an collection.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the databases within a collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<FeedResponse<Microsoft.Azure.Documents.Database>> ListDatabasesAsync<T>(FeedOptions queryOptions = null)
        {
            // DISCUSS: Rename ReadFeed to List? No strong opinion - this matches Tables.
            throw new NotImplementedException();
        }
    }
#pragma warning restore 1998
}
