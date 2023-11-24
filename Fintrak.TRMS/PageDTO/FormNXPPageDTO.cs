using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;

namespace Fintrak.TRMS.PageDTO
{
    public class FormNXPPageDTO
    {
        public PendingNXPResponseDto? PendingFormNXP { get; set; }
        public FormNXPDetailsResponse? FormNXPDetail { get; set; }
        public ProcessedNXPResponseDto? ProcessedFormNXP { get; set; }
        public ShipmentFormDetails? ShipmentFormDetail { get; set; }
        public SingleShipmentResponseDto? NXPShipments { get; set; }
    }
}
