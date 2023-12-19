<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pedidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedidos))
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.id_Pedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pedido_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tota_pagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_comanda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_voltar2 = New System.Windows.Forms.Button()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Pedidos, Me.Pedido_, Me.Tota_pagar, Me.id_comanda})
        Me.dgv_pedidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_pedidos.Location = New System.Drawing.Point(56, 81)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.Size = New System.Drawing.Size(650, 342)
        Me.dgv_pedidos.TabIndex = 0
        '
        'id_Pedidos
        '
        Me.id_Pedidos.HeaderText = "Id Pedidos"
        Me.id_Pedidos.Name = "id_Pedidos"
        Me.id_Pedidos.Width = 91
        '
        'Pedido_
        '
        Me.Pedido_.HeaderText = "Pedido"
        Me.Pedido_.Name = "Pedido_"
        Me.Pedido_.Width = 71
        '
        'Tota_pagar
        '
        Me.Tota_pagar.HeaderText = "Total Pagar"
        Me.Tota_pagar.Name = "Tota_pagar"
        Me.Tota_pagar.Width = 94
        '
        'id_comanda
        '
        Me.id_comanda.HeaderText = "Comanda"
        Me.id_comanda.Name = "id_comanda"
        Me.id_comanda.Width = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 27)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Pedidos"
        '
        'btn_voltar2
        '
        Me.btn_voltar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_voltar2.FlatAppearance.BorderSize = 0
        Me.btn_voltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar2.ForeColor = System.Drawing.Color.White
        Me.btn_voltar2.Location = New System.Drawing.Point(292, 442)
        Me.btn_voltar2.Name = "btn_voltar2"
        Me.btn_voltar2.Size = New System.Drawing.Size(232, 34)
        Me.btn_voltar2.TabIndex = 25
        Me.btn_voltar2.Text = "Voltar"
        Me.btn_voltar2.UseVisualStyleBackColor = False
        '
        'frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.btn_voltar2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pedidos"
        Me.Text = "Pedidos"
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents id_Pedidos As DataGridViewTextBoxColumn
    Friend WithEvents Pedido_ As DataGridViewTextBoxColumn
    Friend WithEvents Tota_pagar As DataGridViewTextBoxColumn
    Friend WithEvents id_comanda As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_voltar2 As Button
End Class
