using egui_project.Model;
using egui_project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using egui_project.ViewModel;

namespace egui_project.Views
{
    /// <summary>
    /// Interaction logic for DialogView.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
         ViewModel.MainViewModel _main;

        public AddBookWindow(MainViewModel main, Book book)
        {
            InitializeComponent();
            _main = main;
            
        }

        private void OnInit(object sender, RoutedEventArgs e)
        {
            Book newbook = new Book();
            newbook.setBook("WEd", "edwd", "wed");
            this.DataContext = newbook;
        }

        private void AddBook_Clicked(object sender, RoutedEventArgs e)
        {
            Book item = (Book)(this.DataContext);
            _main.Books.Add(item);          
        }
    }
}
