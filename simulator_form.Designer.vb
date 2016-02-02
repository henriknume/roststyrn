<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(526, 66)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(192, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'ProgressBar2
        '
        Me.ProgressBar2.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar2.Location = New System.Drawing.Point(526, 132)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(192, 40)
        Me.ProgressBar2.TabIndex = 1
        '
        'ProgressBar3
        '
        Me.ProgressBar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgressBar3.Location = New System.Drawing.Point(526, 196)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(192, 40)
        Me.ProgressBar3.TabIndex = 2
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(526, 259)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(192, 40)
        Me.ProgressBar4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Simulator"
        '
        'UP
        '
        Me.UP.AutoSize = True
        Me.UP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UP.Location = New System.Drawing.Point(424, 81)
        Me.UP.Name = "UP"
        Me.UP.Size = New System.Drawing.Size(39, 25)
        Me.UP.TabIndex = 5
        Me.UP.Text = "UP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DOWN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(380, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "BRIGHTNESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TYPE OF LIGHT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Simulator.My.Resources.Resources.maxresdefault__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 223)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 149)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(434, 773)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Powered by advanced technology"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 460)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "VoiceSimulator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UP As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
