using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class ScreenSoundContext : DbContext
{
    private string connectionString = "Data Source=(localdb)\\ProjectModels;" +
        "Initial Catalog=ScreenSound;Integrated Security=True;" +
        "Encrypt=False;Trust Server Certificate=False;" +
        "Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
    }
    public SqlConnection Conexao()
    {
        return new SqlConnection(connectionString);
    }
}
