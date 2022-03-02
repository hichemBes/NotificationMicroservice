using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Command
{
    public  class PutGeneric<T>:IRequest<string> where T:class
    {

        public T Obj { get; set; }
        public PutGeneric( T  obj)
        {
            Obj = obj;

        }
    }
}
