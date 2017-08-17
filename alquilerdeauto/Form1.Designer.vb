<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPantallaPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonVehiculos = New System.Windows.Forms.Button()
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonReservaciones = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.alquilerdeauto.My.Resources.Resources.SIGEVEN
        Me.PictureBox1.Location = New System.Drawing.Point(258, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 87)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonVehiculos
        '
        Me.ButtonVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVehiculos.Location = New System.Drawing.Point(271, 226)
        Me.ButtonVehiculos.Name = "ButtonVehiculos"
        Me.ButtonVehiculos.Size = New System.Drawing.Size(162, 43)
        Me.ButtonVehiculos.TabIndex = 1
        Me.ButtonVehiculos.Text = "Vehiculos"
        Me.ButtonVehiculos.UseVisualStyleBackColor = True
        '
        'ButtonClientes
        '
        Me.ButtonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.Location = New System.Drawing.Point(74, 337)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(155, 45)
        Me.ButtonClientes.TabIndex = 3
        Me.ButtonClientes.Text = "Clientes"
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'ButtonReservaciones
        '
        Me.ButtonReservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReservaciones.Location = New System.Drawing.Point(441, 338)
        Me.ButtonReservaciones.Name = "ButtonReservaciones"
        Me.ButtonReservaciones.Size = New System.Drawing.Size(185, 44)
        Me.ButtonReservaciones.TabIndex = 4
        Me.ButtonReservaciones.Text = "Reservaciones"
        Me.ButtonReservaciones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bienvenid@"
        '
        'FormPantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReservaciones)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Controls.Add(Me.ButtonVehiculos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormPantallaPrincipal"
        Me.Text = "Pantalla Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonVehiculos As Button
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonReservaciones As Button
    Friend WithEvents Label1 As Label
End Class
