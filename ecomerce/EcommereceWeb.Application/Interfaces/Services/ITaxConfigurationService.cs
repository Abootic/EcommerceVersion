using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ITaxConfigurationService
    {
        Task<IResult<TaxConfigurationDto>> Add(TaxConfigurationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<TaxConfigurationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<TaxConfigurationDto>> Update(TaxConfigurationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<TaxConfigurationDto>>> Find(Expression<Func<TaxConfigurationDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<TaxConfigurationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<TaxConfigurationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
