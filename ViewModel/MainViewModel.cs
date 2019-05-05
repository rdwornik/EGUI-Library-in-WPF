using CsvHelper;
using egui_project.Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace egui_project.ViewModel
{
    public class MainViewModel 
    {

        public MainViewModel()
        {
            //dodadkowe dependendency injection
            loadBooks();
           
        }

        public ObservableCollection<Book> Books
        {
            get;
            set;
        }


        public void loadBooks() //loading books from csv files
        {
            using (var reader = new StreamReader("C:\\Users\\01112268\\Documents\\VisualStudio2015\\Projects\\egui-project\\EGUI-Library-in-WPF\\egui-project\\dane2.csv"))
            using (var csv = new CsvReader(reader))
            { 
                List<Book> result = new List<Book>();
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.Delimiter = ";";
                result = csv.GetRecords<Book>().ToList();
                Books = new ObservableCollection<Book>(result);
            }
        }

        public void addBook(string author, string title, string year)
        {
            Book book = new Book();
            book.setBook(author, title, year);
            Books.Add(book);
            MessageBox.Show(author);
        }

    }
}
