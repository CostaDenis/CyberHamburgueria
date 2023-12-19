Public Class frmAtendente
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs)
        limpar_log()
        Me.Close()
    End Sub

    Private Sub frmAtendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = log_nome
        img_foto.Image = Image.FromFile(log_foto)
    End Sub

    Private Sub btn_sair_Click_1(sender As Object, e As EventArgs) Handles btn_sair.Click
        limpar_log()
        Me.Close()
    End Sub
End Class