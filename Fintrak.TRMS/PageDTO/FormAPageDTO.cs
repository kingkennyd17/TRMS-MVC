using Fintrak.TRMS.Models;

namespace Fintrak.TRMS.PageDTO
{
    public class FormAPageDTO
    {
        public PendingApplication? PendingFormA { get; set; }
        public FormADetails? FormADetail { get; set; }
        public ProcessedApplication? ProcessedFormA { get; set; }
    }
}
