using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ConfigurationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<ConfigurationDto>> Add(ConfigurationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
             
                var entityMap = _mapper.Map<Configuration>(entity);
                var res=await _repositoryManager.ConfigurationRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ConfigurationDto>(res);
                    return await Result<ConfigurationDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<ConfigurationDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch(Exception ex)
            {
                return await Result<ConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<ConfigurationDto>>> Find(Expression<Func<ConfigurationDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<ConfigurationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ConfigurationRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<ConfigurationDto>>.SucessAsync(_mapper.Map<IEnumerable<ConfigurationDto>>(res));
                }
                return await Result<IEnumerable<ConfigurationDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch(Exception ex)
            {
                return await Result<IEnumerable<ConfigurationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ConfigurationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ConfigurationRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<ConfigurationDto>.SucessAsync(_mapper.Map<ConfigurationDto>(res));
                }
                return await Result<ConfigurationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch(Exception ex)
            {
                return await Result<ConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ConfigurationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.ConfigurationRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.ConfigurationRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<ConfigurationDto>.SucessAsync(_mapper.Map<ConfigurationDto>(res));
                    }
                    return await Result<ConfigurationDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<ConfigurationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch(Exception ex)
            {
                return await Result<ConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<ConfigurationDto>> Update(ConfigurationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Configuration>(entity);
                var res = await _repositoryManager.ConfigurationRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<ConfigurationDto>(res);
                    return await Result<ConfigurationDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<ConfigurationDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<ConfigurationDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
