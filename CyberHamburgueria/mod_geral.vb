Imports ADODB
Imports System.Data.OleDb

Module mod_geral

    'Banco de Dados

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public rs2 As New ADODB.Recordset
    Public rs3 As New ADODB.Recordset
    Public sql As String
    Public sql2 As String
    Public banco = Application.StartupPath & "\banco_de_dados\bd_lanches.mdb"


    'Variaveis para armazenamento

    Public cont, cont_hamb, cont_beb, cont_porc, cont_sobre As Integer
    Public tipo_conta, status, diretorio_img As String
    Public resp, aux_cpf As String
    Public id_aux As Integer
    Public desc_aux As String
    Public total_pagar As Double


    'Contadores
    Public qtde As Integer


    'Para compra
    Public preco_item As Double
    Public preco_parcial As Double
    Public pedido As String
    Public Comanda As Integer

    'Log Atual
    Public log_nome As String
    Public log_cargo As String
    Public log_foto As String

    Public Comanda_pagamento As Integer


    'Variaveis para posicionamento
    ' Public centerX As Integer
    ' Public LabelTop As Integer


    Sub conectar_banco_access()

        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source =" & banco)
            'MsgBox("Conectado ao Banco de dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "É nóis")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao Banco de Dados", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Acontece carai")

        End Try
    End Sub

    Sub carregar_dados()

        Try
            sql = "Select cpf, nome, email, status, tipo_conta from tb_contas order by nome"
            rs = db.Execute(sql)

            With frm_contas.dgv_contas
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados dos funcionários!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Sub carregar_todos_pedidos()

        Try
            sql = "select * from tb_pedidos"
            rs = db.Execute(sql)

            With frm_pedidos.dgv_pedidos
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os pedidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Sub carregar_pedidos_ativos()
        Dim comandaa As String
        Try
            sql = "SELECT * FROM tb_pedidos"
            rs = db.Execute(sql)

            With frm_pedidos.dgv_pedidos
                .Rows.Clear()

                Do While rs.EOF = False

                    comandaa = rs.Fields(3).Value
                    '.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Comanda)

                    ' Consulta paralela na tabela tb_comandas usando comanda
                    Dim sqlComandas As String = "SELECT * FROM tb_comandas WHERE id_comanda = " & comandaa & ""
                    Dim rsComandas As New Recordset
                    rsComandas = db.Execute(sqlComandas)


                    Do While rsComandas.EOF = False

                        If rsComandas.Fields(1).Value = "Não" Then
                            .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                        End If
                        rsComandas.MoveNext()
                    Loop

                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os pedidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Sub Carregar_Estoque()

        Try
            sql = "select * from tb_estoque"
            rs = db.Execute(sql)

            With frm_estoque
                .dgv_estoque.Rows.Clear()
                Do While rs.EOF = False
                    If EstaVencido(rs.Fields(2).Value, rs.Fields(3).Value) = False Then
                        .dgv_estoque.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)

                    Else
                        MsgBox("Produto " & rs.Fields(1).Value & " comprado no dia " & rs.Fields(2).Value & " está vencido!" + vbNewLine +
                               "Produto Excluído do Estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        sql2 = "delete * from tb_estoque where id_estoque = " & rs.Fields(0).Value & ""
                        rs2 = db.Execute(sql2)
                    End If
                    rs.MoveNext()
                Loop


            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os dados do estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Function EstaVencido(DataCompra As Date, duracao As Integer) As Boolean
        Dim DataAtual As Date = Date.Now
        Dim DataVencimento As Date = DataCompra.AddDays(duracao)

        If DataAtual > DataVencimento Then
            Return True

        Else
            Return False
        End If

    End Function

    Sub AtualizarEstoqueBD()
        Try
            sql = "Select * from tb_estoque"
            rs = db.Execute(sql)

            While rs.EOF = False
                If EstaVencido(rs.Fields(2).Value, rs.Fields(3).Value) = False Then

                Else
                    MsgBox("Produto " & rs.Fields(1).Value & " comprado no dia " & rs.Fields(2).Value & " está vencido!" + vbNewLine +
                               "Produto Excluído do Estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    sql2 = "delete * from tb_estoque where id_estoque = " & rs.Fields(0).Value & ""
                    rs2 = db.Execute(sql2)
                End If

                rs.MoveNext()
            End While


        Catch ex As Exception

        End Try
    End Sub


    Sub carregar_hamb()
        cont_hamb = 0
        Try
            sql = "Select Nome, Preco, Foto , Descricao from tb_hamb"
            rs = db.Execute(sql)

            Do While rs.EOF = False

                Select Case cont_hamb
                    Case 0
                        frm_menu.lbl_hamb1.Text = rs.Fields(0).Value
                        frm_menu.lbl_preco_hamb1.Text = rs.Fields(1).Value
                        frm_menu.img_hamb1.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Hamb\" & rs.Fields(2).Value)
                        Centraliza_label_acima(frm_menu.lbl_hamb1, frm_menu.img_hamb1)
                        'ajusta_lbl_preco(frm_menu.lbl_preco_hamb1.Text, frm_menu.lbl_preco_hamb1)
                        Centraliza_label_abaixo(frm_menu.lbl_preco_hamb1, frm_menu.img_hamb1)
                        posiciona_label_esquerdo(frm_menu.lbl_preco_hamb1, frm_menu.lbl_hamb1d, -3)
                        posiciona_label_direito(frm_menu.lbl_preco_hamb1, frm_menu.lbl_hamb1e, -1)

                    Case 1
                        frm_menu.lbl_hamb2.Text = rs.Fields(0).Value
                        frm_menu.lbl_preco_hamb2.Text = rs.Fields(1).Value
                        frm_menu.img_hamb2.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Hamb\" & rs.Fields(2).Value)
                        Centraliza_label_acima(frm_menu.lbl_hamb2, frm_menu.img_hamb2)
                        'ajusta_lbl_preco(frm_menu.lbl_preco_hamb2.Text, frm_menu.lbl_preco_hamb2)
                        Centraliza_label_abaixo(frm_menu.lbl_preco_hamb2, frm_menu.img_hamb2)
                        posiciona_label_esquerdo(frm_menu.lbl_preco_hamb2, frm_menu.lbl_hamb2d, -3)
                        posiciona_label_direito(frm_menu.lbl_preco_hamb2, frm_menu.lbl_hamb2e, -1)

                    Case 2
                        frm_menu.lbl_hamb3.Text = rs.Fields(0).Value
                        frm_menu.lbl_preco_hamb3.Text = rs.Fields(1).Value
                        frm_menu.img_hamb3.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Hamb\" & rs.Fields(2).Value)
                        Centraliza_label_acima(frm_menu.lbl_hamb3, frm_menu.img_hamb3)
                        'ajusta_lbl_preco(frm_menu.lbl_preco_hamb3.Text, frm_menu.lbl_preco_hamb3)
                        Centraliza_label_abaixo(frm_menu.lbl_preco_hamb3, frm_menu.img_hamb3)
                        posiciona_label_esquerdo(frm_menu.lbl_preco_hamb3, frm_menu.lbl_hamb3d, -3)
                        posiciona_label_direito(frm_menu.lbl_preco_hamb3, frm_menu.lbl_hamb3e, -1)

                    Case 3
                        frm_menu.lbl_hamb4.Text = rs.Fields(0).Value
                        frm_menu.lbl_preco_hamb4.Text = rs.Fields(1).Value
                        frm_menu.img_hamb4.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Hamb\" & rs.Fields(2).Value)
                        Centraliza_label_acima(frm_menu.lbl_hamb4, frm_menu.img_hamb4)
                        ' ajusta_lbl_preco(frm_menu.lbl_preco_hamb4.Text, frm_menu.lbl_preco_hamb4)
                        Centraliza_label_abaixo(frm_menu.lbl_preco_hamb4, frm_menu.img_hamb4)
                        posiciona_label_esquerdo(frm_menu.lbl_preco_hamb4, frm_menu.lbl_hamb4d, -3)
                        posiciona_label_direito(frm_menu.lbl_preco_hamb4, frm_menu.lbl_hamb4e, -1)

                    Case 4
                        frm_menu.lbl_hamb5.Text = rs.Fields(0).Value
                        frm_menu.lbl_preco_hamb5.Text = rs.Fields(1).Value
                        frm_menu.img_hamb5.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Hamb\" & rs.Fields(2).Value)
                        Centraliza_label_acima(frm_menu.lbl_hamb5, frm_menu.img_hamb5)
                        'ajusta_lbl_preco(frm_menu.lbl_preco_hamb5.Text, frm_menu.lbl_preco_hamb5)
                        Centraliza_label_abaixo(frm_menu.lbl_preco_hamb5, frm_menu.img_hamb5)
                        posiciona_label_esquerdo(frm_menu.lbl_preco_hamb5, frm_menu.lbl_hamb5d, -3)
                        posiciona_label_direito(frm_menu.lbl_preco_hamb5, frm_menu.lbl_hamb5e, -1)

                    Case 5
                        frm_menu.lbl_hamb6.Text = rs.Fields(0).Value
                        frm_menu.lbl_preco_hamb6.Text = rs.Fields(1).Value
                        frm_menu.img_hamb6.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Hamb\" & rs.Fields(2).Value)
                        Centraliza_label_acima(frm_menu.lbl_hamb6, frm_menu.img_hamb6)
                        'ajusta_lbl_preco(frm_menu.lbl_preco_hamb6.Text, frm_menu.lbl_preco_hamb6)
                        Centraliza_label_abaixo(frm_menu.lbl_preco_hamb6, frm_menu.img_hamb6)
                        posiciona_label_esquerdo(frm_menu.lbl_preco_hamb6, frm_menu.lbl_hamb6d, -3)
                        posiciona_label_direito(frm_menu.lbl_preco_hamb6, frm_menu.lbl_hamb6e, -1)


                End Select

                rs.MoveNext()
                cont_hamb += 1

            Loop

        Catch ex As Exception
            MsgBox("Erro ao carregar os Hamburgueres!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Sub carregar_beb()
        cont_beb = 0

        Try
            sql = "select Nome, Preco, Descricao, Foto from tb_beb"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                With frm_menu


                    Select Case cont_beb
                        Case 0
                            .lbl_beb1.Text = rs.Fields(0).Value
                            .lbl_preco_beb1.Text = rs.Fields(1).Value
                            .img_beb1.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Beb\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_beb1, frm_menu.img_beb1)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_beb1.Text, frm_menu.lbl_preco_beb1)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_beb1, frm_menu.img_beb1)
                            posiciona_label_esquerdo(.lbl_preco_beb1, .lbl_beb1d, -3)
                            posiciona_label_direito(.lbl_preco_beb1, .lbl_beb1e, 4)

                        Case 1
                            .lbl_beb2.Text = rs.Fields(0).Value
                            .lbl_preco_beb2.Text = rs.Fields(1).Value
                            .img_beb2.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Beb\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_beb2, frm_menu.img_beb2)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_beb2.Text, frm_menu.lbl_preco_beb2)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_beb2, frm_menu.img_beb2)
                            posiciona_label_esquerdo(.lbl_preco_beb2, .lbl_beb2d, -3)
                            posiciona_label_direito(.lbl_preco_beb2, .lbl_beb2e, 4)

                        Case 2
                            .lbl_beb3.Text = rs.Fields(0).Value
                            .lbl_preco_beb3.Text = rs.Fields(1).Value
                            .img_beb3.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Beb\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_beb3, frm_menu.img_beb3)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_beb3.Text, frm_menu.lbl_preco_beb3)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_beb3, frm_menu.img_beb3)
                            posiciona_label_esquerdo(.lbl_preco_beb3, .lbl_beb3d, -3)
                            posiciona_label_direito(.lbl_preco_beb3, .lbl_beb3e, 4)

                        Case 3
                            .lbl_beb4.Text = rs.Fields(0).Value
                            .lbl_preco_beb4.Text = rs.Fields(1).Value
                            .img_beb4.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Beb\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_beb4, frm_menu.img_beb4)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_beb4.Text, frm_menu.lbl_preco_beb4)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_beb4, frm_menu.img_beb4)
                            posiciona_label_esquerdo(.lbl_preco_beb4, .lbl_beb4d, -3)
                            posiciona_label_direito(.lbl_preco_beb4, .lbl_beb4e, 4)

                        Case 4
                            .lbl_beb5.Text = rs.Fields(0).Value
                            .lbl_preco_beb5.Text = rs.Fields(1).Value
                            .img_beb5.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Beb\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_beb5, frm_menu.img_beb5)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_beb5.Text, frm_menu.lbl_preco_beb5)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_beb5, frm_menu.img_beb5)
                            posiciona_label_esquerdo(.lbl_preco_beb5, .lbl_beb5d, -3)
                            posiciona_label_direito(.lbl_preco_beb5, .lbl_beb5e, 4)

                    End Select
                End With
                rs.MoveNext()
                cont_beb += 1
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar as bebidas!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Sub carregar_porc()
        cont_porc = 0

        Try

            sql = "Select Nome, Preco, Descricao, Foto from tb_porc"
            rs = db.Execute(sql)
            Do While rs.EOF = False


                With frm_menu


                    Select Case cont_porc
                        Case 0
                            .lbl_porc1.Text = rs.Fields(0).Value
                            .lbl_preco_porc1.Text = rs.Fields(1).Value
                            .img_porc1.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Porcao\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_porc1, frm_menu.img_porc1)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_porc1.Text, frm_menu.lbl_preco_porc1)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_porc1, frm_menu.img_porc1)
                            posiciona_label_esquerdo(.lbl_preco_porc1, .lbl_porc1d, -3)
                            posiciona_label_direito(.lbl_preco_porc1, .lbl_porc1e, 4)

                        Case 1
                            .lbl_porc2.Text = rs.Fields(0).Value
                            .lbl_preco_porc2.Text = rs.Fields(1).Value
                            .img_porc2.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Porcao\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_porc2, frm_menu.img_porc2)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_porc2.Text, frm_menu.lbl_preco_porc2)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_porc2, frm_menu.img_porc2)
                            posiciona_label_esquerdo(.lbl_preco_porc2, .lbl_porc2d, -3)
                            posiciona_label_direito(.lbl_preco_porc2, .lbl_porc2e, 4)

                        Case 2
                            .lbl_porc3.Text = rs.Fields(0).Value
                            .lbl_preco_porc3.Text = rs.Fields(1).Value
                            .img_porc3.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Porcao\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_porc3, frm_menu.img_porc3)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_porc3.Text, frm_menu.lbl_preco_porc3)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_porc3, frm_menu.img_porc3)
                            posiciona_label_esquerdo(.lbl_preco_porc3, .lbl_porc3d, -3)
                            posiciona_label_direito(.lbl_preco_porc3, .lbl_porc3e, 4)

                        Case 3
                            .lbl_porc4.Text = rs.Fields(0).Value
                            .lbl_preco_porc4.Text = rs.Fields(1).Value
                            .img_porc4.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Porcao\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_porc4, frm_menu.img_porc4)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_porc4.Text, frm_menu.lbl_preco_porc4)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_porc4, frm_menu.img_porc4)
                            posiciona_label_esquerdo(.lbl_preco_porc4, .lbl_porc4d, -3)
                            posiciona_label_direito(.lbl_preco_porc4, .lbl_porc4e, 4)
                    End Select
                End With
                rs.MoveNext()
                cont_porc += 1
            Loop

        Catch ex As Exception
            MsgBox("Erro ao carregar as Porções!", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)
        End Try

    End Sub

    Sub carrega_sobre()
        cont_sobre = 0

        Try


            sql = "Select Nome, Preco, Descricao, Foto from tb_sobre"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                With frm_menu

                    Select Case cont_sobre
                        Case 0
                            .lbl_sobre1.Text = rs.Fields(0).Value
                            .lbl_preco_sobre1.Text = rs.Fields(1).Value
                            .img_sobre1.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Sobremesas\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_sobre1, frm_menu.img_sobre1)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_sobre1.Text, frm_menu.lbl_preco_sobre1)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_sobre1, frm_menu.img_sobre1)
                            posiciona_label_esquerdo(.lbl_preco_sobre1, .lbl_sobre1d, -3)
                            posiciona_label_direito(.lbl_preco_sobre1, .lbl_sobre1e, 4)

                        Case 1
                            .lbl_sobre2.Text = rs.Fields(0).Value
                            .lbl_preco_sobre2.Text = rs.Fields(1).Value
                            .img_sobre2.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Sobremesas\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_sobre2, frm_menu.img_sobre2)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_sobre2.Text, frm_menu.lbl_preco_sobre2)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_sobre2, frm_menu.img_sobre2)
                            posiciona_label_esquerdo(.lbl_preco_sobre2, .lbl_sobre2d, -3)
                            posiciona_label_direito(.lbl_preco_sobre2, .lbl_sobre2e, 4)

                        Case 2
                            .lbl_sobre3.Text = rs.Fields(0).Value
                            .lbl_preco_sobre3.Text = rs.Fields(1).Value
                            .img_sobre3.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Sobremesas\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_sobre3, frm_menu.img_sobre3)
                            'ajusta_lbl_preco(frm_menu.lbl_preco_sobre3.Text, frm_menu.lbl_preco_sobre3)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_sobre3, frm_menu.img_sobre3)
                            posiciona_label_esquerdo(.lbl_preco_sobre3, .lbl_sobre3d, -3)
                            posiciona_label_direito(.lbl_preco_sobre3, .lbl_sobre3e, 4)

                        Case 3
                            .lbl_sobre4.Text = rs.Fields(0).Value
                            .lbl_preco_sobre4.Text = rs.Fields(1).Value
                            .img_sobre4.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Sobremesas\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_sobre4, frm_menu.img_sobre4)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_sobre4.Text, frm_menu.lbl_preco_sobre4)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_sobre4, frm_menu.img_sobre4)
                            posiciona_label_esquerdo(.lbl_preco_sobre4, .lbl_sobre4d, -3)
                            posiciona_label_direito(.lbl_preco_sobre4, .lbl_sobre4e, 4)

                        Case 4
                            .lbl_sobre5.Text = rs.Fields(0).Value
                            .lbl_preco_sobre5.Text = rs.Fields(1).Value
                            .img_sobre5.Image = Image.FromFile(Application.StartupPath & "\Pedidos\Sobremesas\" & rs.Fields(3).Value)
                            Centraliza_label_acima(frm_menu.lbl_sobre5, frm_menu.img_sobre5)
                            ' ajusta_lbl_preco(frm_menu.lbl_preco_sobre5.Text, frm_menu.lbl_preco_sobre5)
                            Centraliza_label_abaixo(frm_menu.lbl_preco_sobre5, frm_menu.img_sobre5)
                            posiciona_label_esquerdo(.lbl_preco_sobre5, .lbl_sobre5d, -3)
                            posiciona_label_direito(.lbl_preco_sobre5, .lbl_sobre5e, 4)
                    End Select
                End With
                rs.MoveNext()
                cont_sobre += 1
            Loop


        Catch ex As Exception
            MsgBox("Falha ao carregar as Sobremessas!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Sub Centraliza_label_acima(label As Label, imagem As PictureBox)

        Dim centerX As Integer = imagem.Left + imagem.Width / 2


        Dim labelTop As Integer = imagem.Top - label.Height - 10

        label.Left = centerX - label.Width / 2
        label.Top = labelTop
    End Sub

    Sub Centraliza_label_abaixo(label As Label, imagem As PictureBox)

        Dim centerX As Integer = imagem.Left + imagem.Width / 2

        Dim labelTop As Integer = imagem.Bottom + 10

        label.Left = centerX - label.Width / 2
        label.Top = labelTop
    End Sub

    Sub posiciona_label_esquerdo(labelAlvo As Label, novaLabel As Label, espacoEntreLabels As Integer)
        Dim largura As Integer = labelAlvo.Width
        Dim altura As Integer = labelAlvo.Height

        Dim esquerda As Integer = labelAlvo.Left + largura + espacoEntreLabels
        Dim top As Integer = labelAlvo.Top

        novaLabel.Left = esquerda
        novaLabel.Top = top
    End Sub

    Sub posiciona_label_direito(labelAlvo As Label, novaLabel As Label, espacoEntreLabels As Integer)
        Dim largura As Integer = labelAlvo.Width
        Dim altura As Integer = labelAlvo.Height

        Dim direita As Integer = labelAlvo.Left - largura - espacoEntreLabels
        Dim top As Integer = labelAlvo.Top

        novaLabel.Left = direita
        novaLabel.Top = top
    End Sub

    Sub Mostra_selecionado(imagem As PictureBox, nome As Label, preco As Label, descricao As String)

        With frm_menu
            .img_selecionado.Image = imagem.Image
            .lbl_nome_selecionado.Text = nome.Text
            .lbl_preco_selecionado.Text = preco.Text
            .txt_descricao_selecionado.Text = descricao

        End With
    End Sub

    Public Function Puxa_descricao_hamb(id As Integer, tipo As String) As String
        Dim consulta As String
        Try
            If tipo = "Hamb" Then
                consulta = "select Descricao from tb_hamb where id_pedido = " & id & ""
                rs = db.Execute(consulta)

            ElseIf tipo = "Beb" Then
                consulta = "select Descricao from tb_beb where id_beb = " & id & ""
                rs = db.Execute(consulta)

            ElseIf tipo = "Porc" Then
                consulta = "select Descricao from tb_porc where id_porc = " & id & ""
                rs = db.Execute(consulta)

            ElseIf tipo = "Sobre" Then
                consulta = "select Descricao from tb_sobre where id_sobre = " & id & ""
                rs = db.Execute(consulta)
            End If


        Catch ex As Exception
            MsgBox("Erro ao consultar a Descrição do produto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            If rs IsNot Nothing AndAlso rs.State = 1 Then
                rs.Close()
            End If
        End Try
        desc_aux = rs.Fields(0).Value
        Return desc_aux
    End Function

    Public Function Puxa_id_hamb(nome As String, tipo As String) As Integer
        Dim consulta As String
        Try
            If tipo = "Hamb" Then
                consulta = "select id_pedido from tb_hamb where Nome = '" & nome & "'"
                rs = db.Execute(consulta)

            ElseIf tipo = "Beb" Then
                consulta = "select id_beb from tb_beb where Nome = '" & nome & "'"
                rs = db.Execute(consulta)

            ElseIf tipo = "Porc" Then
                consulta = "select id_porc from tb_porc where Nome = '" & nome & "'"
                rs = db.Execute(consulta)
            ElseIf tipo = "Sobre" Then
                consulta = "select id_sobre from tb_sobre where nome = '" & nome & "'"
                rs = db.Execute(consulta)
            End If


        Catch ex As Exception
            MsgBox("Erro ao consultar a id do produto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            If rs IsNot Nothing AndAlso rs.State = 1 Then
                rs.Close()
            End If

        End Try
        id_aux = rs.Fields(0).Value
        Return id_aux
    End Function

    Sub ajusta_lbl_preco(preco As String, lbl As Label)
        lbl.Text = "R$ " & preco & ",00"
    End Sub

    Public Function esta_selecionado(imagem As PictureBox) As Boolean
        If IsNothing(imagem.Image) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub carregar_cmb_pag()

        Try
            sql = "select nome from tb_mtd_pag"
            rs = db.Execute(sql)

            With frm_pagamento.cmb_pag
                .Items.Clear()

                While rs.EOF = False
                    .Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                End While

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os Métodos de Pagamento disponíveis!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Public Function Verificar_Comanda(comanda As Integer) As Boolean
        Dim resp As Boolean
        Try
            sql = "Select * from tb_comandas"
            rs = db.Execute(sql)

            Do While rs.EOF = False

                If rs.Fields(0).Value = comanda Then
                    resp = True
                    Return resp
                    Exit Do
                Else
                    rs.MoveNext()
                End If
            Loop

            resp = False
            Return resp
        Catch ex As Exception
            MsgBox("Erro ao consultar as Comandas!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
        Return resp
    End Function

    Sub visivel_lbl(label1 As Label, label2 As Label)
        label1.Visible = True
        label2.Visible = True
    End Sub

    Sub zerar_campos(text1 As TextBox, text2 As Label)
        text1.Text = "0"
        text2.Text = "0"
    End Sub

    Sub Log_Atual(nome As String, cargo As String, foto As String)

        log_nome = nome
        log_cargo = cargo
        log_foto = foto

        If log_cargo = "Gerente" Then
            frmGerente.Show()

        ElseIf log_cargo = "Atendente" Then
            frmAtendente.Show()

        ElseIf log_cargo = "Cozinha" Then
            frmCozinha.Show()

        ElseIf log_cargo = "Caixa" Then
            frmCaixa.Show()
        End If

    End Sub

    Sub limpar_log()
        log_nome = ""
        log_cargo = ""
        log_foto = ""
    End Sub

    Function Verifica_valor_comanda(id_comanda As Integer) As Boolean

        Try
            sql = "select Pago from tb_comandas where id_comanda = " & id_comanda & ""
            rs = db.Execute(sql)

            If rs.Fields(0).Value = "Sim" Then
                MsgBox("Comanda esta vazia!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Return True

            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar a comanda!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

        Return False

    End Function

    Function retorna_valor_total_comanda(id_comanda As Integer) As Integer
        Dim valoor As Integer


        Try
            sql = "select Total_pagar from tb_pedidos where id_comanda= " & id_comanda & ""
            rs = db.Execute(sql)
            Do While rs.EOF = False
                valoor = valoor + rs.Fields(0).Value
                rs.MoveNext()
            Loop
            Return valoor
        Catch ex As Exception
            MsgBox("Erro ao consultar o valor total da comanda!")
        End Try

        Return valoor

    End Function

    Function retorna_pedido_total_comanda(id_comanda As Integer) As String
        Dim pedidoo As String

        Try
            sql = "select Pedido from tb_pedidos where id_comanda= " & id_comanda & ""
            rs = db.Execute(sql)
            Do While rs.EOF = False
                pedidoo = pedidoo + rs.Fields(0).Value
                rs.MoveNext()
            Loop
            Return pedidoo
        Catch ex As Exception
            MsgBox("Erro ao consultar o pedido total da comanda!")
        End Try

        Return pedidoo
    End Function

    Sub adicionar_estoque(nome As String, dias As Integer, data As String, peso As Integer)

        Try
            sql = "Insert into tb_estoque (Nome, Data_compra, Tempo, Quantidade) Values ('" & nome & "', '" & data & "', " & dias & ", " & peso & ")"
            rs = db.Execute(sql)
            MsgBox("Adicionado ao Estoque!")
        Catch ex As Exception
            MsgBox("Erro ao adicionar no Estoque!")
        End Try

    End Sub

    Sub DiminuirEstoque(tipo As String, nome_pedido As String)
        Dim ingrediente As String
        Dim cont_fields As Integer
        Dim cont_aux As Integer
        Dim sql_aux As String
        Dim sql_aux2 As String
        ingrediente = ""
        cont_fields = 2
        cont_aux = 0

        If tipo = "Hamburguer" Then

            sql = "select * from tb_hamb where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)


            While rs.EOF = False And cont_aux <> 8

                cont_fields += 1

                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If


                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then


                        If rs2.Fields(4).Value > 0 And rs2.Fields(4).Value - rs.Fields(cont_fields + 1).Value > 0 Then
                            sql_aux2 = "Update tb_estoque set Quantidade = Quantidade - " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                            rs2 = db.Execute(sql_aux2)

                        Else
                            MsgBox("Estoque Insuficiente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        End If
                    End If


                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While


        ElseIf tipo = "Bebida" Then

            sql = "select * from tb_beb where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)

            While rs.EOF = False And cont_aux <> 5

                cont_fields += 1

                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If

                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then
                        If rs2.Fields(4).Value > 0 And rs2.Fields(4).Value - rs.Fields(cont_fields + 1).Value > 0 Then
                            sql_aux2 = "Update tb_estoque set Quantidade = Quantidade - " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                            rs2 = db.Execute(sql_aux2)

                        Else
                            MsgBox("Estoque Insuficiente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        End If

                    End If

                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                'rs.MoveNext()
                cont_aux += 1

            End While


        ElseIf tipo = "Porção" Then

            sql = "select * from tb_porc where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)

            While rs.EOF = False And cont_aux <> 3

                cont_fields += 1

                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If

                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then
                        If rs2.Fields(4).Value > 0 And rs2.Fields(4).Value - rs.Fields(cont_fields + 1).Value > 0 Then
                            sql_aux2 = "Update tb_estoque set Quantidade = Quantidade - " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                            rs2 = db.Execute(sql_aux2)

                        Else
                            MsgBox("Estoque Insuficiente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        End If

                    End If

                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While

        ElseIf tipo = "Sobremessa" Then

            sql = "select * from tb_sobre where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)

            While rs.EOF = False And cont_aux <> 3

                cont_fields += 1
                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If

                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then

                        If rs2.Fields(4).Value > 0 And rs2.Fields(4).Value - rs.Fields(cont_fields + 1).Value > 0 Then
                            sql_aux2 = "Update tb_estoque set Quantidade = Quantidade - " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                            rs2 = db.Execute(sql_aux2)

                        Else
                            MsgBox("Estoque Insuficiente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        End If

                    End If

                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While


        End If

    End Sub

    Sub AumentarEstoque(tipo As String, nome_pedido As String)

        Dim ingrediente As String
        Dim cont_fields As Integer
        Dim cont_aux As Integer
        Dim sql_aux As String
        Dim sql_aux2 As String
        ingrediente = ""
        cont_fields = 2
        cont_aux = 0

        If tipo = "Hamburguer" Then

            sql = "select * from tb_hamb where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)


            While rs.EOF = False And cont_aux <> 8

                cont_fields += 1

                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If


                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then
                        sql_aux2 = "Update tb_estoque set Quantidade = Quantidade + " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                        rs2 = db.Execute(sql_aux2)
                    End If


                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While


        ElseIf tipo = "Bebida" Then

            sql = "select * from tb_beb where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)

            While rs.EOF = False And cont_aux <> 5

                cont_fields += 1

                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If

                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then
                        sql_aux2 = "Update tb_estoque set Quantidade = Quantidade + " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                        rs2 = db.Execute(sql_aux2)
                    End If

                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While


        ElseIf tipo = "Porção" Then

            sql = "select * from tb_porc where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)

            While rs.EOF = False And cont_aux <> 3

                cont_fields += 1

                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If

                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then
                        sql_aux2 = "Update tb_estoque set Quantidade = Quantidade + " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                        rs2 = db.Execute(sql_aux2)
                    End If

                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While

        ElseIf tipo = "Sobremessa" Then

            sql = "select * from tb_sobre where Nome = '" & nome_pedido & "'"
            rs = db.Execute(sql)

            While rs.EOF = False And cont_aux <> 3

                cont_fields += 1
                If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                    ingrediente = rs.Fields(cont_fields).Value
                End If

                Try
                    sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                    rs2 = db.Execute(sql_aux)

                    If Not rs2.EOF Then
                        sql_aux2 = "Update tb_estoque set Quantidade = Quantidade + " & rs.Fields(cont_fields + 1).Value & " where Nome = '" & ingrediente & "'"
                        rs2 = db.Execute(sql_aux2)
                    End If

                Catch ex As Exception
                    MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                cont_aux += 1

            End While


        End If

    End Sub


    Function Puxa_Categoria(nome As String) As String
        Dim cat As String
        cat = ""


        sql = "select * from tb_hamb"
        rs = db.Execute(sql)

        While Not rs.EOF
            If rs.Fields(1).Value = nome Then
                cat = "Hamburguer"
                Return cat
            End If
            rs.MoveNext()
        End While


        sql = "select * from tb_beb"
        rs = db.Execute(sql)

        While Not rs.EOF
            If rs.Fields(1).Value = nome Then
                cat = "Bebida"
                Return cat
            End If
            rs.MoveNext()
        End While

        sql = "select * from tb_porc"
        rs = db.Execute(sql)

        While Not rs.EOF
            If rs.Fields(1).Value = nome Then
                cat = "Porção"
                Return cat
            End If
            rs.MoveNext()
        End While

        sql = "select * from tb_sobre"
        rs = db.Execute(sql)

        While Not rs.EOF
            If rs.Fields(1).Value = nome Then
                cat = "Sobremessa"
                Return cat
            End If
            rs.MoveNext()
        End While

        Return cat
    End Function

    Function ConferirEstoque(nome As String, tipo As String) As Boolean

        Dim cat, ingrediente As String
        Dim cont, cont2 As Integer
        Dim cont_fields As Integer
        Dim sql_aux As String

        cont2 = 0
        cont_fields = 1
        ingrediente = ""

        Select Case tipo
            Case "Hamburguer"
                cat = "hamb"
                cont = 8

            Case "Bebida"
                cat = "beb"
                cont = 5

            Case "Porção"
                cat = "porc"
                cont = 3

            Case Else
                cat = "sobre"
                cont = 3
        End Select

        Try
            sql = "select * from tb_" & cat & " where Nome = '" & nome & "'"
            rs = db.Execute(sql)
        Catch ex As Exception
            MsgBox("Erro!")
        End Try

        While rs.EOF = False And cont2 <> cont

            cont_fields += 1
            If Not IsDBNull(rs.Fields(cont_fields).Value) Then
                ingrediente = rs.Fields(cont_fields).Value
            End If

            Try
                sql_aux = "select * from tb_estoque where Nome = '" & ingrediente & "'"
                rs2 = db.Execute(sql_aux)

                If Not rs2.EOF Then

                    If rs2.Fields(4).Value > 0 And rs2.Fields(4).Value - rs.Fields(cont_fields + 1).Value > 0 Then
                        DiminuirEstoque(tipo, nome)
                        Return True
                    Else
                        MsgBox("Estoque Insuficiente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        Return False
                    End If

                End If

            Catch ex As Exception
                MsgBox("Erro ao atualizar o estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Return False

            End Try

            cont2 += 1

        End While
        Return False

    End Function


End Module
