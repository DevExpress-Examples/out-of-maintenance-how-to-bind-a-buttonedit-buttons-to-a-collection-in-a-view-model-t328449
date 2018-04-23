using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {

        private IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(); } }

        public ObservableCollection<ButtonViewModel> Items {
            get { return GetProperty(() => Items); }
            set { SetProperty(() => Items, value); }
        }
        public MainViewModel() {
            Items = new ObservableCollection<ButtonViewModel>() {
                new ButtonViewModel() {
                    Content = "A",
                    Command = new DelegateCommand(()=> {
                        MessageBoxService.ShowMessage("A");
                    }),
                    IsLeft = true,
                },
                new ButtonViewModel() {
                    Content = "B",
                    Command = new DelegateCommand(()=> {
                        MessageBoxService.ShowMessage("B");
                    }),
                    IsLeft = true,
                },
                new ButtonViewModel() {
                    Content = "C",
                    Command = new DelegateCommand(()=> {
                        MessageBoxService.ShowMessage("C");
                    }),
                    IsLeft = true,
                },
                new ButtonViewModel() {
                    Content = "X",
                    Command = new DelegateCommand(()=> {
                        MessageBoxService.ShowMessage("X");
                    }),
                },
                new ButtonViewModel() {
                    Content = "Y",
                    Command = new DelegateCommand(()=> {
                        MessageBoxService.ShowMessage("Y");
                    }),
                },
                new ButtonViewModel() {
                    Content = "Z",
                    Command = new DelegateCommand(()=> {
                        MessageBoxService.ShowMessage("Z");
                    }),
                },
                new ButtonViewModel() {
                    Content = "Clear",
                    Command = new DelegateCommand(()=> {
                        this.Items.Clear();
                        Items = new ObservableCollection<ButtonViewModel>(Items);
                    }),
                },
                new ButtonViewModel() {
                    Content = "Add",
                    Command = new DelegateCommand(()=> {
                        Items.Add(new ButtonViewModel() {
                            Content = "New",
                            IsLeft = this.Items.Count % 2 == 0
                        });
                        Items = new ObservableCollection<ButtonViewModel>(Items);
                    }),
                },
            };
        }
    }
}