Imports System.Data.SqlClient
Public Class Authentification

 
    Private Sub BT_Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Connexion.Click



        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select loginUser,passwdUser,idTypeUser from Utilisateur ", cn)
        dr = cmd.ExecuteReader
        cd = 0
        Do While dr.Read And cd = 0

            log = dr(0)
            pass = dr(1)
            type = dr(2)

            If log = txtLogin.Text And pass = txtPasswd.Text Then

                If type = "admin" Then

                    MenuPrincipalAdmin.Show()
                End If

                cd = 1
            Else


                lblEchecAuth.Visible = True

            End If

        Loop

        dr.Close()
        cn.Close()


    End Sub


    Private Sub Authentification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ActivateMdiChild(MenuPrincipalAdmin)
       

    End Sub

    Private Sub txtLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged

        lblEchecAuth.Visible = False
    End Sub

    Private Sub txtPasswd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswd.TextChanged


        lblEchecAuth.Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
