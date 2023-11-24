namespace Fintrak.TRMS.FormNXPRequestDto
{
    public class NessLevyPaymentRequestDto
    {
        public bool approved { get; set; }
        public string note { get; set; }
        public string rejectionReasonCode { get; set; }
        public string daemonReviewName { get; set; }
        public string daemonSupervisorName { get; set; }
        public string nessLevyPaid { get; set; }
        public string transactionCode { get; set; }
    }
}
