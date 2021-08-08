Public Class MenuPrincipalAdmin

    

    Private Sub MenuPrincipalAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Authentification.Hide()
        GestCommandes.AutoScroll = True


    End Sub

    Private Sub RevendeurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevendeurToolStripMenuItem.Click


        '   GestClients = Me.ActiveMdiChild
        GestClients.MdiParent = Nothing
        GestClients.MdiParent = Me
        GestClients.Show()

   

    End Sub


    Private Sub ProduitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProduitToolStripMenuItem.Click

        GestProduits.MdiParent = Nothing
        GestProduits.MdiParent = Me
        GestProduits.Show()

    End Sub

    Private Sub CommandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandeToolStripMenuItem.Click

        GestCommandes.MdiParent = Nothing
        GestCommandes.MdiParent = Me
        GestCommandes.Show()
        GestCommandes.AutoScroll = True
    End Sub



    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End

    End Sub

    Private Sub QuiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuiterToolStripMenuItem.Click

        GestStock.MdiParent = Nothing
        GestStock.MdiParent = Me
        GestStock.Show()

    End Sub

    Private Sub ConsultationCAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationCAToolStripMenuItem.Click

        ConsultationCA.MdiParent = Nothing
        ConsultationCA.MdiParent = Me
        ConsultationCA.Show()

    End Sub

    Private Sub CapitalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapitalToolStripMenuItem.Click

        Capital.MdiParent = Nothing
        Capital.MdiParent = Me
        Capital.Show()

    End Sub
End Class