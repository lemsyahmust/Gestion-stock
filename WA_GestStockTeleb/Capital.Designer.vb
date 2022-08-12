<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capital
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValeur = New System.Windows.Forms.TextBox()
        Me.Bt_Valider = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblModif = New System.Windows.Forms.Label()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Garamond", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrez une valeur"
        '
        'txtValeur
        '
        Me.txtValeur.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValeur.Location = New System.Drawing.Point(734, 201)
        Me.txtValeur.Name = "txtValeur"
        Me.txtValeur.Size = New System.Drawing.Size(133, 33)
        Me.txtValeur.TabIndex = 1
        '
        'Bt_Valider
        '
        Me.Bt_Valider.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Valider.Location = New System.Drawing.Point(893, 199)
        Me.Bt_Valider.Name = "Bt_Valider"
        Me.Bt_Valider.Size = New System.Drawing.Size(86, 34)
        Me.Bt_Valider.TabIndex = 2
        Me.Bt_Valider.Text = "Valider"
        Me.Bt_Valider.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(694, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Capital"
        '
        'lblModif
        '
        Me.lblModif.AutoSize = True
        Me.lblModif.BackColor = System.Drawing.Color.Transparent
        Me.lblModif.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModif.Location = New System.Drawing.Point(609, 289)
        Me.lblModif.Name = "lblModif"
        Me.lblModif.Size = New System.Drawing.Size(370, 21)
        Me.lblModif.TabIndex = 4
        Me.lblModif.Text = "Modification du capital effectué avec succés"
        Me.lblModif.Visible = False
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblCap.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCap.Location = New System.Drawing.Point(638, 355)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(108, 32)
        Me.lblCap.TabIndex = 46
        Me.lblCap.Text = "Capital :"
        '
        'Capital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WA_GestStockTeleb.My.Resources.Resources.B3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1332, 670)
        Me.Controls.Add(Me.lblCap)
        Me.Controls.Add(Me.lblModif)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bt_Valider)
        Me.Controls.Add(Me.txtValeur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Capital"
        Me.Text = "Capital"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValeur As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Valider As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblModif As System.Windows.Forms.Label
    Friend WithEvents lblCap As System.Windows.Forms.Label
End Class
