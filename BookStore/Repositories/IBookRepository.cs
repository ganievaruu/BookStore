namespace BookStore.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task CreateAsync(Book book);
        Task UpdateAsync(Book book); 
        Task DeleteAsync(int id);
    }
}
