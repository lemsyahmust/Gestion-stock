Imports System.Data.SqlClient

Public Class Capital

    Private Sub Bt_Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Valider.Click

        If txtValeur.Text <> Nothing Then
            cn.Close()
            cn.Open()

            cmd = New SqlCommand("UPDATE Grossiste SET capital=capital+ " & txtValeur.Text & "", cn)
            cmd.ExecuteNonQuery()



            cmd = New SqlCommand("select capital from Grossiste", cn)
            mont = cmd.ExecuteScalar()

            lblCap.Text = "Capital : " & mont & ""

            cn.Close()
            lblModif.Visible = True

        Else
            MsgBox("vous devez absolument saisir une valeur", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub txtValeur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValeur.TextChanged
        lblModif.Visible = False
    End Sub

    Private Sub Capital_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select capital from Grossiste", cn)
        mont = cmd.ExecuteScalar()
        cn.Close()

        lblCap.Text = "Capital : " & mont & ""

    End Sub

    Private Sub lblCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCap.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class