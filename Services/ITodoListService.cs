namespace TodoListClient
{
    public interface ITodoListService
    {
        Task<IEnumerable<TodoItem>> GetAsync();
        Task<TodoItem> GetAsync(int id);
        Task DeleteAsync(int id);
        Task<TodoItem> AddAsync(TodoItem todo);
        Task<TodoItem> EditAsync(TodoItem todo);
    }
}
