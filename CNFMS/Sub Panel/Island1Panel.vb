﻿Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.PrintIsland1Report
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Island1Panel
    Dim dialog1 As DialogResult

    Public Shared Island1DateFrom As String = ""
    Public Shared Island1DateTo As String = ""
    Public Shared Island1PumpName As String = ""

    Public Shared PassDateFromIsland1 As String = ""
    Public Shared PassDateToIsland1 As String = ""

    Dim totalliters1 As Decimal
    Dim totalliters2 As Decimal
    Dim totalliters3 As Decimal

    Dim selectedID As Integer
    Dim SelectedRegular As Decimal
    Dim SelectedPremium As Decimal
    Dim SelectedDiesel As Decimal
    Dim selectedDate As Date

    Dim DateSelected As Date


    Dim TotalRegularTxt As Decimal
    Dim TotalPremiumTxt As Decimal
    Dim TotalDieselTxt As Decimal

    Dim DateNow As Date
    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM fuelprice"
                .Connection = SQLString
            End With
            Try
                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        totalliters1 = dataReader.GetString(7)
                        totalliters2 = dataReader.GetString(8)
                        totalliters3 = dataReader.GetString(9)
                    End If
                End Using
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub loadIsland1Report()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            DateNow = DateTime.Now
            Dim dateTo = DateNow.ToString("yyyy-MM-dd")
            With sqlcommand
                .CommandText = "SELECT Id, Pump_name, Date_cutOff, 	LitersOut_Regular, 	LitersOut_Premium, 	LitersOut_Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM island1_report WHERE DATE(Date_cutOff) = @datepickerTo"
                .Parameters.AddWithValue("@datepickerTo", dateTo)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                island1Table.DataSource = dataTables
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub
    Private Sub ShowAll()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            With sqlcommand
                .CommandText = "SELECT Id, Pump_name, Date_cutOff, 	LitersOut_Regular, 	LitersOut_Premium, 	LitersOut_Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM island1_report"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                island1Table.DataSource = dataTables
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub
    Private Sub filter()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            Dim dateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            Dim dateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
            With sqlcommand
                .CommandText = "SELECT Id, Pump_name, Date_cutOff, LitersOut_Regular, LitersOut_Premium, LitersOut_Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM island1_report WHERE Pump_name = @pumps AND DATE(Date_cutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("pumps", pumpComboBox.SelectedItem.ToString)
                .Parameters.AddWithValue("@datepickerFrom", dateFrom)
                .Parameters.AddWithValue("@datepickerTo", dateTo)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                island1Table.DataSource = dataTables
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub
    Private Sub Island1Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerFrom.Value = New DateTime((Now.Year), Now.Month, 1)
        DateTimePickerTo.Value = DateSerial(Year(DateTimePickerFrom.Value), Month(DateTimePickerFrom.Value) + 1, 0)
        showFuelInfo()
        loadIsland1Report()
        ''  DateTimePickerTo.Value = New DateTime(DateTimePickerTo.Value.Year, DateTimePickerTo.Value.Month, 1).AddMonths(1).AddDays(-1)

    End Sub

    Private Sub addFuelButton_Click(sender As Object, e As EventArgs) Handles addFuelButton.Click
        Addisland1Report.Show()
    End Sub

    Private Sub showAllButton_Click(sender As Object, e As EventArgs) Handles showAllButton.Click
        ShowAll()
    End Sub

    Public Sub filterButton_Click(sender As Object, e As EventArgs) Handles filterButton.Click

        If pumpComboBox.SelectedIndex = -1 Then
            dialog1 = MessageBox.Show("Please Select Pump", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Island1PumpName = pumpComboBox.SelectedItem.ToString()
            filter()
        End If

    End Sub

    Private Sub island1Table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles island1Table.CellContentClick
        Try
            Dim selecteddata As DataGridViewRow = island1Table.Rows(e.RowIndex)
            If island1Table.Columns(e.ColumnIndex).Name = "updateData" Then

                Dim DateNow As Date = DateTime.Now
                DateNow = DateNow.ToString("yyyy-MM-dd")

                selectedID = selecteddata.Cells(1).Value.ToString()
                SelectedRegular = selecteddata.Cells(4).Value.ToString()
                SelectedPremium = selecteddata.Cells(5).Value.ToString()
                SelectedDiesel = selecteddata.Cells(6).Value.ToString()
                selectedDate = selecteddata.Cells(3).Value.ToString()
                DateSelected = selectedDate.ToString("yyyy-MM-dd")


                If Not (DateNow.Equals(DateSelected)) Then
                    dialog1 = MessageBox.Show("Already in Archived!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dialog1 = MessageBox.Show("Do you want to continue?",
                                                           "Cancel?",
                                                           MessageBoxButtons.OKCancel,
                                                           MessageBoxIcon.Information)
                    If dialog1 = DialogResult.OK Then
                        Using sqlcommandDelete1 As New MySqlCommand()
                            With sqlcommandDelete1
                                .CommandText = "DELETE FROM `island1_report` WHERE Id = @delID"
                                .Parameters.AddWithValue("@delID", selectedID)
                                .Connection = SQLString
                                Try
                                    sqlcommandDelete1.ExecuteNonQuery()
                                Catch ex As Exception
                                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End With
                        End Using


                        Using sqlcommandDelete2 As New MySqlCommand()
                            With sqlcommandDelete2
                                .CommandText = "DELETE FROM `island1_cashsale` WHERE Id = @delID"
                                .Parameters.AddWithValue("@delID", selectedID)
                                .Connection = SQLString
                                Try
                                    sqlcommandDelete2.ExecuteNonQuery()
                                Catch ex As Exception
                                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End With
                        End Using

                        'update quantity of All fuel if cancelled
                        Using sqlcommandUpdate As New MySqlCommand()

                            TotalRegularTxt = Format(Val(totalliters1 + SelectedRegular), "0.00")
                            TotalPremiumTxt = Format(Val(totalliters2 + SelectedPremium), "0.00")
                            TotalDieselTxt = Format(Val(totalliters3 + SelectedDiesel), "0.00")

                            With sqlcommandUpdate
                                .CommandText = "UPDATE fuelprice SET TotalQuantity1 = @regular, TotalQuantity2 = @premium, TotalQuantity3 = @diesel WHERE id = 1"
                                .Parameters.AddWithValue("@regular", TotalRegularTxt)
                                .Parameters.AddWithValue("@premium", TotalPremiumTxt)
                                .Parameters.AddWithValue("@diesel", TotalDieselTxt)
                                .Connection = SQLString
                            End With
                            Try
                                ConnectSQL()
                                sqlcommandUpdate.ExecuteNonQuery()
                            Catch ex As Exception
                                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End Using
                        Island1Panel_Load(sender, e)
                        dialog1 = MessageBox.Show("Deleted! SuccessFully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DateTimePickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFrom.ValueChanged
        Island1DateFrom = DateTimePickerFrom.Value.ToString("MMM. dd, yyyy")
        PassDateFromIsland1 = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub DateTimePickerTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerTo.ValueChanged
        Island1DateTo = DateTimePickerTo.Value.ToString("MMM. dd, yyyy")
        PassDateToIsland1 = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
    End Sub
    Private Sub showreportPanel()
        Dim ShowReportIsland1 As New PrintIsland1Report
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowReportIsland1.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowReportIsland1)
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        If pumpComboBox.SelectedIndex = -1 Then
            dialog1 = MessageBox.Show("USE FILTER BUTTON FIRST!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            filterButton_Click(sender, e)
            showreportPanel()
            Dim PrintDialog As New PrintDialog()
            If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                rpt1.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
                rpt1.PrintToPrinter(PrintDialog.PrinterSettings.Copies, PrintDialog.PrinterSettings.Collate, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)
            End If
        End If

    End Sub

    Private Sub exportExcelButton_Click(sender As Object, e As EventArgs) Handles exportExcelButton.Click
        If pumpComboBox.SelectedIndex = -1 Then
            dialog1 = MessageBox.Show("USE FILTER BUTTON FIRST!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dt As New DataTable
                Dim dateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
                Dim dateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
                With sqlcommand
                    .CommandText = "SELECT Id, Pump_name, Date_cutOff, LitersOut_Regular, LitersOut_Premium, LitersOut_Diesel, Price_Regular, Price_Premium, Price_Diesel FROM island1_report WHERE Pump_name = @pumps AND DATE(Date_cutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                    .Parameters.AddWithValue("pumps", pumpComboBox.SelectedItem.ToString)
                    .Parameters.AddWithValue("@datepickerFrom", dateFrom)
                    .Parameters.AddWithValue("@datepickerTo", dateTo)
                    .Connection = SQLString
                End With
                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dt.Clear()
                    dataAdapter.Fill(dt)

                    Dim f As FolderBrowserDialog = New FolderBrowserDialog
                    Try
                        If f.ShowDialog() = DialogResult.OK Then
                            'This section help you if your language is not English.
                            System.Threading.Thread.CurrentThread.CurrentCulture =
                            System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
                            Dim oExcel As Excel.Application
                            Dim oBook As Excel.Workbook
                            Dim oSheet As Excel.Worksheet
                            oExcel = CreateObject("Excel.Application")
                            oBook = oExcel.Workbooks.Add(Type.Missing)
                            oSheet = oBook.Worksheets(1)

                            Dim dc As System.Data.DataColumn
                            Dim dr As System.Data.DataRow
                            Dim colIndex As Integer = 0
                            Dim rowIndex As Integer = 0

                            'Export the Columns to excel file
                            For Each dc In dt.Columns
                                colIndex = colIndex + 1
                                oSheet.Cells(1, colIndex) = dc.ColumnName
                            Next

                            'Export the rows to excel file
                            For Each dr In dt.Rows
                                rowIndex = rowIndex + 1
                                colIndex = 0
                                For Each dc In dt.Columns
                                    colIndex = colIndex + 1
                                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                                Next
                            Next

                            'Set final path
                            Dim fileName As String = "\CN ISLAND1 CUT-OFF Report" + ".xls"
                            Dim finalPath = f.SelectedPath + fileName
                            oSheet.Columns.AutoFit()
                            'Save file in final path
                            oBook.SaveAs(finalPath, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
                            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                            'Release the objects
                            releaseObject(oSheet)
                            oBook.Close(False, Type.Missing, Type.Missing)
                            releaseObject(oBook)
                            oExcel.Quit()
                            releaseObject(oExcel)
                            'Some time Office application does not quit after automation: 
                            'so i am calling GC.Collect method.
                            GC.Collect()
                            dialog1 = MessageBox.Show("Export done successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
                    End Try
                Catch ex As Exception
                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub exportPDFButton_Click(sender As Object, e As EventArgs) Handles exportPDFButton.Click
        If pumpComboBox.SelectedIndex = -1 Then
            dialog1 = MessageBox.Show("USE FILTER BUTTON FIRST!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            showreportPanel()
            Dim exportIsland1 As New PrintIsland1Report
            exportIsland1.export_pdf_format()
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dim CutOffPanelShow As New CutOff_Panel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        CutOffPanelShow.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(CutOffPanelShow)
    End Sub


End Class
