using System;
using Core.entities;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync (int id);
    Task<IReadOnlyList<T>> ListAllAsync ();
    Task<T?> GetEntityWithSpec (ISpecification<T> spec);
    Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    
    /* Two function with the same name , but diffrents parameters are available */
    Task<TResult?> GetEntityWithSpec<TResult> (ISpecification<T, TResult> spec);
    Task<IReadOnlyList<TResult>> ListAsync<TResult>(ISpecification<T,TResult> spec);

    void Add(T entity);
    void Update (T entity);
    void Remove (T entity);
    Task<bool> SaveAllAsync();
    bool Exists (int id); 
}
