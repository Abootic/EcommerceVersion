using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IBasicClassificationService
    {
        Task<IResult<BasicClassificationDto>> Add(BasicClassificationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<BasicClassificationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<BasicClassificationDto>> Update(BasicClassificationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<BasicClassificationDto>>> Find(Expression<Func<BasicClassification, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<BasicClassificationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<BasicClassificationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
