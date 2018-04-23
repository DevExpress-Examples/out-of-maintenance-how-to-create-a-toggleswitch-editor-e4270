Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication3
	Public Class ToggleSwitchViewInfo
		Inherits CheckEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Protected Overrides Sub UpdateCheckProperties(ByVal e As DevExpress.Utils.Drawing.BaseCheckObjectInfoArgs)
			MyBase.UpdateCheckProperties(e)
			Dim args As CheckObjectInfoArgs = TryCast(e, CheckObjectInfoArgs)
			If args.CheckState = System.Windows.Forms.CheckState.Checked Then
				e.Caption = Item.OnText
			Else
				e.Caption = Item.OffText
			End If
		End Sub

		Private Shadows ReadOnly Property Item() As RepositoryItemToggleSwitch
			Get
				Return TryCast(MyBase.Item, RepositoryItemToggleSwitch)
			End Get
		End Property
		Public Overrides ReadOnly Property IsSupportFastViewInfo() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace
