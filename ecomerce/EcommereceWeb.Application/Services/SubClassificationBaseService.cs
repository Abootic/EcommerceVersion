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
    public class SubClassificationBaseService : ISubClassificationBaseService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SubClassificationBaseService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<SubClassificationBaseDto>> Add(SubClassificationBaseDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<SubClassificationBase>(entity);
                var res = await _repositoryManager.SubClassificationBaseRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<SubClassificationBaseDto>(res);
                    return await Result<SubClassificationBaseDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<SubClassificationBaseDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ggggggggggg  {ex.InnerException.Message}");
                return await Result<SubClassificationBaseDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<IEnumerable<SubClassificationBaseDto>>> Find(Expression<Func<SubClassificationBase, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                // var mapExor = _mapper.Map<Expression<Func<SubClassificationBase, bool>>>(expression);


                var item = await _repositoryManager.SubClassificationBaseRepository.Find(expression);

                var itemMap = _mapper.Map<IEnumerable<SubClassificationBaseDto>>(item);
                return await Result<IEnumerable<SubClassificationBaseDto>>.SucessAsync(itemMap);
            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<SubClassificationBaseDto>>.FailAsync($"something error {ex.Message} ");
            }
        }


        public async Task<IResult<IEnumerable<SubClassificationBaseDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.SubClassificationBaseRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<SubClassificationBaseDto>>.SucessAsync(_mapper.Map<IEnumerable<SubClassificationBaseDto>>(res));
                }
                return await Result<IEnumerable<SubClassificationBaseDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<SubClassificationBaseDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SubClassificationBaseDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.SubClassificationBaseRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<SubClassificationBaseDto>.SucessAsync(_mapper.Map<SubClassificationBaseDto>(res));
                }
                return await Result<SubClassificationBaseDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<SubClassificationBaseDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SubClassificationBaseDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.SubClassificationBaseRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.SubClassificationBaseRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<SubClassificationBaseDto>.SucessAsync(_mapper.Map<SubClassificationBaseDto>(res));
                    }
                    return await Result<SubClassificationBaseDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<SubClassificationBaseDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<SubClassificationBaseDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<SubClassificationBaseDto>> Update(SubClassificationBaseDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<SubClassificationBase>(entity);
                var res = await _repositoryManager.SubClassificationBaseRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<SubClassificationBaseDto>(res);
                    return await Result<SubClassificationBaseDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<SubClassificationBaseDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<SubClassificationBaseDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }

}
