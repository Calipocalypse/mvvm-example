using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace mvvm_example.ViewModels
{
    internal class ViewAViewModel : BindableBase
    {
        /* Commands */
        public DelegateCommand ClickMeCommand { get; set; }

        public ViewAViewModel()
        {
            ClickMeCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => FirstName);
        }

        private bool CanExecute()
        {
            return !String.IsNullOrEmpty(FirstName);
        }

        private void Execute()
        {
            MessageBox.Show("Clicked!");
        }

        private string firstName = "Test";

        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }
    }

}
