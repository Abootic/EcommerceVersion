using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IBrandService
    {
        Task<IResult<BrandDto>> Add(BrandDto entity, CancellationToken cancellationToken = default);
        Task<IResult<BrandDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<BrandDto>> Update(BrandDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<BrandDto>>> Find(Expression<Func<BrandDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<BrandDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<BrandDto>> GetById(int Id, CancellationToken cancellationToken = default);
    } 


}
