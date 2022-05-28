using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_example.ViewModels
{
    internal class ViewAViewModel : BindableBase
    {
        private string firstName = "Test";

        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }
    }
}
