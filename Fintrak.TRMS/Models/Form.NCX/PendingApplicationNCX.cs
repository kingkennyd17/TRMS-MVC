using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    public class ResponseResultNCX
    {
        public List<ContentNCX>? Content { get; set; }
        public Pageable? Pageable { get; set; }
        public bool Last { get; set; }
        public int? TotalPages { get; set; }
        public int? TotalElements { get; set; }
        public bool First { get; set; }
        public Sort? Sort { get; set; }
        public int? NumberOfElements { get; set; }
        public int? Size { get; set; }
        public int? Number { get; set; }
    }

    public class PendingApplicationNCX
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public ResponseResultNCX ResponseResult { get; set; }
    }

}
