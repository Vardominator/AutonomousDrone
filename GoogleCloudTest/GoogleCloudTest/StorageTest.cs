using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Download;
using System.Net.Http;
using System.IO;

namespace GoogleCloudTest
{
    class StorageTest
    {
        
        public StorageService CreateStorageClient()
        {

            // Checks the environment variable GOOGLE_APPLICATION_CREDENTIALS to find the JSON with
            //      credential information. Once the credential is established, calls are authorized
            //      OAuth2.
            var credentials = Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefaultAsync().Result;
            
            // Since the credential requires a scope, this checks if already has one built in
            if (credentials.IsCreateScopedRequired)
            {
                credentials = credentials.CreateScoped(new[] { StorageService.Scope.DevstorageFullControl });
            }

            // WTF google. I don't get what this does. Kind of kidding, it handles communication with the server
            var serviceInitializer = new BaseClientService.Initializer()
            {
               
                ApplicationName = "AutonomousDrone",
                HttpClientInitializer = credentials
            };

            return new StorageService(serviceInitializer);
        }

        
        // List buckets in a project, in this case project = AutonomousDrone
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


        // List objects in a bucket
        public void ListObjects(string bucketName)
        {
            StorageService storage = CreateStorageClient();

            var objects = storage.Objects.List(bucketName).Execute();

            if(objects.Items != null)
            {
                foreach (var obj in objects.Items)
                {
                    Console.WriteLine($"Object: {obj.Name}");

                }
            }
        }

        

        // Uploading a file stream
        public void UploadStream(string bucketName)
        {
            StorageService storage = CreateStorageClient();

            var content = "This is some test content";
            var uploadStream = new MemoryStream(Encoding.UTF8.GetBytes(content));

            storage.Objects.Insert
            (
                bucket: bucketName,
                stream: uploadStream,
                contentType: "text/plain",
                body: new Google.Apis.Storage.v1.Data.Object() { Name = "testFile.txt" }
            ).Upload();

            Console.WriteLine("Uploaded testFile.text");

        }


        // Downloading a file stream with progress
        public void DownloadToFile(string bucketName)
        {
            StorageService storage = CreateStorageClient();

            var objectToDownload = storage.Objects.Get(bucketName, "testFile.txt").Execute();

            var downloader = new MediaDownloader(storage);

            // Subscribe a function to the event ProgressChanged
            // The return type of the event is IDownloadProgress which has properties Status and BytesDownloaded
            downloader.ProgressChanged += progress => 
            {
                Console.WriteLine($"{progress.Status} {progress.BytesDownloaded} bytes");
            };



            using (var fileStream = new FileStream(@"C:\Users\Varderes\Desktop\downloadedFile.txt", FileMode.Create))
            {
                var progress = downloader.Download(objectToDownload.MediaLink, fileStream);

                if(progress.Status == DownloadStatus.Completed)
                {
                    Console.WriteLine("Downloaded testFile.txt to downloadedFile.txt");
                }
            }
        }



    }
}
