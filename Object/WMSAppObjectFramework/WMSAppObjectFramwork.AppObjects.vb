#Region "Imports"

Imports System.Windows.Forms

#End Region

Namespace WMSAppObjectFramwork

#Region "AppObject"

    Public Class AppObject

        Public Enum MSGCAP
            MSG
            ERR
            QUE
            WRN
        End Enum

        Private Shared _Version As String
        Public Shared ReadOnly Property Version As String

            Get

                _Version = "WMS Version 1.0"
                Return _Version

            End Get

        End Property

        Private Shared _ScreenHeight As Integer
        Public Shared ReadOnly Property ScreenHeight As Integer

            Get

                _ScreenHeight = Screen.PrimaryScreen.Bounds.Height
                Return _ScreenHeight

            End Get

        End Property

        Private Shared _ScreenWidth As Integer
        Public Shared ReadOnly Property ScreenWidth As Integer

            Get

                _ScreenWidth = Screen.PrimaryScreen.Bounds.Height
                Return _ScreenWidth

            End Get

        End Property

        Public Shared Sub ShowWaitCursor()

            Cursor.Current = Cursors.WaitCursor

        End Sub

        Public Shared Sub ShowDefaultCursor()

            Cursor.Current = Cursors.Default

        End Sub

        Public Shared Sub HandleExceptions(ByVal ex As Exception)

            Dim str As String = String.Format("Error Message : {0} {1} {2}", ex.Message, vbLf, ex.StackTrace)
            MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Sub

        Public Shared Function GetMSGCAP(ByVal MSGCAP As MSGCAP) As String
            Dim rtnStr As String = String.Empty

            Select Case MSGCAP
                Case MSGCAP.ERR
                    rtnStr = "Error"
                Case MSGCAP.MSG
                    rtnStr = "Message"
                Case MSGCAP.QUE
                    rtnStr = "Question"
                Case MSGCAP.WRN
                    rtnStr = "Warning"
            End Select

            Return rtnStr
        End Function

    End Class

#End Region

End Namespace
