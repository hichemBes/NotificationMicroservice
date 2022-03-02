using Data.Repository;
using Domain.Command;
using Domain.Handler;
using Domain.Interface;
using Domain.Model;
using Domain.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra
{
    public class DependencyContainer
    {
        public static void RegisterServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {

            services.AddTransient<IGenericRepository<Notification>, Repository<Notification>>();
            services.AddTransient<IRequestHandler<GetAllGenericQuery<Notification>, IEnumerable<Notification>>, GetAllGenericHandler<Notification>>();
            services.AddTransient<IRequestHandler<PostId<Notification>, Notification>, PostIdGenericHandler<Notification>>();
            services.AddTransient<IRequestHandler<PutGeneric<Notification>, string>, PutGenericHandler<Notification>>();
        }
    }
}


