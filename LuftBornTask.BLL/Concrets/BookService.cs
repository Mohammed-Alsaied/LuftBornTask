using LuftBornTask.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LuftBornTask.BLL.Concrets
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;


        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.AsNoTracking().ToListAsync();
        }

        public async Task<Book> GetBookById(int? id)
        {
            return await _context.Books.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> AddAsync(Book book)
        {
            var rec = (await _context.AddAsync(book)).Entity;
            await SaveChanges();
            return rec;
        }

        public async Task DeleteAsync(int id)
        {
            var book = await  GetBookById(id);
             _context.Remove(book);
            await SaveChanges();
        }

        public async Task<Book> EditAsync(Book book)
        {
            var rec =  _context.Update(book).Entity;
            await SaveChanges();
            return rec;
        }

        public bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

        private async Task<int> SaveChanges()
        {
            return  await _context.SaveChangesAsync();

        }
    }
}
