Imports Microsoft.WindowsAPICodePack

Public Class FrmBase

#Region "const, variable"
    Public _currentToolTipControl As Control = Nothing

    Public Enum ENM_TASKBAR_STATE
        _0_NoProgress = 0
        _1_Indeterminate = 1
        _2_Normal = 2
        _4_Error = 4
        _8_Paused = 8
    End Enum

#End Region

#Region "event"
    Private Sub FrmBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initial position
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub


    '----------------------実装途中
    <System.Diagnostics.DebuggerStepThrough()>
    Private Async Sub FrmBase_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        'if control is "Enable=False", Tooltip visible
        Dim control As Control = GetChildAtPoint(e.Location)

        If control IsNot Nothing Then
            If control.Enabled = False Then
                'ToolTip.Active = True
            End If
        End If

    End Sub


#End Region

End Class