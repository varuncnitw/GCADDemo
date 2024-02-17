Imports System
Imports Gssoft.Gscad
Imports Gssoft.Gscad.Runtime
Imports Gssoft.Gscad.DatabaseServices
Imports Gssoft.Gscad.Geometry
Imports Gssoft.Gscad.ApplicationServices
Imports Gssoft.Gscad.EditorInput
' This line is not mandatory, but improves loading performances
<Assembly: CommandClass(GetType(GRXTest.MyCommands))>
Namespace GRXTest
    Public Class MyCommands
        Dim acDoc As Gssoft.Gscad.ApplicationServices.Document
        <CommandMethod("gsCADProj", CommandFlags.Modal)>
        Public Sub RunMRLCommand() ' This method can have any name
            Dim doc As Gssoft.Gscad.ApplicationServices.Document
            Dim fm As New Form1

            Application.ShowModelessDialog(fm)

        End Sub
        Public Sub loadDocument(filename As String, ByRef sAllLayers() As String,
                                ByRef layerCount As Integer)
            'Dim acDoc As Gssoft.Gscad.ApplicationServices.Document

            acDoc = Gssoft.Gscad.ApplicationServices.Application.DocumentManager.Open(filename,
                                                                False, Nothing)
            Dim acCurDb As Database = acDoc.Database
            'Dim sAllLayers(100) As String

            getLayers(acDoc, sAllLayers, layerCount)
        End Sub
        Public Sub UpdateScreen()
            Application.UpdateScreen()
            Application.DocumentManager.MdiActiveDocument.Editor.UpdateScreen()

            '' Regenerate the drawing
            Application.DocumentManager.MdiActiveDocument.Editor.Regen()
        End Sub

        Public Sub ShowLayer(ByVal sLayer As String
                                )
            Dim acCurDb As Database = acDoc.Database

            'Dim sAllLayers(100) As String
            'Dim layercount As Integer
            '            getLayers(acdoc, sAllLayers, layercount)
            Dim acLyrTblRec As LayerTableRecord

            Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
                Dim acLyrTbl As LayerTable
                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId,
                                                 OpenMode.ForRead)

                For Each acObjId As ObjectId In acLyrTbl

                    acLyrTblRec = acTrans.GetObject(acObjId,
                                            OpenMode.ForWrite)
                    'sLayerNames = sLayerNames & vbLf & acLyrTblRec.Name
                    'Application.ShowAlertDialog("The layers in this drawing are: " &
                    '            sLayerNames)
                    If (acLyrTblRec.Name = sLayer) Then
                        acLyrTblRec.IsOff = False
                        Exit For
                    End If
                Next
                acTrans.Commit()
                UpdateScreen()
            End Using

        End Sub
        Public Sub SaveDoc()
            Dim strDWGName As String = acDoc.Name

            Dim obj As Object = Application.GetSystemVariable("DWGTITLED")

            '' Save the active drawing
            acDoc.Database.SaveAs(strDWGName, True, DwgVersion.Current,
                          acDoc.Database.SecurityParameters)
        End Sub
        Public Sub HideLayer(ByVal sLayer As String
                                )
            Dim acCurDb As Database = acDoc.Database

            'Dim sAllLayers(100) As String
            'Dim layercount As Integer
            '            getLayers(acdoc, sAllLayers, layercount)
            Dim acLyrTblRec As LayerTableRecord

            Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
                Dim acLyrTbl As LayerTable
                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId,
                                                 OpenMode.ForRead)

                For Each acObjId As ObjectId In acLyrTbl

                    acLyrTblRec = acTrans.GetObject(acObjId,
                                            OpenMode.ForWrite)
                    'sLayerNames = sLayerNames & vbLf & acLyrTblRec.Name
                    'Application.ShowAlertDialog("The layers in this drawing are: " &
                    '            sLayerNames)
                    If (acLyrTblRec.Name = sLayer) Then
                        acLyrTblRec.IsOff = True
                        Exit For
                    End If
                Next
                acTrans.Commit()
            End Using
            UpdateScreen()
        End Sub
        Public Sub getLayers(ByVal acdoc As Document, ByRef sAllLayers() As String,
                                             ByRef layerCount As Integer)
            Dim acCurDb As Database = acdoc.Database
            ''' Start a transaction
            Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()

                '    '' Open the Layer table for read
                Dim acLyrTbl As LayerTable
                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId,
                                             OpenMode.ForRead)

                Dim sLayerNames As String = ""
                Dim totalLayerCount As Integer
                totalLayerCount = 0
                For Each acObjId As ObjectId In acLyrTbl
                    Dim acLyrTblRec As LayerTableRecord
                    acLyrTblRec = acTrans.GetObject(acObjId,
                                            OpenMode.ForWrite)
                    'sLayerNames = sLayerNames & vbLf & acLyrTblRec.Name
                    'Application.ShowAlertDialog("The layers in this drawing are: " &
                    '            sLayerNames)
                    'acLyrTblRec.IsOff = True
                    totalLayerCount += 1
                Next
                'Dim sAllLayers(totalLayerCount) As String

                Dim indexCount As Integer
                indexCount = 0
                For Each acObjId As ObjectId In acLyrTbl
                    Dim acLyrTblRec As LayerTableRecord
                    acLyrTblRec = acTrans.GetObject(acObjId,
                                            OpenMode.ForWrite)
                    sLayerNames = acLyrTblRec.Name
                    'Application.ShowAlertDialog("The layers in this drawing are: " &
                    '            sLayerNames)
                    'acLyrTblRec.IsOff = True
                    sAllLayers(indexCount) = sLayerNames
                    indexCount += 1
                Next
                layerCount = totalLayerCount
                '' Turn the layer on
                ' Save the changes and dispose of the transaction
                'acTrans.Commit()
            End Using

        End Sub
    End Class
End Namespace