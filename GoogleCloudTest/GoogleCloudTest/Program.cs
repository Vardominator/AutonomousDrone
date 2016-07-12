using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCloudTest
{
    class Program
    {
        public static void Main(string[] args)
        {

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"F:\GitHub\AutonomousDrone\GoogleCloudTest\AutonomousDrone-bb11fd09154f.json");
            Environment.SetEnvironmentVariable("GOOGLE_PROJECT_ID", "autonomousdrone-1370");
            Environment.SetEnvironmentVariable("GOOGLE_BUCKET", "real-time-drone-data");

            PrintUsage();

            Console.ReadKey();

        }

        private static void PrintUsage()
        {
            Console.WriteLine(@"Usage: [command]
  Commands:
    ListBuckets
    ListObjects
    UploadStream
    DownloadStream
    DeleteObject
    DownloadToFile
    DownloadRange
       
  Environment variables:
    GOOGLE_PROJECT_ID     The ID of Google Developers Console project
    GOOGLE_BUCKET         The name of Google Cloud Storage bucket
    
");


            RunCommand(Console.ReadLine());

        }


        private static void RunCommand(string command)
        {
            var projectId = Environment.GetEnvironmentVariable("GOOGLE_PROJECT_ID");
            var bucketName = Environment.GetEnvironmentVariable("GOOGLE_BUCKET");

            switch (command)
            {
                case "ListBuckets":
                    new StorageTest().ListBuckets(projectId);
                    break;
                //case "ListObjects":
                //    new StorageTest().ListObjects(bucketName);
                //    break;
                //case "UploadStream":
                //    new StorageTest().UploadStream(bucketName);
                //    break;
                //case "DownloadStream":
                //    new StorageTest().DownloadStream(bucketName);
                //    break;
                //case "DeleteObject":
                //    new StorageTest().DeleteObject(bucketName);
                //    break;
                //case "DownloadToFile":
                //    new StorageTest().DownloadToFile(bucketName);
                //    break;
                //case "DownloadRange":
                //    new StorageTest().DownloadRange(bucketName);
                //    break;
                default:
                    Console.WriteLine($"Command not found: {command}");
                    break;
            }
        }

    }
}
