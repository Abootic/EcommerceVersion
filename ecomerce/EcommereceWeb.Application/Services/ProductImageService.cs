using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class ProductImageService : IProductImageService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductImageService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<ProductImageDto>> Add(ProductImageDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<ProductImage>(entity);
                var res = await _repositoryManager.ProductImageRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ProductImageDto>(res);
                    return await Result<ProductImageDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<ProductImageDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<ProductImageDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<IEnumerable<ProductImageDto>>> Find(Expression<Func<ProductImageDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<ProductImage, bool>>>(expression);
                var res = await _repositoryManager.ProductImageRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<ProductImageDto>>.FailAsync("--- there is no any ProductImage like find expression ---");
                return await Result<IEnumerable<ProductImageDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductImageDto>>(res), "");

            }
            catch (Exception ex)
            {

                return await Result<IEnumerable<ProductImageDto>>.FailAsync($"Exp in find ProductVariationDto: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }
        }

        public async Task<IResult<IEnumerable<ProductImageDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductImageRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<ProductImageDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductImageDto>>(res));
                }
                return await Result<IEnumerable<ProductImageDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<ProductImageDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductImageDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductImageRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<ProductImageDto>.SucessAsync(_mapper.Map<ProductImageDto>(res));
                }
                return await Result<ProductImageDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<ProductImageDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductImageDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.ProductImageRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.ProductImageRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<ProductImageDto>.SucessAsync(_mapper.Map<ProductImageDto>(res));
                    }
                    return await Result<ProductImageDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<ProductImageDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<ProductImageDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductImageDto>> Update(ProductImageDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<ProductImage>(entity);
                var res = await _repositoryManager.ProductImageRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ProductImageDto>(res);
                    return await Result<ProductImageDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<ProductImageDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<ProductImageDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
