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
    public class Book //: INotifyPropertyChanged
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }

      //  public event PropertyChangedEventHandler PropertyChanged;

        //public string Author
        //{
        //    get { return title; }
        //    set
        //    {
        //        title = value;
        //    }
        //}

        //public string Title
        //{
        //    get { return author; }
        //    set
        //    {
        //        author = value;
        //    }
        //}

        //public string Year
        //{
        //    get { return year;  }
        //    set
        //    {
        //        year = value;
        //    }
        //}     
    }
}
