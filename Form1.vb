Public Class Form1
    Private Sub lblFrenchFive_Click(sender As Object, e As EventArgs) Handles lblFrenchFive.Click

    End Sub

    Private Sub lblFrenchFour_Click(sender As Object, e As EventArgs) Handles lblFrenchFour.Click

    End Sub

    Private Sub lblFrenchOne_Click(sender As Object, e As EventArgs) Handles lblFrenchOne.Click

    End Sub

    Private Sub lblFrenchTwo_Click(sender As Object, e As EventArgs) Handles lblFrenchTwo.Click

    End Sub

    Private Sub lblFrenchThree_Click(sender As Object, e As EventArgs) Handles lblFrenchThree.Click

    End Sub

    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles BtnOne.Click
        lblFrenchFive.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = True
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrenchFive.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchTwo.Visible = True
        lblFrenchOne.Visible = False
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrenchFive.Visible = False
        lblFrenchFour.Visible = False
        lblFrenchThree.Visible = True
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = False
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrenchFive.Visible = False
        lblFrenchFour.Visible = True
        lblFrenchThree.Visible = False
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = False
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrenchFive.Visible = True
        lblFrenchFour.Visible = False
        lblFrenchThree.Visible = False
        lblFrenchTwo.Visible = False
        lblFrenchOne.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
