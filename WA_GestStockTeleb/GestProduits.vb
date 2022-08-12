
Imports System.Data.SqlClient


Public Class GestProduits


    Private Sub GestProduits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'GestStockTelebDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.

        

        alimenterDG()
        'RB_Ajouter.Checked = False
        'RB_Rechercher.Checked = False

        editP.HeaderText = "Modifier"
        editP.Text = "M"
        editP.UseColumnTextForButtonValue = True
        editP.Width = 80
        DataGridView1.Columns.Add(editP)







        supP.HeaderText = "Supprimer"
        supP.Text = "X"
        supP.UseColumnTextForButtonValue = True
        supP.Width = 80
        DataGridView1.Columns.Add(supP)
        ' alimenterCB_Produits()

    End Sub




    Private Sub alimenterCB_Produits()
        cn.Close()
        cn.Open()
        cb_RechPdt.Text = ""
        cb_RechPdt.Items.Clear()

        cmd = New SqlCommand("SELECT desigPdt FROM Produit", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            cb_RechPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub
    Sub viderRech()

        RB_ModemR.Checked = False
        RB_PortableR.Checked = False
        RB_PuceR.Checked = False
        RB_RechargeR.Checked = False

        cb_RechPdt.Items.Clear()
        cb_RechPdt.Text = ""
        DataGridView1.Rows.Clear()

    End Sub

    Sub viderAjout()

        RB_Modem.Checked = False
        RB_Portable.Checked = False
        RB_Puce.Checked = False
        RB_Puce.Checked = False
        txtDesig.Clear()
        txtPrix.Clear()


    End Sub


    Sub viderSansDG()

        cb_RechPdt.Items.Clear()
        cb_RechPdt.Text = ""
        txtPrix.Clear()

    End Sub

    Sub viderChpsAjout()

        txtDesig.Clear()
        txtPrix.Clear()
        txtPourcAch.Clear()
        lblAjout.Visible = False

    End Sub

    Private Sub viderSansCbPdt()

        txtDesig.Clear()
        txtPrix.Clear()
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub RB_Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Rechercher.Click
        'RB_Ajouter.Checked = False
        DataGridView1.Rows.Clear()
        txtDesig.Clear()
        RB_ModemR.Checked = False
        RB_PortableR.Checked = False
        RB_PuceR.Checked = False
        RB_RechargeR.Checked = False

        lblAjout.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        viderAjout()
        '   alimenterCB_Produits()
        cb_RechPdt.Text = ""
        pn_Ajouter.Visible = False
        pn_Rechercher.Visible = True
        BtFerRech.Visible = True

    End Sub
    'Private Sub RB_Rechercher_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Rechercher.CheckedChanged

    '    If RB_Rechercher.Checked = True Then

    '        'RB_Ajouter.Checked = False
    '        DataGridView1.Rows.Clear()
    '    txtDesig.Clear()
    '    RB_ModemR.Checked = False
    '    RB_PortableR.Checked = False
    '    RB_PuceR.Checked = False
    '    RB_RechargeR.Checked = False

    '    lblAjout.Visible = False
    '    lblSupp.Visible = False
    '    lblSuppe.Visible = False
    '    lblmodif.Visible = False
    '    lblmodife.Visible = False
    '    viderAjout()
    '        '   alimenterCB_Produits()
    '        cb_RechPdt.Text = ""
    '    pn_Ajouter.Visible = False
    '    pn_Rechercher.Visible = True
    '        BtFerRech.Visible = True
    '    End If

    'End Sub

    Private Sub cb_RechPdt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_RechPdt.SelectedIndexChanged

        'If RB_Recharge.Checked = False And RB_Modem.Checked = False And RB_Puce.Checked = False And RB_Portable.Checked = False Then
        '    MsgBox("Vous devez cocher une catégorie afin d'effectuer la consultation")

        'End If
        lblmodif.Visible = False
        lblmodife.Visible = False

        If cb_RechPdt.Text = "" Then
            MsgBox("impossible d'effectuer la recherche : champs vide")

        Else

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select desigPdt,prixPdt,qteStock,pourcentAchat FROM Produit WHERE desigPdt = '" & cb_RechPdt.Text & "'", cn)
            dr = cmd.ExecuteReader()
            viderSansCbPdt()

            dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}

            DataGridView1.Rows.Add(x)

            dr.Close()
            cn.Close()

        End If

    End Sub

    ' Private Sub RB_Ajouter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.CheckedChanged
    ' If RB_Ajouter.Checked = True Then

    '        RB_Recharge.Checked = False
    '       RB_Modem.Checked = False
    '      RB_Portable.Checked = False
    '     RB_Puce.Checked = False
    '    cb_categPdt.Items.Clear()

    '   RB_Rechercher.Checked = False
    'DataGridView1.Rows.Clear()
    'lblAjout.Visible = False
    'lblSupp.Visible = False
    'lblSuppe.Visible = False
    'lblmodif.Visible = False
    'lblmodife.Visible = False
    'alimenterDG()
    'pn_Rechercher.Visible = False
    'pn_Ajouter.Visible = True
    'BtFerAj.Visible = True
    ''    RB_Ajouter.Checked = False


    'End If
    'End Sub 

    Private Sub RB_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.Click

        RB_Recharge.Checked = False
        RB_Modem.Checked = False
        RB_Portable.Checked = False
        RB_Puce.Checked = False
        cb_categPdt.Items.Clear()

        'RB_Rechercher.Checked = False
        DataGridView1.Rows.Clear()
        lblAjout.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
        alimenterDG()
        pn_Rechercher.Visible = False
        pn_Ajouter.Visible = True
        BtFerAj.Visible = True

    End Sub

    Private Sub bn_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bn_Ajouter.Click

        If txtDesig.Text = "" Or txtPrix.Text = "" Then
            MsgBox("Vous devez remplir les champs afin d'ajouter un nouveau produit", MsgBoxStyle.Critical, "Remplissage des champs")

        Else

            cn.Close()
            cn.Open()

            If RB_Recharge.Checked = True Then
                If cb_categPdt.SelectedItem = Nothing Then

                    MsgBox("Vous devez absolument selectionner une catégorie de recharge", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

                Else

                    cmd = New SqlCommand("insert into Produit(desigPdt,prixPdt,qteStock,codeCateg,pourcentAchat) values('" & txtDesig.Text & "'," & txtPrix.Text & ", 0 ,(select codeCateg from CategoriePdt where categPdt = '" & cb_categPdt.Text & "')," & txtPourcAch.Text & ")", cn)
                    cmd.ExecuteNonQuery()

                    If cb_categPdt.Text = "Jawal" Or cb_categPdt.Text = "Telecarte" Or cb_categPdt.Text = "Manzil" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(1,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "Bayn" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(3,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "Inwi" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(4,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "Meditel" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(2,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    End If

                    viderDG()
                    alimenterDG()
                    lblAjout.Visible = True
                End If


            ElseIf RB_Portable.Checked = True Then

                cmd = New SqlCommand("insert into Produit(desigPdt,prixPdt,qteStock,codeCateg,pourcentAchat) values('" & txtDesig.Text & "'," & txtPrix.Text & ", 0 ,7," & txtPourcAch.Text & ")", cn)
                cmd.ExecuteNonQuery()


                viderDG()
                alimenterDG()
                lblAjout.Visible = True


            ElseIf RB_Puce.Checked = True Then

                If cb_categPdt.SelectedItem = Nothing Then

                    MsgBox("Vous devez absolument selectionner une catégorie de puces", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

                Else


                    cmd = New SqlCommand("insert into Produit(desigPdt,prixPdt,qteStock,codeCateg,pourcentAchat) values('" & txtDesig.Text & "'," & txtPrix.Text & ", 0 ,(select codeCateg from CategoriePdt where categPdt = '" & cb_categPdt.Text & "')," & txtPourcAch.Text & ")", cn)
                    cmd.ExecuteNonQuery()

                    If cb_categPdt.Text = "P_IAM" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(1,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "P_Bayn" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(3,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "P_Inwi" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(4,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "P_Meditel" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(2,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    End If

                    viderDG()
                    alimenterDG()
                    lblAjout.Visible = True

                End If

            ElseIf RB_Modem.Checked = True Then

                If cb_categPdt.SelectedItem = Nothing Then

                    MsgBox("Vous devez absolument selectionner une catégorie de puces", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

                Else


                    cmd = New SqlCommand("insert into Produit(desigPdt,prixPdt,qteStock,codeCateg,pourcentAchat) values('" & txtDesig.Text & "'," & txtPrix.Text & ", 0 ,(select codeCateg from CategoriePdt where categPdt = '" & cb_categPdt.Text & "')," & txtPourcAch.Text & ")", cn)
                    cmd.ExecuteNonQuery()

                    If cb_categPdt.Text = "M_IAM" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(1,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "M_Inwi" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(4,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    ElseIf cb_categPdt.Text = "M_Meditel" Then

                        cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(2,(select codePdt from Produit where desigPdt = '" & txtDesig.Text & "'),0,'2011-01-01')", cn)
                        cmd.ExecuteNonQuery()

                    End If

                    viderDG()
                    alimenterDG()
                    lblAjout.Visible = True

                End If
            End If

            viderChpsAjout()
            cn.Close()

        End If
    End Sub

    Sub viderDG()

        DataGridView1.Rows.Clear()

    End Sub

    Private Sub txtDesig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesig.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtPrix.Select()
        End If

    End Sub

    Private Sub txtDesig_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesig.TextChanged

        If RB_Modem.Checked = False And RB_Portable.Checked = False And RB_Puce.Checked = False And RB_Recharge.Checked = False Then

            MsgBox("sélectionnez d'abord la catégorie du produit à ajouter", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

        Else



            lblAjout.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblmodif.Visible = False
            lblmodife.Visible = False

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select desigPdt from Produit", cn)
            dr = cmd.ExecuteReader()

            While dr.Read

                If (dr(0) = txtDesig.Text) Then
                    MsgBox("Ce produit existe déjà", MsgBoxStyle.Exclamation, "Consultation")
                    Exit While
                End If
            End While

            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub alimenterDG()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select desigPdt,prixPdt,qteStock,pourcentAchat FROM Produit", cn)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}

            DataGridView1.Rows.Add(x)

        End While
        dr.Close()
        cn.Close()



    End Sub

    Private Sub BT_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Annuler.Click

        RB_Modem.Checked = False
        RB_ModemR.Checked = False
        RB_Portable.Checked = False
        RB_PortableR.Checked = False
        RB_Puce.Checked = False
        RB_PuceR.Checked = False
        RB_Recharge.Checked = False
        RB_RechargeR.Checked = False

        lblmodife.Visible = False
        lblmodif.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblAjout.Visible = False

        txtDesig.Clear()

        cb_RechPdt.Items.Clear()
        cb_RechPdt.Text = ""

        'RB_Rechercher.Checked = False
        'RB_Ajouter.Checked = False

        viderAjout()
        viderRech()
        alimenterDG()
        pn_Rechercher.Visible = False
        pn_Ajouter.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim ligne As Integer
        'Dim colonne As Integer
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        ' --- Récupération des lignes et colonnes
        ligne = Me.DataGridView1.CurrentRow.Index
        'colonne = Me.DataGridView1.CurrentCell.ColumnIndex()


        Dim desig As String
        Dim prix As Double
      
        If e.ColumnIndex = 5 Then

            lblAjout.Visible = False
            lblmodif.Visible = False
            lblmodife.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False

            If MsgBox("Voulez-vous vraiment supprimer ce produit ?", vbYesNo) = vbYes Then

                desig = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

                cn.Close()
                cn.Open()
                cmd = New SqlCommand("DELETE FROM Produit WHERE desigPdt = '" & desig & "'", cn)

                i = cmd.ExecuteNonQuery

                If (i > 0) Then

                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    cn.Close()
                    'vider()
                    lblSupp.Visible = True
                    alimenterCB_Produits()

                Else
                    lblSuppe.Visible = False
                    cn.Close()
                End If


            End If
        End If


        If e.ColumnIndex = 2 Then
            MsgBox("Attention !! vous ne pouvez pas modifier la quantité.", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

        End If


        If e.ColumnIndex = 4 Then

            lblAjout.Visible = False
            lblmodif.Visible = False
            lblmodife.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False


            desig = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            prix = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            pourc = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
            desig = desig.ToUpper()

            cn.Close()
            cn.Open()

            cmd = New SqlCommand("UPDATE Produit SET prixPdt = " & prix & " , pourcentAchat = " & pourc & " where codePdt= (select codePdt from Produit where desigPdt = '" & desig & "')", cn)
            i = cmd.ExecuteNonQuery


            If (i > 0) Then

                lblmodif.Visible = True

            Else
                lblmodife.Visible = True


            End If
            cn.Close()


        End If


    End Sub

    Private Sub txtPrix_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrix.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPourcAch.Select()
        End If
    End Sub


    Private Sub txtPrix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrix.TextChanged

        If RB_Modem.Checked = False And RB_Portable.Checked = False And RB_Puce.Checked = False And RB_Recharge.Checked = False Then

            MsgBox("sélectionnez d'abord la catégorie du produit à ajouter", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

        Else

        lblAjout.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False

        End If

    End Sub

    Private Sub txtPrixOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrix.KeyPress

        Controle_saisie.Textbox_control(sender, e, True, True, True, False)
        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub


    Private Sub txtQte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblAjout.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblmodif.Visible = False
        lblmodife.Visible = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_RechargeR.CheckedChanged
      
        If RB_RechargeR.Checked = True Then
            viderSansDG()
            DataGridView1.Rows.Clear()
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select desigPdt from Produit where codeCateg in ( select codeCateg from CategoriePdt where typeCateg = 'Recharge')", cn)
            dr = cmd.ExecuteReader()

            Dim x As String

            Do While dr.Read

                x = dr(0)
                cb_RechPdt.Items.Add(x)

            Loop

            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_PortableR.CheckedChanged


        If RB_PortableR.Checked = True Then
            viderSansDG()
            DataGridView1.Rows.Clear()
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select desigPdt from Produit where codeCateg in ( select codeCateg from CategoriePdt where typeCateg = 'Portable')", cn)
            dr = cmd.ExecuteReader()

            Dim x As String

            Do While dr.Read

                x = dr(0)
                cb_RechPdt.Items.Add(x)

            Loop

            dr.Close()
            cn.Close()

        End If
    End Sub

    Private Sub RB_PuceR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_PuceR.CheckedChanged

        If RB_PuceR.Checked = True Then
            viderSansDG()
            DataGridView1.Rows.Clear()
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select desigPdt from Produit where codeCateg in ( select codeCateg from CategoriePdt where typeCateg = 'Puce')", cn)
            dr = cmd.ExecuteReader()

            Dim x As String

            Do While dr.Read

                x = dr(0)
                cb_RechPdt.Items.Add(x)

            Loop
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub RB_ModemR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ModemR.CheckedChanged


        If RB_ModemR.Checked = True Then
            viderSansDG()
            DataGridView1.Rows.Clear()
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select desigPdt from Produit where codeCateg in ( select codeCateg from CategoriePdt where typeCateg = 'Modem')", cn)
            dr = cmd.ExecuteReader()


            Dim x As String

            Do While dr.Read

                x = dr(0)
                cb_RechPdt.Items.Add(x)

            Loop
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub RB_Portable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Portable.CheckedChanged


        viderCacherCateg()
        viderSansDG()
        viderChpsAjout()
    End Sub

    Sub viderCacherCateg()

        lblCategPdt.Visible = False
        cb_categPdt.Text = ""
        cb_categPdt.Visible = False
        cb_categPdt.Items.Clear()
    End Sub

    Private Sub RB_Recharge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Recharge.CheckedChanged

        If RB_Recharge.Checked = True Then

            cb_categPdt.Items.Clear()
            lblCategPdt.Visible = True
            cb_categPdt.Visible = True
            alimenterCategRecharges()

        End If

        viderSansDG()
        viderChpsAjout()
    End Sub

    Private Sub RB_Puce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Puce.CheckedChanged

        If RB_Puce.Checked = True Then

            cb_categPdt.Items.Clear()
            lblCategPdt.Visible = True
            cb_categPdt.Visible = True
            alimenterCategPuces()

        End If
        viderSansDG()
        viderChpsAjout()
    End Sub

    Private Sub RB_Modem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Modem.CheckedChanged

        If RB_Modem.Checked = True Then

            cb_categPdt.Items.Clear()
            lblCategPdt.Visible = True
            cb_categPdt.Visible = True
            alimenterCategModems()

        End If
        viderSansDG()
        viderChpsAjout()
    End Sub

    Private Sub BTAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAnnuler.Click
      viderChpsAjout()

    End Sub

    Private Sub BtFerRech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerRech.Click
        viderRech()
        'RB_Rechercher.Checked = False
        'RB_Ajouter.Checked = False
        pn_Rechercher.Visible = False
        BtFerRech.Visible = False
    End Sub
    Sub alimenterCategRecharges()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select categPdt from CategoriePdt where typeCateg = 'Recharge'", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cb_categPdt.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()

    End Sub

    Sub alimenterCategPuces()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select categPdt from CategoriePdt where typeCateg = 'Puce'", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cb_categPdt.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()

    End Sub

    Sub alimenterCategModems()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select categPdt from CategoriePdt where typeCateg = 'Modem'", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cb_categPdt.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()

    End Sub

    Private Sub BtFerAj_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerAj.Click

        viderAjout()
        pn_Ajouter.Visible = False
        BtFerAj.Visible = False
        'RB_Ajouter.Checked = False
        'RB_Rechercher.Checked = False
    End Sub

    Private Sub cb_categPdt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_categPdt.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDesig.Select()
        End If
    End Sub

    Private Sub cb_categPdt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_categPdt.SelectedIndexChanged
        lblAjout.Visible = False
    End Sub

    Private Sub txtPourcAch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPourcAch.KeyDown
        If e.KeyCode = Keys.Enter Then
            bn_Ajouter.Select()
        End If
    End Sub

    Private Sub txtPourcAchOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPourcAch.KeyPress

        Controle_saisie.Textbox_control(sender, e, True, True, True, False)
        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub

    Private Sub RB_Recharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Recharge.KeyDown

        If RB_Recharge.Checked = False Then

            If e.KeyCode = Keys.Enter Then
                cb_categPdt.Select()
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                txtDesig.Select()
            End If
        End If

    End Sub

    Private Sub RB_Portable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Portable.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_categPdt.Select()
        End If
    End Sub

    Private Sub RB_Puce_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Puce.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_categPdt.Select()
        End If
    End Sub

    Private Sub RB_Modem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Modem.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_categPdt.Select()
        End If
    End Sub

    Private Sub txtPourcAch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPourcAch.TextChanged

    End Sub

    Private Sub bn_Ajouter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bn_Ajouter.KeyDown
        If cb_categPdt.Visible = False Then
            If e.KeyCode = Keys.Enter Then
                txtDesig.Select()
            End If
        Else

            If e.KeyCode = Keys.Enter Then
                cb_categPdt.Select()
            End If

        End If



    End Sub

    Private Sub RB_Ajouter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Ajouter.KeyDown

    End Sub

   
End Class