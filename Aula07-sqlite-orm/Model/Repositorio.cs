using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_sqlite_orm.Model
{
    public class Repositorio
    {
        SQLiteConnection conexao;

        public Repositorio()
        {
            string caminho =
                Path.Join(
                    FileSystem.AppDataDirectory,
                    "banco.bd"
                    );

            conexao = new(caminho);
            conexao.CreateTable<ItemLista>();
        }

        public IEnumerable<ItemLista> GetLista()
        {
            return conexao.Table<ItemLista>();
        }

        public void Insere(ItemLista item)
        {
            conexao.Insert(item);
        }

        public void Delete(ItemLista item)
        {
            conexao.Delete(item);
        }
    }
}
