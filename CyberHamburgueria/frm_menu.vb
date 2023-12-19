Public Class frm_menu
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        AtualizarEstoqueBD()
        lbl_hamb6d.Visible = True
        lbl_hamb6e.Visible = True
        lbl_hamb5d.Visible = True
        lbl_hamb5e.Visible = True
        lbl_hamb4d.Visible = True
        lbl_hamb4e.Visible = True
        lbl_hamb3d.Visible = True
        lbl_hamb3e.Visible = True
        lbl_hamb2d.Visible = True
        lbl_hamb2e.Visible = True
        lbl_hamb1d.Visible = True
        lbl_hamb1e.Visible = True

        lbl_beb1d.Visible = True
        lbl_beb1e.Visible = True
        lbl_beb2d.Visible = True
        lbl_beb2e.Visible = True
        lbl_beb3d.Visible = True
        lbl_beb3e.Visible = True
        lbl_beb4d.Visible = True
        lbl_beb4e.Visible = True
        lbl_beb5d.Visible = True
        lbl_beb5e.Visible = True


        lbl_porc1d.Visible = True
        lbl_porc1e.Visible = True
        lbl_porc2d.Visible = True
        lbl_porc2e.Visible = True
        lbl_porc3d.Visible = True
        lbl_porc3e.Visible = True
        lbl_porc4d.Visible = True
        lbl_porc4e.Visible = True

        lbl_sobre1d.Visible = True
        lbl_sobre1e.Visible = True
        lbl_sobre2d.Visible = True
        lbl_sobre2e.Visible = True
        lbl_sobre3d.Visible = True
        lbl_sobre3e.Visible = True
        lbl_sobre4d.Visible = True
        lbl_sobre4e.Visible = True
        lbl_sobre5d.Visible = True
        lbl_sobre5e.Visible = True

        carregar_hamb()
        carregar_beb()
        carregar_porc()
        carrega_sobre()
        Dim valor_texto = InputBox("Insira a comanda: ", "Entrada da Comanda")

        If Integer.TryParse(valor_texto, Comanda) = False Then
            MsgBox("Erro ao inserir a comanda. Tente Novamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Me.Close()

        Else

            If Verificar_Comanda(Comanda) = False Then

                MsgBox("Comanda não reconhecida! Tente Novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub img_hamb1_Click(sender As Object, e As EventArgs) Handles img_hamb1.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_hamb1, lbl_hamb1, lbl_preco_hamb1, Puxa_descricao_hamb(Puxa_id_hamb(lbl_hamb1.Text, "Hamb"), "Hamb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)

    End Sub

    Private Sub img_hamb2_Click(sender As Object, e As EventArgs) Handles img_hamb2.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_hamb2, lbl_hamb2, lbl_preco_hamb2, Puxa_descricao_hamb(Puxa_id_hamb(lbl_hamb2.Text, "Hamb"), "Hamb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)

    End Sub

    Private Sub img_hamb3_Click(sender As Object, e As EventArgs) Handles img_hamb3.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_hamb3, lbl_hamb3, lbl_preco_hamb3, Puxa_descricao_hamb(Puxa_id_hamb(lbl_hamb3.Text, "Hamb"), "Hamb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_hamb4_Click(sender As Object, e As EventArgs) Handles img_hamb4.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_hamb4, lbl_hamb4, lbl_preco_hamb4, Puxa_descricao_hamb(Puxa_id_hamb(lbl_hamb4.Text, "Hamb"), "Hamb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_hamb5_Click(sender As Object, e As EventArgs) Handles img_hamb5.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_hamb5, lbl_hamb5, lbl_preco_hamb5, Puxa_descricao_hamb(Puxa_id_hamb(lbl_hamb5.Text, "Hamb"), "Hamb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_hamb6_Click(sender As Object, e As EventArgs) Handles img_hamb6.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_hamb6, lbl_hamb6, lbl_preco_hamb6, Puxa_descricao_hamb(Puxa_id_hamb(lbl_hamb6.Text, "Hamb"), "Hamb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btn_aumentar_Click(sender As Object, e As EventArgs) Handles btn_aumentar.Click
        If esta_selecionado(img_selecionado) = True Then
            MsgBox("Selecione um lanche primeiro!")

        Else

            If ConferirEstoque(lbl_nome_selecionado.Text, Puxa_Categoria(lbl_nome_selecionado.Text)) = True Then

                qtde = Integer.Parse(txt_qtde.Text)
                qtde += 1
                txt_qtde.Text = qtde.ToString()

                preco_parcial = Double.Parse(qtde * lbl_preco_selecionado.Text)
                lbl_pp.Text = preco_parcial.ToString()
                lbl_pp.Text = lbl_pp.Text + ",00"

            Else

            End If

        End If

    End Sub

    Private Sub btn_diminuir_Click(sender As Object, e As EventArgs) Handles btn_diminuir.Click
        If esta_selecionado(img_selecionado) = True Then
            MsgBox("Selecione um lanche primeiro!")

        Else
            AumentarEstoque(Puxa_Categoria(lbl_nome_selecionado.Text), lbl_nome_selecionado.Text)
            qtde = Integer.Parse(txt_qtde.Text)
            qtde -= 1
            txt_qtde.Text = qtde.ToString()

            If qtde > 1 Then
                preco_parcial = Double.Parse(qtde * (lbl_preco_selecionado.Text - 1))
                lbl_pp.Text = preco_parcial.ToString()
                lbl_pp.Text = lbl_pp.Text + ",00"

            Else
                preco_parcial = Double.Parse(qtde * (lbl_preco_selecionado.Text))
                lbl_pp.Text = preco_parcial.ToString()
                lbl_pp.Text = lbl_pp.Text + ",00"
            End If

        End If

    End Sub

    Private Sub img_beb1_Click(sender As Object, e As EventArgs) Handles img_beb1.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_beb1, lbl_beb1, lbl_preco_beb1, Puxa_descricao_hamb(Puxa_id_hamb(lbl_beb1.Text, "Beb"), "Beb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_beb2_Click(sender As Object, e As EventArgs) Handles img_beb2.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_beb2, lbl_beb2, lbl_preco_beb2, Puxa_descricao_hamb(Puxa_id_hamb(lbl_beb2.Text, "Beb"), "Beb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_beb3_Click(sender As Object, e As EventArgs) Handles img_beb3.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_beb3, lbl_beb3, lbl_preco_beb3, Puxa_descricao_hamb(Puxa_id_hamb(lbl_beb3.Text, "Beb"), "Beb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_beb4_Click(sender As Object, e As EventArgs) Handles img_beb4.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_beb4, lbl_beb4, lbl_preco_beb4, Puxa_descricao_hamb(Puxa_id_hamb(lbl_beb4.Text, "Beb"), "Beb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_beb5_Click(sender As Object, e As EventArgs) Handles img_beb5.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_beb5, lbl_beb5, lbl_preco_beb5, Puxa_descricao_hamb(Puxa_id_hamb(lbl_beb5.Text, "Beb"), "Beb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_beb6_Click(sender As Object, e As EventArgs) Handles img_beb6.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_beb6, lbl_beb6, lbl_preco_beb6, Puxa_descricao_hamb(Puxa_id_hamb(lbl_beb6.Text, "Beb"), "Beb"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_porc1_Click(sender As Object, e As EventArgs) Handles img_porc1.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_porc1, lbl_porc1, lbl_preco_porc1, Puxa_descricao_hamb(Puxa_id_hamb(lbl_porc1.Text, "Porc"), "Porc"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_porc2_Click(sender As Object, e As EventArgs) Handles img_porc2.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_porc2, lbl_porc2, lbl_preco_porc2, Puxa_descricao_hamb(Puxa_id_hamb(lbl_porc2.Text, "Porc"), "Porc"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_porc3_Click(sender As Object, e As EventArgs) Handles img_porc3.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_porc3, lbl_porc3, lbl_preco_porc3, Puxa_descricao_hamb(Puxa_id_hamb(lbl_porc3.Text, "Porc"), "Porc"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_porc4_Click(sender As Object, e As EventArgs) Handles img_porc4.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_porc4, lbl_porc4, lbl_preco_porc4, Puxa_descricao_hamb(Puxa_id_hamb(lbl_porc4.Text, "Porc"), "Porc"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, -1)
    End Sub

    Private Sub img_sobre1_Click(sender As Object, e As EventArgs) Handles img_sobre1.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_sobre1, lbl_sobre1, lbl_preco_sobre1, Puxa_descricao_hamb(Puxa_id_hamb(lbl_sobre1.Text, "Sobre"), "Sobre"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_sobre2_Click(sender As Object, e As EventArgs) Handles img_sobre2.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_sobre2, lbl_sobre2, lbl_preco_sobre2, Puxa_descricao_hamb(Puxa_id_hamb(lbl_sobre2.Text, "Sobre"), "Sobre"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_sobre3_Click(sender As Object, e As EventArgs) Handles img_sobre3.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_sobre3, lbl_sobre3, lbl_preco_sobre3, Puxa_descricao_hamb(Puxa_id_hamb(lbl_sobre3.Text, "Sobre"), "Sobre"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_sobre4_Click(sender As Object, e As EventArgs) Handles img_sobre4.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_sobre4, lbl_sobre4, lbl_preco_sobre4, Puxa_descricao_hamb(Puxa_id_hamb(lbl_sobre4.Text, "Sobre"), "Sobre"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub img_sobre5_Click(sender As Object, e As EventArgs) Handles img_sobre5.Click
        visivel_lbl(lbl_d, lbl_e)
        zerar_campos(txt_qtde, lbl_pp)
        Mostra_selecionado(img_sobre5, lbl_sobre5, lbl_preco_sobre5, Puxa_descricao_hamb(Puxa_id_hamb(lbl_sobre5.Text, "Sobre"), "Sobre"))
        Centraliza_label_acima(lbl_nome_selecionado, img_selecionado)
        Centraliza_label_abaixo(lbl_preco_selecionado, img_selecionado)
        posiciona_label_esquerdo(lbl_preco_selecionado, lbl_d, -3)
        posiciona_label_direito(lbl_preco_selecionado, lbl_e, 4)
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        If IsNothing(img_selecionado.Image) = True Then
            MsgBox("Selecione um item primeiro!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If

        If txt_qtde.Text = "0" Then
            MsgBox("Insira a quantidade do produto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If

        If ConferirEstoque(lbl_nome_selecionado.Text, Puxa_Categoria(lbl_nome_selecionado.Text)) = True Then
            preco_item = Double.Parse(lbl_preco_selecionado.Text)
            preco_parcial = preco_item * Double.Parse(txt_qtde.Text)

            If lbl_total_pagar.Text <> "0,00" Then
                pedido = pedido & ", " & $"{Double.Parse(txt_qtde.Text)}x {lbl_nome_selecionado.Text}"
                total_pagar = total_pagar + preco_parcial
            Else
                pedido = $"{Double.Parse(txt_qtde.Text)}x {lbl_nome_selecionado.Text}"
                total_pagar = preco_parcial
            End If
        End If



        lbl_total_pagar.Text = total_pagar.ToString("C2")

    End Sub

    Private Sub btn_verificar_comanda_Click(sender As Object, e As EventArgs) Handles btn_verificar_comanda.Click
        MsgBox(pedido & ": R$" & total_pagar & ",00")
    End Sub

    Private Sub btn_confirmar_pedido_Click(sender As Object, e As EventArgs)
        If total_pagar = 0 Then
            MsgBox("Comanda Vazia!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Else
            frm_pagamento.Show()
        End If
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Try
            sql = "insert into tb_pedidos (Pedido, Total_pagar, id_comanda) values ('" & pedido & "', " & total_pagar & ", " & Comanda & ")"
            rs = db.Execute(sql)

            sql = "update tb_comandas set Pago= '" & "Não" & "' where id_comanda = " & Comanda & ""
            rs = db.Execute(sql)
            MsgBox("Pedido realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao realizar o pedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub


End Class