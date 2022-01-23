namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        public Task<List<T>> LoadData<T, U>(string sql, U parameters);
        public Task SaveData<T>(string sql, T parameters);
    }
}