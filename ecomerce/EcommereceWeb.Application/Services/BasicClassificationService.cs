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
    public class BasicClassificationService : IBasicClassificationService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public BasicClassificationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<BasicClassificationDto>> Add(BasicClassificationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<BasicClassification>(entity);
                var res = await _repositoryManager.BasicClassificationRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    var map = _mapper.Map<BasicClassificationDto>(res);
                    return await Result<BasicClassificationDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<BasicClassificationDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<BasicClassificationDto>.FailAsync($"------------------- Exp in add Attribute : {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<IEnumerable<BasicClassificationDto>>> Find(Expression<Func<BasicClassification, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                // var mapExor = _mapper.Map<Expression<Func<BasicClassification, bool>>>(expression);


                var item = await _repositoryManager.BasicClassificationRepository.Find(expression);
                if (item != null)
                {
                    Console.WriteLine($"ddddddddddd {item.First().ArBasicClassificationName}");
                }
                var itemMap = _mapper.Map<IEnumerable<BasicClassificationDto>>(item);
                return await Result<IEnumerable<BasicClassificationDto>>.SucessAsync(itemMap);
            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<BasicClassificationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }


        public async Task<IResult<IEnumerable<BasicClassificationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.BasicClassificationRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<BasicClassificationDto>>.SucessAsync(_mapper.Map<IEnumerable<BasicClassificationDto>>(res));
                }
                return await Result<IEnumerable<BasicClassificationDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<BasicClassificationDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<BasicClassificationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.BasicClassificationRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<BasicClassificationDto>.SucessAsync(_mapper.Map<BasicClassificationDto>(res));
                }
                return await Result<BasicClassificationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<BasicClassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<BasicClassificationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.BasicClassificationRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.BasicClassificationRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<BasicClassificationDto>.SucessAsync(_mapper.Map<BasicClassificationDto>(res));
                    }
                    return await Result<BasicClassificationDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<BasicClassificationDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<BasicClassificationDto>.FailAsync($"------------------- Exp in remove Attribute: {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<BasicClassificationDto>> Update(BasicClassificationDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<BasicClassification>(entity);
                var res = await _repositoryManager.BasicClassificationRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<BasicClassificationDto>(res);
                    return await Result<BasicClassificationDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<BasicClassificationDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<BasicClassificationDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
