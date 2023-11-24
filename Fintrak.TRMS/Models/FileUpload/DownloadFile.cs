namespace Fintrak.TRMS.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ResponseResultDownload
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string fileId { get; set; }
        public string data { get; set; }
        public string fileName { get; set; }
        public string diskFileName { get; set; }
        public string label { get; set; }
        public string mimeType { get; set; }
        public bool deleted { get; set; }
    }

    public class DownloadFileResponse
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultDownload responseResult { get; set; }
    }



}
