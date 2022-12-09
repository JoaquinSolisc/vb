<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label251 = New System.Windows.Forms.Label()
        Me.Label252 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label251
        '
        Me.Label251.AutoSize = True
        Me.Label251.Location = New System.Drawing.Point(0, -1)
        Me.Label251.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label251.Name = "Label251"
        Me.Label251.Size = New System.Drawing.Size(102, 18)
        Me.Label251.TabIndex = 0
        Me.Label251.Text = "Nuevo juego"
        '
        'Label252
        '
        Me.Label252.AutoSize = True
        Me.Label252.Location = New System.Drawing.Point(124, -1)
        Me.Label252.Name = "Label252"
        Me.Label252.Size = New System.Drawing.Size(81, 18)
        Me.Label252.TabIndex = 1
        Me.Label252.Text = "ESC Salir"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 750)
        Me.Controls.Add(Me.Label252)
        Me.Controls.Add(Me.Label251)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Joaquin Solis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label251 As Label
    Friend WithEvents Label252 As Label
    Friend WithEvents Timer1 As Timer
End Class
