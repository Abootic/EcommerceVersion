using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IDetailsDataService
    {
        Task<IResult<DetailsDataDto>> Add(DetailsDataDto entity, CancellationToken cancellationToken = default);
        Task<IResult<DetailsDataDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<DetailsDataDto>> Update(DetailsDataDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<DetailsDataDto>>> Find(Expression<Func<DetailsDataDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<DetailsDataDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<DetailsDataDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
