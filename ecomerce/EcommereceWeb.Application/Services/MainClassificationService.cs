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
    public class MainClassificationService : IMainClassificationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public MainClassificationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<MainClassificationDto>> Add(MainClassificationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<MainClassification>(entity);
                var res = await _repositoryManager.MainClassificationRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<MainClassificationDto>(res);
                    return await Result<MainClassificationDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<MainClassificationDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<MainClassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<MainClassificationDto>>> Find(Expression<Func<MainClassificationDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<MainClassificationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.MainClassificationRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<MainClassificationDto>>.SucessAsync(_mapper.Map<IEnumerable<MainClassificationDto>>(res));
                }
                return await Result<IEnumerable<MainClassificationDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<MainClassificationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<MainClassificationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.MainClassificationRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<MainClassificationDto>.SucessAsync(_mapper.Map<MainClassificationDto>(res));
                }
                return await Result<MainClassificationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<MainClassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<MainClassificationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.MainClassificationRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.MainClassificationRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<MainClassificationDto>.SucessAsync(_mapper.Map<MainClassificationDto>(res));
                    }
                    return await Result<MainClassificationDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<MainClassificationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<MainClassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<MainClassificationDto>> Update(MainClassificationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<MainClassification>(entity);
                var res = await _repositoryManager.MainClassificationRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<MainClassificationDto>(res);
                    return await Result<MainClassificationDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<MainClassificationDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<MainClassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

    }
}
