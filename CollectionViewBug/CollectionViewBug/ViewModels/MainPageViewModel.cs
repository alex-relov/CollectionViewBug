using CollectionViewBug.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewBug.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Grouping<string, ItemModel>> Items { get; set; } = new ObservableCollection<Grouping<string, ItemModel>>();

        ItemModel[] DataList = new ItemModel[]
        {
            new ItemModel("A","One"),
            new ItemModel("A","Two"),
            new ItemModel("A","Three"),
            new ItemModel("B","Four"),
        };

        public ICommand UpdateItems { get; }

        public MainPageViewModel()
        {
            InsertData();
            UpdateItems = new Command(() =>
            {
                Items.Clear();
                InsertData();
            });
        }

        void InsertData()
        {
            var grouped = DataList.GroupBy(g => g.Group);

            foreach (var group in grouped)
            {
                Items.Add(new Grouping<string, ItemModel>(group.Key,group));
            }
        }

    }
}
