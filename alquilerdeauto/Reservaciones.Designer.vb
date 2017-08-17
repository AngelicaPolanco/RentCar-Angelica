<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservaciones
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
        Me.PanelFechaRecorrida = New System.Windows.Forms.Panel()
        Me.CheckBoxEdadConductor = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerFechaDvl = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerHoraRecorrida = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaRecorrida = New System.Windows.Forms.DateTimePicker()
        Me.LabelFechaDevolucion = New System.Windows.Forms.Label()
        Me.LabelFechaRecorrida = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmbLugar = New System.Windows.Forms.ComboBox()
        Me.LabelReogida = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.PanelFechaRecorrida.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFechaRecorrida
        '
        Me.PanelFechaRecorrida.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelFechaRecorrida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelFechaRecorrida.Controls.Add(Me.CheckBoxEdadConductor)
        Me.PanelFechaRecorrida.Controls.Add(Me.DateTimePickerFechaDvl)
        Me.PanelFechaRecorrida.Controls.Add(Me.DateTimePickerHoraRecorrida)
        Me.PanelFechaRecorrida.Controls.Add(Me.DateTimePickerFechaDevolucion)
        Me.PanelFechaRecorrida.Controls.Add(Me.DateTimePickerFechaRecorrida)
        Me.PanelFechaRecorrida.Controls.Add(Me.LabelFechaDevolucion)
        Me.PanelFechaRecorrida.Controls.Add(Me.LabelFechaRecorrida)
        Me.PanelFechaRecorrida.Controls.Add(Me.CheckBox1)
        Me.PanelFechaRecorrida.Controls.Add(Me.cmbLugar)
        Me.PanelFechaRecorrida.Controls.Add(Me.LabelReogida)
        Me.PanelFechaRecorrida.Location = New System.Drawing.Point(12, 26)
        Me.PanelFechaRecorrida.Name = "PanelFechaRecorrida"
        Me.PanelFechaRecorrida.Size = New System.Drawing.Size(666, 254)
        Me.PanelFechaRecorrida.TabIndex = 0
        '
        'CheckBoxEdadConductor
        '
        Me.CheckBoxEdadConductor.AutoSize = True
        Me.CheckBoxEdadConductor.Location = New System.Drawing.Point(19, 202)
        Me.CheckBoxEdadConductor.Name = "CheckBoxEdadConductor"
        Me.CheckBoxEdadConductor.Size = New System.Drawing.Size(166, 17)
        Me.CheckBoxEdadConductor.TabIndex = 9
        Me.CheckBoxEdadConductor.Text = "Conductor entre 18 y 60 años"
        Me.CheckBoxEdadConductor.UseVisualStyleBackColor = True
        '
        'DateTimePickerFechaDvl
        '
        Me.DateTimePickerFechaDvl.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerFechaDvl.Location = New System.Drawing.Point(359, 168)
        Me.DateTimePickerFechaDvl.Name = "DateTimePickerFechaDvl"
        Me.DateTimePickerFechaDvl.Size = New System.Drawing.Size(219, 20)
        Me.DateTimePickerFechaDvl.TabIndex = 8
        '
        'DateTimePickerHoraRecorrida
        '
        Me.DateTimePickerHoraRecorrida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerHoraRecorrida.Location = New System.Drawing.Point(29, 165)
        Me.DateTimePickerHoraRecorrida.Name = "DateTimePickerHoraRecorrida"
        Me.DateTimePickerHoraRecorrida.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePickerHoraRecorrida.TabIndex = 7
        '
        'DateTimePickerFechaDevolucion
        '
        Me.DateTimePickerFechaDevolucion.Location = New System.Drawing.Point(357, 139)
        Me.DateTimePickerFechaDevolucion.Name = "DateTimePickerFechaDevolucion"
        Me.DateTimePickerFechaDevolucion.Size = New System.Drawing.Size(222, 20)
        Me.DateTimePickerFechaDevolucion.TabIndex = 6
        '
        'DateTimePickerFechaRecorrida
        '
        Me.DateTimePickerFechaRecorrida.Location = New System.Drawing.Point(29, 139)
        Me.DateTimePickerFechaRecorrida.Name = "DateTimePickerFechaRecorrida"
        Me.DateTimePickerFechaRecorrida.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePickerFechaRecorrida.TabIndex = 5
        '
        'LabelFechaDevolucion
        '
        Me.LabelFechaDevolucion.AutoSize = True
        Me.LabelFechaDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaDevolucion.Location = New System.Drawing.Point(352, 92)
        Me.LabelFechaDevolucion.Name = "LabelFechaDevolucion"
        Me.LabelFechaDevolucion.Size = New System.Drawing.Size(199, 25)
        Me.LabelFechaDevolucion.TabIndex = 4
        Me.LabelFechaDevolucion.Text = "Fecha de devolucion:"
        '
        'LabelFechaRecorrida
        '
        Me.LabelFechaRecorrida.AutoSize = True
        Me.LabelFechaRecorrida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaRecorrida.Location = New System.Drawing.Point(28, 92)
        Me.LabelFechaRecorrida.Name = "LabelFechaRecorrida"
        Me.LabelFechaRecorrida.Size = New System.Drawing.Size(181, 25)
        Me.LabelFechaRecorrida.TabIndex = 3
        Me.LabelFechaRecorrida.Text = "Fecha de recorrida:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(19, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(231, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Devolver el vehiiculo en una oficina distinta"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmbLugar
        '
        Me.cmbLugar.FormattingEnabled = True
        Me.cmbLugar.Items.AddRange(New Object() {"", "Santo Domingo, Agora", "Santo Domingo, Sambil", "Santo Domingo, Plaza Central", "Santo Domingo, Downtown Center", "Santo Domingo, Mega Centro", "La Romana, Villa Hermosa", "Santiago, Monumento", "Barahona, Pazoleta"})
        Me.cmbLugar.Location = New System.Drawing.Point(206, 15)
        Me.cmbLugar.Name = "cmbLugar"
        Me.cmbLugar.Size = New System.Drawing.Size(345, 21)
        Me.cmbLugar.TabIndex = 1
        '
        'LabelReogida
        '
        Me.LabelReogida.AutoSize = True
        Me.LabelReogida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReogida.Location = New System.Drawing.Point(14, 9)
        Me.LabelReogida.Name = "LabelReogida"
        Me.LabelReogida.Size = New System.Drawing.Size(176, 25)
        Me.LabelReogida.TabIndex = 0
        Me.LabelReogida.Text = "Lugar de Recogida"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(480, 364)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(198, 58)
        Me.ButtonBuscar.TabIndex = 1
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'Reservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 469)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.PanelFechaRecorrida)
        Me.Name = "Reservaciones"
        Me.Text = "Reservaciones"
        Me.PanelFechaRecorrida.ResumeLayout(False)
        Me.PanelFechaRecorrida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFechaRecorrida As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmbLugar As ComboBox
    Friend WithEvents LabelReogida As Label
    Friend WithEvents LabelFechaDevolucion As Label
    Friend WithEvents LabelFechaRecorrida As Label
    Friend WithEvents DateTimePickerFechaRecorrida As DateTimePicker
    Friend WithEvents CheckBoxEdadConductor As CheckBox
    Friend WithEvents DateTimePickerFechaDvl As DateTimePicker
    Friend WithEvents DateTimePickerHoraRecorrida As DateTimePicker
    Friend WithEvents DateTimePickerFechaDevolucion As DateTimePicker
    Friend WithEvents ButtonBuscar As Button
End Class
