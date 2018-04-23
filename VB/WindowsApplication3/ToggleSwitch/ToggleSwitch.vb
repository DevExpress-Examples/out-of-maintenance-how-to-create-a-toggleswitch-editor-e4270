Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication3
	Public Class ToggleSwitch
		Inherits CheckEdit
		Shared Sub New()
			RepositoryItemToggleSwitch.RegisterCustomEdit()
		End Sub

		#Region "HidePropertiesEvents"
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Overridable Property Checked() As Boolean
			Get
				Return MyBase.Checked
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Overridable Property CheckState() As CheckState
			Get
				Return MyBase.CheckState
			End Get
			Set(ByVal value As CheckState)
			End Set
		End Property
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Event CheckedChanged As EventHandler
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Event CheckStateChanged As EventHandler
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Event QueryCheckStateByValue As QueryCheckStateByValueEventHandler
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Event QueryValueByCheckState As QueryValueByCheckStateEventHandler
		#End Region

		#Region "NewPropertiesEvents"
		Public Custom Event Toggled As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler Properties.Toggled, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler Properties.Toggled, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		<Browsable(False)> _
		Public Property IsOn() As Boolean
			Get
				Return MyBase.Checked
			End Get
			Set(ByVal value As Boolean)
				If MyBase.Checked <> value Then
					MyBase.Checked = value
				End If
			End Set
		End Property
		Protected Overrides Sub OnEditValueChanged()
			MyBase.OnEditValueChanged()
			Properties.RaiseToggled(EventArgs.Empty)
		End Sub
		#End Region

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemToggleSwitch.ToggleSwitchName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemToggleSwitch
			Get
				Return TryCast(MyBase.Properties, RepositoryItemToggleSwitch)
			End Get
		End Property
	End Class
End Namespace