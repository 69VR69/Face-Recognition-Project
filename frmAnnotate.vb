Imports System.Runtime.CompilerServices

Public Class frmAnnotation
    Private PanelList(11) As Panel
    Public ModifyMode As Boolean = False
    Public SearchMode As Boolean = False
    Private modifiedFileName As String
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private i As Panel
    Private index As Integer = 0

    Private Sub FrmAnnotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(My.Forms.frmHome.Location.X, My.Forms.frmHome.Location.Y)
        'PanelList assignment 
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
        If ModifyMode Then
            modifiedFileName = InputBox("Enter the name", "Enter the name", " ")
            While (modifiedFileName.Equals(" "))
                modifiedFileName = InputBox("Enter the name", "Enter the name", " ")
            End While
            If modifiedFileName.Equals("") Then
                BackToHome()
                Return
            End If
            modifiedFileName &= ".png"
            My.Forms.frmHome.storageManager.dataManager.LoadAnnotation(modifiedFileName, PanelList)
            pnlAnnotation.BackgroundImage = My.Forms.frmHome.storageManager.OpenImage(modifiedFileName)
        ElseIf SearchMode Then
            btnConfirm.Text = "Search"
            pnlAnnotation.BackgroundImage = My.Forms.frmHome.storageManager.OpenImage()
        End If
        lblDescription.Text = modifiedFileName
    End Sub

    'Drag
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
    End Sub
    'Moving
    Private Sub Pnl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseMove, pnlE2.MouseMove,
    pnlBC.MouseMove, pnlBL.MouseMove, pnlBN.MouseMove, pnlLL.MouseMove, pnlRL.MouseMove, pnlSFL.MouseMove, pnlSFR.MouseMove, pnlSNL.MouseMove, pnlSNR.MouseMove,
    pnlTL.MouseMove
        If allowCoolMove = True Then
            CType(sender, Panel).Location = New Point(CType(sender, Panel).Location.X + e.X - myCoolPoint.X, CType(sender, Panel).Location.Y + e.Y - myCoolPoint.Y)
        End If
        CType(sender, Panel).BringToFront()
        lblDescription.Text = CType(sender, Panel).Tag
    End Sub
    'Drop
    Private Sub Pnl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlE1.MouseUp, pnlE2.MouseUp,
        pnlBC.MouseUp, pnlBL.MouseUp, pnlBN.MouseUp, pnlLL.MouseUp, pnlRL.MouseUp, pnlSFL.MouseUp, pnlSFR.MouseUp, pnlSNL.MouseUp, pnlSNR.MouseUp,
    pnlTL.MouseUp

        allowCoolMove = False
        Me.Cursor = Cursors.Default
        CType(sender, Panel).BringToFront()
        If PanelList.Count > index Then
            index = index + 1
            i.Visible = True
            i.BringToFront()
            lblDescription.Text = CType(sender, Panel).Tag 'Display the correct information for each annotation

        End If


    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BackToHome()
    End Sub

    Public Sub BackToHome()
        My.Forms.frmHome.Show()
        My.Forms.frmAnnotation.Close()
        My.Forms.frmHome.Init()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If ModifyMode Then 'If modify mode then save the modification
            My.Forms.frmHome.storageManager.SaveModifiedImage(modifiedFileName, PanelList)
            ModifyMode = False
            modifiedFileName = Nothing
        ElseIf SearchMode Then 'If search mode then compare to the database
            My.Forms.frmHome.storageManager.CompareImage(PanelList)
            SearchMode = False
        Else 'Else then save the annotation
            Dim newImageName As String = InputBox("Enter the name", "Enter the name", " ")
            While (newImageName.Equals(" "))
                newImageName = InputBox("Enter the name", "Enter the name", " ")
            End While
            If newImageName.Equals("") Then
                BackToHome()
                Return
            End If
            newImageName &= ".png"
            Dim imagePath As String = My.Forms.frmHome.storageManager.imagePath
            If Not imagePath.Equals(".png") Then
                My.Forms.frmHome.storageManager.SaveImage(imagePath, newImageName, PanelList)

            End If
        End If
        BackToHome()
    End Sub
End Class
