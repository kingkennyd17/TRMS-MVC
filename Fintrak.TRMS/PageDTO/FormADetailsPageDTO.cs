using Fintrak.TRMS.Models;

namespace Fintrak.TRMS.PageDTO
{
    public class FormADetailsPageDTO
    {
        public FormADetails? FormADetails { get; set; }
        public ApprovalRejectionRequest? ApprovalRequest { get; set; }
        public DisbursementReviewerRequest? DisbursementRequest { get; set; }
    }
}
