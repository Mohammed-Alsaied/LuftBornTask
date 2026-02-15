using LuftBornTask.DAL.Context;

namespace LuftBornTask.BLL.Concrets
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;

        public IBookService BookService { get; set; }


        public UnitOfWork(ApplicationDbContext context, IBookService bookService)
        {
            _context = context;
            BookService = new BookService(_context);
        }
    }
}
