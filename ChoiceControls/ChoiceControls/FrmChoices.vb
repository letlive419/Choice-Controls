Public Class FrmChoices

    Private arrRadColor(2) As RadioButton
    Private arrRadTrim(2) As RadioButton
    Private arrChk(2) As CheckBox
    Private strColor As String
    Private strTrim As String
    Private strStartDate As String
    Private strEndDate As String
    Private summary As FrmSummary
    Private Sub LoadComboBoxChoices()
        cboSalesItem.Items.Add("Long sleeve shirt")
        cboSalesItem.Items.Add("Short sleeve shirt")
        cboSalesItem.Items.Add("Lightweight Jacket")
    End Sub
    Private Sub LoadListBoxChoices()
        lstSizes.Items.Add("Small")
        lstSizes.Items.Add("Medium")
        lstSizes.Items.Add("Large")
        lstSizes.Items.Add("XL")
        lstSizes.Items.Add("XXL")
    End Sub
    Private Sub LoadCheckedListBoxChoices()
        clbHats.Items.Add("Baseball Cap")
        clbHats.Items.Add("Cowboy Hat")
        clbHats.Items.Add("Tennis Hat")
        clbHats.Items.Add("Golf Hat")

    End Sub
    Private Sub FrmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
        LoadListBoxChoices()
        LoadCheckedListBoxChoices()
        arrRadColor(0) = radRed
        arrRadColor(1) = radBlue
        arrRadColor(2) = radGreen
        arrRadTrim(0) = radGold
        arrRadTrim(1) = radSilver
        arrRadTrim(2) = radBlack
        arrChk(0) = chkExpress
        arrChk(1) = chkSaturday
        arrChk(2) = chkResidential


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub radColors_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged, radBlue.CheckedChanged, radGreen.CheckedChanged

        Dim rad As RadioButton

        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then
            strColor = rad.Text
        End If

    End Sub

    Private Sub radTrim_CheckedChanged(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged, radGold.CheckedChanged, radSilver.CheckedChanged

        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then
            strTrim = rad.Text
        End If

    End Sub

    Private Sub mclSaleRange_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mclSaleRange.DateSelected
        strStartDate = FormatDateTime(e.Start.ToString, DateFormat.ShortDate)
        strEndDate = FormatDateTime(e.End.ToString, DateFormat.ShortDate)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim strResult As String
        Dim i As Integer
        Dim blnErrors As Boolean
        errP.Clear()
        If cboSalesItem.SelectedIndex = -1 Then
            errP.SetError(cboSalesItem, "You must select a sale item!")
            blnErrors = True

        End If
        If lstSizes.SelectedIndex = -1 Then
            errP.SetError(lstSizes, "You must select a size!")
            blnErrors = True
        End If
        If strColor = "" Then
            errP.SetError(grpColors, "You must select a color!")
            blnErrors = True

        End If
        If strTrim = "" Then
            errP.SetError(grpTrim, "You must select a trim!")
            blnErrors = True

        End If

        If strStartDate = "" Then
            errP.SetError(mclSaleRange, "You must select a date!")
            blnErrors = True

        End If
        If Not IsNumeric(txtID.Text) Then
            errP.SetError(txtID, " Your ID must be numeric")
            blnErrors = True

        End If
        If mskZip.Text = "" Then
            errP.SetError(mskZip, "You must enter a zipcode!")
            blnErrors = True

        End If
        If blnErrors Then
            Exit Sub
        End If
        strResult = "you selected the following:" & vbCrLf
        strResult &= "Sale Item: " & cboSalesItem.SelectedItem.ToString & vbCrLf
        strResult &= "Size: " & lstSizes.SelectedItem.ToString & vbCrLf
        strResult &= "Color: " & strColor & vbCrLf
        strResult &= "Trim: " & strTrim & vbCrLf
        strResult &= "Hats: " & vbCrLf
        For i = 0 To clbHats.Items.Count - 1
            If clbHats.GetItemCheckState(i) = CheckState.Checked Then
                strResult &= "  " & clbHats.Items(i).ToString & vbCrLf

            End If
        Next
        strResult &= "Delivery options: " & vbCrLf
        For i = 0 To arrChk.Length - 1
            If arrChk(i).Checked Then
                strResult &= "  " & arrChk(i).Text

            End If

        Next
        strResult &= "Approval date: " & FormatDateTime(dtmApproval.Value, DateFormat.ShortDate) & vbCrLf
        strResult &= "Sale start date: " & strStartDate & vbCrLf
        strResult &= "Sale end date: " & strEndDate & vbCrLf
        MessageBox.Show(strResult, "Your Choices", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        summary = New FrmSummary
        summary.lblSummary.Text = strResult
        summary.ShowDialog()
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To arrRadColor.Length - 1
            arrRadColor(i).Checked = False

        Next
        For i = 0 To arrRadColor.Length - 1
            arrRadTrim(i).Checked = False

        Next
        For i = 0 To arrRadColor.Length - 1
            arrChk(i).Checked = False

        Next
        clbHats.ClearSelected()
        For i = 0 To clbHats.Items.Count - 1
            clbHats.SetItemCheckState(i, CheckState.Unchecked)
        Next
        lstSizes.SelectedIndex = -1
        cboSalesItem.SelectedIndex = -1
        strColor = ""
        strTrim = ""
        dtmApproval.Value = Today.Date
        mclSaleRange.SelectionStart = Today
        mclSaleRange.SelectionEnd = Today
        errP.Clear()
        txtID.Clear()
        mskZip.Clear()

    End Sub
End Class
