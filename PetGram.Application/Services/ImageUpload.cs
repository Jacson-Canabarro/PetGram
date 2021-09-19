using System;
using System.IO;
using System.Text.RegularExpressions;
using Azure.Storage.Blobs;

namespace PetGram.Application.services
{
    public class ImageUpload
    {

        public string UploadBase64Img(string base64, string container)
        {
            var fileName = Guid.NewGuid().ToString() + ".jpg";
            var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(base64, "");

            byte[] imagesBytes = Convert.FromBase64String(data);
            
            var blobClient = new BlobClient("DefaultEndpointsProtocol=https;AccountName=atinfnet;AccountKey=hc58mZ1n5vcRto4wEHprZJQgSNttRmAW/0aTYKwf0ZDDiPexpwsywWIAijFwUPX+nh5uKUcXiEvsWJeoJiUOPQ==;EndpointSuffix=core.windows.net", container, fileName);
            
            using (var stream = new MemoryStream(imagesBytes)) 
            {
                blobClient.Upload(stream);
            }
            return blobClient.Uri.AbsoluteUri;
        }
        
        
        
    }
}