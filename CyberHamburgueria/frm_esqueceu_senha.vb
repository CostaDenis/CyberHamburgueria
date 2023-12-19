Public Class frm_esqueceu_senha
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        Try
            sql = "select cpf, nome, email, senha, status, id_conta from tb_contas where cpf = '" & txt_cpf.Text & "' and nome = '" & txt_nome_completo.Text & "' and email = '" & txt_email.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then

                If rs.Fields(4).Value = "bloqueado" Then
                    MsgBox("Conta bloqueada! Função indisponível!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                    Limpar_esqueceu_senha()
                    Exit Sub
                End If


                MsgBox("Cpf = " & rs.Fields(0).Value + vbNewLine & "Senha = " & rs.Fields(3).Value, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Else
                MsgBox("Dados incompatíveis", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)
                Limpar_esqueceu_senha()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Limpar_esqueceu_senha()
        txt_cpf.Clear()
        txt_nome_completo.Clear()
        txt_email.Clear()
    End Sub
End Class