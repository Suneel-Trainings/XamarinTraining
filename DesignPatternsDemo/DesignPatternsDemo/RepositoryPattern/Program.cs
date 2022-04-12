using System;
namespace DesignPatternsDemo.RepositoryPattern
{
    public abstract class EntityBase
    {
        public Int64 Id { get; protected set; }
    }

    public interface IRepository<T> where T : EntityBase
    {
        T GetById(Int64 id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }

    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public void Create(T entity)
        {
            //Write your logic here to persist the entity
        }

        public void Delete(T entity)
        {
            //Write your logic here to delete an entity
        }

        public T GetById(long id)
        {
            //Write your logic here to retrieve an entity by Id
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            //Write your logic here to update an entity
        }
    }

    public class CustomerRepository : IRepository<Customer>
    {
        //Write your code here to implement each of the methods of the IRepository interface.
        public void Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    public class Customer : EntityBase
    {
    }

    public class Product : EntityBase
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
    }

    public class ProductRepository : IRepository<Product>
    {

        //Write your code here to implement each of the methods of the IRepository interface.
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
