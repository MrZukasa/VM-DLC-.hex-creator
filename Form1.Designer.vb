<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MasterBin = New System.Windows.Forms.Button()
        Me.masterfolder = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SlaveBin = New System.Windows.Forms.Button()
        Me.MasterSW = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SlaveSW = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MasterBin
        '
        Me.MasterBin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.MasterBin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MasterBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MasterBin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterBin.Location = New System.Drawing.Point(12, 35)
        Me.MasterBin.Name = "MasterBin"
        Me.MasterBin.Size = New System.Drawing.Size(115, 56)
        Me.MasterBin.TabIndex = 0
        Me.MasterBin.Text = "Master"
        Me.MasterBin.UseVisualStyleBackColor = True
        '
        'masterfolder
        '
        Me.masterfolder.FileName = "OpenFileDialog1"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(146, 37)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(556, 54)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(146, 110)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(556, 59)
        Me.TextBox3.TabIndex = 5
        '
        'SlaveBin
        '
        Me.SlaveBin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SlaveBin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SlaveBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlaveBin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveBin.Location = New System.Drawing.Point(12, 108)
        Me.SlaveBin.Name = "SlaveBin"
        Me.SlaveBin.Size = New System.Drawing.Size(115, 61)
        Me.SlaveBin.TabIndex = 3
        Me.SlaveBin.Text = "Slave"
        Me.SlaveBin.UseVisualStyleBackColor = True
        '
        'MasterSW
        '
        Me.MasterSW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.MasterSW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MasterSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MasterSW.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterSW.Location = New System.Drawing.Point(12, 186)
        Me.MasterSW.Name = "MasterSW"
        Me.MasterSW.Size = New System.Drawing.Size(115, 166)
        Me.MasterSW.TabIndex = 6
        Me.MasterSW.Text = "Master SW"
        Me.MasterSW.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(146, 186)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(556, 166)
        Me.TextBox5.TabIndex = 7
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Location = New System.Drawing.Point(146, 376)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(556, 168)
        Me.TextBox6.TabIndex = 9
        '
        'SlaveSW
        '
        Me.SlaveSW.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SlaveSW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SlaveSW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SlaveSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlaveSW.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveSW.Location = New System.Drawing.Point(12, 376)
        Me.SlaveSW.Name = "SlaveSW"
        Me.SlaveSW.Size = New System.Drawing.Size(115, 168)
        Me.SlaveSW.TabIndex = 8
        Me.SlaveSW.Text = "Slave SW"
        Me.SlaveSW.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(708, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(757, 571)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.SlaveSW)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.MasterSW)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.SlaveBin)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MasterBin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valar Morghulis"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MasterBin As Button
    Friend WithEvents masterfolder As OpenFileDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SlaveBin As Button
    Friend WithEvents MasterSW As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents SlaveSW As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
