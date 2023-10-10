using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class AttributeItemService : IAttributeItemService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public AttributeItemService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IResult<AttributeItemDto>> Add(AttributeItemDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                if (entity == null) return await Result<AttributeItemDto>.FailAsync("--- entity is null ---");

                var entityMap = _mapper.Map<AttributeItem>(entity);
                var res = await _repositoryManager.AttributeItemRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    var map = _mapper.Map<AttributeItemDto>(res);
                    return await Result<AttributeItemDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<AttributeItemDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<AttributeItemDto>.FailAsync($"------------------- Exp in add Attribute items: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<IEnumerable<AttributeItemDto>>> Find(Expression<Func<AttributeItemDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<AttributeItem, bool>>>(expression);
                var res = await _repositoryManager.AttributeItemRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<AttributeItemDto>>.FailAsync("--- there is no any Attribute item like find expression ---");
                return await Result<IEnumerable<AttributeItemDto>>.SucessAsync(_mapper.Map<IEnumerable<AttributeItemDto>>(res), "");

            }
            catch (Exception ex)
            {

                return await Result<IEnumerable<AttributeItemDto>>.FailAsync($"Exp in find Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }

        }

        public async Task<IResult<IEnumerable<AttributeItemDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.AttributeItemRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<AttributeItemDto>>.SucessAsync(_mapper.Map<IEnumerable<AttributeItemDto>>(res));
                }
                return await Result<IEnumerable<AttributeItemDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<AttributeItemDto>>.FailAsync($"Exp in get all Attribute items: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public async Task<IResult<AttributeItemDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.AttributeItemRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<AttributeItemDto>.SucessAsync(_mapper.Map<AttributeItemDto>(res));
                }
                return await Result<AttributeItemDto>.FailAsync($" لايوجد بيانات لهذا الرقم : {Id}---");

            }
            catch (Exception ex)
            {
                return await Result<AttributeItemDto>.FailAsync($"Exp in get Attribute items Id: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public  async Task<IResult<AttributeItemDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.AttributeItemRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.AttributeItemRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (res != null)
                    {
                        return await Result<AttributeItemDto>.SucessAsync(_mapper.Map<AttributeItemDto>(res));
                    }
                    return await Result<AttributeItemDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<AttributeItemDto>.FailAsync($"--- لا يوجد عنصر لديه هذا الرقم : {Id}---");

            }
            catch (Exception ex)
            {
                return await Result<AttributeItemDto>.FailAsync($"------------------- Exp in remove Attribute item: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<AttributeItemDto>> Update(AttributeItemDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                if (entity == null) return await Result<AttributeItemDto>.FailAsync("--- entity is null ---");
                var entityMap = _mapper.Map<AttributeItem>(entity);
                var res = await _repositoryManager.AttributeItemRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<AttributeItemDto>(res);
                    return await Result<AttributeItemDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<AttributeItemDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<AttributeItemDto>.FailAsync($"------------------- Exp in update AttributeItem: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }
    }

}
