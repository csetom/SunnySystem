namespace SunnySystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Default Repository interface.
    /// </summary>
    /// <typeparam name="T">Generic class. </typeparam>
    public interface IMyRepository<T>
        where T : class
    {
        /// <summary>
        /// Get all entity.
        /// </summary>
        /// <returns>All entity.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Get entity by id.
        /// </summary>
        /// <param name="id">Id of the entity.</param>
        /// <returns>Entity.</returns>
        T GetByID(int id);

        /// <summary>
        /// Find one or more entity.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <returns>Entity or entites.</returns>
        IEnumerable<T> Find(Func<T, bool> filter);

        /// <summary>
        /// Update entity.
        /// </summary>
        /// <param name="entity">Update.</param>
        void Update(T entity);

        /// <summary>
        /// Add entity.
        /// </summary>
        /// <param name="entity">Add.</param>
        /// <returns>Id.</returns>
        int Add(T entity);

        /// <summary>
        /// Delete entity.
        /// </summary>
        /// <param name="entity">Entity I want to delete.</param>
        void Delete(T entity);

        /// <summary>
        /// Save.
        /// </summary>
        void Commit();
    }
}