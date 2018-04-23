Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New WindowsApplication3.DataSet1()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemToggleSwitch1 = New WindowsApplication3.RepositoryItemToggleSwitch()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.toggleSwitch1 = New WindowsApplication3.ToggleSwitch()
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customerInfoBindingSource
			' 
			Me.customerInfoBindingSource.DataMember = "CustomerInfo"
			Me.customerInfoBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customerInfoBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemToggleSwitch1})
			Me.gridControl1.Size = New System.Drawing.Size(1015, 497)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colDate, Me.colCheck})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			' 
			' colDate
			' 
			Me.colDate.FieldName = "Date"
			Me.colDate.Name = "colDate"
			Me.colDate.Visible = True
			Me.colDate.VisibleIndex = 3
			' 
			' colCheck
			' 
			Me.colCheck.ColumnEdit = Me.repositoryItemToggleSwitch1
			Me.colCheck.FieldName = "Check"
			Me.colCheck.Name = "colCheck"
			Me.colCheck.Visible = True
			Me.colCheck.VisibleIndex = 4
			' 
			' repositoryItemToggleSwitch1
			' 
			Me.repositoryItemToggleSwitch1.AutoHeight = False
			Me.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.toggleSwitch1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 497)
			Me.panelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(1015, 68)
			Me.panelControl1.TabIndex = 4
			' 
			' toggleSwitch1
			' 
			Me.toggleSwitch1.IsOn = False
			Me.toggleSwitch1.Location = New System.Drawing.Point(63, 23)
			Me.toggleSwitch1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.toggleSwitch1.Name = "toggleSwitch1"
			Me.toggleSwitch1.Properties.Caption = "toggleSwitch1"
			Me.toggleSwitch1.Size = New System.Drawing.Size(111, 23)
			Me.toggleSwitch1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1015, 565)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private customerInfoBindingSource As System.Windows.Forms.BindingSource
		Private dataSet11 As DataSet1
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colCheck As DevExpress.XtraGrid.Columns.GridColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private toggleSwitch1 As ToggleSwitch
		Private repositoryItemToggleSwitch1 As RepositoryItemToggleSwitch
	End Class
End Namespace

