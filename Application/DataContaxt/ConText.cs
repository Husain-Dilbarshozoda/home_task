using Npgsql;

namespace Application.DataContext;

public class ConText
{
    private readonly string mainConnection = "Server=localhost;Port=5432;Database=;Username=postgres;Password=;";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(mainConnection);
    }
}