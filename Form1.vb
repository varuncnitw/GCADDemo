Imports System
Imports Gssoft.Gscad
Imports Gssoft.Gscad.Runtime
Imports Gssoft.Gscad.ApplicationServices
Imports Gssoft.Gscad.DatabaseServices
Imports Gssoft.Gscad.Geometry
Imports Gssoft.Gscad.EditorInput
Imports System.Security.Cryptography


Public Class Form1
    ' This line is not mandatory, but improves loading performances
    Dim myComnd As New GRXTest.MyCommands
    Dim sAllLayers(100) As String

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myComnd.SaveDoc()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Drawing File (*.dwg)|*.dwg|All files (*.*)|*.*"
            ofd.Title = "Select file"
            If ofd.ShowDialog() = DialogResult.OK Then
                Me.TextBox1.Text = ofd.FileName
                Dim layerCount As Integer
                myComnd.loadDocument(ofd.FileName, sAllLayers, layerCount)
                ' : Load the file
                For i = 0 To layerCount - 1
                    Me.ListBox1.Items.Add(sAllLayers(i))
                Next

            End If


        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer

        For i = 0 To Me.ListBox1.Items.Count - 1
            Me.ListBox1.SetSelected(i, True)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer

        For i = 0 To Me.ListBox1.Items.Count - 1
            Dim selItem As Boolean = Me.ListBox1.GetSelected(i)
            If (selItem = True) Then
                myComnd.ShowLayer(Me.ListBox1.Items(i))
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer

        For i = 0 To Me.ListBox1.Items.Count - 1
            Dim selItem As Boolean = Me.ListBox1.GetSelected(i)
            If (selItem = True) Then
                myComnd.HideLayer(Me.ListBox1.Items(i))
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Hide()

    End Sub
End Class
