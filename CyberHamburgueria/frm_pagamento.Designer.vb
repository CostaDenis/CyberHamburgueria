<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pagamento
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pagamento))
        Me.txt_ped_selecionado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_pag = New System.Windows.Forms.ComboBox()
        Me.btn_confirmar_pedido = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_preco_final = New System.Windows.Forms.Label()
        Me.lbl_preco_final_e = New System.Windows.Forms.Label()
        Me.lbl_preco_final_d = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_comanda = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_ped_selecionado
        '
        Me.txt_ped_selecionado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ped_selecionado.Location = New System.Drawing.Point(84, 106)
        Me.txt_ped_selecionado.Multiline = True
        Me.txt_ped_selecionado.Name = "txt_ped_selecionado"
        Me.txt_ped_selecionado.ReadOnly = True
        Me.txt_ped_selecionado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ped_selecionado.Size = New System.Drawing.Size(199, 72)
        Me.txt_ped_selecionado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(88, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tela da Pagamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pedido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selecione o tipo de pagamento: "
        '
        'cmb_pag
        '
        Me.cmb_pag.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pag.FormattingEnabled = True
        Me.cmb_pag.Location = New System.Drawing.Point(289, 191)
        Me.cmb_pag.Name = "cmb_pag"
        Me.cmb_pag.Size = New System.Drawing.Size(160, 26)
        Me.cmb_pag.TabIndex = 5
        '
        'btn_confirmar_pedido
        '
        Me.btn_confirmar_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_confirmar_pedido.FlatAppearance.BorderSize = 0
        Me.btn_confirmar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar_pedido.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_pedido.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar_pedido.Location = New System.Drawing.Point(249, 294)
        Me.btn_confirmar_pedido.Name = "btn_confirmar_pedido"
        Me.btn_confirmar_pedido.Size = New System.Drawing.Size(195, 34)
        Me.btn_confirmar_pedido.TabIndex = 33
        Me.btn_confirmar_pedido.Text = "Confirmar Pedido"
        Me.btn_confirmar_pedido.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(48, 294)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(195, 34)
        Me.btn_voltar.TabIndex = 34
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(362, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Total a Pagar:"
        '
        'lbl_preco_final
        '
        Me.lbl_preco_final.AutoSize = True
        Me.lbl_preco_final.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco_final.Location = New System.Drawing.Point(406, 120)
        Me.lbl_preco_final.Name = "lbl_preco_final"
        Me.lbl_preco_final.Size = New System.Drawing.Size(17, 18)
        Me.lbl_preco_final.TabIndex = 37
        Me.lbl_preco_final.Text = "0"
        '
        'lbl_preco_final_e
        '
        Me.lbl_preco_final_e.AutoSize = True
        Me.lbl_preco_final_e.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco_final_e.Location = New System.Drawing.Point(362, 120)
        Me.lbl_preco_final_e.Name = "lbl_preco_final_e"
        Me.lbl_preco_final_e.Size = New System.Drawing.Size(28, 18)
        Me.lbl_preco_final_e.TabIndex = 38
        Me.lbl_preco_final_e.Text = "R$"
        Me.lbl_preco_final_e.Visible = False
        '
        'lbl_preco_final_d
        '
        Me.lbl_preco_final_d.AutoSize = True
        Me.lbl_preco_final_d.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco_final_d.Location = New System.Drawing.Point(438, 120)
        Me.lbl_preco_final_d.Name = "lbl_preco_final_d"
        Me.lbl_preco_final_d.Size = New System.Drawing.Size(30, 18)
        Me.lbl_preco_final_d.TabIndex = 39
        Me.lbl_preco_final_d.Text = ",00"
        Me.lbl_preco_final_d.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Comanda: "
        '
        'lbl_comanda
        '
        Me.lbl_comanda.AutoSize = True
        Me.lbl_comanda.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comanda.Location = New System.Drawing.Point(123, 66)
        Me.lbl_comanda.Name = "lbl_comanda"
        Me.lbl_comanda.Size = New System.Drawing.Size(68, 22)
        Me.lbl_comanda.TabIndex = 41
        Me.lbl_comanda.Text = "Label6"
        '
        'frm_pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(478, 345)
        Me.Controls.Add(Me.lbl_comanda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_preco_final_d)
        Me.Controls.Add(Me.lbl_preco_final_e)
        Me.Controls.Add(Me.lbl_preco_final)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_confirmar_pedido)
        Me.Controls.Add(Me.cmb_pag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ped_selecionado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pagamento"
        Me.Text = "Pagamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ped_selecionado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_pag As ComboBox
    Friend WithEvents btn_confirmar_pedido As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_preco_final As Label
    Friend WithEvents lbl_preco_final_e As Label
    Friend WithEvents lbl_preco_final_d As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_comanda As Label
End Class
