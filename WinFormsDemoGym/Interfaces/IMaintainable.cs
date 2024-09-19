namespace WinFormsDemoGym.Interfaces
{
    public interface IMaintainable<T> where T : class
    {
        public List<T> GetAll();
        public void Save(T obj);
        public void Delete(T obj);
        public void Update(T obj);
    }
}
