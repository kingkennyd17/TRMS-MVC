using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AttachmentNCX
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object entity { get; set; }
        public object entityId { get; set; }
        public FileNCX file { get; set; }
    }

    public class ConsigneeCountry
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public object code3 { get; set; }
    }

    public class ContactNCX
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public object code { get; set; }
        public object firstName { get; set; }
        public object middleName { get; set; }
        public object lastName { get; set; }
        public bool enabled { get; set; }
        public bool underEmbargo { get; set; }
        public object licenseExpiryDate { get; set; }
        public object licenseStatus { get; set; }
        public bool deleted { get; set; }
        public string emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public object passportNumber { get; set; }
        public object bvn { get; set; }
        public string rcNumber { get; set; }
        public object licenseNumber { get; set; }
        public object nepcRegistrationNumber { get; set; }
        public string taxIdentificationNumber { get; set; }
        public object jobRole { get; set; }
        public string type { get; set; }
        public object organizationType { get; set; }
        public object accountCategory { get; set; }
        public bool designatedBank { get; set; }
        public object contactOrganization { get; set; }
        public object user { get; set; }
        public object lga { get; set; }
        public object createdBy { get; set; }
        public object sector { get; set; }
    }

    public class CountryNCX
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public object code3 { get; set; }
    }

    public class FileNCX
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string fileId { get; set; }
        public string fileName { get; set; }
        public string diskFileName { get; set; }
        public string label { get; set; }
        public string mimeType { get; set; }
        public bool deleted { get; set; }
    }

    public class HsCode
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public object sector { get; set; }
        public object subCategory { get; set; }
        public List<object> permits { get; set; }
        public bool banned { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string description { get; set; }
        public object descriptionPreAmend { get; set; }
        public double quantity { get; set; }
        public object quantityPreAmend { get; set; }
        public double netWeight { get; set; }
        public object netWeightPreAmend { get; set; }
        public double grossWeight { get; set; }
        public object grossWeightPreAmend { get; set; }
        public HsCode hsCode { get; set; }
        public object hsCodePreAmend { get; set; }
        public UnitOfMeasurement unitOfMeasurement { get; set; }
        public object unitOfMeasurementPreAmend { get; set; }
        public PackagingMode packagingMode { get; set; }
        public object packagingModePreAmend { get; set; }
        public bool deleted { get; set; }
    }

    public class LockedBy
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object name { get; set; }
        public object description { get; set; }
        public object code { get; set; }
        public string firstName { get; set; }
        public object middleName { get; set; }
        public string lastName { get; set; }
        public bool enabled { get; set; }
        public bool underEmbargo { get; set; }
        public object licenseExpiryDate { get; set; }
        public object licenseStatus { get; set; }
        public bool deleted { get; set; }
        public string emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public object phone { get; set; }
        public object address { get; set; }
        public object passportNumber { get; set; }
        public object bvn { get; set; }
        public object rcNumber { get; set; }
        public object licenseNumber { get; set; }
        public object nepcRegistrationNumber { get; set; }
        public object taxIdentificationNumber { get; set; }
        public object jobRole { get; set; }
        public string type { get; set; }
        public object organizationType { get; set; }
        public object accountCategory { get; set; }
        public bool designatedBank { get; set; }
        public object contactOrganization { get; set; }
        public object user { get; set; }
        public object lga { get; set; }
        public object createdBy { get; set; }
        public object sector { get; set; }
    }

    public class Ncs
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string code { get; set; }
        public object firstName { get; set; }
        public object middleName { get; set; }
        public object lastName { get; set; }
        public bool enabled { get; set; }
        public bool underEmbargo { get; set; }
        public object licenseExpiryDate { get; set; }
        public object licenseStatus { get; set; }
        public bool deleted { get; set; }
        public object emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public object phone { get; set; }
        public string address { get; set; }
        public object passportNumber { get; set; }
        public object bvn { get; set; }
        public object rcNumber { get; set; }
        public object licenseNumber { get; set; }
        public object nepcRegistrationNumber { get; set; }
        public object taxIdentificationNumber { get; set; }
        public object jobRole { get; set; }
        public object type { get; set; }
        public object organizationType { get; set; }
        public object accountCategory { get; set; }
        public bool designatedBank { get; set; }
        public object contactOrganization { get; set; }
        public object user { get; set; }
        public object lga { get; set; }
        public object createdBy { get; set; }
        public object sector { get; set; }
    }

    public class PackagingMode
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public object description { get; set; }
    }

    public class PortDischarge
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public CountryNCX country { get; set; }
    }

    public class PortShipment
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public object location { get; set; }
        public object transportationMode { get; set; }
    }

    public class ProcessingBankNCX
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string code { get; set; }
        public object firstName { get; set; }
        public object middleName { get; set; }
        public object lastName { get; set; }
        public bool enabled { get; set; }
        public bool underEmbargo { get; set; }
        public object licenseExpiryDate { get; set; }
        public object licenseStatus { get; set; }
        public bool deleted { get; set; }
        public object emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public object phone { get; set; }
        public object address { get; set; }
        public object passportNumber { get; set; }
        public object bvn { get; set; }
        public object rcNumber { get; set; }
        public object licenseNumber { get; set; }
        public object nepcRegistrationNumber { get; set; }
        public object taxIdentificationNumber { get; set; }
        public object jobRole { get; set; }
        public object type { get; set; }
        public object organizationType { get; set; }
        public object accountCategory { get; set; }
        public bool designatedBank { get; set; }
        public object contactOrganization { get; set; }
        public object user { get; set; }
        public object lga { get; set; }
        public object createdBy { get; set; }
        public object sector { get; set; }
    }

    public class ProcessingBankBranchNCX
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public object emailAddress { get; set; }
        public object phone { get; set; }
        public object bankCode { get; set; }
    }

    public class ResponseResult
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public object archivedAt { get; set; }
        public long dateSubmitted { get; set; }
        public object formNumberAssignedDate { get; set; }
        public string statusCode { get; set; }
        public string status { get; set; }
        public long expireAt { get; set; }
        public string applicationNumber { get; set; }
        public int lastApplicationNumber { get; set; }
        public double exchangeRate { get; set; }
        public int year { get; set; }
        public bool isDeleted { get; set; }
        public string accountNumber { get; set; }
        public object accountNumberPreAmend { get; set; }
        public long expectedShipmentDate { get; set; }
        public object expectedShipmentDatePreAmend { get; set; }
        public bool activeProcess { get; set; }
        public long currentStageDate { get; set; }
        public object processReset { get; set; }
        public object formNumber { get; set; }
        public object formNumberSerial { get; set; }
        public object cancellationNumberSerial { get; set; }
        public object amendmentNumberSerial { get; set; }
        public object adbApprovedDate { get; set; }
        public double estimatedValueOfGoodsNaira { get; set; }
        public object estimatedValueOfGoodsNairaPreAmend { get; set; }
        public double estimatedValueOfGoodsDollar { get; set; }
        public object estimatedValueOfGoodsDollarPreAmend { get; set; }
        public string shipperName { get; set; }
        public object shipperNamePreAmend { get; set; }
        public string shipperPhone { get; set; }
        public object shipperPhonePreAmend { get; set; }
        public string shipperAddress { get; set; }
        public object shipperAddressPreAmend { get; set; }
        public PortShipment portShipment { get; set; }
        public object portShipmentPreAmend { get; set; }
        public PortDischarge portDischarge { get; set; }
        public object portDischargePreAmend { get; set; }
        public object byOrderOf { get; set; }
        public object byOrderOfPreAmend { get; set; }
        public string consigneeName { get; set; }
        public object consigneeNamePreAmend { get; set; }
        public string consigneeEmail { get; set; }
        public object consigneeEmailPreAmend { get; set; }
        public string consigneePhone { get; set; }
        public object consigneePhonePreAmend { get; set; }
        public string consigneeAddressLine1 { get; set; }
        public object consigneeAddressLine1PreAmend { get; set; }
        public string consigneeAddressLine2 { get; set; }
        public object consigneeAddressLine2PreAmend { get; set; }
        public string consigneeAddressCity { get; set; }
        public object consigneeAddressCityPreAmend { get; set; }
        public string consigneeAddressState { get; set; }
        public object consigneeAddressStatePreAmend { get; set; }
        public ConsigneeCountry consigneeCountry { get; set; }
        public object consigneeCountryPreAmend { get; set; }
        public ProcessingBankNCX processingBank { get; set; }
        public object processingBankPreAmend { get; set; }
        public ProcessingBankBranchNCX processingBankBranch { get; set; }
        public object processingBankBranchPreAmend { get; set; }
        public object shipmentPurpose { get; set; }
        public object shipmentPurposePreAmend { get; set; }
        public List<AttachmentNCX> attachments { get; set; }
        public List<Item> items { get; set; }
        public double totalQuantity { get; set; }
        public double totalNetWeight { get; set; }
        public double totalGrossWeight { get; set; }
        public ContactNCX contact { get; set; }
        public Ncs ncs { get; set; }
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
        public ShippingLine shippingLine { get; set; }
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
        public LockedBy lockedBy { get; set; }
        public List<object> workflowNotes { get; set; }
        public object preCancellationRequestStatus { get; set; }
        public object cancellationNumber { get; set; }
        public object cancellationReason { get; set; }
        public bool cancellationInit { get; set; }
        public bool cancellationComplete { get; set; }
        public object cancellationRequestDate { get; set; }
        public object cancellationCompletedDate { get; set; }
    }

    public class FormNCXDetails
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResult responseResult { get; set; }
    }

    public class ShippingLine
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string code { get; set; }
        public object firstName { get; set; }
        public object middleName { get; set; }
        public object lastName { get; set; }
        public bool enabled { get; set; }
        public bool underEmbargo { get; set; }
        public object licenseExpiryDate { get; set; }
        public object licenseStatus { get; set; }
        public bool deleted { get; set; }
        public object emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public object phone { get; set; }
        public object address { get; set; }
        public object passportNumber { get; set; }
        public object bvn { get; set; }
        public object rcNumber { get; set; }
        public object licenseNumber { get; set; }
        public object nepcRegistrationNumber { get; set; }
        public object taxIdentificationNumber { get; set; }
        public object jobRole { get; set; }
        public object type { get; set; }
        public object organizationType { get; set; }
        public object accountCategory { get; set; }
        public bool designatedBank { get; set; }
        public object contactOrganization { get; set; }
        public object user { get; set; }
        public object lga { get; set; }
        public object createdBy { get; set; }
        public object sector { get; set; }
    }

    public class UnitOfMeasurement
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }


}
