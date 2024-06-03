using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;

        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await context.Books.FindAsync(id);

            if (book != null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await context.Books.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await context.Books.FindAsync(id);
        }

        public async Task UpdateAsync(Book book)
        {
            context.Books.Update(book);
            await context.SaveChangesAsync();
        }
    }
}
