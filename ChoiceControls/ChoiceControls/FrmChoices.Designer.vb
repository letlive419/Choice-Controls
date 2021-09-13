<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChoices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSalesItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbHats = New System.Windows.Forms.CheckedListBox()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.grpTrim = New System.Windows.Forms.GroupBox()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkResidential = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtmApproval = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mclSaleRange = New System.Windows.Forms.MonthCalendar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpColors.SuspendLayout()
        Me.grpTrim.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ComboBox - Sale Items"
        '
        'cboSalesItem
        '
        Me.cboSalesItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesItem.FormattingEnabled = True
        Me.cboSalesItem.Location = New System.Drawing.Point(27, 55)
        Me.cboSalesItem.Name = "cboSalesItem"
        Me.cboSalesItem.Size = New System.Drawing.Size(165, 21)
        Me.cboSalesItem.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ListBox - Sizes"
        '
        'lstSizes
        '
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.Location = New System.Drawing.Point(30, 128)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.Size = New System.Drawing.Size(120, 95)
        Me.lstSizes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CheckedListBox - Hats"
        '
        'clbHats
        '
        Me.clbHats.CheckOnClick = True
        Me.clbHats.FormattingEnabled = True
        Me.clbHats.Location = New System.Drawing.Point(30, 258)
        Me.clbHats.Name = "clbHats"
        Me.clbHats.Size = New System.Drawing.Size(120, 94)
        Me.clbHats.TabIndex = 5
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(7, 19)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(45, 17)
        Me.radRed.TabIndex = 7
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(6, 42)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBlue.TabIndex = 8
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(6, 65)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(54, 17)
        Me.radGreen.TabIndex = 9
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'grpColors
        '
        Me.grpColors.Controls.Add(Me.radGreen)
        Me.grpColors.Controls.Add(Me.radRed)
        Me.grpColors.Controls.Add(Me.radBlue)
        Me.grpColors.Location = New System.Drawing.Point(260, 55)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(128, 96)
        Me.grpColors.TabIndex = 10
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "RadioButtons - Color"
        '
        'grpTrim
        '
        Me.grpTrim.Controls.Add(Me.radBlack)
        Me.grpTrim.Controls.Add(Me.radSilver)
        Me.grpTrim.Controls.Add(Me.radGold)
        Me.grpTrim.Location = New System.Drawing.Point(253, 179)
        Me.grpTrim.Name = "grpTrim"
        Me.grpTrim.Size = New System.Drawing.Size(134, 107)
        Me.grpTrim.TabIndex = 11
        Me.grpTrim.TabStop = False
        Me.grpTrim.Text = "More RadioButton - Trim"
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Location = New System.Drawing.Point(7, 79)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(52, 17)
        Me.radBlack.TabIndex = 10
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "Black"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(6, 56)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(51, 17)
        Me.radSilver.TabIndex = 9
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(6, 36)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(47, 17)
        Me.radGold.TabIndex = 8
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkResidential)
        Me.GroupBox3.Controls.Add(Me.chkSaturday)
        Me.GroupBox3.Controls.Add(Me.chkExpress)
        Me.GroupBox3.Location = New System.Drawing.Point(251, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 104)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CheckBoxes - Delivery"
        '
        'chkResidential
        '
        Me.chkResidential.AutoSize = True
        Me.chkResidential.Location = New System.Drawing.Point(6, 67)
        Me.chkResidential.Name = "chkResidential"
        Me.chkResidential.Size = New System.Drawing.Size(119, 17)
        Me.chkResidential.TabIndex = 2
        Me.chkResidential.Text = "Residential Address"
        Me.chkResidential.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(6, 44)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(109, 17)
        Me.chkSaturday.TabIndex = 1
        Me.chkSaturday.Text = "Saturday Delivery"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(7, 20)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(107, 17)
        Me.chkExpress.TabIndex = 0
        Me.chkExpress.Text = "Express Shipping"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DateTimePicker-Approval Date"
        '
        'dtmApproval
        '
        Me.dtmApproval.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmApproval.Location = New System.Drawing.Point(447, 96)
        Me.dtmApproval.Name = "dtmApproval"
        Me.dtmApproval.Size = New System.Drawing.Size(200, 20)
        Me.dtmApproval.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "MonthCalendar-Sale Data Range"
        '
        'mclSaleRange
        '
        Me.mclSaleRange.Location = New System.Drawing.Point(447, 179)
        Me.mclSaleRange.Name = "mclSaleRange"
        Me.mclSaleRange.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(444, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "TextBox-ManagerID #"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(446, 387)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(227, 20)
        Me.txtID.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Masked TextBox - Store Zipcode"
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(451, 458)
        Me.mskZip.Mask = "00000-9999"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(222, 20)
        Me.mskZip.TabIndex = 20
        Me.mskZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(762, 94)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(111, 43)
        Me.btnReport.TabIndex = 21
        Me.btnReport.Text = "Report Choices"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(762, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 43)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(762, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 43)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'FrmChoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.mskZip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mclSaleRange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtmApproval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpTrim)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.clbHats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSalesItem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmChoices"
        Me.Text = "Controls that provide choices"
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        Me.grpTrim.ResumeLayout(False)
        Me.grpTrim.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboSalesItem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbHats As CheckedListBox
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents grpColors As GroupBox
    Friend WithEvents grpTrim As GroupBox
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkResidential As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtmApproval As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents mclSaleRange As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskZip As MaskedTextBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents errP As ErrorProvider
End Class
