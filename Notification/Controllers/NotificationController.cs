using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Model;
using System.Linq;
using Domain.Queries;
using Domain.Command;
using Domain.Dtos;

namespace Notification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController

    {
        public readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public NotificationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;


        }
        [HttpGet]
        public IEnumerable<NotificationDto> Get()
        {
            var data = _mediator.Send(new GetAllGenericQuery<Domain.Model.Notification>()).Result.Select(data => _mapper.Map<NotificationDto>(data));

            return data;

        }
        // POST: api/Notification
        [HttpPost("postNotification")]
        public Domain.Model.Notification Post([FromBody] Domain.Model.Notification no)
        {
            return _mediator.Send(new PostId<Domain.Model.Notification>(no)).Result;
        }
        [HttpPut("putNotification")]
        public string update([FromBody] Domain.Model.Notification not)
        {
            return _mediator.Send(new PutGeneric<Domain.Model.Notification>(not)).Result;
        }




    }
}
