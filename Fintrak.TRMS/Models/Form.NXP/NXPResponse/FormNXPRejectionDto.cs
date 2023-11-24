namespace Fintrak.TRMS.FormNXPResponseDto
{
    public class FormNXPRejectionDto
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultDto responseResult { get; set; }
    }

    public class ResponseResultDto
    {
        public ContentDto[] content { get; set; }
        public PageableDto pageable { get; set; }
        public bool last { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public bool first { get; set; } 
        public SortBDto sort { get; set; }
        public int numberOfElements { get; set; }
        public int size { get; set; }
        public int number { get; set; }

    }
    public class ContentDto
    {
        public int id { get; set; }
        public int createdAt { get; set; }
        public int updatedAt { get; set; }
        public int achievedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string formType { get; set; }
    }

    public class PageableDto
    {
        public SortDto sort { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int offset { get; set; }
        public bool unpaged { get; set; }
        public bool paged { get; set; }
    }

    public class SortDto
    {
        public bool sorted { get; set; }
        public bool unsorted { get; set; }
    }
    public class SortBDto
    {
        public bool sorted { get; set; }
        public bool unsorted { get; set; }
    }
}
