using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IMasterDataService
    {
        Task<IResult<MasterDataDto>> Add(MasterDataDto entity, CancellationToken cancellationToken = default);
        Task<IResult<MasterDataDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<MasterDataDto>> Update(MasterDataDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<MasterDataDto>>> Find(Expression<Func<MasterDataDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<MasterDataDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<MasterDataDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
