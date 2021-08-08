<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestProduits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestProduits))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RB_Ajouter = New System.Windows.Forms.RadioButton()
        Me.RB_Rechercher = New System.Windows.Forms.RadioButton()
        Me.pn_Rechercher = New System.Windows.Forms.Panel()
        Me.BtFerRech = New System.Windows.Forms.Button()
        Me.RB_ModemR = New System.Windows.Forms.RadioButton()
        Me.RB_PuceR = New System.Windows.Forms.RadioButton()
        Me.RB_PortableR = New System.Windows.Forms.RadioButton()
        Me.RB_RechargeR = New System.Windows.Forms.RadioButton()
        Me.cb_RechPdt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.desigPdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prixPdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PourcAch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_Ajouter = New System.Windows.Forms.Panel()
        Me.txtPourcAch = New System.Windows.Forms.TextBox()
        Me.lblPourcentAch = New System.Windows.Forms.Label()
        Me.lblCategPdt = New System.Windows.Forms.Label()
        Me.cb_categPdt = New System.Windows.Forms.ComboBox()
        Me.BtFerAj = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.RB_Modem = New System.Windows.Forms.RadioButton()
        Me.RB_Puce = New System.Windows.Forms.RadioButton()
        Me.RB_Portable = New System.Windows.Forms.RadioButton()
        Me.RB_Recharge = New System.Windows.Forms.RadioButton()
        Me.lblAjout = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.txtDesig = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bn_Ajouter = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.lblSuppe = New System.Windows.Forms.Label()
        Me.lblmodif = New System.Windows.Forms.Label()
        Me.lblmodife = New System.Windows.Forms.Label()
        Me.pn_Rechercher.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_Ajouter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 38)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Gestion des produits"
        '
        'RB_Ajouter
        '
        Me.RB_Ajouter.AutoSize = True
        Me.RB_Ajouter.BackColor = System.Drawing.Color.Transparent
        Me.RB_Ajouter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ajouter.Location = New System.Drawing.Point(573, 77)
        Me.RB_Ajouter.Name = "RB_Ajouter"
        Me.RB_Ajouter.Size = New System.Drawing.Size(88, 22)
        Me.RB_Ajouter.TabIndex = 31
        Me.RB_Ajouter.Text = "Ajouter"
        Me.RB_Ajouter.UseVisualStyleBackColor = False
        '
        'RB_Rechercher
        '
        Me.RB_Rechercher.AutoSize = True
        Me.RB_Rechercher.BackColor = System.Drawing.Color.Transparent
        Me.RB_Rechercher.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Rechercher.Location = New System.Drawing.Point(690, 77)
        Me.RB_Rechercher.Name = "RB_Rechercher"
        Me.RB_Rechercher.Size = New System.Drawing.Size(107, 22)
        Me.RB_Rechercher.TabIndex = 30
        Me.RB_Rechercher.Text = "Consulter"
        Me.RB_Rechercher.UseVisualStyleBackColor = False
        '
        'pn_Rechercher
        '
        Me.pn_Rechercher.BackColor = System.Drawing.Color.Transparent
        Me.pn_Rechercher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_Rechercher.Controls.Add(Me.BtFerRech)
        Me.pn_Rechercher.Controls.Add(Me.RB_ModemR)
        Me.pn_Rechercher.Controls.Add(Me.RB_PuceR)
        Me.pn_Rechercher.Controls.Add(Me.RB_PortableR)
        Me.pn_Rechercher.Controls.Add(Me.RB_RechargeR)
        Me.pn_Rechercher.Controls.Add(Me.cb_RechPdt)
        Me.pn_Rechercher.Controls.Add(Me.Label2)
        Me.pn_Rechercher.Location = New System.Drawing.Point(10, 104)
        Me.pn_Rechercher.Name = "pn_Rechercher"
        Me.pn_Rechercher.Size = New System.Drawing.Size(440, 89)
        Me.pn_Rechercher.TabIndex = 33
        Me.pn_Rechercher.Visible = False
        '
        'BtFerRech
        '
        Me.BtFerRech.Image = CType(resources.GetObject("BtFerRech.Image"), System.Drawing.Image)
        Me.BtFerRech.Location = New System.Drawing.Point(415, -2)
        Me.BtFerRech.Name = "BtFerRech"
        Me.BtFerRech.Size = New System.Drawing.Size(24, 24)
        Me.BtFerRech.TabIndex = 49
        Me.BtFerRech.UseVisualStyleBackColor = True
        '
        'RB_ModemR
        '
        Me.RB_ModemR.AutoSize = True
        Me.RB_ModemR.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_ModemR.Location = New System.Drawing.Point(314, 15)
        Me.RB_ModemR.Name = "RB_ModemR"
        Me.RB_ModemR.Size = New System.Drawing.Size(87, 22)
        Me.RB_ModemR.TabIndex = 38
        Me.RB_ModemR.TabStop = True
        Me.RB_ModemR.Text = "Modem"
        Me.RB_ModemR.UseVisualStyleBackColor = True
        '
        'RB_PuceR
        '
        Me.RB_PuceR.AutoSize = True
        Me.RB_PuceR.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_PuceR.Location = New System.Drawing.Point(234, 15)
        Me.RB_PuceR.Name = "RB_PuceR"
        Me.RB_PuceR.Size = New System.Drawing.Size(66, 22)
        Me.RB_PuceR.TabIndex = 37
        Me.RB_PuceR.TabStop = True
        Me.RB_PuceR.Text = "Puce"
        Me.RB_PuceR.UseVisualStyleBackColor = True
        '
        'RB_PortableR
        '
        Me.RB_PortableR.AutoSize = True
        Me.RB_PortableR.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_PortableR.Location = New System.Drawing.Point(120, 15)
        Me.RB_PortableR.Name = "RB_PortableR"
        Me.RB_PortableR.Size = New System.Drawing.Size(97, 22)
        Me.RB_PortableR.TabIndex = 36
        Me.RB_PortableR.TabStop = True
        Me.RB_PortableR.Text = "Portable"
        Me.RB_PortableR.UseVisualStyleBackColor = True
        '
        'RB_RechargeR
        '
        Me.RB_RechargeR.AutoSize = True
        Me.RB_RechargeR.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_RechargeR.Location = New System.Drawing.Point(10, 15)
        Me.RB_RechargeR.Name = "RB_RechargeR"
        Me.RB_RechargeR.Size = New System.Drawing.Size(103, 22)
        Me.RB_RechargeR.TabIndex = 35
        Me.RB_RechargeR.TabStop = True
        Me.RB_RechargeR.Text = "Recharge"
        Me.RB_RechargeR.UseVisualStyleBackColor = True
        '
        'cb_RechPdt
        '
        Me.cb_RechPdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RechPdt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RechPdt.FormattingEnabled = True
        Me.cb_RechPdt.Location = New System.Drawing.Point(265, 46)
        Me.cb_RechPdt.Name = "cb_RechPdt"
        Me.cb_RechPdt.Size = New System.Drawing.Size(142, 28)
        Me.cb_RechPdt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sélectionnez votre produit"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desigPdt, Me.prixPdt, Me.Quantité, Me.PourcAch})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(598, 424)
        Me.DataGridView1.TabIndex = 34
        '
        'desigPdt
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.desigPdt.DefaultCellStyle = DataGridViewCellStyle1
        Me.desigPdt.HeaderText = "Désignation"
        Me.desigPdt.Name = "desigPdt"
        '
        'prixPdt
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prixPdt.DefaultCellStyle = DataGridViewCellStyle2
        Me.prixPdt.HeaderText = "Prix"
        Me.prixPdt.Name = "prixPdt"
        '
        'Quantité
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantité.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantité.HeaderText = "Quantité"
        Me.Quantité.Name = "Quantité"
        '
        'PourcAch
        '
        Me.PourcAch.HeaderText = "Pourcentage d'achat"
        Me.PourcAch.Name = "PourcAch"
        '
        'pn_Ajouter
        '
        Me.pn_Ajouter.BackColor = System.Drawing.Color.Transparent
        Me.pn_Ajouter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_Ajouter.Controls.Add(Me.txtPourcAch)
        Me.pn_Ajouter.Controls.Add(Me.lblPourcentAch)
        Me.pn_Ajouter.Controls.Add(Me.lblCategPdt)
        Me.pn_Ajouter.Controls.Add(Me.cb_categPdt)
        Me.pn_Ajouter.Controls.Add(Me.BtFerAj)
        Me.pn_Ajouter.Controls.Add(Me.BTAnnuler)
        Me.pn_Ajouter.Controls.Add(Me.RB_Modem)
        Me.pn_Ajouter.Controls.Add(Me.RB_Puce)
        Me.pn_Ajouter.Controls.Add(Me.RB_Portable)
        Me.pn_Ajouter.Controls.Add(Me.RB_Recharge)
        Me.pn_Ajouter.Controls.Add(Me.lblAjout)
        Me.pn_Ajouter.Controls.Add(Me.Label3)
        Me.pn_Ajouter.Controls.Add(Me.txtPrix)
        Me.pn_Ajouter.Controls.Add(Me.txtDesig)
        Me.pn_Ajouter.Controls.Add(Me.Label5)
        Me.pn_Ajouter.Controls.Add(Me.Label4)
        Me.pn_Ajouter.Controls.Add(Me.bn_Ajouter)
        Me.pn_Ajouter.Location = New System.Drawing.Point(685, 212)
        Me.pn_Ajouter.Name = "pn_Ajouter"
        Me.pn_Ajouter.Size = New System.Drawing.Size(460, 359)
        Me.pn_Ajouter.TabIndex = 35
        Me.pn_Ajouter.Visible = False
        '
        'txtPourcAch
        '
        Me.txtPourcAch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPourcAch.Location = New System.Drawing.Point(304, 231)
        Me.txtPourcAch.Name = "txtPourcAch"
        Me.txtPourcAch.Size = New System.Drawing.Size(68, 29)
        Me.txtPourcAch.TabIndex = 53
        '
        'lblPourcentAch
        '
        Me.lblPourcentAch.AutoSize = True
        Me.lblPourcentAch.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPourcentAch.Location = New System.Drawing.Point(75, 237)
        Me.lblPourcentAch.Name = "lblPourcentAch"
        Me.lblPourcentAch.Size = New System.Drawing.Size(178, 18)
        Me.lblPourcentAch.TabIndex = 52
        Me.lblPourcentAch.Text = "Pourcentage d'achat"
        '
        'lblCategPdt
        '
        Me.lblCategPdt.AutoSize = True
        Me.lblCategPdt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategPdt.Location = New System.Drawing.Point(75, 122)
        Me.lblCategPdt.Name = "lblCategPdt"
        Me.lblCategPdt.Size = New System.Drawing.Size(87, 18)
        Me.lblCategPdt.TabIndex = 51
        Me.lblCategPdt.Text = "Catégorie"
        Me.lblCategPdt.Visible = False
        '
        'cb_categPdt
        '
        Me.cb_categPdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categPdt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_categPdt.FormattingEnabled = True
        Me.cb_categPdt.Location = New System.Drawing.Point(232, 113)
        Me.cb_categPdt.Name = "cb_categPdt"
        Me.cb_categPdt.Size = New System.Drawing.Size(197, 33)
        Me.cb_categPdt.TabIndex = 50
        Me.cb_categPdt.Visible = False
        '
        'BtFerAj
        '
        Me.BtFerAj.Image = CType(resources.GetObject("BtFerAj.Image"), System.Drawing.Image)
        Me.BtFerAj.Location = New System.Drawing.Point(620, -2)
        Me.BtFerAj.Name = "BtFerAj"
        Me.BtFerAj.Size = New System.Drawing.Size(24, 24)
        Me.BtFerAj.TabIndex = 49
        Me.BtFerAj.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAnnuler.Location = New System.Drawing.Point(220, 272)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(87, 28)
        Me.BTAnnuler.TabIndex = 35
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'RB_Modem
        '
        Me.RB_Modem.AutoSize = True
        Me.RB_Modem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Modem.Location = New System.Drawing.Point(341, 63)
        Me.RB_Modem.Name = "RB_Modem"
        Me.RB_Modem.Size = New System.Drawing.Size(87, 22)
        Me.RB_Modem.TabIndex = 34
        Me.RB_Modem.TabStop = True
        Me.RB_Modem.Text = "Modem"
        Me.RB_Modem.UseVisualStyleBackColor = True
        '
        'RB_Puce
        '
        Me.RB_Puce.AutoSize = True
        Me.RB_Puce.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Puce.Location = New System.Drawing.Point(261, 63)
        Me.RB_Puce.Name = "RB_Puce"
        Me.RB_Puce.Size = New System.Drawing.Size(66, 22)
        Me.RB_Puce.TabIndex = 33
        Me.RB_Puce.TabStop = True
        Me.RB_Puce.Text = "Puce"
        Me.RB_Puce.UseVisualStyleBackColor = True
        '
        'RB_Portable
        '
        Me.RB_Portable.AutoSize = True
        Me.RB_Portable.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Portable.Location = New System.Drawing.Point(141, 63)
        Me.RB_Portable.Name = "RB_Portable"
        Me.RB_Portable.Size = New System.Drawing.Size(97, 22)
        Me.RB_Portable.TabIndex = 32
        Me.RB_Portable.TabStop = True
        Me.RB_Portable.Text = "Portable"
        Me.RB_Portable.UseVisualStyleBackColor = True
        '
        'RB_Recharge
        '
        Me.RB_Recharge.AutoSize = True
        Me.RB_Recharge.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Recharge.Location = New System.Drawing.Point(20, 63)
        Me.RB_Recharge.Name = "RB_Recharge"
        Me.RB_Recharge.Size = New System.Drawing.Size(103, 22)
        Me.RB_Recharge.TabIndex = 31
        Me.RB_Recharge.TabStop = True
        Me.RB_Recharge.Text = "Recharge"
        Me.RB_Recharge.UseVisualStyleBackColor = True
        '
        'lblAjout
        '
        Me.lblAjout.AutoSize = True
        Me.lblAjout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjout.Location = New System.Drawing.Point(98, 321)
        Me.lblAjout.Name = "lblAjout"
        Me.lblAjout.Size = New System.Drawing.Size(198, 21)
        Me.lblAjout.TabIndex = 30
        Me.lblAjout.Text = "Ajout réalisé avec succés"
        Me.lblAjout.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ajout d'un nouveau produit"
        '
        'txtPrix
        '
        Me.txtPrix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrix.Location = New System.Drawing.Point(304, 191)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(68, 29)
        Me.txtPrix.TabIndex = 8
        '
        'txtDesig
        '
        Me.txtDesig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesig.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesig.Location = New System.Drawing.Point(247, 152)
        Me.txtDesig.Name = "txtDesig"
        Me.txtDesig.Size = New System.Drawing.Size(167, 29)
        Me.txtDesig.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Prix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Désignation"
        '
        'bn_Ajouter
        '
        Me.bn_Ajouter.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bn_Ajouter.Location = New System.Drawing.Point(114, 272)
        Me.bn_Ajouter.Name = "bn_Ajouter"
        Me.bn_Ajouter.Size = New System.Drawing.Size(87, 28)
        Me.bn_Ajouter.TabIndex = 2
        Me.bn_Ajouter.Text = "Valider"
        Me.bn_Ajouter.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Annuler.Location = New System.Drawing.Point(609, 382)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(76, 28)
        Me.BT_Annuler.TabIndex = 36
        Me.BT_Annuler.Text = "Retour"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.BackColor = System.Drawing.Color.Transparent
        Me.lblSupp.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupp.Location = New System.Drawing.Point(169, 647)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(162, 19)
        Me.lblSupp.TabIndex = 37
        Me.lblSupp.Text = "Suppression avec succés"
        Me.lblSupp.Visible = False
        '
        'lblSuppe
        '
        Me.lblSuppe.AutoSize = True
        Me.lblSuppe.BackColor = System.Drawing.Color.Transparent
        Me.lblSuppe.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSuppe.Location = New System.Drawing.Point(189, 647)
        Me.lblSuppe.Name = "lblSuppe"
        Me.lblSuppe.Size = New System.Drawing.Size(153, 19)
        Me.lblSuppe.TabIndex = 38
        Me.lblSuppe.Text = "Suppression echouée !!"
        Me.lblSuppe.Visible = False
        '
        'lblmodif
        '
        Me.lblmodif.AutoSize = True
        Me.lblmodif.BackColor = System.Drawing.Color.Transparent
        Me.lblmodif.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblmodif.Location = New System.Drawing.Point(174, 647)
        Me.lblmodif.Name = "lblmodif"
        Me.lblmodif.Size = New System.Drawing.Size(218, 19)
        Me.lblmodif.TabIndex = 39
        Me.lblmodif.Text = "Modification réalisée avec succés"
        Me.lblmodif.Visible = False
        '
        'lblmodife
        '
        Me.lblmodife.AutoSize = True
        Me.lblmodife.BackColor = System.Drawing.Color.Transparent
        Me.lblmodife.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblmodife.Location = New System.Drawing.Point(189, 647)
        Me.lblmodife.Name = "lblmodife"
        Me.lblmodife.Size = New System.Drawing.Size(146, 19)
        Me.lblmodife.TabIndex = 40
        Me.lblmodife.Text = "Modification échouée"
        Me.lblmodife.Visible = False
        '
        'GestProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WA_GestStockTeleb.My.Resources.Resources.B3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1349, 646)
        Me.Controls.Add(Me.lblmodife)
        Me.Controls.Add(Me.lblmodif)
        Me.Controls.Add(Me.lblSuppe)
        Me.Controls.Add(Me.lblSupp)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.pn_Ajouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pn_Rechercher)
        Me.Controls.Add(Me.RB_Ajouter)
        Me.Controls.Add(Me.RB_Rechercher)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GestProduits"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pn_Rechercher.ResumeLayout(False)
        Me.pn_Rechercher.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_Ajouter.ResumeLayout(False)
        Me.pn_Ajouter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_Ajouter As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Rechercher As System.Windows.Forms.RadioButton
    Friend WithEvents pn_Rechercher As System.Windows.Forms.Panel
    Friend WithEvents cb_RechPdt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pn_Ajouter As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents txtDesig As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bn_Ajouter As System.Windows.Forms.Button
    Friend WithEvents BT_Annuler As System.Windows.Forms.Button
    Friend WithEvents lblAjout As System.Windows.Forms.Label
    Friend WithEvents lblSupp As System.Windows.Forms.Label
    Friend WithEvents lblSuppe As System.Windows.Forms.Label
    Friend WithEvents RB_Modem As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Puce As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Portable As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Recharge As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ModemR As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PuceR As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PortableR As System.Windows.Forms.RadioButton
    Friend WithEvents RB_RechargeR As System.Windows.Forms.RadioButton
    Friend WithEvents lblmodif As System.Windows.Forms.Label
    Friend WithEvents lblmodife As System.Windows.Forms.Label
    Friend WithEvents BTAnnuler As System.Windows.Forms.Button
    Friend WithEvents BtFerRech As System.Windows.Forms.Button
    Friend WithEvents BtFerAj As System.Windows.Forms.Button
    Friend WithEvents lblCategPdt As System.Windows.Forms.Label
    Friend WithEvents cb_categPdt As System.Windows.Forms.ComboBox
    Friend WithEvents desigPdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prixPdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantité As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPourcAch As System.Windows.Forms.TextBox
    Friend WithEvents lblPourcentAch As System.Windows.Forms.Label
    Friend WithEvents PourcAch As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
