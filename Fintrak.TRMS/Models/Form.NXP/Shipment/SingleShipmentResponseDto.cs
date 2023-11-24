using System;

namespace Fintrak.TRMS.FormNXPResponseDto
{
    public class SingleShipmentResponseDto
    {
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public SingleShipmentResultDto responseResult { get; set; }
    }

    public class SingleShipmentResultDto
    {
        public SingleShipmentContentDto[] content { get; set; }
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

    public class SingleShipmentContentDto
    {
        public string statusCode { get; set; }
        public int applicantId { get; set; }
        public DateTime? currentStageDate { get; set; }
        public string shipmentNumber { get; set; }
        public string pciNumber { get; set; }
        public double nessLevyPayable { get; set; }
        public string ciType { get; set; }
        public string ciNumber { get; set; }
        public int createdAt { get; set; }
        public double totalDollarFoB { get; set; }
        public int updatedAt { get; set; }
        public string formApplicationNumber { get; set; }
        public string applicantName { get; set; }
        public string formFormNumber { get; set; }
        public int id { get; set; }
    }
}
