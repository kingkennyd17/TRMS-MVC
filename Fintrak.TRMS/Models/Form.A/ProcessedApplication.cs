namespace Fintrak.TRMS.Models
{
    public class ProcessedApplication
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public ResponseResultApplication ResponseResult { get; set; }
    }

    public class ContentApplication
    {
        public string StatusCode { get; set; }
        public string CurrencyCode { get; set; }
        public object Status { get; set; }  // Use the appropriate type if "Status" is known
        public double TotalAmountRequested { get; set; }
        public object TotalAmountDisbursed { get; set; }  // Use the appropriate type if "TotalAmountDisbursed" is known
        public object ApprovingStakeholderId { get; set; }  // Use the appropriate type if "ApprovingStakeholderId" is known
        public object ApprovingStakeholderCode { get; set; }  // Use the appropriate type if "ApprovingStakeholderCode" is known
        public object ApprovingStakeholderName { get; set; }  // Use the appropriate type if "ApprovingStakeholderName" is known
        public object AmendmentInit { get; set; }  // Use the appropriate type if "AmendmentInit" is known
        public string FormNumber { get; set; }
        public long? CurrentStageDate { get; set; }
        public string ApplicationNumber { get; set; }
        public long? CreatedAt { get; set; }
        public long? UpdatedAt { get; set; }
        public object FormNumberSerial { get; set; }  // Use the appropriate type if "FormNumberSerial" is known
        public string ApplicantName { get; set; }
        public string ProcessingBankBranchName { get; set; }
        public int? ApplicantId { get; set; }
        public int? Id { get; set; }
    }

}
