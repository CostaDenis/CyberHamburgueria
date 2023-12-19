Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        txt_senha.UseSystemPasswordChar = True
        cont = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_politica.Show()
    End Sub

    Private Sub btn_loginClick(sender As Object, e As EventArgs) Handles btn_login.Click

        Try
            If txt_cpf.Text = "   .   .   -" Or txt_senha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")

                If txt_cpf.Text = "   .   .   -" Then
                    txt_cpf.Focus()
                End If

                If txt_senha.Text = "" Then
                    txt_senha.Focus()
                End If

            Else
                sql = "select cpf, nome, email, senha, status, tipo_conta, foto from tb_contas where cpf = '" & txt_cpf.Text & "' and senha = '" & txt_senha.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    cont = cont + 1
                    If cont < 15 Then
                        MsgBox("Dados inválidos" + vbNewLine + "Tentativas restantes: " & 15 - cont, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                        txt_cpf.Focus()
                        Exit Sub

                    Else
                        MsgBox("Dados inválidos" + vbNewLine + "Limite de tentativas excedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Atenção!")
                        Me.Close()
                    End If
                Else
                    If rs.Fields(4).Value = "bloqueado" Then
                        MsgBox("Conta bloqueada" + vbNewLine + "Contate a gerência!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        Limpar_Login()

                        Exit Sub
                    Else
                        Limpar_Login()
                        Log_Atual(rs.Fields(1).Value, rs.Fields(5).Value, Application.StartupPath & "\fotos\" & rs.Fields(6).Value)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao fazer o login!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub Limpar_Login()
        txt_cpf.Clear()
        txt_senha.Clear()
        txt_cpf.Focus()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frm_esqueceu_senha.Show()
    End Sub
End Class
