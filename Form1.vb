Public Class Form1

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Drawing File (*.dwg)|*.dwg|All files (*.*)|*.*"
            'ofd.Title = "Select file"
            If ofd.ShowDialog() = DialogResult.OK Then
                Me.TextBox1.Text = ofd.FileName

                ' TODO: Load the file
                MessageBox.Show("Drawing file is Loaded successfully")

                ' TODO: List the layers
                Me.ListBox1.Items.Add("Layer1")
                Me.ListBox1.Items.Add("Layer2")
                Me.ListBox1.Items.Add("Layer3")
                Me.ListBox1.Items.Add("Layer4")
                Me.ListBox1.Items.Add("Layer5")
                Me.ListBox1.Items.Add("Layer6")

            End If


        End Using
    End Sub

    Private Sub SelectALL_Click(sender As Object, e As EventArgs) Handles SelectALL.Click
        Dim i As Integer
        For i = 0 To Me.ListBox1.Items.Count - 1
            Me.ListBox1.SetSelected(i, True)
        Next
    End Sub

    Private Sub ShowLayers_Click(sender As Object, e As EventArgs) Handles ShowLayers.Click

        Me.bShowLayers = True
        Me.bHideLayers = False

    End Sub

    Private Sub HideLayers_Click(sender As Object, e As EventArgs) Handles HideLayers.Click

        Me.bShowLayers = False
        Me.bHideLayers = True

    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        If bHideLayers = True Then
            ' TODO: Hide the Layers
            MessageBox.Show("Layers are Hide successfully")
        ElseIf bShowLayers = True Then
            ' TODO: Show the layers
            MessageBox.Show("Layers are Shown successfully")
        End If

        Dim i As Integer
        For i = 0 To Me.ListBox1.Items.Count - 1
            Me.ListBox1.SetSelected(i, False)
        Next
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' TODO: Save the file with changes
        MessageBox.Show("Save the file")
    End Sub
End Class
