using CsvHelper;
using egui_project.Model;
using egui_project.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egui_project.ViewModel
{
   

    public class BookViewModel
    {
        public DialogCommand DeleteCommand { get; set; }
        public DialogCommand AddCommnad { get; set; }
        public DialogCommand EditCommand { get; set; }



        public BookViewModel()
        {
            loadBooks();
        }

        public ObservableCollection<Book> Books
        {
            get;
            set;
        }

    public void loadBooks() //loading books from csv files
        {
        using (var reader = new StreamReader("C:\\Users\\01112268\\Documents\\VisualStudio2015\\Projects\\egui-project\\EGUI-Library-in-WPF\\egui-project\\dane1.csv"))
        using (var csv = new CsvReader(reader))
        {
             
                List<Book> result = new List<Book>();
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.Delimiter = ";";
                result = csv.GetRecords<Book>().ToList();
                Books = new ObservableCollection<Book>(result);
            }
        }

    }
}
