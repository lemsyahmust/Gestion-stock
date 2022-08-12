<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestFactures
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
        Me.RB_Consulter = New System.Windows.Forms.RadioButton()
        Me.RB_Ajouter = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.numFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomRevend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montantHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tauxTVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montantTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.desigPdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qté = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prixU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prixTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_CreatFact = New System.Windows.Forms.Panel()
        Me.lblFactE = New System.Windows.Forms.Label()
        Me.lblFactc = New System.Windows.Forms.Label()
        Me.BT_AnnulerR = New System.Windows.Forms.Button()
        Me.txtNumFact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbNumCmd = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BT_Valider = New System.Windows.Forms.Button()
        Me.cb_Revendeur = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblsupf = New System.Windows.Forms.Label()
        Me.pn_RecherFact = New System.Windows.Forms.Panel()
        Me.Cb_Reche_numFact = New System.Windows.Forms.ComboBox()
        Me.Ck_NumFact = New System.Windows.Forms.CheckBox()
        Me.Cb_Reche_NumCmd = New System.Windows.Forms.ComboBox()
        Me.Ck_NumCmd = New System.Windows.Forms.CheckBox()
        Me.Cb_Reche_Date = New System.Windows.Forms.ComboBox()
        Me.Cb_Reche_Revendeur = New System.Windows.Forms.ComboBox()
        Me.Ck_Date = New System.Windows.Forms.CheckBox()
        Me.CK_Revend = New System.Windows.Forms.CheckBox()
        Me.bt_confirmer = New System.Windows.Forms.Button()
        Me.lblModif = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_CreatFact.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_RecherFact.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestion des factures"
        '
        'RB_Consulter
        '
        Me.RB_Consulter.AutoSize = True
        Me.RB_Consulter.Location = New System.Drawing.Point(589, 64)
        Me.RB_Consulter.Name = "RB_Consulter"
        Me.RB_Consulter.Size = New System.Drawing.Size(81, 17)
        Me.RB_Consulter.TabIndex = 30
        Me.RB_Consulter.Text = "Rechercher"
        Me.RB_Consulter.UseVisualStyleBackColor = True
        '
        'RB_Ajouter
        '
        Me.RB_Ajouter.AutoSize = True
        Me.RB_Ajouter.Location = New System.Drawing.Point(489, 64)
        Me.RB_Ajouter.Name = "RB_Ajouter"
        Me.RB_Ajouter.Size = New System.Drawing.Size(50, 17)
        Me.RB_Ajouter.TabIndex = 29
        Me.RB_Ajouter.Text = "Créer"
        Me.RB_Ajouter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numFact, Me.dateFact, Me.numCmd, Me.nomRevend, Me.montantHT, Me.tauxTVA, Me.montantTTC})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(913, 150)
        Me.DataGridView1.TabIndex = 31
        '
        'numFact
        '
        Me.numFact.HeaderText = "Numéro de facture"
        Me.numFact.Name = "numFact"
        '
        'dateFact
        '
        Me.dateFact.HeaderText = "Date"
        Me.dateFact.Name = "dateFact"
        '
        'numCmd
        '
        Me.numCmd.HeaderText = "Numéro de commande"
        Me.numCmd.Name = "numCmd"
        '
        'nomRevend
        '
        Me.nomRevend.HeaderText = "Référence"
        Me.nomRevend.Name = "nomRevend"
        '
        'montantHT
        '
        Me.montantHT.HeaderText = "Montant HT"
        Me.montantHT.Name = "montantHT"
        '
        'tauxTVA
        '
        Me.tauxTVA.HeaderText = "Taux TVA"
        Me.tauxTVA.Name = "tauxTVA"
        '
        'montantTTC
        '
        Me.montantTTC.HeaderText = "Montant TTC"
        Me.montantTTC.Name = "montantTTC"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desigPdt, Me.qté, Me.prixU, Me.prixTotal})
        Me.DataGridView2.Location = New System.Drawing.Point(29, 461)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(444, 150)
        Me.DataGridView2.TabIndex = 32
        '
        'desigPdt
        '
        Me.desigPdt.HeaderText = "Désignation"
        Me.desigPdt.Name = "desigPdt"
        '
        'qté
        '
        Me.qté.HeaderText = "Qté"
        Me.qté.Name = "qté"
        '
        'prixU
        '
        Me.prixU.HeaderText = "P.U/HT"
        Me.prixU.Name = "prixU"
        '
        'prixTotal
        '
        Me.prixTotal.HeaderText = "P.T/HT"
        Me.prixTotal.Name = "prixTotal"
        '
        'pn_CreatFact
        '
        Me.pn_CreatFact.Controls.Add(Me.lblFactE)
        Me.pn_CreatFact.Controls.Add(Me.lblFactc)
        Me.pn_CreatFact.Controls.Add(Me.BT_AnnulerR)
        Me.pn_CreatFact.Controls.Add(Me.txtNumFact)
        Me.pn_CreatFact.Controls.Add(Me.Label4)
        Me.pn_CreatFact.Controls.Add(Me.cbNumCmd)
        Me.pn_CreatFact.Controls.Add(Me.Label6)
        Me.pn_CreatFact.Controls.Add(Me.BT_Valider)
        Me.pn_CreatFact.Controls.Add(Me.cb_Revendeur)
        Me.pn_CreatFact.Controls.Add(Me.Label3)
        Me.pn_CreatFact.Controls.Add(Me.Label2)
        Me.pn_CreatFact.Location = New System.Drawing.Point(743, 442)
        Me.pn_CreatFact.Name = "pn_CreatFact"
        Me.pn_CreatFact.Size = New System.Drawing.Size(414, 298)
        Me.pn_CreatFact.TabIndex = 33
        Me.pn_CreatFact.Visible = False
        '
        'lblFactE
        '
        Me.lblFactE.AutoSize = True
        Me.lblFactE.Location = New System.Drawing.Point(163, 266)
        Me.lblFactE.Name = "lblFactE"
        Me.lblFactE.Size = New System.Drawing.Size(91, 13)
        Me.lblFactE.TabIndex = 44
        Me.lblFactE.Text = "Création echouée"
        Me.lblFactE.Visible = False
        '
        'lblFactc
        '
        Me.lblFactc.AutoSize = True
        Me.lblFactc.Location = New System.Drawing.Point(163, 266)
        Me.lblFactc.Name = "lblFactc"
        Me.lblFactc.Size = New System.Drawing.Size(131, 13)
        Me.lblFactc.TabIndex = 43
        Me.lblFactc.Text = "Facture crée avec succés"
        Me.lblFactc.Visible = False
        '
        'BT_AnnulerR
        '
        Me.BT_AnnulerR.Location = New System.Drawing.Point(215, 216)
        Me.BT_AnnulerR.Name = "BT_AnnulerR"
        Me.BT_AnnulerR.Size = New System.Drawing.Size(90, 24)
        Me.BT_AnnulerR.TabIndex = 9
        Me.BT_AnnulerR.Text = "Annuler"
        Me.BT_AnnulerR.UseVisualStyleBackColor = True
        '
        'txtNumFact
        '
        Me.txtNumFact.Location = New System.Drawing.Point(202, 68)
        Me.txtNumFact.Name = "txtNumFact"
        Me.txtNumFact.Size = New System.Drawing.Size(140, 20)
        Me.txtNumFact.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Numéro de la facture"
        '
        'cbNumCmd
        '
        Me.cbNumCmd.FormattingEnabled = True
        Me.cbNumCmd.Location = New System.Drawing.Point(202, 121)
        Me.cbNumCmd.Name = "cbNumCmd"
        Me.cbNumCmd.Size = New System.Drawing.Size(140, 21)
        Me.cbNumCmd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(119, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Création d'une facture"
        '
        'BT_Valider
        '
        Me.BT_Valider.Location = New System.Drawing.Point(122, 215)
        Me.BT_Valider.Name = "BT_Valider"
        Me.BT_Valider.Size = New System.Drawing.Size(80, 25)
        Me.BT_Valider.TabIndex = 4
        Me.BT_Valider.Text = "Valider"
        Me.BT_Valider.UseVisualStyleBackColor = True
        '
        'cb_Revendeur
        '
        Me.cb_Revendeur.FormattingEnabled = True
        Me.cb_Revendeur.Location = New System.Drawing.Point(202, 94)
        Me.cb_Revendeur.Name = "cb_Revendeur"
        Me.cb_Revendeur.Size = New System.Drawing.Size(140, 21)
        Me.cb_Revendeur.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Réference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numéro de la commande"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.dateCmd, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView3.Location = New System.Drawing.Point(29, 296)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(546, 150)
        Me.DataGridView3.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numéro de commande"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'dateCmd
        '
        Me.dateCmd.HeaderText = "Date"
        Me.dateCmd.Name = "dateCmd"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Numéro de facture"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Réference"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'lblsupf
        '
        Me.lblsupf.AutoSize = True
        Me.lblsupf.Location = New System.Drawing.Point(390, 411)
        Me.lblsupf.Name = "lblsupf"
        Me.lblsupf.Size = New System.Drawing.Size(168, 13)
        Me.lblsupf.TabIndex = 35
        Me.lblsupf.Text = "Suppression réalisée avec succés"
        Me.lblsupf.Visible = False
        '
        'pn_RecherFact
        '
        Me.pn_RecherFact.Controls.Add(Me.Cb_Reche_numFact)
        Me.pn_RecherFact.Controls.Add(Me.Ck_NumFact)
        Me.pn_RecherFact.Controls.Add(Me.Cb_Reche_NumCmd)
        Me.pn_RecherFact.Controls.Add(Me.Ck_NumCmd)
        Me.pn_RecherFact.Controls.Add(Me.Cb_Reche_Date)
        Me.pn_RecherFact.Controls.Add(Me.Cb_Reche_Revendeur)
        Me.pn_RecherFact.Controls.Add(Me.Ck_Date)
        Me.pn_RecherFact.Controls.Add(Me.CK_Revend)
        Me.pn_RecherFact.Controls.Add(Me.bt_confirmer)
        Me.pn_RecherFact.Location = New System.Drawing.Point(39, 98)
        Me.pn_RecherFact.Name = "pn_RecherFact"
        Me.pn_RecherFact.Size = New System.Drawing.Size(679, 116)
        Me.pn_RecherFact.TabIndex = 37
        Me.pn_RecherFact.Visible = False
        '
        'Cb_Reche_numFact
        '
        Me.Cb_Reche_numFact.FormattingEnabled = True
        Me.Cb_Reche_numFact.Location = New System.Drawing.Point(262, 10)
        Me.Cb_Reche_numFact.Name = "Cb_Reche_numFact"
        Me.Cb_Reche_numFact.Size = New System.Drawing.Size(160, 21)
        Me.Cb_Reche_numFact.TabIndex = 51
        Me.Cb_Reche_numFact.Visible = False
        '
        'Ck_NumFact
        '
        Me.Ck_NumFact.AutoSize = True
        Me.Ck_NumFact.Location = New System.Drawing.Point(58, 14)
        Me.Ck_NumFact.Name = "Ck_NumFact"
        Me.Ck_NumFact.Size = New System.Drawing.Size(169, 17)
        Me.Ck_NumFact.TabIndex = 50
        Me.Ck_NumFact.Text = "Rechercher par N° de Facture"
        Me.Ck_NumFact.UseVisualStyleBackColor = True
        '
        'Cb_Reche_NumCmd
        '
        Me.Cb_Reche_NumCmd.FormattingEnabled = True
        Me.Cb_Reche_NumCmd.Location = New System.Drawing.Point(262, 37)
        Me.Cb_Reche_NumCmd.Name = "Cb_Reche_NumCmd"
        Me.Cb_Reche_NumCmd.Size = New System.Drawing.Size(160, 21)
        Me.Cb_Reche_NumCmd.TabIndex = 49
        Me.Cb_Reche_NumCmd.Visible = False
        '
        'Ck_NumCmd
        '
        Me.Ck_NumCmd.AutoSize = True
        Me.Ck_NumCmd.Location = New System.Drawing.Point(58, 41)
        Me.Ck_NumCmd.Name = "Ck_NumCmd"
        Me.Ck_NumCmd.Size = New System.Drawing.Size(185, 17)
        Me.Ck_NumCmd.TabIndex = 48
        Me.Ck_NumCmd.Text = "Rechercher par N° de commande"
        Me.Ck_NumCmd.UseVisualStyleBackColor = True
        '
        'Cb_Reche_Date
        '
        Me.Cb_Reche_Date.FormattingEnabled = True
        Me.Cb_Reche_Date.Location = New System.Drawing.Point(262, 91)
        Me.Cb_Reche_Date.Name = "Cb_Reche_Date"
        Me.Cb_Reche_Date.Size = New System.Drawing.Size(160, 21)
        Me.Cb_Reche_Date.TabIndex = 47
        Me.Cb_Reche_Date.Visible = False
        '
        'Cb_Reche_Revendeur
        '
        Me.Cb_Reche_Revendeur.FormattingEnabled = True
        Me.Cb_Reche_Revendeur.Location = New System.Drawing.Point(262, 64)
        Me.Cb_Reche_Revendeur.Name = "Cb_Reche_Revendeur"
        Me.Cb_Reche_Revendeur.Size = New System.Drawing.Size(160, 21)
        Me.Cb_Reche_Revendeur.TabIndex = 46
        Me.Cb_Reche_Revendeur.Visible = False
        '
        'Ck_Date
        '
        Me.Ck_Date.AutoSize = True
        Me.Ck_Date.Location = New System.Drawing.Point(58, 95)
        Me.Ck_Date.Name = "Ck_Date"
        Me.Ck_Date.Size = New System.Drawing.Size(124, 17)
        Me.Ck_Date.TabIndex = 45
        Me.Ck_Date.Text = "Rechercher par date"
        Me.Ck_Date.UseVisualStyleBackColor = True
        '
        'CK_Revend
        '
        Me.CK_Revend.AutoSize = True
        Me.CK_Revend.Location = New System.Drawing.Point(58, 68)
        Me.CK_Revend.Name = "CK_Revend"
        Me.CK_Revend.Size = New System.Drawing.Size(151, 17)
        Me.CK_Revend.TabIndex = 44
        Me.CK_Revend.Text = "Rechercher par revendeur"
        Me.CK_Revend.UseVisualStyleBackColor = True
        '
        'bt_confirmer
        '
        Me.bt_confirmer.Location = New System.Drawing.Point(520, 24)
        Me.bt_confirmer.Name = "bt_confirmer"
        Me.bt_confirmer.Size = New System.Drawing.Size(104, 34)
        Me.bt_confirmer.TabIndex = 43
        Me.bt_confirmer.Text = "Valider"
        Me.bt_confirmer.UseVisualStyleBackColor = True
        '
        'lblModif
        '
        Me.lblModif.AutoSize = True
        Me.lblModif.Location = New System.Drawing.Point(421, 411)
        Me.lblModif.Name = "lblModif"
        Me.lblModif.Size = New System.Drawing.Size(100, 13)
        Me.lblModif.TabIndex = 38
        Me.lblModif.Text = "Modification réalisé "
        Me.lblModif.Visible = False
        '
        'GestFactures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 750)
        Me.Controls.Add(Me.lblModif)
        Me.Controls.Add(Me.pn_RecherFact)
        Me.Controls.Add(Me.lblsupf)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.pn_CreatFact)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RB_Consulter)
        Me.Controls.Add(Me.RB_Ajouter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GestFactures"
        Me.Text = "GestFactures"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_CreatFact.ResumeLayout(False)
        Me.pn_CreatFact.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_RecherFact.ResumeLayout(False)
        Me.pn_RecherFact.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_Consulter As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Ajouter As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents numFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numCmd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomRevend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montantHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tauxTVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montantTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents desigPdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qté As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prixU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prixTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pn_CreatFact As System.Windows.Forms.Panel
    Friend WithEvents txtNumFact As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbNumCmd As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BT_Valider As System.Windows.Forms.Button
    Friend WithEvents cb_Revendeur As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BT_AnnulerR As System.Windows.Forms.Button
    Friend WithEvents lblFactc As System.Windows.Forms.Label
    Friend WithEvents lblFactE As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateCmd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblsupf As System.Windows.Forms.Label
    Friend WithEvents pn_RecherFact As System.Windows.Forms.Panel
    Friend WithEvents bt_confirmer As System.Windows.Forms.Button
    Friend WithEvents Cb_Reche_numFact As System.Windows.Forms.ComboBox
    Friend WithEvents Ck_NumFact As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Reche_NumCmd As System.Windows.Forms.ComboBox
    Friend WithEvents Ck_NumCmd As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Reche_Date As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Reche_Revendeur As System.Windows.Forms.ComboBox
    Friend WithEvents Ck_Date As System.Windows.Forms.CheckBox
    Friend WithEvents CK_Revend As System.Windows.Forms.CheckBox
    Friend WithEvents lblModif As System.Windows.Forms.Label
End Class
