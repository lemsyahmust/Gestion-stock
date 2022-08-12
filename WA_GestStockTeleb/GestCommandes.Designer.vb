<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestCommandes
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestCommandes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RB_Ajouter = New System.Windows.Forms.RadioButton()
        Me.RB_Consulter = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.numCmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomRevend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montantHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.numCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desigPdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qteCmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prixVente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BT_fermerDG2 = New System.Windows.Forms.Button()
        Me.pn_CreatCmd = New System.Windows.Forms.Panel()
        Me.BtFerC = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.lblCreditDH = New System.Windows.Forms.Label()
        Me.lblCmdc = New System.Windows.Forms.Label()
        Me.lblCmdE = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BT_Valider = New System.Windows.Forms.Button()
        Me.cb_Revendeur = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pn_RempCmd = New System.Windows.Forms.Panel()
        Me.txtPv = New System.Windows.Forms.TextBox()
        Me.lblPVente = New System.Windows.Forms.Label()
        Me.BtPayer = New System.Windows.Forms.Button()
        Me.LblMA = New System.Windows.Forms.Label()
        Me.lblQteSt = New System.Windows.Forms.Label()
        Me.RB_Modem = New System.Windows.Forms.RadioButton()
        Me.RB_Puce = New System.Windows.Forms.RadioButton()
        Me.RB_Portable = New System.Windows.Forms.RadioButton()
        Me.RB_Recharge = New System.Windows.Forms.RadioButton()
        Me.btValider = New System.Windows.Forms.Button()
        Me.BT_fermerR = New System.Windows.Forms.Button()
        Me.lblAjout = New System.Windows.Forms.Label()
        Me.BT_AnnulerR = New System.Windows.Forms.Button()
        Me.txtQteCmd = New System.Windows.Forms.TextBox()
        Me.cb_desigPdt = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CK_Revend = New System.Windows.Forms.CheckBox()
        Me.Ck_Date = New System.Windows.Forms.CheckBox()
        Me.pn_RecherCmd = New System.Windows.Forms.Panel()
        Me.lblPar = New System.Windows.Forms.Label()
        Me.BtFermerRech = New System.Windows.Forms.Button()
        Me.Cb_Reche_NumCmd = New System.Windows.Forms.ComboBox()
        Me.Ck_NumCmd = New System.Windows.Forms.CheckBox()
        Me.BtVlider = New System.Windows.Forms.Button()
        Me.Cb_Reche_Date = New System.Windows.Forms.ComboBox()
        Me.Cb_Reche_Revend = New System.Windows.Forms.ComboBox()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.lblSuppe = New System.Windows.Forms.Label()
        Me.lblModifDC = New System.Windows.Forms.Label()
        Me.lblModifDCe = New System.Windows.Forms.Label()
        Me.lblRetPdt = New System.Windows.Forms.Label()
        Me.lblRetech = New System.Windows.Forms.Label()
        Me.PnPaiement = New System.Windows.Forms.Panel()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.Bt_Imprimer = New System.Windows.Forms.Button()
        Me.BtFerP = New System.Windows.Forms.Button()
        Me.lblMontant = New System.Windows.Forms.Label()
        Me.lblRestePaieDH = New System.Windows.Forms.Label()
        Me.lblManque = New System.Windows.Forms.Label()
        Me.txtReste = New System.Windows.Forms.TextBox()
        Me.lblReste = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblPaie = New System.Windows.Forms.Label()
        Me.txtDonner = New System.Windows.Forms.TextBox()
        Me.Bt_Donner = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblMp = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_CreatCmd.SuspendLayout()
        Me.pn_RempCmd.SuspendLayout()
        Me.pn_RecherCmd.SuspendLayout()
        Me.PnPaiement.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestion des commandes"
        '
        'RB_Ajouter
        '
        Me.RB_Ajouter.AutoSize = True
        Me.RB_Ajouter.BackColor = System.Drawing.Color.Transparent
        Me.RB_Ajouter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ajouter.Location = New System.Drawing.Point(529, 63)
        Me.RB_Ajouter.Name = "RB_Ajouter"
        Me.RB_Ajouter.Size = New System.Drawing.Size(88, 22)
        Me.RB_Ajouter.TabIndex = 25
        Me.RB_Ajouter.Text = "Ajouter"
        Me.RB_Ajouter.UseVisualStyleBackColor = False
        '
        'RB_Consulter
        '
        Me.RB_Consulter.AutoSize = True
        Me.RB_Consulter.BackColor = System.Drawing.Color.Transparent
        Me.RB_Consulter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Consulter.Location = New System.Drawing.Point(632, 63)
        Me.RB_Consulter.Name = "RB_Consulter"
        Me.RB_Consulter.Size = New System.Drawing.Size(107, 22)
        Me.RB_Consulter.TabIndex = 28
        Me.RB_Consulter.Text = "Consulter"
        Me.RB_Consulter.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numCmd, Me.dateCmd, Me.nomRevend, Me.montantHT})
        Me.DataGridView1.Location = New System.Drawing.Point(1, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(793, 192)
        Me.DataGridView1.TabIndex = 29
        '
        'numCmd
        '
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCmd.DefaultCellStyle = DataGridViewCellStyle17
        Me.numCmd.HeaderText = "Numéro de commande"
        Me.numCmd.Name = "numCmd"
        '
        'dateCmd
        '
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCmd.DefaultCellStyle = DataGridViewCellStyle18
        Me.dateCmd.HeaderText = "Date"
        Me.dateCmd.Name = "dateCmd"
        '
        'nomRevend
        '
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomRevend.DefaultCellStyle = DataGridViewCellStyle19
        Me.nomRevend.HeaderText = "Réference"
        Me.nomRevend.Name = "nomRevend"
        '
        'montantHT
        '
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montantHT.DefaultCellStyle = DataGridViewCellStyle20
        Me.montantHT.HeaderText = "Montant HT"
        Me.montantHT.Name = "montantHT"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numCd, Me.desigPdt, Me.qteCmd, Me.prixVente, Me.Column1})
        Me.DataGridView2.Location = New System.Drawing.Point(798, 231)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(574, 192)
        Me.DataGridView2.TabIndex = 30
        '
        'numCd
        '
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCd.DefaultCellStyle = DataGridViewCellStyle21
        Me.numCd.HeaderText = "Numéro de commande"
        Me.numCd.Name = "numCd"
        Me.numCd.Width = 80
        '
        'desigPdt
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desigPdt.DefaultCellStyle = DataGridViewCellStyle22
        Me.desigPdt.HeaderText = "Désignation"
        Me.desigPdt.Name = "desigPdt"
        Me.desigPdt.Width = 80
        '
        'qteCmd
        '
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qteCmd.DefaultCellStyle = DataGridViewCellStyle23
        Me.qteCmd.HeaderText = "Quantité commanndée"
        Me.qteCmd.Name = "qteCmd"
        Me.qteCmd.Width = 80
        '
        'prixVente
        '
        Me.prixVente.HeaderText = "Prix de vente"
        Me.prixVente.Name = "prixVente"
        Me.prixVente.Width = 80
        '
        'Column1
        '
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle24
        Me.Column1.HeaderText = "Quantité en stock"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'BT_fermerDG2
        '
        Me.BT_fermerDG2.Image = CType(resources.GetObject("BT_fermerDG2.Image"), System.Drawing.Image)
        Me.BT_fermerDG2.Location = New System.Drawing.Point(1348, 231)
        Me.BT_fermerDG2.Name = "BT_fermerDG2"
        Me.BT_fermerDG2.Size = New System.Drawing.Size(24, 24)
        Me.BT_fermerDG2.TabIndex = 31
        Me.BT_fermerDG2.UseVisualStyleBackColor = True
        '
        'pn_CreatCmd
        '
        Me.pn_CreatCmd.BackColor = System.Drawing.Color.Transparent
        Me.pn_CreatCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_CreatCmd.Controls.Add(Me.BtFerC)
        Me.pn_CreatCmd.Controls.Add(Me.BtAnnuler)
        Me.pn_CreatCmd.Controls.Add(Me.lblCreditDH)
        Me.pn_CreatCmd.Controls.Add(Me.lblCmdc)
        Me.pn_CreatCmd.Controls.Add(Me.lblCmdE)
        Me.pn_CreatCmd.Controls.Add(Me.Label6)
        Me.pn_CreatCmd.Controls.Add(Me.BT_Valider)
        Me.pn_CreatCmd.Controls.Add(Me.cb_Revendeur)
        Me.pn_CreatCmd.Controls.Add(Me.Label3)
        Me.pn_CreatCmd.Location = New System.Drawing.Point(801, 27)
        Me.pn_CreatCmd.Name = "pn_CreatCmd"
        Me.pn_CreatCmd.Size = New System.Drawing.Size(454, 169)
        Me.pn_CreatCmd.TabIndex = 32
        Me.pn_CreatCmd.Visible = False
        '
        'BtFerC
        '
        Me.BtFerC.Image = CType(resources.GetObject("BtFerC.Image"), System.Drawing.Image)
        Me.BtFerC.Location = New System.Drawing.Point(506, -2)
        Me.BtFerC.Name = "BtFerC"
        Me.BtFerC.Size = New System.Drawing.Size(24, 24)
        Me.BtFerC.TabIndex = 48
        Me.BtFerC.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAnnuler.Location = New System.Drawing.Point(272, 100)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(95, 28)
        Me.BtAnnuler.TabIndex = 45
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'lblCreditDH
        '
        Me.lblCreditDH.AutoSize = True
        Me.lblCreditDH.BackColor = System.Drawing.Color.Maroon
        Me.lblCreditDH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreditDH.Location = New System.Drawing.Point(8, 119)
        Me.lblCreditDH.Name = "lblCreditDH"
        Me.lblCreditDH.Size = New System.Drawing.Size(85, 25)
        Me.lblCreditDH.TabIndex = 44
        Me.lblCreditDH.Text = "cred DH"
        Me.lblCreditDH.Visible = False
        '
        'lblCmdc
        '
        Me.lblCmdc.AutoSize = True
        Me.lblCmdc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCmdc.Location = New System.Drawing.Point(176, 133)
        Me.lblCmdc.Name = "lblCmdc"
        Me.lblCmdc.Size = New System.Drawing.Size(187, 19)
        Me.lblCmdc.TabIndex = 42
        Me.lblCmdc.Text = "Commande crée avec succés"
        Me.lblCmdc.Visible = False
        '
        'lblCmdE
        '
        Me.lblCmdE.AutoSize = True
        Me.lblCmdE.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmdE.Location = New System.Drawing.Point(200, 135)
        Me.lblCmdE.Name = "lblCmdE"
        Me.lblCmdE.Size = New System.Drawing.Size(114, 17)
        Me.lblCmdE.TabIndex = 43
        Me.lblCmdE.Text = "Création echouée"
        Me.lblCmdE.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(146, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ajout d'une commande"
        '
        'BT_Valider
        '
        Me.BT_Valider.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Valider.Location = New System.Drawing.Point(180, 100)
        Me.BT_Valider.Name = "BT_Valider"
        Me.BT_Valider.Size = New System.Drawing.Size(86, 28)
        Me.BT_Valider.TabIndex = 4
        Me.BT_Valider.Text = "Valider"
        Me.BT_Valider.UseVisualStyleBackColor = True
        '
        'cb_Revendeur
        '
        Me.cb_Revendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Revendeur.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Revendeur.FormattingEnabled = True
        Me.cb_Revendeur.Location = New System.Drawing.Point(174, 57)
        Me.cb_Revendeur.Name = "cb_Revendeur"
        Me.cb_Revendeur.Size = New System.Drawing.Size(183, 29)
        Me.cb_Revendeur.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Réference"
        '
        'pn_RempCmd
        '
        Me.pn_RempCmd.BackColor = System.Drawing.Color.Transparent
        Me.pn_RempCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_RempCmd.Controls.Add(Me.txtPv)
        Me.pn_RempCmd.Controls.Add(Me.lblPVente)
        Me.pn_RempCmd.Controls.Add(Me.BtPayer)
        Me.pn_RempCmd.Controls.Add(Me.LblMA)
        Me.pn_RempCmd.Controls.Add(Me.lblQteSt)
        Me.pn_RempCmd.Controls.Add(Me.RB_Modem)
        Me.pn_RempCmd.Controls.Add(Me.RB_Puce)
        Me.pn_RempCmd.Controls.Add(Me.RB_Portable)
        Me.pn_RempCmd.Controls.Add(Me.RB_Recharge)
        Me.pn_RempCmd.Controls.Add(Me.btValider)
        Me.pn_RempCmd.Controls.Add(Me.BT_fermerR)
        Me.pn_RempCmd.Controls.Add(Me.lblAjout)
        Me.pn_RempCmd.Controls.Add(Me.BT_AnnulerR)
        Me.pn_RempCmd.Controls.Add(Me.txtQteCmd)
        Me.pn_RempCmd.Controls.Add(Me.cb_desigPdt)
        Me.pn_RempCmd.Controls.Add(Me.Label5)
        Me.pn_RempCmd.Controls.Add(Me.Label4)
        Me.pn_RempCmd.Controls.Add(Me.Label7)
        Me.pn_RempCmd.Location = New System.Drawing.Point(735, 475)
        Me.pn_RempCmd.Name = "pn_RempCmd"
        Me.pn_RempCmd.Size = New System.Drawing.Size(567, 255)
        Me.pn_RempCmd.TabIndex = 33
        Me.pn_RempCmd.Visible = False
        '
        'txtPv
        '
        Me.txtPv.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPv.Location = New System.Drawing.Point(214, 136)
        Me.txtPv.Name = "txtPv"
        Me.txtPv.Size = New System.Drawing.Size(110, 27)
        Me.txtPv.TabIndex = 43
        '
        'lblPVente
        '
        Me.lblPVente.AutoSize = True
        Me.lblPVente.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPVente.Location = New System.Drawing.Point(4, 140)
        Me.lblPVente.Name = "lblPVente"
        Me.lblPVente.Size = New System.Drawing.Size(116, 18)
        Me.lblPVente.TabIndex = 42
        Me.lblPVente.Text = "Prix de vente"
        '
        'BtPayer
        '
        Me.BtPayer.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPayer.Location = New System.Drawing.Point(98, 170)
        Me.BtPayer.Name = "BtPayer"
        Me.BtPayer.Size = New System.Drawing.Size(80, 27)
        Me.BtPayer.TabIndex = 41
        Me.BtPayer.Text = "Payer"
        Me.BtPayer.UseVisualStyleBackColor = True
        Me.BtPayer.Visible = False
        '
        'LblMA
        '
        Me.LblMA.AutoSize = True
        Me.LblMA.BackColor = System.Drawing.Color.Maroon
        Me.LblMA.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMA.Location = New System.Drawing.Point(47, 200)
        Me.LblMA.Name = "LblMA"
        Me.LblMA.Size = New System.Drawing.Size(381, 47)
        Me.LblMA.TabIndex = 40
        Me.LblMA.Text = "Montant total actuel :"
        '
        'lblQteSt
        '
        Me.lblQteSt.AutoSize = True
        Me.lblQteSt.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblQteSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQteSt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQteSt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblQteSt.Location = New System.Drawing.Point(329, 139)
        Me.lblQteSt.Name = "lblQteSt"
        Me.lblQteSt.Size = New System.Drawing.Size(158, 23)
        Me.lblQteSt.TabIndex = 39
        Me.lblQteSt.Text = "Quantité en stock : "
        Me.lblQteSt.Visible = False
        '
        'RB_Modem
        '
        Me.RB_Modem.AutoSize = True
        Me.RB_Modem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Modem.Location = New System.Drawing.Point(363, 30)
        Me.RB_Modem.Name = "RB_Modem"
        Me.RB_Modem.Size = New System.Drawing.Size(87, 22)
        Me.RB_Modem.TabIndex = 38
        Me.RB_Modem.TabStop = True
        Me.RB_Modem.Text = "Modem"
        Me.RB_Modem.UseVisualStyleBackColor = True
        '
        'RB_Puce
        '
        Me.RB_Puce.AutoSize = True
        Me.RB_Puce.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Puce.Location = New System.Drawing.Point(270, 30)
        Me.RB_Puce.Name = "RB_Puce"
        Me.RB_Puce.Size = New System.Drawing.Size(66, 22)
        Me.RB_Puce.TabIndex = 37
        Me.RB_Puce.TabStop = True
        Me.RB_Puce.Text = "Puce"
        Me.RB_Puce.UseVisualStyleBackColor = True
        '
        'RB_Portable
        '
        Me.RB_Portable.AutoSize = True
        Me.RB_Portable.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Portable.Location = New System.Drawing.Point(156, 30)
        Me.RB_Portable.Name = "RB_Portable"
        Me.RB_Portable.Size = New System.Drawing.Size(97, 22)
        Me.RB_Portable.TabIndex = 36
        Me.RB_Portable.TabStop = True
        Me.RB_Portable.Text = "Portable"
        Me.RB_Portable.UseVisualStyleBackColor = True
        '
        'RB_Recharge
        '
        Me.RB_Recharge.AutoSize = True
        Me.RB_Recharge.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Recharge.Location = New System.Drawing.Point(30, 30)
        Me.RB_Recharge.Name = "RB_Recharge"
        Me.RB_Recharge.Size = New System.Drawing.Size(103, 22)
        Me.RB_Recharge.TabIndex = 35
        Me.RB_Recharge.TabStop = True
        Me.RB_Recharge.Text = "Recharge"
        Me.RB_Recharge.UseVisualStyleBackColor = True
        '
        'btValider
        '
        Me.btValider.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btValider.Location = New System.Drawing.Point(188, 170)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(80, 27)
        Me.btValider.TabIndex = 33
        Me.btValider.Text = "Valider"
        Me.btValider.UseVisualStyleBackColor = True
        '
        'BT_fermerR
        '
        Me.BT_fermerR.Image = CType(resources.GetObject("BT_fermerR.Image"), System.Drawing.Image)
        Me.BT_fermerR.Location = New System.Drawing.Point(542, -3)
        Me.BT_fermerR.Name = "BT_fermerR"
        Me.BT_fermerR.Size = New System.Drawing.Size(24, 24)
        Me.BT_fermerR.TabIndex = 32
        Me.BT_fermerR.UseVisualStyleBackColor = True
        '
        'lblAjout
        '
        Me.lblAjout.AutoSize = True
        Me.lblAjout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjout.Location = New System.Drawing.Point(18, 220)
        Me.lblAjout.Name = "lblAjout"
        Me.lblAjout.Size = New System.Drawing.Size(99, 17)
        Me.lblAjout.TabIndex = 7
        Me.lblAjout.Text = "Produit ajouté "
        Me.lblAjout.Visible = False
        '
        'BT_AnnulerR
        '
        Me.BT_AnnulerR.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_AnnulerR.Location = New System.Drawing.Point(284, 170)
        Me.BT_AnnulerR.Name = "BT_AnnulerR"
        Me.BT_AnnulerR.Size = New System.Drawing.Size(96, 27)
        Me.BT_AnnulerR.TabIndex = 6
        Me.BT_AnnulerR.Text = "Annuler"
        Me.BT_AnnulerR.UseVisualStyleBackColor = True
        '
        'txtQteCmd
        '
        Me.txtQteCmd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQteCmd.Location = New System.Drawing.Point(214, 100)
        Me.txtQteCmd.Name = "txtQteCmd"
        Me.txtQteCmd.Size = New System.Drawing.Size(110, 27)
        Me.txtQteCmd.TabIndex = 4
        '
        'cb_desigPdt
        '
        Me.cb_desigPdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_desigPdt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_desigPdt.FormattingEnabled = True
        Me.cb_desigPdt.Location = New System.Drawing.Point(181, 61)
        Me.cb_desigPdt.Name = "cb_desigPdt"
        Me.cb_desigPdt.Size = New System.Drawing.Size(183, 33)
        Me.cb_desigPdt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantité commandée"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Désignation produit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(128, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(292, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ajout de produit(s)  dans une commande"
        '
        'CK_Revend
        '
        Me.CK_Revend.AutoSize = True
        Me.CK_Revend.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_Revend.Location = New System.Drawing.Point(23, 58)
        Me.CK_Revend.Name = "CK_Revend"
        Me.CK_Revend.Size = New System.Drawing.Size(116, 22)
        Me.CK_Revend.TabIndex = 34
        Me.CK_Revend.Text = "Revendeur"
        Me.CK_Revend.UseVisualStyleBackColor = True
        '
        'Ck_Date
        '
        Me.Ck_Date.AutoSize = True
        Me.Ck_Date.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_Date.Location = New System.Drawing.Point(24, 91)
        Me.Ck_Date.Name = "Ck_Date"
        Me.Ck_Date.Size = New System.Drawing.Size(69, 22)
        Me.Ck_Date.TabIndex = 35
        Me.Ck_Date.Text = "Date "
        Me.Ck_Date.UseVisualStyleBackColor = True
        '
        'pn_RecherCmd
        '
        Me.pn_RecherCmd.BackColor = System.Drawing.Color.Transparent
        Me.pn_RecherCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_RecherCmd.Controls.Add(Me.lblPar)
        Me.pn_RecherCmd.Controls.Add(Me.BtFermerRech)
        Me.pn_RecherCmd.Controls.Add(Me.Cb_Reche_NumCmd)
        Me.pn_RecherCmd.Controls.Add(Me.Ck_NumCmd)
        Me.pn_RecherCmd.Controls.Add(Me.BtVlider)
        Me.pn_RecherCmd.Controls.Add(Me.Cb_Reche_Date)
        Me.pn_RecherCmd.Controls.Add(Me.Cb_Reche_Revend)
        Me.pn_RecherCmd.Controls.Add(Me.Ck_Date)
        Me.pn_RecherCmd.Controls.Add(Me.CK_Revend)
        Me.pn_RecherCmd.Location = New System.Drawing.Point(12, 72)
        Me.pn_RecherCmd.Name = "pn_RecherCmd"
        Me.pn_RecherCmd.Size = New System.Drawing.Size(486, 124)
        Me.pn_RecherCmd.TabIndex = 36
        Me.pn_RecherCmd.Visible = False
        '
        'lblPar
        '
        Me.lblPar.AutoSize = True
        Me.lblPar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPar.Location = New System.Drawing.Point(3, 7)
        Me.lblPar.Name = "lblPar"
        Me.lblPar.Size = New System.Drawing.Size(36, 19)
        Me.lblPar.TabIndex = 50
        Me.lblPar.Text = "Par :"
        '
        'BtFermerRech
        '
        Me.BtFermerRech.Image = CType(resources.GetObject("BtFermerRech.Image"), System.Drawing.Image)
        Me.BtFermerRech.Location = New System.Drawing.Point(461, -2)
        Me.BtFermerRech.Name = "BtFermerRech"
        Me.BtFermerRech.Size = New System.Drawing.Size(24, 24)
        Me.BtFermerRech.TabIndex = 49
        Me.BtFermerRech.UseVisualStyleBackColor = True
        '
        'Cb_Reche_NumCmd
        '
        Me.Cb_Reche_NumCmd.BackColor = System.Drawing.SystemColors.Window
        Me.Cb_Reche_NumCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Reche_NumCmd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Reche_NumCmd.FormattingEnabled = True
        Me.Cb_Reche_NumCmd.Location = New System.Drawing.Point(215, 22)
        Me.Cb_Reche_NumCmd.Name = "Cb_Reche_NumCmd"
        Me.Cb_Reche_NumCmd.Size = New System.Drawing.Size(147, 28)
        Me.Cb_Reche_NumCmd.TabIndex = 40
        Me.Cb_Reche_NumCmd.Visible = False
        '
        'Ck_NumCmd
        '
        Me.Ck_NumCmd.AutoSize = True
        Me.Ck_NumCmd.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_NumCmd.Location = New System.Drawing.Point(24, 25)
        Me.Ck_NumCmd.Name = "Ck_NumCmd"
        Me.Ck_NumCmd.Size = New System.Drawing.Size(171, 22)
        Me.Ck_NumCmd.TabIndex = 39
        Me.Ck_NumCmd.Text = " N° de commande"
        Me.Ck_NumCmd.UseVisualStyleBackColor = True
        '
        'BtVlider
        '
        Me.BtVlider.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVlider.Location = New System.Drawing.Point(383, 55)
        Me.BtVlider.Name = "BtVlider"
        Me.BtVlider.Size = New System.Drawing.Size(83, 28)
        Me.BtVlider.TabIndex = 38
        Me.BtVlider.Text = "Valider"
        Me.BtVlider.UseVisualStyleBackColor = True
        '
        'Cb_Reche_Date
        '
        Me.Cb_Reche_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Reche_Date.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Reche_Date.FormattingEnabled = True
        Me.Cb_Reche_Date.Location = New System.Drawing.Point(215, 88)
        Me.Cb_Reche_Date.Name = "Cb_Reche_Date"
        Me.Cb_Reche_Date.Size = New System.Drawing.Size(147, 28)
        Me.Cb_Reche_Date.TabIndex = 37
        Me.Cb_Reche_Date.Visible = False
        '
        'Cb_Reche_Revend
        '
        Me.Cb_Reche_Revend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Reche_Revend.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Reche_Revend.FormattingEnabled = True
        Me.Cb_Reche_Revend.Location = New System.Drawing.Point(215, 55)
        Me.Cb_Reche_Revend.Name = "Cb_Reche_Revend"
        Me.Cb_Reche_Revend.Size = New System.Drawing.Size(147, 28)
        Me.Cb_Reche_Revend.TabIndex = 36
        Me.Cb_Reche_Revend.Visible = False
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.BackColor = System.Drawing.Color.Transparent
        Me.lblSupp.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupp.Location = New System.Drawing.Point(263, 438)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(162, 19)
        Me.lblSupp.TabIndex = 38
        Me.lblSupp.Text = "Suppression avec succés"
        Me.lblSupp.Visible = False
        '
        'lblSuppe
        '
        Me.lblSuppe.AutoSize = True
        Me.lblSuppe.BackColor = System.Drawing.Color.Transparent
        Me.lblSuppe.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppe.Location = New System.Drawing.Point(264, 439)
        Me.lblSuppe.Name = "lblSuppe"
        Me.lblSuppe.Size = New System.Drawing.Size(141, 17)
        Me.lblSuppe.TabIndex = 39
        Me.lblSuppe.Text = "Suppression échouée "
        Me.lblSuppe.Visible = False
        '
        'lblModifDC
        '
        Me.lblModifDC.AutoSize = True
        Me.lblModifDC.BackColor = System.Drawing.Color.Transparent
        Me.lblModifDC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifDC.Location = New System.Drawing.Point(875, 431)
        Me.lblModifDC.Name = "lblModifDC"
        Me.lblModifDC.Size = New System.Drawing.Size(176, 15)
        Me.lblModifDC.TabIndex = 40
        Me.lblModifDC.Text = "Modification réalisé avec succés"
        Me.lblModifDC.Visible = False
        '
        'lblModifDCe
        '
        Me.lblModifDCe.AutoSize = True
        Me.lblModifDCe.BackColor = System.Drawing.Color.Transparent
        Me.lblModifDCe.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifDCe.Location = New System.Drawing.Point(875, 431)
        Me.lblModifDCe.Name = "lblModifDCe"
        Me.lblModifDCe.Size = New System.Drawing.Size(134, 15)
        Me.lblModifDCe.TabIndex = 41
        Me.lblModifDCe.Text = "Modification echouée !!"
        Me.lblModifDCe.Visible = False
        '
        'lblRetPdt
        '
        Me.lblRetPdt.AutoSize = True
        Me.lblRetPdt.BackColor = System.Drawing.Color.Transparent
        Me.lblRetPdt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetPdt.Location = New System.Drawing.Point(880, 431)
        Me.lblRetPdt.Name = "lblRetPdt"
        Me.lblRetPdt.Size = New System.Drawing.Size(296, 17)
        Me.lblRetPdt.TabIndex = 42
        Me.lblRetPdt.Text = "Retrait du produit de la commande avec succes"
        Me.lblRetPdt.Visible = False
        '
        'lblRetech
        '
        Me.lblRetech.AutoSize = True
        Me.lblRetech.BackColor = System.Drawing.Color.Transparent
        Me.lblRetech.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRetech.Location = New System.Drawing.Point(970, 431)
        Me.lblRetech.Name = "lblRetech"
        Me.lblRetech.Size = New System.Drawing.Size(110, 19)
        Me.lblRetech.TabIndex = 43
        Me.lblRetech.Text = "echec de retrait "
        Me.lblRetech.Visible = False
        '
        'PnPaiement
        '
        Me.PnPaiement.BackColor = System.Drawing.Color.Transparent
        Me.PnPaiement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnPaiement.Controls.Add(Me.lblCap)
        Me.PnPaiement.Controls.Add(Me.Bt_Imprimer)
        Me.PnPaiement.Controls.Add(Me.BtFerP)
        Me.PnPaiement.Controls.Add(Me.lblMontant)
        Me.PnPaiement.Controls.Add(Me.lblRestePaieDH)
        Me.PnPaiement.Controls.Add(Me.lblManque)
        Me.PnPaiement.Controls.Add(Me.txtReste)
        Me.PnPaiement.Controls.Add(Me.lblReste)
        Me.PnPaiement.Controls.Add(Me.lblP)
        Me.PnPaiement.Controls.Add(Me.lblPaie)
        Me.PnPaiement.Controls.Add(Me.txtDonner)
        Me.PnPaiement.Controls.Add(Me.Bt_Donner)
        Me.PnPaiement.Location = New System.Drawing.Point(421, 475)
        Me.PnPaiement.Name = "PnPaiement"
        Me.PnPaiement.Size = New System.Drawing.Size(312, 255)
        Me.PnPaiement.TabIndex = 44
        Me.PnPaiement.Visible = False
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblCap.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCap.Location = New System.Drawing.Point(26, 30)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(83, 25)
        Me.lblCap.TabIndex = 48
        Me.lblCap.Text = "Capital :"
        Me.lblCap.Visible = False
        '
        'Bt_Imprimer
        '
        Me.Bt_Imprimer.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Imprimer.Location = New System.Drawing.Point(114, 220)
        Me.Bt_Imprimer.Name = "Bt_Imprimer"
        Me.Bt_Imprimer.Size = New System.Drawing.Size(105, 28)
        Me.Bt_Imprimer.TabIndex = 48
        Me.Bt_Imprimer.Text = "Imprimer"
        Me.Bt_Imprimer.UseVisualStyleBackColor = True
        Me.Bt_Imprimer.Visible = False
        '
        'BtFerP
        '
        Me.BtFerP.Image = CType(resources.GetObject("BtFerP.Image"), System.Drawing.Image)
        Me.BtFerP.Location = New System.Drawing.Point(287, -2)
        Me.BtFerP.Name = "BtFerP"
        Me.BtFerP.Size = New System.Drawing.Size(24, 24)
        Me.BtFerP.TabIndex = 47
        Me.BtFerP.UseVisualStyleBackColor = True
        '
        'lblMontant
        '
        Me.lblMontant.AutoSize = True
        Me.lblMontant.BackColor = System.Drawing.Color.Maroon
        Me.lblMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontant.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontant.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMontant.Location = New System.Drawing.Point(10, 100)
        Me.lblMontant.Name = "lblMontant"
        Me.lblMontant.Size = New System.Drawing.Size(300, 27)
        Me.lblMontant.TabIndex = 46
        Me.lblMontant.Text = "Montant total à payer : montant"
        '
        'lblRestePaieDH
        '
        Me.lblRestePaieDH.AutoSize = True
        Me.lblRestePaieDH.BackColor = System.Drawing.Color.Maroon
        Me.lblRestePaieDH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRestePaieDH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestePaieDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRestePaieDH.Location = New System.Drawing.Point(42, 63)
        Me.lblRestePaieDH.Name = "lblRestePaieDH"
        Me.lblRestePaieDH.Size = New System.Drawing.Size(102, 27)
        Me.lblRestePaieDH.TabIndex = 45
        Me.lblRestePaieDH.Text = "Crédit DH"
        '
        'lblManque
        '
        Me.lblManque.AutoSize = True
        Me.lblManque.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblManque.Location = New System.Drawing.Point(60, 198)
        Me.lblManque.Name = "lblManque"
        Me.lblManque.Size = New System.Drawing.Size(119, 19)
        Me.lblManque.TabIndex = 6
        Me.lblManque.Text = "Manque de crédit"
        Me.lblManque.Visible = False
        '
        'txtReste
        '
        Me.txtReste.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReste.Location = New System.Drawing.Point(79, 166)
        Me.txtReste.Name = "txtReste"
        Me.txtReste.Size = New System.Drawing.Size(62, 27)
        Me.txtReste.TabIndex = 5
        Me.txtReste.Text = "  "
        Me.txtReste.Visible = False
        '
        'lblReste
        '
        Me.lblReste.AutoSize = True
        Me.lblReste.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReste.Location = New System.Drawing.Point(25, 170)
        Me.lblReste.Name = "lblReste"
        Me.lblReste.Size = New System.Drawing.Size(48, 20)
        Me.lblReste.TabIndex = 4
        Me.lblReste.Text = "Reste"
        Me.lblReste.Visible = False
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.Location = New System.Drawing.Point(110, 5)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(69, 16)
        Me.lblP.TabIndex = 3
        Me.lblP.Text = "Paiement"
        '
        'lblPaie
        '
        Me.lblPaie.AutoSize = True
        Me.lblPaie.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPaie.Location = New System.Drawing.Point(27, 198)
        Me.lblPaie.Name = "lblPaie"
        Me.lblPaie.Size = New System.Drawing.Size(208, 19)
        Me.lblPaie.TabIndex = 2
        Me.lblPaie.Text = "  Paiement réalisé avec succés   "
        Me.lblPaie.Visible = False
        '
        'txtDonner
        '
        Me.txtDonner.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonner.Location = New System.Drawing.Point(40, 133)
        Me.txtDonner.Name = "txtDonner"
        Me.txtDonner.Size = New System.Drawing.Size(100, 27)
        Me.txtDonner.TabIndex = 1
        '
        'Bt_Donner
        '
        Me.Bt_Donner.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Donner.Location = New System.Drawing.Point(155, 132)
        Me.Bt_Donner.Name = "Bt_Donner"
        Me.Bt_Donner.Size = New System.Drawing.Size(93, 31)
        Me.Bt_Donner.TabIndex = 0
        Me.Bt_Donner.Text = "Valider"
        Me.Bt_Donner.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(591, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 26)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblMp
        '
        Me.LblMp.AutoSize = True
        Me.LblMp.BackColor = System.Drawing.Color.Maroon
        Me.LblMp.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMp.Location = New System.Drawing.Point(948, 442)
        Me.LblMp.Name = "LblMp"
        Me.LblMp.Size = New System.Drawing.Size(222, 30)
        Me.LblMp.TabIndex = 47
        Me.LblMp.Text = "Montant total actuel:"
        Me.LblMp.Visible = False
        '
        'GestCommandes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WA_GestStockTeleb.My.Resources.Resources.B3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.LblMp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PnPaiement)
        Me.Controls.Add(Me.lblRetech)
        Me.Controls.Add(Me.lblRetPdt)
        Me.Controls.Add(Me.lblModifDCe)
        Me.Controls.Add(Me.lblModifDC)
        Me.Controls.Add(Me.lblSuppe)
        Me.Controls.Add(Me.lblSupp)
        Me.Controls.Add(Me.pn_RecherCmd)
        Me.Controls.Add(Me.pn_RempCmd)
        Me.Controls.Add(Me.pn_CreatCmd)
        Me.Controls.Add(Me.BT_fermerDG2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RB_Consulter)
        Me.Controls.Add(Me.RB_Ajouter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GestCommandes"
        Me.Text = "s"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_CreatCmd.ResumeLayout(False)
        Me.pn_CreatCmd.PerformLayout()
        Me.pn_RempCmd.ResumeLayout(False)
        Me.pn_RempCmd.PerformLayout()
        Me.pn_RecherCmd.ResumeLayout(False)
        Me.pn_RecherCmd.PerformLayout()
        Me.PnPaiement.ResumeLayout(False)
        Me.PnPaiement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_Ajouter As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Consulter As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BT_fermerDG2 As System.Windows.Forms.Button
    Friend WithEvents pn_CreatCmd As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BT_Valider As System.Windows.Forms.Button
    Friend WithEvents cb_Revendeur As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pn_RempCmd As System.Windows.Forms.Panel
    Friend WithEvents lblAjout As System.Windows.Forms.Label
    Friend WithEvents BT_AnnulerR As System.Windows.Forms.Button
    Friend WithEvents txtQteCmd As System.Windows.Forms.TextBox
    Friend WithEvents cb_desigPdt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BT_fermerR As System.Windows.Forms.Button
    Friend WithEvents CK_Revend As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_Date As System.Windows.Forms.CheckBox
    Friend WithEvents pn_RecherCmd As System.Windows.Forms.Panel
    Friend WithEvents Cb_Reche_Date As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Reche_Revend As System.Windows.Forms.ComboBox
    Friend WithEvents BtVlider As System.Windows.Forms.Button
    Friend WithEvents lblSupp As System.Windows.Forms.Label
    Friend WithEvents lblSuppe As System.Windows.Forms.Label
    Friend WithEvents lblModifDC As System.Windows.Forms.Label
    Friend WithEvents lblModifDCe As System.Windows.Forms.Label
    Friend WithEvents lblCmdc As System.Windows.Forms.Label
    Friend WithEvents lblCmdE As System.Windows.Forms.Label
    Friend WithEvents Cb_Reche_NumCmd As System.Windows.Forms.ComboBox
    Friend WithEvents Ck_NumCmd As System.Windows.Forms.CheckBox
    Friend WithEvents lblRetPdt As System.Windows.Forms.Label
    Friend WithEvents lblRetech As System.Windows.Forms.Label
    Friend WithEvents PnPaiement As System.Windows.Forms.Panel
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents lblPaie As System.Windows.Forms.Label
    Friend WithEvents txtDonner As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Donner As System.Windows.Forms.Button
    Friend WithEvents txtReste As System.Windows.Forms.TextBox
    Friend WithEvents lblReste As System.Windows.Forms.Label
    Friend WithEvents lblManque As System.Windows.Forms.Label
    Friend WithEvents lblCreditDH As System.Windows.Forms.Label
    Friend WithEvents lblRestePaieDH As System.Windows.Forms.Label
    Friend WithEvents btValider As System.Windows.Forms.Button
    Friend WithEvents RB_Modem As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Puce As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Portable As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Recharge As System.Windows.Forms.RadioButton
    Friend WithEvents lblMontant As System.Windows.Forms.Label
    Friend WithEvents lblQteSt As System.Windows.Forms.Label
    Friend WithEvents numCmd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateCmd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomRevend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montantHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtAnnuler As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtFerP As System.Windows.Forms.Button
    Friend WithEvents BtFerC As System.Windows.Forms.Button
    Friend WithEvents LblMA As System.Windows.Forms.Label
    Friend WithEvents BtFermerRech As System.Windows.Forms.Button
    Friend WithEvents lblPar As System.Windows.Forms.Label
    Friend WithEvents LblMp As System.Windows.Forms.Label
    Friend WithEvents Bt_Imprimer As System.Windows.Forms.Button
    Friend WithEvents BtPayer As System.Windows.Forms.Button
    Friend WithEvents lblCap As System.Windows.Forms.Label
    Friend WithEvents txtPv As System.Windows.Forms.TextBox
    Friend WithEvents lblPVente As System.Windows.Forms.Label
    Friend WithEvents numCd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desigPdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qteCmd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prixVente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
