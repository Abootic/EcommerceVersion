using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class ContactService : IContactService
    {
        public Task<IResult<ContactDto>> Add(ContactDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ContactDto>>> Find(Expression<Func<ContactDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ContactDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ContactDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<DataListItem>>> GetDDL(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ContactDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ContactDto>> Update(ContactDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
