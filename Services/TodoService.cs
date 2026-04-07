using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;
using TodoApi.DTOs;

namespace TodoApi.Services
{
    public class TodoService
    {
        private readonly AppDbContext _context;

        public TodoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> GetAll()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem> Create(TodoDto dto)
        {
            var item = new TodoItem
            {
                Title = dto.Title,
                IsCompleted = dto.IsCompleted
            };

            _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<bool> Update(int id, TodoDto dto)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item == null) return false;

            item.Title = dto.Title;
            item.IsCompleted = dto.IsCompleted;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item == null) return false;

            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}