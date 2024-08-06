namespace TransactionManagementService.Domain.Commons.Entities;

public abstract class DomainEntity
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
 
}