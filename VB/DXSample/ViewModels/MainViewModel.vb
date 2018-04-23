Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels
	Public Class MainViewModel
		Inherits ViewModelBase

		Private ReadOnly Property MessageBoxService() As IMessageBoxService
			Get
				Return GetService(Of IMessageBoxService)()
			End Get
		End Property

		Public Property Items() As ObservableCollection(Of ButtonViewModel)
			Get
				Return GetProperty(Function() Items)
			End Get
			Set(ByVal value As ObservableCollection(Of ButtonViewModel))
				SetProperty(Function() Items, value)
			End Set
		End Property
		Public Sub New()
            Items = New ObservableCollection(Of ButtonViewModel)() From {
                New ButtonViewModel() With {
                    .Content = "A",
                    .Command = New DelegateCommand(Function() MessageBoxService.ShowMessage("A")),
                    .IsLeft = True
                },
                New ButtonViewModel() With {
                    .Content = "B",
                    .Command = New DelegateCommand(Function() MessageBoxService.ShowMessage("B")),
                    .IsLeft = True},
                New ButtonViewModel() With {
                    .Content = "C",
                    .Command = New DelegateCommand(Function() MessageBoxService.ShowMessage("C")),
                    .IsLeft = True},
                New ButtonViewModel() With {
                    .Content = "X",
                    .Command = New DelegateCommand(Function() MessageBoxService.ShowMessage("X"))
                },
                New ButtonViewModel() With {
                    .Content = "Y",
                    .Command = New DelegateCommand(Function() MessageBoxService.ShowMessage("Y"))},
                New ButtonViewModel() With {
                    .Content = "Z",
                    .Command = New DelegateCommand(Function() MessageBoxService.ShowMessage("Z"))},
                New ButtonViewModel() With {
                    .Content = "Clear",
                    .Command = New DelegateCommand(
                        Sub()
                            Items.Clear()
                            Items = New ObservableCollection(Of ButtonViewModel)(Items)
                        End Sub)
                },
                New ButtonViewModel() With {
                    .Content = "Add",
                    .Command = New DelegateCommand(
                        Sub()
                            Items.Add(New ButtonViewModel() With {
                                .Content = "New",
                                .IsLeft = Items.Count Mod 2 = 0
                            })
                            Items = New ObservableCollection(Of ButtonViewModel)(Items)
                        End Sub)
                }
            }
        End Sub
	End Class
End Namespace