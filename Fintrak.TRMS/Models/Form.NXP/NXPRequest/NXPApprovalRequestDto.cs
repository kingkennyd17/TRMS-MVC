﻿namespace Fintrak.TRMS.FormNXPRequestDto
{
    public class NXPApprovalRequestDto
    {
        public bool approved { get; set; }
        public string note { get; set; }
        public string daemonReviewName { get; set; }
        public string daemonSupervisorName { get; set; }
        public string rejectionReasonCode { get; set; }
    }
}
