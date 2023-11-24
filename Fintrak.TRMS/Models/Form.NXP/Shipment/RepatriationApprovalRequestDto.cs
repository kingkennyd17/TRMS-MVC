namespace Fintrak.TRMS.FormNXPRequestDto
{
    public class RepatriationApprovalRequestDto
    {
        public bool approved { get; set; }
        public string note { get; set; }
        public string rejectionReasonCode { get; set; }
        public string daemonReviewName { get; set; }
        public string daemonSupervisorName { get; set; }
        public string swiftHeaderMessage { get; set; }
        public string bankStatementFileId { get; set; }
        public string amount { get; set; }
        public string fullRepatriation { get; set; }
    }
}
