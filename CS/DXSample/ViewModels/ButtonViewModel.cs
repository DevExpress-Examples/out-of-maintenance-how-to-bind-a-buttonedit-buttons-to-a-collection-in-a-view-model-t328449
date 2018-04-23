using DevExpress.Mvvm;
using System.Windows.Input;

namespace DXSample.ViewModels {
    public class ButtonViewModel : ViewModelBase {
        public string Content {
            get { return GetProperty(() => Content); }
            set { SetProperty(() => Content, value); }
        }
        public ICommand Command {
            get { return GetProperty(() => Command); }
            set { SetProperty(() => Command, value); }
        }
        public bool IsLeft {
            get { return GetProperty(() => IsLeft); }
            set { SetProperty(() => IsLeft, value); }
        }
    }
}