using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HendonEventsApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [ICommand]
        public void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            Items.Add(Text);
            //add our item
            Text = string.Empty;
        }
    }

}
