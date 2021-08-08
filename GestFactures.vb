Imports System.Data.SqlClient
Public Class GestFactures

    Private Sub GestFactures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        alimenterDG_Factures()
        DataGridView2.Visible = False
        DataGridView3.Visible = False

        visDC.HeaderText = "Visualiser"
        visDC.Text = "V"
        visDC.UseColumnTextForButtonValue = True
        visDC.Width = 80
        DataGridView3.Columns.Add(visDC)

        editF.HeaderText = "Modifier"
        editF.Text = "M"
        editF.UseColumnTextForButtonValue = True
        editF.Width = 80
        DataGridView1.Columns.Add(editF)


        supF.HeaderText = "Supprimer"
        supF.Text = "X"
        supF.UseColumnTextForButtonValue = True
        supF.Width = 80
        DataGridView1.Columns.Add(supF)




        'editCmd.HeaderText = "Modifier"
        'editCmd.Text = "M"
        'editCmd.UseColumnTextForButtonValue = True
        'editCmd.Width = 80
        'DataGridView1.Columns.Add(editCmd)


    End Sub



    Public Sub viderDG1()

        DataGridView1.Rows.Clear()


    End Sub

    Public Sub viderDG2()

        DataGridView2.Rows.Clear()


    End Sub

    Public Sub viderDG3()

        DataGridView3.Rows.Clear()


    End Sub

    Sub alimenter_cb_com()

        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT numCmd FROM Commande where codeRevend =(select codeRevend from Revendeur where nomRevend = '" & cb_Revendeur.Text & "') and numFact = 'null'", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            cbNumCmd.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()



    End Sub

    Sub alimenterDG_Factures()


        cn.Open()

        cmd = New SqlCommand("select F.numFact,F.dateFact,F.numCmd,R.nomRevend,F.montantHT,F.tauxTVA,F.montantTTC FROM Facture F , Revendeur R where F.codeRevend = R.codeRevend", cn)
        dr = cmd.ExecuteReader()




        While dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6)}

            DataGridView1.Rows.Add(x)

        End While

        dr.Close()
        cn.Close()




    End Sub
    Sub viderCbRev()

        cb_Revendeur.Items.Clear()
        cb_Revendeur.Text = ""

    End Sub

   

    Private Sub RB_Ajouter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.CheckedChanged


        viderDG1()
        alimenterDG_Factures()

        lblModif.Visible = False
        lblsupf.Visible = False

        pn_CreatFact.Visible = True
        pn_RecherFact.Visible = False


        viderCbRev()
        alimenterCB_Revendeurs()





    End Sub


    Sub viderF()



        cb_Revendeur.Items.Clear()
        cb_Revendeur.Text = ""

        cbNumCmd.Items.Clear()
        cbNumCmd.Text = ""




    End Sub

    Public Sub alimenterDG_Commandes()

        cn.Open()

        cmd = New SqlCommand("select C.numCmd,C.dateCmd,C.numFact,R.nomRevend FROM Commande C , Revendeur R where C.codeRevend = R.codeRevend", cn)
        dr = cmd.ExecuteReader()




        While dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}

            DataGridView1.Rows.Add(x)
            DataGridView1.Show()
        End While

        dr.Close()
        cn.Close()



    End Sub


    Sub alimenterCB_Revendeurs()

        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT nomRevend FROM Revendeur", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            cb_Revendeur.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub


    Sub alimenterCB_Commandes()

        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT numCmd FROM Commande", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_NumCmd.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub

    Private Sub BT_Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Valider.Click


        If txtNumFact.Text = "" Or cbNumCmd.Text = "" Or cb_Revendeur.Text = "" Then
            MsgBox("Vous devez saisir tous  les champs afin d'ajouter un  produit a cette commande", MsgBoxStyle.Critical, "Remplissage des champs")

        Else


            Dim d As Date
            d = Date.Today

            cn.Open()
            cmd = New SqlCommand("insert into Facture(numFact,numCmd,codeRevend,dateFact,montantHT,tauxTVA) values('" & txtNumFact.Text & "','" & cbNumCmd.Text & "',(select codeRevend from Revendeur where nomRevend = '" & cb_Revendeur.Text & "'),'" & d & "',0,20)", cn)
            i = cmd.ExecuteNonQuery()
            cn.Close()


            If (i > 0) Then



                cn.Open()

                cmd = New SqlCommand("update Facture set montantHT = (select SUM(totalPdt) from DetailsCommande where numCmd = '" & cbNumCmd.Text & "') where numCmd = '" & cbNumCmd.Text & "'", cn)
                j = cmd.ExecuteNonQuery()

                cmd = New SqlCommand("update Facture set montantTTC = montantHT * (1+(tauxTVA/100))", cn)
                k = cmd.ExecuteNonQuery()


                'cmd = New SqlCommand("select pourcentRevend from Revendeur where nomRevend = '" & Cb_Reche_Revendeur.Text & "'", cn)
                'dr = cmd.ExecuteReader
                'dr.Read()

                'dr.Close()

                cmd = New SqlCommand("update Facture  set montantTTC = montantTTC - (montantTTC * (20 /100))  where codeRevend = (select R.codeRevend from Revendeur  R where R.nomRevend = '" & Cb_Reche_Revendeur.Text & "')", cn)
                l = cmd.ExecuteNonQuery()

                If j > 0 And k > 0 And l > 0 Then


                    cmd = New SqlCommand("update Commande set numFact = '" & txtNumFact.Text & "' where numCmd = '" & cbNumCmd.Text & "'", cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()

                    viderF()
                    lblFactc.Visible = True
                    viderDG1()
                    alimenterDG_Factures()



                    DataGridView1.Visible = True
                    DataGridView2.Visible = False
                    DataGridView3.Visible = False

                    viderDG2()
                    viderDG3()

                Else

                    lblFactE.Visible = True


                End If

            Else

                cn.Open()
                cmd = New SqlCommand("delete from facture where numFact = '" & txtNumFact.Text & "'", cn)
                cmd.ExecuteNonQuery()
                lblFactE.Visible = True
                cn.Close()

            End If



        End If

        txtNumFact.Clear()

    End Sub

    Sub alimenterDG3_rev()

        cn.Open()
        cmd = New SqlCommand("select C.numCmd, C.dateCmd, C.numFact from Commande  C  where C.codeRevend =  (select codeRevend from Revendeur  where '" & cb_Revendeur.Text & "' = nomRevend) and C.numfact = 'null';", cn)
        dr = cmd.ExecuteReader
        DataGridView3.Columns(3).Visible = False

        While dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2)}

            DataGridView3.Rows.Add(x)
            'DataGridView1.Show()


        End While
        dr.Close()
        cn.Close()



    End Sub

    Private Sub cb_Revendeur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Revendeur.SelectedIndexChanged
        If cb_Revendeur.SelectedItem <> Nothing Then

            viderDG3()


            DataGridView1.Visible = False
            DataGridView3.Visible = True
            DataGridView2.Visible = True

            alimenterDG3_rev()
            cbNumCmd.Items.Clear()
            cbNumCmd.Text = ""
            alimenter_cb_com()
        End If


    End Sub


    Public Sub alimenterDG_DetCommandes()

        cn.Open()

        cmd = New SqlCommand("select desigPdt,qteCmd,prixU,totalPdt from DetailsCommande where numCmd ='" & DataGridView3.Rows(DataGridView3.CurrentCell.RowIndex).Cells(0).Value & "' ", cn)
        dr = cmd.ExecuteReader()




        While dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}

            DataGridView2.Rows.Add(x)
            DataGridView2.Show()
        End While

        dr.Close()
        cn.Close()



    End Sub

    Sub alimenterDG2_cb()

        

    End Sub
    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
  
        If e.ColumnIndex = 4 Then

            viderDG2()
            alimenterDG_DetCommandes()

           
        End If







    End Sub

   
    Private Sub txtNumFact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumFact.TextChanged

        cn.Open()

        cmd = New SqlCommand("select numFact from Facture", cn)
        dr = cmd.ExecuteReader()
        While dr.Read

            If (dr(0) = txtNumFact.Text) Then
                MsgBox("Cette facture existe déjà", MsgBoxStyle.Exclamation, "Consultation")
                Exit While
            End If
        End While

        dr.Close()
        cn.Close()

    End Sub

   
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        Dim ligne As Integer
        'Dim colonne As Integer
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        ' --- Récupération des lignes et colonnes
        ligne = Me.DataGridView1.CurrentRow.Index
        'colonne = Me.DataGridView1.CurrentCell.ColumnIndex()


        Dim nf As String
        Dim d As Date
        Dim nc As String
        Dim r As String
        Dim mht As Double
        Dim tva As Double

        If e.ColumnIndex = 7 Then




            nf = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            d = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            nc = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
            r = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
            mht = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
            tva = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value

            cn.Open()
            cmd = New SqlCommand("Update Facture set  dateFact = '" & d & "',numCmd = '" & nc & "' where numFact = '" & nf & "'", cn)
            i = cmd.ExecuteNonQuery

            If (i > 0) Then

                cmd = New SqlCommand("Update Commande  set  numFact = 'null' where numFact = '" & nf & "'", cn)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("Update Commande  set  numFact = '" & nf & "' where numCmd = '" & nc & "'", cn)
                cmd.ExecuteNonQuery()




            


            cmd = New SqlCommand("select SUM(totalPdt) from DetailsCommande where numCmd = '" & nc & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()

            cmd = New SqlCommand("Update Facture set  montantHT = " & dr(0) & "", cn)
            dr.Close()
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("update Facture set montantTTC = montantHT * (1+(tauxTVA/100)) where numFact = '" & nf & "' ", cn)
            cmd.ExecuteNonQuery()

                cmd = New SqlCommand("select pourcentRevend from Revendeur where nomRevend = '" & r & "' )", cn)
                dr = cmd.ExecuteReader
                dr.Read()

                cmd = New SqlCommand("update Facture set montantTTC = montantTTC - (montantTTC * (" & dr(0) & " /100))  where codeRevend = select codeRevend from Revendeur  where nomRevend = '" & r & "'", cn)
                l = cmd.ExecuteNonQuery()


                lblModif.Visible = True

            End If


        End If


        If e.ColumnIndex = 8 Then

            nf = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

            cn.Open()

            cmd = New SqlCommand("DELETE FROM Facture WHERE numFact = '" & nf & "'", cn)
            i = cmd.ExecuteNonQuery


            cmd = New SqlCommand("UPDATE Commande SET numFact = 'null' WHERE numFact = '" & nf & "'", cn)
            cmd.ExecuteNonQuery()




            If i > 0 Then

                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                cn.Close()
                lblsupf.Visible = True

                DataGridView1.Rows.Clear()
                alimenterDG_Factures()

                viderDG2()
                viderDG3()

            End If



        End If
    End Sub

    Private Sub BtVlider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'viderDG1()
        'viderDG2()
        'viderDG3()




    End Sub

    Private Sub RB_Consulter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Consulter.CheckedChanged
        If RB_Consulter.Checked = True Then


            viderDG1()
            viderDG2()
            viderDG3()

            lblModif.Visible = False
            lblsupf.Visible = False
            lblFactc.Visible = False
            lblFactE.Visible = False

            pn_RecherFact.Visible = True
            pn_CreatFact.Visible = False


        End If


    End Sub


    Sub alimenterCb_Reche_Revend()

        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT nomRevend FROM Revendeur", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_Revendeur.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub

    Private Sub CK_Revend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If CK_Revend.Checked = True Then


        '    Cb_Reche_Rev.Items.Clear()
        '    Cb_Reche_Rev.Text = ""

        '    Cb_Reche_NumFact.Visible = False
        '    Ck_NumFact.Checked = False



        '    Cb_Reche_Rev.Visible = True
        '    alimenterCb_Reche_Revend()

        'Else

        '    Cb_Reche_Rev.Visible = False


        'End If


    End Sub
    Sub alimenterCb_Reche_Date()

        cn.Open()

        cmd = New SqlCommand("select distinct dateFact from Facture", cn)

        dr = cmd.ExecuteReader

        Do While dr.Read
            'Cb_Reche_DateF.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()

    End Sub

    Private Sub Ck_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If Ck_Date.Checked = True Then

        '    Cb_Reche_DateF.Visible = True

        '    Cb_Reche_DateF.Items.Clear()
        '    Cb_Reche_DateF.Text = ""
        '    alimenterCb_Reche_Date()



        '    ck_numCmd.Checked = False
        '    cb_Rech_numCmd.Visible = False

        '    Ck_NumFact.Checked = False
        '    Cb_Reche_NumFact.Visible = False


        'ElseIf ck_numCmd.Checked = True Then

        '    viderDG1()
        '    viderDG2()
        '    Ck_Date.Checked = False
        '    Cb_Reche_DateF.Visible = False

        '    ck_revend.Checked = False
        '    cb_RechRev.Visible = False

        '    C.Items.Clear()
        '    cb_Rech_numCmd.Text = ""
        '    cb_Rech_numCmd.Visible = True
        '    alimenterCB_Commandes()

        'Else

        '    cb_Rech_numCmd.Visible = False

        'End If
        'Cb_Reche_DateF.Visible = False

        'End If

    End Sub

  
    Private Sub Ck_NumCmdF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Ck_NumCmd.Checked = True Then

            viderDG1()
            viderDG2()
            viderDG3()

            'Ck_Date.Checked = False
            'Cb_Reche_Date.Visible = False

            'CK_Revend.Checked = False
            'Cb_Reche_Revend.Visible = False

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""
            Cb_Reche_NumCmd.Visible = True
            alimenterCB_Commandes()

        Else

            Cb_Reche_NumCmd.Visible = False

        End If

    End Sub

    Private Sub bt_confirmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_confirmer.Click

        viderDG1()
        viderDG2()
        viderDG3()

        If Cb_Reche_Revendeur.SelectedItem <> Nothing And Cb_Reche_Date.SelectedItem = Nothing And Cb_Reche_numFact.SelectedItem = Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing Then


            cn.Open()
            cmd = New SqlCommand("select distinct F.numFact, F.dateFact, F.numCmd,F.codeRevend, F.montantHT, F.tauxTVA, F.montantTTC from Facture F, Revendeur R where F.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & Cb_Reche_Revendeur.Text & "') ", cn)

           
            dr = cmd.ExecuteReader
            DataGridView1.Columns(3).Visible = False

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6)}


                DataGridView1.Rows.Add(x)

            End While
            dr.Close()
            cn.Close()

        ElseIf Cb_Reche_Date.SelectedItem = Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing And Cb_Reche_Revendeur.SelectedItem = Nothing And Cb_Reche_numFact.SelectedItem <> Nothing Then


            cn.Open()
            cmd = New SqlCommand("select F.numFact ,F.dateFact, F.numCmd ,R.nomRevend,F.montantHT,F.tauxTVA,F.montantTTC  from Facture F , Revendeur R where F.numFact = '" & Cb_Reche_numFact.Text & "' and R.codeRevend = F.codeRevend", cn)

            dr = cmd.ExecuteReader

            DataGridView1.Columns(3).Visible = True

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6)}


                DataGridView1.Rows.Add(x)

            End While
            dr.Close()
            cn.Close()



        ElseIf Cb_Reche_Date.SelectedItem = Nothing And Cb_Reche_NumCmd.SelectedItem <> Nothing And Cb_Reche_Revendeur.SelectedItem = Nothing And Cb_Reche_numFact.SelectedItem = Nothing Then


            cn.Open()
            cmd = New SqlCommand("select F.numFact ,F.dateFact, F.numCmd ,R.nomRevend,F.montantHT,F.tauxTVA,F.montantTTC  from Facture F , Revendeur R where F.numCmd = '" & Cb_Reche_NumCmd.Text & "' and R.codeRevend = F.codeRevend", cn)

            dr = cmd.ExecuteReader

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6)}


                DataGridView1.Columns(3).Visible = True
                DataGridView1.Rows.Add(x)

            End While
            dr.Close()
            cn.Close()

        ElseIf Cb_Reche_Date.SelectedItem <> Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing And Cb_Reche_numFact.SelectedItem = Nothing And Cb_Reche_Revendeur.SelectedItem = Nothing Then

            cn.Open()
            cmd = New SqlCommand("select distinct F.numFact, F.dateFact,F.numCmd,R.nomRevend,F.montantHT , F.tauxTVA, F.montantTTC from Facture F,Revendeur R  where F.dateFact = '" & Cb_Reche_Date.Text & "' and R.codeRevend =F.codeRevend", cn)
            dr = cmd.ExecuteReader

            DataGridView1.Columns(3).Visible = True


            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6)}

                DataGridView1.Rows.Add(x)


            End While
            dr.Close()
            cn.Close()


        ElseIf Cb_Reche_Date.SelectedItem <> Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing And Cb_Reche_numFact.SelectedItem = Nothing And Cb_Reche_Revendeur.SelectedItem <> Nothing Then

            cn.Open()
            cmd = New SqlCommand("select distinct F.numFact, F.dateFact,F.numCmd,F.codeRevend,F.montantHT , F.tauxTVA, F.montantTTC from Facture F,Revendeur R  where F.codeRevend = (select codeRevend from Revendeur  where nomRevend = '" & Cb_Reche_Revendeur.Text & "' ) and  F.dateFact = '" & Cb_Reche_Date.Text & "' ", cn)
            dr = cmd.ExecuteReader

            DataGridView1.Columns(3).Visible = False

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6)}

                DataGridView1.Rows.Add(x)




            End While
            dr.Close()
            cn.Close()


        End If

    End Sub


    Private Sub CK_Revend_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_Revend.CheckedChanged

        If CK_Revend.Checked = True Then

            viderDG1()
            viderDG2()
            viderDG3()
            Cb_Reche_numFact.Items.Clear()
            Cb_Reche_numFact.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""

            Cb_Reche_Revendeur.Items.Clear()
            Cb_Reche_Revendeur.Text = ""

            Cb_Reche_NumCmd.Visible = False
            Ck_NumCmd.Checked = False

            Cb_Reche_numFact.Visible = False
            Ck_NumFact.Checked = False


            Cb_Reche_Revendeur.Visible = True

            alimenterCb_Reche_Revend()

        Else

            Cb_Reche_Revendeur.Visible = False


        End If


    End Sub

    Sub alimenterCB_Rech_Fact()


        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT numFact FROM Facture", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_numFact.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()





    End Sub


    Private Sub Ck_NumFact_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_NumFact.CheckedChanged

        If Ck_NumFact.Checked = True Then

            viderDG1()
            viderDG2()
            viderDG3()

            Ck_Date.Checked = False
            Cb_Reche_Date.Visible = False

            CK_Revend.Checked = False
            Cb_Reche_Revendeur.Visible = False

            Ck_NumCmd.Checked = False
            Cb_Reche_NumCmd.Visible = False

            Cb_Reche_numFact.Items.Clear()
            Cb_Reche_numFact.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""

            Cb_Reche_Date.Items.Clear()
            Cb_Reche_Date.Text = ""

            Cb_Reche_Revendeur.Items.Clear()
            Cb_Reche_Revendeur.Text = ""

            Cb_Reche_numFact.Visible = True

            alimenterCB_Rech_Fact()

        Else

            Cb_Reche_NumCmd.Visible = False

        End If
    End Sub

    Sub alimenterCB_Rech_Commandes()


        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT numCmd FROM Facture", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_NumCmd.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()




    End Sub

    Private Sub Ck_NumCmd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_NumCmd.CheckedChanged
        If Ck_NumCmd.Checked = True Then

            viderDG1()
            viderDG2()
            viderDG3()

            Ck_Date.Checked = False
            Cb_Reche_Date.Visible = False

            CK_Revend.Checked = False
            Cb_Reche_Revendeur.Visible = False

            Ck_NumFact.Checked = False
            Cb_Reche_numFact.Visible = False

            Cb_Reche_numFact.Items.Clear()
            Cb_Reche_numFact.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""

            Cb_Reche_Date.Items.Clear()
            Cb_Reche_Date.Text = ""

            Cb_Reche_Revendeur.Items.Clear()
            Cb_Reche_Revendeur.Text = ""



            Cb_Reche_NumCmd.Visible = True

            alimenterCB_Rech_Commandes()

        Else

            Cb_Reche_NumCmd.Visible = False

        End If

    End Sub

    Sub alimenterCb_Reche_DateF()

        cn.Open()
        ' cb_RechPdt.Text = ""

        cmd = New SqlCommand("SELECT distinct dateFact FROM Facture", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_Date.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()




    End Sub

    Private Sub Ck_Date_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_Date.CheckedChanged

        If Ck_Date.Checked = True Then

            viderDG1()
            viderDG2()
            viderDG3()


            Cb_Reche_NumCmd.Visible = False
            Ck_NumCmd.Checked = False


            Ck_NumFact.Checked = False
            Cb_Reche_numFact.Visible = False

            Cb_Reche_numFact.Items.Clear()
            Cb_Reche_numFact.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""

            Cb_Reche_Date.Items.Clear()
            Cb_Reche_Date.Text = ""


            Cb_Reche_Date.Visible = True

            alimenterCb_Reche_DateF()


        Else
            Cb_Reche_Date.Visible = False

        End If


    End Sub


    'Sub vscroll_change()

    '    Me.Top = VScrollBar1.Value

    'End Sub


    'Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll

    '    vscroll_change()
    'End Sub
End Class