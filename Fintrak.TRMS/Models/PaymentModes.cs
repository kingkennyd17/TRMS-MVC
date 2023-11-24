using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ContentPayModes
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class PageablePayModes
    {
        public Sort sort { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int offset { get; set; }
        public bool paged { get; set; }
        public bool unpaged { get; set; }
    }

    public class ResponseResultPayModes
    {
        public List<ContentPayModes> content { get; set; }
        public PageablePayModes pageable { get; set; }
        public bool last { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public bool first { get; set; }
        public SortPayModes sort { get; set; }
        public int size { get; set; }
        public int number { get; set; }
        public int numberOfElements { get; set; }
    }

    public class PaymentModesResponse
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultPayModes responseResult { get; set; }
    }

    public class SortPayModes
    {
        public bool sorted { get; set; }
        public bool unsorted { get; set; }
    }


}
