Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication3
	Public Class ToggleSwitchViewInfo
		Inherits CheckEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub
		Protected Overrides Sub UpdateCheckProperties(ByVal e As DevExpress.Utils.Drawing.CheckObjectInfoArgs)
			MyBase.UpdateCheckProperties(e)
			If e.CheckState = System.Windows.Forms.CheckState.Checked Then
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
