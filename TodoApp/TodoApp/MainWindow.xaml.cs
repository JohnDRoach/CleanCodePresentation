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

            backingCollection.Add(new ToDo() { Description = "Something" });
            backingCollection.Add(new ToDo() { Description = "Something Else" });
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
                backingCollection.Remove(todo);
                todo.Priority++;
                backingCollection.Add(todo);
            }
        }

        private void DownClick(object sender, RoutedEventArgs e)
        {
            if (currentlySelected != null && currentlySelected is ToDo)
            {
                var todo = currentlySelected as ToDo;
                backingCollection.Remove(todo);
                todo.Priority--;
                backingCollection.Add(todo);
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
    }
}
