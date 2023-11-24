using System.Collections.Generic;

namespace Fintrak.TRMS.FormNXPResponseDto
{
    public class PendingNXPResponseDto
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public ResponseResultPendingDto responseResult { get; set; }
    }

    public class ResponseResultPendingDto
    {
        public List<ContentPendingDto>? content { get; set; }
        public PageableDto pageable { get; set; }
        public bool last { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public bool first { get; set; }
        public SortBDto sort { get; set; }
        public int numberOfElements { get; set; }
        public int size { get; set; }
        public int number { get; set; }
    }

    public class ContentPendingDto
    {
        public string statusCode { get; set; }
        public string currencyCode { get; set; }
        public string status { get; set; }
        public int? initialShipmentTotalQuantity { get; set; }
        public double? initialShipmentTotalDollarFoB { get; set; }
        public string ProcessingBankId { get; set; }
        public string ProcessingBankName { get; set; }
        public string designatedBankId { get; set; }
        public int applicantId { get; set; }
        public string designatedBankName { get; set; }
        public string formNumber { get; set; }
        public long? currentStageDate { get; set; }
        public string applicationNumber { get; set; }
        public long? createdAt { get; set; }
        public string exchangeRateApplicantCurrency { get; set; }
        public string exchangeRate { get; set; }
        public long? updatedAt { get; set; }
        public double? initialShipmentNessLevyPayable { get; set; }
        public string processingBankCode { get; set; }
        public string dessignatedBankCode { get; set; }
        public string applicantName { get; set; }
        public string processingBankBranches { get; set; }
        public int id { get; set; }
    }

}
