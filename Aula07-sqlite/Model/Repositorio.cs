using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_sqlite.Model
{
    public class Repositorio
    {
        SQLiteConnection conexao;

        public Repositorio()
        {
            string caminho = Path.Join(FileSystem.AppDataDirectory, "banco.db");

        conexao = new(caminho);
            conexao.Execute("CREATE TABLE IF NOT EXISTS lista (item TEXT);");
        }

        public void Adicionar(string item)
        {
            conexao.Execute("INSERT INTO lista VALUES (?)", item);
        }

        public List<string> GetItems()
        {
            return conexao.QueryScalars<string>("SELECT * FROM lista");
        }

        public void Apagar(string item)
        {
            conexao.Execute("DELETE FROM lista WHERE item = ?", item);
        }
    }
}
