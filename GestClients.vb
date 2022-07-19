Imports System.Data.SqlClient

Public Class GestClients



    Private Sub GestClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'GestStockTelebDataSet.Revendeur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.RevendeurTableAdapter1.Fill(Me.GestStockTelebDataSet.Revendeur)
        
        cb_RechClient.Text = ""
        vider()
        pn_Ajouter.Visible = False
        pn_Rechercher.Visible = False
        
        alimenterDG()
        
        editR.HeaderText = "Modifier"
        editR.Text = "M"
        editR.UseColumnTextForButtonValue = True
        editR.Width = 80
        DataGridView1.Columns.Add(editR)







        supR.HeaderText = "Supprimer"
        supR.Text = "X"
        supR.UseColumnTextForButtonValue = True
        supR.Width = 80
        DataGridView1.Columns.Add(supR)

        alimenterCB_Clients()





    End Sub

    Sub viderRechCli()

        cb_RechClient.Items.Clear()
        cb_RechClient.Text = ""


    End Sub
    Sub alimenterCB_Clients()


        viderRechCli()
        cn.Close()
        cn.Open()
        cmd = New SqlCommand("SELECT nomRevend FROM Revendeur", cn)


        dr = cmd.ExecuteReader

        Do While dr.Read()
            cb_RechClient.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub



    Private Sub viderAjout()

        txt_nomr.Clear()
        txtadr.Clear()
        txtteler.Clear()
        viderDGPourcent()
        DataGridView2.Visible = False
        ck_Pourcentages.Checked = False
        ck_CliNorm.Checked = False

    End Sub


    Private Sub vider()

        DataGridView1.Rows.Clear()
        cb_RechClient.Items.Clear()
        cb_RechClient.Text = ""
        txtadr.Clear()
        txtteler.Clear()
        txt_nomr.Clear()
    End Sub


    Private Sub viderSansCbRech()

        DataGridView1.Rows.Clear()
           txtadr.Clear()
        txtteler.Clear()

    End Sub


    Private Sub alimenterDG()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select nomRevend,adrRevend,telRevend FROM Revendeur", cn)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim x As String() = {dr(0), dr(1), dr(2)}

            DataGridView1.Rows.Add(x)

        End While
        dr.Close()
        cn.Close()



    End Sub


    Private Sub BT_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Annuler.Click

        ck_Pourcentages.Checked = False
        ck_CliNorm.Checked = False
        viderDGPourcent()

        DataGridView2.Visible = False
        BTModifPourc.Visible = False
        lblModifPourc.Visible = False
        lblModifPourcE.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblAjout.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False

        txt_nomr.Clear()
        viderRechCli()
        cn.Close()
        cn.Open()

        'RB_Rechercher.Checked = False
        'RB_Ajouter.Checked = False

        vider()
        alimenterDG()

        pn_Rechercher.Visible = False
        pn_Ajouter.Visible = False

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        ' If DataGridView1.CurrentCell.Selected = True Or DataGridView1.CurrentRow.Selected = True Then

        lblModifPourc.Visible = False
        lblModifPourcE.Visible = False
        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False

        
        Dim nom, adr, tel As String

        ' nom = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        nomR = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value



        viderDGPourcent()
        DataGridView2.Visible = True
        alimenterDGPourcentRevend()
        BTModifPourc.Visible = True
        ' End If

        Dim ligne As Integer
        'Dim colonne As Integer
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        ' --- Récupération des lignes et colonnes
        ligne = Me.DataGridView1.CurrentRow.Index
        'colonne = Me.DataGridView1.CurrentCell.ColumnIndex()




        If e.ColumnIndex = 4 Then

            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblAjout.Visible = False
            lblmodif.Visible = False
            lblmodife.Visible = False
            lblModifPourc.Visible = False
            lblModifPourcE.Visible = False

            If MsgBox("Voulez-vous vraiment supprimer ce revendeur ?", vbYesNo) = vbYes Then

              

                nom = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

                cn.Close()
                cn.Open()
                cmd = New SqlCommand("DELETE FROM Revendeur WHERE nomRevend = '" & nom & "'", cn)
                cmd1 = New SqlCommand("DELETE FROM Commande WHERE codeRevend = (select codeRevend from Revendeur where nomRevend= '" & nom & "')", cn)
                cmd2 = New SqlCommand("DELETE FROM AvoirPourcent where codeRevend = (select codeRevend from Revendeur where nomRevend= '" & nom & "')", cn)
                j = cmd1.ExecuteNonQuery
                j = cmd2.ExecuteNonQuery
                i = cmd.ExecuteNonQuery

                If (i > 0) Then


                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    cn.Close()
                    vider()
                    alimenterDG()
                    alimenterCB_Clients()
                    lblSupp.Visible = True
                    viderDGPourcent()
                    DataGridView2.Visible = False
                    BTModifPourc.Visible = False
                Else
                    lblSuppe.Visible = True

                End If
                cn.Close()
            End If
        End If

        If e.ColumnIndex = 3 Then

           
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblAjout.Visible = False
            lblmodif.Visible = False
            lblmodife.Visible = False
            lblModifPourc.Visible = False
            lblModifPourcE.Visible = False




            nom = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            adr = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            tel = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value


            '   pourc = CDec(Val(pourct))

            nom = nom.ToUpper()

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("UPDATE Revendeur SET nomRevend = '" & nom & "',adrRevend = '" & adr & "',telRevend = '" & tel & "' where nomRevend='" & nomR & "'", cn)
            i = cmd.ExecuteNonQuery

            '    cmd = New SqlCommand("UPDATE AvoirPourcent set ", cn)

            If (i > 0) Then
                lblmodif.Visible = True
            Else
                lblmodife.Visible = False
            End If
            cn.Close()


        End If


    End Sub

    Private Sub RB_Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Rechercher.Click

        BTModifPourc.Visible = False
        DataGridView2.Rows.Clear()
        DataGridView2.Visible = False
        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblModifPourc.Visible = False
        lblModifPourcE.Visible = False
        vider()
        alimenterCB_Clients()
        pn_Ajouter.Visible = False
        pn_Rechercher.Visible = True
        ck_Pourcentages.Checked = False
        ck_CliNorm.Checked = False

    End Sub

    'Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Rechercher.CheckedChanged

    '    BTModifPourc.Visible = False
    '    DataGridView2.Rows.Clear()
    '    DataGridView2.Visible = False
    '    lblAjout.Visible = False
    '    lblmodif.Visible = False
    '    lblmodife.Visible = False
    '    lblSupp.Visible = False
    '    lblSuppe.Visible = False
    '    lblModifPourc.Visible = False
    '    lblModifPourcE.Visible = False
    '    vider()
    '    alimenterCB_Clients()
    '    pn_Ajouter.Visible = False
    '    pn_Rechercher.Visible = True
    '    ck_Pourcentages.Checked = False
    '    ck_CliNorm.Checked = False
    'End Sub



    Private Sub RB_Supprimer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False

        cb_RechClient.Text = ""
        vider()
        pn_Rechercher.Visible = True

    End Sub

    



    Private Sub bn_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bn_Ajouter.Click

        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblModifPourc.Visible = False
        lblModifPourcE.Visible = False


        If ck_CliNorm.Checked = False Then

            If txt_nomr.Text = "" Or txtadr.Text = "" Or txtteler.Text = "" Or ck_Pourcentages.Checked = False Then
                MsgBox("Vous devez remplir les champs afin d'ajouter un autre revendeur", MsgBoxStyle.Critical, "Remplissage des champs")

            Else

                Try


                    cn.Close()
                    cn.Open()


                    cmd = New SqlCommand("insert into Revendeur(nomRevend,adrRevend,telRevend) values('" & txt_nomr.Text & "','" & txtadr.Text & "','" & txtteler.Text & "')", cn)
                    cmd.ExecuteNonQuery()

                    pourc = DataGridView2.Rows(0).Cells(1).Value
                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Jawal')," & pourc & ")", cn)
                    cmd.ExecuteNonQuery()

                    pourc = DataGridView2.Rows(1).Cells(1).Value
                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Telecarte')," & pourc & ")", cn)
                    cmd.ExecuteNonQuery()

                    pourc = DataGridView2.Rows(2).Cells(1).Value
                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Manzil')," & pourc & ")", cn)
                    cmd.ExecuteNonQuery()

                    pourc = DataGridView2.Rows(3).Cells(1).Value
                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Bayn')," & pourc & ")", cn)
                    cmd.ExecuteNonQuery()

                    pourc = DataGridView2.Rows(4).Cells(1).Value
                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Inwi')," & pourc & ")", cn)
                    cmd.ExecuteNonQuery()

                    pourc = DataGridView2.Rows(5).Cells(1).Value
                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Meditel')," & pourc & ")", cn)
                    cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(6).Cells(1).Value
                    'cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Portable')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(7).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'P_IAM')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(8).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'P_Bayn')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(9).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'P_Inwi')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(10).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'P_Meditel')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(11).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'M_IAM')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(12).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'M_Inwi')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    'pourc = DataGridView2.Rows(13).Cells(1).Value
                    '    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'M_Meditel')," & pourc & ")", cn)
                    'cmd.ExecuteNonQuery()

                    cn.Close()
                    vider()
                    alimenterDG()
                    lblAjout.Visible = True
                    ck_Pourcentages.Checked = False


                Catch ex As Exception
                    MsgBox(ex.Message)
                    cn.Close()
                    vider()
                    alimenterDG()
                    lblAjout.Visible = True
                    ck_Pourcentages.Checked = False

                End Try


            End If

        Else

            If txt_nomr.Text = "" Or txtadr.Text = "" Or txtteler.Text = "" Then
                MsgBox("Vous devez remplir les champs afin d'ajouter un autre revendeur", MsgBoxStyle.Critical, "Remplissage des champs")

            Else

                Try

                    cn.Close()
                    cn.Open()
                    cmd = New SqlCommand("insert into Revendeur(nomRevend,adrRevend,telRevend) values('" & txt_nomr.Text & "','" & txtadr.Text & "','" & txtteler.Text & "')", cn)
                    cmd.ExecuteNonQuery()

                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Jawal'),7)", cn)
                    cmd.ExecuteNonQuery()


                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Telecarte'),7.5)", cn)
                    cmd.ExecuteNonQuery()


                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Manzil'),7.5)", cn)
                    cmd.ExecuteNonQuery()


                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Bayn'),6.5)", cn)
                    cmd.ExecuteNonQuery()


                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Inwi'),6.5)", cn)
                    cmd.ExecuteNonQuery()


                    cmd = New SqlCommand("insert into AvoirPourcent(codeRevend,codeCateg,pourcentage) values((select codeRevend from Revendeur where nomRevend = '" & txt_nomr.Text & "'),(select codeCateg from CategoriePdt where categPdt = 'Meditel'),6)", cn)
                    cmd.ExecuteNonQuery()

                    cn.Close()
                    vider()
                    alimenterDG()
                    lblAjout.Visible = True

                Catch ex As Exception
                    MsgBox(ex.Message)
                    cn.Close()
                    vider()
                    alimenterDG()
                    lblAjout.Visible = True
                    ck_Pourcentages.Checked = False

                End Try

            End If
        End If


    End Sub

    Private Sub bn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pn_Ajouter.Visible = False
        pn_Rechercher.Visible = False
    End Sub

    Private Sub RB_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.Click

        vider()
        ck_Pourcentages.Checked = False
        BTModifPourc.Visible = False
        DataGridView2.Rows.Clear()
        DataGridView2.Visible = False
        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblModifPourc.Visible = False
        lblModifPourcE.Visible = False
        viderDGPourcent()
        alimenterDG()
        pn_Rechercher.Visible = False
        pn_Ajouter.Visible = True

    End Sub

    'Private Sub RB_Ajouter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.CheckedChanged
    '    If RB_Ajouter.Checked = True Then

    '        vider()
    '        ck_Pourcentages.Checked = False
    '        BTModifPourc.Visible = False
    '        DataGridView2.Rows.Clear()
    '        DataGridView2.Visible = False
    '        lblAjout.Visible = False
    '        lblmodif.Visible = False
    '        lblmodife.Visible = False
    '        lblSupp.Visible = False
    '        lblSuppe.Visible = False
    '        lblModifPourc.Visible = False
    '        lblModifPourcE.Visible = False
    '        viderDGPourcent()
    '        alimenterDG()
    '        pn_Rechercher.Visible = False
    '        pn_Ajouter.Visible = True

    '    End If
    'End Sub

    Private Sub txt_nomr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nomr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtadr.Select()
        End If
    End Sub


    Private Sub txt_nomr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nomr.TextChanged

        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select nomRevend from Revendeur", cn)
        dr = cmd.ExecuteReader()
        While dr.Read

            If (dr(0) = txt_nomr.Text) Then
                MsgBox("Cet Revendeur existe déjà", MsgBoxStyle.Exclamation, "Consultation")
                Exit While
            End If
        End While

        dr.Close()
        cn.Close()

        BTModifPourc.Visible = False
        DataGridView2.Rows.Clear()
        DataGridView2.Visible = False
    End Sub

    Private Sub cb_RechClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_RechClient.SelectedIndexChanged

        '   BTModifPourc.Visible = False
        DataGridView2.Rows.Clear()
        ' DataGridView2.Visible = False

        If cb_RechClient.Text = " " Then
            MsgBox("impossible d'effectuer la recherche : champs vide")

        Else
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select nomRevend,adrRevend,telRevend FROM Revendeur WHERE nomRevend = '" & cb_RechClient.Text & "'", cn)
            dr = cmd.ExecuteReader()
            viderSansCbRech()

            dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2)}

            DataGridView1.Rows.Add(x)

            dr.Close()
            cn.Close()

            nomR = cb_RechClient.Text
            alimenterDGPourcentRevend()
            DataGridView2.Visible = True
            BTModifPourc.Visible = True

        End If
    End Sub

    Private Sub txtadr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtadr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtteler.Select()
        End If
    End Sub


    Private Sub txtadr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadr.TextChanged
        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
    End Sub

    Private Sub txtteler_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtteler.TextChanged
        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False



    End Sub

    Private Sub txt_nomrOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nomr.KeyPress

        Controle_saisie.Textbox_control(sender, e, False, False, False, True)
        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub

    Private Sub txttelerOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtteler.KeyPress

        Controle_saisie.Textbox_control(sender, e, True, True, True, False)
        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub

    Private Sub txtpOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Controle_saisie.Textbox_control(sender, e, True, False, True, False)
        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub

    Private Sub txtp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False

    End Sub


    
    Private Sub BTAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAnnuler.Click
        viderAjout()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerRch.Click
        'RB_Rechercher.Checked = False
        viderRechCli()
        BtFerRch.Visible = False
        pn_Rechercher.Visible = False
    End Sub

    Private Sub BtFerAj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerAj.Click

        BTModifPourc.Visible = False
        'RB_Ajouter.Checked = False
        viderAjout()
        BtFerAj.Visible = False
        pn_Ajouter.Visible = False
        ck_Pourcentages.Checked = False
        DataGridView2.Visible = False

    End Sub

    Sub alimenterDGPourcentRevend()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select C.categPdt,A.pourcentage from CategoriePdt C, AvoirPourcent A where A.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & nomR & "') and A.codeCateg = C.codeCateg", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            DataGridView2.Rows.Add(dr(0), dr(1))
        Loop

        dr.Close()
        cn.Close()

    End Sub



    Sub alimenterDGPourcent()

        x = {"Jawal", 0}
        DataGridView2.Rows.Add(x)

        x = {"Telecarte", 0}
        DataGridView2.Rows.Add(x)

        x = {"Manzil", 0}
        DataGridView2.Rows.Add(x)

        x = {"Bayn", 0}
        DataGridView2.Rows.Add(x)

        x = {"Inwi", 0}
        DataGridView2.Rows.Add(x)

        x = {"Meditel", 0}
        DataGridView2.Rows.Add(x)

        'x = {"Portable", 0}
        'DataGridView2.Rows.Add(x)

        

    End Sub

   

    Sub viderDGPourcent()

        DataGridView2.Rows.Clear()

    End Sub



    Private Sub ck_Pourcentages_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_Pourcentages.CheckedChanged
        If ck_Pourcentages.Checked = True Then

            
                viderDGPourcent()
                alimenterDGPourcent()
                DataGridView2.Visible = True


        Else
            BTModifPourc.Visible = False
            viderDGPourcent()
            DataGridView2.Visible = False

        End If


    End Sub

  
    Private Sub BTModifPourc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTModifPourc.Click

        cn.Close()
        cn.Open()

        nomR = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        categ = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(0).Value
        pourc = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(1).Value

        cmd = New SqlCommand("update AvoirPourcent set pourcentage = " & pourc & " where codeCateg = (select codeCateg from CategoriePdt where categPdt = '" & categ & "') and codeRevend = (select codeRevend from Revendeur where nomRevend = '" & nomR & "')", cn)
        i = cmd.ExecuteNonQuery()

        If i > 0 Then
            lblModifPourc.Visible = True
        Else
            lblModifPourcE.Visible = True
        End If
        cn.Close()

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        lblAjout.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        lblModifPourc.Visible = False
        lblModifPourcE.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False



    End Sub

    Private Sub pn_Ajouter_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pn_Ajouter.Paint

    End Sub

    Private Sub ck_CliNorm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_CliNorm.CheckedChanged

        If ck_CliNorm.Checked = True Then

            ck_Pourcentages.Visible = False


        Else

            ck_Pourcentages.Visible = True

        End If
        ck_Pourcentages.Checked = False

    End Sub
End Class