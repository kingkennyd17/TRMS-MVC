using System.Collections.Generic;

namespace Fintrak.TRMS.FormNXPResponseDto
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attachment
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object entity { get; set; }
        public object entityId { get; set; }
        public File file { get; set; }
    }

    public class Contact
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
        public object address { get; set; }
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

    public class ContactOrganization
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

    public class Country
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public object code3 { get; set; }
    }

    public class Currency
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double sellRate { get; set; }
        public object buyRate { get; set; }
        public object description { get; set; }
        public object exchangeRateDate { get; set; }
        public int currencyMarket { get; set; }
        public double midRevalRate { get; set; }
        public object country { get; set; }
        public object exchangeRate { get; set; }
        public object exchangeRateApplicantCurrency { get; set; }
        public object currency { get; set; }
    }

    public class DesignatedBank
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

    public class Dpr
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

    public class File
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string fileId { get; set; }
        public string fileName { get; set; }
        public string diskFileName { get; set; }
        public string label { get; set; }
        public string mimeType { get; set; }
        public bool deleted { get; set; }
    }

    public class FormContact
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
        public ContactOrganization contactOrganization { get; set; }
        public object user { get; set; }
        public object lga { get; set; }
        public object createdBy { get; set; }
        public object sector { get; set; }
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

    public class InitialShipment
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object form { get; set; }
        public object shipmentNumber { get; set; }
        public object statusCode { get; set; }
        public object expectedShipmentDateExporter { get; set; }
        public long expectedShipmentDate { get; set; }
        public object expectedShipmentDatePreAmend { get; set; }
        public object vesselNameTmp { get; set; }
        public object vesselNameExporter { get; set; }
        public object vesselName { get; set; }
        public object vesselNamePreAmend { get; set; }
        public object exchangeRate { get; set; }
        public object exchangeRateApplicantCurrency { get; set; }
        public double totalNetWeight { get; set; }
        public object totalNetWeightExporter { get; set; }
        public object ncsTotalNetWeight { get; set; }
        public object meaTotalNetWeight { get; set; }
        public double totalGrossWeight { get; set; }
        public object totalGrossWeightExporter { get; set; }
        public object ncsTotalGrossWeight { get; set; }
        public object meaTotalGrossWeight { get; set; }
        public double totalQuantity { get; set; }
        public object totalQuantityExporter { get; set; }
        public object ncsTotalQuantity { get; set; }
        public object meaTotalQuantity { get; set; }
        public object dprTotalQuantity { get; set; }
        public double totalCF { get; set; }
        public double totalFreightCharges { get; set; }
        public double totalFoB { get; set; }
        public double totalDollarFoB { get; set; }
        public bool piaApproved { get; set; }
        public bool ncsApproved { get; set; }
        public object currentDPRActor { get; set; }
        public object currentMEAActor { get; set; }
        public bool dprApproved { get; set; }
        public bool meaApproved { get; set; }
        public bool activeProcess { get; set; }
        public object currentStageDate { get; set; }
        public object processReset { get; set; }
        public PortDestination portDestination { get; set; }
        public object portDestinationPreAmend { get; set; }
        public object portDestinationExporter { get; set; }
        public List<Item> items { get; set; }
        public object attachments { get; set; }
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
        public object amendments { get; set; }
        public object lockedBy { get; set; }
        public object workflowNotes { get; set; }
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

    public class Item
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public double unitPrice { get; set; }
        public object unitPricePreAmend { get; set; }
        public double exporterUnitPrice { get; set; }
        public object ncsUnitPrice { get; set; }
        public object meaUnitPrice { get; set; }
        public double quantity { get; set; }
        public object quantityPreAmend { get; set; }
        public double exporterQuantity { get; set; }
        public double ncsQuantity { get; set; }
        public double meaQuantity { get; set; }
        public double dprQuantity { get; set; }
        public double netWeight { get; set; }
        public double exporterNetWeight { get; set; }
        public object ncsNetWeight { get; set; }
        public object meaNetWeight { get; set; }
        public double grossWeight { get; set; }
        public double exporterGrossWeight { get; set; }
        public object ncsGrossWeight { get; set; }
        public object meaGrossWeight { get; set; }
        public double foB { get; set; }
        public double foBExporter { get; set; }
        public object nessLevyPayable { get; set; }
        public double dollarFoB { get; set; }
        public double dollarFoBExporter { get; set; }
        public double frightCharge { get; set; }
        public object frightChargePreAmend { get; set; }
        public object quality { get; set; }
        public object originalShipmentItemId { get; set; }
        public string description { get; set; }
        public object descriptionPreAmend { get; set; }
        public HsCode hsCode { get; set; }
        public object hsCodePreAmend { get; set; }
        public UnitOfMeasurement unitOfMeasurement { get; set; }
        public object dprUnitOfMeasurement { get; set; }
        public PackagingMode packagingMode { get; set; }
        public SectoralPurpose sectoralPurpose { get; set; }
        public List<object> dgdTagValues { get; set; }
        public bool deleted { get; set; }
    }

    public class LoadingTerminal
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public object description { get; set; }
    }

    public class MonitoringMea
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
        public string emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public string phone { get; set; }
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

    public class NonInspectionReason
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string reason { get; set; }
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

    public class PaymentMode
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Pia
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
        public string emailAddress { get; set; }
        public object emailAddress2 { get; set; }
        public string phone { get; set; }
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

    public class PortDestination
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public Country country { get; set; }
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

    public class ProcessingBank
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

    public class ProcessingBankBranch
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

    public class ResponseResultDetails
    {
        public int id { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public object archivedAt { get; set; }
        public Contact contact { get; set; }
        public object tin { get; set; }
        public int year { get; set; }
        public string formType { get; set; }
        public string statusCode { get; set; }
        public string status { get; set; }
        public string applicationNumber { get; set; }
        public object lastApplicationNumber { get; set; }
        public string formNumber { get; set; }
        public int formNumberSerial { get; set; }
        public object cancellationNumberSerial { get; set; }
        public object extensionNumberSerial { get; set; }
        public object formNumberAssignedDate { get; set; }
        public object amendmentNumberSerial { get; set; }
        public bool amendmentInit { get; set; }
        public bool cancelled { get; set; }
        public bool isDeleted { get; set; }
        public long expireAt { get; set; }
        public int expiryPeriod { get; set; }
        public object dateSubmitted { get; set; }
        public bool activeProcess { get; set; }
        public object currentStageDate { get; set; }
        public bool processReset { get; set; }
        public object currentPVSVersion { get; set; }
        public string consigneeName { get; set; }
        public string consigneeEmail { get; set; }
        public string consigneePhone { get; set; }
        public string consigneeAddressLine1 { get; set; }
        public object consigneeAddressLine2 { get; set; }
        public string consigneeAddressCity { get; set; }
        public string consigneeAddressState { get; set; }
        public object consigneeCountry { get; set; }
        public object byOrderOf { get; set; }
        public object nepcNumber { get; set; }
        public object cacNumber { get; set; }
        public object licenseNumber { get; set; }
        public string rcNumber { get; set; }
        public string accountNumber { get; set; }
        public object accountNumberPreAmend { get; set; }
        public string processingFeeAccountNumber { get; set; }
        public object processingFeeAccountNumberPreAmend { get; set; }
        public string sector { get; set; }
        public int numOfItemsExpected { get; set; }
        public double exchangeRate { get; set; }
        public double exchangeRateApplicantCurrency { get; set; }
        public double totalNetWeight { get; set; }
        public double totalNetWeightExporter { get; set; }
        public object ncsTotalNetWeight { get; set; }
        public object meaTotalNetWeight { get; set; }
        public double totalGrossWeight { get; set; }
        public double totalGrossWeightExporter { get; set; }
        public object ncsTotalGrossWeight { get; set; }
        public object meaTotalGrossWeight { get; set; }
        public double totalQuantity { get; set; }
        public double totalQuantityExporter { get; set; }
        public double ncsTotalQuantity { get; set; }
        public double meaTotalQuantity { get; set; }
        public double dprTotalQuantity { get; set; }
        public double totalCF { get; set; }
        public double totalFreightCharges { get; set; }
        public double totalFoB { get; set; }
        public double totalFoBExporter { get; set; }
        public double totalDollarFoBExporter { get; set; }
        public double totalDollarFoB { get; set; }
        public double nessLevyPayable { get; set; }
        public object nessLevyPaymentPercent { get; set; }
        public bool shipmentsCompleted { get; set; }
        public bool endShipmentsRequestApproved { get; set; }
        public object endShipmentsRequestDate { get; set; }
        public object endShipmentsRequestReason { get; set; }
        public DesignatedBank designatedBank { get; set; }
        public object designatedBankPreAmend { get; set; }
        public ProcessingBank processingBank { get; set; }
        public object processingBankPreAmend { get; set; }
        public ProcessingBankBranch processingBankBranch { get; set; }
        public object processingBankBranchPreAmend { get; set; }
        public Country country { get; set; }
        public object countryPreAmend { get; set; }
        public object countryExporter { get; set; }
        public object inspectionLocation { get; set; }
        public object inspectionLocationPreAmend { get; set; }
        public TransportationMode transportationMode { get; set; }
        public object transportationModePreAmend { get; set; }
        public PortShipment portShipment { get; set; }
        public object portShipmentPreAmend { get; set; }
        public LoadingTerminal loadingTerminal { get; set; }
        public object loadingTerminalPreAmend { get; set; }
        public Currency currency { get; set; }
        public object currencyPreAmend { get; set; }
        public PaymentMode paymentMode { get; set; }
        public object paymentModePreAmend { get; set; }
        public Pia pia { get; set; }
        public object piaPreAmend { get; set; }
        public Ncs ncs { get; set; }
        public Ted ted { get; set; }
        public MonitoringMea monitoringMea { get; set; }
        public object monitoringMeaPreAmend { get; set; }
        public object tempShippingLine { get; set; }
        public object tempShippingLinePreAmend { get; set; }
        public Dpr dpr { get; set; }
        public List<NonInspectionReason> nonInspectionReasons { get; set; }
        public List<object> pvsResponses { get; set; }
        public List<object> failedInspections { get; set; }
        public List<object> permits { get; set; }
        public List<Attachment> attachments { get; set; }
        public object extension1PreStatusCode { get; set; }
        public object extension1ExpirationDate { get; set; }
        public object extension1Number { get; set; }
        public object extension1Reason { get; set; }
        public bool extension1Init { get; set; }
        public bool extension1Complete { get; set; }
        public object extension1RequestDate { get; set; }
        public object extension1CompletedDate { get; set; }
        public bool dueExtension1 { get; set; }
        public object extension2PreStatusCode { get; set; }
        public object extension2ExpirationDate { get; set; }
        public object extension2Number { get; set; }
        public object extension2Reason { get; set; }
        public bool extension2Init { get; set; }
        public bool extension2Complete { get; set; }
        public object extension2RequestDate { get; set; }
        public object extension2CompletedDate { get; set; }
        public bool dueExtension2 { get; set; }
        public object preCancellationRequestStatus { get; set; }
        public object cancellationNumber { get; set; }
        public object cancellationReason { get; set; }
        public bool cancellationInit { get; set; }
        public bool cancellationComplete { get; set; }
        public object cancellationRequestDate { get; set; }
        public object cancellationCompletedDate { get; set; }
        public InitialShipment initialShipment { get; set; }
        public object shipmentTmp { get; set; }
        public List<object> shipments { get; set; }
        public object lockedBy { get; set; }
        public List<object> amendments { get; set; }
        public List<WorkflowNote> workflowNotes { get; set; }
        public object preAmendmentRequestStatus { get; set; }
        public object amendmentNumber { get; set; }
        public object amendmentReason { get; set; }
        public bool amendmentComplete { get; set; }
        public object amendmentRequestDate { get; set; }
        public object amendmentCompletedDate { get; set; }
        public List<object> amendmentAttachments { get; set; }
        public object amendmentHistory { get; set; }
        public object einvoice { get; set; }
        public bool oilExport { get; set; }
    }

    public class FormNXPDetailsResponse
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultDetails responseResult { get; set; }
    }

    public class SectoralPurpose
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Ted
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

    public class TransportationMode
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public object description { get; set; }
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

    public class WorkflowNote
    {
        public int id { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object archivedAt { get; set; }
        public object formId { get; set; }
        public bool approved { get; set; }
        public int formTypeId { get; set; }
        public object rejectionReason { get; set; }
        public FormContact formContact { get; set; }
        public object daemonReviewerName { get; set; }
        public object daemonSupervisorName { get; set; }
        public object applicationStatusCode { get; set; }
        public object noteTitle { get; set; }
        public string noteDescription { get; set; }
        public bool deleted { get; set; }
    }



}
