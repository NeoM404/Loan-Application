<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        transID = New Label()
        accountName = New Label()
        accountNum = New Label()
        addrs = New Label()
        loadAmnt = New Label()
        intrstCharged = New Label()
        loanPeriod = New Label()
        IDBox = New TextBox()
        AccountNameBox = New TextBox()
        AccountNumberBox = New TextBox()
        addressBox = New TextBox()
        AmountLoanBox = New TextBox()
        interest = New NumericUpDown()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Branchlabel = New Label()
        issuelbl = New Label()
        occupationlbl = New Label()
        phoneNolbl = New Label()
        collateral = New Label()
        calc_payment = New Button()
        branchBox = New TextBox()
        totalPayBox = New TextBox()
        occupationBox = New TextBox()
        phoneNumBox = New TextBox()
        collateralBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        loanofficer = New TextBox()
        btnConnectDB = New Button()
        Button2 = New Button()
        monthPeriod = New RadioButton()
        GroupBox1 = New GroupBox()
        yearPeriod = New RadioButton()
        issueDateTimePicker = New DateTimePicker()
        Payments = New Label()
        montlyInstallBox = New TextBox()
        dateIssued = New DateTimePicker()
        dueDate = New DateTimePicker()
        updateBtn = New Button()
        delBtn = New Button()
        DomainUpDown1 = New DomainUpDown()
        Label5 = New Label()
        Label6 = New Label()
        DomainUpDown2 = New DomainUpDown()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label7 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label8 = New Label()
        Panel5 = New Panel()
        Label9 = New Label()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Label10 = New Label()
        CType(interest, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' transID
        ' 
        transID.AutoSize = True
        transID.Location = New Point(19, 37)
        transID.Name = "transID"
        transID.Size = New Size(123, 25)
        transID.TabIndex = 0
        transID.Text = "Transaction ID"
        ' 
        ' accountName
        ' 
        accountName.AutoSize = True
        accountName.Location = New Point(19, 82)
        accountName.Name = "accountName"
        accountName.Size = New Size(129, 25)
        accountName.TabIndex = 1
        accountName.Text = "Account Name"
        ' 
        ' accountNum
        ' 
        accountNum.AutoSize = True
        accountNum.Location = New Point(19, 125)
        accountNum.Name = "accountNum"
        accountNum.Size = New Size(147, 25)
        accountNum.TabIndex = 2
        accountNum.Text = "Account Number"
        ' 
        ' addrs
        ' 
        addrs.AutoSize = True
        addrs.Location = New Point(38, 175)
        addrs.Name = "addrs"
        addrs.Size = New Size(77, 25)
        addrs.TabIndex = 3
        addrs.Text = "Address"
        ' 
        ' loadAmnt
        ' 
        loadAmnt.AutoSize = True
        loadAmnt.Location = New Point(24, 228)
        loadAmnt.Name = "loadAmnt"
        loadAmnt.Size = New Size(142, 25)
        loadAmnt.TabIndex = 4
        loadAmnt.Text = "Amount of Loan"
        ' 
        ' intrstCharged
        ' 
        intrstCharged.AutoSize = True
        intrstCharged.Location = New Point(19, 281)
        intrstCharged.Name = "intrstCharged"
        intrstCharged.Size = New Size(143, 25)
        intrstCharged.TabIndex = 5
        intrstCharged.Text = "Interest Charged"
        ' 
        ' loanPeriod
        ' 
        loanPeriod.AutoSize = True
        loanPeriod.Location = New Point(27, 342)
        loanPeriod.Name = "loanPeriod"
        loanPeriod.Size = New Size(121, 25)
        loanPeriod.TabIndex = 6
        loanPeriod.Text = "Peiod of Loan"
        ' 
        ' IDBox
        ' 
        IDBox.Location = New Point(203, 37)
        IDBox.Name = "IDBox"
        IDBox.Size = New Size(150, 31)
        IDBox.TabIndex = 7
        ' 
        ' AccountNameBox
        ' 
        AccountNameBox.Location = New Point(203, 79)
        AccountNameBox.Name = "AccountNameBox"
        AccountNameBox.Size = New Size(150, 31)
        AccountNameBox.TabIndex = 8
        ' 
        ' AccountNumberBox
        ' 
        AccountNumberBox.Location = New Point(203, 125)
        AccountNumberBox.Name = "AccountNumberBox"
        AccountNumberBox.Size = New Size(150, 31)
        AccountNumberBox.TabIndex = 9
        ' 
        ' addressBox
        ' 
        addressBox.Location = New Point(203, 175)
        addressBox.Name = "addressBox"
        addressBox.Size = New Size(150, 31)
        addressBox.TabIndex = 10
        ' 
        ' AmountLoanBox
        ' 
        AmountLoanBox.Location = New Point(203, 228)
        AmountLoanBox.Name = "AmountLoanBox"
        AmountLoanBox.Size = New Size(150, 31)
        AmountLoanBox.TabIndex = 11
        ' 
        ' interest
        ' 
        interest.Location = New Point(205, 281)
        interest.Name = "interest"
        interest.Size = New Size(81, 31)
        interest.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(292, 287)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 25)
        Label1.TabIndex = 13
        Label1.Text = "%"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(203, 339)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(114, 33)
        ComboBox1.TabIndex = 14
        ' 
        ' Branchlabel
        ' 
        Branchlabel.AutoSize = True
        Branchlabel.Location = New Point(827, 47)
        Branchlabel.Name = "Branchlabel"
        Branchlabel.Size = New Size(65, 25)
        Branchlabel.TabIndex = 15
        Branchlabel.Text = "Branch"
        ' 
        ' issuelbl
        ' 
        issuelbl.AutoSize = True
        issuelbl.Location = New Point(807, 94)
        issuelbl.Name = "issuelbl"
        issuelbl.Size = New Size(94, 25)
        issuelbl.TabIndex = 16
        issuelbl.Text = "Issue Date"
        ' 
        ' occupationlbl
        ' 
        occupationlbl.AutoSize = True
        occupationlbl.Location = New Point(798, 131)
        occupationlbl.Name = "occupationlbl"
        occupationlbl.Size = New Size(103, 25)
        occupationlbl.TabIndex = 17
        occupationlbl.Text = "Occupation"
        ' 
        ' phoneNolbl
        ' 
        phoneNolbl.AutoSize = True
        phoneNolbl.Location = New Point(806, 181)
        phoneNolbl.Name = "phoneNolbl"
        phoneNolbl.Size = New Size(95, 25)
        phoneNolbl.TabIndex = 18
        phoneNolbl.Text = "Phone No:"
        ' 
        ' collateral
        ' 
        collateral.AutoSize = True
        collateral.Location = New Point(816, 231)
        collateral.Name = "collateral"
        collateral.Size = New Size(85, 25)
        collateral.TabIndex = 19
        collateral.Text = "Collateral"
        ' 
        ' calc_payment
        ' 
        calc_payment.Location = New Point(628, 342)
        calc_payment.Name = "calc_payment"
        calc_payment.Size = New Size(216, 34)
        calc_payment.TabIndex = 20
        calc_payment.Text = "Calculate Payement"
        calc_payment.UseVisualStyleBackColor = True
        ' 
        ' branchBox
        ' 
        branchBox.Location = New Point(916, 41)
        branchBox.Name = "branchBox"
        branchBox.Size = New Size(231, 31)
        branchBox.TabIndex = 22
        ' 
        ' totalPayBox
        ' 
        totalPayBox.Location = New Point(889, 325)
        totalPayBox.Name = "totalPayBox"
        totalPayBox.PlaceholderText = "Total Payment: R0 "
        totalPayBox.Size = New Size(278, 31)
        totalPayBox.TabIndex = 23
        ' 
        ' occupationBox
        ' 
        occupationBox.Location = New Point(916, 125)
        occupationBox.Name = "occupationBox"
        occupationBox.Size = New Size(231, 31)
        occupationBox.TabIndex = 24
        ' 
        ' phoneNumBox
        ' 
        phoneNumBox.Location = New Point(916, 175)
        phoneNumBox.Name = "phoneNumBox"
        phoneNumBox.Size = New Size(231, 31)
        phoneNumBox.TabIndex = 25
        ' 
        ' collateralBox
        ' 
        collateralBox.Location = New Point(916, 225)
        collateralBox.Name = "collateralBox"
        collateralBox.Size = New Size(231, 31)
        collateralBox.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 25)
        Label2.TabIndex = 27
        Label2.Text = "Loan Officer"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 28
        Label3.Text = "Date Issued"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 29
        Label4.Text = "Date Due"
        ' 
        ' loanofficer
        ' 
        loanofficer.Location = New Point(121, 21)
        loanofficer.Name = "loanofficer"
        loanofficer.Size = New Size(205, 31)
        loanofficer.TabIndex = 30
        ' 
        ' btnConnectDB
        ' 
        btnConnectDB.Location = New Point(1059, 733)
        btnConnectDB.Name = "btnConnectDB"
        btnConnectDB.Size = New Size(112, 34)
        btnConnectDB.TabIndex = 36
        btnConnectDB.Text = "Save"
        btnConnectDB.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1158, 733)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 37
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' monthPeriod
        ' 
        monthPeriod.AutoSize = True
        monthPeriod.Location = New Point(6, 24)
        monthPeriod.Name = "monthPeriod"
        monthPeriod.Size = New Size(98, 29)
        monthPeriod.TabIndex = 39
        monthPeriod.TabStop = True
        monthPeriod.Text = "Months"
        monthPeriod.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(yearPeriod)
        GroupBox1.Controls.Add(monthPeriod)
        GroupBox1.Location = New Point(355, 324)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(238, 59)
        GroupBox1.TabIndex = 40
        GroupBox1.TabStop = False
        GroupBox1.Text = "Period"
        ' 
        ' yearPeriod
        ' 
        yearPeriod.AutoSize = True
        yearPeriod.Location = New Point(126, 24)
        yearPeriod.Name = "yearPeriod"
        yearPeriod.Size = New Size(77, 29)
        yearPeriod.TabIndex = 40
        yearPeriod.TabStop = True
        yearPeriod.Text = "Years"
        yearPeriod.UseVisualStyleBackColor = True
        ' 
        ' issueDateTimePicker
        ' 
        issueDateTimePicker.Location = New Point(916, 88)
        issueDateTimePicker.Name = "issueDateTimePicker"
        issueDateTimePicker.Size = New Size(300, 31)
        issueDateTimePicker.TabIndex = 41
        ' 
        ' Payments
        ' 
        Payments.AutoSize = True
        Payments.Location = New Point(941, 377)
        Payments.Name = "Payments"
        Payments.Size = New Size(0, 25)
        Payments.TabIndex = 42
        ' 
        ' montlyInstallBox
        ' 
        montlyInstallBox.Location = New Point(889, 352)
        montlyInstallBox.Name = "montlyInstallBox"
        montlyInstallBox.PlaceholderText = "Montly Installments: R0"
        montlyInstallBox.Size = New Size(278, 31)
        montlyInstallBox.TabIndex = 43
        ' 
        ' dateIssued
        ' 
        dateIssued.Location = New Point(121, 76)
        dateIssued.Name = "dateIssued"
        dateIssued.Size = New Size(300, 31)
        dateIssued.TabIndex = 44
        ' 
        ' dueDate
        ' 
        dueDate.Location = New Point(121, 148)
        dueDate.Name = "dueDate"
        dueDate.Size = New Size(300, 31)
        dueDate.TabIndex = 45
        ' 
        ' updateBtn
        ' 
        updateBtn.Location = New Point(684, 733)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(112, 34)
        updateBtn.TabIndex = 46
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' delBtn
        ' 
        delBtn.Location = New Point(576, 733)
        delBtn.Name = "delBtn"
        delBtn.Size = New Size(112, 34)
        delBtn.TabIndex = 47
        delBtn.Text = "Delete"
        delBtn.UseVisualStyleBackColor = True
        ' 
        ' DomainUpDown1
        ' 
        DomainUpDown1.Location = New Point(245, 18)
        DomainUpDown1.Name = "DomainUpDown1"
        DomainUpDown1.Size = New Size(180, 31)
        DomainUpDown1.TabIndex = 35
        DomainUpDown1.Text = "-Select-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(109, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 25)
        Label5.TabIndex = 34
        Label5.Text = "Type of Loan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 25)
        Label6.TabIndex = 48
        Label6.Text = "Admin Action"
        ' 
        ' DomainUpDown2
        ' 
        DomainUpDown2.Location = New Point(145, 13)
        DomainUpDown2.Name = "DomainUpDown2"
        DomainUpDown2.Size = New Size(180, 31)
        DomainUpDown2.TabIndex = 49
        DomainUpDown2.Text = "-Select-"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(transID)
        Panel1.Controls.Add(accountName)
        Panel1.Controls.Add(accountNum)
        Panel1.Controls.Add(addrs)
        Panel1.Controls.Add(IDBox)
        Panel1.Controls.Add(AccountNameBox)
        Panel1.Controls.Add(AccountNumberBox)
        Panel1.Controls.Add(addressBox)
        Panel1.Controls.Add(loadAmnt)
        Panel1.Controls.Add(montlyInstallBox)
        Panel1.Controls.Add(AmountLoanBox)
        Panel1.Controls.Add(intrstCharged)
        Panel1.Controls.Add(issueDateTimePicker)
        Panel1.Controls.Add(interest)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(calc_payment)
        Panel1.Controls.Add(loanPeriod)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(totalPayBox)
        Panel1.Controls.Add(collateralBox)
        Panel1.Controls.Add(Branchlabel)
        Panel1.Controls.Add(phoneNumBox)
        Panel1.Controls.Add(branchBox)
        Panel1.Controls.Add(collateral)
        Panel1.Controls.Add(occupationBox)
        Panel1.Controls.Add(issuelbl)
        Panel1.Controls.Add(occupationlbl)
        Panel1.Controls.Add(phoneNolbl)
        Panel1.Location = New Point(25, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1248, 397)
        Panel1.TabIndex = 50
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(25, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1248, 37)
        Panel2.TabIndex = 51
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(422, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(366, 32)
        Label7.TabIndex = 0
        Label7.Text = "ENTER TRANSACTION DETAILS"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(loanofficer)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(dateIssued)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(dueDate)
        Panel3.Location = New Point(25, 497)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(459, 224)
        Panel3.TabIndex = 52
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(25, 459)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(459, 48)
        Panel4.TabIndex = 53
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(93, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(193, 30)
        Label8.TabIndex = 1
        Label8.Text = "OFFICE USE ONLY"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel5.Controls.Add(Label9)
        Panel5.Location = New Point(646, 459)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(627, 48)
        Panel5.TabIndex = 54
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(213, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(164, 30)
        Label9.TabIndex = 1
        Label9.Text = "TYPE OF LOAN"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(DomainUpDown1)
        Panel6.Location = New Point(646, 506)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(627, 75)
        Panel6.TabIndex = 53
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.Control
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(DomainUpDown2)
        Panel7.Location = New Point(935, 617)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(335, 75)
        Panel7.TabIndex = 54
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel8.Controls.Add(Label10)
        Panel8.Location = New Point(935, 587)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(335, 35)
        Panel8.TabIndex = 55
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(115, 1)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 28)
        Label10.TabIndex = 1
        Label10.Text = "ADMIN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(1304, 779)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(delBtn)
        Controls.Add(updateBtn)
        Controls.Add(Payments)
        Controls.Add(Button2)
        Controls.Add(btnConnectDB)
        Name = "Form1"
        Text = "Form1"
        CType(interest, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents transID As Label
    Friend WithEvents accountName As Label
    Friend WithEvents accountNum As Label
    Friend WithEvents addrs As Label
    Friend WithEvents loadAmnt As Label
    Friend WithEvents intrstCharged As Label
    Friend WithEvents loanPeriod As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents AccountNameBox As TextBox
    Friend WithEvents AccountNumberBox As TextBox
    Friend WithEvents addressBox As TextBox
    Friend WithEvents AmountLoanBox As TextBox
    Friend WithEvents interest As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Branchlabel As Label
    Friend WithEvents issuelbl As Label
    Friend WithEvents occupationlbl As Label
    Friend WithEvents phoneNolbl As Label
    Friend WithEvents collateral As Label
    Friend WithEvents calc_payment As Button
    Friend WithEvents branchBox As TextBox
    Friend WithEvents totalPayBox As TextBox
    Friend WithEvents occupationBox As TextBox
    Friend WithEvents phoneNumBox As TextBox
    Friend WithEvents collateralBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents loanofficer As TextBox
    Friend WithEvents btnConnectDB As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents monthPeriod As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents yearPeriod As RadioButton
    Friend WithEvents issueDateTimePicker As DateTimePicker
    Friend WithEvents Payments As Label
    Friend WithEvents montlyInstallBox As TextBox
    Friend WithEvents dateIssued As DateTimePicker
    Friend WithEvents dueDate As DateTimePicker
    Friend WithEvents updateBtn As Button
    Friend WithEvents delBtn As Button
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label10 As Label
End Class
