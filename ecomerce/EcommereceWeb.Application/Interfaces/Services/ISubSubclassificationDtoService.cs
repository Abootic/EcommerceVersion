using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ISubSubclassificationDtoService
    {
        Task<IResult<SubSubclassificationDto>> Add(SubSubclassificationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<SubSubclassificationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<SubSubclassificationDto>> Update(SubSubclassificationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<SubSubclassificationDto>>> Find(Expression<Func<SubSubclassificationDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<SubSubclassificationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<SubSubclassificationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
