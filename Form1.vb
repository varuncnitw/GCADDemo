Imports System
Imports Gssoft.Gscad
Imports Gssoft.Gscad.Runtime
Imports Gssoft.Gscad.ApplicationServices
Imports Gssoft.Gscad.DatabaseServices
Imports Gssoft.Gscad.Geometry
Imports Gssoft.Gscad.EditorInput
Imports System.Security.Cryptography

'<Assembly: CommandClass(GetType(Form1))>

'Namespace GRXTest

Public Class Form1
    ' This line is not mandatory, but improves loading performances
    Dim myComnd As New GRXTest.MyCommands
    Dim sAllLayers(100) As String

    '    <CommandMethod("vbhello", CommandFlags.Modal)>
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' MessageBox.Show("Save the file")
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'Me.Hide()
        myComnd.SaveDoc()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Drawing File (*.dwg)|*.dwg|All files (*.*)|*.*"
            ofd.Title = "Select file"
            If ofd.ShowDialog() = DialogResult.OK Then
                Me.TextBox1.Text = ofd.FileName
                'MessageBox.Show("Drawing file is Loaded successfully")
                'Dim myComnd As New GRXTest.MyCommands
                Dim layerCount As Integer
                myComnd.loadDocument(ofd.FileName, sAllLayers, layerCount)
                ' : Load the file
                '               Dim acApp As Gssoft.Gscad.ApplicationServices.Application
                'Dim acAppComObj As AcadApplication
                '              Dim strProgId As String = "Gssoft.Gscad.Application.24.1"
                '             Dim doc As Gssoft.Gscad.ApplicationServices.Document
                'doc = Gssoft.Gscad.ApplicationServices.Application.DocumentManager.MdiActiveDocument
                'On Error Resume Next

                '' Get a running instance of AutoCAD
                'acApp = GetObject("E:\\DDRive\\CBIT\\gstarCAD\\Installer\\GstarCAD 2024\\gcad.exe", strProgId)
                If Err.Number > 0 Then
                    Err.Clear()

                    '    '' Create a new instance of AutoCAD
                    '    acApp = CreateObject(strProgId)

                    '    '' Check to see if an instance of AutoCAD was created
                    '    If Err.Number > 0 Then
                    '        Err.Clear()

                    '        '' If an instance of AutoCAD is not created then message and exit
                    '        MsgBox("Instance of 'Gssoft.Gscad' could not be created.")

                    '        Exit Sub
                    '    End If
                End If
                'Dim doc As Gssoft.Gscad.ApplicationServices.Document
                'acApp =
                '' Dim acDoc As Gssoft.Gscad.ApplicationServices.Document

                'doc = Gssoft.Gscad.ApplicationServices.Application.DocumentManager.Open(ofd.FileName, False, Nothing)
                'doc.Editor.WriteMessage("hello vb.net")
                '   MessageBox.Show("Drawing file is Loaded successfully")

                ' TODO: List the layers

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
        'Me.bShowLayers = True
        'Me.bHideLayers = False
        Dim i As Integer

        For i = 0 To Me.ListBox1.Items.Count - 1
            Dim selItem As Boolean = Me.ListBox1.GetSelected(i)
            If (selItem = True) Then
                myComnd.ShowLayer(Me.ListBox1.Items(i))
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.bShowLayers = False
        'Me.bHideLayers = True
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
'End Namespace