using egui_project.Model;
using egui_project.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        }

    }
}
