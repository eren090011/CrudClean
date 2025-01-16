namespace Domain.Primitives;

public interface IUnitOfwork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken= default);
}