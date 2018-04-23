Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication3
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemToggleSwitch
		Inherits RepositoryItemCheckEdit
		Shared Sub New()
			RegisterCustomEdit()
		End Sub
		Public Sub New()
			MyBase.CheckStyle = CheckStyles.UserDefined
			MyBase.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
			MyBase.PictureUnchecked = ResourceImageHelper.CreateImageFromResources("WindowsApplication3.Resources.ToggleSwitchOff.png", GetType(RepositoryItemToggleSwitch).Assembly)
			MyBase.PictureChecked = ResourceImageHelper.CreateImageFromResources("WindowsApplication3.Resources.ToggleSwitchOn.png", GetType(RepositoryItemToggleSwitch).Assembly)
			MyBase.PictureGrayed = ResourceImageHelper.CreateImageFromResources("WindowsApplication3.Resources.ToggleSwitchDisabled.png", GetType(RepositoryItemToggleSwitch).Assembly)
		End Sub
		Public Const ToggleSwitchName As String = "ToggleSwitch"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return ToggleSwitchName
			End Get
		End Property

		#Region "HidePropertiesEvents"
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property GlyphAlignment() As DevExpress.Utils.HorzAlignment
			Get
				Return DevExpress.Utils.HorzAlignment.Far
			End Get
			Set(ByVal value As DevExpress.Utils.HorzAlignment)
			End Set
		End Property
		Private privateCheckStyle As CheckStyles
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property CheckStyle() As CheckStyles
			Get
				Return privateCheckStyle
			End Get
			Set(ByVal value As CheckStyles)
				privateCheckStyle = value
			End Set
		End Property
		Private privateDisplayValueChecked As String
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property DisplayValueChecked() As String
			Get
				Return privateDisplayValueChecked
			End Get
			Set(ByVal value As String)
				privateDisplayValueChecked = value
			End Set
		End Property
		Private privateDisplayValueGrayed As String
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property DisplayValueGrayed() As String
			Get
				Return privateDisplayValueGrayed
			End Get
			Set(ByVal value As String)
				privateDisplayValueGrayed = value
			End Set
		End Property
		Private privateDisplayValueUnchecked As String
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property DisplayValueUnchecked() As String
			Get
				Return privateDisplayValueUnchecked
			End Get
			Set(ByVal value As String)
				privateDisplayValueUnchecked = value
			End Set
		End Property
		Private privateImageIndexChecked As Integer
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property ImageIndexChecked() As Integer
			Get
				Return privateImageIndexChecked
			End Get
			Set(ByVal value As Integer)
				privateImageIndexChecked = value
			End Set
		End Property

		Private privateImageIndexGrayed As Integer
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property ImageIndexGrayed() As Integer
			Get
				Return privateImageIndexGrayed
			End Get
			Set(ByVal value As Integer)
				privateImageIndexGrayed = value
			End Set
		End Property
		Private privateImageIndexUnchecked As Integer
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property ImageIndexUnchecked() As Integer
			Get
				Return privateImageIndexUnchecked
			End Get
			Set(ByVal value As Integer)
				privateImageIndexUnchecked = value
			End Set
		End Property
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property PictureChecked() As Image
			Get
				Return MyBase.PictureChecked
			End Get
			Set(ByVal value As Image)
			End Set
		End Property
		Private privatePictureGrayed As Image
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property PictureGrayed() As Image
			Get
				Return privatePictureGrayed
			End Get
			Set(ByVal value As Image)
				privatePictureGrayed = value
			End Set
		End Property
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property PictureUnchecked() As Image
			Get
				Return MyBase.PictureUnchecked
			End Get
			Set(ByVal value As Image)
			End Set
		End Property
		Private privateRadioGroupIndex As Integer
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property RadioGroupIndex() As Integer
			Get
				Return privateRadioGroupIndex
			End Get
			Set(ByVal value As Integer)
				privateRadioGroupIndex = value
			End Set
		End Property
		Private privateValueChecked As Object
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property ValueChecked() As Object
			Get
				Return privateValueChecked
			End Get
			Set(ByVal value As Object)
				privateValueChecked = value
			End Set
		End Property
		Private privateValueGrayed As Object
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property ValueGrayed() As Object
			Get
				Return privateValueGrayed
			End Get
			Set(ByVal value As Object)
				privateValueGrayed = value
			End Set
		End Property
		Private privateValueUnchecked As Object
		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows Property ValueUnchecked() As Object
			Get
				Return privateValueUnchecked
			End Get
			Set(ByVal value As Object)
				privateValueUnchecked = value
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

		#Region "NewProperties"
		Private _OnContent As String = "On"
		Private _OffContent As String = "Off"
		<DefaultValue("Off")> _
		Public Property OffText() As String
			Get
				Return _OffContent
			End Get
			Set(ByVal value As String)
				If OffText = value Then
					Return
				End If
				_OffContent = value
				OnPropertiesChanged()
			End Set
		End Property
		<DefaultValue("On")> _
		Public Property OnText() As String
			Get
				Return _OnContent
			End Get
			Set(ByVal value As String)
				If OnText = value Then
					Return
				End If
				_OnContent = value
				OnPropertiesChanged()
			End Set
		End Property
		Private _onImage As Image
		<System.ComponentModel.DefaultValue(GetType(Object), Nothing)> _
		Public Property OnImage() As Image
			Get
				Return _onImage
			End Get
			Set(ByVal value As Image)
				If OnImage Is value Then
					Return
				End If
				_onImage = value
				MyBase.PictureChecked = value
				OnPropertiesChanged()
			End Set
		End Property
		Private _offImage As Image
		<System.ComponentModel.DefaultValue(GetType(Object), Nothing)> _
		Public Property OffImage() As Image
			Get
				Return _offImage
			End Get
			Set(ByVal value As Image)
				If OffImage Is value Then
					Return
				End If
				_offImage = value
				MyBase.PictureUnchecked = value
				OnPropertiesChanged()
			End Set
		End Property

		#End Region

		#Region "NewEvent"

		Private Shared ReadOnly _toggled As Object = New Object()

		Public Custom Event Toggled As EventHandler
			AddHandler(ByVal value As EventHandler)
				Events.AddHandler(_toggled, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				Events.RemoveHandler(_toggled, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event


		Protected Friend Overridable Sub RaiseToggled(ByVal e As EventArgs)
			Dim handler As EventHandler = TryCast(Events(_toggled), EventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), e)
			End If
		End Sub
		#End Region
		Public Shared Sub RegisterCustomEdit()
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(GetType(RepositoryItemToggleSwitch).Assembly. GetManifestResourceStream("WindowsApplication3.Resources.ToggleSwitchOn.png")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(ToggleSwitchName, GetType(ToggleSwitch), GetType(RepositoryItemToggleSwitch), GetType(ToggleSwitchViewInfo), New CheckEditPainter(), True, img))
		End Sub
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemToggleSwitch = TryCast(item, RepositoryItemToggleSwitch)
				If source Is Nothing Then
					Return
				End If
				OnText = source.OnText
				OffText = source.OffText
				OnImage = source.OnImage
				OffImage = source.OffImage
				Events.AddHandler(_toggled, source.Events(_toggled))
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class
End Namespace