namespace Fintrak.TRMS.Models
{
    public class ApprovalRejectionRequest
    {
        public bool Approved { get; set; }
        public string Note { get; set; }
        public string DaemonReviewerName { get; set; }
        public string DaemonSupervisorName { get; set; }
        public string RejectionReasonCode { get; set; }
    }

    public class ApprovalRejectionResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseResult { get; set; }
    }

}
