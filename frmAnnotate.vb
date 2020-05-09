Imports System.Runtime.CompilerServices

Public Class frmAnnotation
    Private PanelList As ArrayList = New ArrayList()
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private i As Panel
    Private index As Integer = 0
    Private Sub Pnl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseDown, pnlE2.MouseDown,
    pnlBC.MouseDown, pnlBL.MouseDown, pnlBN.MouseDown, pnlLL.MouseDown, pnlRL.MouseDown, pnlSFL.MouseDown, pnlSFR.MouseDown, pnlSNL.MouseDown, pnlSNR.MouseDown,
    pnlTL.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
        If PanelList.Count > index Then
            i = PanelList.Item(index)
        End If
        CType(sender, Panel).BringToFront()
        Label1.Text = CType(sender, Panel).Tag
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
        If PanelList.Count > index Then
            index = index + 1
            i.Location = CType(sender, Panel).Location
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmAnnotation.Hide()
        My.Forms.frmChoose.Show()
    End Sub

    Private Sub frmAnnotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelList.Add(pnlE1)
        PanelList.Add(pnlE2)
        PanelList.Add(pnlBC)
        PanelList.Add(pnlBL)
        PanelList.Add(pnlBN)
        PanelList.Add(pnlLL)
        PanelList.Add(pnlRL)
        PanelList.Add(pnlSFL)
        PanelList.Add(pnlSFR)
        PanelList.Add(pnlSNL)
        PanelList.Add(pnlSNR)
        PanelList.Add(pnlTL)

    End Sub
End Class
