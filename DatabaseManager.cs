using Microsoft.Data.Sqlite;

namespace ContactBook_PTDN_Project
{
    internal class DatabaseManager
    {
        private const string _databaseName = "contact-book.db";

        internal const string _contactsTableName = "Contacts";
        internal const string _contactsColumnNameId = "id";
        internal const string _contactsColumnNameFirstName = "first_name";
        internal const string _contactsColumnNameLastName = "last_name";
        internal const string _contactsColumnNameBirthdayTicks = "birthday_ticks";
        internal const string _contactsColumnNamePhoneNumber = "phone_number";
        internal const string _contactsColumnNameEmail = "email";

        internal static void InitializeDatabase()
        {
            using var connection = new SqliteConnection($"DataSource={_databaseName}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @$"
                CREATE TABLE IF NOT EXISTS {_contactsTableName}
                (
                    {_contactsColumnNameId} TEXT PRIMARY KEY,
                    {_contactsColumnNameFirstName} TEXT NOT NULL,
                    {_contactsColumnNameLastName} TEXT NOT NULL,
                    {_contactsColumnNameBirthdayTicks} INTEGER NOT NULL,
                    {_contactsColumnNamePhoneNumber} TEXT,
                    {_contactsColumnNameEmail} TEXT
                );
            ";

            command.ExecuteNonQuery();
        }

        internal static int ExecuteCommand(string commandText, out string? errorMessage)
        {
            errorMessage = null;
            using var connection = new SqliteConnection($"DataSource={_databaseName}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = commandText;

            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return 0;
            }
        }

        internal static SqliteConnection? ExecuteQuery(string commandText, out SqliteDataReader? result, out string? errorMessage)
        {
            errorMessage = null;
            var connection = new SqliteConnection($"DataSource={_databaseName}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = commandText;

            try
            {
                result = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                result = null;
            }

            return connection;
        }
    }
}
