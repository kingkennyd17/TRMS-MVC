using System.Collections.Generic;

namespace Fintrak.TRMS.FormNXPResponseDto
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ResponseResultRepatriation
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object form { get; set; }
        public object shipmentNumber { get; set; }
        public string statusCode { get; set; }
        public object expectedShipmentDateExporter { get; set; }
        public object expectedShipmentDate { get; set; }
        public object expectedShipmentDatePreAmend { get; set; }
        public object vesselNameTmp { get; set; }
        public object vesselNameExporter { get; set; }
        public object vesselName { get; set; }
        public object vesselNamePreAmend { get; set; }
        public object exchangeRate { get; set; }
        public object exchangeRateApplicantCurrency { get; set; }
        public object totalNetWeight { get; set; }
        public object totalNetWeightExporter { get; set; }
        public object ncsTotalNetWeight { get; set; }
        public object meaTotalNetWeight { get; set; }
        public object totalGrossWeight { get; set; }
        public object totalGrossWeightExporter { get; set; }
        public object ncsTotalGrossWeight { get; set; }
        public object meaTotalGrossWeight { get; set; }
        public object totalQuantity { get; set; }
        public object totalQuantityExporter { get; set; }
        public object ncsTotalQuantity { get; set; }
        public object meaTotalQuantity { get; set; }
        public object dprTotalQuantity { get; set; }
        public object totalCF { get; set; }
        public object totalFreightCharges { get; set; }
        public object totalFoB { get; set; }
        public object totalDollarFoB { get; set; }
        public bool piaApproved { get; set; }
        public bool ncsApproved { get; set; }
        public object currentDPRActor { get; set; }
        public object currentMEAActor { get; set; }
        public bool dprApproved { get; set; }
        public bool meaApproved { get; set; }
        public bool activeProcess { get; set; }
        public object currentStageDate { get; set; }
        public object processReset { get; set; }
        public object portDestination { get; set; }
        public object portDestinationPreAmend { get; set; }
        public object portDestinationExporter { get; set; }
        public List<object> items { get; set; }
        public List<object> attachments { get; set; }
        public object dprCertificateNumber { get; set; }
        public object dprVarianceReportFile { get; set; }
        public bool pciApproved { get; set; }
        public object pciNumber { get; set; }
        public object inspectionNote { get; set; }
        public object inspectionDate { get; set; }
        public object pciFile { get; set; }
        public List<object> nonCCIIssuance { get; set; }
        public object ciNumber { get; set; }
        public object ciType { get; set; }
        public object ciDate { get; set; }
        public bool ciApproved { get; set; }
        public object ciFile { get; set; }
        public object meaEvRepCode { get; set; }
        public object meaEvRepFile { get; set; }
        public bool nessLevyPaymentApproved { get; set; }
        public object transactionCode { get; set; }
        public object transactionFile { get; set; }
        public object nessLevyPayableExporter { get; set; }
        public object nessLevyPayable { get; set; }
        public object nessLevyPaid { get; set; }
        public object nessLevyDate { get; set; }
        public bool sgdApproved { get; set; }
        public object sgdNumber { get; set; }
        public object sgdStatus { get; set; }
        public object sgdInspectionAct { get; set; }
        public object sgdDateIssued { get; set; }
        public object sgdDateEntered { get; set; }
        public object sgdFile { get; set; }
        public object certificateOfOrigin { get; set; }
        public object goodsReleasedForShipment { get; set; }
        public bool billOfLadingApproved { get; set; }
        public object shippingLine { get; set; }
        public object shippingLinePreAmend { get; set; }
        public object billOfLadingNumber { get; set; }
        public object billOfLadingDate { get; set; }
        public object shipmentDate { get; set; }
        public object billOfLadingFile { get; set; }
        public object amountToRepatriate { get; set; }
        public object amountRepatriated { get; set; }
        public object repatriationDueDate { get; set; }
        public object repatriationDate { get; set; }
        public List<object> repatriations { get; set; }
        public bool fullRepatriationReceived { get; set; }
        public object amendmentNumberSerial { get; set; }
        public object preAmendmentRequestStatus { get; set; }
        public object amendmentNumber { get; set; }
        public object amendmentReason { get; set; }
        public bool amendmentInit { get; set; }
        public bool amendmentComplete { get; set; }
        public object amendmentRequestDate { get; set; }
        public object amendmentCompletedDate { get; set; }
        public List<object> amendmentAttachments { get; set; }
        public object amendmentHistory { get; set; }
        public List<object> amendments { get; set; }
        public object lockedBy { get; set; }
        public List<object> workflowNotes { get; set; }
        public object cancellationNumberSerial { get; set; }
        public bool cancelled { get; set; }
        public object preCancellationRequestStatus { get; set; }
        public object cancellationNumber { get; set; }
        public object cancellationReason { get; set; }
        public bool cancellationInit { get; set; }
        public bool cancellationComplete { get; set; }
        public object cancellationRequestDate { get; set; }
        public object cancellationCompletedDate { get; set; }
        public object moveToRepatriation { get; set; }
        public bool deleted { get; set; }
    }

    public class RepatriationApprovalResponseDto
{
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultRepatriation responseResult { get; set; }
    }


}
