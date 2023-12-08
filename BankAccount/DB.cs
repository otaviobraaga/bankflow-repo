/*using SQLite;

namespace TransferFunds {
    public static class SQLiteDB {
        public static SQLiteConnection GetConnection() {
            string databasePath = "transfer.db3"; // Nome do arquivo do banco de dados
            return new SQLiteConnection(databasePath);
        }

        public static void InitializeDatabase() {
            using (var db = GetConnection()) {
                db.CreateTable<TransferState>();
            }
        }
    }
}*/