using Aula07_sqlite_orm.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_sqlite_orm.ViewModel
{
    public partial class AppViewModel : ObservableObject
    {
        Repositorio bd = new();


        [ObservableProperty]
        string texto;

        public ObservableCollection<ItemLista> Lista { get; set; }

        public AppViewModel()
        {
            Lista = new(bd.GetLista());
        }

        [RelayCommand]
        void Adicionar()
        {
            ItemLista item = new();
            item.Item = Texto;
            Lista.Add(item);
            Texto = "";
        }

        [RelayCommand]
        void Remover(ItemLista item)
        {
            Lista.Remove(item);
            bd.Delete(item);
        }
    }
}
