using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.S3Events;
using Amazon.S3;
using Amazon.S3.Util;


namespace ConsoleAWSCall
{

    class Program
    {
        private static string accessKey = "$49iyrI!FcG,AKIAJVSYPSVAC6BPILKQ";
        private static string secretAccessKey = "LidX+kJlcqcmHdamw7BlsOaljuXdJNSDFp8IMoOu";
        string filePath = "C:\\Projects\\Testing\\Temp Files\\test.jpg";
        string s3Bucket = "your.bucket.name/subdirectory-if-needed";
        private static string serviceUrl = "https://ap-south-1.console.aws.amazon.com";  //N. Virginia service url         
        string newFileName = "test-" + DateTime.Now.Ticks.ToString() + ".jpg"; //new filename in s3, optional

        //IAmazonS3 S3Client { get; set; }
        static void Main(string[] args)
        {
     
        AmazonS3Client Client = new AmazonS3Client(accessKey, secretAccessKey);


              


           S3 s3 = new S3(accessKey, secretAccessKey, serviceUrl);
    
        }
        public class S3
        {
           
            Amazon.S3.AmazonS3Client S3Client = null;
            public S3(string accessKeyId, string secretAccessKey, string serviceUrl)
            {
                Amazon.S3.AmazonS3Config s3Config = new Amazon.S3.AmazonS3Config();
                s3Config.ServiceURL = serviceUrl;

                this.S3Client = new Amazon.S3.AmazonS3Client(accessKeyId, secretAccessKey, s3Config);
            }
           
       
        }
    }
}
