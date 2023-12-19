Public Class frm_pedidos
    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_pedidos_ativos()

    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Me.Close()

    End Sub


End Class