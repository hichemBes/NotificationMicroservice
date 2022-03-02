using Domain.Command;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handler
{
    public class PutGenericHandler<T> : IRequestHandler<PutGeneric<T>, string> where T : class
    {

        private readonly IGenericRepository<T> rep;
        public PutGenericHandler(IGenericRepository<T> Rep)
        {
            rep= Rep;
        }
        public Task<string> Handle(PutGeneric<T> request, CancellationToken cancellationToken)
        {
            var  res = rep.Update(request.Obj);
            return Task.FromResult(res);
        }
    }
}
