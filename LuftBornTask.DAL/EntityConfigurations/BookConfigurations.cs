namespace LuftBornTask.DAL.EntityConfigurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Author).IsRequired();
            builder.Property(a => a.Description).IsRequired();

        }
    }
}
