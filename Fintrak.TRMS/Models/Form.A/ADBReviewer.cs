using System.Collections.Generic;

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

    //public class ADBReviewerResponse
    //{
    //    public int ResponseCode { get; set; }
    //    public string ResponseMessage { get; set; }
    //    public string ResponseResult { get; set; }
    //}






    public class ResponseResultADB
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object dateSubmitted { get; set; }
        public object formNumberAssignedDate { get; set; }
        public string statusCode { get; set; }
        public object status { get; set; }
        public object expireAt { get; set; }
        public string applicationNumber { get; set; }
        public object lastApplicationNumber { get; set; }
        public object exchangeRate { get; set; }
        public int year { get; set; }
        public bool isDeleted { get; set; }
        public object accountNumber { get; set; }
        public object accountNumberPreAmend { get; set; }
        public object expectedShipmentDate { get; set; }
        public object expectedShipmentDatePreAmend { get; set; }
        public bool activeProcess { get; set; }
        public object currentStageDate { get; set; }
        public object processReset { get; set; }
        public object formNumber { get; set; }
        public object formNumberSerial { get; set; }
        public object cancellationNumberSerial { get; set; }
        public object amendmentNumberSerial { get; set; }
        public object adbApprovedDate { get; set; }
        public object estimatedValueOfGoodsNaira { get; set; }
        public object estimatedValueOfGoodsNairaPreAmend { get; set; }
        public object estimatedValueOfGoodsDollar { get; set; }
        public object estimatedValueOfGoodsDollarPreAmend { get; set; }
        public object shipperName { get; set; }
        public object shipperNamePreAmend { get; set; }
        public object shipperPhone { get; set; }
        public object shipperPhonePreAmend { get; set; }
        public object shipperAddress { get; set; }
        public object shipperAddressPreAmend { get; set; }
        public object portShipment { get; set; }
        public object portShipmentPreAmend { get; set; }
        public object portDischarge { get; set; }
        public object portDischargePreAmend { get; set; }
        public object byOrderOf { get; set; }
        public object byOrderOfPreAmend { get; set; }
        public object consigneeName { get; set; }
        public object consigneeNamePreAmend { get; set; }
        public object consigneeEmail { get; set; }
        public object consigneeEmailPreAmend { get; set; }
        public object consigneePhone { get; set; }
        public object consigneePhonePreAmend { get; set; }
        public object consigneeAddressLine1 { get; set; }
        public object consigneeAddressLine1PreAmend { get; set; }
        public object consigneeAddressLine2 { get; set; }
        public object consigneeAddressLine2PreAmend { get; set; }
        public object consigneeAddressCity { get; set; }
        public object consigneeAddressCityPreAmend { get; set; }
        public object consigneeAddressState { get; set; }
        public object consigneeAddressStatePreAmend { get; set; }
        public object consigneeCountry { get; set; }
        public object consigneeCountryPreAmend { get; set; }
        public object processingBank { get; set; }
        public object processingBankPreAmend { get; set; }
        public object processingBankBranch { get; set; }
        public object processingBankBranchPreAmend { get; set; }
        public object shipmentPurpose { get; set; }
        public object shipmentPurposePreAmend { get; set; }
        public List<object> attachments { get; set; }
        public List<object> items { get; set; }
        public object totalQuantity { get; set; }
        public object totalNetWeight { get; set; }
        public object totalGrossWeight { get; set; }
        public object contact { get; set; }
        public object ncs { get; set; }
        public object ted { get; set; }
        public object sgdNumber { get; set; }
        public object sgdStatus { get; set; }
        public object sgdInspectionAct { get; set; }
        public object sgdDateIssued { get; set; }
        public object sgdDateEntered { get; set; }
        public object sgdFile { get; set; }
        public object certificateOfOrigin { get; set; }
        public object goodsReleasedForShipment { get; set; }
        public bool sgdApproved { get; set; }
        public object sgdApprovedDate { get; set; }
        public object shippingLineApprovedDate { get; set; }
        public bool billOfLadingApproved { get; set; }
        public object vesselName { get; set; }
        public object billOfLadingNumber { get; set; }
        public object billOfLadingDate { get; set; }
        public object shipmentDate { get; set; }
        public object shippingLine { get; set; }
        public object shippingLinePreAmend { get; set; }
        public object billOfLadingFile { get; set; }
        public object preAmendmentRequestStatus { get; set; }
        public object amendmentNumber { get; set; }
        public object amendmentReason { get; set; }
        public bool amendmentInit { get; set; }
        public bool amendmentComplete { get; set; }
        public object amendmentRequestDate { get; set; }
        public object amendmentCompletedDate { get; set; }
        public object amendmentHistory { get; set; }
        public List<object> amendmentAttachments { get; set; }
        public List<object> amendments { get; set; }
        public object lockedBy { get; set; }
        public List<object> workflowNotes { get; set; }
        public object preCancellationRequestStatus { get; set; }
        public object cancellationNumber { get; set; }
        public object cancellationReason { get; set; }
        public bool cancellationInit { get; set; }
        public bool cancellationComplete { get; set; }
        public object cancellationRequestDate { get; set; }
        public object cancellationCompletedDate { get; set; }
    }

    public class ADBReviewerResponse
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultADB responseResult { get; set; }
    }
}
