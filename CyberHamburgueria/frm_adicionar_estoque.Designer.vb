<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adicionar_estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adicionar_estoque))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_dias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adicionar ao Estoque"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(115, 60)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(194, 29)
        Me.txt_nome.TabIndex = 2
        '
        'txt_data
        '
        Me.txt_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data.Location = New System.Drawing.Point(202, 143)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(95, 29)
        Me.txt_data.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data da Compra"
        '
        'txt_dias
        '
        Me.txt_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dias.Location = New System.Drawing.Point(530, 60)
        Me.txt_dias.Name = "txt_dias"
        Me.txt_dias.Size = New System.Drawing.Size(54, 29)
        Me.txt_dias.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tempo Durável"
        '
        'txt_peso
        '
        Me.txt_peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_peso.Location = New System.Drawing.Point(469, 147)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(110, 29)
        Me.txt_peso.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(386, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Gramas"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(330, 223)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(194, 36)
        Me.btn_confirmar.TabIndex = 10
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(115, 223)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(194, 36)
        Me.btn_voltar.TabIndex = 11
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_adicionar_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 322)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_dias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_adicionar_estoque"
        Me.Text = "Adicionar Estoque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_data As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_dias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_voltar As Button
End Class
