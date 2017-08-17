<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.Labelnumeroreserva = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelcodigocliente = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelRegCliente = New System.Windows.Forms.LinkLabel()
        Me.LabelcdgVehiculo = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelfchIncFact = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Labelfchdev = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LabelTipVehFact = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LabelnomClin = New System.Windows.Forms.Label()
        Me.TextBoxclntfact = New System.Windows.Forms.TextBox()
        Me.Labelmntpagar = New System.Windows.Forms.Label()
        Me.TextBoxMNTPAGAR = New System.Windows.Forms.TextBox()
        Me.ButtonfACTURAR = New System.Windows.Forms.Button()
        Me.Labelcodempl = New System.Windows.Forms.Label()
        Me.TextBoxcodempl = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelnumeroreserva
        '
        Me.Labelnumeroreserva.AutoSize = True
        Me.Labelnumeroreserva.Location = New System.Drawing.Point(528, 31)
        Me.Labelnumeroreserva.Name = "Labelnumeroreserva"
        Me.Labelnumeroreserva.Size = New System.Drawing.Size(72, 13)
        Me.Labelnumeroreserva.TabIndex = 0
        Me.Labelnumeroreserva.Text = "# de Reserva"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.alquilerdeauto.My.Resources.Resources.SIGEVEN
        Me.PictureBox1.Location = New System.Drawing.Point(27, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 106)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Labelcodigocliente
        '
        Me.Labelcodigocliente.AutoSize = True
        Me.Labelcodigocliente.Location = New System.Drawing.Point(35, 152)
        Me.Labelcodigocliente.Name = "Labelcodigocliente"
        Me.Labelcodigocliente.Size = New System.Drawing.Size(64, 13)
        Me.Labelcodigocliente.TabIndex = 2
        Me.Labelcodigocliente.Text = "Cod_Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 144)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'LabelRegCliente
        '
        Me.LabelRegCliente.AutoSize = True
        Me.LabelRegCliente.Location = New System.Drawing.Point(288, 147)
        Me.LabelRegCliente.Name = "LabelRegCliente"
        Me.LabelRegCliente.Size = New System.Drawing.Size(87, 13)
        Me.LabelRegCliente.TabIndex = 4
        Me.LabelRegCliente.TabStop = True
        Me.LabelRegCliente.Text = "Registrar  Cliente"
        '
        'LabelcdgVehiculo
        '
        Me.LabelcdgVehiculo.AutoSize = True
        Me.LabelcdgVehiculo.Location = New System.Drawing.Point(26, 186)
        Me.LabelcdgVehiculo.Name = "LabelcdgVehiculo"
        Me.LabelcdgVehiculo.Size = New System.Drawing.Size(73, 13)
        Me.LabelcdgVehiculo.TabIndex = 5
        Me.LabelcdgVehiculo.Text = "Cod_Vehiculo"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(105, 189)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'LabelfchIncFact
        '
        Me.LabelfchIncFact.AutoSize = True
        Me.LabelfchIncFact.Location = New System.Drawing.Point(35, 235)
        Me.LabelfchIncFact.Name = "LabelfchIncFact"
        Me.LabelfchIncFact.Size = New System.Drawing.Size(80, 13)
        Me.LabelfchIncFact.TabIndex = 7
        Me.LabelfchIncFact.Text = "Fecha de Inicio"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 230)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(169, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Labelfchdev
        '
        Me.Labelfchdev.AutoSize = True
        Me.Labelfchdev.Location = New System.Drawing.Point(323, 237)
        Me.Labelfchdev.Name = "Labelfchdev"
        Me.Labelfchdev.Size = New System.Drawing.Size(94, 13)
        Me.Labelfchdev.TabIndex = 9
        Me.Labelfchdev.Text = "Fecha Devolucion"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(425, 235)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'LabelTipVehFact
        '
        Me.LabelTipVehFact.AutoSize = True
        Me.LabelTipVehFact.Location = New System.Drawing.Point(35, 278)
        Me.LabelTipVehFact.Name = "LabelTipVehFact"
        Me.LabelTipVehFact.Size = New System.Drawing.Size(87, 13)
        Me.LabelTipVehFact.TabIndex = 11
        Me.LabelTipVehFact.Text = "Tipo de Vehiculo"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(121, 275)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(175, 21)
        Me.ComboBox3.TabIndex = 12
        '
        'LabelnomClin
        '
        Me.LabelnomClin.AutoSize = True
        Me.LabelnomClin.Location = New System.Drawing.Point(396, 145)
        Me.LabelnomClin.Name = "LabelnomClin"
        Me.LabelnomClin.Size = New System.Drawing.Size(79, 13)
        Me.LabelnomClin.TabIndex = 13
        Me.LabelnomClin.Text = "Nombre Cliente"
        '
        'TextBoxclntfact
        '
        Me.TextBoxclntfact.Location = New System.Drawing.Point(481, 142)
        Me.TextBoxclntfact.Name = "TextBoxclntfact"
        Me.TextBoxclntfact.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxclntfact.TabIndex = 14
        '
        'Labelmntpagar
        '
        Me.Labelmntpagar.AutoSize = True
        Me.Labelmntpagar.Location = New System.Drawing.Point(458, 335)
        Me.Labelmntpagar.Name = "Labelmntpagar"
        Me.Labelmntpagar.Size = New System.Drawing.Size(32, 13)
        Me.Labelmntpagar.TabIndex = 15
        Me.Labelmntpagar.Text = "RD $"
        '
        'TextBoxMNTPAGAR
        '
        Me.TextBoxMNTPAGAR.Location = New System.Drawing.Point(505, 332)
        Me.TextBoxMNTPAGAR.Name = "TextBoxMNTPAGAR"
        Me.TextBoxMNTPAGAR.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxMNTPAGAR.TabIndex = 16
        '
        'ButtonfACTURAR
        '
        Me.ButtonfACTURAR.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonfACTURAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonfACTURAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonfACTURAR.Location = New System.Drawing.Point(503, 391)
        Me.ButtonfACTURAR.Name = "ButtonfACTURAR"
        Me.ButtonfACTURAR.Size = New System.Drawing.Size(130, 34)
        Me.ButtonfACTURAR.TabIndex = 17
        Me.ButtonfACTURAR.Text = "Facturar"
        Me.ButtonfACTURAR.UseVisualStyleBackColor = False
        '
        'Labelcodempl
        '
        Me.Labelcodempl.AutoSize = True
        Me.Labelcodempl.Location = New System.Drawing.Point(400, 183)
        Me.Labelcodempl.Name = "Labelcodempl"
        Me.Labelcodempl.Size = New System.Drawing.Size(79, 13)
        Me.Labelcodempl.TabIndex = 18
        Me.Labelcodempl.Text = "Cod_Empleado"
        '
        'TextBoxcodempl
        '
        Me.TextBoxcodempl.Location = New System.Drawing.Point(484, 182)
        Me.TextBoxcodempl.Name = "TextBoxcodempl"
        Me.TextBoxcodempl.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxcodempl.TabIndex = 19
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 439)
        Me.Controls.Add(Me.TextBoxcodempl)
        Me.Controls.Add(Me.Labelcodempl)
        Me.Controls.Add(Me.ButtonfACTURAR)
        Me.Controls.Add(Me.TextBoxMNTPAGAR)
        Me.Controls.Add(Me.Labelmntpagar)
        Me.Controls.Add(Me.TextBoxclntfact)
        Me.Controls.Add(Me.LabelnomClin)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.LabelTipVehFact)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Labelfchdev)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LabelfchIncFact)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.LabelcdgVehiculo)
        Me.Controls.Add(Me.LabelRegCliente)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Labelcodigocliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Labelnumeroreserva)
        Me.Name = "Factura"
        Me.Text = "Factura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelnumeroreserva As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Labelcodigocliente As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelRegCliente As LinkLabel
    Friend WithEvents LabelcdgVehiculo As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LabelfchIncFact As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Labelfchdev As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents LabelTipVehFact As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents LabelnomClin As Label
    Friend WithEvents TextBoxclntfact As TextBox
    Friend WithEvents Labelmntpagar As Label
    Friend WithEvents TextBoxMNTPAGAR As TextBox
    Friend WithEvents ButtonfACTURAR As Button
    Friend WithEvents Labelcodempl As Label
    Friend WithEvents TextBoxcodempl As TextBox
End Class
