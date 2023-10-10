using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using System.Linq.Expressions;
using Attribute = EcommereceWeb.Domain.Entity.Attribute;


namespace EcommereceWeb.Application.Services
{
    public class AttributeService : IAttributeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public AttributeService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IResult<AttributeDto>> Add(AttributeDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                if (entity == null) return await Result<AttributeDto>.FailAsync("--- entity is null ---");

                var entityMap = _mapper.Map<Attribute>(entity);
                var res = await _repositoryManager.AttributeRepository.AddAndReturn(entityMap);
                if(res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    var map = _mapper.Map<AttributeDto>(res);
                    return await Result<AttributeDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<AttributeDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<AttributeDto>.FailAsync($"------------------- Exp in add Attribute : {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<IEnumerable<AttributeDto>>> Find(Expression<Func<AttributeDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<Attribute, bool>>>(expression);
                var res = await _repositoryManager.AttributeRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<AttributeDto>>.FailAsync("--- there is no any Attribute like find expression ---");
                return await Result<IEnumerable<AttributeDto>>.SucessAsync(_mapper.Map<IEnumerable<AttributeDto>>(res), "");

            }
            catch (Exception ex)
            {

                return await Result<IEnumerable<AttributeDto>>.FailAsync($"Exp in find Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }

        }

        public async Task<IResult<IEnumerable<AttributeDto>>> GetAll(CancellationToken cancellationToken = default)
        {

            try
            {
                var res = await _repositoryManager.AttributeRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<AttributeDto>>.SucessAsync(_mapper.Map<IEnumerable<AttributeDto>>(res));
                }
                return await Result<IEnumerable<AttributeDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<AttributeDto>>.FailAsync($"Exp in get all Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ."); 
            }
        }

        public async Task<IResult<AttributeDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.AttributeRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<AttributeDto>.SucessAsync(_mapper.Map<AttributeDto>(res));
                }
                return await Result<AttributeDto>.FailAsync($" لايوجد بيانات لهذا الرقم : {Id}---");

            }
            catch (Exception ex)
            {
                return await Result<AttributeDto>.FailAsync($"Exp in get Attribute Id: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ."); 
            }
        }

        public async Task<IResult<AttributeDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.AttributeRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.AttributeRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (res != null)
                    {
                        return await Result<AttributeDto>.SucessAsync(_mapper.Map<AttributeDto>(res));
                    }
                    return await Result<AttributeDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<AttributeDto>.FailAsync($"--- لا يوجد عنصر لديه هذا الرقم : {Id}---");

            }
            catch (Exception ex)
            {
                return await Result<AttributeDto>.FailAsync($"------------------- Exp in remove Attribute: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");            }
        }

        public async Task<IResult<AttributeDto>> Update(AttributeDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                if (entity == null) return await Result<AttributeDto>.FailAsync("--- entity is null ---");
                var entityMap = _mapper.Map<Attribute>(entity);
                var res = await _repositoryManager.AttributeRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<AttributeDto>(res);
                    return await Result<AttributeDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<AttributeDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<AttributeDto>.FailAsync($"------------------- Exp in update Attribute: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }
    }

}
