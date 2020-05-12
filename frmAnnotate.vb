Imports System.Runtime.CompilerServices

Public Class frmAnnotation
    Private PanelList(11) As Panel
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private i As Panel
    Private index As Integer = 0

    Private Sub FrmAnnotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: wrap following code into for loop + extract maxNumber of panel into a constant
        PanelList(0) = pnlE1
        PanelList(1) = pnlE2
        PanelList(2) = pnlBC
        PanelList(3) = pnlBL
        PanelList(4) = pnlBN
        PanelList(5) = pnlLL
        PanelList(6) = pnlRL
        PanelList(7) = pnlSFL
        PanelList(8) = pnlSFR
        PanelList(9) = pnlSNL
        PanelList(10) = pnlSNR
        PanelList(11) = pnlTL
    End Sub

    Private Sub Pnl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseDown, pnlE2.MouseDown,
    pnlBC.MouseDown, pnlBL.MouseDown, pnlBN.MouseDown, pnlLL.MouseDown, pnlRL.MouseDown, pnlSFL.MouseDown, pnlSFR.MouseDown, pnlSNL.MouseDown, pnlSNR.MouseDown,
    pnlTL.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
        If PanelList.Count > index Then
            i = PanelList(index)
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

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmAnnotation.Hide()
        My.Forms.frmChoose.Show()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim newImageName As String = InputBox("Enter the name", "Enter the name", "Please Enter the name")
        My.Forms.frmChoose.storageManager.SaveImage(My.Forms.frmChoose.storageManager.imagePath, newImageName, PanelList)
    End Sub
End Class
