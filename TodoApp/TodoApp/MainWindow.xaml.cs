using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<ToDo> backingCollection = new ObservableCollection<ToDo>();
        private object currentlySelected = null;

        public MainWindow()
        {
            InitializeComponent();

            FileInfo toDoFile = new FileInfo("ToDoItemsStore.txt");
            using (var stream = toDoFile.OpenText())
            {
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();
                    string[] stuff = line.Split(',');
                    backingCollection.Add(new ToDo() { Priority = int.Parse(stuff[0]), Description = stuff[1] });
                }
            }
        }

        public ObservableCollection<ToDo> Items
        {
            get
            {
                return backingCollection;
            }
        }

        private void UpClick(object sender, RoutedEventArgs e)
        {
            if (currentlySelected != null && currentlySelected is ToDo)
            {
                var todo = currentlySelected as ToDo;
                todo.Priority++;
                backingCollection.Remove(todo);
                backingCollection.Add(todo);
                MyListView.SelectedItem = todo;
            }
        }

        private void DownClick(object sender, RoutedEventArgs e)
        {
            if (currentlySelected != null && currentlySelected is ToDo)
            {
                var todo = currentlySelected as ToDo;
                todo.Priority--;
                backingCollection.Remove(todo);
                backingCollection.Add(todo);
                MyListView.SelectedItem = todo;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                currentlySelected = e.AddedItems[0];
            }
            else
            {
                currentlySelected = null;
            }
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            FileInfo toDoFile = new FileInfo("ToDoItemsStore.txt");
            using (var stream = toDoFile.CreateText())
            {
                foreach (ToDo todo in backingCollection)
                {
                    stream.WriteLine(string.Format("{0},{1}", todo.Priority, todo.Description));
                }
            }
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            backingCollection.Add(new ToDo() { Priority = 0, Description = "Description" });
        }
    }
}
