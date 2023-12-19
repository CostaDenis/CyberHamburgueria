Public Class frmGerente
    Private Sub frmGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = log_nome
        img_foto.Image = Image.FromFile(log_foto)
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        frm_estoque.Show()
    End Sub

    Private Sub btn_contas_Click(sender As Object, e As EventArgs) Handles btn_contas.Click
        frm_contas.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        limpar_log()
        Me.Close()
    End Sub


End Class