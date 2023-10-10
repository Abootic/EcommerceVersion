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
    public class BrandService : IBrandService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public BrandService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<BrandDto>> Add(BrandDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<Brand>(entity);
                var res = await _repositoryManager.BrandRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<BrandDto>(res);
                    return await Result<BrandDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<BrandDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<BrandDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<BrandDto>>> Find(Expression<Func<BrandDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<BrandDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.BrandRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<BrandDto>>.SucessAsync(_mapper.Map<IEnumerable<BrandDto>>(res));
                }
                return await Result<IEnumerable<BrandDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<BrandDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<BrandDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.BrandRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<BrandDto>.SucessAsync(_mapper.Map<BrandDto>(res));
                }
                return await Result<BrandDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<BrandDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<BrandDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.BrandRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.BrandRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<BrandDto>.SucessAsync(_mapper.Map<BrandDto>(res));
                    }
                    return await Result<BrandDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<BrandDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<BrandDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<BrandDto>> Update(BrandDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Brand>(entity);
                var res = await _repositoryManager.BrandRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<BrandDto>(res);
                    return await Result<BrandDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<BrandDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<BrandDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
