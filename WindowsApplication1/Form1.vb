' Program: The Hoodie Shop
' Pharynn Lewis
' Dr.Bothur
' Cpt 185
' Feb. 13,2022
' Descripition: This application is to display how the user  
' enters a quantity of the product after the selction is made 
' to show the cost.


Public Class frmhoodie
    'cost of hoodies by quantity.
    Const _cdecemalcostofhoodies As Decimal = 19.95D

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        ' Dim strhoodienumber As String
        Dim intamountofhoodies As Integer
        Dim dectotalamount As Decimal

        'INPUT OF USER
        intamountofhoodies = Integer.Parse(txthoodienumber.Text)

        'PROCESSING DATA
        dectotalamount = intamountofhoodies * -_cdecemalcostofhoodies

        'OUTPUT
        lbltotalamount.Text = dectotalamount.ToString("c")

    End Sub


    Private Sub btnexitwindow_Click(sender As Object, e As EventArgs) Handles btnexitwindow.Click

    End Sub

    Private Sub frmhoodie_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    txtCost.Text = ""
    txtAmountOfHoodies.Clear()





End Class

