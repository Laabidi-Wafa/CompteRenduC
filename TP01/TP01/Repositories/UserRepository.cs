using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;
using SQLite;

namespace TP01.Repositories
{
    public class UserRepository
    {
        SQLiteAsyncConnection connection;
        public string StatusMessage { get; set; }
        public UserRepository(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<User>();
        }

        public async Task AddNewUser(string email , string password)
        {
            int result = 0;
            try
            {
                result = await connection.InsertAsync(new User { Email = email, Password = password });
                StatusMessage = $"{result} utilisateur ajouté avec succée";

            }
            catch (Exception ex)
            {
                StatusMessage = $"Impossible d'ajouter l'utilisateur , Erreur {ex.Message}";
            }
        }

        public async Task<List<User>> GetUserAsync()
        {
            try
            {
                return await connection.Table<User>().ToListAsync();

            }
            catch (Exception ex)
            {
                StatusMessage = $"Impossible de récupérer la liste des utilisateur , Erreur {ex.Message}";
            }
            return new List<User>();
        }
    }
}
