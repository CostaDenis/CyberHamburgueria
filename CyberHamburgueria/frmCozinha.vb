Public Class frmCozinha
    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        frm_pedidos.Show()
    End Sub

    Private Sub frmCozinha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = log_nome
        img_foto.Image = Image.FromFile(log_foto)
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        limpar_log()
        Me.Close()
    End Sub
End Class