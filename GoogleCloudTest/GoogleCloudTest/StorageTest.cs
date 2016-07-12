using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Download;
using System.Net.Http;



namespace GoogleCloudTest
{
    class StorageTest
    {
        
        public StorageService CreateStorageClient()
        {


            var credentials = Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefaultAsync().Result;
            

            if (credentials.IsCreateScopedRequired)
            {
                credentials = credentials.CreateScoped(new[] { StorageService.Scope.DevstorageFullControl });
            }

            var serviceInitializer = new BaseClientService.Initializer()
            {
               
                ApplicationName = "AutonomousDrone",
                HttpClientInitializer = credentials
            };

            return new StorageService(serviceInitializer);
        }
        // [END create_storage_client]

        // [START list_buckets]
        public void ListBuckets(string projectId)
        {


            StorageService storage = CreateStorageClient();
           
            var buckets = storage.Buckets.List(projectId).Execute();
            

            if (buckets.Items != null)
            {
                foreach (var bucket in buckets.Items)
                {
                    Console.WriteLine($"Bucket: {bucket.Name}");
                }
            }
        }

    }
}
