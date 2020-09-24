using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NyukuApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()

        {
            MenuList = GetMenus();
        }
        private ObservableCollection<Menu> menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }
        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Icon = "icon.png", Name = "Calculator"},
                new Menu { Icon = "icon.png", Name = "Tax Tables"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public class Menu
        {
            public string Name { get; set; }
            public string Icon { get; set; }
        }
    }
}
