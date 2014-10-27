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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbMaquina = New System.Windows.Forms.PictureBox()
        Me.pbUsuario = New System.Windows.Forms.PictureBox()
        Me.pbTijera = New System.Windows.Forms.PictureBox()
        Me.pbPapel = New System.Windows.Forms.PictureBox()
        Me.pbPiedra = New System.Windows.Forms.PictureBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        CType(Me.pbMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTijera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPapel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPiedra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(-2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(661, 23)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(635, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        '
        'pbMaquina
        '
        Me.pbMaquina.Location = New System.Drawing.Point(475, 227)
        Me.pbMaquina.Name = "pbMaquina"
        Me.pbMaquina.Size = New System.Drawing.Size(128, 128)
        Me.pbMaquina.TabIndex = 6
        Me.pbMaquina.TabStop = False
        '
        'pbUsuario
        '
        Me.pbUsuario.Location = New System.Drawing.Point(69, 227)
        Me.pbUsuario.Name = "pbUsuario"
        Me.pbUsuario.Size = New System.Drawing.Size(128, 128)
        Me.pbUsuario.TabIndex = 5
        Me.pbUsuario.TabStop = False
        '
        'pbTijera
        '
        Me.pbTijera.Image = Global.PapelLic.My.Resources.Resources._1413827088_barber_scissors
        Me.pbTijera.Location = New System.Drawing.Point(475, 60)
        Me.pbTijera.Name = "pbTijera"
        Me.pbTijera.Size = New System.Drawing.Size(128, 128)
        Me.pbTijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbTijera.TabIndex = 4
        Me.pbTijera.TabStop = False
        '
        'pbPapel
        '
        Me.pbPapel.Image = Global.PapelLic.My.Resources.Resources._1413827028_FEZ_03_128
        Me.pbPapel.Location = New System.Drawing.Point(272, 60)
        Me.pbPapel.Name = "pbPapel"
        Me.pbPapel.Size = New System.Drawing.Size(128, 128)
        Me.pbPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbPapel.TabIndex = 3
        Me.pbPapel.TabStop = False
        '
        'pbPiedra
        '
        Me.pbPiedra.Image = Global.PapelLic.My.Resources.Resources._1413826997_3D_Stone
        Me.pbPiedra.Location = New System.Drawing.Point(69, 60)
        Me.pbPiedra.Name = "pbPiedra"
        Me.pbPiedra.Size = New System.Drawing.Size(128, 128)
        Me.pbPiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbPiedra.TabIndex = 2
        Me.pbPiedra.TabStop = False
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(220, 227)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 40)
        Me.lblResultado.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(658, 399)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.pbMaquina)
        Me.Controls.Add(Me.pbUsuario)
        Me.Controls.Add(Me.pbTijera)
        Me.Controls.Add(Me.pbPapel)
        Me.Controls.Add(Me.pbPiedra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piedra, papel y tijera"
        CType(Me.pbMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTijera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPapel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPiedra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbPiedra As System.Windows.Forms.PictureBox
    Friend WithEvents pbPapel As System.Windows.Forms.PictureBox
    Friend WithEvents pbTijera As System.Windows.Forms.PictureBox
    Friend WithEvents pbUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents pbMaquina As System.Windows.Forms.PictureBox
    Friend WithEvents lblResultado As System.Windows.Forms.Label

End Class
