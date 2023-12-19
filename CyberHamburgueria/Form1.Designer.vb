<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblErroLogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.btn_login = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(376, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'lblErroLogin
        '
        Me.lblErroLogin.AutoSize = True
        Me.lblErroLogin.Location = New System.Drawing.Point(376, 50)
        Me.lblErroLogin.Name = "lblErroLogin"
        Me.lblErroLogin.Size = New System.Drawing.Size(0, 13)
        Me.lblErroLogin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(374, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cpf de usuário"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(376, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(376, 196)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(385, 26)
        Me.txt_senha.TabIndex = 9
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(376, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ao clicar em login você concorda com nossa"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(376, 235)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 19)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Mostrar senha"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Fuchsia
        Me.LinkLabel1.Location = New System.Drawing.Point(574, 277)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(129, 15)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "política de privacidade"
        '
        'txt_cpf
        '
        Me.txt_cpf.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txt_cpf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(376, 117)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(385, 26)
        Me.txt_cpf.TabIndex = 1
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(643, 239)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(118, 15)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Esqueceu a senha?"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(441, 328)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(262, 34)
        Me.btn_login.TabIndex = 34
        Me.btn_login.Text = "Entrar"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 426)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblErroLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblErroLogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents btn_login As Button
End Class
