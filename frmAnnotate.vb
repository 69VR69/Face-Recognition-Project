Imports System.Runtime.CompilerServices

Public Class frmAnnotation


    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private Sub Pnl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseDown, pnlE2.MouseDown,
    pnlBC.MouseDown, pnlBL.MouseDown, pnlBN.MouseDown, pnlLL.MouseDown, pnlRL.MouseDown, pnlSFL.MouseDown, pnlSFR.MouseDown, pnlSNL.MouseDown, pnlSNR.MouseDown,
    pnlTL.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
        CType(sender, Panel).BringToFront()
    End Sub
    Private Sub Pnl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseMove, pnlE2.MouseMove,
    pnlBC.MouseMove, pnlBL.MouseMove, pnlBN.MouseMove, pnlLL.MouseMove, pnlRL.MouseMove, pnlSFL.MouseMove, pnlSFR.MouseMove, pnlSNL.MouseMove, pnlSNR.MouseMove,
    pnlTL.MouseMove
        If allowCoolMove = True Then
            CType(sender, Panel).Location = New Point(CType(sender, Panel).Location.X + e.X - myCoolPoint.X, CType(sender, Panel).Location.Y + e.Y - myCoolPoint.Y)
        End If
        CType(sender, Panel).BringToFront()
    End Sub
    Private Sub Pnl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseUp, pnlE2.MouseUp,
        pnlBC.MouseUp, pnlBL.MouseUp, pnlBN.MouseUp, pnlLL.MouseUp, pnlRL.MouseUp, pnlSFL.MouseUp, pnlSFR.MouseUp, pnlSNL.MouseUp, pnlSNR.MouseUp,
    pnlTL.MouseUp

        allowCoolMove = False
        Me.Cursor = Cursors.Default
        CType(sender, Panel).BringToFront()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmAnnotation.Hide()
        My.Forms.frmChoose.Show()
    End Sub


End Class