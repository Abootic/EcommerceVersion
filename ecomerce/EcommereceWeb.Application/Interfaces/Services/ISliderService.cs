using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ISliderService
    {
        Task<IResult<SliderDto>> Add(SliderDto entity, CancellationToken cancellationToken = default);
        Task<IResult<SliderDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<SliderDto>> Update(SliderDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<SliderDto>>> Find(Expression<Func<SliderDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<SliderDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<SliderDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
