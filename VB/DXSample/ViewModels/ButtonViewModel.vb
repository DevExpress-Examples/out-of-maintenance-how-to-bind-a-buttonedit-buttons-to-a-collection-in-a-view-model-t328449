Imports DevExpress.Mvvm
Imports System.Windows.Input

Namespace DXSample.ViewModels
	Public Class ButtonViewModel
		Inherits ViewModelBase

		Public Property Content() As String
			Get
				Return GetProperty(Function() Content)
			End Get
			Set(ByVal value As String)
				SetProperty(Function() Content, value)
			End Set
		End Property
		Public Property Command() As ICommand
			Get
				Return GetProperty(Function() Command)
			End Get
			Set(ByVal value As ICommand)
				SetProperty(Function() Command, value)
			End Set
		End Property
		Public Property IsLeft() As Boolean
			Get
				Return GetProperty(Function() IsLeft)
			End Get
			Set(ByVal value As Boolean)
				SetProperty(Function() IsLeft, value)
			End Set
		End Property
	End Class
End Namespace