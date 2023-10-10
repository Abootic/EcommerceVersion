using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IConfigurationService
    {
        Task<IResult<ConfigurationDto>> Add(ConfigurationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ConfigurationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ConfigurationDto>> Update(ConfigurationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ConfigurationDto>>> Find(Expression<Func<ConfigurationDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ConfigurationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ConfigurationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
