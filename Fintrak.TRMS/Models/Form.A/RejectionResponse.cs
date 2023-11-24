using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    public class RejectionResponse
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultRejection responseResult { get; set; }
        public Pageable Pageable { get; set; }
    }

    public class ResponseResultRejection
    {
        public List<Content>? content { get; set;}
    }

    public class Content
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public long? archivedAt { get; set; }  // Use long? to represent a nullable long
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string formType { get; set; }
    }

    public class Pageable
    {
        public Sort Sort { get; set; }
        public int Offset { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public bool Paged { get; set; }
        public bool Unpaged { get; set; }
    }

    public class Sort
    {
        public bool Sorted { get; set; }
        public bool Unsorted { get; set; }
    }
}
