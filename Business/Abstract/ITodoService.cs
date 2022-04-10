﻿using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    // Todo ile ilgili kontrol operasyonlarini tutar
    public interface ITodoService
    {
        List<Todo> GetAll();
        List<TodoDetailDto> GetTodoDetails();
        void Add(Todo todo);
    }
}
