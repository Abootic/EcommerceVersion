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
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<ProductDto>> Add(ProductDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                if (entity == null) return await Result<ProductDto>.FailAsync("---entity is null");
                var entityMap = _mapper.Map<Product>(entity);
                var res = await _repositoryManager.ProductRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    var map = _mapper.Map<ProductDto>(res);
                    return await Result<ProductDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<ProductDto>.FailAsync($"لم يتم الاضافة ");
            }
            catch (Exception ex)
            {

                return await Result<ProductDto>.FailAsync($"------------------- Exp in add Product : {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<IEnumerable<ProductDto>>> Find(Expression<Func<ProductDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<Product, bool>>>(expression);
                var res = _repositoryManager.ProductRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<ProductDto>>.FailAsync("--- there is no any product like find expression ---");
                return await Result<IEnumerable<ProductDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductDto>>(res), "");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<ProductDto>>.FailAsync($"Exp in find Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }

        }

        public async Task<IResult<IEnumerable<ProductDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<ProductDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductDto>>(res));
                }
                return await Result<IEnumerable<ProductDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<ProductDto>>.FailAsync($"Exp in get all Product: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public async Task<IResult<ProductDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<ProductDto>.SucessAsync(_mapper.Map<ProductDto>(res));
                }
                return await Result<ProductDto>.FailAsync($" لايوجد بيانات لهذا الرقم : {Id}---");

            }
            catch (Exception ex)
            {
                return await Result<ProductDto>.FailAsync($"Exp in get Product Id: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public async Task<IResult<ProductDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.ProductRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.ProductRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (res != null)
                    {
                        return await Result<ProductDto>.SucessAsync(_mapper.Map<ProductDto>(res));
                    }
                    return await Result<ProductDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<ProductDto>.FailAsync($"--- لا يوجد منتج لديه هذا الرقم : {Id}---");

            }
            catch (Exception ex)
            {
                return await Result<ProductDto>.FailAsync($"------------------- Exp in remove Product: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public Task<IResult<ProductDto>> Update(ProductDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
