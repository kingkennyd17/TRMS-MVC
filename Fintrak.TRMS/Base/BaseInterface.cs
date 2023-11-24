using System.Threading.Tasks;

namespace Fintrak.TRMS.Base
{
    public interface IBaseRepository<T, R>
    {
        Task<R> CreateAsync(T model, string apiUrl, string token);
        Task<R> GetAsync(string apiUrl, string token);
        Task<R> UpdateAsync(T model, string apiUrl, string token);
        Task<bool> DeleteAsync(T model, string apiUrl, string token);
    }
}
