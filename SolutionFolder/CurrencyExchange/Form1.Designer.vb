<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InputData = New System.Windows.Forms.TextBox()
        Me.InputBox = New System.Windows.Forms.ListBox()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.OutputBox = New System.Windows.Forms.ListBox()
        Me.OutputData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InputData
        '
        Me.InputData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputData.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InputData.Location = New System.Drawing.Point(1687, 12)
        Me.InputData.Name = "InputData"
        Me.InputData.Size = New System.Drawing.Size(843, 81)
        Me.InputData.TabIndex = 0
        Me.InputData.Text = "Input"
        '
        'InputBox
        '
        Me.InputBox.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InputBox.FormattingEnabled = True
        Me.InputBox.ItemHeight = 37
        Me.InputBox.Items.AddRange(New Object() {"USD", "C$USD", "Euro", "Peso", "Yen", "Ruble", "Rupee", "Dirham", "Won", "Pound", "DK Krone"})
        Me.InputBox.Location = New System.Drawing.Point(12, 72)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(342, 1299)
        Me.InputBox.TabIndex = 1
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InputLabel.Location = New System.Drawing.Point(16, 19)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(151, 37)
        Me.InputLabel.TabIndex = 2
        Me.InputLabel.Text = "Input: USD"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OutputLabel.Location = New System.Drawing.Point(402, 19)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(204, 37)
        Me.OutputLabel.TabIndex = 4
        Me.OutputLabel.Text = "Output: C$USD"
        '
        'OutputBox
        '
        Me.OutputBox.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OutputBox.FormattingEnabled = True
        Me.OutputBox.ItemHeight = 37
        Me.OutputBox.Items.AddRange(New Object() {"USD", "C$USD", "Euro", "Peso", "Yen", "Ruble", "Rupee", "Dirham", "Won", "Pound", "DK Krone"})
        Me.OutputBox.Location = New System.Drawing.Point(398, 72)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(342, 1299)
        Me.OutputBox.TabIndex = 3
        '
        'OutputData
        '
        Me.OutputData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputData.BackColor = System.Drawing.Color.Transparent
        Me.OutputData.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OutputData.Location = New System.Drawing.Point(746, 1303)
        Me.OutputData.Name = "OutputData"
        Me.OutputData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OutputData.Size = New System.Drawing.Size(1784, 81)
        Me.OutputData.TabIndex = 5
        Me.OutputData.Text = "Output"
        Me.OutputData.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2542, 1393)
        Me.Controls.Add(Me.OutputData)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.InputLabel)
        Me.Controls.Add(Me.InputBox)
        Me.Controls.Add(Me.InputData)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CurEx"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputData As TextBox
    Friend WithEvents InputBox As ListBox
    Friend WithEvents InputLabel As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents OutputBox As ListBox
    Friend WithEvents OutputData As Label
End Class
