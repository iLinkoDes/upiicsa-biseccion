<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biseccion
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
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fxi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lf = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.lc = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indice, Me.a, Me.xi, Me.b, Me.fa, Me.fxi, Me.fb})
        Me.Salida.Location = New System.Drawing.Point(30, 176)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(747, 262)
        Me.Salida.TabIndex = 0
        '
        'indice
        '
        Me.indice.HeaderText = "Índice"
        Me.indice.Name = "indice"
        '
        'a
        '
        Me.a.HeaderText = "a"
        Me.a.Name = "a"
        '
        'xi
        '
        Me.xi.HeaderText = "xi"
        Me.xi.Name = "xi"
        '
        'b
        '
        Me.b.HeaderText = "b"
        Me.b.Name = "b"
        '
        'fa
        '
        Me.fa.HeaderText = "f(a)"
        Me.fa.Name = "fa"
        '
        'fxi
        '
        Me.fxi.HeaderText = "f(xi)"
        Me.fxi.Name = "fxi"
        '
        'fb
        '
        Me.fb.HeaderText = "f(b)"
        Me.fb.Name = "fb"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(90, 25)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 1
        Me.lf.Text = "Dame función"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(90, 63)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(44, 13)
        Me.la.TabIndex = 2
        Me.la.Text = "Dame a"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(90, 99)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(44, 13)
        Me.lb.TabIndex = 3
        Me.lb.Text = "Dame b"
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Location = New System.Drawing.Point(90, 138)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(63, 13)
        Me.lc.TabIndex = 4
        Me.lc.Text = "Dame cifras"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(218, 22)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(155, 20)
        Me.tf.TabIndex = 5
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(218, 60)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(155, 20)
        Me.ta.TabIndex = 6
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(218, 96)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(155, 20)
        Me.tb.TabIndex = 7
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(218, 131)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(155, 20)
        Me.tc.TabIndex = 8
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(515, 52)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 9
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(515, 99)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Biseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lf)
        Me.Controls.Add(Me.Salida)
        Me.Name = "Biseccion"
        Me.Text = "Método de Biseccion"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salida As DataGridView
    Friend WithEvents indice As DataGridViewTextBoxColumn
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents xi As DataGridViewTextBoxColumn
    Friend WithEvents b As DataGridViewTextBoxColumn
    Friend WithEvents fa As DataGridViewTextBoxColumn
    Friend WithEvents fxi As DataGridViewTextBoxColumn
    Friend WithEvents fb As DataGridViewTextBoxColumn
    Friend WithEvents lf As Label
    Friend WithEvents la As Label
    Friend WithEvents lb As Label
    Friend WithEvents lc As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
End Class
