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
    public class CurrencyService : ICurrencyService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CurrencyService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<CurrencyDto>> Add(CurrencyDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<Currency>(entity);
                var res = await _repositoryManager.CurrencyRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<CurrencyDto>(res);
                    return await Result<CurrencyDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<CurrencyDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<CurrencyDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<CurrencyDto>>> Find(Expression<Func<CurrencyDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<CurrencyDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.CurrencyRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<CurrencyDto>>.SucessAsync(_mapper.Map<IEnumerable<CurrencyDto>>(res));
                }
                return await Result<IEnumerable<CurrencyDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<CurrencyDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<CurrencyDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.CurrencyRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<CurrencyDto>.SucessAsync(_mapper.Map<CurrencyDto>(res));
                }
                return await Result<CurrencyDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<CurrencyDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<CurrencyDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.CurrencyRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.CurrencyRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<CurrencyDto>.SucessAsync(_mapper.Map<CurrencyDto>(res));
                    }
                    return await Result<CurrencyDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<CurrencyDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<CurrencyDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<CurrencyDto>> Update(CurrencyDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Currency>(entity);
                var res = await _repositoryManager.CurrencyRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<CurrencyDto>(res);
                    return await Result<CurrencyDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<CurrencyDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<CurrencyDto>.FailAsync($"something error {ex.Message} ");
            }
        }

    }
}
