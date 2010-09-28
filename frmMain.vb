Public Class frmMain
    Private Function GetLastName(ByVal strName As String) As String

        Dim intComma As Integer

        'Extracts last name from "Customer name:" textbox
        intComma = strName.IndexOf(",")
        strName = strName.Substring(0, intComma)

        Return strName

    End Function

    Private Function GetFirstName(ByVal strName As String) As String

        Dim intSpace As Integer

        'Extracts first name from "Customer name:" textbox
        strName = StrReverse(strName)
        intSpace = strName.IndexOf(" ")
        strName = strName.Substring(0, intSpace)
        strName = StrReverse(strName)

        Return strName

    End Function

    Private Function GetInvoiceNum(ByVal strName As String, ByVal strNum As String) As String

        'Gets first two letters of last name and last four digits of zipcode
        strName = strName.Substring(0, 2)
        strNum = StrReverse(strNum)
        strNum = strNum.Substring(0, 4)
        strNum = StrReverse(strNum)

        Return strName.ToUpper & strNum

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\price and tax data.txt")
        Dim dblChair, dblSofa, dblTax, dblCost As Double
        Dim fmtStr As String = "{0,11}{1,13}"

        dblChair = CDbl(sr.ReadLine)
        dblSofa = CDbl(sr.ReadLine)
        dblTax = CDbl(sr.ReadLine)
        dblCost = (dblChair * CDbl(txtChair.Text)) + (dblSofa * CDbl(txtSofa.Text))

        'Displays invoice form in the list box
        lstDisplay.Items.Add(String.Format("Invoice Number: " & GetInvoiceNum(txtName.Text, txtCity.Text)))
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add(String.Format("Name: " & GetFirstName(txtName.Text) & " " & GetLastName(txtName.Text)))
        lstDisplay.Items.Add("Address: " & txtAddress.Text)
        lstDisplay.Items.Add("City: " & txtCity.Text)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Number of Chairs: " & txtChair.Text)
        lstDisplay.Items.Add("Number of Sofas: " & txtSofa.Text)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add(String.Format(fmtStr, "Cost:", FormatCurrency(dblCost)))
        lstDisplay.Items.Add(String.Format(fmtStr, "Sales Tax:", FormatCurrency(dblCost * dblTax)))
        lstDisplay.Items.Add(String.Format(fmtStr, "", "------------"))
        lstDisplay.Items.Add(String.Format(fmtStr, "Total Cost:", FormatCurrency(dblCost + (dblCost * dblTax))))

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        'Exits the program
        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clears all text boxes and list box
        lstDisplay.Items.Clear()
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtChair.Clear()
        txtSofa.Clear()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
