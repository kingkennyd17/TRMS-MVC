using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IViewFileRepository : IBaseRepository<GetModel, byte[]>
    {
        Task<byte[]> ViewFile(string token, string fileId);
    }
}
