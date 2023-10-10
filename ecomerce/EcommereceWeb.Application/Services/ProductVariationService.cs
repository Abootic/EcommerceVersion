using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class ProductVariationService : IProductVariationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductVariationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IResult<ProductVariationDto>> Add(ProductVariationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<ProductVariation>(entity);
                var res = await _repositoryManager.ProductVariationRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ProductVariationDto>(res);
                    return await Result<ProductVariationDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<ProductVariationDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<ProductVariationDto>.FailAsync($"Exp in Add ProductVariationDto: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public async Task<IResult<IEnumerable<ProductVariationDto>>> Find(Expression<Func<ProductVariationDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<ProductVariation, bool>>>(expression);
                var res = await _repositoryManager.ProductVariationRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<ProductVariationDto>>.FailAsync("--- there is no any ProductVariation like find expression ---");
                return await Result<IEnumerable<ProductVariationDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductVariationDto>>(res), "");

            }
            catch (Exception ex)
            {

                return await Result<IEnumerable<ProductVariationDto>>.FailAsync($"Exp in find ProductVariationDto: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }
        }

        public async Task<IResult<IEnumerable<ProductVariationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductVariationRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<ProductVariationDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductVariationDto>>(res));
                }
                return await Result<IEnumerable<ProductVariationDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<ProductVariationDto>>.FailAsync($"Exp in GetAll ProductVariationDto: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public async Task<IResult<ProductVariationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductVariationRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<ProductVariationDto>.SucessAsync(_mapper.Map<ProductVariationDto>(res));
                }
                return await Result<ProductVariationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<ProductVariationDto>.FailAsync($"Exp in GetById ProductVariationDto: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public async Task<IResult<ProductVariationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.ProductVariationRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.ProductVariationRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<ProductVariationDto>.SucessAsync(_mapper.Map<ProductVariationDto>(res));
                    }
                    return await Result<ProductVariationDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<ProductVariationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<ProductVariationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductVariationDto>> Update(ProductVariationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<ProductVariation>(entity);
                var res = await _repositoryManager.ProductVariationRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ProductVariationDto>(res);
                    return await Result<ProductVariationDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<ProductVariationDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<ProductVariationDto>.FailAsync($"Exp in Update ProductVariationDto: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }
    }

}
