<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficeUse
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
        collateralBox = New TextBox()
        phoneNumBox = New TextBox()
        occupationBox = New TextBox()
        issueDateBox = New TextBox()
        branchBox = New TextBox()
        ComboBox2 = New ComboBox()
        calc_payment = New Button()
        collateral = New Label()
        phoneNolbl = New Label()
        occupationlbl = New Label()
        issuelbl = New Label()
        Branchlabel = New Label()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        interest = New NumericUpDown()
        AmountLoanBox = New TextBox()
        addressBox = New TextBox()
        AccountNumberBox = New TextBox()
        AccountNameBox = New TextBox()
        IDBox = New TextBox()
        loanPeriod = New Label()
        intrstCharged = New Label()
        loadAmnt = New Label()
        addrs = New Label()
        accountNum = New Label()
        accountName = New Label()
        transID = New Label()
        CType(interest, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' collateralBox
        ' 
        collateralBox.Location = New Point(964, 443)
        collateralBox.Name = "collateralBox"
        collateralBox.Size = New Size(231, 31)
        collateralBox.TabIndex = 53
        ' 
        ' phoneNumBox
        ' 
        phoneNumBox.Location = New Point(964, 364)
        phoneNumBox.Name = "phoneNumBox"
        phoneNumBox.Size = New Size(231, 31)
        phoneNumBox.TabIndex = 52
        ' 
        ' occupationBox
        ' 
        occupationBox.Location = New Point(964, 297)
        occupationBox.Name = "occupationBox"
        occupationBox.Size = New Size(231, 31)
        occupationBox.TabIndex = 51
        ' 
        ' issueDateBox
        ' 
        issueDateBox.Location = New Point(964, 229)
        issueDateBox.Name = "issueDateBox"
        issueDateBox.Size = New Size(231, 31)
        issueDateBox.TabIndex = 50
        ' 
        ' branchBox
        ' 
        branchBox.Location = New Point(964, 167)
        branchBox.Name = "branchBox"
        branchBox.Size = New Size(231, 31)
        branchBox.TabIndex = 49
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DisplayMember = "Years"
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(449, 526)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(114, 33)
        ComboBox2.TabIndex = 48
        ' 
        ' calc_payment
        ' 
        calc_payment.Location = New Point(611, 526)
        calc_payment.Name = "calc_payment"
        calc_payment.Size = New Size(216, 34)
        calc_payment.TabIndex = 47
        calc_payment.Text = "Calculate Payement"
        calc_payment.UseVisualStyleBackColor = True
        ' 
        ' collateral
        ' 
        collateral.AutoSize = True
        collateral.Location = New Point(847, 443)
        collateral.Name = "collateral"
        collateral.Size = New Size(85, 25)
        collateral.TabIndex = 46
        collateral.Text = "Collateral"
        ' 
        ' phoneNolbl
        ' 
        phoneNolbl.AutoSize = True
        phoneNolbl.Location = New Point(838, 364)
        phoneNolbl.Name = "phoneNolbl"
        phoneNolbl.Size = New Size(95, 25)
        phoneNolbl.TabIndex = 45
        phoneNolbl.Text = "Phone No:"
        ' 
        ' occupationlbl
        ' 
        occupationlbl.AutoSize = True
        occupationlbl.Location = New Point(838, 297)
        occupationlbl.Name = "occupationlbl"
        occupationlbl.Size = New Size(103, 25)
        occupationlbl.TabIndex = 44
        occupationlbl.Text = "Occupation"
        ' 
        ' issuelbl
        ' 
        issuelbl.AutoSize = True
        issuelbl.Location = New Point(838, 229)
        issuelbl.Name = "issuelbl"
        issuelbl.Size = New Size(94, 25)
        issuelbl.TabIndex = 43
        issuelbl.Text = "Issue Date"
        ' 
        ' Branchlabel
        ' 
        Branchlabel.AutoSize = True
        Branchlabel.Location = New Point(838, 170)
        Branchlabel.Name = "Branchlabel"
        Branchlabel.Size = New Size(65, 25)
        Branchlabel.TabIndex = 42
        Branchlabel.Text = "Branch"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(287, 526)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(114, 33)
        ComboBox1.TabIndex = 41
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(374, 468)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 25)
        Label1.TabIndex = 40
        Label1.Text = "%"
        ' 
        ' interest
        ' 
        interest.Location = New Point(287, 462)
        interest.Name = "interest"
        interest.Size = New Size(81, 31)
        interest.TabIndex = 39
        ' 
        ' AmountLoanBox
        ' 
        AmountLoanBox.Location = New Point(287, 392)
        AmountLoanBox.Name = "AmountLoanBox"
        AmountLoanBox.Size = New Size(150, 31)
        AmountLoanBox.TabIndex = 38
        ' 
        ' addressBox
        ' 
        addressBox.Location = New Point(287, 339)
        addressBox.Name = "addressBox"
        addressBox.Size = New Size(150, 31)
        addressBox.TabIndex = 37
        ' 
        ' AccountNumberBox
        ' 
        AccountNumberBox.Location = New Point(287, 275)
        AccountNumberBox.Name = "AccountNumberBox"
        AccountNumberBox.Size = New Size(150, 31)
        AccountNumberBox.TabIndex = 36
        ' 
        ' AccountNameBox
        ' 
        AccountNameBox.Location = New Point(287, 214)
        AccountNameBox.Name = "AccountNameBox"
        AccountNameBox.Size = New Size(150, 31)
        AccountNameBox.TabIndex = 35
        ' 
        ' IDBox
        ' 
        IDBox.Location = New Point(287, 164)
        IDBox.Name = "IDBox"
        IDBox.Size = New Size(150, 31)
        IDBox.TabIndex = 34
        ' 
        ' loanPeriod
        ' 
        loanPeriod.AutoSize = True
        loanPeriod.Location = New Point(106, 534)
        loanPeriod.Name = "loanPeriod"
        loanPeriod.Size = New Size(121, 25)
        loanPeriod.TabIndex = 33
        loanPeriod.Text = "Peiod of Loan"
        ' 
        ' intrstCharged
        ' 
        intrstCharged.AutoSize = True
        intrstCharged.Location = New Point(105, 464)
        intrstCharged.Name = "intrstCharged"
        intrstCharged.Size = New Size(143, 25)
        intrstCharged.TabIndex = 32
        intrstCharged.Text = "Interest Charged"
        ' 
        ' loadAmnt
        ' 
        loadAmnt.AutoSize = True
        loadAmnt.Location = New Point(106, 392)
        loadAmnt.Name = "loadAmnt"
        loadAmnt.Size = New Size(142, 25)
        loadAmnt.TabIndex = 31
        loadAmnt.Text = "Amount of Loan"
        ' 
        ' addrs
        ' 
        addrs.AutoSize = True
        addrs.Location = New Point(158, 339)
        addrs.Name = "addrs"
        addrs.Size = New Size(77, 25)
        addrs.TabIndex = 30
        addrs.Text = "Address"
        ' 
        ' accountNum
        ' 
        accountNum.AutoSize = True
        accountNum.Location = New Point(106, 275)
        accountNum.Name = "accountNum"
        accountNum.Size = New Size(147, 25)
        accountNum.TabIndex = 29
        accountNum.Text = "Account Number"
        ' 
        ' accountName
        ' 
        accountName.AutoSize = True
        accountName.Location = New Point(106, 220)
        accountName.Name = "accountName"
        accountName.Size = New Size(129, 25)
        accountName.TabIndex = 28
        accountName.Text = "Account Name"
        ' 
        ' transID
        ' 
        transID.AutoSize = True
        transID.Location = New Point(112, 164)
        transID.Name = "transID"
        transID.Size = New Size(123, 25)
        transID.TabIndex = 27
        transID.Text = "Transaction ID"
        ' 
        ' OfficeUse
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(collateralBox)
        Controls.Add(phoneNumBox)
        Controls.Add(occupationBox)
        Controls.Add(issueDateBox)
        Controls.Add(branchBox)
        Controls.Add(ComboBox2)
        Controls.Add(calc_payment)
        Controls.Add(collateral)
        Controls.Add(phoneNolbl)
        Controls.Add(occupationlbl)
        Controls.Add(issuelbl)
        Controls.Add(Branchlabel)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(interest)
        Controls.Add(AmountLoanBox)
        Controls.Add(addressBox)
        Controls.Add(AccountNumberBox)
        Controls.Add(AccountNameBox)
        Controls.Add(IDBox)
        Controls.Add(loanPeriod)
        Controls.Add(intrstCharged)
        Controls.Add(loadAmnt)
        Controls.Add(addrs)
        Controls.Add(accountNum)
        Controls.Add(accountName)
        Controls.Add(transID)
        Name = "OfficeUse"
        Size = New Size(1324, 732)
        CType(interest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents collateralBox As TextBox
    Friend WithEvents phoneNumBox As TextBox
    Friend WithEvents occupationBox As TextBox
    Friend WithEvents issueDateBox As TextBox
    Friend WithEvents branchBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents calc_payment As Button
    Friend WithEvents collateral As Label
    Friend WithEvents phoneNolbl As Label
    Friend WithEvents occupationlbl As Label
    Friend WithEvents issuelbl As Label
    Friend WithEvents Branchlabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents interest As NumericUpDown
    Friend WithEvents AmountLoanBox As TextBox
    Friend WithEvents addressBox As TextBox
    Friend WithEvents AccountNumberBox As TextBox
    Friend WithEvents AccountNameBox As TextBox
    Friend WithEvents IDBox As TextBox
    Friend WithEvents loanPeriod As Label
    Friend WithEvents intrstCharged As Label
    Friend WithEvents loadAmnt As Label
    Friend WithEvents addrs As Label
    Friend WithEvents accountNum As Label
    Friend WithEvents accountName As Label
    Friend WithEvents transID As Label
End Class
