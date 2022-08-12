Module Controle_saisie


    Public Sub Textbox_control(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal Nombre As Boolean, ByVal Est_entier As Boolean, ByVal Est_positif As Boolean, ByVal Alphabet As Boolean)
        Select Case e.KeyChar
            Case "0" To "9"
                If Nombre = False Then e.Handled = True
            Case " "
                If Alphabet = False Then e.Handled = True
            Case "a" To "z"
                If Alphabet = False Then e.Handled = True
            Case ".", ","
                If Est_entier = False Then
                    e.Handled = True
                Else
                    '    e.KeyChar = ","
                End If
          
            Case "-"
                If Est_positif = True Then
                    e.Handled = True
                Else
                    'enlever le moins précedent
                End If
            Case Else
                If (Char.IsControl(e.KeyChar)) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
        End Select
    End Sub
End Module
