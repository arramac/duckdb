using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft;
using Newtonsoft.Json;

namespace DuckDB
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private async Task DoSomething()
        {
            DocumentClient client = new DocumentClient(new Uri("docdb.documents.azure.com"), "xxx");

            Database database = client.GetDatabaseReference("db");
            if (!await database.ExistsAsync())
            {
                await database.CreateAsync();
            }

            DocumentCollection collection = client.GetCollectionReference("db", "coll");
            if (!await collection.ExistsAsync())
            {
                await collection.CreateAsync(new PartitioningPolicy { PartitionKeyName = "Artist" }, 1000);
            }

            Song song = new Song { Album = "IV", Artist = "Led Zeppelin", SongTitle = "Stairway to Heaven", Year = 1971 };
            await collection.CreateDocumentAsync(song);

            song.Album = "Greatest Hits";
            await collection.ReplaceDocumentAsync(song);

            Document readSong = await collection.ReadDocumentAsync("Led Zeppelin", "Stairway to Heaven");

            await collection.DeleteDocumentAsync("Led Zeppelin", "Stairway to Heaven");

            IQueryable<Song> query = new DocumentQuery<Song>().Where(s => s.Year == 1971).Take(10);
            await collection.ExecuteQueryAsync<Song>(query);

            FeedResponse<dynamic> results = await collection.ExecuteQuerySegmentedAsync<Song>(query);
            results = await collection.ExecuteQuerySegmentedAsync<Song>(query, new FeedOptions { RequestContinuation = results.ResponseContinuation });

            await collection.UpdateThroughputAsync(500);

            await collection.StoredProcedures.CreateStoredProcedureAsync(new StoredProcedure { Id = "Aggregate", Body = "function() { ..}" });
        }

        public class Song
        {
            public string Artist { get; set; }
            public string Album { get; set; }
            
            [JsonProperty("id")]
            public string SongTitle { get; set; }
            public int Year { get; set; }
        }
    }
}
