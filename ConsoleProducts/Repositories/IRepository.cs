namespace ConsoleProducts.Repositories
{
    internal interface IRepository<T>
    {
        public List<T> getAll();
        public T get(int id);
        public Boolean delete(int id);
        public Boolean update(T entity);
        public T add(T entity);
    }
}
