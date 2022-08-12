Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO.Stream
Imports System.IO.FileMode
Imports Microsoft.Office.Interop

Public Class ConsultationCA



    Private Sub ConsultationCA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pn_ConsultCA.Visible = True
        alimenterSocietes()

    End Sub
    Sub alimenterSocietes()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select nomSoc from Societe where codeSoc in ( select distinct codeSoc from AcheterPdt where YEAR(dateAchat) > 2011 )", cn)
        dr = cmd.ExecuteReader


        Do While dr.Read
            cbRechSoc.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()

    End Sub


    Sub alimenterSocietesParCli()

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select nomSoc from Societe where codeSoc in ( select distinct Cp.codeSoc from ContenirPdtCmd Cp , Commande C where C.numCmd = Cp.numCmd and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "'))", cn)
        dr = cmd.ExecuteReader


        Do While dr.Read
            cbRechSoc.Items.Add(dr(0))
        Loop

        dr.Close()
        cn.Close()



    End Sub

    'Sub alimenterSocietesParCli()

    '    cn.Close()
    '    cn.Open()
    '    cmd = New SqlCommand("select nomSoc from Societe where codeSoc = (select codeSoc from Societe ", cn)
    '    dr = cmd.ExecuteReader


    '    Do While dr.Read
    '        cbRechSoc.Items.Add(dr(0))
    '    Loop

    '    dr.Close()
    '    cn.Close()






    'End Sub


    Sub alimenterCB_Clients()

        cn.Close()
        cn.Open()
        cb_RechClient.Text = " "

        cmd = New SqlCommand("SELECT nomRevend FROM Revendeur where codeRevend in (select distinct codeRevend from Commande where etatP = 'p')", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read()
            cb_RechClient.Items.Add(dr(0))
        Loop
        dr.Close()
        cn.Close()

    End Sub

    Sub viderClients()

        cb_RechClient.Items.Clear()
        cb_RechClient.Text = ""
    End Sub

    Sub viderMois()

        Cb_Reche_Mois.Items.Clear()
        Cb_Reche_Mois.Text = ""


    End Sub

    Sub viderAnnee()

        cbRechAnnee.Items.Clear()
        cbRechAnnee.Text = ""

    End Sub

    Sub viderJour()

        cb_RechJour.Items.Clear()
        cb_RechJour.Text = ""


    End Sub

    Sub viderSoc()

        cbRechSoc.Items.Clear()
        cbRechSoc.Text = ""

    End Sub

    Private Sub Ck_Client_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_Client.CheckedChanged

        If Ck_Client.Checked = True Then

            LblCA.Visible = True
            LblDepenses.Visible = False

            DataGridView1.Visible = True
            DataGridView2.Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True


            viderDG1()
            CkDate.Checked = False

            ckRechSoc.Checked = False
            viderSoc()
            alimenterSocietes()
            cbRechSoc.Visible = False

            lblJour.Visible = False
            lblMois.Visible = False

            Cb_Reche_Mois.Visible = False

            cb_RechJour.Visible = False

            cb_RechClient.Visible = True

            viderClients()
            alimenterCB_Clients()


            'viderSoc()
            'alimenterSocietes()

        Else

            LblCA.Visible = False
            viderDG1()
            viderDG2()
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            viderClients()
            cb_RechClient.Visible = False
            cbRechAnnee.Visible = False
            viderAnnee()
            lblAnnee.Visible = False
            Cb_Reche_Mois.Visible = False
            viderMois()
            cb_RechJour.Visible = False
            viderJour()
            cbRechSoc.Visible = False
            viderSoc()
            lblMois.Visible = False
            lblJour.Visible = False

        End If
    End Sub

    Private Sub CkJour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkDate.CheckedChanged

        If CkDate.Checked = True Then

            Bt_Imprimer.Visible = False

            LblCA.Visible = True
            LblDepenses.Visible = False


            DataGridView1.Visible = True
            DataGridView2.Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False

            viderAnnee()
            viderJour()
            viderMois()

            viderDG1()
            Ck_Client.Checked = False
            cb_RechClient.Visible = False
            viderClients()

            ckRechSoc.Checked = False
            cbRechSoc.Visible = False
            viderSoc()


            cn.Close()
            cn.Open()

            cmd = New SqlCommand("select distinct YEAR(dateCmd) from Commande where etatP = 'p'", cn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                cbRechAnnee.Items.Add(dr(0))
            Loop

            dr.Close()

            

            lblJour.Visible = True
            lblMois.Visible = True
            lblAnnee.Visible = True

            cbRechAnnee.Visible = True
            Cb_Reche_Mois.Visible = True
            cb_RechJour.Visible = True

        Else

            LblCA.Visible = False
            viderDG1()
            DataGridView1.Visible = False
            viderMois()
            viderJour()
            viderAnnee()
            cbRechAnnee.Visible = False
            Cb_Reche_Mois.Visible = False
            cb_RechJour.Visible = False
            lblAnnee.Visible = False
            lblJour.Visible = False
            lblMois.Visible = False

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
    Private Sub cb_RechClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_RechClient.SelectedIndexChanged

        If cb_RechClient.SelectedItem <> Nothing Then

            viderAnnee()
            viderMois()
            viderJour()
            viderDG1()

            lblJour.Visible = True
            lblMois.Visible = True
            lblAnnee.Visible = True

            cbRechSoc.Visible = True
            cbRechAnnee.Visible = True
            Cb_Reche_Mois.Visible = True
            cb_RechJour.Visible = True

            cn.Close()
            cn.Open()


            cmd = New SqlCommand("select SUM(montantHT) from Commande where etatP = 'p' and codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
            mont = cmd.ExecuteScalar

            If mont <> 0 Then

                DataGridView2.Visible = False

                Dim ca As String() = {mont, "   --", cb_RechClient.Text}

                DataGridView1.Rows.Add(ca)

                cmd = New SqlCommand("select distinct YEAR(dateCmd) from Commande where etatP = 'p' and codeRevend = (select R.codeRevend from Revendeur R where R.nomRevend = '" & cb_RechClient.Text & "')", cn)
                dr = cmd.ExecuteReader

                Do While dr.Read
                    cbRechAnnee.Items.Add(dr(0))
                Loop
                dr.Close()

                viderSoc()
                alimenterSocietesParCli()


            End If


        End If

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


    Private Sub Cb_Reche_Mois_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Reche_Mois.SelectedIndexChanged

        If Cb_Reche_Mois.SelectedItem <> Nothing Then

            convert_mois_en_num()
            viderJour()

            viderDG1()

            cn.Close()
            cn.Open()

            If cbRechSoc.SelectedItem <> Nothing And cb_RechClient.SelectedItem = Nothing Then

                Bt_Imprimer.Visible = True

                DataGridView1.Visible = True
                DataGridView1.Columns(1).Visible = True
                DataGridView1.Columns(2).Visible = True

                cmd = New SqlCommand("select SUM(A.qteAchat * (P.prixPdt * (1-(P.pourcentAchat/100)))) from AcheterPdt A,Produit P where A.codePdt = P.codePdt and A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat) = " & cbRechAnnee.Text & "  and MONTH(A.dateAchat) = " & cd & "", cn)
                mont = cmd.ExecuteScalar

                x = {mont, Cb_Reche_Mois.Text, cbRechSoc.Text}
                DataGridView1.Rows.Add(x)

                cmd = New SqlCommand("select distinct DAY(dateAchat) from AcheterPdt  where codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(dateAchat) = " & cbRechAnnee.Text & " and MONTH(dateAchat) = " & cd & "", cn)
                dr1 = cmd.ExecuteReader()

                viderJour()
                Do While dr1.Read
                    cb_RechJour.Items.Add(dr1(0))
                Loop
                dr1.Close()

                'ElseIf cbRechSoc.SelectedItem <> Nothing And cb_RechClient.SelectedItem <> Nothing Then

                '    DataGridView1.Visible = False

                '    cmd = New SqlCommand("select SUM(Cp.totalPdt) from ContenirPdtCmd Cp, Commande C where C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
                '    mont = cmd.ExecuteScalar

            ElseIf cb_RechClient.SelectedItem <> Nothing And cbRechSoc.SelectedItem = Nothing Then

                DataGridView1.Visible = True
                Bt_Imprimer.Visible = True

                cmd = New SqlCommand("select SUM(C.montantHT) from Commande C where C.etatP = 'p' and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd) =  " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & "", cn)
                mont = cmd.ExecuteScalar

                cmd = New SqlCommand("select distinct DAY(C.dateCmd) from Commande C where  C.etatP = 'p' and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd) =  " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & "", cn)
                dr1 = cmd.ExecuteReader()

                viderJour()
                Do While dr1.Read
                    cb_RechJour.Items.Add(dr1(0))
                Loop
                dr1.Close()

                If mont <> 0 Then

                    cmd = New SqlCommand("select R.nomRevend from  Revendeur  R, Commande C where C.etatP = 'p' and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and R.nomRevend = '" & cb_RechClient.Text & "' and YEAR(C.dateCmd) = " & cbRechAnnee.Text & " and MONTH(C.dateCmd) =" & cd & "", cn)
                    nomR = cmd.ExecuteScalar
                    viderDG1()
                    DataGridView1.Rows.Add(mont, Cb_Reche_Mois.Text, nomR)

                Else
                    DataGridView1.Rows.Add(0, Cb_Reche_Mois.Text, nomR)
                End If

            ElseIf cb_RechClient.SelectedItem <> Nothing And cbRechSoc.SelectedItem <> Nothing Then

                Bt_Imprimer.Visible = True

                cmd = New SqlCommand("select SUM(Cp.totalPdt) from ContenirPdtCmd Cp , Commande C where  C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & "", cn)
                mont = cmd.ExecuteScalar

                cmd = New SqlCommand("select distinct DAY(C.dateCmd) from Commande C ,ContenirPdtCmd Cp where C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & "", cn)
                dr1 = cmd.ExecuteReader()

                viderJour()

                Do While dr1.Read
                    cb_RechJour.Items.Add(dr1(0))
                Loop
                dr1.Close()

                DataGridView2.Visible = True

                If mont <> 0 Then
                    viderDG2()
                    nomR = cb_RechClient.Text
                    nomSoc = cbRechSoc.Text
                    DataGridView2.Rows.Add(mont, nomR, nomSoc)

                Else
                    DataGridView2.Rows.Add(0, nomR, nomSoc)
                End If

            Else
                DataGridView1.Visible = True
                DataGridView1.Columns(2).Visible = False

                cmd = New SqlCommand("select SUM(C.montantHT) from Commande C where C.etatP = 'p' and  YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & "", cn)
                mont = cmd.ExecuteScalar

                Dim ca As String() = {mont, Cb_Reche_Mois.Text, "  --"}

                DataGridView1.Rows.Add(mont, Cb_Reche_Mois.Text)

                cmd = New SqlCommand("select distinct DAY(dateCmd) from Commande where etatP = 'p' and YEAR(dateCmd)  = " & cbRechAnnee.Text & " and  MONTH(dateCmd) = " & cd & "", cn)
                dr1 = cmd.ExecuteReader()


                Do While dr1.Read
                    cb_RechJour.Items.Add(dr1(0))
                Loop

                dr1.Close()
            End If

            End If
            cn.Close()
    End Sub

    Sub viderDG1()
        DataGridView1.Rows.Clear()
    End Sub

    Sub viderDG2()
        DataGridView2.Rows.Clear()
    End Sub


    Private Sub cb_RechJour_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_RechJour.SelectedIndexChanged

        Bt_Imprimer.Visible = False
        cn.Close()
        cn.Open()

        '   If Ck_Client.Checked = True And ckRechSoc.Checked = False Then
        If cb_RechClient.SelectedItem <> Nothing And cbRechAnnee.SelectedItem <> Nothing And Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem <> Nothing And cbRechSoc.SelectedItem = Nothing Then


            cmd = New SqlCommand("select SUM(C.montantHT) from Commande C where C.etatP = 'p' and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & " and DAY(C.dateCmd) = " & cb_RechJour.Text & "", cn)
            mont = cmd.ExecuteScalar

            If mont <> 0 Then

                cmd = New SqlCommand("select C.dateCmd,R.nomRevend from  Revendeur  R, Commande C where  C.etatP = 'p' and R.nomRevend = '" & cb_RechClient.Text & "' and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " and MONTH(C.dateCmd) = " & cd & " and DAY(C.dateCmd) = " & cb_RechJour.Text & "", cn)
                dr = cmd.ExecuteReader
                dr.Read()
                viderDG1()
                DataGridView1.Rows.Add(mont, dr(0), dr(1))

            End If
            dr.Close()

            'End If

            '  ElseIf ckRechSoc.Checked = True And Ck_Client.Checked = False Then

        ElseIf cb_RechClient.SelectedItem = Nothing And cbRechAnnee.SelectedItem <> Nothing And Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem <> Nothing And cbRechSoc.SelectedItem <> Nothing Then


            cmd = New SqlCommand("select SUM(A.qteAchat * (P.prixPdt * (1-(P.pourcentAchat/100)))) from AcheterPdt A,Produit P where A.codePdt = P.codePdt and A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat)  = " & cbRechAnnee.Text & " and MONTH(A.dateAchat) = " & cd & " and DAY(A.dateAchat) = " & cb_RechJour.Text & "", cn)
            mont = cmd.ExecuteScalar

            If mont <> 0 Then

                cmd = New SqlCommand("select A.dateAchat ,S.nomSoc from AcheterPdt A,Societe S where S.nomSoc = '" & cbRechSoc.Text & "' and A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat)  = " & cbRechAnnee.Text & " and MONTH(A.dateAchat) = " & cd & " and DAY(A.dateAchat) = " & cb_RechJour.Text & "", cn)
                dr = cmd.ExecuteReader
                dr.Read()
                viderDG1()
                DataGridView1.Rows.Add(mont, dr(0), dr(1))

            End If
            dr.Close()

            '   End If

        ElseIf cb_RechClient.SelectedItem <> Nothing And cbRechAnnee.SelectedItem <> Nothing And Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem <> Nothing And cbRechSoc.SelectedItem <> Nothing Then

            cmd = New SqlCommand("select  SUM(Cp.totalPdt) from ContenirPdtCmd Cp , Commande C  where  C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " and  MONTH(C.dateCmd) = " & cd & " and DAY(C.dateCmd) = " & cb_RechJour.Text & "", cn)
            mont = cmd.ExecuteScalar

            If mont <> 0 Then

                viderDG2()
                nomR = cb_RechClient.Text
                nomSoc = cbRechSoc.Text
                DataGridView2.Rows.Add(mont, nomR, nomSoc)

            Else
                DataGridView2.Rows.Add(0, nomR, nomSoc)
            End If



        Else


            cmd = New SqlCommand("select SUM(montantHT) from Commande  where  etatP = 'p' and YEAR(dateCmd)  = " & cbRechAnnee.Text & " and MONTH(dateCmd) = " & cd & " and DAY(dateCmd) = " & cb_RechJour.Text & "", cn)
            mont = cmd.ExecuteScalar


            If mont <> 0 Then

                cmd = New SqlCommand("select dateCmd from   Commande  where  etatP = 'p' and YEAR(dateCmd)  = " & cbRechAnnee.Text & " and MONTH(dateCmd) = " & cd & " and DAY(dateCmd) = " & cb_RechJour.Text & "", cn)
                d = cmd.ExecuteScalar

                viderDG1()
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Rows.Add(mont, d)

            End If

        End If

        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        Bt_Imprimer.Visible = False

        Ck_Client.Checked = False
        cb_RechClient.Visible = False
        viderClients()

        CkDate.Checked = False

        lblAnnee.Visible = False
        cbRechAnnee.Visible = False

        viderAnnee()

        lblMois.Visible = False
        Cb_Reche_Mois.Visible = False

        viderMois()

        lblJour.Visible = False
        viderJour()

        cb_RechJour.Visible = False
        ckRechSoc.Checked = False
        cbRechSoc.Visible = False
        LblDepenses.Visible = False
        LblCA.Visible = False

        viderSoc()
        alimenterSocietes()


        viderDG1()

    End Sub

    
    Private Sub ckRechSoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckRechSoc.CheckedChanged

        If ckRechSoc.Checked = True Then

            Bt_Imprimer.Visible = True

            DataGridView1.Visible = True

            LblCA.Visible = False
            LblDepenses.Visible = True
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            viderDG1()
            CkDate.Checked = False
            Ck_Client.Checked = False

            lblJour.Visible = False
            lblMois.Visible = False

            Cb_Reche_Mois.Visible = False
            viderMois()

            cb_RechJour.Visible = False
            viderJour()

            cb_RechClient.Visible = False
            viderClients()

            viderSoc()
            alimenterSocietes()
            cbRechSoc.Visible = True
        Else
            viderDG1()

            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True

            viderSoc()
            cbRechSoc.Visible = False
            Cb_Reche_Mois.Visible = False
            cbRechAnnee.Visible = False
            cb_RechJour.Visible = False
            viderJour()
            viderMois()
            viderAnnee()
            lblAnnee.Visible = False
            lblJour.Visible = False
            lblMois.Visible = False

        End If
    End Sub

    Private Sub cbRechSoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRechSoc.SelectedIndexChanged

        viderAnnee()
        cbRechAnnee.Visible = True
        lblAnnee.Visible = True
        viderMois()

        Bt_Imprimer.Visible = False
        viderJour()

        If cbRechSoc.SelectedItem <> Nothing And cb_RechClient.SelectedItem <> Nothing Then

            cn.Close()
            cn.Open()

            LblCA.Visible = False
            LblDepenses.Visible = False

            cmd = New SqlCommand("select SUM(Cp.totalPdt) from ContenirPdtCmd Cp, Commande C where C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
            mont = cmd.ExecuteScalar


            If mont <> 0 Then

                DataGridView1.Visible = False
                viderDG2()

                x = {mont, cb_RechClient.Text, cbRechSoc.Text}
                DataGridView2.Rows.Add(x)
                DataGridView2.Visible = True

            Else

                MsgBox("CA de ce client est nul", MsgBoxStyle.OkCancel)

            End If

            cmd = New SqlCommand("select distinct YEAR(C.dateCmd) from Commande C, ContenirPdtCmd Cp  where C.etatP = 'p' and  C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
            dr = cmd.ExecuteReader

            viderAnnee()

            Do While dr.Read
                cbRechAnnee.Items.Add(dr(0))
            Loop

            dr.Close()



            'cmd = New SqlCommand("select distinct MONTH(C.dateCmd) from Commande C, ContenirPdtCmd Cp  where C.etatP = 'p' and  C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
            'dr = cmd.ExecuteReader

            'viderMois()

            'Do While dr.Read
            '    convertNumMois(dr(0))

            'Loop
            'dr.Close()



        ElseIf cbRechSoc.SelectedItem <> Nothing And cb_RechClient.SelectedItem = Nothing Then

            cn.Close()
            cn.Open()
            viderDG1()
            cmd = New SqlCommand("select SUM(A.qteAchat * (P.prixPdt * (1-(P.pourcentAchat/100)))) as 'montantG' from AcheterPdt A, Produit P where A.codePdt = P.codePdt and A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat) > 2011", cn)
            mont = cmd.ExecuteScalar

            If mont <> 0 Then

                DataGridView2.Visible = False
                DataGridView1.Visible = True
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Rows.Add(mont)


            Else

                MsgBox("CA nul", MsgBoxStyle.OkCancel)

            End If


            viderAnnee()
            viderJour()
            viderMois()
            Cb_Reche_Mois.Visible = True
            cb_RechJour.Visible = True
            lblJour.Visible = True
            lblMois.Visible = True

            'cmd = New SqlCommand("select distinct MONTH(A.dateAchat) from AcheterPdt A where A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat) > 2011", cn)
            'dr = cmd.ExecuteReader

            'Do While dr.Read
            '    convertNumMois(dr(0))
            'Loop

            'dr.Close()

            cmd = New SqlCommand("select distinct YEAR(A.dateAchat) from AcheterPdt A where A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat) > 2011", cn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                cbRechAnnee.Items.Add(dr(0))
            Loop

            dr.Close()
            cn.Close()
        End If

    End Sub

    Sub imprimerCACliSoc_Mois()

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichCASocCliMois.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        ' Dim nbLigne As Integer

        convert_mois_en_num()

        Try

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select distinct C.dateCmd,C.numCmd from Commande C , ContenirPdtCmd Cp where C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and MONTH(C.dateCmd) = " & cd & "", cn)
            dr = cmd.ExecuteReader

            Dim z As Integer

            z = 8

            xlsheet.Cells(8, 1) = cb_RechClient.Text
            xlsheet.Cells(8, 2) = cbRechSoc.Text
            xlsheet.Cells(8, 3) = Cb_Reche_Mois.Text



            Do While dr.Read
                d = dr(0)
                cmd = New SqlCommand("select SUM(Cp.totalPdt) from ContenirPdtCmd Cp , Commande C where C.numCmd = Cp.numCmd and C.etatP = 'p' and C.numCmd = " & dr(1) & " and YEAR(C.dateCmd) = " & d.Year & " and  MONTH(C.dateCmd) = " & d.Month & " and DAY(C.dateCmd) = " & d.Day & " and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "')", cn)
                mont = cmd.ExecuteScalar

                xlsheet.Cells(z, 5) = d
                xlsheet.Cells(z, 6) = mont

                z = z + 1
            Loop

            cmd = New SqlCommand("select SUM(Cp.totalPdt) from ContenirPdtCmd Cp , Commande C  where C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "')  and MONTH(C.dateCmd) = " & cd & " and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
            montG = cmd.ExecuteScalar
            cn.Close()

            y = "    CA :"

            xlsheet.Cells(z + 1, 5) = y
            xlsheet.Cells(z + 1, 6) = montG


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

    Sub imprimerCACli_Mois()

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichCACli_Mois.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        ' Dim nbLigne As Integer

        convert_mois_en_num()

        Try

            cn.Close()
            cn.Open()
            cmd = New SqlCommand(" select distinct dateCmd from Commande  where  etatP = 'p' and codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(dateCmd) = " & cbRechAnnee.Text & " and MONTH(dateCmd) = " & cd & "", cn)
            dr = cmd.ExecuteReader

            Dim z As Integer

            z = 8

            xlsheet.Cells(8, 2) = cb_RechClient.Text
            xlsheet.Cells(8, 3) = Cb_Reche_Mois.Text



            Do While dr.Read
                d = dr(0)
                cmd = New SqlCommand("select SUM(montantHT) from Commande where etatP = 'p' and YEAR(dateCmd) = " & d.Year & " and  MONTH(dateCmd) = " & d.Month & " and DAY(dateCmd) = " & d.Day & " and codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
                mont = cmd.ExecuteScalar

                xlsheet.Cells(z, 5) = d
                xlsheet.Cells(z, 6) = mont

                z = z + 1
            Loop

            cmd = New SqlCommand("select SUM(montantHT) from Commande where etatP = 'p' and YEAR(dateCmd) = " & cbRechAnnee.Text & " and MONTH(dateCmd) = " & cd & " and codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
            montG = cmd.ExecuteScalar
            cn.Close()

            y = "    CA :"

            xlsheet.Cells(z + 1, 5) = y
            xlsheet.Cells(z + 1, 6) = montG


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

    Sub imprimerDepSoc_Mois()

        Dim xlApp As Excel.Application        ' application excel
        Dim xlBook As Excel.Workbook          ' Classeur excel
        Dim xlsheet As Excel.Worksheet        ' Feuille excel

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = xlApp.Workbooks.Open("C:\FichDepSoc_Mois.xlsx")
        xlsheet = CType(xlBook.Worksheets(1), Excel.Worksheet)

        ' Dim nbLigne As Integer

        convert_mois_en_num()

        Try

            cn.Close()
            cn.Open()
            cmd = New SqlCommand("select distinct dateAchat from AcheterPdt where codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(dateAchat) > 2011 and MONTH(dateAchat) = " & cd & "", cn)
            dr = cmd.ExecuteReader



            Dim z As Integer

            z = 8

            xlsheet.Cells(8, 2) = cbRechSoc.Text
            xlsheet.Cells(8, 3) = Cb_Reche_Mois.Text


            Do While dr.Read
                d = dr(0)
                cmd = New SqlCommand("select SUM(A.qteAchat * (P.prixPdt * (1-(P.pourcentAchat/100)))) from AcheterPdt A,Produit P where A.codePdt = P.codePdt and A.codeSoc =(select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(dateAchat) = " & cbRechAnnee.Text & " and MONTH(dateAchat) = " & cd & " and DAY(dateAchat) = " & d.Day & "", cn)
                mont = cmd.ExecuteScalar

                xlsheet.Cells(z, 5) = d
                xlsheet.Cells(z, 6) = mont

                z = z + 1
            Loop


            cmd = New SqlCommand("select SUM(A.qteAchat * (P.prixPdt * (1-(P.pourcentAchat/100)))) from AcheterPdt A,Produit P where A.codePdt = P.codePdt and A.codeSoc =(select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(dateAchat) = " & cbRechAnnee.Text & " and MONTH(dateAchat) = " & cd & " ", cn)
            montG = cmd.ExecuteScalar

            y = "   Dépenses :"

            xlsheet.Cells(z + 1, 5) = y
            xlsheet.Cells(z + 1, 6) = montG


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



    Private Sub Bt_Imprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Imprimer.Click

        If Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem = Nothing And cb_RechClient.SelectedItem <> Nothing And cbRechSoc.SelectedItem = Nothing Then

            imprimerCACli_Mois()

        ElseIf Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem = Nothing And cb_RechClient.SelectedItem = Nothing And cbRechSoc.SelectedItem <> Nothing Then

            imprimerDepSoc_Mois()

        ElseIf Cb_Reche_Mois.SelectedItem <> Nothing And cb_RechJour.SelectedItem = Nothing And cb_RechClient.SelectedItem <> Nothing And cbRechSoc.SelectedItem <> Nothing Then

            imprimerCACliSoc_Mois()

        End If

    End Sub

    Private Sub cbRechAnnee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRechAnnee.SelectedIndexChanged

        Cb_Reche_Mois.Visible = True
        lblMois.Visible = True


        cn.Close()
        cn.Open()

        If cb_RechClient.SelectedItem <> Nothing And cbRechSoc.SelectedItem = Nothing Then

            
           
            If cbRechAnnee.SelectedItem <> Nothing Then

                viderDG1()


                cmd = New SqlCommand("select distinct MONTH(dateCmd) from Commande where etatP = 'p' and YEAR(dateCmd) = " & cbRechAnnee.Text & " and codeRevend = (select R.codeRevend from Revendeur R where R.nomRevend = '" & cb_RechClient.Text & "')", cn)
                dr = cmd.ExecuteReader

                viderMois()
                viderJour()

                Do While dr.Read
                    convertNumMois(dr(0))
                Loop

                dr.Close()

                cmd = New SqlCommand("select SUM(C.montantHT) from Commande C where C.etatP = 'p' and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd) =  " & cbRechAnnee.Text & "", cn)
                mont = cmd.ExecuteScalar


                DataGridView1.Rows.Add(mont, cbRechAnnee.Text, cb_RechClient.Text)
                DataGridView1.Visible = True

            End If

        ElseIf cbRechSoc.SelectedItem <> Nothing And cb_RechClient.SelectedItem = Nothing Then

            If cbRechAnnee.SelectedItem <> Nothing Then

                viderDG1()


                cmd = New SqlCommand("select distinct MONTH(A.dateAchat) from AcheterPdt A where A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat) =" & cbRechAnnee.Text & "", cn)
                dr = cmd.ExecuteReader

                viderMois()
                viderJour()

                Do While dr.Read
                    convertNumMois(dr(0))
                Loop
                dr.Close()

                cmd = New SqlCommand("select SUM(A.qteAchat * (P.prixPdt * (1-(P.pourcentAchat/100)))) from AcheterPdt A,Produit P where A.codePdt = P.codePdt and A.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and YEAR(A.dateAchat) = " & cbRechAnnee.Text & "", cn)
                mont = cmd.ExecuteScalar

                x = {mont, cbRechAnnee.Text, cbRechSoc.Text}
                DataGridView1.Rows.Add(x)
                DataGridView1.Visible = True
            End If

        ElseIf cbRechSoc.SelectedItem <> Nothing And cb_RechClient.SelectedItem <> Nothing Then

            If cbRechAnnee.SelectedItem <> Nothing Then

                viderDG1()

                cmd = New SqlCommand("select distinct MONTH(C.dateCmd) from Commande C, ContenirPdtCmd Cp  where C.etatP = 'p' and  YEAR(C.dateCmd) = " & cbRechAnnee.Text & " and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "')", cn)
                dr = cmd.ExecuteReader

                viderMois()
                viderJour()

                Do While dr.Read
                    convertNumMois(dr(0))
                Loop

                dr.Close()

                cmd = New SqlCommand("select SUM(Cp.totalPdt) from ContenirPdtCmd Cp , Commande C where  C.etatP = 'p' and C.numCmd = Cp.numCmd and Cp.codeSoc = (select codeSoc from Societe where nomSoc = '" & cbRechSoc.Text & "') and C.codeRevend = (select codeRevend from Revendeur where nomRevend = '" & cb_RechClient.Text & "') and YEAR(C.dateCmd)  = " & cbRechAnnee.Text & " ", cn)
                mont = cmd.ExecuteScalar

                DataGridView2.Visible = True

                If mont <> 0 Then

                    viderDG2()
                    nomR = cb_RechClient.Text
                    nomSoc = cbRechSoc.Text
                    DataGridView2.Rows.Add(mont, nomR, nomSoc)

                Else
                    DataGridView2.Rows.Add(0, nomR, nomSoc)
                End If

            End If

        Else

            cmd = New SqlCommand("select  distinct MONTH(dateCmd) from Commande where  etatP = 'p' and YEAR(dateCmd) = " & cbRechAnnee.Text & "", cn)
            dr = cmd.ExecuteReader

            viderMois()
            viderJour()

            Do While dr.Read
                convertNumMois(dr(0))
            Loop

            dr.Close()

            cmd = New SqlCommand("select SUM(C.montantHT) from Commande C where C.etatP = 'p' and  YEAR(C.dateCmd)  = " & cbRechAnnee.Text & "", cn)
            mont = cmd.ExecuteScalar

            viderDG1()
            DataGridView1.Rows.Add(mont, cbRechAnnee.Text)

        End If
        cn.Close()

    End Sub

  
End Class