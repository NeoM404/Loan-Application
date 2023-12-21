'Has classes to connect to the database (connect, command, reader
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
'Imports Microsoft.Data.SqlClient
Public Class Form1
    Private transactionObj As New Transaction()
    Private officeuseObj As New OfficeUse()
    Private loanObj As New Loan()
    Private Period As String

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private result As String

    Private Class Transaction

        Private transID As Integer
        Private accountName As String
        Private accountNumber, Address, branchName, occupation, collateral As String
        Private amount_of_loan, loan_period As Integer
        Private interest_charged As Single
        Private issueDate As DateTime
        Private phoneNumber As String
        Private period As Boolean
        Private monthly_installment, total_payment As Single

        Public Sub SetTransID(value As Integer)
            transID = value
        End Sub
        Public Sub SetAccountName(value As String)
            accountName = value
        End Sub
        Public Sub SetAccountNumber(value As String)
            accountNumber = value
        End Sub
        Public Sub SetAddress(value As String)
            Address = value
        End Sub
        Public Sub SetCollateral(value As String)
            collateral = value
        End Sub
        Public Sub SetBranchName(value As String)
            branchName = value
        End Sub
        Public Sub SetOccupation(value As String)
            occupation = value
        End Sub
        Public Sub SetLoanAmount(value As Integer)
            amount_of_loan = value
        End Sub
        Public Sub SetLoanPeriod(value As Integer)
            loan_period = value
        End Sub
        Public Sub SetInterestCharged(value As Single)
            interest_charged = value
        End Sub
        Public Sub SetIssueDate(value As DateTime)
            issueDate = value
        End Sub
        Public Sub SetPhoneNumber(value As String)
            phoneNumber = value
        End Sub
        Public Sub SetPeriodForLoan(value As Boolean)
            period = value
        End Sub
        Public Sub SetMontlyInstallment(value As Single)
            monthly_installment = value
        End Sub
        Public Sub SetTotalPayment(value As Single)
            total_payment = value
        End Sub

        Public Function GetTransID() As Integer
            Return transID
        End Function
        Public Function GetAccountName() As String
            Return accountName
        End Function
        Public Function GetAccountNumber() As String
            Return accountNumber
        End Function
        Public Function GetAddress() As String
            Return Address
        End Function
        Public Function GetBranchName() As String
            Return branchName
        End Function
        Public Function GetOccupation() As String
            Return occupation
        End Function
        Public Function GetCollateral() As String
            Return collateral
        End Function
        Public Function GetLoanAmount() As Integer
            Return amount_of_loan
        End Function
        Public Function GetLoanPeriod() As Integer
            Return loan_period
        End Function
        Public Function GetInterestCharged() As Single
            Return interest_charged
        End Function
        Public Function GetIssueDate() As DateTime
            Return issueDate
        End Function
        Public Function GetPhoneNumber() As String
            Return phoneNumber
        End Function
        Public Function GetMonthlyInstallment() As Single
            Return monthly_installment
        End Function

        Public Function GetTotalPayements() As Single
            Return total_payment
        End Function


        Public Function GetPeriodForLoan() As Boolean
            Return period
        End Function


    End Class

    Private Class OfficeUse
        Private loan_officer As String
        Private date_issued As DateTime
        Private due_date As DateTime

        Public Sub SetLoanOfficer(value As String)
            loan_officer = value
        End Sub
        Public Sub SetDateIssued(value As DateTime)
            date_issued = value
        End Sub
        Public Sub SetDueDate(value As String)
            due_date = value
        End Sub

        Public Function GetLoanOfficer() As String
            Return loan_officer
        End Function

        Public Function GetDateIssued() As DateTime
            Return date_issued
        End Function

        Public Function GetDueDate() As DateTime
            Return due_date
        End Function
    End Class

    Private Class Loan
        Private loan_type As String

        Public Sub SetLoanType(value As String)
            loan_type = value
        End Sub

        Public Function GetLoanType() As String
            Return loan_type
        End Function

    End Class


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles transID.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles addrs.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rand As New Random()

        IDBox.Text = CStr(rand.Next(10101, 202021))
        Dim transId As Integer = CInt(IDBox.Text)

        transactionObj.SetTransID(transId)

        For periods As Integer = 1 To 24
            ComboBox1.Items.Add(periods)
        Next

        DomainUpDown1.Items.Add("--SELECT--")
        DomainUpDown1.Items.Add("Vehicle Loan")
        DomainUpDown1.Items.Add("Home Loan")
        DomainUpDown1.Items.Add("Business Loan")
        DomainUpDown1.Items.Add("Pet Loan")
        DomainUpDown1.Items.Add("Personal Loan")

        DomainUpDown2.Items.Add("Yes")
        DomainUpDown2.Items.Add("No")

        DomainUpDown2.SelectedIndex = 1
        DomainUpDown1.SelectedIndex = 0

        delBtn.Enabled = False
        updateBtn.Enabled = False
        IDBox.Enabled = False
    End Sub

    Private Sub ComboBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
        Dim userInputText As String = ComboBox1.Text.Trim()

        If Not String.IsNullOrEmpty(userInputText) Then
            'Try Parsing the input as a valid integer
            If Integer.TryParse(userInputText, Nothing) Then
                transactionObj.SetLoanPeriod(CInt(userInputText))
            Else
                MessageBox.Show("Invalid Input, Enter a valid number")
                'Cancel the event keeping the ComboBox focused
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Try
            transactionObj.SetLoanPeriod(CInt(ComboBox1.Text))
        Catch ex As Exception
            MessageBox.Show("Invalid Input!", "Try again")
            ComboBox1.Text = "1"
        End Try
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IDBox_TextChanged_1(sender As Object, e As EventArgs) Handles IDBox.TextChanged

    End Sub

    Private Sub AccountNumberBox_TextChanged(sender As Object, e As EventArgs) Handles AccountNumberBox.TextChanged
        transactionObj.SetAccountNumber(AccountNumberBox.Text)
    End Sub

    Private Sub addressBox_TextChanged(sender As Object, e As EventArgs) Handles addressBox.TextChanged
        transactionObj.SetAddress(addressBox.Text)
    End Sub

    Private Sub AccountNameBox_TextChanged(sender As Object, e As EventArgs) Handles AccountNameBox.TextChanged
        transactionObj.SetAccountName(AccountNameBox.Text)
    End Sub

    Private Sub AmountLoanBox_TextChanged(sender As Object, e As EventArgs) Handles AmountLoanBox.TextChanged
        Try
            transactionObj.SetLoanAmount(CInt(AmountLoanBox.Text))

        Catch ex As Exception
            MessageBox.Show("Invalid Input!", "Try again")
            AmountLoanBox.Text = ""
        End Try
    End Sub

    Private Sub interest_ValueChanged(sender As Object, e As EventArgs) Handles interest.ValueChanged
        Try
            transactionObj.SetInterestCharged(CDbl(interest.Text) + 1)
        Catch ex As Exception
            MessageBox.Show("Invalid Input!", "Try again")
            interest.Text = ""
        End Try
    End Sub

    Private Sub monthPeriod_CheckedChanged(sender As Object, e As EventArgs) Handles monthPeriod.CheckedChanged
        transactionObj.SetPeriodForLoan(True)
    End Sub

    Private Sub yearPeriod_CheckedChanged(sender As Object, e As EventArgs) Handles yearPeriod.CheckedChanged
        transactionObj.SetPeriodForLoan(False)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub branchBox_TextChanged(sender As Object, e As EventArgs) Handles branchBox.TextChanged
        transactionObj.SetBranchName(branchBox.Text)
    End Sub

    Private Sub issueDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles issueDateTimePicker.ValueChanged
        transactionObj.SetIssueDate(issueDateTimePicker.Value)
    End Sub

    Private Sub occupationBox_TextChanged(sender As Object, e As EventArgs) Handles occupationBox.TextChanged
        transactionObj.SetOccupation(occupationBox.Text)
    End Sub

    Private Sub phoneNumBox_TextChanged(sender As Object, e As EventArgs) Handles phoneNumBox.TextChanged
        Dim phoneNum = New String((phoneNumBox.Text).Where(Function(c) Char.IsDigit(c)).ToArray())


        If phoneNum.Length = 10 Then
            phoneNum = "0" & phoneNum.Substring(1, 3) & " " & phoneNum.Substring(4, Math.Min(3, phoneNum.Length - 4)) & " " & phoneNum.Substring(7, Math.Min(4, phoneNum.Length - 7))
        End If

        phoneNumBox.Text = phoneNum
        ' Select the cursor to be at the end
        phoneNumBox.SelectionStart = phoneNumBox.Text.Length

        transactionObj.SetPhoneNumber(phoneNum)
    End Sub

    Private Sub collateralBox_TextChanged(sender As Object, e As EventArgs) Handles collateralBox.TextChanged
        transactionObj.SetCollateral(collateralBox.Text)
    End Sub

    Private Sub calc_payment_Click(sender As Object, e As EventArgs) Handles calc_payment.Click
        Dim mntly_interest As Single = ((transactionObj.GetInterestCharged()) / (12 * 100))
        Dim ln_prd As Integer

        If (transactionObj.GetPeriodForLoan()) Then
            ln_prd = transactionObj.GetLoanPeriod()
            Period = "Monthly"
        Else
            ln_prd = transactionObj.GetLoanPeriod() * 12
            Period = "Yearly"
        End If

        Dim mntly_inst As Single
        Try
            mntly_inst = (transactionObj.GetLoanAmount() * mntly_interest * (1 + mntly_interest) ^ ln_prd) / (((1 + mntly_interest) ^ ln_prd) - 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mntly_inst = (transactionObj.GetLoanAmount() * mntly_interest * (1 + mntly_interest) ^ ln_prd) / (((1 + mntly_interest) ^ ln_prd) - 1)
        End Try

        transactionObj.SetMontlyInstallment(mntly_inst)

        transactionObj.SetTotalPayment(transactionObj.GetMonthlyInstallment() * transactionObj.GetLoanPeriod())
        'transactionObj.GetInterestCharged()
        ' transactionObj.GetLoanPeriod()

        totalPayBox.Text = "Total Payment: R" & transactionObj.GetTotalPayements()
        montlyInstallBox.Text = "Montly Installments: R" & transactionObj.GetMonthlyInstallment()
    End Sub

    Private Sub montlyInstallBox_TextChanged(sender As Object, e As EventArgs) Handles montlyInstallBox.TextChanged

    End Sub

    Private Sub loanofficer_TextChanged(sender As Object, e As EventArgs) Handles loanofficer.TextChanged
        officeuseObj.SetLoanOfficer(loanofficer.Text)
    End Sub



    Private Sub dateIssued_ValueChanged(sender As Object, e As EventArgs) Handles dateIssued.ValueChanged
        officeuseObj.SetDateIssued(dateIssued.Value)
    End Sub

    Private Sub dueDate_ValueChanged(sender As Object, e As EventArgs) Handles dueDate.ValueChanged
        officeuseObj.SetDueDate(dueDate.Value)
    End Sub

    Private Sub btnConnectDB_Click(sender As Object, e As EventArgs) Handles btnConnectDB.Click

        myConn = New SqlConnection("Initial Catalog = Loans; " & "Data Source = LSBSA-10L6HW3; Integrated Security = SSPI;") 'Provide server, DB, Integrated Security = SSPI for Windows authentication


        myCmd = myConn.CreateCommand
        'Open Connection and Execute the above command
        myConn.Open()

        'Insert Data to the Database
        Try
            myCmd.CommandText = "INSERT INTO dbo.LoanTransaction(TransID, AccountName, AccountNo, " &
                                "Address_, AmountLoan, InterestCharged, PeriodOfLoan, Branch_, " &
                                "IssueDate, Occupation, PhoneNumber, Collateral, period_, TotalPayment, MonthlyPayement) " &
                                "VALUES('" & transactionObj.GetTransID() & "',' " & transactionObj.GetAccountName() & "', " &
                                "'" & transactionObj.GetAccountNumber() & "',' " & transactionObj.GetAddress() & "', " &
                                "'" & transactionObj.GetLoanAmount() & "',' " & transactionObj.GetInterestCharged() & "', " &
                                "'" & transactionObj.GetLoanPeriod() & "',' " & transactionObj.GetBranchName() & "', " &
                                "'" & transactionObj.GetIssueDate() & "',' " & transactionObj.GetOccupation() & "', " &
                                "'" & transactionObj.GetPhoneNumber() & "',' " & transactionObj.GetCollateral() & "', " &
                                "'" & Period & "', ' " & transactionObj.GetTotalPayements() & "',' " & transactionObj.GetMonthlyInstallment() & "' )"

            ', MonthlyPayement , ' " & transactionObj.GetMonthlyInstallment() & " '

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Dim ty As Type = transactionObj.GetTotalPayements().GetType
            Console.WriteLine(ty)

        Finally

            If myCmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Record Entered Sucessfully")
            Else
                MessageBox.Show("Record failed to Insert to Database(Transaction Table)")
            End If

        End Try


        myCmd = myConn.CreateCommand
        Try

            myCmd.CommandText = "INSERT INTO dbo.OfficeUse(Loanofficer, DateIssued, DateDue) " &
                                 "VALUES('" & officeuseObj.GetLoanOfficer() & "', '" & officeuseObj.GetDateIssued() & "', " &
                                 " '" & officeuseObj.GetDueDate() & "')"

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            If myCmd.ExecuteNonQuery() = 1 Then

            Else
                MessageBox.Show("Record failed to Insert to Database(Office Use Table)")
            End If

        End Try

        myCmd = myConn.CreateCommand
        Try


            myCmd.CommandText = "INSERT INTO dbo.LoanType(TypeLoan) VALUES('" & loanObj.GetLoanType() & "')"
            ', MonthlyPayement , ' " & transactionObj.GetMonthlyInstallment() & " '

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            If myCmd.ExecuteNonQuery() = 1 Then

            Else
                MessageBox.Show("Record failed to Insert to Database(LoanType Table)")
            End If

        End Try



        ' READING FROM DATABASE
        myCmd.CommandText = "SELECT * FROM dbo.LoanTransaction"

        myReader = myCmd.ExecuteReader

        Try
            If myReader IsNot Nothing Then
                'Reads from DB
                Do While myReader.Read()
                    ' myReader = myCmd.ExecuteNonQuery()
                    result = result & myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbTab & myReader.GetDecimal(4) & vbTab & myReader.GetDecimal(5) & vbTab & myReader.GetInt32(6) & vbTab & myReader.GetString(7) & vbTab & myReader.GetDateTime(8) & vbTab & myReader.GetString(9) & vbTab & myReader.GetString(10) & vbTab & myReader.GetString(11) & vbLf
                Loop
                MessageBox.Show(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' myConn.Close()
        End Try



        myConn.Close()
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        Try
            loanObj.SetLoanType(DomainUpDown1.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Input!", "Try again")
            interest.Text = ""
        End Try
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        myConn = New SqlConnection("Initial Catalog = Loans; " & "Data Source = LSBSA-10L6HW3; Integrated Security = SSPI;") 'Provide server, DB, Integrated Security = SSPI for Windows authentication
        myCmd = myConn.CreateCommand


        'Open Connection and Execute the above command
        myConn.Open()

        ' UPDATE TO THE DATABASE
        Dim trans As Integer = 4546465
        Dim coll As String = " Car"
        Try
            myCmd.CommandText = "UPDATE dbo.LoanTransaction SET TransID= '" & trans & "' WHERE Collateral = '" & coll & "'"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If myCmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Record Updated Sucessfully")
            Else
                MessageBox.Show("Record failed to Update to the Database")
            End If

            myConn.Close()
        End Try


    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        myConn = New SqlConnection("Initial Catalog = Loans; " & "Data Source = LSBSA-10L6HW3; Integrated Security = SSPI;") 'Provide server, DB, Integrated Security = SSPI for Windows authentication
        myCmd = myConn.CreateCommand


        'Open Connection and Execute the above command
        myConn.Open()

        ' UPDATE TO THE DATABASE
        Dim trans As Integer = 4546465
        Dim coll As String = " Car"

        Try
            myCmd.CommandText = "DELETE FROM dbo.LoanTransaction WHERE Collateral = '" & coll & "'"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If myCmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Record Updated Sucessfully")
            Else
                MessageBox.Show("Record failed to Update to the Database")
            End If

            myConn.Close()
        End Try

    End Sub

    Private Sub DomainUpDown2_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown2.SelectedItemChanged
        If (DomainUpDown2.Text = "Yes") Then
            delBtn.Enabled = True
            updateBtn.Enabled = True
        Else
            delBtn.Enabled = False
            updateBtn.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub




    ' Private Sub issueDateBox_TextChanged(sender As Object, e As EventArgs) Handles issueDateBox.TextChanged
    ' End Sub
End Class
