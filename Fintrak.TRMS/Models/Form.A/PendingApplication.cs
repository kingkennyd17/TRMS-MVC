using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    public class PendingApplication
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultApplication responseResult { get; set; }
    }

    public class ResponseResultApplication
    {
        public List<ContentApplication>? content { get; set; }
        public PageableApplication pageable { get; set; }
        public bool last { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public bool first { get; set; }
        public Sort sort { get; set; }
        public int? numberOfElements { get; set; }
        public int? size { get; set; }
        public int? number { get; set; }
    }

    public class PageableApplication
    {
        public SortApplication sort { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int offset { get; set; }
        public bool unpaged { get; set; }
        public bool paged { get; set; }
    }

    public class SortApplication
    {
        public bool sorted { get; set; }
        public bool unsorted { get; set; }
    }
}
