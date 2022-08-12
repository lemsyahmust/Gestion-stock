Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO.Stream
Imports System.IO.FileMode
Imports Microsoft.Office.Interop

Public Class GestCommandes



    'Function N_L() As Int32
    '    'retourne l dernier numero de bon de livaison plus un
    '    Dim m As Int32
    '    Dim cmd As SqlCommand = New SqlCommand("select numCmd from Commande", cn)
    '    Dim dr As SqlDataReader
    '    cn.Close()
    '    cn.Open()
    '    dr = cmd.ExecuteReader
    '    While dr.Read()
    '        m = dr.GetValue(0)
    '    End While
    '    dr.Close()
    '    cn.Close()
    '    Return m
    'End Function


    Sub imprimerCmd()


        numC = Me.DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select dateCmd from Commande where numCmd = " & numC & "", cn)
        d1 = cmd.ExecuteScalar

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichCommande.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        Try
            '            ici on compte le nombre de lignes et de colonnes du datatable
            Dim nbrLigne As Integer = Me.DataGridView2.Rows.Count - 1
            Dim nbrColon As Integer = Me.DataGridView2.Columns.Count - 1
            Dim x, y As Integer

            cmd = New SqlCommand("select nomRevend from Revendeur where codeRevend = (select codeRevend from Commande where numCmd = " & numC & ")", cn)
            nomR = cmd.ExecuteScalar

            xlsheet.Cells(5, 3) = nomR
            xlsheet.Cells(5, 2) = d1

            For x = 1 To nbrColon - 3
                ' Pour chaque colonne et chaque ligne on transfert les données 
                ' On commence par la ligne 8 et la colonne 2 pour laisser un espace      
                For y = 0 To nbrLigne
                    xlsheet.Cells(y + 8, x + 1) = Me.DataGridView2.Item(x, y).Value

                    cn.Close()
                    cn.Open()
                    If x = 1 Then

                        cmd = New SqlCommand("select prixPdt from Produit where codePdt = (select codePdt from Produit where desigPdt = '" & Me.DataGridView2.Item(x, y).Value & "')", cn)
                        pu = cmd.ExecuteScalar

                        cmd = New SqlCommand("select totalPdt from ContenirPdtCmd where numCmd = " & numC & " and  codePdt = (select codePdt from Produit where desigPdt = '" & Me.DataGridView2.Item(x, y).Value & "')", cn)
                        mont = cmd.ExecuteScalar

                        xlsheet.Cells(y + 8, x + 3) = pu
                        xlsheet.Cells(y + 8, x + 4) = mont

                    End If



                Next
            Next

            cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
            montG = cmd.ExecuteScalar

            montGT = montG.ToString + " dhs"
            xlsheet.Cells(8, 7) = montGT



            Dim chemin As String
            Dim SaveFileDialog1 As New SaveFileDialog()
            Dim result As DialogResult = SaveFileDialog1.ShowDialog()

            If (result = Windows.Forms.DialogResult.OK) Then

                chemin = SaveFileDialog1.FileName
                xlsheet.SaveAs(chemin)

            End If



            '' ici on affiche les résultat dans excel
            xlsheet.Application.Visible = True
            xlsheet.PrintPreview()




            '' on peut sauvegarder notre document sur le disque
            xlsheet.SaveAs("C:\FichCommande.xlsx")

            xlApp.DisplayAlerts = False
            ' on quitte l'application et on détruit les objets
            xlApp.Quit()
            xlsheet = Nothing
            xlBook = Nothing
            xlApp = Nothing

        Catch ex As Exception
            xlApp.DisplayAlerts = False
            xlApp.Quit()
            xlsheet = Nothing
            xlBook = Nothing
            xlApp = Nothing
        End Try

    End Sub


    Sub imprimerCmdPaiement1()

        '   numC = Me.DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select dateCmd from Commande where numCmd = " & numC & "", cn)
        d1 = cmd.ExecuteScalar

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichCommandePaiement1.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        Try
            '            ici on compte le nombre de lignes et de colonnes du datatable
            Dim nbrLigne As Integer = Me.DataGridView2.Rows.Count - 1
            Dim nbrColon As Integer = Me.DataGridView2.Columns.Count - 1
            Dim x, y As Integer

            cmd = New SqlCommand("select nomRevend from Revendeur where codeRevend = (select codeRevend from Commande where numCmd = " & numC & ")", cn)
            nomR = cmd.ExecuteScalar

            xlsheet.Cells(5, 2) = nomR
            xlsheet.Cells(5, 1) = d1

            For x = 1 To nbrColon - 3
                ' Pour chaque colonne et chaque ligne on transfert les données 
                ' On commence par la ligne 8 et la colonne 2 pour laisser un espace      
                For y = 0 To nbrLigne
                    xlsheet.Cells(y + 8, x) = Me.DataGridView2.Item(x, y).Value

                    cn.Close()
                    cn.Open()
                    If x = 1 Then
                        cmd = New SqlCommand("select prixPdt from Produit where codePdt = (select codePdt from Produit where desigPdt = '" & Me.DataGridView2.Item(x, y).Value & "')", cn)
                        pu = cmd.ExecuteScalar

                        cmd = New SqlCommand("select totalPdt from ContenirPdtCmd where numCmd = " & numC & " and  codePdt = (select codePdt from Produit where desigPdt = '" & Me.DataGridView2.Item(x, y).Value & "')", cn)
                        mont = cmd.ExecuteScalar

                        xlsheet.Cells(y + 8, x + 2) = pu
                        xlsheet.Cells(y + 8, x + 3) = mont

                    End If

                Next
            Next

            cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
            montG = cmd.ExecuteScalar

            cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
            reste = cmd.ExecuteScalar


            monTT = monTT + montG


            'If Val(txtReste.Text) < 0 Then

            '    If reste > 0 Then
            '        monTT = monTT + reste
            '    End If

            '    'Else
            '    '    If reste > reste + Val(txtReste.Text) Then
            '    '        tot = tot + reste
            '    '    End If
            'End If


            montGT = monTT.ToString + " dhs"

            If reste > 0 Then

                resteS = "-" + reste.ToString + " dhs"
                xlsheet.Cells(11, 6) = resteS
            Else
                '  resteS = Val(txtReste.Text)
                resteS = " 0 dhs"
                xlsheet.Cells(11, 6) = resteS
            End If

            xlsheet.Cells(8, 6) = montGT
            xlsheet.Cells(8, 7) = Val(txtDonner.Text)

            Dim chemin As String
            Dim SaveFileDialog1 As New SaveFileDialog()
            Dim result As DialogResult = SaveFileDialog1.ShowDialog()

            If (result = Windows.Forms.DialogResult.OK) Then

                chemin = SaveFileDialog1.FileName
                xlsheet.SaveAs(chemin)

            End If




            '' ici on affiche les résultat dans excel
            xlsheet.Application.Visible = True
            xlsheet.PrintPreview()

            '' on peut sauvegarder notre document sur le disque
            ' xlsheet.SaveAs("C:\FichCommandePaiement1.xlsx")




            xlApp.DisplayAlerts = False
            ' on quitte l'application et on détruit les objets
            xlApp.Quit()
            xlsheet = Nothing
            xlBook = Nothing
            xlApp = Nothing

        Catch ex As Exception
            xlApp.DisplayAlerts = False
            xlApp.Quit()
            xlsheet = Nothing
            xlBook = Nothing
            xlApp = Nothing
        End Try

    End Sub



    Sub imprimerCmdPaiement2()

        montG = 0
        mont = 0
        montGT = 0
        numC = Me.DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select dateCmd from Commande where numCmd = " & numC & "", cn)
        d1 = cmd.ExecuteScalar

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichCommandePaiement2.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        Try
            '            ici on compte le nombre de lignes et de colonnes du datatable
            Dim nbrLigne As Integer = Me.DataGridView2.Rows.Count - 1
            Dim nbrColon As Integer = Me.DataGridView2.Columns.Count - 1
            Dim x, y As Integer

            cmd = New SqlCommand("select nomRevend from Revendeur where codeRevend = (select codeRevend from Commande where numCmd = " & numC & ")", cn)
            nomR = cmd.ExecuteScalar

            xlsheet.Cells(5, 2) = nomR
            xlsheet.Cells(5, 1) = d1

            For x = 1 To nbrColon - 3
                ' Pour chaque colonne et chaque ligne on transfert les données 
                ' On commence par la ligne 8 et la colonne 2 pour laisser un espace      
                For y = 0 To nbrLigne
                    xlsheet.Cells(y + 8, x) = Me.DataGridView2.Item(x, y).Value

                    cn.Close()
                    cn.Open()
                    If x = 1 Then

                        cmd = New SqlCommand("select prixPdt from Produit where codePdt = (select codePdt from Produit where desigPdt = '" & Me.DataGridView2.Item(x, y).Value & "')", cn)
                        pu = cmd.ExecuteScalar

                        cmd = New SqlCommand("select totalPdt from ContenirPdtCmd where numCmd = " & numC & " and  codePdt = (select codePdt from Produit where desigPdt = '" & Me.DataGridView2.Item(x, y).Value & "')", cn)
                        mont = cmd.ExecuteScalar

                        xlsheet.Cells(y + 8, x + 2) = pu
                        xlsheet.Cells(y + 8, x + 3) = mont

                    End If

                Next
            Next

            cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
            montG = cmd.ExecuteScalar

            cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
            reste = cmd.ExecuteScalar


            monTT = monTT + montG


            'If Val(txtReste.Text) < 0 Then

            '    If reste > 0 Then
            '        monTT = monTT + reste
            '    End If

            '    'Else
            '    '    If reste > reste + Val(txtReste.Text) Then
            '    '        tot = tot + reste
            '    '    End If
            'End If


            montGT = monTT.ToString + " dhs"

            If reste > 0 Then


                resteS = "-" + reste.ToString + " dhs"
                xlsheet.Cells(11, 6) = resteS
            Else
                '  resteS = Val(txtReste.Text)
                resteS = " 0 dhs"
                xlsheet.Cells(11, 6) = resteS
            End If

            xlsheet.Cells(8, 6) = montGT



            '            xlsheet.Cells(8, 7) = Val(txtDonner.Text)

            Dim chemin As String
            Dim SaveFileDialog1 As New SaveFileDialog()
            Dim result As DialogResult = SaveFileDialog1.ShowDialog()

            If (result = Windows.Forms.DialogResult.OK) Then

                chemin = SaveFileDialog1.FileName
                xlsheet.SaveAs(chemin)

            End If




            '' ici on affiche les résultat dans excel
            xlsheet.Application.Visible = True
            xlsheet.PrintPreview()

            '' on peut sauvegarder notre document sur le disque
            '     xlsheet.SaveAs("C:\FichCommandePaiement2.xlsx")




            xlApp.DisplayAlerts = False
            ' on quitte l'application et on détruit les objets
            xlApp.Quit()
            xlsheet = Nothing
            xlBook = Nothing
            xlApp = Nothing

        Catch ex As Exception
            xlApp.DisplayAlerts = False
            xlApp.Quit()
            xlsheet = Nothing
            xlBook = Nothing
            xlApp = Nothing
        End Try

    End Sub

    Private Sub GestCommandes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub




    Public Sub GestionCommandes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AutoScroll = True


        alimenterDG_Commandes()
        'RB_Ajouter.Checked = False
        'RB_Consulter.Checked = False

        editCmd.HeaderText = "Modifier"
        editCmd.Text = "M"
        editCmd.UseColumnTextForButtonValue = True
        editCmd.Width = 69
        DataGridView1.Columns.Add(editCmd)


        supCmd.HeaderText = "Supprimer"
        supCmd.Text = "X"
        supCmd.UseColumnTextForButtonValue = True
        supCmd.Width = 69
        DataGridView1.Columns.Add(supCmd)


        rempCmd.HeaderText = "Remplir"
        rempCmd.Text = "R"
        rempCmd.UseColumnTextForButtonValue = True
        rempCmd.Width = 69
        DataGridView1.Columns.Add(rempCmd)


        PayC.HeaderText = "Payer"
        PayC.Text = "P"
        PayC.UseColumnTextForButtonValue = True
        PayC.Width = 69
        DataGridView1.Columns.Add(PayC)

        impCmd.HeaderText = "Imprimer"
        impCmd.Text = "I"
        impCmd.UseColumnTextForButtonValue = True
        impCmd.Width = 69
        DataGridView1.Columns.Add(impCmd)


        editDC.HeaderText = "Modifier"
        editDC.Text = "M"
        editDC.UseColumnTextForButtonValue = True
        editDC.Width = 80
        DataGridView2.Columns.Add(editDC)


        BT_fermerDG2.Visible = False
        DataGridView2.Visible = False

        supDC.HeaderText = "Supprimer"
        supDC.Text = "X"
        supDC.UseColumnTextForButtonValue = True
        supDC.Width = 80
        DataGridView2.Columns.Add(supDC)

        DataGridView1.Columns(6).Visible = True
        DataGridView1.Columns(7).Visible = True
        DataGridView1.Columns(8).Visible = True




    End Sub

    Public Sub alimenterDG_Commandes()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select C.numCmd,C.dateCmd,R.nomRevend,C.montantHT FROM Commande C , Revendeur R where C.codeRevend = R.codeRevend", cn)
        dr = cmd.ExecuteReader()

        While dr.Read()

            Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}

            DataGridView1.Rows.Add(x)
            DataGridView1.Show()

        End While

        dr.Close()
        cn.Close()

    End Sub

    Public Sub alimenterDG_DetCommandes()

        cn.Close()
        cn.Open()

        numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

        cmd = New SqlCommand("select Cp.numCmd,P.desigPdt,Cp.qteCmd,P.prixPdt,P.qteStock from ContenirPdtCmd Cp, Produit P  where Cp.codePdt = P.codePdt and numCmd = " & numC & "", cn)
        dr = cmd.ExecuteReader()

        While dr.Read()

            cmd = New SqlCommand("select Cp.totalPdt from ContenirPdtCmd Cp, Produit P where Cp.numCmd = " & numC & " and Cp.codePdt = (select codePdt from Produit where desigPdt = '" & dr(1) & "')", cn)
            mont = cmd.ExecuteScalar


            qte = dr(2)
            prix = mont / qte

            Dim x As String() = {dr(0), dr(1), qte, prix, dr(4)}

            DataGridView2.Rows.Add(x)
            DataGridView2.Show()
        End While

        dr.Close()
        cn.Close()

    End Sub

    Sub alimenterDG2_cb()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select Cp.numCmd,P.desigPdt,Cp.qteCmd,P.prixPdt,P.qteStock from ContenirPdtCmd Cp, Produit P  where Cp.numCmd = " & Cb_Reche_NumCmd.Text & " and Cp.codePdt = (select codePdt from Produit where desigPdt = '" & desig & "')", cn)
        dr = cmd.ExecuteReader()
        DataGridView2.Columns(0).Visible = False
    
        While dr.Read()

            cmd = New SqlCommand("select totalPdt from ContenirPdtCmd Cp, Produit P where Cp.numCmd = " & Cb_Reche_NumCmd.Text & " and Cp.codePdt =s(select codePdt from Produit where desigPdt ='" & dr(1) & "')", cn)
            mont = cmd.ExecuteScalar

            qte = dr(2)
            prix = mont / qte

            Dim x As String() = {dr(0), dr(1), qte, prix, dr(4)}
            DataGridView2.Rows.Add(x)

        End While

        dr.Close()
        cn.Close()

        BT_fermerDG2.Visible = True
    End Sub


    Public Sub viderDG1()

        DataGridView1.Rows.Clear()

    End Sub

    Public Sub viderDG2()

        DataGridView2.Rows.Clear()

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        DataGridView2.Columns(0).Visible = False
        '  DataGridView2.Columns(3).Visible = True


        Dim ligne As Integer
        ' --- Récupération des lignes et colonnes
        ligne = Me.DataGridView1.CurrentRow.Index

       



        If DataGridView1.CurrentCell.Selected = True Then

            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblPaie.Visible = False
            lblManque.Visible = False
            pn_CreatCmd.Visible = False
            BtFerC.Visible = False
            '    pn_RecherCmd.Visible = False
            '   BtFermerRech.Visible = False
            viderCmdC()
            viderCmdR()
            pn_RempCmd.Visible = False
            BT_fermerR.Visible = False
            PnPaiement.Visible = False
            BtFerP.Visible = False
            '    RB_Ajouter.Checked = False
            '     RB_Consulter.Checked = False


            numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

            viderDG2()
            alimenterDG_DetCommandes()
            DataGridView2.Visible = True
            BT_fermerDG2.Visible = True


            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select etatP from Commande where numCmd = " & numC & "", cn)
            etatP = cmd.ExecuteScalar()

            If etatP = "np" Then

                viderDG2()
                alimenterDG_DetCommandes()
                DataGridView2.Visible = True
                BT_fermerDG2.Visible = True
                DataGridView2.Columns(4).Visible = True
                DataGridView2.Columns(5).Visible = True

            Else

                DataGridView2.Columns(4).Visible = False
                DataGridView2.Columns(5).Visible = False


            End If
        End If

        If e.ColumnIndex = 5 Then

            


            BT_fermerDG2.Visible = True
            DataGridView2.Visible = True

            dateC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value


            pn_CreatCmd.Visible = False
            BtFerC.Visible = False
            ' pn_RecherCmd.Visible = False
            ' BtFermerRech.Visible = False
            viderCmdC()
            viderCmdR()
            pn_RempCmd.Visible = False
            BT_fermerR.Visible = False
            PnPaiement.Visible = False
            BtFerP.Visible = False
            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblPaie.Visible = False
            lblManque.Visible = False


            If MsgBox("Voulez-vous vraiment supprimer cette commande ?", vbYesNo) = vbYes Then


                numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value


                cn.Close()
                cn.Open()
                cmd = New SqlCommand("select etatP from Commande where numCmd = " & numC & "", cn)
                etatP = cmd.ExecuteScalar()

                If etatP = "np" Then




                    DataGridView2.Columns(4).Visible = True
                    DataGridView2.Columns(5).Visible = True

                    cmd = New SqlCommand("select CP.codePdt , CP.qteCmd, C.dateCmd from  ContenirPdtCmd CP ,Commande C WHERE Cp.numCmd = " & numC & "", cn)
                    dr = cmd.ExecuteReader





                    'cmd = New SqlCommand("select etatP from Commande where numCmd = '" & numC & "'", cn)
                    'etatP = cmd.ExecuteScalar

                    'If etatP = "np" Then

                    cmd = New SqlCommand("select Cp.codePdt,Cp.qteCmd,P.desigPdt from ContenirPdtCmd Cp,Produit P where Cp.numCmd = " & numC & " and P.codePdt = Cp.codePdt", cn)
                    dr1 = cmd.ExecuteReader()


                    ' desig = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(1).Value
                    ' qte = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(2).Value

                    Do While dr1.Read()

                        codePa = dr1(0)
                        qte = dr1(1)
                        desig = dr1(2)

                        cmd = New SqlCommand("update Produit set qteStock = qteStock + (select qteCmd from ContenirPdtCmd where codePdt = " & codePa & " and numCmd = " & numC & ") where codePdt = " & codePa & "", cn)
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand("update ArchiveStock set SF = SF + " & qte & "  where codePdt = " & codePa & " and MONTH(dateArch) =" & dateC.Month & " and DAY(dateArch) = " & dateC.Day & "", cn)
                        cmd.ExecuteNonQuery()

                    Loop
                    dr1.Close()



                    cmd1 = New SqlCommand("DELETE from ContenirPdtCmd WHERE numCmd = " & numC & "", cn)
                    cmd = New SqlCommand("DELETE FROM Commande WHERE numCmd = " & numC & "", cn)

                    j = cmd1.ExecuteNonQuery
                    i = cmd.ExecuteNonQuery

                    If (i > 0 And j >= 0) Then


                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                        lblSupp.Visible = True

                        lblAjout.Visible = False
                        lblModifDC.Visible = False
                        lblModifDCe.Visible = False
                        lblCmdc.Visible = False
                        lblCmdE.Visible = False
                        lblCreditDH.Visible = False
                        lblRetech.Visible = False
                        lblRetPdt.Visible = False
                        lblSuppe.Visible = False
                        lblPaie.Visible = False
                        lblManque.Visible = False
                        DataGridView1.Rows.Clear()
                        alimenterDG_Commandes()
                        viderDG2()
                        DataGridView2.Visible = False
                        BT_fermerDG2.Visible = False
                    Else
                        lblAjout.Visible = False
                        lblModifDC.Visible = False
                        lblModifDCe.Visible = False
                        lblCmdc.Visible = False
                        lblCmdE.Visible = False
                        lblCreditDH.Visible = False
                        lblRetech.Visible = False
                        lblRetPdt.Visible = False
                        lblSupp.Visible = False
                        lblPaie.Visible = False
                        lblManque.Visible = False
                        lblSuppe.Visible = True

                    End If


                Else

                    MsgBox("impossible de supprimer cette commande de l'archive : Déja payée.", MsgBoxStyle.OkCancel, MsgBoxStyle.Exclamation)
                    DataGridView2.Columns(4).Visible = False
                    DataGridView2.Columns(5).Visible = False

                End If
                cn.Close()
            End If
            'End If

        End If

        If e.ColumnIndex = 4 Then

            pn_CreatCmd.Visible = False
            BtFerC.Visible = False
            ' pn_RecherCmd.Visible = False
            ' BtFermerRech.Visible = False
            viderCmdC()
            viderCmdR()
            pn_RempCmd.Visible = False
            BT_fermerR.Visible = False
            PnPaiement.Visible = False
            BtFerP.Visible = False
            BT_fermerDG2.Visible = False
            DataGridView2.Visible = False

            dateC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblPaie.Visible = False
            lblManque.Visible = False


            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select etatP from Commande where numCmd = " & numC & "", cn)
            etatP = cmd.ExecuteScalar()

            If etatP = "np" Then

                viderCmdR()
                BT_fermerR.Visible = False

                pn_RempCmd.Visible = False
                PnPaiement.Visible = False
                BtFerP.Visible = False

                viderDG2()
                alimenterDG_DetCommandes()

                DataGridView2.Visible = True
                DataGridView2.Columns(4).Visible = True
                DataGridView2.Columns(5).Visible = True
                BT_fermerDG2.Visible = True

                cn.Close()
                cn.Open()
                cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
                mont = cmd.ExecuteScalar
                LblMp.Text = "Montant actuel : " & mont & " dhs"
                LblMp.Visible = True


            Else


                BT_fermerDG2.Visible = False
                DataGridView2.Visible = False


                MsgBox("Commande déja payée ! ", MsgBoxStyle.Exclamation)
                LblMp.Visible = False
                BT_fermerDG2.Visible = False
                DataGridView2.Visible = False
                DataGridView2.Columns(4).Visible = False
                DataGridView2.Columns(5).Visible = False
            End If




        End If

        If e.ColumnIndex = 6 Then

            pn_CreatCmd.Visible = False
            BtFerC.Visible = False
            ' pn_RecherCmd.Visible = False
            ' BtFermerRech.Visible = False
            viderCmdC()
            viderCmdR()
            pn_RempCmd.Visible = False
            BT_fermerR.Visible = False
            PnPaiement.Visible = False
            BtFerP.Visible = False
            BT_fermerDG2.Visible = False
            DataGridView2.Visible = False


            dateC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblPaie.Visible = False
            lblManque.Visible = False

            viderCmdR()

            cn.Close()
            cn.Open()

            cmd = New SqlCommand("select etatP from Commande where numCmd = " & numC & "", cn)
            etatP = cmd.ExecuteScalar()

            If etatP = "np" Then

                DataGridView2.Visible = True
                DataGridView2.Columns(4).Visible = True
                DataGridView2.Columns(5).Visible = True
                BT_fermerDG2.Visible = True
                viderCmdC()

                pn_CreatCmd.Visible = False
                PnPaiement.Visible = False
                BtFerP.Visible = False
                BT_fermerR.Visible = True
                pn_RempCmd.Visible = True

                cn.Close()
                cn.Open()
                cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
                mont = cmd.ExecuteScalar
                LblMA.Text = "Montant actuel : " & mont & " dhs"
                LblMA.Visible = True


                nomR = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
            Else

                MsgBox("Commande déja payée ! ", MsgBoxStyle.Exclamation)

                DataGridView2.Visible = False
                BT_fermerDG2.Visible = False
            End If


        End If

        If e.ColumnIndex = 7 Then

            pn_CreatCmd.Visible = False
            BtFerC.Visible = False
            'pn_RecherCmd.Visible = False
            'BtFermerRech.Visible = False
            viderCmdC()
            viderCmdR()
            pn_RempCmd.Visible = False
            BT_fermerR.Visible = False
            BT_fermerDG2.Visible = False
            DataGridView2.Visible = False
            PnPaiement.Visible = False
            BtFerP.Visible = False

            dateC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

            txtDonner.Clear()
            lblReste.Visible = False
            txtReste.Clear()


            txtReste.Visible = False

            lblPaie.Visible = False
            lblManque.Visible = False



            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False


            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select etatP from Commande where numCmd = " & numC & "", cn)
            etatP = cmd.ExecuteScalar
            LblMp.Visible = False

            If etatP = "p" Then

                pn_RempCmd.Visible = False
                viderCmdR()
                ' pn_RecherCmd.Visible = False
                pn_CreatCmd.Visible = False
                viderCmdC()
                DataGridView2.Visible = False
                PnPaiement.Visible = False
                BtFerP.Visible = False
                MsgBox("Commande déja payée ! ", MsgBoxStyle.Exclamation)
                cn.Close()

            Else

                viderDG2()
                DataGridView2.Visible = True
                DataGridView2.Columns(4).Visible = True
                DataGridView2.Columns(5).Visible = True
                BT_fermerDG2.Visible = True
                alimenterDG_DetCommandes()

                nomR = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value

                cn.Close()
                cn.Open()

                cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
                DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value = cmd.ExecuteScalar

                montG = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value

                

                cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
                mont = cmd.ExecuteScalar

                BtFerP.Visible = True
                PnPaiement.Visible = True
                '        DataGridView2.Columns(4).Visible = False
                '        DataGridView2.Columns(5).Visible = False

                LblMA.Visible = False
                LblMp.Visible = False

                lblRestePaieDH.Text = "Reste (dhs) : " & mont & ". "
                lblRestePaieDH.Visible = True

                'lblRestePaieRyal.Text = "Reste (ryal) : " & (mont * 20) & "."
                'lblRestePaieRyal.Visible = True

                montG = montG + mont
                lblMontant.Text = "Montant total a payer : " & montG & " dhs"
                lblMontant.Visible = True

                cmd = New SqlCommand("select capital from Grossiste", cn)
                cap = cmd.ExecuteScalar

                lblCap.Text = "Capital : " & cap & " dhs"
                lblCap.Visible = True


                cn.Close()
                pn_CreatCmd.Visible = False
                pn_RempCmd.Visible = False

            End If


        End If

        If e.ColumnIndex = 8 Then

            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False
            lblPaie.Visible = False
            lblManque.Visible = False
            'PnPaiement.Visible = False
            'BtFerP.Visible = False
            'pn_CreatCmd.Visible = False
            'BtFerC.Visible = False
            'pn_RecherCmd.Visible = False
            'BtFermerRech.Visible = False
            'viderCmdC()
            'viderCmdR()
            'pn_RempCmd.Visible = False
            'BT_fermerR.Visible = False

            cn.Close()
            cn.Open()
            'cmd = New SqlCommand("select etatP from Commande where numCmd = '" & numC & "'", cn)
            'etatP = cmd.ExecuteScalar()

            'If etatP = "p" Then

            BT_fermerDG2.Visible = False
            DataGridView2.Visible = False

            DataGridView2.Columns(4).Visible = False
            DataGridView2.Columns(5).Visible = False
            LblMp.Visible = False

            imprimerCmdPaiement2()

            'Else

            '    imprimerCmd()

            'End If

        End If

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick




        Dim ligne As Integer
        ' --- Récupération des lignes et colonnes
        ligne = Me.DataGridView2.CurrentRow.Index


        lblAjout.Visible = False
        lblModifDC.Visible = False
        lblModifDCe.Visible = False
        lblCmdc.Visible = False
        lblCmdE.Visible = False
        lblCreditDH.Visible = False
        lblRetech.Visible = False
        lblRetPdt.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False


        If e.ColumnIndex = 6 Then

            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False

            d = Date.Today

            If MsgBox("Voulez-vous vraiment retirer ce produit de la commande " & numC & " ?", vbYesNo) = vbYes Then


                numC = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(0).Value
                desPd = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(1).Value

                If RB_Consulter.Checked = False Then

                    cn.Close()
                    cn.Open()
                    cmd = New SqlCommand("select qteCmd from ContenirPdtCmd where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & desPd & "')", cn)
                    qte = cmd.ExecuteScalar

                Else

                    qte = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(2).Value


                End If


                cn.Close()
                cn.Open()
                cmd1 = New SqlCommand("select totalPdt from ContenirPdtCmd where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & desPd & "')", cn)
                l = cmd1.ExecuteScalar

                cmd1 = New SqlCommand("UPDATE Commande set montantHT = montantHT - " & l & " where numCmd = " & numC & "", cn)
                cmd1.ExecuteNonQuery()

                cmd = New SqlCommand("select etatP from Commande where numCmd = " & numC & "", cn)
                etatP = cmd.ExecuteScalar


                If etatP = "np" Then
                    cmd1 = New SqlCommand("DELETE from ContenirPdtCmd WHERE numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & desPd & "')", cn)
                    j = cmd1.ExecuteNonQuery

                    If (j > 0) Then

                        cmd1 = New SqlCommand("update Produit set qteStock = qteStock + " & qte & " where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & desPd & "')", cn)
                        cmd1.ExecuteNonQuery()


                        cmd = New SqlCommand("update ArchiveStock set SF = SF + " & qte & " where codePdt = (select codePdt from Produit where desigPdt = '" & desPd & "') and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                        cmd.ExecuteNonQuery()


                        lblRetPdt.Visible = True
                        viderCmdR()


                        cmd = New SqlCommand("select desigPdt from Produit where codePdt not in (select codePdt from ContenirPdtCmd where numCmd = " & numC & ") ", cn)
                        dr = cmd.ExecuteReader

                        Do While dr.Read
                            cb_desigPdt.Items.Add(dr(0))
                        Loop
                        dr.Close()

                        DataGridView2.Rows.Remove(DataGridView2.CurrentRow)




                        cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
                        mont = cmd.ExecuteScalar


                        LblMp.Text = "Montant actuel : " & mont & " dhs"
                        LblMp.Visible = True
                        DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value = mont

                        LblMA.Text = "Montant actuel : " & mont & " dhs"
                        LblMA.Visible = True

                        lblMontant.Text = "Montant total à payer : " & mont & " dhs"

                    Else

                        lblRetech.Visible = True


                    End If
                Else

                    MsgBox("impossible de retirer ce produit de cette commande de l'archive: déja payée.", MsgBoxStyle.OkCancel, MsgBoxStyle.Exclamation)

                End If

                cn.Close()
            End If


        End If

        If e.ColumnIndex = 5 Then


            lblAjout.Visible = False
            lblModifDC.Visible = False
            lblModifDCe.Visible = False
            lblCmdc.Visible = False
            lblCmdE.Visible = False
            lblCreditDH.Visible = False
            lblRetech.Visible = False
            lblRetPdt.Visible = False
            lblSupp.Visible = False
            lblSuppe.Visible = False


            DataGridView2.Columns(4).Visible = True


            numC = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(0).Value
            desPd = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(1).Value

            If RB_Consulter.Checked = True Then

                'cmd = New SqlCommand("select qteCmd from ContenirPdtCmd where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & desPd & "')", cn)
                'qte = cmd.ExecuteScalar

                'Else

                dateC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
                nomR = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value

            End If


            Dim dp As String
            Dim q As Integer


            dp = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(1).Value
            qteNouv = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(2).Value
            q = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(4).Value
            prix = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(3).Value
            dp = dp.ToUpper()

            cn.Close()
            cn.Open()

            'cmd = New SqlCommand("select qteStock from Produit where desigPdt = '" & dp & "'", cn)
            'q = cmd.ExecuteScalar

            cmd = New SqlCommand("select qteCmd from ContenirPdtCmd where numCmd = " & numC & " and codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & dp & "')", cn)
            qteAnc = cmd.ExecuteScalar


            If (qteNouv - qteAnc <= q) Then

7:
                cmd = New SqlCommand("UPDATE ContenirPdtCmd SET qteCmd = " & qteNouv & " where numCmd =" & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & dp & "')", cn)
                i = cmd.ExecuteNonQuery

                cmd2 = New SqlCommand("update Produit set qteStock = qteStock + (" & qteAnc & " - " & qteNouv & " ) where  codePdt = (select codePdt from Produit where desigPdt = '" & dp & "' )", cn)
                cmd2.ExecuteNonQuery()

                cmd = New SqlCommand("UPDATE ContenirPdtCmd SET prixU = (select prixPdt from Produit where  codePdt = (select codePdt from Produit where desigPdt = '" & dp & "'))", cn)
                cmd.ExecuteNonQuery()

                cmd1 = New SqlCommand("UPDATE ContenirPdtCmd SET totalPdt = qteCmd * " & prix & " where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & dp & "')", cn)
                cmd1.ExecuteNonQuery()



                If (i > 0) Then

                    cmd = New SqlCommand("select distinct codeCateg from Produit where desigPdt = '" & dp & "' and codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Recharge')", cn)
                    codeCatg = cmd.ExecuteScalar

                    If codeCatg <> 0 Then

                        cmd = New SqlCommand("select totalPdt * (1-((A.pourcentage)/100)) as montantT from ContenirPdtCmd ,  AvoirPourcent A where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & dp & "') and (A.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & nomR & "') and A.codeCateg = (select codeCateg from Produit  where desigPdt = '" & dp & "'))", cn)
                        mont = cmd.ExecuteScalar

                    Else

                        cmd = New SqlCommand("select totalPdt from ContenirPdtCmd  where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & dp & "')", cn)
                        mont = cmd.ExecuteScalar

                    End If

                    cmd = New SqlCommand("update ContenirPdtCmd set totalPdt = " & mont & " where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & dp & "')", cn)
                    cmd.ExecuteNonQuery()




                    cmd1 = New SqlCommand("select SUM(totalPdt) from ContenirPdtCmd where numCmd = '" & numC & "'", cn)
                    montG = cmd1.ExecuteScalar

                    cmd1 = New SqlCommand("UPDATE Commande SET montantHT = " & montG & " where numCmd = '" & numC & "'", cn)
                    cmd1.ExecuteNonQuery()

                    cmd = New SqlCommand("select A.SF from ArchiveStock A where A.codePdt = (select codePdt from Produit where desigPdt = '" & dp & "' ) and MONTH(A.dateArch) =" & dateC.Month & " and DAY(A.dateArch) = " & dateC.Day & "", cn)
                    SF = cmd.ExecuteScalar
                    SF = SF + (qteAnc - qteNouv)

                    cmd = New SqlCommand("update ArchiveStock   set SF = " & SF & " where codePdt = (select codePdt from Produit where desigPdt = '" & dp & "' ) and MONTH(dateArch) =" & dateC.Month & " and DAY(dateArch) = " & dateC.Day & "", cn)
                    cmd.ExecuteNonQuery()


                    lblModifDC.Visible = True

                    cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
                    mont = cmd.ExecuteScalar
                    LblMp.Text = "Montant actuel : " & mont & " dhs"
                    LblMp.Visible = True

                    LblMA.Text = "Montant actuel : " & mont & " dhs"

                    lblMontant.Text = "Montant total à payer : " & mont & " dhs"

                    cn.Close()


                    DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value = montG



                    If RB_Consulter.Checked = True Then

                        viderDG2()
                        alimenterDG_DetCommandes()

                    Else

                        cn.Close()
                        cn.Open()
                        cmd = New SqlCommand("select qteStock from Produit where desigPdt = '" & dp & "'", cn)
                        q = cmd.ExecuteScalar

                        DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(4).Value = q
                        DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(3).Value = prix

                    End If


                    'viderDG1()
                    'alimenterDG_Commandes()



                Else

                    lblModifDC.Visible = False
                    lblModifDCe.Visible = True

                End If


            Else
                MsgBox("impossible d'effectuer la modification : quantité en stock indisponible", MsgBoxStyle.OkCancel, MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub BT_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_fermerDG2.Click

        DataGridView2.Rows.Clear()
        DataGridView2.Visible = False
        BT_fermerDG2.Visible = False
        LblMp.Visible = False
    End Sub

    Private Sub RB_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.Click

        lblAjout.Visible = False
        lblCreditDH.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblModifDC.Visible = False
        lblModifDCe.Visible = False
        lblRetech.Visible = False
        lblRetPdt.Visible = False
        lblAjout.Visible = False

        viderDG1()
        alimenterDG_Commandes()


        viderCmdC()
        viderCmdR()
        viderRech()

        viderDG2()
        DataGridView2.Visible = False
        BT_fermerDG2.Visible = False
        PnPaiement.Visible = False
        pn_CreatCmd.Visible = True
        BtFerC.Visible = True
        pn_RempCmd.Visible = False
        pn_RecherCmd.Visible = False

        alimenterCB_Revendeurs()
        '  txtNumCmd.Enabled = False

        '    Dim n As Integer = N_L()
        '    txtNumCmd.Text = n + 1


        BT_fermerDG2.Visible = False

    End Sub

    'Private Sub RB_Ajouter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ajouter.CheckedChanged

    '    lblAjout.Visible = False
    '    lblCreditDH.Visible = False
    '    lblSupp.Visible = False
    '    lblSuppe.Visible = False
    '    lblModifDC.Visible = False
    '    lblModifDCe.Visible = False
    '    lblRetech.Visible = False
    '    lblRetPdt.Visible = False
    '    lblAjout.Visible = False

    '    viderDG1()
    '    alimenterDG_Commandes()


    '    viderCmdC()
    '    viderCmdR()
    '    viderRech()

    '    viderDG2()
    '    DataGridView2.Visible = False
    '    BT_fermerDG2.Visible = False
    '    PnPaiement.Visible = False
    '    pn_CreatCmd.Visible = True
    '    BtFerC.Visible = True
    '    pn_RempCmd.Visible = False
    '    pn_RecherCmd.Visible = False

    '    alimenterCB_Revendeurs()
    '    '  txtNumCmd.Enabled = False

    '    '    Dim n As Integer = N_L()
    '    '    txtNumCmd.Text = n + 1


    '    BT_fermerDG2.Visible = False



    'End Sub

    Sub viderCmdR()

        RB_Modem.Checked = False
        RB_Portable.Checked = False
        RB_Puce.Checked = False
        RB_Recharge.Checked = False

        BtPayer.Visible = False

        cb_desigPdt.Text = ""
        cb_desigPdt.Items.Clear()
        txtQteCmd.Clear()
        txtPv.Clear()
        lblQteSt.Text = ""
        lblQteSt.Visible = False
        LblMA.Visible = False
        LblMp.Visible = False
        ' LblMA.Text = ""
    End Sub


    Sub viderCmdC()

        '   txtNumCmd.Clear()
        cb_Revendeur.Items.Clear()
        cb_Revendeur.Text = ""
        lblReste.Visible = False
        lblReste.Text = ""

    End Sub


    Sub viderCmdP()

        lblRestePaieDH.Text = ""
        ' lblRestePaieRyal.Text = ""


        txtDonner.Clear()

        lblRestePaieDH.Visible = False
        '   lblRestePaieRyal.Visible = False

        lblCap.Visible = False
        lblReste.Visible = False
        txtReste.Visible = False


        txtReste.Clear()

        lblManque.Visible = False
        lblPaie.Visible = False


    End Sub

    Sub alimenterCB_Revendeurs()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("SELECT nomRevend FROM Revendeur", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            cb_Revendeur.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub


    Private Sub BT_Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Valider.Click

       


        If cb_Revendeur.Text = "" Then

            MsgBox("Vous devez selectionner une référence afin de créer une nouvelle commande", MsgBoxStyle.Critical, "Remplissage des champs")

        Else

            Dim d As Date
            d = Date.Now

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("insert into Commande(dateCmd,codeRevend,reste,montantHT,etatP) values(getdate(),(select codeRevend from Revendeur where nomRevend ='" & (cb_Revendeur.Text) & "'),0,0,'np')", cn)
            i = cmd.ExecuteNonQuery()
            cn.Close()


            If i > 0 Then

                nomR = cb_Revendeur.Text
                dateC = Date.Now
               

                '     txtNumCmd.Enabled = False

                ' Dim n As Integer = N_L()
                '         txtNumCmd.Text = n + 1
                lblCmdc.Visible = True
                lblCreditDH.Text = ""
                lblCreditDH.Visible = False
                'lblCredRyal.Text = ""
                'lblCredRyal.Visible = False

                ' DataGridView1.Rows.Add(numC, d, nomR, 0)

                viderDG1()
                alimenterDG_Commandes()

                

                viderCmdR()
                pn_RempCmd.Visible = True
                BT_fermerR.Visible = True
                viderDG2()

                cn.Close()
                cn.Open()

                cmd = New SqlCommand("SELECT IDENT_CURRENT('Commande')", cn)
                numC = cmd.ExecuteScalar


                viderCmdC()
                alimenterCB_Revendeurs()

                'RB_Ajouter.Checked = False
                'RB_Consulter.Checked = False
            Else

                RB_Ajouter.Checked = False
                RB_Consulter.Checked = False

                lblCmdE.Visible = True

            End If


        End If
        

    End Sub


    Sub alimenterCB_Pdts()
        cn.Close()
        cn.Open()

        cmd = New SqlCommand("SELECT desigPdt FROM Produit ", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()


    End Sub


    Private Sub cb_numCmdR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblAjout.Visible = False
    End Sub

    Private Sub cb_desigPdt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_desigPdt.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtQteCmd.Select()
        End If

    End Sub

    Private Sub cb_desigPdt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_desigPdt.KeyPress

    End Sub

    Private Sub cb_desigPdt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_desigPdt.SelectedIndexChanged

        lblAjout.Visible = False

        cn.Close()
        cn.Open()
        cmd2 = New SqlCommand("select qteStock from Produit where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "')", cn)
        qteS = cmd2.ExecuteScalar

        lblQteSt.Text = "Quantité en stock : " & qteS & " "
        lblQteSt.Visible = True

    End Sub

    Private Sub BT_AnnulerR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_AnnulerR.Click

        'LblMA.Visible = False
        ' lblQteSt.Visible = False
        ' cb_desigPdt.Items.Clear()
        txtQteCmd.Clear()
        txtPv.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_fermerR.Click

        BtPayer.Visible = False
        pn_RempCmd.Visible = False
        BT_fermerR.Visible = False
        RB_Modem.Checked = False
        RB_Portable.Checked = False
        RB_Puce.Checked = False
        RB_Recharge.Checked = False
        viderCmdR()


    End Sub

    Private Sub RB_Consulter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Consulter.Click

        lblSupp.Visible = False
        lblSuppe.Visible = False
        lblModifDC.Visible = False
        lblModifDCe.Visible = False
        lblRetech.Visible = False
        lblRetPdt.Visible = False
        lblAjout.Visible = False
        LblMp.Visible = False
        viderDG1()
        viderDG2()
        PnPaiement.Visible = False
        pn_RecherCmd.Visible = True
        BtFermerRech.Visible = True
        pn_CreatCmd.Visible = False

    End Sub

    'Private Sub RB_Consulter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Consulter.CheckedChanged

    '    If RB_Consulter.Checked = True Then

    '        lblSupp.Visible = False
    '        lblSuppe.Visible = False
    '        lblModifDC.Visible = False
    '        lblModifDCe.Visible = False
    '        lblRetech.Visible = False
    '        lblRetPdt.Visible = False
    '        lblAjout.Visible = False
    '        LblMp.Visible = False
    '        viderDG1()
    '        viderDG2()
    '        PnPaiement.Visible = False
    '        pn_RecherCmd.Visible = True
    '        BtFermerRech.Visible = True
    '        pn_CreatCmd.Visible = False

    '    End If

    'End Sub

    Sub alimenterCb_Reche_Revend()

        cn.Close()
        cn.Open()



        If Cb_Reche_Date.SelectedItem <> Nothing Then

            d = Cb_Reche_Date.Text
            cmd = New SqlCommand("SELECT distinct nomRevend FROM Revendeur where codeRevend in (select codeRevend from Commande where MONTH(dateCmd) = " & d.Month & " and DAY(dateCmd) = " & d.Day & ")", cn)

        Else
            cmd = New SqlCommand("SELECT distinct nomRevend FROM Revendeur where codeRevend in (select codeRevend from Commande)", cn)

        End If
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_Revend.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub

    Sub alimenterCb_Reche_Date()
        cn.Close()
        cn.Open()


        If Cb_Reche_Revend.SelectedItem <> Nothing Then

            cmd = New SqlCommand("SELECT distinct dateCmd FROM Commande where codeRevend = (select codeRevend from Revendeur where nomRevend = '" & Cb_Reche_Revend.Text & "')", cn)

        Else

            cmd = New SqlCommand("select distinct dateCmd from Commande", cn)

        End If

        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_Date.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()

    End Sub

    Private Sub CK_Revend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_Revend.CheckedChanged

        If CK_Revend.Checked = True Then

            viderDG1()
            viderDG2()

            Cb_Reche_Revend.Items.Clear()
            Cb_Reche_Revend.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""

            Cb_Reche_NumCmd.Visible = False
            Ck_NumCmd.Checked = False

            Cb_Reche_Revend.Visible = True
            alimenterCb_Reche_Revend()

        Else

            Cb_Reche_Revend.Visible = False

        End If

    End Sub

    Private Sub Ck_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_Date.CheckedChanged

        If Ck_Date.Checked = True Then

            viderDG1()
            viderDG2()

            Cb_Reche_Date.Items.Clear()
            Cb_Reche_Date.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""


            Cb_Reche_NumCmd.Visible = False
            Ck_NumCmd.Checked = False

            Cb_Reche_Date.Visible = True
            alimenterCb_Reche_Date()

        Else
            Cb_Reche_Date.Visible = False

        End If

    End Sub

    Private Sub BtVlider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVlider.Click


        DataGridView1.Columns(2).Visible = True


        viderDG1()
        viderDG2()

        If Cb_Reche_Revend.SelectedItem <> Nothing And Cb_Reche_Date.SelectedItem <> Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing Then

            d = Cb_Reche_Date.Text
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select C.numCmd,C.dateCmd,R.nomRevend,C.montantHT from  Commande C,Revendeur R  where C.codeRevend = (select codeRevend from Revendeur  where nomRevend = '" & Cb_Reche_Revend.Text & "' ) and YEAR(C.dateCmd) = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & " and R.codeRevend = C.codeRevend", cn)
            dr = cmd.ExecuteReader

            DataGridView1.Columns(2).Visible = False

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}
                DataGridView1.Rows.Add(x)

            End While

            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(8).Visible = True

            dr.Close()
            cn.Close()

        ElseIf Cb_Reche_Revend.SelectedItem <> Nothing And Cb_Reche_Date.SelectedItem = Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing Then

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select C.numCmd, C.dateCmd, C.montantHT from Commande  C  where C.codeRevend =  (select codeRevend from Revendeur  where '" & Cb_Reche_Revend.Text & "' = nomRevend)", cn)
            dr = cmd.ExecuteReader
            ' DataGridView1.Columns(3).Visible = False

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), Cb_Reche_Revend.Text, dr(2)}
                DataGridView1.Rows.Add(x)

            End While

            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(8).Visible = True

            dr.Close()
            cn.Close()

        ElseIf Cb_Reche_Revend.SelectedItem = Nothing And Cb_Reche_NumCmd.SelectedItem = Nothing And Cb_Reche_Date.SelectedItem <> Nothing Then

            d = Cb_Reche_Date.Text
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select C.numCmd, C.dateCmd,R.nomRevend,C.montantHT from Commande C,Revendeur R  where YEAR(C.dateCmd) = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & " and R.codeRevend = C.codeRevend", cn)
            dr = cmd.ExecuteReader

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}
                DataGridView1.Rows.Add(x)

            End While

            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(8).Visible = True

            dr.Close()
            cn.Close()

        ElseIf Cb_Reche_Revend.SelectedItem = Nothing And Cb_Reche_Date.SelectedItem = Nothing And Cb_Reche_NumCmd.SelectedItem <> Nothing Then

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select C.numCmd, C.dateCmd, R.nomRevend,C.montantHT,C.etatP from Commande C, Revendeur R where C.numCmd = " & Cb_Reche_NumCmd.Text & " and R.codeRevend = C.codeRevend", cn)
            dr = cmd.ExecuteReader

            While dr.Read()

                Dim x As String() = {dr(0), dr(1), dr(2), dr(3)}
                DataGridView1.Columns(3).Visible = True
                DataGridView1.Rows.Add(x)

                If dr(4) = "p" Then

                    DataGridView2.Columns(4).Visible = False
                    DataGridView2.Columns(5).Visible = False

                Else

                    DataGridView2.Columns(4).Visible = True
                    DataGridView2.Columns(5).Visible = True
                End If
            End While

            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(8).Visible = True

            dr.Close()
            cn.Close()
            alimenterDG2_cb()

        End If
    End Sub

    Sub alimenterCB_Commandes()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("SELECT numCmd FROM Commande", cn)
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

            Ck_Date.Checked = False
            Cb_Reche_Date.Visible = False

            CK_Revend.Checked = False
            Cb_Reche_Revend.Visible = False

            Cb_Reche_Revend.Items.Clear()
            Cb_Reche_Revend.Text = ""

            Cb_Reche_Date.Items.Clear()
            Cb_Reche_Date.Text = ""

            Cb_Reche_NumCmd.Items.Clear()
            Cb_Reche_NumCmd.Text = ""

            Cb_Reche_NumCmd.Visible = True
            alimenterCB_Commandes()

        Else

            Cb_Reche_NumCmd.Visible = False

        End If

    End Sub

    Private Sub Bt_Donner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Donner.Click

        If txtDonner.Text = "" Then

            MsgBox("Vous devez remplir le champs du montant donné  ", MsgBoxStyle.Critical, "Remplissage des champs")

        Else

            cn.Close()
            cn.Open()

            If RB_Consulter.Checked = True Then
                cmd = New SqlCommand("select nomRevend from Revendeur where codeRevend = (select codeRevend from Commande where numCmd = " & numC & ")", cn)
                nomR = cmd.ExecuteScalar

            Else

            
            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
            monTT = cmd.ExecuteScalar

            End If

            reste = 0

            cmd = New SqlCommand("select distinct montantHT from Commande where numCmd = " & numC & "", cn)
            mont = cmd.ExecuteScalar
            reste = Val(txtDonner.Text) - mont    '  reste = 180 - 50 = 130

            If reste >= 0 Then

                If Val(txtDonner.Text) >= (mont + monTT) Then

                    cap = cap + mont + monTT
                    cmd = New SqlCommand("update Grossiste set  capital = " & cap & "", cn)
                    cmd.ExecuteNonQuery()

                    lblCap.Text = "Capital : " & cap & ""


                Else

                    cap = cap + Val(txtDonner.Text)
                    cmd = New SqlCommand("update Grossiste set  capital = " & cap & "", cn)
                    cmd.ExecuteNonQuery()

                    lblCap.Text = "Capital : " & cap & ""

                End If


                cd = 0



                cmd = New SqlCommand("select numCmd from Commande where reste >= 0 and codeRevend = (select codeRevend from Revendeur where nomRevend = '" & nomR & "')", cn)
                dr = cmd.ExecuteReader()

                Do While dr.Read() And cd = 0

                    y = dr(0)
                    cmd2 = New SqlCommand("select reste from Commande where numCmd = " & y & "", cn)
                    r = cmd2.ExecuteScalar

                    If reste - r > 0 Then

                        reste = reste - r
                        cmd2 = New SqlCommand("update Commande set reste = 0 where numCmd = " & y & "", cn)
                        cmd2.ExecuteNonQuery()

                    ElseIf reste - r = 0 Then

                        reste = reste - r
                        cmd2 = New SqlCommand("update Commande set reste = 0 where numCmd = " & y & "", cn)
                        cmd2.ExecuteNonQuery()
                        cd = 1

                    ElseIf reste - r < 0 Then

                        reste = r - reste

                        cmd2 = New SqlCommand("update Commande set reste = " & reste & " where numCmd = " & y & "", cn)
                        cmd2.ExecuteNonQuery()
                        reste = -reste
                        cd = 1
                    End If


                Loop

                lblReste.Visible = True
                txtReste.Text = reste
                txtReste.Visible = True
                lblPaie.Visible = True


                '     dr.Close()

                cmd = New SqlCommand("update Commande set etatP='p' where numCmd = " & numC & "", cn)
                cmd.ExecuteNonQuery()



                cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
                mont = cmd.ExecuteScalar

                lblRestePaieDH.Text = "Reste : " & mont & " dhs"
                '  lblRestePaieRyal.Text = "Reste : " & (mont * 20) & " ryal"

                DataGridView2.Visible = False
                BT_fermerDG2.Visible = False

            ElseIf reste < 0 Then

                If Val(txtDonner.Text) >= (mont + monTT) Then

                    cap = cap + mont + monTT
                    cmd = New SqlCommand("update Grossiste set  capital = " & cap & "", cn)
                    cmd.ExecuteNonQuery()

                    lblCap.Text = "Capital : " & cap & ""

                Else

                    cap = cap + Val(txtDonner.Text)
                    cmd = New SqlCommand("update Grossiste set  capital = " & cap & "", cn)
                    cmd.ExecuteNonQuery()

                    lblCap.Text = "Capital : " & cap & ""

                End If


                lblReste.Visible = True
                txtReste.Text = reste
                txtReste.Visible = True
                lblManque.Visible = True


                cmd = New SqlCommand("update Commande set reste = " & -reste & " , etatP = 'p' where numCmd = " & numC & " ", cn)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
                mont = cmd.ExecuteScalar
                lblRestePaieDH.Text = "Reste : " & mont & " dhs"
                ' lblRestePaieRyal.Text = "Reste : " & (mont * 20) & " ryal"


            End If


            cmd = New SqlCommand("select capital from Grossiste", cn)
            cap = cmd.ExecuteScalar

            lblCap.Text = "Capital : " & cap & " dhs"

            cn.Close()
            Bt_Imprimer.Visible = True

        End If
    End Sub

    Private Sub cb_Revendeur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Revendeur.SelectedIndexChanged

        If cb_Revendeur.SelectedItem <> Nothing Then

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select count(numCmd) from Commande", cn)
            i = cmd.ExecuteScalar

            If (i > 0) Then

                j = 0
                cmd = New SqlCommand("select nomRevend from Revendeur where codeRevend in (select distinct codeRevend from Commande)", cn)
                dr = cmd.ExecuteReader

                Do While dr.Read And j = 0
                    If dr(0) = cb_Revendeur.Text Then

                        j = 1

                    End If

                Loop

                If j = 0 Then

                    lblCreditDH.Text = "pas de reste"
                    lblCreditDH.Visible = True

                    'lblCredRyal.Text = ""
                    'lblCredRyal.Visible = False

                Else

                    dr.Close()
                    cmd = New SqlCommand("select SUM(reste) from Commande where  codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & cb_Revendeur.Text & "') ", cn)
                    mont = cmd.ExecuteScalar

                    '   If Not dr.IsDBNull(0) Then


                    lblCreditDH.Text = "Reste : " & mont & " dhs"
                    lblCreditDH.Visible = True

                    'lblCredRyal.Text = "Reste : " & (mont * 20) & " ryal "
                    'lblCredRyal.Visible = True

                    '                End If



                End If

                dr.Close()
                cn.Close()

            End If
        End If

    End Sub

    Sub viderRech()

        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False

        Ck_Date.Checked = False
        Ck_NumCmd.Checked = False
        CK_Revend.Checked = False
        Cb_Reche_Date.Visible = False
        Cb_Reche_NumCmd.Visible = False
        Cb_Reche_Revend.Visible = False

        Cb_Reche_NumCmd.Items.Clear()
        Cb_Reche_NumCmd.Text = ""
        Cb_Reche_Revend.Items.Clear()
        Cb_Reche_Revend.Text = ""
        Cb_Reche_Date.Items.Clear()
        Cb_Reche_Date.Text = ""



    End Sub
    Private Sub BT_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        RB_Ajouter.Checked = False
        RB_Consulter.Checked = False

        viderCmdC()
        viderCmdR()

        viderDG1()
        viderDG2()
        LblMp.Visible = False

        viderCmdP()
        viderRech()

        lblRetPdt.Visible = False
        lblRetech.Visible = False
        lblModifDC.Visible = False
        lblModifDCe.Visible = False

        alimenterDG_Commandes()
        pn_CreatCmd.Visible = False
        pn_RecherCmd.Visible = False
        pn_RempCmd.Visible = False
        PnPaiement.Visible = False
        BT_fermerDG2.Visible = False
        BT_fermerR.Visible = False
        BtFerC.Visible = False
        BtFerP.Visible = False
        DataGridView2.Visible = False


    End Sub

    
    Private Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click

        'RB_Ajouter.Checked = False
        ' RB_Consulter.Checked = False

        pn_CreatCmd.Visible = False
        BtFerC.Visible = False

        d = Date.Today



        If (RB_Recharge.Checked = True And (cb_desigPdt.Text = "" Or txtQteCmd.Text = "")) Then

            MsgBox("Vous devez saisir tous  les champs afin d'ajouter un  produit a cette commande", MsgBoxStyle.Critical, "Remplissage des champs")

        ElseIf ((RB_Puce.Checked = True Or RB_Modem.Checked = True Or RB_Portable.Checked = True) And (cb_desigPdt.Text = "" Or txtQteCmd.Text = "" Or txtPv.Text = "")) Then

            MsgBox("Vous devez saisir tous  les champs afin d'ajouter un  produit a cette commande", MsgBoxStyle.Critical, "Remplissage des champs")

        Else

            If RB_Consulter.Checked = True Then

                numC = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
                nomR = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value

            End If


            cn.Close()
            cn.Open()
            cmd = New SqlCommand("Select qteStock from Produit where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "')", cn)
            qte = cmd.ExecuteScalar

            If (qte - Val(txtQteCmd.Text) >= 0) Then

                If RB_Portable.Checked = True Then

                    ' (select prixPdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')

                    cmd = New SqlCommand("insert into ContenirPdtCmd(codePdt,numCmd,qteCmd,prixU,totalPdt,codeSoc) values((select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & numC & "," & txtQteCmd.Text & "," & txtPv.Text & ",0,(select codeSoc from Societe where nomSoc = 'Anonyme'))", cn)
                    cmd.ExecuteNonQuery()


                ElseIf RB_Puce.Checked = True Or RB_Modem.Checked = True Then

                    cmd = New SqlCommand("insert into ContenirPdtCmd(codePdt,numCmd,qteCmd,prixU,totalPdt,codeSoc) values((select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & numC & "," & txtQteCmd.Text & "," & txtPv.Text & ",0,(select distinct codeSoc from AcheterPdt  where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')))", cn)
                    cmd.ExecuteNonQuery()


                ElseIf RB_Recharge.Checked = True Then

                    cmd = New SqlCommand("insert into ContenirPdtCmd(codePdt,numCmd,qteCmd,prixU,totalPdt,codeSoc) values((select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & numC & "," & txtQteCmd.Text & ",(select prixPdt from Produit where desigPdt = '" & cb_desigPdt.Text & "'),0,(select distinct codeSoc from AcheterPdt  where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')))", cn)
                    cmd.ExecuteNonQuery()

                End If


                cmd = New SqlCommand("select qteStock from Produit where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "') ", cn)
                SI = cmd.ExecuteScalar

                cmd = New SqlCommand(" update Produit set qteStock = ( qteStock - " & Val(txtQteCmd.Text) & " ) where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "') ", cn)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("update ContenirPdtCmd set totalPdt = (prixU * qteCmd)  where numCmd = " & numC & " and  codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "') ", cn)
                cmd.ExecuteNonQuery()

                If RB_Recharge.Checked = True Then

                    cmd = New SqlCommand("select totalPdt * (1-((A.pourcentage)/100)) as montantT from ContenirPdtCmd ,  AvoirPourcent A where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "') and (A.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & nomR & "') and A.codeCateg = (select codeCateg from Produit  where desigPdt = '" & cb_desigPdt.Text & "'))", cn)
                    mont = cmd.ExecuteScalar

                Else

                    cmd = New SqlCommand("select totalPdt from ContenirPdtCmd  where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')", cn)
                    mont = cmd.ExecuteScalar

                End If

                cmd = New SqlCommand("update ContenirPdtCmd set totalPdt = " & Val(mont) & " where numCmd = " & numC & " and qteCmd = " & txtQteCmd.Text & " and codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "')", cn)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("select totalPdt from ContenirPdtCmd where numCmd = " & numC & " and codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')", cn)
                tot = cmd.ExecuteScalar

                cmd = New SqlCommand("select dateCmd from Commande where numCmd = " & numC & "", cn)
                d1 = cmd.ExecuteScalar


                cond = 0
                cmd = New SqlCommand("select SF from ArchiveStock where dateArch = (select dateCmd from Commande where numCmd = " & numC & ") and codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')", cn)
                cond = cmd.ExecuteScalar



                If cond <> 0 Then



                    cmd = New SqlCommand("update ArchiveStock set SF = SF - " & txtQteCmd.Text & " where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "') and dateArch = (select dateCmd from Commande where numCmd = " & numC & ")", cn)
                    cmd.ExecuteNonQuery()

                Else

                    SF = SI - txtQteCmd.Text
                    cmd = New SqlCommand("insert into ArchiveStock(codePdt,SI,SF,dateArch) values((select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & SI & "," & SF & ",'2012-" & d1.Month & "-" & d1.Day & "')", cn)
                    cmd.ExecuteNonQuery()



                End If

                cmd = New SqlCommand("update Commande  SET montantHT = montantHT + " & tot & " where numCmd = " & numC & "", cn)
                cmd.ExecuteNonQuery()

                lblAjout.Visible = True

                cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
                mont = cmd.ExecuteScalar

                LblMA.Text = "Montant actuel : " & mont & " dhs"
                LblMA.Visible = True
                cn.Close()

                LblMp.Text = "Montant actuel : " & mont & " dhs"

                BtPayer.Visible = True



                BT_fermerDG2.Visible = True
                DataGridView2.Columns(4).Visible = True
                DataGridView2.Columns(5).Visible = True


                If RB_Consulter.Checked = False Then

                    cn.Open()
                    cmd = New SqlCommand("select prixPdt from Produit where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')", cn)
                    prix = cmd.ExecuteScalar
                    cn.Close()
                    DataGridView2.Visible = True
                    DataGridView2.Columns(0).Visible = False
                    If RB_Recharge.Checked = True Then
                        DataGridView2.Rows.Add(numC, cb_desigPdt.Text, txtQteCmd.Text, prix, qte - Val(txtQteCmd.Text))
                    Else
                        DataGridView2.Rows.Add(numC, cb_desigPdt.Text, txtQteCmd.Text, Val(txtPv.Text), qte - Val(txtQteCmd.Text))
                    End If
                Else

                    viderDG2()
                    alimenterDG_DetCommandes()



                    DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value = mont

                End If

                    'viderDG1()
                    'alimenterDG_Commandes()
                    cb_desigPdt.Items.Clear()
                    cb_desigPdt.Text = ""
                    txtQteCmd.Clear()
                    txtPv.Clear()
                    lblQteSt.Visible = False
                    '   viderCmdR()

                    LblMA.Visible = True
                    If RB_Recharge.Checked = True Then
                        alimenterRecharges()
                    End If


                    If RB_Portable.Checked = True Then
                        alimenterPortables()
                    End If


                    If RB_Puce.Checked = True Then
                        alimenterPuces()
                    End If

                    If RB_Modem.Checked = True Then
                        alimenterModem()
                    End If




                Else

                    MsgBox("impossible de commander ce produit : Quantité en stock insuffisante", MsgBoxStyle.OkCancel)
                End If

        End If

        'cb_desigPdt.Items.Clear()
        'cb_desigPdt.Text = ""
        'txtQteCmd.Clear()

    End Sub

    Sub alimenterRecharges()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select desigPdt from Produit where qteStock > 0 and codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Recharge') and (codePdt not in (select codePdt from ContenirPdtCmd where numCmd = " & numC & ")) ", cn)
        dr = cmd.ExecuteReader


        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()

        cn.Close()

    End Sub

    Sub alimenterPortables()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select desigPdt from Produit where qteStock > 0 and codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Portable') and (codePdt not in (select codePdt from ContenirPdtCmd where numCmd = " & numC & " )) ", cn)
        dr = cmd.ExecuteReader

        ' If Not dr.IsDBNull(0) Then
        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        '  End If
        cn.Close()

    End Sub

    Sub alimenterPuces()

        cn.Close()
        cn.Open()


        cmd = New SqlCommand("select desigPdt from Produit where qteStock > 0 and codeCateg  in (select codeCateg from CategoriePdt where typeCateg = 'Puce') and (codePdt not in (select codePdt from ContenirPdtCmd where numCmd = " & numC & "))", cn)
        dr = cmd.ExecuteReader

        '  If Not dr.IsDBNull(0) Then
        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        ' End If
        cn.Close()

    End Sub

    Sub alimenterModem()

        cn.Close()
        cn.Open()


        cmd = New SqlCommand("select desigPdt from Produit where qteStock > 0 and codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Modem') and (codePdt not in (select codePdt from ContenirPdtCmd where numCmd = " & numC & ")) ", cn)
        dr = cmd.ExecuteReader

        ' If Not dr.IsDBNull(0) Then
        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        ' End If
        cn.Close()

    End Sub

    Private Sub RB_Recharge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Recharge.CheckedChanged

        If RB_Recharge.Checked = True Then
            lblPVente.Visible = False
            txtPv.Clear()
            txtPv.Visible = False
            lblRetPdt.Visible = False
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            txtQteCmd.Clear()
            alimenterRecharges()

        End If
    End Sub

    Private Sub RB_Portable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Portable.CheckedChanged

        lblQteSt.Text = ""
        lblQteSt.Visible = False

       

        If RB_Portable.Checked = True Then

            txtPv.Clear()
            lblPVente.Visible = True
            txtPv.Visible = True
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            txtQteCmd.Clear()
            lblRetPdt.Visible = False
            alimenterPortables()

        End If
    End Sub

    Private Sub RB_Puce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Puce.CheckedChanged

        lblQteSt.Text = ""
        lblQteSt.Visible = False

        If RB_Puce.Checked = True Then
            txtPv.Clear()
            lblPVente.Visible = True
            txtPv.Visible = True
            lblRetPdt.Visible = False
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            txtQteCmd.Clear()
            alimenterPuces()

           

        End If

    End Sub

    Private Sub RB_Modem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Modem.CheckedChanged

        lblQteSt.Text = ""
        lblQteSt.Visible = False

       
        If RB_Modem.Checked = True Then

            txtPv.Clear()
            lblPVente.Visible = True
            txtPv.Visible = True
            lblRetPdt.Visible = False
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            txtQteCmd.Clear()
            alimenterModem()

           

        End If
    End Sub

   
    Private Sub txtNumCmd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'cn.Close()
        'cn.Open()

        'cmd = New SqlCommand("select numCmd from Commande", cn)
        'dr = cmd.ExecuteReader()
        'While dr.Read

        '    If (dr(0) = txtNumCmd.Text) Then
        '        MsgBox("Cette commande existe déjà", MsgBoxStyle.Exclamation, "Consultation")
        '        Exit While
        '    End If
        'End While

        'dr.Close()
        'cn.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        RB_Ajouter.Checked = False
        RB_Consulter.Checked = False

        viderCmdC()
        viderCmdR()

        viderDG1()
        viderDG2()
        LblMp.Visible = False

        viderCmdP()
        viderRech()

        lblRetPdt.Visible = False
        lblRetech.Visible = False
        lblModifDC.Visible = False
        lblModifDCe.Visible = False

        alimenterDG_Commandes()
        pn_CreatCmd.Visible = False
        pn_RecherCmd.Visible = False
        pn_RempCmd.Visible = False
        BtPayer.Visible = False
        PnPaiement.Visible = False

        BT_fermerDG2.Visible = False
        BT_fermerR.Visible = False
        BtFerC.Visible = False
        BtFerP.Visible = False
        DataGridView2.Visible = False

    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerC.Click


        viderCmdC()
        RB_Ajouter.Checked = False
        BtFerC.Visible = False
        pn_CreatCmd.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerP.Click

        PnPaiement.Visible = False
        BtFerP.Visible = False
        viderCmdP()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFermerRech.Click
        RB_Consulter.Checked = False
        BtFermerRech.Visible = False
        pn_RecherCmd.Visible = False
        viderRech()
    End Sub

    Private Sub Bt_Imprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Imprimer.Click
        imprimerCmdPaiement1()
    End Sub

    Private Sub BtAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAnnuler.Click

        cb_Revendeur.Items.Clear()
        cb_Revendeur.Text = ""
        lblCreditDH.Text = ""
        ' lblCredRyal.Text = ""
        lblCreditDH.Visible = False
        '  lblCredRyal.Visible = False
        alimenterCB_Revendeurs()

    End Sub

    Private Sub Cb_Reche_Revend_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Reche_Revend.SelectedIndexChanged

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select distinct dateCmd from Commande where codeRevend in (select codeRevend from Revendeur where nomRevend = '" & Cb_Reche_Revend.Text & "')", cn)
        dr = cmd.ExecuteReader

        If Cb_Reche_Date.SelectedItem = Nothing Then
            Cb_Reche_Date.Items.Clear()
            Do While dr.Read
                Cb_Reche_Date.Items.Add(dr(0))
            Loop

        End If

        
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Cb_Reche_Date_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Reche_Date.SelectedIndexChanged

        d = Cb_Reche_Date.Text

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select distinct nomRevend from Revendeur where codeRevend in (select codeRevend from Commande where MONTH(dateCmd) = " & d.Month & " and DAY(dateCmd) = " & d.Day & ")", cn)
        dr = cmd.ExecuteReader

        If Cb_Reche_Revend.SelectedItem = Nothing Then
            Cb_Reche_Revend.Items.Clear()

            Do While dr.Read
                Cb_Reche_Revend.Items.Add(dr(0))
            Loop

        End If

       
        dr.Close()
        cn.Close()

    End Sub

   
    Private Sub BtPayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPayer.Click


        lblModifDC.Visible = False
        lblModifDCe.Visible = False
        lblRetech.Visible = False
        lblRetPdt.Visible = False
        lblAjout.Visible = False
        lblSupp.Visible = False
        lblSuppe.Visible = False


        pn_RempCmd.Visible = False
        BT_fermerR.Visible = False
        viderCmdR()
        viderCmdP()
        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select montantHT from Commande where numCmd = " & numC & "", cn)
        montG = cmd.ExecuteScalar

        If RB_Consulter.Checked = False Then

            Dim i As Integer
            For i = 0 To DataGridView1.Rows.Count - 1

                If DataGridView1.Rows(i).Cells(0).Value = numC Then

                    DataGridView1.Rows(i).Cells(3).Value = montG

                End If
            Next

        Else
            DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value = montG
        End If


        cmd = New SqlCommand("select SUM(reste) from Commande where codeRevend  = (select R.codeRevend from Revendeur R where R.nomRevend = '" & nomR & "')", cn)
        mont = cmd.ExecuteScalar

        BtFerP.Visible = True
        PnPaiement.Visible = True
        '        DataGridView2.Columns(4).Visible = False
        '        DataGridView2.Columns(5).Visible = False

        LblMA.Visible = False
        LblMp.Visible = False



        lblRestePaieDH.Text = "Reste (dhs) : " & mont & "."
        lblRestePaieDH.Visible = True

        'lblRestePaieRyal.Text = "Reste (ryal) : " & (mont * 20) & "."
        'lblRestePaieRyal.Visible = True

        montG = montG + mont
        lblMontant.Text = "Montant total a payer : " & montG & " dhs"
        lblMontant.Visible = True


        cmd = New SqlCommand("select capital from Grossiste", cn)
        cap = cmd.ExecuteScalar

        lblCap.Text = "Capital : " & cap & " dhs"
        lblCap.Visible = True

        cn.Close()


    End Sub


    Private Sub txtDonnerOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDonner.KeyPress

        Controle_saisie.Textbox_control(sender, e, True, True, True, False)
        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub

    Private Sub txtQteCmd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQteCmd.KeyDown


        If RB_Recharge.Checked = False Then

            If e.KeyCode = Keys.Enter Then
                txtPv.Select()
            End If

        Else

            If e.KeyCode = Keys.Enter Then
                btValider.Select()
            End If

        End If


    End Sub

    Private Sub txtQteCmdOnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQteCmd.KeyPress

        Controle_saisie.Textbox_control(sender, e, True, False, True, False)

        ' | | | |_ si True: Caractère alphabet autorisé
        ' | | |
        ' | | |_si True:Nombre positif uniquement
        ' | |
        ' | |_ si True: Nombre entier uniquement
        ' |
        ' |_si true: Nombre autorisé

    End Sub
  
    Private Sub pn_CreatCmd_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pn_CreatCmd.Paint

    End Sub

    Private Sub txtPv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPv.KeyDown
        If e.KeyCode = Keys.Enter Then
            btValider.Select()
        End If
    End Sub

    Private Sub txtPv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPv.TextChanged

    End Sub

    Private Sub txtQteCmd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQteCmd.TextChanged

    End Sub

    Private Sub btValider_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btValider.KeyDown

        If e.KeyCode = Keys.Enter Then
            cb_desigPdt.Select()
        End If

    End Sub

    Private Sub RB_Recharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Recharge.KeyDown

        '   Me.cb_desigPdt.Select()

        If e.KeyCode = Keys.Enter Then
            cb_desigPdt.Select()
        End If

    End Sub

    Private Sub RB_Portable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Portable.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_desigPdt.Select()
        End If
    End Sub

    Private Sub RB_Puce_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Puce.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_desigPdt.Select()
        End If
    End Sub

    Private Sub RB_Modem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Modem.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_desigPdt.Select()
        End If
    End Sub


End Class