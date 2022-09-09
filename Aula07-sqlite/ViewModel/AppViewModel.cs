using Aula07_sqlite.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_sqlite.ViewModel
{
    public partial class AppViewModel : ObservableObject
    {
        private Repositorio bd;
        public ObservableCollection<string> Lista { get; set; }
        
        public AppViewModel()
        {
            bd = new();
            Lista = new(bd.GetItems());
        }

        [ObservableProperty]
        string entryItem;

        [RelayCommand]
        void Adicionar()
        {
            Lista.Add(EntryItem);
            bd.Adicionar(EntryItem);
            EntryItem = "";
        }

        [RelayCommand]
        void Apagar(string item)
        {
            Lista.Remove(item);
            bd.Apagar(item);
        }
    }
}
