<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultationCA
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
        Me.pn_ConsultCA = New System.Windows.Forms.Panel()
        Me.lblAnnee = New System.Windows.Forms.Label()
        Me.cbRechAnnee = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbRechSoc = New System.Windows.Forms.ComboBox()
        Me.ckRechSoc = New System.Windows.Forms.CheckBox()
        Me.cb_RechClient = New System.Windows.Forms.ComboBox()
        Me.CkDate = New System.Windows.Forms.CheckBox()
        Me.lblJour = New System.Windows.Forms.Label()
        Me.lblMois = New System.Windows.Forms.Label()
        Me.cb_RechJour = New System.Windows.Forms.ComboBox()
        Me.Cb_Reche_Mois = New System.Windows.Forms.ComboBox()
        Me.Ck_Client = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Somme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblCA = New System.Windows.Forms.Label()
        Me.LblDepenses = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Référence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Société = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bt_Imprimer = New System.Windows.Forms.Button()
        Me.pn_ConsultCA.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(752, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consultation du chiffre d'affaire et dépenses"
        '
        'pn_ConsultCA
        '
        Me.pn_ConsultCA.BackColor = System.Drawing.Color.Transparent
        Me.pn_ConsultCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_ConsultCA.Controls.Add(Me.lblAnnee)
        Me.pn_ConsultCA.Controls.Add(Me.cbRechAnnee)
        Me.pn_ConsultCA.Controls.Add(Me.Label8)
        Me.pn_ConsultCA.Controls.Add(Me.cbRechSoc)
        Me.pn_ConsultCA.Controls.Add(Me.ckRechSoc)
        Me.pn_ConsultCA.Controls.Add(Me.cb_RechClient)
        Me.pn_ConsultCA.Controls.Add(Me.CkDate)
        Me.pn_ConsultCA.Controls.Add(Me.lblJour)
        Me.pn_ConsultCA.Controls.Add(Me.lblMois)
        Me.pn_ConsultCA.Controls.Add(Me.cb_RechJour)
        Me.pn_ConsultCA.Controls.Add(Me.Cb_Reche_Mois)
        Me.pn_ConsultCA.Controls.Add(Me.Ck_Client)
        Me.pn_ConsultCA.Location = New System.Drawing.Point(323, 59)
        Me.pn_ConsultCA.Name = "pn_ConsultCA"
        Me.pn_ConsultCA.Size = New System.Drawing.Size(592, 146)
        Me.pn_ConsultCA.TabIndex = 40
        Me.pn_ConsultCA.Visible = False
        '
        'lblAnnee
        '
        Me.lblAnnee.AutoSize = True
        Me.lblAnnee.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnee.Location = New System.Drawing.Point(216, 48)
        Me.lblAnnee.Name = "lblAnnee"
        Me.lblAnnee.Size = New System.Drawing.Size(60, 18)
        Me.lblAnnee.TabIndex = 54
        Me.lblAnnee.Text = "Année"
        Me.lblAnnee.Visible = False
        '
        'cbRechAnnee
        '
        Me.cbRechAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechAnnee.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRechAnnee.FormattingEnabled = True
        Me.cbRechAnnee.Location = New System.Drawing.Point(291, 44)
        Me.cbRechAnnee.Name = "cbRechAnnee"
        Me.cbRechAnnee.Size = New System.Drawing.Size(87, 28)
        Me.cbRechAnnee.TabIndex = 53
        Me.cbRechAnnee.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 15)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Par :"
        '
        'cbRechSoc
        '
        Me.cbRechSoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechSoc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRechSoc.FormattingEnabled = True
        Me.cbRechSoc.Location = New System.Drawing.Point(416, 44)
        Me.cbRechSoc.Name = "cbRechSoc"
        Me.cbRechSoc.Size = New System.Drawing.Size(139, 28)
        Me.cbRechSoc.TabIndex = 44
        Me.cbRechSoc.Visible = False
        '
        'ckRechSoc
        '
        Me.ckRechSoc.AutoSize = True
        Me.ckRechSoc.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckRechSoc.Location = New System.Drawing.Point(397, 18)
        Me.ckRechSoc.Name = "ckRechSoc"
        Me.ckRechSoc.Size = New System.Drawing.Size(87, 22)
        Me.ckRechSoc.TabIndex = 43
        Me.ckRechSoc.Text = "Société"
        Me.ckRechSoc.UseVisualStyleBackColor = True
        '
        'cb_RechClient
        '
        Me.cb_RechClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RechClient.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RechClient.FormattingEnabled = True
        Me.cb_RechClient.Location = New System.Drawing.Point(26, 46)
        Me.cb_RechClient.Name = "cb_RechClient"
        Me.cb_RechClient.Size = New System.Drawing.Size(169, 28)
        Me.cb_RechClient.TabIndex = 42
        Me.cb_RechClient.Visible = False
        '
        'CkDate
        '
        Me.CkDate.AutoSize = True
        Me.CkDate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkDate.Location = New System.Drawing.Point(228, 18)
        Me.CkDate.Name = "CkDate"
        Me.CkDate.Size = New System.Drawing.Size(65, 22)
        Me.CkDate.TabIndex = 41
        Me.CkDate.Text = "Date"
        Me.CkDate.UseVisualStyleBackColor = True
        '
        'lblJour
        '
        Me.lblJour.AutoSize = True
        Me.lblJour.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJour.Location = New System.Drawing.Point(221, 106)
        Me.lblJour.Name = "lblJour"
        Me.lblJour.Size = New System.Drawing.Size(46, 18)
        Me.lblJour.TabIndex = 40
        Me.lblJour.Text = "Jour"
        Me.lblJour.Visible = False
        '
        'lblMois
        '
        Me.lblMois.AutoSize = True
        Me.lblMois.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMois.Location = New System.Drawing.Point(220, 78)
        Me.lblMois.Name = "lblMois"
        Me.lblMois.Size = New System.Drawing.Size(47, 18)
        Me.lblMois.TabIndex = 39
        Me.lblMois.Text = "Mois"
        Me.lblMois.Visible = False
        '
        'cb_RechJour
        '
        Me.cb_RechJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RechJour.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RechJour.FormattingEnabled = True
        Me.cb_RechJour.Location = New System.Drawing.Point(307, 102)
        Me.cb_RechJour.Name = "cb_RechJour"
        Me.cb_RechJour.Size = New System.Drawing.Size(55, 28)
        Me.cb_RechJour.TabIndex = 38
        Me.cb_RechJour.Visible = False
        '
        'Cb_Reche_Mois
        '
        Me.Cb_Reche_Mois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Reche_Mois.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Reche_Mois.FormattingEnabled = True
        Me.Cb_Reche_Mois.Location = New System.Drawing.Point(291, 74)
        Me.Cb_Reche_Mois.Name = "Cb_Reche_Mois"
        Me.Cb_Reche_Mois.Size = New System.Drawing.Size(87, 28)
        Me.Cb_Reche_Mois.TabIndex = 37
        Me.Cb_Reche_Mois.Visible = False
        '
        'Ck_Client
        '
        Me.Ck_Client.AutoSize = True
        Me.Ck_Client.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_Client.Location = New System.Drawing.Point(49, 18)
        Me.Ck_Client.Name = "Ck_Client"
        Me.Ck_Client.Size = New System.Drawing.Size(116, 22)
        Me.Ck_Client.TabIndex = 35
        Me.Ck_Client.Text = "Revendeur"
        Me.Ck_Client.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(605, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Somme, Me.DateD, Me.Client})
        Me.DataGridView1.Location = New System.Drawing.Point(449, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(341, 72)
        Me.DataGridView1.TabIndex = 41
        '
        'Somme
        '
        Me.Somme.HeaderText = "Somme"
        Me.Somme.Name = "Somme"
        '
        'DateD
        '
        Me.DateD.HeaderText = "Date"
        Me.DateD.Name = "DateD"
        '
        'Client
        '
        Me.Client.HeaderText = "Référence"
        Me.Client.Name = "Client"
        '
        'LblCA
        '
        Me.LblCA.AutoSize = True
        Me.LblCA.BackColor = System.Drawing.Color.Transparent
        Me.LblCA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCA.Location = New System.Drawing.Point(369, 255)
        Me.LblCA.Name = "LblCA"
        Me.LblCA.Size = New System.Drawing.Size(28, 15)
        Me.LblCA.TabIndex = 44
        Me.LblCA.Text = "CA :"
        Me.LblCA.Visible = False
        '
        'LblDepenses
        '
        Me.LblDepenses.AutoSize = True
        Me.LblDepenses.BackColor = System.Drawing.Color.Transparent
        Me.LblDepenses.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepenses.Location = New System.Drawing.Point(357, 255)
        Me.LblDepenses.Name = "LblDepenses"
        Me.LblDepenses.Size = New System.Drawing.Size(95, 18)
        Me.LblDepenses.TabIndex = 45
        Me.LblDepenses.Text = "Dépenses :"
        Me.LblDepenses.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CA, Me.Référence, Me.Société})
        Me.DataGridView2.Location = New System.Drawing.Point(449, 314)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(341, 75)
        Me.DataGridView2.TabIndex = 46
        Me.DataGridView2.Visible = False
        '
        'CA
        '
        Me.CA.HeaderText = "CA"
        Me.CA.Name = "CA"
        '
        'Référence
        '
        Me.Référence.HeaderText = "Référence"
        Me.Référence.Name = "Référence"
        '
        'Société
        '
        Me.Société.HeaderText = "Société"
        Me.Société.Name = "Société"
        Me.Société.Width = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "CA :"
        Me.Label2.Visible = False
        '
        'Bt_Imprimer
        '
        Me.Bt_Imprimer.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Imprimer.Location = New System.Drawing.Point(584, 417)
        Me.Bt_Imprimer.Name = "Bt_Imprimer"
        Me.Bt_Imprimer.Size = New System.Drawing.Size(119, 30)
        Me.Bt_Imprimer.TabIndex = 48
        Me.Bt_Imprimer.Text = "Imprimer"
        Me.Bt_Imprimer.UseVisualStyleBackColor = True
        Me.Bt_Imprimer.Visible = False
        '
        'ConsultationCA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WA_GestStockTeleb.My.Resources.Resources.B3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.Bt_Imprimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.LblDepenses)
        Me.Controls.Add(Me.LblCA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pn_ConsultCA)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ConsultationCA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pn_ConsultCA.ResumeLayout(False)
        Me.pn_ConsultCA.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pn_ConsultCA As System.Windows.Forms.Panel
    Friend WithEvents lblJour As System.Windows.Forms.Label
    Friend WithEvents lblMois As System.Windows.Forms.Label
    Friend WithEvents cb_RechJour As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Reche_Mois As System.Windows.Forms.ComboBox
    Friend WithEvents Ck_Client As System.Windows.Forms.CheckBox
    Friend WithEvents CkDate As System.Windows.Forms.CheckBox
    Friend WithEvents cb_RechClient As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbRechSoc As System.Windows.Forms.ComboBox
    Friend WithEvents ckRechSoc As System.Windows.Forms.CheckBox
    Friend WithEvents Somme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Client As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblCA As System.Windows.Forms.Label
    Friend WithEvents LblDepenses As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents CA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Référence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Société As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bt_Imprimer As System.Windows.Forms.Button
    Friend WithEvents lblAnnee As System.Windows.Forms.Label
    Friend WithEvents cbRechAnnee As System.Windows.Forms.ComboBox
End Class
