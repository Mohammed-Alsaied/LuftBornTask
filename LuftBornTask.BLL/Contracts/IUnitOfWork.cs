namespace LuftBornTask.BLL.Contracts
{
    public interface IUnitOfWork
    {
        public IBookService BookService { get; set; }
    }
}
