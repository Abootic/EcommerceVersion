using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ISubSubclassificationService
    {
        Task<IResult<SubSubclassificationDto>> Add(SubSubclassificationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<SubSubclassificationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<SubSubclassificationDto>> Update(SubSubclassificationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<SubSubclassificationDto>>> Find(Expression<Func<SubSubclassification, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<SubSubclassificationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<SubSubclassificationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
