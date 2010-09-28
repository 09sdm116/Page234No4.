<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblSofa = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblChair = New System.Windows.Forms.Label()
        Me.lblOrdered = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtChair = New System.Windows.Forms.TextBox()
        Me.txtSofa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(42, 255)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(125, 23)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process Order"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(294, 255)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(497, 255)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(125, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(31, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Customer name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(66, 58)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(35, 101)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(79, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City, State, Zip:"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(41, 178)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(56, 13)
        Me.lblNum.TabIndex = 6
        Me.lblNum.Text = "Number of"
        '
        'lblSofa
        '
        Me.lblSofa.AutoSize = True
        Me.lblSofa.Location = New System.Drawing.Point(40, 191)
        Me.lblSofa.Name = "lblSofa"
        Me.lblSofa.Size = New System.Drawing.Size(74, 13)
        Me.lblSofa.TabIndex = 7
        Me.lblSofa.Text = "sofas ordered:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(31, 24)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 8
        Me.lblLast.Text = "(Last, First)"
        '
        'lblChair
        '
        Me.lblChair.AutoSize = True
        Me.lblChair.Location = New System.Drawing.Point(40, 134)
        Me.lblChair.Name = "lblChair"
        Me.lblChair.Size = New System.Drawing.Size(56, 13)
        Me.lblChair.TabIndex = 9
        Me.lblChair.Text = "Number of"
        '
        'lblOrdered
        '
        Me.lblOrdered.AutoSize = True
        Me.lblOrdered.Location = New System.Drawing.Point(37, 147)
        Me.lblOrdered.Name = "lblOrdered"
        Me.lblOrdered.Size = New System.Drawing.Size(77, 13)
        Me.lblOrdered.TabIndex = 10
        Me.lblOrdered.Text = "chairs ordered:"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 14
        Me.lstDisplay.Location = New System.Drawing.Point(408, 10)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(256, 214)
        Me.lstDisplay.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 20)
        Me.txtName.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(127, 54)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(219, 20)
        Me.txtAddress.TabIndex = 13
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(127, 98)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(219, 20)
        Me.txtCity.TabIndex = 14
        '
        'txtChair
        '
        Me.txtChair.Location = New System.Drawing.Point(127, 142)
        Me.txtChair.Name = "txtChair"
        Me.txtChair.Size = New System.Drawing.Size(48, 20)
        Me.txtChair.TabIndex = 15
        '
        'txtSofa
        '
        Me.txtSofa.Location = New System.Drawing.Point(127, 186)
        Me.txtSofa.Name = "txtSofa"
        Me.txtSofa.Size = New System.Drawing.Size(48, 20)
        Me.txtSofa.TabIndex = 16
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 307)
        Me.Controls.Add(Me.txtSofa)
        Me.Controls.Add(Me.txtChair)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblOrdered)
        Me.Controls.Add(Me.lblChair)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblSofa)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Name = "frmMain"
        Me.Text = "Furniture Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents lblSofa As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblChair As System.Windows.Forms.Label
    Friend WithEvents lblOrdered As System.Windows.Forms.Label
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtChair As System.Windows.Forms.TextBox
    Friend WithEvents txtSofa As System.Windows.Forms.TextBox

End Class
