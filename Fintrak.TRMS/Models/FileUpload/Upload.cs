namespace Fintrak.TRMS.Models
{
    public class FileUploadResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public FileUploadResult ResponseResult { get; set; }
    }

    public class FileUploadResult
    {
        public string FileId { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public string Label { get; set; }
    }

}
