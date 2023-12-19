Public Class frm_estoque
    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Estoque()
    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Me.Close()

    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        frm_adicionar_estoque.Show()
    End Sub
End Class