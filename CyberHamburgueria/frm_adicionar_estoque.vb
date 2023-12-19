Public Class frm_adicionar_estoque


    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        adicionar_estoque(txt_nome.Text, Integer.Parse(txt_dias.Text), txt_data.Text, Integer.Parse(txt_peso.Text))
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub
End Class