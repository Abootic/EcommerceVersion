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
    public class SliderService : ISliderService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SliderService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<SliderDto>> Add(SliderDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<Slider>(entity);
                var res = await _repositoryManager.SliderRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<SliderDto>(res);
                    return await Result<SliderDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<SliderDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<SliderDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<SliderDto>>> Find(Expression<Func<SliderDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<SliderDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.SliderRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<SliderDto>>.SucessAsync(_mapper.Map<IEnumerable<SliderDto>>(res));
                }
                return await Result<IEnumerable<SliderDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<SliderDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SliderDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.SliderRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<SliderDto>.SucessAsync(_mapper.Map<SliderDto>(res));
                }
                return await Result<SliderDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<SliderDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SliderDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.SliderRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.SliderRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<SliderDto>.SucessAsync(_mapper.Map<SliderDto>(res));
                    }
                    return await Result<SliderDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<SliderDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<SliderDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SliderDto>> Update(SliderDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Slider>(entity);
                var res = await _repositoryManager.SliderRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<SliderDto>(res);
                    return await Result<SliderDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<SliderDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<SliderDto>.FailAsync($"something error {ex.Message} ");
            }
        }

    }
}
