using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IUploadRepository : IBaseRepository<IFormFile, FileUploadResponse>
    {
        Task<FileUploadResponse> UploadFile(IFormFile file, string token);
    }
}
