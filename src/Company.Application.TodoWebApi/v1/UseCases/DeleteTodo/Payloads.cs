﻿using System;
using MediatR;

namespace Company.Application.TodoWebApi.v1.UseCases.DeleteTodo
{
	public class DeleteTodoRequest : IRequest<DeleteTodoResponse>
	{
		public Guid Id { get; set; }
	}

	public class DeleteTodoResponse
	{
		public Guid Result { get; set; }
	}
}