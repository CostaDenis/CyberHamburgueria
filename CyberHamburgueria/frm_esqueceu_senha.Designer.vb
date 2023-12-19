<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_esqueceu_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_esqueceu_senha))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome_completo = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(39, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Insira seus dados"
        '
        'txt_cpf
        '
        Me.txt_cpf.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txt_cpf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(46, 122)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(165, 26)
        Me.txt_cpf.TabIndex = 3
        '
        'txt_nome_completo
        '
        Me.txt_nome_completo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_completo.Location = New System.Drawing.Point(46, 209)
        Me.txt_nome_completo.Name = "txt_nome_completo"
        Me.txt_nome_completo.Size = New System.Drawing.Size(262, 26)
        Me.txt_nome_completo.TabIndex = 4
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(46, 292)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(262, 26)
        Me.txt_email.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome Completo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(46, 352)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(135, 37)
        Me.btn_voltar.TabIndex = 9
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(192, 352)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(135, 37)
        Me.btn_confirmar.TabIndex = 10
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'frm_esqueceu_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(375, 450)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nome_completo)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_esqueceu_senha"
        Me.Text = "Recuperar Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_nome_completo As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_confirmar As Button
End Class
