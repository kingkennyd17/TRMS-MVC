using System;
using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    public class DisbursementReviewerRequest
    {
        public bool Approved { get; set; }
        public string Note { get; set; }
        //public string DaemonReviewName { get; set; }
        //public string DaemonSupervisorName { get; set; }
        public List<Beneficiary> Beneficiaries { get; set; }
        //public string Beneficiaries { get; set; }
        public bool DisbursementsCloseOut { get; set; }
        public string RejectionStakeholder { get; set; }
    }
    public class RejectDisbursementRequest
    {
        public bool DisbursementsCloseOut { get; set; }
        public string RejectionStakeholder { get; set; }
        public string Note { get; set; }
        public string RejectionReasonCode { get; set; }
    }

    public class Beneficiary
    {
        public int? Id { get; set; }
        public List<Disbursement>? Disbursements { get; set; }
    }

    public class Disbursement
    {
        public int? Id { get; set; }
        public string Bvn { get; set; }
        public decimal? Amount { get; set; }
        public string ExchangeRate { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentModeCode { get; set; }
        public DateTime? DateDisbursed { get; set; }
        public Guid? TransactionCodeFileId { get; set; }
    }

    public class DisbursementReviewerResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseResult { get; set; }
    }
}
