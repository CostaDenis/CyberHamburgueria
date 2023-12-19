Public Class frm_pagamento
    Private Sub frm_pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valor_texto = InputBox("Insira a comanda: ", "Entrada da Comanda")
        If Integer.TryParse(valor_texto, Comanda_pagamento) = False Then
            MsgBox("Erro ao inserir a comanda. Tente Novamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Me.Close()

        Else

            If Verificar_Comanda(Comanda_pagamento) = False Then

                MsgBox("Comanda não reconhecida! Tente Novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Me.Close()
            End If

        End If

        If Verifica_valor_comanda(Comanda_pagamento) = True Then
            Me.Close()
        End If


        lbl_preco_final_d.Visible = True
        lbl_preco_final_e.Visible = True
        carregar_cmb_pag()

        txt_ped_selecionado.Text = retorna_pedido_total_comanda(Comanda_pagamento)
        lbl_preco_final.Text = retorna_valor_total_comanda(Comanda_pagamento).ToString

        posiciona_label_esquerdo(lbl_preco_final, lbl_preco_final_d, 8)
        posiciona_label_direito(lbl_preco_final, lbl_preco_final_e, -1)
        lbl_comanda.Text = Comanda_pagamento.ToString



    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()

    End Sub

    Private Sub btn_confirmar_pedido_Click(sender As Object, e As EventArgs) Handles btn_confirmar_pedido.Click

        If cmb_pag.Text = "" Then
            MsgBox("Selecione um método de pagamento primeiro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        Else
            Try
                'sql = "Insert Into tb_pedidos (Pedido, Total_pagar, id_comanda) Values ('" & retorna_pedido_total_comanda(Comanda_pagamento) & "', " & retorna_valor_total_comanda(Comanda_pagamento) & ", " & Comanda_pagamento & ")"
                sql = "Delete * from tb_pedidos where id_comanda = " & Comanda_pagamento & ""
                rs = db.Execute(sql)

                sql = "Update tb_comandas set Pago = '" & "Sim" & "' where id_comanda = " & Comanda & ""
                rs = db.Execute(sql)

                MsgBox("Compra Finalizada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Catch ex As Exception
                MsgBox("Erro ao gravar pedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

            Me.Close()

        End If

    End Sub


End Class