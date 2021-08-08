Imports System.Data
Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO.Stream
Imports System.IO.FileMode
Imports Microsoft.Office.Interop

Public Class GestStock

    Sub imprimerParMois()

        

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichStockMois.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)


        Dim nbrColon As Integer = Me.DataGridView1.Columns.Count - 2
        Dim nbrLigne As Integer
        Dim y, z As Integer


        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select distinct dateArch from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & " and MONTH(dateArch) = " & cd & "", cn)
        dr = cmd.ExecuteReader

        z = 0

        Try

            Do While dr.Read




                nbrLigne = 0
                d = dr(0)
                cmd = New SqlCommand("select count(codeArchSt) from ArchiveStock where YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                nbrLigne = cmd.ExecuteScalar

                cmd = New SqlCommand("select codeArchSt from ArchiveStock where YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                dr1 = cmd.ExecuteReader

                xlsheet.Cells(7 + z, 1) = d

                For y = 0 To nbrLigne - 1

                    dr1.Read()
                    cmd = New SqlCommand("select codePdt from ArchiveStock where YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & " and codeArchSt = " & dr1(0) & "", cn)
                    codeP = cmd.ExecuteScalar

                    cmd1 = New SqlCommand("select qteAchat from AcheterPdt where codePdt = " & codeP & " and YEAR(dateAchat) = " & d.Year & " and MONTH(dateAchat) = " & d.Month & " and DAY(dateAchat) = " & d.Day & "", cn)
                    ent = cmd1.ExecuteScalar

                    cmd1 = New SqlCommand("select SI from ArchiveStock where codePdt = " & codeP & " and YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                    SI = cmd1.ExecuteScalar

                    cmd1 = New SqlCommand("select SF from ArchiveStock where codePdt = " & codeP & " and YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                    SF = cmd1.ExecuteScalar

                    cmd1 = New SqlCommand("select desigPdt from Produit where codePdt = " & codeP & "", cn)
                    desig = cmd1.ExecuteScalar

                    cmd1 = New SqlCommand("select qteCmd from ContenirPdtCmd Cp, Commande C  where Cp.codePdt = " & codeP & " and C.numCmd= Cp.numCmd and YEAR(C.dateCmd) = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & "", cn)
                    qte = cmd1.ExecuteScalar


                    If qte <> 0 Then

                        cmd1 = New SqlCommand("select SUM(qteCmd) from ContenirPdtCmd Cp, Commande C  where Cp.codePdt = " & codeP & " and C.numCmd= Cp.numCmd and YEAR(C.dateCmd) = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & "", cn)
                        sort = cmd1.ExecuteScalar

                    Else
                        sort = 0
                    End If



                    xlsheet.Cells(7 + z, 2) = ent
                    xlsheet.Cells(7 + z, 3) = desig
                    xlsheet.Cells(7 + z, 4) = SI
                    xlsheet.Cells(7 + z, 5) = SF
                    xlsheet.Cells(7 + z, 6) = sort



                    'xlsheet.Cells(y + z, x + 2) = Me.DataGridView1.Item(x, y).Value

                    z = z + 1

                Next

                z = y + z


            Loop

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
            '   xlsheet.SaveAs("C:\FichStock.xlsx")



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

    Sub imprimerParJour()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select dateArch from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & " and MONTH(dateArch) = " & cd & " and DAY(dateArch) = " & cb_RechJour.Text & "", cn)
        d1 = cmd.ExecuteScalar

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichStockJour.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        Try
            '            ici on compte le nombre de lignes et de colonnes du datatable
            Dim nbrLigne As Integer = Me.DataGridView1.Rows.Count - 1
            Dim nbrColon As Integer = Me.DataGridView1.Columns.Count - 1
            Dim x, y As Integer


            'xlsheet.Cells(5, 0) = Me.DataGridView1.Columns(0).Name
            'xlsheet.Cells(5, 3) = Me.DataGridView1.Columns(1).Name
            'xlsheet.Cells(5, 6) = Me.DataGridView1.Columns(2).Name
            'xlsheet.Cells(5, 9) = Me.DataGridView1.Columns(3).Name
            'xlsheet.Cells(5, 12) = Me.DataGridView1.Columns(4).Name



            xlsheet.Cells(5, 2) = d1
            For x = 0 To nbrColon
                ' Pour chaque colonne et chaque ligne on transfert les données 
                ' On commence par la ligne 8 et la colonne 2 pour laisser un espace      
                For y = 0 To nbrLigne
                    xlsheet.Cells(y + 8, x + 2) = Me.DataGridView1.Item(x, y).Value
                Next
            Next


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
            '   xlsheet.SaveAs("C:\FichStock.xlsx")



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


    Private Sub RB_Charger_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Charger.CheckedChanged

        If RB_Charger.Checked = True Then

            lblModifSt.Visible = False
            DataGridView1.Columns(5).Visible = False
            viderConsult()
            pn_ConsultArchiv.Visible = False
            lblChargement.Visible = False
            pn_chargeSt.Visible = True

            cn.Close()
            cn.Open()

            cmd = New SqlCommand("select capital from Grossiste", cn)
            cap = cmd.ExecuteScalar

            cn.Close()

            lblCap.Text = "Capital : " & cap & ""
            lblCap.Visible = True



        End If
    End Sub

    'Sub alimenterSocietes()

    '    cn.Close()
    '    cn.Open()
    '    cmd = New SqlCommand("select nomSoc from Societe where codeSoc <> 5", cn)
    '    dr = cmd.ExecuteReader

    '    Do While dr.Read
    '        cb_Societe.Items.Add(dr(0))
    '    Loop

    '    dr.Close()
    '    cn.Close()

    'End Sub


    Sub alimenterRecharges()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select desigPdt from Produit where codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Recharge')", cn)
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

        cmd = New SqlCommand("select desigPdt from Produit where codeCateg = (select codeCateg from CategoriePdt where typeCateg = 'Portable')", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub
    Sub alimenterPuces()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select desigPdt from Produit where codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Puce')", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub
    Sub alimenterModems()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("select desigPdt from Produit where codeCateg in (select codeCateg from CategoriePdt where typeCateg = 'Modem')", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cb_desigPdt.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub

    Private Sub RB_Recharge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Recharge.CheckedChanged

        If RB_Recharge.Checked = True Then

            lblChargement.Visible = False
            lblQteSt.Visible = False
            lblQteSt.Text = ""
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            alimenterRecharges()
            viderSoc()
            'alimenterSocietes()
            'cb_Societe.Visible = True
            txtQteCmd.Clear()
        End If
    End Sub

    Private Sub RB_Portable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Portable.CheckedChanged

        If RB_Portable.Checked = True Then

            lblChargement.Visible = False
            lblQteSt.Visible = False
            lblQteSt.Text = ""
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            alimenterPortables()
            viderSoc()
            'cb_Societe.Visible = False
            txtQteCmd.Clear()

        End If
    End Sub

    Private Sub RB_Puce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Puce.CheckedChanged
        If RB_Puce.Checked = True Then


            lblChargement.Visible = False
            lblQteSt.Visible = False
            lblQteSt.Text = ""
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            alimenterPuces()
            viderSoc()
            'alimenterSocietes()
            'cb_Societe.Visible = True
            txtQteCmd.Clear()
        End If
    End Sub

    Private Sub RB_Modem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Modem.CheckedChanged

        If RB_Modem.Checked = True Then

            lblChargement.Visible = False
            lblQteSt.Visible = False
            lblQteSt.Text = ""
            cb_desigPdt.Items.Clear()
            cb_desigPdt.Text = ""
            alimenterModems()
            viderSoc()
            'alimenterSocietes()
            'cb_Societe.Visible = True
            txtQteCmd.Clear()
        End If

    End Sub

    Private Sub BT_fermerR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_fermerAj.Click

        RB_Charger.Checked = False
        viderCharg()
        pn_chargeSt.Visible = False
        BT_fermerAj.Visible = False
    End Sub

    Private Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click


        If cb_desigPdt.SelectedItem <> Nothing And txtQteCmd.Text <> Nothing Then

            d = Date.Today
            cn.Close()
            cn.Open()

            cmd = New SqlCommand("select qteStock from Produit where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')", cn)
            qte = cmd.ExecuteScalar()
            SI = qte + txtQteCmd.Text

            cmd = New SqlCommand("select codePdt from ArchiveStock where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "') and YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
            codeP = cmd.ExecuteScalar

            cmd = New SqlCommand("select codePdt from AcheterPdt where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "') and YEAR(dateAchat) = " & d.Year & " and MONTH(dateAchat) = " & d.Month & " and DAY(dateAchat) = " & d.Day & "", cn)
            codePa = cmd.ExecuteScalar

            If codeP <> 0 Then

                cmd = New SqlCommand("update ArchiveStock set SI =  SI + " & txtQteCmd.Text & " , SF = SF + " & txtQteCmd.Text & " where codePdt = " & codeP & " and YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                cmd.ExecuteNonQuery()

            Else
               
                cmd = New SqlCommand("insert into ArchiveStock(codePdt,SI,SF,dateArch) values((select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & SI & "," & SI & ",getdate())", cn)
                cmd.ExecuteNonQuery()


            End If


            If codePa <> 0 Then

                cmd = New SqlCommand("update AcheterPdt set qteAchat = qteAchat + " & txtQteCmd.Text & " where codePdt = " & codeP & " and YEAR(dateAchat) = " & d.Year & " and MONTH(dateAchat) = " & d.Month & " and DAY(dateAchat) = " & d.Day & "", cn)
                cmd.ExecuteNonQuery()

            Else
                If RB_Portable.Checked = True Then

                    cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values(5,(select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & txtQteCmd.Text & ",getdate())", cn)
                    cmd.ExecuteNonQuery()

                Else

                    cmd = New SqlCommand("insert into AcheterPdt(codeSoc,codePdt,qteAchat,dateAchat) values((select  distinct codeSoc from AcheterPdt where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')),(select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')," & txtQteCmd.Text & ",getdate())", cn)
                    cmd.ExecuteNonQuery()

                End If
            End If


            qteNouv = txtQteCmd.Text

            cmd = New SqlCommand("select prixPdt * (1-(pourcentAchat/100)) from Produit  where codePdt = (select codePdt from Produit where desigPdt = '" & cb_desigPdt.Text & "')", cn)
            prix = cmd.ExecuteScalar

            prix = prix * qteNouv


            cmd = New SqlCommand("update Grossiste set capital = capital - " & prix & "", cn)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("select capital from Grossiste", cn)
            cap = cmd.ExecuteScalar

            lblCap.Text = "Capital : " & cap & ""
            lblCap.Visible = True


            cmd = New SqlCommand("update Produit set qteStock = " & SI & " where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "')", cn)
            cmd.ExecuteNonQuery()

           

            cn.Close()


            alimenterLblQte()
            lblChargement.Visible = True
            txtQteCmd.Text = ""

        Else

            MsgBox("vous dever remplir tous les champs afin de charger votre stock", MsgBoxStyle.Exclamation, MsgBoxStyle.OkCancel)

        End If

    End Sub

    Sub viderCharg()

        RB_Recharge.Checked = False
        RB_Modem.Checked = False
        RB_Portable.Checked = False
        RB_Puce.Checked = False
        viderPdt()
        viderSoc()
        txtQteCmd.Clear()
        lblQteSt.Visible = False
        lblQteSt.Text = ""
        lblChargement.Visible = False
        viderSoc()

    End Sub

    Sub viderPdt()

        cb_desigPdt.Items.Clear()
        cb_desigPdt.Text = ""

    End Sub

    Sub viderSoc()
        'cb_Societe.Items.Clear()
        'cb_Societe.Text = ""
    End Sub

    Private Sub GestStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        editStock.HeaderText = "Modifier"
        editStock.Text = "M"
        editStock.UseColumnTextForButtonValue = True
        editStock.Width = 69
        DataGridView1.Columns.Add(editStock)


        DataGridView1.Columns(5).Visible = False
        'viderSoc()
        'alimenterSocietes()

    End Sub

    Sub alimenterLblQte()

        cn.Close()
        cn.Open()
        cmd2 = New SqlCommand("select qteStock from Produit where codePdt = (select P.codePdt from Produit P where P.desigPdt = '" & cb_desigPdt.Text & "')", cn)
        qteS = cmd2.ExecuteScalar

        lblQteSt.Text = "Quantité en stock : " & qteS & " "
        lblQteSt.Visible = True

    End Sub

    Private Sub cb_desigPdt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_desigPdt.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtQteCmd.Select()
        End If
    End Sub

    Private Sub cb_desigPdt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_desigPdt.SelectedIndexChanged

        lblChargement.Visible = False
        alimenterLblQte()

    End Sub



    Private Sub BT_AnnulerR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_AnnulerR.Click
        viderCharg()
    End Sub

    Sub alimenter_Rech_DateArch()

        cn.Close()
        cn.Open()

        cmd = New SqlCommand("SELECT distinct dateArch FROM ArchiveStock ", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            Cb_Reche_Mois.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub


    Private Sub RB_Rechercher_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Consulter.CheckedChanged

        If RB_Consulter.Checked = True Then

            lblModifSt.Visible = False
            DataGridView1.Columns(5).Visible = False
            pn_chargeSt.Visible = False
            viderCharg()
            pn_ConsultArchiv.Visible = True
            BtFerRech.Visible = True
            cn.Close()
            cn.Open()

            cmd = New SqlCommand("select distinct YEAR(dateArch) from ArchiveStock where YEAR(dateArch) > 2011", cn)
            dr = cmd.ExecuteReader

            cbRechAn.Text = ""
            cbRechAn.Items.Clear()


            Do While dr.Read
                cbRechAn.Items.Add(dr(0))
            Loop

            dr.Close()

            cbRechAn.Visible = True
            lblAnnee.Visible = True

            'cmd = New SqlCommand("select distinct MONTH(dateArch) from ArchiveStock where YEAR(dateArch) > 2011", cn)
            'dr = cmd.ExecuteReader
            'Cb_Reche_Mois.Text = ""
            'Cb_Reche_Mois.Items.Clear()

            'Do While dr.Read
            '    convertNumMois(dr(0))
            'Loop

            'Cb_Reche_Mois.Visible = True
            'lblMois.Visible = True

            viderDG1()


        End If
    End Sub

    Sub convertNumMois(ByVal a As Integer)

        If a = 1 Then
            Cb_Reche_Mois.Items.Add("Janvier")
        ElseIf a = 2 Then
            Cb_Reche_Mois.Items.Add("Fevrier")
        ElseIf a = 3 Then
            Cb_Reche_Mois.Items.Add("Mars")
        ElseIf a = 4 Then
            Cb_Reche_Mois.Items.Add("Avril")
        ElseIf a = 5 Then
            Cb_Reche_Mois.Items.Add("Mai")
        ElseIf a = 6 Then
            Cb_Reche_Mois.Items.Add("Juin")
        ElseIf a = 7 Then
            Cb_Reche_Mois.Items.Add("Juillet")
        ElseIf a = 8 Then
            Cb_Reche_Mois.Items.Add("Aout")
        ElseIf a = 9 Then
            Cb_Reche_Mois.Items.Add("Septembre")
        ElseIf a = 10 Then
            Cb_Reche_Mois.Items.Add("Octobre")
        ElseIf a = 11 Then
            Cb_Reche_Mois.Items.Add("Novembre")
        ElseIf a = 12 Then
            Cb_Reche_Mois.Items.Add("Decembre")

        End If
    End Sub

    Private Sub Cb_Reche_Date_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Reche_Mois.SelectedIndexChanged

        lblModifSt.Visible = False
        viderDG1()
        convert_mois_en_num()
        lblJour.Visible = True
        cb_RechJour.Visible = True
        cb_RechJour.Items.Clear()
        cb_RechJour.Text = ""

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select distinct DAY(dateArch) from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & "  and  MONTH(dateArch) = " & cd & "", cn)
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            cb_RechJour.Items.Add(dr1(0))
        Loop

        dr1.Close()

        cmd = New SqlCommand("select distinct dateArch from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & "  and MONTH(dateArch) = " & cd & "", cn)
        dr1 = cmd.ExecuteReader

        Do While dr1.Read

            d = dr1(0)
            cmd = New SqlCommand("select * from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & "  and  MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)

            dr2 = cmd.ExecuteReader

            Do While dr2.Read

                codeP = dr2(1)
                d = dr2(4)

                cmd1 = New SqlCommand("select qteAchat from AcheterPdt where codePdt = " & codeP & " and YEAR(dateAchat) = " & d.Year & "  and MONTH(dateAchat) = " & d.Month & " and DAY(dateAchat) = " & d.Day & "", cn)
                ent = cmd1.ExecuteScalar

                cmd1 = New SqlCommand("select SI from ArchiveStock where codePdt = " & codeP & " and  YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                SI = cmd1.ExecuteScalar

                cmd1 = New SqlCommand("select SF from ArchiveStock where codePdt = " & codeP & " and YEAR(dateArch) = " & d.Year & " and  MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
                SF = cmd1.ExecuteScalar

                cmd1 = New SqlCommand("select desigPdt from Produit where codePdt = " & codeP & "", cn)
                desig = cmd1.ExecuteScalar

                cmd1 = New SqlCommand("select qteCmd from ContenirPdtCmd Cp, Commande C  where Cp.codePdt = " & codeP & " and C.numCmd= Cp.numCmd and YEAR(C.dateCmd)  = " & d.Year & " and  MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & "", cn)
                qte = cmd1.ExecuteScalar

                If qte <> 0 Then

                    cmd1 = New SqlCommand("select SUM(qteCmd) from ContenirPdtCmd Cp, Commande C  where Cp.codePdt = " & codeP & " and C.numCmd= Cp.numCmd and  YEAR(C.dateCmd)  = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & "", cn)
                    sort = cmd1.ExecuteScalar
                    x = {ent, desig, SI, SF, sort, d}

                Else
                    x = {ent, desig, SI, SF, 0, d}
                End If

                DataGridView1.Rows.Add(x)
                DataGridView1.Columns(5).Visible = True

            Loop

            dr2.Close()

        Loop

        dr1.Close()
        cn.Close()
       

        'dr.Close()
        'cn.Close()

    End Sub


    Sub viderConsult()

        viderDG1()
        cbRechAn.Items.Clear()
        cbRechAn.Text = ""
        Cb_Reche_Mois.Text = ""
        Cb_Reche_Mois.Items.Clear()
        Cb_Reche_Mois.Visible = False
        lblMois.Visible = False
        cb_RechJour.Text = ""
        cb_RechJour.Items.Clear()
        cb_RechJour.Visible = False
        lblJour.Visible = False

    End Sub

    Sub viderDG1()
        DataGridView1.Rows.Clear()
    End Sub


    Sub convert_mois_en_num()

        If Cb_Reche_Mois.Text = "Janvier" Then
            cd = 1
        ElseIf Cb_Reche_Mois.Text = "Fevrier" Then
            cd = 2
        ElseIf Cb_Reche_Mois.Text = "Mars" Then
            cd = 3
        ElseIf Cb_Reche_Mois.Text = "Avril" Then
            cd = 4
        ElseIf Cb_Reche_Mois.Text = "Mai" Then
            cd = 5
        ElseIf Cb_Reche_Mois.Text = "Juin" Then
            cd = 6
        ElseIf Cb_Reche_Mois.Text = "Juillet" Then
            cd = 7
        ElseIf Cb_Reche_Mois.Text = "Aout" Then
            cd = 8
        ElseIf Cb_Reche_Mois.Text = "Septembre" Then
            cd = 9
        ElseIf Cb_Reche_Mois.Text = "Octobre" Then
            cd = 10
        ElseIf Cb_Reche_Mois.Text = "Novembre" Then
            cd = 11
        ElseIf Cb_Reche_Mois.Text = "Decembre" Then
            cd = 12
        End If

    End Sub


    Private Sub cb_RechJour_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_RechJour.SelectedIndexChanged

        lblModifSt.Visible = False
        viderDG1()
        ' DataGridView1.Columns(5).Visible = False
        cn.Close()
        cn.Open()

        
        cmd = New SqlCommand("select * from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & "  and  MONTH(dateArch) = " & cd & " and DAY(dateArch) = " & cb_RechJour.Text & "", cn)
        dr2 = cmd.ExecuteReader

        Do While dr2.Read
            codeP = dr2(1)
            d = dr2(4)

            cmd1 = New SqlCommand("select qteAchat from AcheterPdt where codePdt = " & codeP & " and YEAR(dateAchat) = " & d.Year & " and MONTH(dateAchat) = " & d.Month & " and DAY(dateAchat) = " & d.Day & "", cn)
            ent = cmd1.ExecuteScalar

            cmd1 = New SqlCommand("select SI from ArchiveStock where codePdt = " & codeP & " and YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
            SI = cmd1.ExecuteScalar

            cmd1 = New SqlCommand("select SF from ArchiveStock where codePdt = " & codeP & " and YEAR(dateArch) = " & d.Year & " and MONTH(dateArch) = " & d.Month & " and DAY(dateArch) = " & d.Day & "", cn)
            SF = cmd1.ExecuteScalar

            cmd1 = New SqlCommand("select desigPdt from Produit where codePdt = " & codeP & "", cn)
            desig = cmd1.ExecuteScalar

            cmd1 = New SqlCommand("select qteCmd from ContenirPdtCmd Cp, Commande C  where Cp.codePdt = " & codeP & " and C.numCmd= Cp.numCmd and YEAR(C.dateCmd) = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & "", cn)
            qte = cmd1.ExecuteScalar

            If qte <> 0 Then



                cmd1 = New SqlCommand("select SUM(qteCmd) from ContenirPdtCmd Cp, Commande C  where Cp.codePdt = " & codeP & " and C.numCmd= Cp.numCmd and YEAR(C.dateCmd) = " & d.Year & " and MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & "", cn)
                sort = cmd1.ExecuteScalar

                x = {ent, desig, SI, SF, sort, d}

            Else
                x = {ent, desig, SI, SF, 0, d}
            End If

            DataGridView1.Rows.Add(x)

        Loop

        dr.Close()
        cn.Close()

    End Sub

    Private Sub txtQteCmd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQteCmd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btValider.Select()
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

    Private Sub BT_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Annuler.Click

        lblModifSt.Visible = False
        DataGridView1.Columns(5).Visible = False
        viderCharg()
        viderConsult()
        viderDG1()
        BT_fermerAj.Visible = False
        BtFerRech.Visible = False
        pn_chargeSt.Visible = False
        pn_ConsultArchiv.Visible = False
        RB_Charger.Checked = False
        RB_Consulter.Checked = False


    End Sub

    Private Sub BtFerRech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFerRech.Click

        DataGridView1.Columns(5).Visible = False
        viderConsult()
        BtFerRech.Visible = False
        pn_ConsultArchiv.Visible = False
        lblJour.Visible = False
        lblMois.Visible = False
        cb_RechJour.Visible = False
        Cb_Reche_Mois.Visible = False
        RB_Consulter.Checked = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        lblModifSt.Visible = False

        If Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem <> Nothing Then

            imprimerParJour()


        ElseIf Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem = Nothing Then

            imprimerParMois()

        End If



    End Sub


    Private Sub cbRechAn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRechAn.SelectedIndexChanged

        lblModifSt.Visible = False
        viderDG1()
        Cb_Reche_Mois.Items.Clear()
        Cb_Reche_Mois.Text = ""
        cb_RechJour.Items.Clear()
        cb_RechJour.Text = ""
        lblJour.Visible = False
        cb_RechJour.Visible = False
        lblMois.Visible = True
        Cb_Reche_Mois.Visible = True

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select distinct MONTH(dateArch) from ArchiveStock where YEAR(dateArch) = " & cbRechAn.Text & "", cn)
        dr = cmd.ExecuteReader
        Cb_Reche_Mois.Text = ""
        Cb_Reche_Mois.Items.Clear()

        Do While dr.Read
            convertNumMois(dr(0))
        Loop

        dr.Close()
        cn.Close()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        '    AncEnt = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value

        If e.ColumnIndex = 6 Then

            ent = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            d1 = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value
            desig = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value

            cn.Close()
            cn.Open()

            cmd = New SqlCommand("select qteAchat from AcheterPdt where  codePdt = (select codePdt from Produit where desigPdt = '" & desig & "') and YEAR(dateAchat) = " & d1.Year & " and MONTH(dateAchat) = " & d1.Month & " and DAY(dateAchat) = " & d1.Day & "", cn)
            AncEnt = cmd.ExecuteScalar

            qteS = AncEnt - ent

            cmd = New SqlCommand("select prixPdt * (1-(pourcentAchat/100)) from Produit  where codePdt = (select codePdt from Produit where desigPdt = '" & desig & "')", cn)
            prix = cmd.ExecuteScalar

            cmd = New SqlCommand("update AcheterPdt set qteAchat = " & ent & "  where codePdt = (select codePdt from Produit where desigPdt = '" & desig & "') and YEAR(dateAchat) = " & d1.Year & " and MONTH(dateAchat) = " & d1.Month & " and DAY(dateAchat) = " & d1.Day & "", cn)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("update ArchiveStock set SI = SI - " & qteS & "  where codePdt = (select codePdt from Produit where desigPdt = '" & desig & "') and YEAR(dateArch) = " & d1.Year & " and MONTH(dateArch) = " & d1.Month & " and DAY(dateArch) = " & d1.Day & "", cn)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("update ArchiveStock set SF = SF - " & qteS & " where codePdt = (select codePdt from Produit where desigPdt = '" & desig & "') and YEAR(dateArch) = " & d1.Year & " and MONTH(dateArch) = " & d1.Month & " and DAY(dateArch) = " & d1.Day & "", cn)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("update Produit set qteStock = qteStock - " & qteS & " where codePdt = (select codePdt from Produit where desigPdt = '" & desig & "')", cn)
            cmd.ExecuteNonQuery()


            mont = prix * qteS

            cmd = New SqlCommand("update Grossiste set capital = capital + " & mont & "", cn)
            cmd.ExecuteNonQuery()

            cn.Close()

            lblModifSt.Visible = True


        End If


    End Sub


    Private Sub RB_Recharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RB_Recharge.KeyDown
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

    Private Sub txtQteCmd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQteCmd.TextChanged

    End Sub

    Private Sub btValider_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btValider.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_desigPdt.Select()
        End If
    End Sub
End Class