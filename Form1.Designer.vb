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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowLayers = New System.Windows.Forms.Button()
        Me.HideLayers = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Apply = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SelectALL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(406, 23)
        Me.TextBox1.TabIndex = 0
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(525, 52)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 1
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input File"
        '
        'ShowLayers
        '
        Me.ShowLayers.Location = New System.Drawing.Point(84, 116)
        Me.ShowLayers.Name = "ShowLayers"
        Me.ShowLayers.Size = New System.Drawing.Size(88, 48)
        Me.ShowLayers.TabIndex = 3
        Me.ShowLayers.Text = "Show Layers"
        Me.ShowLayers.UseVisualStyleBackColor = True
        '
        'HideLayers
        '
        Me.HideLayers.Location = New System.Drawing.Point(83, 170)
        Me.HideLayers.Name = "HideLayers"
        Me.HideLayers.Size = New System.Drawing.Size(89, 45)
        Me.HideLayers.TabIndex = 4
        Me.HideLayers.Text = "Hide Layers"
        Me.HideLayers.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(270, 116)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(330, 289)
        Me.ListBox1.TabIndex = 5
        '
        'Apply
        '
        Me.Apply.Location = New System.Drawing.Point(424, 485)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(75, 23)
        Me.Apply.TabIndex = 6
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(525, 485)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SelectALL
        '
        Me.SelectALL.Location = New System.Drawing.Point(525, 420)
        Me.SelectALL.Name = "SelectALL"
        Me.SelectALL.Size = New System.Drawing.Size(75, 23)
        Me.SelectALL.TabIndex = 8
        Me.SelectALL.Text = "Select All"
        Me.SelectALL.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 542)
        Me.Controls.Add(Me.SelectALL)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.HideLayers)
        Me.Controls.Add(Me.ShowLayers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowLayers As Button
    Friend WithEvents HideLayers As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Apply As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents SelectALL As Button

    Private bShowLayers As Boolean
    Private bHideLayers As Boolean

End Class
