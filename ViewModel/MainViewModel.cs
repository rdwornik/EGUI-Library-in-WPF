using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egui_project.ViewModel
{
    class MainViewModel : ObesrvableObject
    {
        public BookViewModel BookModel { get; private set; }
        public YearViewModel YearModel { get; private set; }

        public MainViewModel()
        {
            BookModel = new BookViewModel();
            YearModel = new YearViewModel(BookModel.Books);
         
        }
    }
}
