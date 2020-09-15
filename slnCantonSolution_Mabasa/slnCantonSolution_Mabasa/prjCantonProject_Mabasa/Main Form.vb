Option Explicit On
Option Infer Off
Option Strict On
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'useful list life
        For intLife As Integer = 3 To 20 Step 1
            lstLife.Items.Add(intLife.ToString)
        Next
        'default selected
        lstLife.SelectedItem = "3"

    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'clear all items sa lstDDB ug SYL arun every click sa button d mag add always
        lstSYD.Items.Clear()
        lstDDB.Items.Clear()
        'input values
        Dim intCost As Integer
        Dim intSalvage As Integer
        Dim intLife As Integer
        Dim dblDDB As Double
        Dim dblSYD As Double
        'parsing
        Integer.TryParse(txtCost.Text, intCost)
        Integer.TryParse(txtSalvage.Text, intSalvage)
        Integer.TryParse(lstLife.SelectedItem.ToString, intLife)

        'heading sa lists
        lstDDB.Items.Add("Year" & ControlChars.Tab & "Depreciation" & ControlChars.NewLine)
        lstSYD.Items.Add("Year" & ControlChars.Tab & "Depreciation" & ControlChars.NewLine)

        'repeat years
        For intYear As Integer = 1 To intLife Step 1
            'calculate DDB and SYD
            dblDDB = Financial.DDB(intCost, intSalvage, intLife, intYear)
            dblSYD = Financial.SYD(intCost, intSalvage, intLife, intYear)

            'Display DDB and SYD
            lstDDB.Items.Add(intYear.ToString &
                    ControlChars.Tab & dblDDB.ToString("N2"))

            lstSYD.Items.Add(intYear.ToString &
                    ControlChars.Tab & dblSYD.ToString("N2"))
        Next intYear
        'focus
        txtCost.Focus()
        txtCost.SelectAll()
    End Sub

    'highlight all text
    Private Sub txtCost_MouseUp(sender As Object, e As EventArgs) Handles txtCost.MouseUp, txtCost.Enter
        txtCost.SelectAll()
    End Sub
    Private Sub txtSalvage_MouseUp(sender As Object, e As EventArgs) Handles txtSalvage.MouseUp, txtSalvage.Enter
        txtSalvage.SelectAll()
    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress, txtSalvage.KeyPress
        ' allows only numbers and the Backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged, txtSalvage.TextChanged, lstLife.SelectedValueChanged
        'clear all items
        lstSYD.Items.Clear()
        lstDDB.Items.Clear()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
