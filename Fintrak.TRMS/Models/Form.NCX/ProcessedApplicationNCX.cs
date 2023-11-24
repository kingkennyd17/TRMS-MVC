namespace Fintrak.TRMS.Models
{

    public class ContentNCX
    {
        public string StatusCode { get; set; }
        public string ApplicationNumber { get; set; }
        public string Status { get; set; }
        public object ProcessingBankCode { get; set; }
        public object EstimatedValueOfGoodsNaira { get; set; }
        public long? CreatedAt { get; set; }
        public string FormNumber { get; set; }
        public long? CurrentStageDate { get; set; }
        public long? UpdatedAt { get; set; }
        public object ApplicantName { get; set; }
        public object ProcessingBankId { get; set; }
        public string ProcessingBankName { get; set; }
        public int? ApplicantId { get; set; }
        public string ProcessingBankBranchName { get; set; }
        public int? Id { get; set; }
    }

    public class ProcessedApplicationNCX
    {
        public int? ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public ResponseResultNCX? ResponseResult { get; set; }
    }

}
