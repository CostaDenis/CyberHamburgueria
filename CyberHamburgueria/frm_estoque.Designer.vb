<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estoque))
        Me.dgv_estoque = New System.Windows.Forms.DataGridView()
        Me.id_estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nomee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_voltar2 = New System.Windows.Forms.Button()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_estoque
        '
        Me.dgv_estoque.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_estoque, Me.Nomee, Me.Data_compra, Me.tempo, Me.Quantidade})
        Me.dgv_estoque.Location = New System.Drawing.Point(46, 84)
        Me.dgv_estoque.Name = "dgv_estoque"
        Me.dgv_estoque.Size = New System.Drawing.Size(560, 297)
        Me.dgv_estoque.TabIndex = 0
        '
        'id_estoque
        '
        Me.id_estoque.HeaderText = "ID"
        Me.id_estoque.Name = "id_estoque"
        '
        'Nomee
        '
        Me.Nomee.HeaderText = "Nome"
        Me.Nomee.Name = "Nomee"
        '
        'Data_compra
        '
        Me.Data_compra.HeaderText = "Data Compra"
        Me.Data_compra.Name = "Data_compra"
        '
        'tempo
        '
        Me.tempo.HeaderText = "Tempo Duravel (dias)"
        Me.tempo.Name = "tempo"
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quant (g)"
        Me.Quantidade.Name = "Quantidade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dados relacionados ao Estoque"
        '
        'btn_voltar2
        '
        Me.btn_voltar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_voltar2.FlatAppearance.BorderSize = 0
        Me.btn_voltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar2.ForeColor = System.Drawing.Color.White
        Me.btn_voltar2.Location = New System.Drawing.Point(131, 441)
        Me.btn_voltar2.Name = "btn_voltar2"
        Me.btn_voltar2.Size = New System.Drawing.Size(208, 26)
        Me.btn_voltar2.TabIndex = 23
        Me.btn_voltar2.Text = "Voltar"
        Me.btn_voltar2.UseVisualStyleBackColor = False
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_adicionar.FlatAppearance.BorderSize = 0
        Me.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adicionar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar.ForeColor = System.Drawing.Color.White
        Me.btn_adicionar.Location = New System.Drawing.Point(345, 441)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(208, 26)
        Me.btn_adicionar.TabIndex = 24
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'frm_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(643, 510)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.btn_voltar2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_estoque)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_estoque"
        Me.Text = "Estoque"
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_estoque As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_voltar2 As Button
    Friend WithEvents id_estoque As DataGridViewTextBoxColumn
    Friend WithEvents Nomee As DataGridViewTextBoxColumn
    Friend WithEvents Data_compra As DataGridViewTextBoxColumn
    Friend WithEvents tempo As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents btn_adicionar As Button
End Class
