﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Author
{
    public class CreateAuthorCommand : IRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
