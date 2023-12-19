Public Class frmCaixa
    Private Sub frmCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = log_nome
        img_foto.Image = Image.FromFile(log_foto)
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        limpar_log()
        Me.Close()
    End Sub

    Private Sub btn_pagamento_Click(sender As Object, e As EventArgs) Handles btn_pagamento.Click
        frm_pagamento.Show()
    End Sub
End Class