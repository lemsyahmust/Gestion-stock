<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestClients))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn_Rechercher = New System.Windows.Forms.Panel()
        Me.BtFerRch = New System.Windows.Forms.Button()
        Me.cb_RechClient = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()

        ' Me.RB_Rechercher = New System.Windows.Forms.RadioButton()
        ' Me.RB_Ajouter = New System.Windows.Forms.RadioButton()
        Me.RB_Rechercher = New System.Windows.Forms.Button()
        Me.RB_Ajouter = New System.Windows.Forms.Button()

        Me.pn_Ajouter = New System.Windows.Forms.Panel()
        Me.ck_CliNorm = New System.Windows.Forms.CheckBox()
        Me.ck_Pourcentages = New System.Windows.Forms.CheckBox()
        Me.BtFerAj = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.lblAjout = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtteler = New System.Windows.Forms.TextBox()
        Me.txtadr = New System.Windows.Forms.TextBox()
        Me.txt_nomr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bn_Ajouter = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CatégoriePdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PourcentagePR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.lblSuppe = New System.Windows.Forms.Label()
        Me.lblmodife = New System.Windows.Forms.Label()
        Me.lblmodif = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTModifPourc = New System.Windows.Forms.Button()
        Me.lblModifPourc = New System.Windows.Forms.Label()
        Me.lblModifPourcE = New System.Windows.Forms.Label()
        Me.pn_Rechercher.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_Ajouter.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(508, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion des revendeurs"
        '
        'pn_Rechercher
        '
        Me.pn_Rechercher.BackColor = System.Drawing.Color.Transparent
        Me.pn_Rechercher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_Rechercher.Controls.Add(Me.BtFerRch)
        Me.pn_Rechercher.Controls.Add(Me.cb_RechClient)
        Me.pn_Rechercher.Controls.Add(Me.Label2)
        Me.pn_Rechercher.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pn_Rechercher.Location = New System.Drawing.Point(32, 82)
        Me.pn_Rechercher.Name = "pn_Rechercher"
        Me.pn_Rechercher.Size = New System.Drawing.Size(465, 52)
        Me.pn_Rechercher.TabIndex = 20
        Me.pn_Rechercher.Visible = False
        '
        'BtFerRch
        '
        Me.BtFerRch.Image = CType(resources.GetObject("BtFerRch.Image"), System.Drawing.Image)
        Me.BtFerRch.Location = New System.Drawing.Point(439, -2)
        Me.BtFerRch.Name = "BtFerRch"
        Me.BtFerRch.Size = New System.Drawing.Size(24, 24)
        Me.BtFerRch.TabIndex = 49
        Me.BtFerRch.UseVisualStyleBackColor = True
        '
        'cb_RechClient
        '
        Me.cb_RechClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RechClient.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RechClient.FormattingEnabled = True
        Me.cb_RechClient.Location = New System.Drawing.Point(267, 14)
        Me.cb_RechClient.Name = "cb_RechClient"
        Me.cb_RechClient.Size = New System.Drawing.Size(166, 26)
        Me.cb_RechClient.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(11, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sélectionnez votre revendeur"
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Annuler.Location = New System.Drawing.Point(589, 348)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(76, 28)
        Me.BT_Annuler.TabIndex = 8
        Me.BT_Annuler.Text = "Retour"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Adresse, Me.Tel})
        Me.DataGridView1.GridColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(32, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 400)
        Me.DataGridView1.TabIndex = 22
        '
        'Nom
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Nom.DefaultCellStyle = DataGridViewCellStyle1
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        '
        'Adresse
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Adresse.DefaultCellStyle = DataGridViewCellStyle2
        Me.Adresse.HeaderText = "Adresse"
        Me.Adresse.Name = "Adresse"
        '
        'Tel
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Tel.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tel.HeaderText = "Tel."
        Me.Tel.Name = "Tel"
        '
        'RB_Rechercher
        '
        'Me.RB_Rechercher.AutoSize = True
        Me.RB_Rechercher.BackColor = System.Drawing.Color.Transparent
        Me.RB_Rechercher.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Rechercher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RB_Rechercher.Location = New System.Drawing.Point(708, 82)
        Me.RB_Rechercher.Name = "RB_Rechercher"
        Me.RB_Rechercher.Size = New System.Drawing.Size(107, 50)
        Me.RB_Rechercher.TabIndex = 23
        Me.RB_Rechercher.TabStop = True
        Me.RB_Rechercher.Text = "Consulter"
        Me.RB_Rechercher.UseVisualStyleBackColor = False
        '
        'RB_Ajouter
        '
        ' Me.RB_Ajouter.AutoSize = True
        Me.RB_Ajouter.BackColor = System.Drawing.Color.Transparent
        Me.RB_Ajouter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ajouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RB_Ajouter.Location = New System.Drawing.Point(577, 82)
        Me.RB_Ajouter.Name = "RB_Ajouter"
        Me.RB_Ajouter.Size = New System.Drawing.Size(88, 50)
        Me.RB_Ajouter.TabIndex = 24
        Me.RB_Ajouter.TabStop = True
        Me.RB_Ajouter.Text = "Ajouter"
        Me.RB_Ajouter.UseVisualStyleBackColor = False
        '
        'pn_Ajouter
        '
        Me.pn_Ajouter.BackColor = System.Drawing.Color.Transparent
        Me.pn_Ajouter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_Ajouter.Controls.Add(Me.ck_CliNorm)
        Me.pn_Ajouter.Controls.Add(Me.ck_Pourcentages)
        Me.pn_Ajouter.Controls.Add(Me.BtFerAj)
        Me.pn_Ajouter.Controls.Add(Me.BTAnnuler)
        Me.pn_Ajouter.Controls.Add(Me.lblAjout)
        Me.pn_Ajouter.Controls.Add(Me.Label3)
        Me.pn_Ajouter.Controls.Add(Me.txtteler)
        Me.pn_Ajouter.Controls.Add(Me.txtadr)
        Me.pn_Ajouter.Controls.Add(Me.txt_nomr)
        Me.pn_Ajouter.Controls.Add(Me.Label6)
        Me.pn_Ajouter.Controls.Add(Me.Label5)
        Me.pn_Ajouter.Controls.Add(Me.Label4)
        Me.pn_Ajouter.Controls.Add(Me.bn_Ajouter)
        Me.pn_Ajouter.Location = New System.Drawing.Point(682, 153)
        Me.pn_Ajouter.Name = "pn_Ajouter"
        Me.pn_Ajouter.Size = New System.Drawing.Size(350, 348)
        Me.pn_Ajouter.TabIndex = 28
        Me.pn_Ajouter.Visible = False
        '
        'ck_CliNorm
        '
        Me.ck_CliNorm.AutoSize = True
        Me.ck_CliNorm.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_CliNorm.Location = New System.Drawing.Point(27, 52)
        Me.ck_CliNorm.Name = "ck_CliNorm"
        Me.ck_CliNorm.Size = New System.Drawing.Size(142, 22)
        Me.ck_CliNorm.TabIndex = 64
        Me.ck_CliNorm.Text = "Client normal"
        Me.ck_CliNorm.UseVisualStyleBackColor = True
        Me.ck_CliNorm.Visible = False
        '
        'ck_Pourcentages
        '
        Me.ck_Pourcentages.AutoSize = True
        Me.ck_Pourcentages.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_Pourcentages.Location = New System.Drawing.Point(27, 200)
        Me.ck_Pourcentages.Name = "ck_Pourcentages"
        Me.ck_Pourcentages.Size = New System.Drawing.Size(139, 22)
        Me.ck_Pourcentages.TabIndex = 63
        Me.ck_Pourcentages.Text = "Pourcentages"
        Me.ck_Pourcentages.UseVisualStyleBackColor = True
        '
        'BtFerAj
        '
        Me.BtFerAj.Image = CType(resources.GetObject("BtFerAj.Image"), System.Drawing.Image)
        Me.BtFerAj.Location = New System.Drawing.Point(325, -2)
        Me.BtFerAj.Name = "BtFerAj"
        Me.BtFerAj.Size = New System.Drawing.Size(24, 24)
        Me.BtFerAj.TabIndex = 49
        Me.BtFerAj.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAnnuler.Location = New System.Drawing.Point(179, 246)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(87, 28)
        Me.BTAnnuler.TabIndex = 30
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'lblAjout
        '
        Me.lblAjout.AutoSize = True
        Me.lblAjout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAjout.Location = New System.Drawing.Point(97, 286)
        Me.lblAjout.Name = "lblAjout"
        Me.lblAjout.Size = New System.Drawing.Size(157, 17)
        Me.lblAjout.TabIndex = 29
        Me.lblAjout.Text = "Ajout réalisé avec succés"
        Me.lblAjout.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(58, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ajout d'un nouveau revendeur"
        '
        'txtteler
        '
        Me.txtteler.Location = New System.Drawing.Point(154, 153)
        Me.txtteler.Name = "txtteler"
        Me.txtteler.Size = New System.Drawing.Size(135, 22)
        Me.txtteler.TabIndex = 9
        '
        'txtadr
        '
        Me.txtadr.Location = New System.Drawing.Point(154, 119)
        Me.txtadr.Name = "txtadr"
        Me.txtadr.Size = New System.Drawing.Size(136, 22)
        Me.txtadr.TabIndex = 8
        '
        'txt_nomr
        '
        Me.txt_nomr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nomr.Location = New System.Drawing.Point(153, 87)
        Me.txt_nomr.Name = "txt_nomr"
        Me.txt_nomr.Size = New System.Drawing.Size(137, 22)
        Me.txt_nomr.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Adresse "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(14, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nom complet"
        '
        'bn_Ajouter
        '
        Me.bn_Ajouter.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bn_Ajouter.Location = New System.Drawing.Point(71, 246)
        Me.bn_Ajouter.Name = "bn_Ajouter"
        Me.bn_Ajouter.Size = New System.Drawing.Size(87, 28)
        Me.bn_Ajouter.TabIndex = 2
        Me.bn_Ajouter.Text = "Valider"
        Me.bn_Ajouter.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatégoriePdt, Me.PourcentagePR})
        Me.DataGridView2.Location = New System.Drawing.Point(1052, 153)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(219, 348)
        Me.DataGridView2.TabIndex = 62
        Me.DataGridView2.Visible = False
        '
        'CatégoriePdt
        '
        Me.CatégoriePdt.HeaderText = "Catégorie"
        Me.CatégoriePdt.Name = "CatégoriePdt"
        '
        'PourcentagePR
        '
        Me.PourcentagePR.HeaderText = "Pourcentage"
        Me.PourcentagePR.Name = "PourcentagePR"
        Me.PourcentagePR.Width = 75
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.BackColor = System.Drawing.Color.Transparent
        Me.lblSupp.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupp.Location = New System.Drawing.Point(207, 568)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(162, 19)
        Me.lblSupp.TabIndex = 29
        Me.lblSupp.Text = "Suppression avec succés"
        Me.lblSupp.Visible = False
        '
        'lblSuppe
        '
        Me.lblSuppe.AutoSize = True
        Me.lblSuppe.BackColor = System.Drawing.Color.Transparent
        Me.lblSuppe.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSuppe.Location = New System.Drawing.Point(208, 568)
        Me.lblSuppe.Name = "lblSuppe"
        Me.lblSuppe.Size = New System.Drawing.Size(153, 19)
        Me.lblSuppe.TabIndex = 30
        Me.lblSuppe.Text = "Suppression echouée !!"
        Me.lblSuppe.Visible = False
        '
        'lblmodife
        '
        Me.lblmodife.AutoSize = True
        Me.lblmodife.BackColor = System.Drawing.Color.Transparent
        Me.lblmodife.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblmodife.Location = New System.Drawing.Point(221, 583)
        Me.lblmodife.Name = "lblmodife"
        Me.lblmodife.Size = New System.Drawing.Size(146, 19)
        Me.lblmodife.TabIndex = 44
        Me.lblmodife.Text = "Modification échouée"
        Me.lblmodife.Visible = False
        '
        'lblmodif
        '
        Me.lblmodif.AutoSize = True
        Me.lblmodif.BackColor = System.Drawing.Color.Transparent
        Me.lblmodif.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblmodif.Location = New System.Drawing.Point(190, 568)
        Me.lblmodif.Name = "lblmodif"
        Me.lblmodif.Size = New System.Drawing.Size(218, 19)
        Me.lblmodif.TabIndex = 43
        Me.lblmodif.Text = "Modification réalisée avec succés"
        Me.lblmodif.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(213, 568)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Suppression echouée !!"
        Me.Label8.Visible = False
        '
        'BTModifPourc
        '
        Me.BTModifPourc.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModifPourc.Location = New System.Drawing.Point(1125, 507)
        Me.BTModifPourc.Name = "BTModifPourc"
        Me.BTModifPourc.Size = New System.Drawing.Size(101, 28)
        Me.BTModifPourc.TabIndex = 63
        Me.BTModifPourc.Text = "Modifier"
        Me.BTModifPourc.UseVisualStyleBackColor = True
        Me.BTModifPourc.Visible = False
        '
        'lblModifPourc
        '
        Me.lblModifPourc.AutoSize = True
        Me.lblModifPourc.BackColor = System.Drawing.Color.Transparent
        Me.lblModifPourc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblModifPourc.Location = New System.Drawing.Point(1003, 534)
        Me.lblModifPourc.Name = "lblModifPourc"
        Me.lblModifPourc.Size = New System.Drawing.Size(320, 19)
        Me.lblModifPourc.TabIndex = 64
        Me.lblModifPourc.Text = "Modification du pourcentage réalisée avec succés"
        Me.lblModifPourc.Visible = False
        '
        'lblModifPourcE
        '
        Me.lblModifPourcE.AutoSize = True
        Me.lblModifPourcE.BackColor = System.Drawing.Color.Transparent
        Me.lblModifPourcE.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblModifPourcE.Location = New System.Drawing.Point(1003, 534)
        Me.lblModifPourcE.Name = "lblModifPourcE"
        Me.lblModifPourcE.Size = New System.Drawing.Size(248, 19)
        Me.lblModifPourcE.TabIndex = 65
        Me.lblModifPourcE.Text = "Modification du pourcentage échouée" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblModifPourcE.Visible = False
        '
        'GestClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 742)
        Me.Controls.Add(Me.lblModifPourcE)
        Me.Controls.Add(Me.lblModifPourc)
        Me.Controls.Add(Me.BTModifPourc)
        Me.Controls.Add(Me.lblmodife)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lblmodif)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSuppe)
        Me.Controls.Add(Me.lblSupp)
        Me.Controls.Add(Me.pn_Ajouter)
        Me.Controls.Add(Me.RB_Ajouter)
        Me.Controls.Add(Me.RB_Rechercher)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pn_Rechercher)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "GestClients"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pn_Rechercher.ResumeLayout(False)
        Me.pn_Rechercher.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_Ajouter.ResumeLayout(False)
        Me.pn_Ajouter.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pn_Rechercher As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_RechClient As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    ' Friend WithEvents RevendeurTableAdapter1 As WA_GestStockTeleb.GestStockTelebDataSetTableAdapters.RevendeurTableAdapter
    Friend WithEvents BT_Annuler As System.Windows.Forms.Button
    'Friend WithEvents RB_Rechercher As System.Windows.Forms.RadioButton
    'Friend WithEvents RB_Ajouter As System.Windows.Forms.RadioButton

    Friend WithEvents RB_Rechercher As System.Windows.Forms.Button
    Friend WithEvents RB_Ajouter As System.Windows.Forms.Button

    Friend WithEvents pn_Ajouter As System.Windows.Forms.Panel
    Friend WithEvents txtteler As System.Windows.Forms.TextBox
    Friend WithEvents txtadr As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bn_Ajouter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAjout As System.Windows.Forms.Label
    Friend WithEvents lblSupp As System.Windows.Forms.Label
    Friend WithEvents lblSuppe As System.Windows.Forms.Label
    Friend WithEvents lblmodife As System.Windows.Forms.Label
    Friend WithEvents lblmodif As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTAnnuler As System.Windows.Forms.Button
    Friend WithEvents BtFerAj As System.Windows.Forms.Button
    Friend WithEvents BtFerRch As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ck_Pourcentages As System.Windows.Forms.CheckBox
    Friend WithEvents BTModifPourc As System.Windows.Forms.Button
    Friend WithEvents lblModifPourc As System.Windows.Forms.Label
    Friend WithEvents lblModifPourcE As System.Windows.Forms.Label
    Friend WithEvents CatégoriePdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PourcentagePR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ck_CliNorm As System.Windows.Forms.CheckBox
End Class
