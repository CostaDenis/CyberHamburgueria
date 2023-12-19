<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_contas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_contas))
        Me.tab_contas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_escolher_img = New System.Windows.Forms.Button()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_bloqueado = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rb_ativo = New System.Windows.Forms.RadioButton()
        Me.gb_tipo_conta = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_cargo = New System.Windows.Forms.ComboBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nome_completo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_voltar2 = New System.Windows.Forms.Button()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Statuss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tab_contas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gb_tipo_conta.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_contas
        '
        Me.tab_contas.Controls.Add(Me.TabPage1)
        Me.tab_contas.Controls.Add(Me.TabPage2)
        Me.tab_contas.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_contas.Location = New System.Drawing.Point(12, 12)
        Me.tab_contas.Name = "tab_contas"
        Me.tab_contas.SelectedIndex = 0
        Me.tab_contas.Size = New System.Drawing.Size(561, 541)
        Me.tab_contas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.btn_voltar)
        Me.TabPage1.Controls.Add(Me.btn_escolher_img)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.gb_tipo_conta)
        Me.TabPage1.Controls.Add(Me.txt_senha)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_nome_completo)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 512)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adicionar"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_cadastrar.FlatAppearance.BorderSize = 0
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(270, 477)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(208, 26)
        Me.btn_cadastrar.TabIndex = 20
        Me.btn_cadastrar.Text = "Salvar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(34, 477)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(208, 26)
        Me.btn_voltar.TabIndex = 21
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_escolher_img
        '
        Me.btn_escolher_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_escolher_img.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_escolher_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_escolher_img.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_escolher_img.ForeColor = System.Drawing.Color.White
        Me.btn_escolher_img.Location = New System.Drawing.Point(270, 420)
        Me.btn_escolher_img.Name = "btn_escolher_img"
        Me.btn_escolher_img.Size = New System.Drawing.Size(208, 30)
        Me.btn_escolher_img.TabIndex = 19
        Me.btn_escolher_img.Text = "Selecionar imagem"
        Me.btn_escolher_img.UseVisualStyleBackColor = False
        '
        'img_foto
        '
        Me.img_foto.Location = New System.Drawing.Point(270, 222)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(208, 192)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 18
        Me.img_foto.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.rb_bloqueado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.rb_ativo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(11, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 96)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(233, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 90)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'rb_bloqueado
        '
        Me.rb_bloqueado.AutoSize = True
        Me.rb_bloqueado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_bloqueado.Location = New System.Drawing.Point(103, 48)
        Me.rb_bloqueado.Name = "rb_bloqueado"
        Me.rb_bloqueado.Size = New System.Drawing.Size(102, 22)
        Me.rb_bloqueado.TabIndex = 16
        Me.rb_bloqueado.TabStop = True
        Me.rb_bloqueado.Text = "Bloqueado"
        Me.rb_bloqueado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Status"
        '
        'rb_ativo
        '
        Me.rb_ativo.AutoSize = True
        Me.rb_ativo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ativo.Location = New System.Drawing.Point(7, 48)
        Me.rb_ativo.Name = "rb_ativo"
        Me.rb_ativo.Size = New System.Drawing.Size(61, 22)
        Me.rb_ativo.TabIndex = 12
        Me.rb_ativo.TabStop = True
        Me.rb_ativo.Text = "Ativo"
        Me.rb_ativo.UseVisualStyleBackColor = True
        '
        'gb_tipo_conta
        '
        Me.gb_tipo_conta.Controls.Add(Me.Label6)
        Me.gb_tipo_conta.Controls.Add(Me.GroupBox1)
        Me.gb_tipo_conta.Controls.Add(Me.cb_cargo)
        Me.gb_tipo_conta.Location = New System.Drawing.Point(11, 216)
        Me.gb_tipo_conta.Name = "gb_tipo_conta"
        Me.gb_tipo_conta.Size = New System.Drawing.Size(231, 96)
        Me.gb_tipo_conta.TabIndex = 14
        Me.gb_tipo_conta.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de Conta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(233, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 90)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cb_cargo
        '
        Me.cb_cargo.FormattingEnabled = True
        Me.cb_cargo.Items.AddRange(New Object() {"Atendente", "Caixa", "Cozinha", "Gerência"})
        Me.cb_cargo.Location = New System.Drawing.Point(11, 44)
        Me.cb_cargo.Name = "cb_cargo"
        Me.cb_cargo.Size = New System.Drawing.Size(183, 24)
        Me.cb_cargo.TabIndex = 10
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(238, 174)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(240, 26)
        Me.txt_senha.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Senha"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(11, 174)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(213, 26)
        Me.txt_email.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email"
        '
        'txt_nome_completo
        '
        Me.txt_nome_completo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_completo.Location = New System.Drawing.Point(189, 104)
        Me.txt_nome_completo.Name = "txt_nome_completo"
        Me.txt_nome_completo.Size = New System.Drawing.Size(289, 26)
        Me.txt_nome_completo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txt_cpf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(11, 104)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(140, 26)
        Me.txt_cpf.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informar dados"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btn_voltar2)
        Me.TabPage2.Controls.Add(Me.dgv_contas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(553, 512)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 27)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Contas Cadastradas"
        '
        'btn_voltar2
        '
        Me.btn_voltar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btn_voltar2.FlatAppearance.BorderSize = 0
        Me.btn_voltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar2.ForeColor = System.Drawing.Color.White
        Me.btn_voltar2.Location = New System.Drawing.Point(172, 470)
        Me.btn_voltar2.Name = "btn_voltar2"
        Me.btn_voltar2.Size = New System.Drawing.Size(208, 26)
        Me.btn_voltar2.TabIndex = 22
        Me.btn_voltar2.Text = "Voltar"
        Me.btn_voltar2.UseVisualStyleBackColor = False
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_contas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPF, Me.Nome, Me.Email, Me.Statuss, Me.Cargo, Me.Excluir})
        Me.dgv_contas.Location = New System.Drawing.Point(0, 49)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.ReadOnly = True
        Me.dgv_contas.Size = New System.Drawing.Size(547, 369)
        Me.dgv_contas.TabIndex = 0
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Statuss
        '
        Me.Statuss.HeaderText = "Status"
        Me.Statuss.Name = "Statuss"
        Me.Statuss.ReadOnly = True
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Excluir.Width = 70
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(585, 565)
        Me.Controls.Add(Me.tab_contas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_contas"
        Me.Text = "Contas"
        Me.tab_contas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gb_tipo_conta.ResumeLayout(False)
        Me.gb_tipo_conta.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_contas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nome_completo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_ativo As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_cargo As ComboBox
    Friend WithEvents rb_bloqueado As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents gb_tipo_conta As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_escolher_img As Button
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Statuss As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents btn_voltar2 As Button
    Friend WithEvents Label8 As Label
End Class
