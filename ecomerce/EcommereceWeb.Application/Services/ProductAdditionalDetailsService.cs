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
    public class ProductAdditionalDetailsService : IProductAdditionalDetailsService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductAdditionalDetailsService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<ProductAdditionalDetailsDto>> Add(ProductAdditionalDetailsDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<ProductAdditionalDetails>(entity);
                var res = await _repositoryManager.ProductAdditionalDetailsRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ProductAdditionalDetailsDto>(res);
                    return await Result<ProductAdditionalDetailsDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<ProductAdditionalDetailsDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                string exMsg=ex.InnerException!=null?ex.InnerException.Message:ex.Message;
                return await Result<ProductAdditionalDetailsDto>.FailAsync($"something error {exMsg} ");
            }
        }

        public async Task<IResult<IEnumerable<ProductAdditionalDetailsDto>>> Find(Expression<Func<ProductAdditionalDetailsDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<ProductAdditionalDetails, bool>>>(expression);
                var res = await _repositoryManager.ProductAdditionalDetailsRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<ProductAdditionalDetailsDto>>.FailAsync("--- there is no any Attribute like find expression ---");
                return await Result<IEnumerable<ProductAdditionalDetailsDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductAdditionalDetailsDto>>(res), "");

            }
            catch (Exception ex)
            {

                return await Result<IEnumerable<ProductAdditionalDetailsDto>>.FailAsync($"Exp in find Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }

        }

        public async Task<IResult<IEnumerable<ProductAdditionalDetailsDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductAdditionalDetailsRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<ProductAdditionalDetailsDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductAdditionalDetailsDto>>(res));
                }
                return await Result<IEnumerable<ProductAdditionalDetailsDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<ProductAdditionalDetailsDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductAdditionalDetailsDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductAdditionalDetailsRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<ProductAdditionalDetailsDto>.SucessAsync(_mapper.Map<ProductAdditionalDetailsDto>(res));
                }
                return await Result<ProductAdditionalDetailsDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<ProductAdditionalDetailsDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductAdditionalDetailsDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.ProductAdditionalDetailsRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.ProductAdditionalDetailsRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<ProductAdditionalDetailsDto>.SucessAsync(_mapper.Map<ProductAdditionalDetailsDto>(res));
                    }
                    return await Result<ProductAdditionalDetailsDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<ProductAdditionalDetailsDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<ProductAdditionalDetailsDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ProductAdditionalDetailsDto>> Update(ProductAdditionalDetailsDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<ProductAdditionalDetails>(entity);
                var res = await _repositoryManager.ProductAdditionalDetailsRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ProductAdditionalDetailsDto>(res);
                    return await Result<ProductAdditionalDetailsDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<ProductAdditionalDetailsDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<ProductAdditionalDetailsDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
