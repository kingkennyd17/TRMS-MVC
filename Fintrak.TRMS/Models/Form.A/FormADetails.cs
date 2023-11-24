using System;
using System.Collections.Generic;

namespace Fintrak.TRMS.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool Enabled { get; set; }
        public bool UnderEmbargo { get; set; }
        public DateTime? LicenseExpiryDate { get; set; }
        public string LicenseStatus { get; set; }
        public bool Deleted { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddress2 { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PassportNumber { get; set; }
        public string Bvn { get; set; }
        public string RcNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string NepcRegistrationNumber { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public object JobRole { get; set; }
        public string Type { get; set; }
        public object OrganizationType { get; set; }
        public object AccountCategory { get; set; }
        public bool DesignatedBank { get; set; }
        public object ContactOrganization { get; set; }
        public object User { get; set; }
        public string Lga { get; set; }
        public string CreatedBy { get; set; }
        public string Sector { get; set; }
    }

    public class PaymentMode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Code3 { get; set; }
    }

    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal SellRate { get; set; }
    }

    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class File
    {
        public int Id { get; set; }
        public long? CreatedAt { get; set; }
        public long? UpdatedAt { get; set; }
        public long? ArchivedAt { get; set; }
        public string FileId { get; set; }
        public string FileName { get; set; }
        public string DiskFileName { get; set; }
        public string Label { get; set; }
        public string MimeType { get; set; }
        public bool Deleted { get; set; }
    }

    public class ResponseResultFormA
    {
        public int Id { get; set; }
        public long? CreatedAt { get; set; }
        public long? UpdatedAt { get; set; }
        public long? ArchivedAt { get; set; }
        public Contact Contact { get; set; }
        public int ValidForForex { get; set; }
        public int Year { get; set; }
        public string ApplicationNumber { get; set; }
        public string StatusCode { get; set; }
        public string Status { get; set; }
        public string FormType { get; set; }
        public string ApplicantType { get; set; }
        public bool IsDeleted { get; set; }
        public string ProcessingFeeAccountNumber { get; set; }
        public string ProcessingFeeAccountNumberPreAmend { get; set; }
        public string RejectionStakeholder { get; set; }
        public bool ActiveProcess { get; set; }
        public DateTime? CurrentStageDate { get; set; }
        public object ProcessReset { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public object PaymentModePreAmend { get; set; }
        public object ExchangeRate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantPhone { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantTINBVN { get; set; }
        public string ApplicantRcNumber { get; set; }
        public string ApplicantAddress { get; set; }
        public TransactionPurpose TransactionPurpose { get; set; }
        public string TransactionPurposeOther { get; set; }
        public string TransactionPurposePreAmend { get; set; }
        public string DoctorName { get; set; }
        public string DoctorNamePreAmend { get; set; }
        public string ReferringHospitalName { get; set; }
        public string ReferringHospitalNamePreAmend { get; set; }
        public string ReferringHospitalCity { get; set; }
        public string ReferringHospitalCityPreAmend { get; set; }
        public string ReferringHospitalPhone { get; set; }
        public string ReferringHospitalPhonePreAmend { get; set; }
        public string ReferringHospitalEmail { get; set; }
        public string ReferringHospitalEmailPreAmend { get; set; }
        public string ReferringHospitalAddress { get; set; }
        public string ReferringHospitalAddressPreAmend { get; set; }
        public string ReferredHospitalName { get; set; }
        public string ReferredHospitalNamePreAmend { get; set; }
        public string ReferredHospitalState { get; set; }
        public string ReferredHospitalStatePreAmend { get; set; }
        public string ReferredHospitalCity { get; set; }
        public string ReferredHospitalCityPreAmend { get; set; }
        public string ReferredHospitalPhone { get; set; }
        public string ReferredHospitalPhonePreAmend { get; set; }
        public string ReferredHospitalEmail { get; set; }
        public string ReferredHospitalEmailPreAmend { get; set; }
        public string ReferredHospitalAddress { get; set; }
        public string ReferredHospitalAddressPreAmend { get; set; }
        public string ReferringHospitalState { get; set; }
        public string ReferringHospitalStatePreAmend { get; set; }
        public string ReferredHospitalCountry { get; set; }
        public string ReferredHospitalCountryPreAmend { get; set; }
        public Ted Ted { get; set; }
        public string Branch { get; set; }
        public string BranchPreAmend { get; set; }
        public ProcessingBank ProcessingBank { get; set; }
        public object ProcessingBankPreAmend { get; set; }
        public string ApprovingStakeholder { get; set; }
        public string DisbursementStakeholder { get; set; }
        public ProcessingBankBranch ProcessingBankBranch { get; set; }
        public object ProcessingBankBranchPreAmend { get; set; }
        public object TedApproved { get; set; }
        public List<BeneficiaryFormA> Beneficiaries { get; set; }
        public bool DisbursementsCloseOut { get; set; }
        public List<object> EndDisbursementsRequests { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<object> WorkflowNotes { get; set; }
        public object PreCancellationRequestStatus { get; set; }
        public string CancellationNumber { get; set; }
        public string CancellationReason { get; set; }
        public bool CancellationInit { get; set; }
        public bool CancellationComplete { get; set; }
        public DateTime? CancellationRequestDate { get; set; }
        public DateTime? CancellationCompletedDate { get; set; }
        public object AmendmentNumberSerial { get; set; }
        public object PreAmendmentRequestStatus { get; set; }
        public object AmendmentNumber { get; set; }
        public object AmendmentReason { get; set; }
        public bool AmendmentInit { get; set; }
        public bool AmendmentComplete { get; set; }
        public object AmendmentRequestDate { get; set; }
        public object AmendmentCompletedDate { get; set; }
        public List<object> AmendmentAttachments { get; set; }
        public object AmendmentHistory { get; set; }
        public List<object> Amendments { get; set; }
        public object LockedBy { get; set; }
        public object TimeLocked { get; set; }
    }

    public class ProcessingBankBranch
    {
        public int Id { get; set; }
        public object CreatedAt { get; set; }
        public object UpdatedAt { get; set; }
        public object ArchivedAt { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public object EmailAddress { get; set; }
        public object Phone { get; set; }
        public object BankCode { get; set; }
    }

    public class ProcessingBank
    {
        public int Id { get; set; }
        public object CreatedAt { get; set; }
        public object UpdatedAt { get; set; }
        public object ArchivedAt { get; set; }
        public string Name { get; set; }
        public object Description { get; set; }
        public string Code { get; set; }
        public object FirstName { get; set; }
        public object MiddleName { get; set; }
        public object LastName { get; set; }
        public bool Enabled { get; set; }
        public bool UnderEmbargo { get; set; }
        public object LicenseExpiryDate { get; set; }
        public object LicenseStatus { get; set; }
        public bool Deleted { get { return false; } set { } }
        public object EmailAddress { get; set; }
        public object EmailAddress2 { get; set; }
        public object Phone { get; set; }
        public object Address { get; set; }
        public object PassportNumber { get; set; }
        public object Bvn { get; set; }
        public object RcNumber { get; set; }
        public object LicenseNumber { get; set; }
        public object NepcRegistrationNumber { get; set; }
        public object TaxIdentificationNumber { get; set; }
        public object JobRole { get; set; }
        public object Type { get; set; }
        public object OrganizationType { get; set; }
        public object AccountCategory { get; set; }
        public bool DesignatedBank { get { return false; } set { } }
        public object ContactOrganization { get; set; }
        public object User { get; set; }
        public object Lga { get; set; }
        public object CreatedBy { get; set; }
        public object Sector { get; set; }
    }

    public class TransactionPurpose
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string BeneficiaryType { get; set; }
        public double? LimitAmount { get; set; }
        public object Attachments { get; set; }
        public TradeCategory TradeCategory { get; set; }
    }

    public class TradeCategory
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public object Description { get; set; }
    }

    public class Ted
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Description { get; set; }
        public string Code { get; set; }
        public object FirstName { get; set; }
        public object MiddleName { get; set; }
        public object LastName { get; set; }
        public bool Enabled { get; set; }
        public bool UnderEmbargo { get; set; }
        public object LicenseExpiryDate { get; set; }
        public object LicenseStatus { get; set; }
        public bool Deleted { get; set; }
        public object EmailAddress { get; set; }
        public object EmailAddress2 { get; set; }
        public object Phone { get; set; }
        public object Address { get; set; }
        public object PassportNumber { get; set; }
        public object Bvn { get; set; }
        public object RcNumber { get; set; }
        public object LicenseNumber { get; set; }
        public object NepcRegistrationNumber { get; set; }
        public object TaxIdentificationNumber { get; set; }
        public object JobRole { get; set; }
        public object Type { get; set; }
        public object OrganizationType { get; set; }
        public object AccountCategory { get; set; }
        public bool DesignatedBank { get; set; }
        public object ContactOrganization { get; set; }
        public object User { get; set; }
        public object Lga { get; set; }
        public object CreatedBy { get; set; }
        public object Sector { get; set; }
    }

    public class BeneficiaryFormA
    {
        public int Id { get; set; }
        public object CreatedAt { get; set; }
        public object UpdatedAt { get; set; }
        public object ArchivedAt { get; set; }
        public List<object> Disbursements { get; set; }
        public object DisbursementCompleted { get; set; }
        public string Bvn { get; set; }
        public object BvnPreAmend { get; set; }
        public string Name { get; set; }
        public object NamePreAmend { get; set; }
        public object Phone { get; set; }
        public object PhonePreAmend { get; set; }
        public string Email { get; set; }
        public object EmailPreAmend { get; set; }
        public object City { get; set; }
        public object CityPreAmend { get; set; }
        public object State { get; set; }
        public object StatePreAmend { get; set; }
        public object AddressLine1 { get; set; }
        public object AddressLine1PreAmend { get; set; }
        public object AddressLine2 { get; set; }
        public object AddressLine2PreAmend { get; set; }
        public string PassportNumber { get; set; }
        public object PassportNumberPreAmend { get; set; }
        public Country Country { get; set; }
        public object CountryPreAmend { get; set; }
        public decimal? AmountRequested { get; set; }
        public object AmountRequestedPreAmend { get; set; }
        public Currency Currency { get; set; }
        public object CurrencyPreAmend { get; set; }
        public Airline Airline { get; set; }
        public object AirlinePreAmend { get; set; }
        public object AirlineOther { get; set; }
        public object AirlineOtherPreAmend { get; set; }
        public string AirTicketNumber { get; set; }
        public object AirTicketNumberPreAmend { get; set; }
        public string Route { get; set; }
        public object RoutePreAmend { get; set; }
        public object StudentName { get; set; }
        public object StudentNamePreAmend { get; set; }
        public object StudentPassportNo { get; set; }
        public object StudentPassportNoPreAmend { get; set; }
        public object BankAccountName { get; set; }
        public object BankAccountNamePreAmend { get; set; }
        public object BankAccountAddress { get; set; }
        public object BankAccountAddressPreAmend { get; set; }
        public object BankAccountIban { get; set; }
        public object BankAccountIbanPreAmend { get; set; }
        public object BankAccountSwiftCode { get; set; }
        public object BankAccountSwiftCodePreAmend { get; set; }
        public object BankAccountNumber { get; set; }
        public object BankAccountNumberPreAmend { get; set; }
        public object BankAccountCorrespondenceBankName { get; set; }
        public object BankAccountCorrespondenceBankNamePreAmend { get; set; }
        public object BankAccountCorrespondenceBankAddress { get; set; }
        public object BankAccountCorrespondenceBankAddressPreAmend { get; set; }
        public object BankAccountCorrespondenceBankSwiftCode { get; set; }
        public object BankAccountCorrespondenceBankSwiftCodePreAmend { get; set; }
    }

    public class Attachment
    {
        public int Id { get; set; }
        public object CreatedAt { get; set; }
        public object UpdatedAt { get; set; }
        public object ArchivedAt { get; set; }
        public object Entity { get; set; }
        public object EntityId { get; set; }
        public File File { get; set; }
    }

    public class FormADetails
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public ResponseResultFormA ResponseResult { get; set; }
    }

}
