Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Module Module1


    ''   Option Explicit
    'Private Declare Sub InitCommonControls Lib "comctl32.dll" ()
    'Public Sub Main()
    '    InitCommonControls()
    '    ' Suite de votre code dans la Sub Main.

    'End Sub

    Public cn As New SqlConnection("Data Source=DESKTOP-SAN3PBB\SQLEXPRESS;Initial Catalog=GestStockTeleb;Integrated Security=true;MultipleActiveResultSets=True")

    Public cmd As New SqlCommand
    Public cmd1 As New SqlCommand
    Public cmd2 As New SqlCommand

    Public dr As SqlDataReader
    Public dr1 As SqlDataReader
    Public dr2 As SqlDataReader


    Public numC As Integer
    Public prix As Double
    Public cap As Double
    Public nom As String
    Public categ As String
    Public log As String
    Public pass As String
    Public type As String
    Public montGT As String
    Public resteS As String
    Public nomSoc As String

    Public etatC As String
    Public y As String
    Public cd As Integer
    Public codeCatg As Integer

    Public editR As New DataGridViewButtonColumn()
    Public supR As New DataGridViewButtonColumn()

    Public editP As New DataGridViewButtonColumn()
    Public supP As New DataGridViewButtonColumn()
    Public impCmd As New DataGridViewButtonColumn

    Public supCmd As New DataGridViewButtonColumn()
    Public editCmd As New DataGridViewButtonColumn()
    Public rempCmd As New DataGridViewButtonColumn()

    Public editStock As New DataGridViewButtonColumn()

    Public supDC As New DataGridViewButtonColumn()
    Public editDC As New DataGridViewButtonColumn()


    Public visDC As New DataGridViewButtonColumn()

    Public editF As New DataGridViewButtonColumn()
    Public supF As New DataGridViewButtonColumn()

    Public PayC As New DataGridViewButtonColumn()

    Public mont As Double
    Public montG As Double
    Public tot As Double
    Public pu As Double
    Public monTT As Double
    Public reste As Double
    Public cred As Double
    Public r As Double

    Public v As Integer
    Public i As Integer
    Public j As Integer
    Public k As Integer

    Public codeP As Integer
    Public codePa As Integer

    Public pourc As Double
    Public qteS As Integer
    Public d As Date
    Public d1 As Date
    Public dateC As Date

    Public etatP As String

    Public AncEnt As Integer
    Public ent As Integer
    Public desig As String
    Public SI As Integer
    Public SF As Integer
    Public sort As Integer
    Public cond As Integer

    Public codeSoc As Integer
    Public qte As Integer
    Public l As Double
    Public qteAnc As Integer
    Public qteNouv As Integer

    Public m As MsgBoxStyle
    Public nomR As String
    Public desPd As String
    Public x As String()

End Module
