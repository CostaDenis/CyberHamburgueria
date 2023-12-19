<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtendente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtendente))
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.Color.White
        Me.btn_menu.Location = New System.Drawing.Point(144, 312)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(193, 33)
        Me.btn_menu.TabIndex = 19
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(144, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(123, 78)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(96, 25)
        Me.btn_sair.TabIndex = 26
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 32)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Lanches"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 32)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cyber"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Atendente"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(120, 8)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(70, 22)
        Me.lbl_nome.TabIndex = 22
        Me.lbl_nome.Text = "(nome)"
        '
        'img_foto
        '
        Me.img_foto.Location = New System.Drawing.Point(3, 0)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(114, 103)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 21
        Me.img_foto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 75)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "_____________"
        '
        'frmAtendente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 394)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAtendente"
        Me.Text = "Atendente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label1 As Label
End Class
