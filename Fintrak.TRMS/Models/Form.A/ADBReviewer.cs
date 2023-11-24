namespace Fintrak.TRMS.Models
{
    public class ADBReviewerRequest
    {
        public bool Approved { get; set; }
        public string Note { get; set; }
        public string DaemonReviewName { get; set; }
        public string DaemonSupervisorName { get; set; }
        public string RejectionReasonCode { get; set; }
    }
    public class ADBReviewerRequestNCX
    {
        public bool Approved { get; set; }
        public string Note { get; set; }
        public string DaemonReviewerName { get; set; }
        public string DaemonSupervisorName { get; set; }
        public string RejectionReasonCode { get; set; }
    }

    public class ADBReviewerResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseResult { get; set; }
    }

}
