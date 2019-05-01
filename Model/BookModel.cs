using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egui_project.Model
{
    class BookModel
    {
    }
    public class Book : INotifyPropertyChanged
    {
        private string title;
        private string author;
        private string year;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                author = value;
            }
        }

        public string Year
        {
            get { return year;  }
            set
            {
                year = value;
            }
        }     
    }
}
