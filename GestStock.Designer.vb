<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestStock
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
        Me.pn_chargeSt = New System.Windows.Forms.Panel()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.lblEch = New System.Windows.Forms.Label()
        Me.lblQteSt = New System.Windows.Forms.Label()
        Me.RB_Modem = New System.Windows.Forms.RadioButton()
        Me.RB_Puce = New System.Windows.Forms.RadioButton()
        Me.RB_Portable = New System.Windows.Forms.RadioButton()
        Me.RB_Recharge = New System.Windows.Forms.RadioButton()
        Me.btValider = New System.Windows.Forms.Button()
        Me.BT_fermerAj = New System.Windows.Forms.Button()
        Me.lblChargement = New System.Windows.Forms.Label()
        Me.BT_AnnulerR = New System.Windows.Forms.Button()
        Me.txtQteCmd = New System.Windows.Forms.TextBox()
        Me.cb_desigPdt = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RB_Charger = New System.Windows.Forms.RadioButton()
        Me.RB_Consulter = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Entrées = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Désignation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SInit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sorties = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateArch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_ConsultArchiv = New System.Windows.Forms.Panel()
        Me.lblAnnee = New System.Windows.Forms.Label()
        Me.cbRechAn = New System.Windows.Forms.ComboBox()
        Me.lblPar = New System.Windows.Forms.Label()
        Me.BtFerRech = New System.Windows.Forms.Button()
        Me.lblJour = New System.Windows.Forms.Label()
        Me.lblMois = New System.Windows.Forms.Label()
        Me.cb_RechJour = New System.Windows.Forms.ComboBox()
        Me.Cb_Reche_Mois = New System.Windows.Forms.ComboBox()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblModifSt = New System.Windows.Forms.Label()
        Me.pn_chargeSt.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_ConsultArchiv.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_chargeSt
        '
        Me.pn_chargeSt.BackColor = System.Drawing.Color.Transparent
        Me.pn_chargeSt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_chargeSt.Controls.Add(Me.lblCap)
        Me.pn_chargeSt.Controls.Add(Me.lblEch)
        Me.pn_chargeSt.Controls.Add(Me.lblQteSt)
        Me.pn_chargeSt.Controls.Add(Me.RB_Modem)
        Me.pn_chargeSt.Controls.Add(Me.RB_Puce)
        Me.pn_chargeSt.Controls.Add(Me.RB_Portable)
        Me.pn_chargeSt.Controls.Add(Me.RB_Recharge)
        Me.pn_chargeSt.Controls.Add(Me.btValider)
        Me.pn_chargeSt.Controls.Add(Me.BT_fermerAj)
        Me.pn_chargeSt.Controls.Add(Me.lblChargement)
        Me.pn_chargeSt.Controls.Add(Me.BT_AnnulerR)
        Me.pn_chargeSt.Controls.Add(Me.txtQteCmd)
        Me.pn_chargeSt.Controls.Add(Me.cb_desigPdt)
        Me.pn_chargeSt.Controls.Add(Me.Label5)
        Me.pn_chargeSt.Controls.Add(Me.Label4)
        Me.pn_chargeSt.Controls.Add(Me.Label7)
        Me.pn_chargeSt.Location = New System.Drawing.Point(748, 173)
        Me.pn_chargeSt.Name = "pn_chargeSt"
        Me.pn_chargeSt.Size = New System.Drawing.Size(495, 355)
        Me.pn_chargeSt.TabIndex = 34
        Me.pn_chargeSt.Visible = False
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblCap.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCap.Location = New System.Drawing.Point(249, 206)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(83, 25)
        Me.lblCap.TabIndex = 45
        Me.lblCap.Text = "Capital :"
        '
        'lblEch
        '
        Me.lblEch.AutoSize = True
        Me.lblEch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEch.Location = New System.Drawing.Point(166, 303)
        Me.lblEch.Name = "lblEch"
        Me.lblEch.Size = New System.Drawing.Size(173, 21)
        Me.lblEch.TabIndex = 44
        Me.lblEch.Text = "Echec de chargement"
        Me.lblEch.Visible = False
        '
        'lblQteSt
        '
        Me.lblQteSt.AutoSize = True
        Me.lblQteSt.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblQteSt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQteSt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblQteSt.Location = New System.Drawing.Point(11, 206)
        Me.lblQteSt.Name = "lblQteSt"
        Me.lblQteSt.Size = New System.Drawing.Size(183, 25)
        Me.lblQteSt.TabIndex = 39
        Me.lblQteSt.Text = "Quantité en stock : "
        Me.lblQteSt.Visible = False
        '
        'RB_Modem
        '
        Me.RB_Modem.AutoSize = True
        Me.RB_Modem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Modem.Location = New System.Drawing.Point(360, 62)
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
        Me.RB_Puce.Location = New System.Drawing.Point(274, 62)
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
        Me.RB_Portable.Location = New System.Drawing.Point(166, 62)
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
        Me.RB_Recharge.Location = New System.Drawing.Point(38, 62)
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
        Me.btValider.Location = New System.Drawing.Point(131, 255)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(87, 28)
        Me.btValider.TabIndex = 33
        Me.btValider.Text = "Valider"
        Me.btValider.UseVisualStyleBackColor = True
        '
        'BT_fermerAj
        '
        Me.BT_fermerAj.Image = Global.WA_GestStockTeleb.My.Resources.Resources.fermer
        Me.BT_fermerAj.Location = New System.Drawing.Point(467, -2)
        Me.BT_fermerAj.Name = "BT_fermerAj"
        Me.BT_fermerAj.Size = New System.Drawing.Size(24, 24)
        Me.BT_fermerAj.TabIndex = 32
        Me.BT_fermerAj.UseVisualStyleBackColor = True
        '
        'lblChargement
        '
        Me.lblChargement.AutoSize = True
        Me.lblChargement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChargement.Location = New System.Drawing.Point(149, 303)
        Me.lblChargement.Name = "lblChargement"
        Me.lblChargement.Size = New System.Drawing.Size(172, 21)
        Me.lblChargement.TabIndex = 7
        Me.lblChargement.Text = "Stock a été mis à jour"
        Me.lblChargement.Visible = False
        '
        'BT_AnnulerR
        '
        Me.BT_AnnulerR.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_AnnulerR.Location = New System.Drawing.Point(241, 255)
        Me.BT_AnnulerR.Name = "BT_AnnulerR"
        Me.BT_AnnulerR.Size = New System.Drawing.Size(88, 28)
        Me.BT_AnnulerR.TabIndex = 6
        Me.BT_AnnulerR.Text = "Annuler"
        Me.BT_AnnulerR.UseVisualStyleBackColor = True
        '
        'txtQteCmd
        '
        Me.txtQteCmd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQteCmd.Location = New System.Drawing.Point(263, 148)
        Me.txtQteCmd.Name = "txtQteCmd"
        Me.txtQteCmd.Size = New System.Drawing.Size(91, 29)
        Me.txtQteCmd.TabIndex = 4
        '
        'cb_desigPdt
        '
        Me.cb_desigPdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_desigPdt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_desigPdt.FormattingEnabled = True
        Me.cb_desigPdt.Location = New System.Drawing.Point(213, 113)
        Me.cb_desigPdt.Name = "cb_desigPdt"
        Me.cb_desigPdt.Size = New System.Drawing.Size(188, 29)
        Me.cb_desigPdt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantité "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Désignation produit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(194, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Chargement du stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(565, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 38)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Gestion du stock"
        '
        'RB_Charger
        '
        Me.RB_Charger.AutoSize = True
        Me.RB_Charger.BackColor = System.Drawing.Color.Transparent
        Me.RB_Charger.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Charger.Location = New System.Drawing.Point(563, 71)
        Me.RB_Charger.Name = "RB_Charger"
        Me.RB_Charger.Size = New System.Drawing.Size(92, 22)
        Me.RB_Charger.TabIndex = 37
        Me.RB_Charger.Text = "Charger"
        Me.RB_Charger.UseVisualStyleBackColor = False
        '
        'RB_Consulter
        '
        Me.RB_Consulter.AutoSize = True
        Me.RB_Consulter.BackColor = System.Drawing.Color.Transparent
        Me.RB_Consulter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Consulter.Location = New System.Drawing.Point(680, 71)
        Me.RB_Consulter.Name = "RB_Consulter"
        Me.RB_Consulter.Size = New System.Drawing.Size(107, 22)
        Me.RB_Consulter.TabIndex = 36
        Me.RB_Consulter.Text = "Consulter"
        Me.RB_Consulter.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Entrées, Me.Désignation, Me.SInit, Me.SFin, Me.Sorties, Me.dateArch})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 355)
        Me.DataGridView1.TabIndex = 38
        '
        'Entrées
        '
        Me.Entrées.HeaderText = "Entrées"
        Me.Entrées.Name = "Entrées"
        '
        'Désignation
        '
        Me.Désignation.HeaderText = "Désignation"
        Me.Désignation.Name = "Désignation"
        '
        'SInit
        '
        Me.SInit.HeaderText = "Stock Initial"
        Me.SInit.Name = "SInit"
        '
        'SFin
        '
        Me.SFin.HeaderText = "Stock Final"
        Me.SFin.Name = "SFin"
        '
        'Sorties
        '
        Me.Sorties.HeaderText = "Sorties"
        Me.Sorties.Name = "Sorties"
        '
        'dateArch
        '
        Me.dateArch.HeaderText = "Date"
        Me.dateArch.Name = "dateArch"
        '
        'pn_ConsultArchiv
        '
        Me.pn_ConsultArchiv.BackColor = System.Drawing.Color.Transparent
        Me.pn_ConsultArchiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_ConsultArchiv.Controls.Add(Me.lblAnnee)
        Me.pn_ConsultArchiv.Controls.Add(Me.cbRechAn)
        Me.pn_ConsultArchiv.Controls.Add(Me.lblPar)
        Me.pn_ConsultArchiv.Controls.Add(Me.BtFerRech)
        Me.pn_ConsultArchiv.Controls.Add(Me.lblJour)
        Me.pn_ConsultArchiv.Controls.Add(Me.lblMois)
        Me.pn_ConsultArchiv.Controls.Add(Me.cb_RechJour)
        Me.pn_ConsultArchiv.Controls.Add(Me.Cb_Reche_Mois)
        Me.pn_ConsultArchiv.Location = New System.Drawing.Point(19, 111)
        Me.pn_ConsultArchiv.Name = "pn_ConsultArchiv"
        Me.pn_ConsultArchiv.Size = New System.Drawing.Size(586, 49)
        Me.pn_ConsultArchiv.TabIndex = 39
        Me.pn_ConsultArchiv.Visible = False
        '
        'lblAnnee
        '
        Me.lblAnnee.AutoSize = True
        Me.lblAnnee.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnee.Location = New System.Drawing.Point(78, 16)
        Me.lblAnnee.Name = "lblAnnee"
        Me.lblAnnee.Size = New System.Drawing.Size(60, 18)
        Me.lblAnnee.TabIndex = 53
        Me.lblAnnee.Text = "Année"
        '
        'cbRechAn
        '
        Me.cbRechAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechAn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRechAn.FormattingEnabled = True
        Me.cbRechAn.Location = New System.Drawing.Point(146, 11)
        Me.cbRechAn.Name = "cbRechAn"
        Me.cbRechAn.Size = New System.Drawing.Size(96, 26)
        Me.cbRechAn.TabIndex = 52
        '
        'lblPar
        '
        Me.lblPar.AutoSize = True
        Me.lblPar.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPar.Location = New System.Drawing.Point(14, 11)
        Me.lblPar.Name = "lblPar"
        Me.lblPar.Size = New System.Drawing.Size(56, 23)
        Me.lblPar.TabIndex = 51
        Me.lblPar.Text = "Par :"
        '
        'BtFerRech
        '
        Me.BtFerRech.Image = Global.WA_GestStockTeleb.My.Resources.Resources.fermer
        Me.BtFerRech.Location = New System.Drawing.Point(560, -2)
        Me.BtFerRech.Name = "BtFerRech"
        Me.BtFerRech.Size = New System.Drawing.Size(24, 24)
        Me.BtFerRech.TabIndex = 47
        Me.BtFerRech.UseVisualStyleBackColor = True
        '
        'lblJour
        '
        Me.lblJour.AutoSize = True
        Me.lblJour.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJour.Location = New System.Drawing.Point(422, 16)
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
        Me.lblMois.Location = New System.Drawing.Point(248, 14)
        Me.lblMois.Name = "lblMois"
        Me.lblMois.Size = New System.Drawing.Size(47, 18)
        Me.lblMois.TabIndex = 39
        Me.lblMois.Text = "Mois"
        Me.lblMois.Visible = False
        '
        'cb_RechJour
        '
        Me.cb_RechJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RechJour.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RechJour.FormattingEnabled = True
        Me.cb_RechJour.Location = New System.Drawing.Point(483, 11)
        Me.cb_RechJour.Name = "cb_RechJour"
        Me.cb_RechJour.Size = New System.Drawing.Size(48, 26)
        Me.cb_RechJour.TabIndex = 38
        Me.cb_RechJour.Visible = False
        '
        'Cb_Reche_Mois
        '
        Me.Cb_Reche_Mois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Reche_Mois.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Reche_Mois.FormattingEnabled = True
        Me.Cb_Reche_Mois.Location = New System.Drawing.Point(308, 13)
        Me.Cb_Reche_Mois.Name = "Cb_Reche_Mois"
        Me.Cb_Reche_Mois.Size = New System.Drawing.Size(96, 26)
        Me.Cb_Reche_Mois.TabIndex = 37
        Me.Cb_Reche_Mois.Visible = False
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Annuler.Location = New System.Drawing.Point(597, 566)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(100, 29)
        Me.BT_Annuler.TabIndex = 46
        Me.BT_Annuler.Text = "Retour"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(335, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblModifSt
        '
        Me.lblModifSt.AutoSize = True
        Me.lblModifSt.BackColor = System.Drawing.Color.Transparent
        Me.lblModifSt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifSt.Location = New System.Drawing.Point(269, 537)
        Me.lblModifSt.Name = "lblModifSt"
        Me.lblModifSt.Size = New System.Drawing.Size(269, 21)
        Me.lblModifSt.TabIndex = 48
        Me.lblModifSt.Text = "Modification du stock avec succés"
        Me.lblModifSt.Visible = False
        '
        'GestStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.WA_GestStockTeleb.My.Resources.Resources.B3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.lblModifSt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.pn_ConsultArchiv)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RB_Charger)
        Me.Controls.Add(Me.RB_Consulter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pn_chargeSt)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GestStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pn_chargeSt.ResumeLayout(False)
        Me.pn_chargeSt.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_ConsultArchiv.ResumeLayout(False)
        Me.pn_ConsultArchiv.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pn_chargeSt As System.Windows.Forms.Panel
    Friend WithEvents lblQteSt As System.Windows.Forms.Label
    Friend WithEvents RB_Modem As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Puce As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Portable As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Recharge As System.Windows.Forms.RadioButton
    Friend WithEvents btValider As System.Windows.Forms.Button
    Friend WithEvents BT_fermerAj As System.Windows.Forms.Button
    Friend WithEvents lblChargement As System.Windows.Forms.Label
    Friend WithEvents BT_AnnulerR As System.Windows.Forms.Button
    Friend WithEvents txtQteCmd As System.Windows.Forms.TextBox
    Friend WithEvents cb_desigPdt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_Charger As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Consulter As System.Windows.Forms.RadioButton
    Friend WithEvents lblEch As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pn_ConsultArchiv As System.Windows.Forms.Panel
    Friend WithEvents Cb_Reche_Mois As System.Windows.Forms.ComboBox
    Friend WithEvents lblJour As System.Windows.Forms.Label
    Friend WithEvents lblMois As System.Windows.Forms.Label
    Friend WithEvents cb_RechJour As System.Windows.Forms.ComboBox
    Friend WithEvents BT_Annuler As System.Windows.Forms.Button
    Friend WithEvents BtFerRech As System.Windows.Forms.Button
    Friend WithEvents lblPar As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Entrées As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Désignation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SInit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sorties As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateArch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblAnnee As System.Windows.Forms.Label
    Friend WithEvents cbRechAn As System.Windows.Forms.ComboBox
    Friend WithEvents lblModifSt As System.Windows.Forms.Label
    Friend WithEvents lblCap As System.Windows.Forms.Label
End Class
