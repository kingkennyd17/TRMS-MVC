using Fintrak.TRMS.Models;

namespace Fintrak.TRMS.PageDTO
{
    public class FormNCXPageDTO
    {
        public PendingApplicationNCX? PendingFormNCX { get; set; }
        public FormNCXDetails? FormNCXDetail { get; set; }
        public ProcessedApplicationNCX? ProcessedFormNCX { get; set; }
    }
}
