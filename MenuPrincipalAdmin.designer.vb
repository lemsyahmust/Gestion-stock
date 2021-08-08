<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipalAdmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RevendeurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CapitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RevendeurToolStripMenuItem
        '
        Me.RevendeurToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevendeurToolStripMenuItem.Name = "RevendeurToolStripMenuItem"
        Me.RevendeurToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RevendeurToolStripMenuItem.Text = "Revendeurs"
        '
        'ProduitToolStripMenuItem
        '
        Me.ProduitToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProduitToolStripMenuItem.Name = "ProduitToolStripMenuItem"
        Me.ProduitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ProduitToolStripMenuItem.Text = "Produits"
        '
        'CommandeToolStripMenuItem
        '
        Me.CommandeToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandeToolStripMenuItem.Name = "CommandeToolStripMenuItem"
        Me.CommandeToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CommandeToolStripMenuItem.Text = "Commandes"
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(66, 22)
        Me.QuiterToolStripMenuItem.Text = "Stock"
        '
        'ConsultationCAToolStripMenuItem
        '
        Me.ConsultationCAToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultationCAToolStripMenuItem.Name = "ConsultationCAToolStripMenuItem"
        Me.ConsultationCAToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.ConsultationCAToolStripMenuItem.Text = " CA"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(81, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RevendeurToolStripMenuItem, Me.ProduitToolStripMenuItem, Me.CommandeToolStripMenuItem, Me.QuiterToolStripMenuItem, Me.ConsultationCAToolStripMenuItem, Me.CapitalToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1095, 26)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CapitalToolStripMenuItem
        '
        Me.CapitalToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapitalToolStripMenuItem.Name = "CapitalToolStripMenuItem"
        Me.CapitalToolStripMenuItem.Size = New System.Drawing.Size(81, 22)
        Me.CapitalToolStripMenuItem.Text = "Capital"
        '
        'MenuPrincipalAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WA_GestStockTeleb.My.Resources.Resources.B3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1095, 582)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipalAdmin"
        Me.Text = "Menu principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RevendeurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProduitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultationCAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CapitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
