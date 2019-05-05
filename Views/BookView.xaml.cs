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

namespace egui_project.Views
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : UserControl
    {
        MainViewModel _main = new MainViewModel();

        public BookView()
        {
            InitializeComponent();
            this.DataContext = _main; 
        }

        private void OpenAddBookWindow(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            AddBookWindow addBookWindow = new AddBookWindow(_main,book);
            addBookWindow.ShowDialog();
            //Binding myBinding = new Binding();
            //myBinding.Source = _main.Books;
            //myBinding.Mode = BindingMode.TwoWay;
            //myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            //BindingOperations.SetBinding


        }

        private void OpenEditWindow(object sender, RoutedEventArgs e)
        {
            Book item = (Book)dataGrid.SelectedItem;
            AddBookWindow addBookWindow = new AddBookWindow(_main,item);          
            addBookWindow.ShowDialog();
            
        }
    }
}
