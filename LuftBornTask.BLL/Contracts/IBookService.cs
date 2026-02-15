namespace LuftBornTask.BLL.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetBookById(int? Id);
        Task<Book> AddAsync(Book entity);

        Task<Book> EditAsync(Book entity);
        Task DeleteAsync(int id);

        bool BookExists(int id);

    }
}
