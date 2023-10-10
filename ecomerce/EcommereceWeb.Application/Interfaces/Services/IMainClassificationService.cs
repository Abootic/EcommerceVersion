using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IMainClassificationService
    {
        Task<IResult<MainClassificationDto>> Add(MainClassificationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<MainClassificationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<MainClassificationDto>> Update(MainClassificationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<MainClassificationDto>>> Find(Expression<Func<MainClassificationDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<MainClassificationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<MainClassificationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
