using AppPedagio.Models;
using SQLite;

namespace AppPedagio.Helpers;

public class SQLiteDatabaseHelper
{
    readonly SQLiteAsyncConnection _conn;
    public SQLiteDatabaseHelper(string path)
    {
        _conn = new SQLiteAsyncConnection(path);
        _conn.CreateTableAsync<Pedagio>().Wait();
    }

    public Task<int> Insert(Pedagio p)
    {
        return _conn.InsertAsync(p);
    }

    public Task<List<Pedagio>> Update(Pedagio p)
    {
        string sql = "Update Pedagio SET Local=?, " +
                     "WHERE Valor=?";

        return _conn.QueryAsync<Pedagio>(sql,
            p.Local, p.Valor);
    }

    public Task<List<Pedagio>> GetAll()
    {
        return _conn.Table<Pedagio>().ToListAsync();
    }

    public Task<List<Pedagio>> Search(string q)
    {
        string sql = "SELECT * FROM Pedagio WHERE " +
            "local LIKE '%" + q + "%' ";

        return _conn.QueryAsync<Pedagio>(sql);
    }
}