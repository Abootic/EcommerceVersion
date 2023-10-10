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
    public class TaxConfigurationService : ITaxConfigurationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public TaxConfigurationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<TaxConfigurationDto>> Add(TaxConfigurationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<TaxConfiguration>(entity);
                var res = await _repositoryManager.TaxConfigurationRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<TaxConfigurationDto>(res);
                    return await Result<TaxConfigurationDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<TaxConfigurationDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<TaxConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<TaxConfigurationDto>>> Find(Expression<Func<TaxConfigurationDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<TaxConfigurationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.TaxConfigurationRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<TaxConfigurationDto>>.SucessAsync(_mapper.Map<IEnumerable<TaxConfigurationDto>>(res));
                }
                return await Result<IEnumerable<TaxConfigurationDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<TaxConfigurationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<TaxConfigurationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.TaxConfigurationRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<TaxConfigurationDto>.SucessAsync(_mapper.Map<TaxConfigurationDto>(res));
                }
                return await Result<TaxConfigurationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<TaxConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<TaxConfigurationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.TaxConfigurationRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.TaxConfigurationRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<TaxConfigurationDto>.SucessAsync(_mapper.Map<TaxConfigurationDto>(res));
                    }
                    return await Result<TaxConfigurationDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<TaxConfigurationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<TaxConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<TaxConfigurationDto>> Update(TaxConfigurationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<TaxConfiguration>(entity);
                var res = await _repositoryManager.TaxConfigurationRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<TaxConfigurationDto>(res);
                    return await Result<TaxConfigurationDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<TaxConfigurationDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<TaxConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

    }
}
