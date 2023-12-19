Imports System.Windows.Forms

Public Class frm_contas

    Private Sub btn_escolher_img_Click(sender As Object, e As EventArgs) Handles btn_escolher_img.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Arquivos de imagem|*.bmp;*.jpg;*.jpeg;*.gif;*.png"
        openFileDialog1.Title = "Selecione uma foto!"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            img_foto.Image = New System.Drawing.Bitmap(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click

        Try

            If txt_cpf.Text = "   .   .   -" Or txt_nome_completo.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or cb_cargo.Text = "" Or (rb_ativo.Checked Or rb_bloqueado.Checked) = False Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")

            Else
                Select Case cb_cargo.SelectedIndex
                    Case 0
                        tipo_conta = "Atendente"

                    Case 1
                        tipo_conta = "Caixa"

                    Case 2
                        tipo_conta = "Cozinha"

                    Case 3
                        tipo_conta = "Gerente"
                End Select


                If rb_ativo.Checked = True Then
                    Status = "Ativo"
                Else
                    Status = "Bloqueado"
                End If

                sql = "Select id_conta from tb_contas where cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    sql = "select id_conta from tb_contas"
                    rs = db.Execute(sql)
                    cont = 0

                    rs = db.Execute(sql)
                    cont = 0

                    While rs.EOF = False
                        cont += 1
                        rs.MoveNext()

                    End While

                    sql = "INSERT INTO tb_contas (cpf, nome, email, senha, status, tipo_conta, foto) VALUES ('" & txt_cpf.Text & "', '" & txt_nome_completo.Text & "', '" & txt_email.Text & "', '" & txt_senha.Text & "', '" & Status & "', '" & tipo_conta & "', '" & diretorio_img & "')"
                    rs = db.Execute(sql)
                    MsgBox("Dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    limpar_tela()


                Else
                    sql = "Update tb_contas set nome = '" & txt_nome_completo.Text & "', email = '" & txt_email.Text & "', " &
                          "senha = '" & txt_senha.Text & "', status = '" & status & "', " &
                          "tipo_conta = '" & tipo_conta & "', foto = '" & diretorio_img & "' where cpf = '" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    limpar_tela()
                End If

            End If
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try



    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1

                .InitialDirectory = Application.StartupPath & "\fotos\"
                .Title = "Selecione uma foto!"
                .ShowDialog()
                diretorio_img = .SafeFileName
                img_foto.Load(Application.StartupPath & "\fotos\" & diretorio_img)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub limpar_tela()
        txt_cpf.Clear()
        txt_email.Clear()
        txt_nome_completo.Clear()
        txt_senha.Clear()
        cb_cargo.Text = ""
        rb_ativo.Checked = False
        rb_bloqueado.Checked = False
        img_foto.Image = Nothing
    End Sub

    Private Sub txt_cpf_Leave(sender As Object, e As EventArgs) Handles txt_cpf.Leave

        Try

            sql = "Select cpf, nome, email, senha, status, tipo_conta, foto from tb_contas where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                txt_nome_completo.Focus()

            Else
                txt_nome_completo.Text = rs.Fields(1).Value
                txt_email.Text = rs.Fields(2).Value
                txt_senha.Text = rs.Fields(3).Value

                If rs.Fields(4).Value = "Ativo" Then
                    rb_ativo.Checked = True
                    rb_bloqueado.Checked = False
                Else
                    rb_bloqueado.Checked = True
                    rb_ativo.Checked = False
                End If

                Select Case rs.Fields(5).Value
                    Case "Atendente"
                        cb_cargo.SelectedIndex = 0

                    Case "Caixa"
                        cb_cargo.SelectedIndex = 1

                    Case "Cozinha"
                        cb_cargo.SelectedIndex = 2

                    Case "Gerente"
                        cb_cargo.SelectedIndex = 3
                End Select
                img_foto.Image = Image.FromFile(rs.Fields(6).Value)

            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar os dados!")
        End Try

    End Sub

    Private Sub frm_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_dados()

    End Sub

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick

        Try
            With dgv_contas

                If .CurrentRow.Cells(5).Selected = True Then

                    resp = MsgBox("A conta contendo o CPF: " & .CurrentRow.Cells(0).Value & " será excluido do sistema! Deseja continuar?", MsgBoxStyle.Information + vbOKCancel, "Atenção")

                    If resp = MsgBoxResult.Ok Then
                        sql = "delete * from tb_contas where cpf ='" & .CurrentRow.Cells(0).Value & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                    End If
                End If

            End With
        Catch ex As Exception
            MsgBox("Erro ao excluir o registro do Cpf: " & dgv_contas.CurrentRow.Cells(0).Value & "", MsgBoxStyle.Critical + vbOKOnly, "Erro ao excluir!")
        End Try


    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Me.Close()
    End Sub
End Class