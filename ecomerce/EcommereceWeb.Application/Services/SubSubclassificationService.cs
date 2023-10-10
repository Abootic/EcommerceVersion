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
    public class SubSubclassificationService : ISubSubclassificationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SubSubclassificationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<SubSubclassificationDto>> Add(SubSubclassificationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<SubSubclassification>(entity);
                var res = await _repositoryManager.SubSubclassificationRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<SubSubclassificationDto>(res);
                    return await Result<SubSubclassificationDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<SubSubclassificationDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ggggggggggg  {ex.InnerException.Message}");
                return await Result<SubSubclassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<IEnumerable<SubSubclassificationDto>>> Find(Expression<Func<SubSubclassification, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                // var mapExor = _mapper.Map<Expression<Func<SubSubclassification, bool>>>(expression);


                var item = await _repositoryManager.SubSubclassificationRepository.Find(expression);

                var itemMap = _mapper.Map<IEnumerable<SubSubclassificationDto>>(item);
                return await Result<IEnumerable<SubSubclassificationDto>>.SucessAsync(itemMap);
            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<SubSubclassificationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }


        public async Task<IResult<IEnumerable<SubSubclassificationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.SubSubclassificationRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<SubSubclassificationDto>>.SucessAsync(_mapper.Map<IEnumerable<SubSubclassificationDto>>(res));
                }
                return await Result<IEnumerable<SubSubclassificationDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<SubSubclassificationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SubSubclassificationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.SubSubclassificationRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<SubSubclassificationDto>.SucessAsync(_mapper.Map<SubSubclassificationDto>(res));
                }
                return await Result<SubSubclassificationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<SubSubclassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SubSubclassificationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.SubSubclassificationRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.SubSubclassificationRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<SubSubclassificationDto>.SucessAsync(_mapper.Map<SubSubclassificationDto>(res));
                    }
                    return await Result<SubSubclassificationDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<SubSubclassificationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<SubSubclassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SubSubclassificationDto>> Update(SubSubclassificationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<SubSubclassification>(entity);
                var res = await _repositoryManager.SubSubclassificationRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<SubSubclassificationDto>(res);
                    return await Result<SubSubclassificationDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<SubSubclassificationDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<SubSubclassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

    }
}
