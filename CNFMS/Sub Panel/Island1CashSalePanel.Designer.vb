﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Island1CashSalePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Island1CashSalePanel))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Island1CashSaleITable = New Guna.UI.WinForms.GunaDataGridView()
        Me.backButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exportPDFButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.exportExcelButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.PrintButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pumpComboBox = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.DateTimePickerTo = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.showAllButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.filterButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.Island1CashSaleITable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.Island1CashSaleITable)
        Me.GunaPanel1.Controls.Add(Me.backButton)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Controls.Add(Me.GroupBox2)
        Me.GunaPanel1.Controls.Add(Me.GroupBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.TabIndex = 0
        '
        'Island1CashSaleITable
        '
        Me.Island1CashSaleITable.AllowUserToAddRows = False
        Me.Island1CashSaleITable.AllowUserToResizeColumns = False
        Me.Island1CashSaleITable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Island1CashSaleITable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Island1CashSaleITable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Island1CashSaleITable.BackgroundColor = System.Drawing.Color.White
        Me.Island1CashSaleITable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Island1CashSaleITable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Island1CashSaleITable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Island1CashSaleITable.ColumnHeadersHeight = 60
        Me.Island1CashSaleITable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Island1CashSaleITable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column10, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Island1CashSaleITable.DefaultCellStyle = DataGridViewCellStyle3
        Me.Island1CashSaleITable.EnableHeadersVisualStyles = False
        Me.Island1CashSaleITable.GridColor = System.Drawing.Color.LightGray
        Me.Island1CashSaleITable.Location = New System.Drawing.Point(57, 464)
        Me.Island1CashSaleITable.Name = "Island1CashSaleITable"
        Me.Island1CashSaleITable.ReadOnly = True
        Me.Island1CashSaleITable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Island1CashSaleITable.RowHeadersVisible = False
        Me.Island1CashSaleITable.RowHeadersWidth = 55
        Me.Island1CashSaleITable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Island1CashSaleITable.RowTemplate.Height = 40
        Me.Island1CashSaleITable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Island1CashSaleITable.ShowCellErrors = False
        Me.Island1CashSaleITable.ShowRowErrors = False
        Me.Island1CashSaleITable.Size = New System.Drawing.Size(1567, 550)
        Me.Island1CashSaleITable.StandardTab = True
        Me.Island1CashSaleITable.TabIndex = 85
        Me.Island1CashSaleITable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.Island1CashSaleITable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Island1CashSaleITable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Island1CashSaleITable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Island1CashSaleITable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Island1CashSaleITable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Island1CashSaleITable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Island1CashSaleITable.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.Island1CashSaleITable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.Island1CashSaleITable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.Island1CashSaleITable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Island1CashSaleITable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.Island1CashSaleITable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Island1CashSaleITable.ThemeStyle.HeaderStyle.Height = 60
        Me.Island1CashSaleITable.ThemeStyle.ReadOnly = True
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.Height = 40
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Island1CashSaleITable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'backButton
        '
        Me.backButton.AnimationHoverSpeed = 0.07!
        Me.backButton.AnimationSpeed = 0.03!
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.backButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.backButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.backButton.FocusedColor = System.Drawing.Color.Empty
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.White
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.ImageOffsetX = 15
        Me.backButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.backButton.Location = New System.Drawing.Point(57, 83)
        Me.backButton.Name = "backButton"
        Me.backButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.backButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.backButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.backButton.OnHoverForeColor = System.Drawing.Color.White
        Me.backButton.OnHoverImage = Nothing
        Me.backButton.OnPressedColor = System.Drawing.Color.Black
        Me.backButton.Radius = 5
        Me.backButton.Size = New System.Drawing.Size(149, 54)
        Me.backButton.TabIndex = 84
        Me.backButton.Text = "Go Back"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(52, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 33)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "/ CASH SALES REPORT / ISLAND 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exportPDFButton)
        Me.GroupBox2.Controls.Add(Me.exportExcelButton)
        Me.GroupBox2.Controls.Add(Me.PrintButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1567, 118)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRINT, EXPORT"
        '
        'exportPDFButton
        '
        Me.exportPDFButton.AnimationHoverSpeed = 0.07!
        Me.exportPDFButton.AnimationSpeed = 0.03!
        Me.exportPDFButton.BackColor = System.Drawing.Color.Transparent
        Me.exportPDFButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.exportPDFButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exportPDFButton.FocusedColor = System.Drawing.Color.Empty
        Me.exportPDFButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportPDFButton.ForeColor = System.Drawing.Color.White
        Me.exportPDFButton.Image = CType(resources.GetObject("exportPDFButton.Image"), System.Drawing.Image)
        Me.exportPDFButton.ImageOffsetX = 15
        Me.exportPDFButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.exportPDFButton.Location = New System.Drawing.Point(149, 48)
        Me.exportPDFButton.Name = "exportPDFButton"
        Me.exportPDFButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exportPDFButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exportPDFButton.OnHoverImage = Nothing
        Me.exportPDFButton.OnPressedColor = System.Drawing.Color.Black
        Me.exportPDFButton.Radius = 5
        Me.exportPDFButton.Size = New System.Drawing.Size(126, 45)
        Me.exportPDFButton.TabIndex = 69
        Me.exportPDFButton.Text = "PDF"
        '
        'exportExcelButton
        '
        Me.exportExcelButton.AnimationHoverSpeed = 0.07!
        Me.exportExcelButton.AnimationSpeed = 0.03!
        Me.exportExcelButton.BackColor = System.Drawing.Color.Transparent
        Me.exportExcelButton.BaseColor1 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.BaseColor2 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.exportExcelButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exportExcelButton.FocusedColor = System.Drawing.Color.Empty
        Me.exportExcelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportExcelButton.ForeColor = System.Drawing.Color.White
        Me.exportExcelButton.Image = CType(resources.GetObject("exportExcelButton.Image"), System.Drawing.Image)
        Me.exportExcelButton.ImageOffsetX = 15
        Me.exportExcelButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.exportExcelButton.Location = New System.Drawing.Point(281, 48)
        Me.exportExcelButton.Name = "exportExcelButton"
        Me.exportExcelButton.OnHoverBaseColor1 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.OnHoverBaseColor2 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exportExcelButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exportExcelButton.OnHoverImage = Nothing
        Me.exportExcelButton.OnPressedColor = System.Drawing.Color.Black
        Me.exportExcelButton.Radius = 5
        Me.exportExcelButton.Size = New System.Drawing.Size(126, 45)
        Me.exportExcelButton.TabIndex = 68
        Me.exportExcelButton.Text = "Excel"
        '
        'PrintButton
        '
        Me.PrintButton.AnimationHoverSpeed = 0.07!
        Me.PrintButton.AnimationSpeed = 0.03!
        Me.PrintButton.BackColor = System.Drawing.Color.Transparent
        Me.PrintButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.PrintButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PrintButton.FocusedColor = System.Drawing.Color.Empty
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.White
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.ImageOffsetX = 15
        Me.PrintButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.PrintButton.Location = New System.Drawing.Point(13, 48)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PrintButton.OnHoverForeColor = System.Drawing.Color.White
        Me.PrintButton.OnHoverImage = Nothing
        Me.PrintButton.OnPressedColor = System.Drawing.Color.Black
        Me.PrintButton.Radius = 5
        Me.PrintButton.Size = New System.Drawing.Size(126, 45)
        Me.PrintButton.TabIndex = 70
        Me.PrintButton.Text = "Print"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pumpComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox1.Controls.Add(Me.showAllButton)
        Me.GroupBox1.Controls.Add(Me.filterButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1567, 166)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'pumpComboBox
        '
        Me.pumpComboBox.BackColor = System.Drawing.Color.Transparent
        Me.pumpComboBox.BaseColor = System.Drawing.Color.White
        Me.pumpComboBox.BorderColor = System.Drawing.Color.Silver
        Me.pumpComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.pumpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pumpComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.pumpComboBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pumpComboBox.ForeColor = System.Drawing.Color.Black
        Me.pumpComboBox.FormattingEnabled = True
        Me.pumpComboBox.ItemHeight = 40
        Me.pumpComboBox.Items.AddRange(New Object() {"Pump 1", "Pump 2", "Pump 3", "Pump 4", "Pump 5 ", "Pump 6"})
        Me.pumpComboBox.Location = New System.Drawing.Point(13, 89)
        Me.pumpComboBox.Name = "pumpComboBox"
        Me.pumpComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.pumpComboBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.pumpComboBox.Radius = 5
        Me.pumpComboBox.Size = New System.Drawing.Size(230, 46)
        Me.pumpComboBox.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(523, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 39)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Date to"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 39)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Pump #"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(264, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 39)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Date From"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerFrom.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePickerFrom.CustomFormat = Nothing
        Me.DateTimePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(269, 89)
        Me.DateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DateTimePickerFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DateTimePickerFrom.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Radius = 5
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(230, 45)
        Me.DateTimePickerFrom.TabIndex = 73
        Me.DateTimePickerFrom.Text = "11/8/2022"
        Me.DateTimePickerFrom.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerTo.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerTo.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePickerTo.CustomFormat = Nothing
        Me.DateTimePickerTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerTo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTo.Location = New System.Drawing.Point(528, 90)
        Me.DateTimePickerTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DateTimePickerTo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DateTimePickerTo.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerTo.Radius = 5
        Me.DateTimePickerTo.Size = New System.Drawing.Size(230, 45)
        Me.DateTimePickerTo.TabIndex = 74
        Me.DateTimePickerTo.Text = "11/8/2022"
        Me.DateTimePickerTo.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'showAllButton
        '
        Me.showAllButton.AnimationHoverSpeed = 0.07!
        Me.showAllButton.AnimationSpeed = 0.03!
        Me.showAllButton.BackColor = System.Drawing.Color.Transparent
        Me.showAllButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.showAllButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.showAllButton.FocusedColor = System.Drawing.Color.Empty
        Me.showAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showAllButton.ForeColor = System.Drawing.Color.White
        Me.showAllButton.Image = CType(resources.GetObject("showAllButton.Image"), System.Drawing.Image)
        Me.showAllButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.showAllButton.Location = New System.Drawing.Point(905, 89)
        Me.showAllButton.Name = "showAllButton"
        Me.showAllButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.showAllButton.OnHoverForeColor = System.Drawing.Color.White
        Me.showAllButton.OnHoverImage = Nothing
        Me.showAllButton.OnPressedColor = System.Drawing.Color.Black
        Me.showAllButton.Radius = 5
        Me.showAllButton.Size = New System.Drawing.Size(126, 45)
        Me.showAllButton.TabIndex = 71
        Me.showAllButton.Text = "Show All"
        '
        'filterButton
        '
        Me.filterButton.AnimationHoverSpeed = 0.07!
        Me.filterButton.AnimationSpeed = 0.03!
        Me.filterButton.BackColor = System.Drawing.Color.Transparent
        Me.filterButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.filterButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.filterButton.FocusedColor = System.Drawing.Color.Empty
        Me.filterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterButton.ForeColor = System.Drawing.Color.White
        Me.filterButton.Image = CType(resources.GetObject("filterButton.Image"), System.Drawing.Image)
        Me.filterButton.ImageOffsetX = 15
        Me.filterButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.filterButton.Location = New System.Drawing.Point(773, 90)
        Me.filterButton.Name = "filterButton"
        Me.filterButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.filterButton.OnHoverForeColor = System.Drawing.Color.White
        Me.filterButton.OnHoverImage = Nothing
        Me.filterButton.OnPressedColor = System.Drawing.Color.Black
        Me.filterButton.Radius = 5
        Me.filterButton.Size = New System.Drawing.Size(126, 45)
        Me.filterButton.TabIndex = 72
        Me.filterButton.Text = "Filter"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 30.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 71
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Id"
        Me.Column9.FillWeight = 50.0!
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Pump_Name"
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "Pump"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Date_CutOff"
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "SalesRegular"
        Me.Column2.HeaderText = "Cash Sales (Regular)"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "SalesPremium"
        Me.Column3.HeaderText = "Cash Sales (Premium)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "SalesDiesel"
        Me.Column4.HeaderText = "Cash Sales   (Diesel)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "Total_Sale"
        Me.Column10.HeaderText = "Total Cash Sales"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Price_Regular"
        Me.Column6.FillWeight = 60.0!
        Me.Column6.HeaderText = "Price Regular"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Price_Premium"
        Me.Column7.FillWeight = 60.0!
        Me.Column7.HeaderText = "Price Premium"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Price_Diesel"
        Me.Column8.FillWeight = 60.0!
        Me.Column8.HeaderText = "Price   Diesel"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Island1CashSalePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "Island1CashSalePanel"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.Island1CashSaleITable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents backButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents exportPDFButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents exportExcelButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PrintButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pumpComboBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents DateTimePickerTo As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents showAllButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents filterButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Island1CashSaleITable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
