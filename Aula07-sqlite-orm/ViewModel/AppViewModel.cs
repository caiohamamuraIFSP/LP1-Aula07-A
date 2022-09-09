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
        [ObservableProperty]
        string texto;

        public ObservableCollection<string> Lista { get; } = new()
        {
            "Item 1",
            "Item 2"
        };

        [RelayCommand]
        void Adicionar()
        {
            Lista.Add(Texto);
            Texto = "";
        }
        [RelayCommand]
        void Remover(string item)
        {
            Lista.Remove(item);
        }
    }
}
