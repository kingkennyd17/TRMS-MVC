using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IDownloadFileRepository : IBaseRepository<GetModel, DownloadFileResponse>
    {
        Task<DownloadFileResponse> DownloadFile(string token, string fileId);
    }
}
