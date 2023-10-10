using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ICurrencyService
    {
        Task<IResult<CurrencyDto>> Add(CurrencyDto entity, CancellationToken cancellationToken = default);
        Task<IResult<CurrencyDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<CurrencyDto>> Update(CurrencyDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<CurrencyDto>>> Find(Expression<Func<CurrencyDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<CurrencyDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<CurrencyDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
