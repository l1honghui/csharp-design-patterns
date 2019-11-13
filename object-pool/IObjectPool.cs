namespace object_pool
{
    public interface IObjectPool<T>
    {
        T GetObject();
        void PutObject(T instance);
    }
}