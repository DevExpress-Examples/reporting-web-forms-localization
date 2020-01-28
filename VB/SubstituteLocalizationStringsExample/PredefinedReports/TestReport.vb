'====================================================================================================
'The Free Edition of Instant VB limits conversion output to 100 lines per file.

'To subscribe to the Premium Edition, visit our website:
'https://www.tangiblesoftwaresolutions.com/order/order-instant-vb.html
'====================================================================================================

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for TestReport
''' </summary>
Public Class TestReport
	Inherits DevExpress.XtraReports.UI.XtraReport

	Private TopMargin As TopMarginBand
	Private ReportHeader As ReportHeaderBand
	Private label1 As XRLabel
	Private GroupHeader1 As GroupHeaderBand
	Private table1 As XRTable
	Private tableRow1 As XRTableRow
	Private tableCell1 As XRTableCell
	Private tableCell2 As XRTableCell
	Private tableCell3 As XRTableCell
	Private Detail As DetailBand
	Private table2 As XRTable
	Private tableRow2 As XRTableRow
	Private WithEvents tableCell4 As XRTableCell
	Private tableCell5 As XRTableCell
	Private tableCell6 As XRTableCell
	Private pictureBox1 As XRPictureBox
	Private BottomMargin As BottomMarginBand
	Private pageInfo1 As XRPageInfo
	Private pageInfo2 As XRPageInfo
	Private Title As XRControlStyle
	Private DetailCaption1 As XRControlStyle
	Private DetailData1 As XRControlStyle
	Private DetailData3_Odd As XRControlStyle
	Private PageInfo As XRControlStyle
	Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

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

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TestReport))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(638F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "NWind Categories"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 28F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' tableRow1
			' 

'====================================================================================================
'End of the allowed output for the Free Edition of Instant VB.

'To subscribe to the Premium Edition, visit our website:
'https://www.tangiblesoftwaresolutions.com/order/order-instant-vb.html
'====================================================================================================
