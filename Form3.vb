Imports System.Data.SqlClient

Public Class Form3
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents NicePanel1 As PureComponents.NicePanel.NicePanel
    Friend WithEvents NicePanel4 As PureComponents.NicePanel.NicePanel
    Friend WithEvents lstColumns As System.Windows.Forms.ListBox
    Friend WithEvents QueryPanel As PureComponents.NicePanel.NicePanel
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents cmnuQK_Esit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_EsitDegil As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_Kucuk As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_Buyuk As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_BuyukEsit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_KucukEsit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_Like As System.Windows.Forms.MenuItem
    Friend WithEvents NicePanel6 As PureComponents.NicePanel.NicePanel
    Friend WithEvents dgAraSonuc As System.Windows.Forms.DataGrid
    Friend WithEvents btnAra As System.Windows.Forms.Button
    Friend WithEvents NicePanel2 As PureComponents.NicePanel.NicePanel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents cmnuQueries As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuQ_Insert As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQ_Update As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQ_Delete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQ_AllDelete As System.Windows.Forms.MenuItem
    Friend WithEvents btnSorgu As System.Windows.Forms.Button
    Friend WithEvents Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmnuQueryKosulTextbox As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuQueryKosulCheckbox As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuQueryKosulDateTimePic As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuQK_DTP_Esit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_DTP_EsitDegil As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_DTP_BuyukEsit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_DTP_KucukEsit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_DTP_Buyuk As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_DTP_Kucuk As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_CHK_Esit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuQK_CHK_EsitDegil As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ContainerImage1 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage1 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage2 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle1 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle1 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle1 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle2 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage2 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage3 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage4 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle2 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle2 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle3 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle4 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage3 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage5 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage6 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle3 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle3 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle5 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle6 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage4 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage7 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage8 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle4 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle4 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle7 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle8 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage5 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage9 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage10 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle5 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle5 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle9 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle10 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Me.NicePanel1 = New PureComponents.NicePanel.NicePanel
        Me.NicePanel2 = New PureComponents.NicePanel.NicePanel
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.NicePanel6 = New PureComponents.NicePanel.NicePanel
        Me.dgAraSonuc = New System.Windows.Forms.DataGrid
        Me.QueryPanel = New PureComponents.NicePanel.NicePanel
        Me.cmnuQueries = New System.Windows.Forms.ContextMenu
        Me.cmnuQ_Insert = New System.Windows.Forms.MenuItem
        Me.cmnuQ_Update = New System.Windows.Forms.MenuItem
        Me.cmnuQ_Delete = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.cmnuQ_AllDelete = New System.Windows.Forms.MenuItem
        Me.btnSorgu = New System.Windows.Forms.Button
        Me.Panel = New System.Windows.Forms.Panel
        Me.btnAra = New System.Windows.Forms.Button
        Me.NicePanel4 = New PureComponents.NicePanel.NicePanel
        Me.lstColumns = New System.Windows.Forms.ListBox
        Me.cmnuQueryKosulTextbox = New System.Windows.Forms.ContextMenu
        Me.cmnuQK_Esit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_EsitDegil = New System.Windows.Forms.MenuItem
        Me.cmnuQK_Kucuk = New System.Windows.Forms.MenuItem
        Me.cmnuQK_Buyuk = New System.Windows.Forms.MenuItem
        Me.cmnuQK_BuyukEsit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_KucukEsit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_Like = New System.Windows.Forms.MenuItem
        Me.Err = New System.Windows.Forms.ErrorProvider
        Me.cmnuQueryKosulCheckbox = New System.Windows.Forms.ContextMenu
        Me.cmnuQK_CHK_Esit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_CHK_EsitDegil = New System.Windows.Forms.MenuItem
        Me.cmnuQueryKosulDateTimePic = New System.Windows.Forms.ContextMenu
        Me.cmnuQK_DTP_Esit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_DTP_EsitDegil = New System.Windows.Forms.MenuItem
        Me.cmnuQK_DTP_BuyukEsit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_DTP_KucukEsit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_DTP_Buyuk = New System.Windows.Forms.MenuItem
        Me.cmnuQK_DTP_Kucuk = New System.Windows.Forms.MenuItem
        Me.NicePanel1.SuspendLayout()
        Me.NicePanel2.SuspendLayout()
        Me.NicePanel6.SuspendLayout()
        CType(Me.dgAraSonuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QueryPanel.SuspendLayout()
        Me.NicePanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'NicePanel1
        '
        Me.NicePanel1.BackColor = System.Drawing.Color.Transparent
        Me.NicePanel1.CloseButton = True
        ContainerImage1.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage1.Image = Nothing
        ContainerImage1.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage1.Transparency = 50
        Me.NicePanel1.ContainerImage = ContainerImage1
        Me.NicePanel1.ContextMenuButton = False
        Me.NicePanel1.Controls.Add(Me.NicePanel2)
        Me.NicePanel1.Controls.Add(Me.NicePanel6)
        Me.NicePanel1.Controls.Add(Me.QueryPanel)
        Me.NicePanel1.Controls.Add(Me.NicePanel4)
        Me.NicePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        HeaderImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage1.Image = Nothing
        Me.NicePanel1.FooterImage = HeaderImage1
        Me.NicePanel1.FooterText = "PureComponents NicePanel for .NET WinForms V1.0."
        Me.NicePanel1.ForeColor = System.Drawing.Color.Black
        HeaderImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage2.Image = Nothing
        Me.NicePanel1.HeaderImage = HeaderImage2
        Me.NicePanel1.HeaderText = "...::: WIN QUERY BUILDING :::..."
        Me.NicePanel1.IsExpanded = True
        Me.NicePanel1.Location = New System.Drawing.Point(0, 0)
        Me.NicePanel1.MouseMoveTarget = PureComponents.NicePanel.MouseMoveTarget.Form
        Me.NicePanel1.Name = "NicePanel1"
        Me.NicePanel1.OriginalFooterVisible = True
        Me.NicePanel1.OriginalHeight = 0
        Me.NicePanel1.Size = New System.Drawing.Size(816, 613)
        ContainerStyle1.BackColor = System.Drawing.Color.FromArgb(CType(142, Byte), CType(179, Byte), CType(231, Byte))
        ContainerStyle1.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle1.BorderColor = System.Drawing.Color.FromArgb(CType(1, Byte), CType(45, Byte), CType(150, Byte))
        ContainerStyle1.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle1.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(232, Byte), CType(252, Byte))
        ContainerStyle1.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle1.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle1.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        ContainerStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle1.ForeColor = System.Drawing.Color.Black
        ContainerStyle1.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle1.ContainerStyle = ContainerStyle1
        PanelHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(CType(9, Byte), CType(42, Byte), CType(127, Byte))
        PanelHeaderStyle1.ButtonColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(191, Byte), CType(227, Byte))
        PanelHeaderStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(145, Byte), CType(215, Byte))
        PanelHeaderStyle1.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle1.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle1.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle1.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(169, Byte), CType(198, Byte), CType(237, Byte))
        PanelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle1.FooterStyle = PanelHeaderStyle1
        PanelHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(145, Byte), CType(215, Byte))
        PanelHeaderStyle2.ButtonColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(191, Byte), CType(227, Byte))
        PanelHeaderStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(9, Byte), CType(42, Byte), CType(127, Byte))
        PanelHeaderStyle2.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle2.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle2.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle2.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle2.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(230, Byte), CType(251, Byte))
        PanelHeaderStyle2.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelHeaderStyle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        PanelStyle1.HeaderStyle = PanelHeaderStyle2
        Me.NicePanel1.Style = PanelStyle1
        Me.NicePanel1.TabIndex = 0
        '
        'NicePanel2
        '
        Me.NicePanel2.BackColor = System.Drawing.Color.Transparent
        ContainerImage2.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage2.Image = Nothing
        ContainerImage2.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage2.Transparency = 50
        Me.NicePanel2.ContainerImage = ContainerImage2
        Me.NicePanel2.ContextMenuButton = False
        Me.NicePanel2.Controls.Add(Me.TreeView1)
        HeaderImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage3.Image = Nothing
        Me.NicePanel2.FooterImage = HeaderImage3
        Me.NicePanel2.FooterText = ""
        Me.NicePanel2.ForeColor = System.Drawing.Color.Black
        HeaderImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage4.Image = Nothing
        Me.NicePanel2.HeaderImage = HeaderImage4
        Me.NicePanel2.HeaderText = "DATABASES & TABLES"
        Me.NicePanel2.IsExpanded = True
        Me.NicePanel2.Location = New System.Drawing.Point(8, 48)
        Me.NicePanel2.Name = "NicePanel2"
        Me.NicePanel2.OriginalFooterVisible = True
        Me.NicePanel2.OriginalHeight = 0
        Me.NicePanel2.Size = New System.Drawing.Size(208, 232)
        ContainerStyle2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(240, Byte), CType(221, Byte))
        ContainerStyle2.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle2.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle2.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle2.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(155, Byte), CType(207, Byte), CType(152, Byte))
        ContainerStyle2.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle2.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle2.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        ContainerStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle2.ForeColor = System.Drawing.Color.Black
        ContainerStyle2.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle2.ContainerStyle = ContainerStyle2
        PanelHeaderStyle3.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle3.ButtonColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(191, Byte), CType(227, Byte))
        PanelHeaderStyle3.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle3.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle3.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle3.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle3.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle3.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle2.FooterStyle = PanelHeaderStyle3
        PanelHeaderStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle4.ButtonColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle4.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle4.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle4.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle4.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle4.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        PanelHeaderStyle4.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle2.HeaderStyle = PanelHeaderStyle4
        Me.NicePanel2.Style = PanelStyle2
        Me.NicePanel2.TabIndex = 6
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(8, 48)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(192, 160)
        Me.TreeView1.TabIndex = 0
        '
        'NicePanel6
        '
        Me.NicePanel6.BackColor = System.Drawing.Color.Transparent
        ContainerImage3.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage3.Image = Nothing
        ContainerImage3.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage3.Transparency = 50
        Me.NicePanel6.ContainerImage = ContainerImage3
        Me.NicePanel6.ContextMenuButton = False
        Me.NicePanel6.Controls.Add(Me.dgAraSonuc)
        HeaderImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage5.Image = Nothing
        Me.NicePanel6.FooterImage = HeaderImage5
        Me.NicePanel6.FooterText = ""
        Me.NicePanel6.ForeColor = System.Drawing.Color.Black
        HeaderImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage6.Image = Nothing
        Me.NicePanel6.HeaderImage = HeaderImage6
        Me.NicePanel6.HeaderText = "ARAMA SONUÇLARI"
        Me.NicePanel6.IsExpanded = True
        Me.NicePanel6.Location = New System.Drawing.Point(224, 48)
        Me.NicePanel6.Name = "NicePanel6"
        Me.NicePanel6.OriginalFooterVisible = True
        Me.NicePanel6.OriginalHeight = 0
        Me.NicePanel6.Size = New System.Drawing.Size(584, 232)
        ContainerStyle3.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(240, Byte), CType(221, Byte))
        ContainerStyle3.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle3.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle3.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle3.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle3.FadeColor = System.Drawing.Color.FromArgb(CType(155, Byte), CType(207, Byte), CType(152, Byte))
        ContainerStyle3.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle3.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle3.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        ContainerStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle3.ForeColor = System.Drawing.Color.Black
        ContainerStyle3.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle3.ContainerStyle = ContainerStyle3
        PanelHeaderStyle5.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle5.ButtonColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(191, Byte), CType(227, Byte))
        PanelHeaderStyle5.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle5.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle5.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle5.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle5.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle5.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle3.FooterStyle = PanelHeaderStyle5
        PanelHeaderStyle6.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle6.ButtonColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle6.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle6.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle6.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle6.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle6.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle6.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        PanelHeaderStyle6.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle3.HeaderStyle = PanelHeaderStyle6
        Me.NicePanel6.Style = PanelStyle3
        Me.NicePanel6.TabIndex = 5
        '
        'dgAraSonuc
        '
        Me.dgAraSonuc.CaptionBackColor = System.Drawing.Color.LightGray
        Me.dgAraSonuc.DataMember = ""
        Me.dgAraSonuc.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dgAraSonuc.HeaderFont = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dgAraSonuc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAraSonuc.Location = New System.Drawing.Point(8, 48)
        Me.dgAraSonuc.Name = "dgAraSonuc"
        Me.dgAraSonuc.Size = New System.Drawing.Size(568, 160)
        Me.dgAraSonuc.TabIndex = 0
        '
        'QueryPanel
        '
        Me.QueryPanel.BackColor = System.Drawing.Color.Transparent
        ContainerImage4.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage4.Image = Nothing
        ContainerImage4.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage4.Transparency = 50
        Me.QueryPanel.ContainerImage = ContainerImage4
        Me.QueryPanel.ContextMenu = Me.cmnuQueries
        Me.QueryPanel.Controls.Add(Me.btnSorgu)
        Me.QueryPanel.Controls.Add(Me.Panel)
        Me.QueryPanel.Controls.Add(Me.btnAra)
        HeaderImage7.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage7.Image = Nothing
        Me.QueryPanel.FooterImage = HeaderImage7
        Me.QueryPanel.FooterText = ""
        Me.QueryPanel.ForeColor = System.Drawing.Color.Black
        HeaderImage8.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage8.Image = Nothing
        Me.QueryPanel.HeaderImage = HeaderImage8
        Me.QueryPanel.HeaderText = "QUERY STRING"
        Me.QueryPanel.IsExpanded = True
        Me.QueryPanel.Location = New System.Drawing.Point(224, 288)
        Me.QueryPanel.Name = "QueryPanel"
        Me.QueryPanel.OriginalFooterVisible = True
        Me.QueryPanel.OriginalHeight = 0
        Me.QueryPanel.Size = New System.Drawing.Size(584, 296)
        ContainerStyle4.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(240, Byte), CType(221, Byte))
        ContainerStyle4.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle4.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle4.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle4.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle4.FadeColor = System.Drawing.Color.FromArgb(CType(155, Byte), CType(207, Byte), CType(152, Byte))
        ContainerStyle4.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle4.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle4.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        ContainerStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle4.ForeColor = System.Drawing.Color.Black
        ContainerStyle4.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle4.ContainerStyle = ContainerStyle4
        PanelHeaderStyle7.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle7.ButtonColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(191, Byte), CType(227, Byte))
        PanelHeaderStyle7.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle7.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle7.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle7.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle7.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle7.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle4.FooterStyle = PanelHeaderStyle7
        PanelHeaderStyle8.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle8.ButtonColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle8.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle8.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle8.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle8.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle8.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle8.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        PanelHeaderStyle8.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle4.HeaderStyle = PanelHeaderStyle8
        Me.QueryPanel.Style = PanelStyle4
        Me.QueryPanel.TabIndex = 3
        '
        'cmnuQueries
        '
        Me.cmnuQueries.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuQ_Insert, Me.cmnuQ_Update, Me.cmnuQ_Delete, Me.MenuItem4, Me.cmnuQ_AllDelete})
        '
        'cmnuQ_Insert
        '
        Me.cmnuQ_Insert.Index = 0
        Me.cmnuQ_Insert.Text = "Insert"
        '
        'cmnuQ_Update
        '
        Me.cmnuQ_Update.Index = 1
        Me.cmnuQ_Update.Text = "Update"
        '
        'cmnuQ_Delete
        '
        Me.cmnuQ_Delete.Index = 2
        Me.cmnuQ_Delete.Text = "Delete"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'cmnuQ_AllDelete
        '
        Me.cmnuQ_AllDelete.Index = 4
        Me.cmnuQ_AllDelete.Text = "All Delete"
        '
        'btnSorgu
        '
        Me.btnSorgu.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSorgu.Location = New System.Drawing.Point(280, 8)
        Me.btnSorgu.Name = "btnSorgu"
        Me.btnSorgu.Size = New System.Drawing.Size(120, 23)
        Me.btnSorgu.TabIndex = 2
        Me.btnSorgu.Text = "SORGUYU VER !"
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.Location = New System.Drawing.Point(8, 48)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(568, 224)
        Me.Panel.TabIndex = 0
        '
        'btnAra
        '
        Me.btnAra.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAra.Location = New System.Drawing.Point(408, 8)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(120, 23)
        Me.btnAra.TabIndex = 1
        Me.btnAra.Text = "ARAMA YAP !"
        '
        'NicePanel4
        '
        Me.NicePanel4.BackColor = System.Drawing.Color.Transparent
        ContainerImage5.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage5.Image = Nothing
        ContainerImage5.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage5.Transparency = 50
        Me.NicePanel4.ContainerImage = ContainerImage5
        Me.NicePanel4.ContextMenuButton = False
        Me.NicePanel4.Controls.Add(Me.lstColumns)
        HeaderImage9.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage9.Image = Nothing
        Me.NicePanel4.FooterImage = HeaderImage9
        Me.NicePanel4.FooterText = ""
        Me.NicePanel4.ForeColor = System.Drawing.Color.Black
        HeaderImage10.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage10.Image = Nothing
        Me.NicePanel4.HeaderImage = HeaderImage10
        Me.NicePanel4.HeaderText = "COLUMNS"
        Me.NicePanel4.IsExpanded = True
        Me.NicePanel4.Location = New System.Drawing.Point(8, 288)
        Me.NicePanel4.Name = "NicePanel4"
        Me.NicePanel4.OriginalFooterVisible = True
        Me.NicePanel4.OriginalHeight = 0
        Me.NicePanel4.Size = New System.Drawing.Size(208, 296)
        ContainerStyle5.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(240, Byte), CType(221, Byte))
        ContainerStyle5.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle5.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle5.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle5.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle5.FadeColor = System.Drawing.Color.FromArgb(CType(155, Byte), CType(207, Byte), CType(152, Byte))
        ContainerStyle5.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle5.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle5.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        ContainerStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle5.ForeColor = System.Drawing.Color.Black
        ContainerStyle5.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle5.ContainerStyle = ContainerStyle5
        PanelHeaderStyle9.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle9.ButtonColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(191, Byte), CType(227, Byte))
        PanelHeaderStyle9.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle9.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle9.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle9.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle9.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle9.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle5.FooterStyle = PanelHeaderStyle9
        PanelHeaderStyle10.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle10.ButtonColor = System.Drawing.Color.FromArgb(CType(184, Byte), CType(233, Byte), CType(184, Byte))
        PanelHeaderStyle10.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle10.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle10.FlashBackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(122, Byte), CType(1, Byte))
        PanelHeaderStyle10.FlashFadeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(215, Byte), CType(159, Byte))
        PanelHeaderStyle10.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle10.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        PanelHeaderStyle10.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle5.HeaderStyle = PanelHeaderStyle10
        Me.NicePanel4.Style = PanelStyle5
        Me.NicePanel4.TabIndex = 2
        '
        'lstColumns
        '
        Me.lstColumns.Location = New System.Drawing.Point(8, 48)
        Me.lstColumns.Name = "lstColumns"
        Me.lstColumns.Size = New System.Drawing.Size(192, 225)
        Me.lstColumns.TabIndex = 0
        '
        'cmnuQueryKosulTextbox
        '
        Me.cmnuQueryKosulTextbox.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuQK_Esit, Me.cmnuQK_EsitDegil, Me.cmnuQK_Kucuk, Me.cmnuQK_Buyuk, Me.cmnuQK_BuyukEsit, Me.cmnuQK_KucukEsit, Me.cmnuQK_Like})
        '
        'cmnuQK_Esit
        '
        Me.cmnuQK_Esit.Index = 0
        Me.cmnuQK_Esit.Text = "="
        '
        'cmnuQK_EsitDegil
        '
        Me.cmnuQK_EsitDegil.Index = 1
        Me.cmnuQK_EsitDegil.Text = "<>"
        '
        'cmnuQK_Kucuk
        '
        Me.cmnuQK_Kucuk.Index = 2
        Me.cmnuQK_Kucuk.Text = "<"
        '
        'cmnuQK_Buyuk
        '
        Me.cmnuQK_Buyuk.Index = 3
        Me.cmnuQK_Buyuk.Text = ">"
        '
        'cmnuQK_BuyukEsit
        '
        Me.cmnuQK_BuyukEsit.Index = 4
        Me.cmnuQK_BuyukEsit.Text = ">="
        '
        'cmnuQK_KucukEsit
        '
        Me.cmnuQK_KucukEsit.Index = 5
        Me.cmnuQK_KucukEsit.Text = "<="
        '
        'cmnuQK_Like
        '
        Me.cmnuQK_Like.Index = 6
        Me.cmnuQK_Like.Text = "Like"
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'cmnuQueryKosulCheckbox
        '
        Me.cmnuQueryKosulCheckbox.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuQK_CHK_Esit, Me.cmnuQK_CHK_EsitDegil})
        '
        'cmnuQK_CHK_Esit
        '
        Me.cmnuQK_CHK_Esit.Index = 0
        Me.cmnuQK_CHK_Esit.Text = "="
        '
        'cmnuQK_CHK_EsitDegil
        '
        Me.cmnuQK_CHK_EsitDegil.Index = 1
        Me.cmnuQK_CHK_EsitDegil.Text = "<>"
        '
        'cmnuQueryKosulDateTimePic
        '
        Me.cmnuQueryKosulDateTimePic.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuQK_DTP_Esit, Me.cmnuQK_DTP_EsitDegil, Me.cmnuQK_DTP_BuyukEsit, Me.cmnuQK_DTP_KucukEsit, Me.cmnuQK_DTP_Buyuk, Me.cmnuQK_DTP_Kucuk})
        '
        'cmnuQK_DTP_Esit
        '
        Me.cmnuQK_DTP_Esit.Index = 0
        Me.cmnuQK_DTP_Esit.Text = "="
        '
        'cmnuQK_DTP_EsitDegil
        '
        Me.cmnuQK_DTP_EsitDegil.Index = 1
        Me.cmnuQK_DTP_EsitDegil.Text = "<>"
        '
        'cmnuQK_DTP_BuyukEsit
        '
        Me.cmnuQK_DTP_BuyukEsit.Index = 2
        Me.cmnuQK_DTP_BuyukEsit.Text = ">="
        '
        'cmnuQK_DTP_KucukEsit
        '
        Me.cmnuQK_DTP_KucukEsit.Index = 3
        Me.cmnuQK_DTP_KucukEsit.Text = "<="
        '
        'cmnuQK_DTP_Buyuk
        '
        Me.cmnuQK_DTP_Buyuk.Index = 4
        Me.cmnuQK_DTP_Buyuk.Text = ">"
        '
        'cmnuQK_DTP_Kucuk
        '
        Me.cmnuQK_DTP_Kucuk.Index = 5
        Me.cmnuQK_DTP_Kucuk.Text = "<"
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 613)
        Me.Controls.Add(Me.NicePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form1"
        Me.NicePanel1.ResumeLayout(False)
        Me.NicePanel2.ResumeLayout(False)
        Me.NicePanel6.ResumeLayout(False)
        CType(Me.dgAraSonuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QueryPanel.ResumeLayout(False)
        Me.NicePanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Yerel Degiskenler"
    Private myConnStr As String
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myDR As SqlDataReader

    Private strDatabase As String = Nothing
    Private strTable As String = Nothing
    'Database adetini saklýyacak deðiþkeni tanýmlýyoruz..
    Private ParentNodeNum As Integer

    Private UserID As String
    Private Password As String

    Private TblNotNullColumns As DataTable
    Private TblPrimaryColumns As DataTable
    Private TblIdentityColumns As DataTable
    Private TblColumns As DataTable
    Private CurrentControl As Control
#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Yeni Sql baglantisi tanimliyoruz..
        Dim myconn As SqlConnection = New SqlConnection("Server=.\SQLEXPRESS;Database=master;Integrated Security=SSPI;")

        'Yeni Sql Sorgusu tanimliyoruz..
        Dim myCmd As SqlCommand = New SqlCommand("select name from master.dbo.sysdatabases", myconn)

        'Sql data okuyucu tanimlanir..
        Dim myDR As SqlDataReader

        'Baðlanti açilir ve data okuma gerçekleþtirilir..
        myconn.Open()
        myDR = myCmd.ExecuteReader

        'Treeview a Database ve onlarýn alt dallarý olarak her database in içeriðindeki tablolar eklenir..
        Do While myDR.Read
            Me.TreeView1.Nodes.Add(myDR.Item(0))
        Loop

        'Data okuyucu yeni bir sorgu ve okuma için kapatýlýr..
        myDR.Close()

        'Sql sorgusu ;database adetini bize verir..
        myCmd = New SqlCommand("SELECT count(name) from master.dbo.sysdatabases", myconn)

        'Database adeti okunur..
        myDR = myCmd.ExecuteReader

        'Datareader sorgu neticesini okur.. 
        Do While myDR.Read
            'Database adeti deðþkene atanýr..
            ParentNodeNum = myDR.Item(0)
        Loop

        'Datareader kapatýlýr..
        myDR.Close()

        'Her bir database için döngü saðlanýr..
        For i As Integer = 0 To ParentNodeNum - 1
            'Her database in içeriðindeki tablo isimlerini döndürecek sorgu..
            myCmd = New SqlCommand("select name from " & Me.TreeView1.Nodes.Item(i).Text & ".dbo.sysobjects where xtype='U' and name<>'dtProperties'", myconn)

            'DataReader okuma yapar..
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                'Eger boþ dönerse hata olusmamasý için boþ oldugunda Treeview e
                'ekleme yapýlmamasý saðlanýr..
                If Not myDR.Item(0) = Nothing Then
                    'Her bir database in içeriðindeki tablo adý treeview a eklenir..
                    Me.TreeView1.Nodes.Item(i).Nodes.Add(myDR.Item(0))
                End If
            Loop

            'Döngünün her tekrarý için DataReader kapatýlýr..
            myDR.Close()
        Next

        'Baðlantý kapatýlýr..
        myconn.Close()
    End Sub

    Public Sub FillComboBox(ByVal cmd As ComboBox, ByVal TableName As String)
        Dim Columns(1) As String
        Dim i As Integer = 0

        cmd.Items.Clear()
        myConn.Open()
        myConn.ChangeDatabase(Me.strDatabase)

        Dim myCmd As New SqlCommand("select name from syscolumns where id=object_id('" & TableName & "') and colorder in(1,2) order by colorder", myConn)

        Dim myDR As SqlDataReader
        myDR = myCmd.ExecuteReader

        While myDR.Read
            Columns(i) = myDR.Item(0).ToString
            i += 1
        End While

        myDR.Close()

        Dim myDA As New SqlDataAdapter("select " & Columns(0) & "," & Columns(1) & "  from " & TableName, myConn)

        Dim DataTable As New DataTable

        myDA.Fill(DataTable)
        cmd.DisplayMember = Columns(1)
        cmd.ValueMember = Columns(0)
        cmd.DataSource = DataTable
        myConn.Close()
    End Sub

    Private Sub btnAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAra.Click
        Dim WhereString As String = " WHERE "

        For Each ctrl As Control In Panel.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If Not txt.Text = "" Then
                    WhereString &= txt.Name & " LIKE '" & txt.Text & "' AND"
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cmb As ComboBox = CType(ctrl, ComboBox)
                If Not cmb.SelectedValue = "" Then
                    WhereString &= cmb.Name & " = '" & cmb.SelectedValue & "' AND"
                End If
            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dtp As DateTimePicker = CType(ctrl, DateTimePicker)
                If dtp.Checked = True Then
                    WhereString &= dtp.Name & " = '" & dtp.Text & "' AND"
                End If
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                If chk.CheckState = CheckState.Checked Then
                    WhereString &= chk.Name & "=1 AND"
                ElseIf chk.CheckState = CheckState.Unchecked Then
                    WhereString &= chk.Name & "=0 AND"
                End If
            End If
        Next

        'Sondaki AND operatoru kesilir..
        WhereString = WhereString.Substring(0, Len(WhereString) - 4)

        If WhereString <> " WHERE " Then
            WhereString = "SELECT * FROM [" & Me.strTable & "]" & WhereString
        Else
            WhereString = "SELECT * FROM [" & Me.strTable & "]"
        End If

        Dim myDA As New SqlDataAdapter(WhereString, myConn)
        Dim myDT As New DataTable
        myDA.Fill(myDT)
        Me.dgAraSonuc.DataSource = myDT
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Try

            If Not Me.TreeView1.SelectedNode.Parent Is Nothing Then
                Me.strDatabase = Me.TreeView1.SelectedNode.Parent.Text
                Me.strTable = Me.TreeView1.SelectedNode.Text
            Else
                Me.lstColumns.Items.Clear()
                Me.Panel.Controls.Clear()
                Exit Sub
            End If

            'Location X,Y ilk deger belirlenir ve kaç tane nesne kondugunu sayan bir 
            'index degiskeni ve baþlýklar için font degiskenleri girilir..
            Dim LocX As Integer = 10
            Dim LocY As Integer = 10
            Dim index As Integer = 0
            Dim FontStyle As Font = Me.QueryPanel.Style.HeaderStyle.Font
            Dim CurrentColumn As String = ""

            myConnStr = "Server=.\SQLEXPRESS;Database=" & Me.strDatabase & ";Integrated Security=SSPI;"

            myConn = New SqlConnection
            myConn.ConnectionString = myConnStr

            Me.lstColumns.Items.Clear()
            'Panel içindeki nesneler silinir..
            Me.Panel.Controls.Clear()

            '*****************************************************

            'Seçilen tablo'nun kolonlarýný listelemek için DataTable kullanýyoruz..
            TblColumns = New DataTable

            'Seçilen Tablo'nun kolonlarý okunur ve DataTable a aktarýlýr..
            Dim myDA As New SqlDataAdapter("SELECT syscolumns.name,systypes.name,syscolumns.colorder FROM syscolumns,systypes WHERE syscolumns.id=object_id('" & Me.strDatabase & ".." & Me.strTable & "') AND syscolumns.xtype=systypes.xtype AND systypes.xtype=systypes.xusertype ORDER BY syscolumns.colorder", myConn)

            myDA.Fill(TblColumns)

            '*****************************************************

            'Not Null geçilemeyecek kolonlarý kaydetmek için DataTable atnýmlýyoruz..
            TblNotNullColumns = New DataTable

            'Not NUll geçilemeyecek kolonlar listeleniyor..
            myDA = New SqlDataAdapter("select name from " & Me.strDatabase & "..syscolumns where id=object_id('" & Me.strTable & "') and isnullable=0", myConn)

            myDA.Fill(TblNotNullColumns)

            '*****************************************************
            'Primary Key olan kolonlarý DataTable'a aktardýk..
            TblPrimaryColumns = New DataTable

            myDA = New SqlDataAdapter("select parent_obj=object_name(parent_obj) from " & Me.strDatabase & "..sysobjects where xtype='PK' and object_name(parent_obj)<>'dtproperties'", myConn)

            myDA.Fill(TblPrimaryColumns)

            '*****************************************************
            'Identity olan kolonlarý DataTable'a aktardýk..
            TblIdentityColumns = New DataTable

            myDA = New SqlDataAdapter("select name from " & Me.strDatabase & ".dbo.syscolumns where colstat=1 and id=object_id('" & Me.strTable & "')", myConn)

            myDA.Fill(TblIdentityColumns)

            '*****************************************************

            'Ýliþkili kolonlarýn iliþkili olduklarý tablo ile baðlantýsý 
            'saðlamak için DataTable olusturduk..
            Dim Tblsysforeignkeys As New DataTable

            myDA = New SqlDataAdapter("select object_name(rkeyid),fkey from sysforeignkeys where object_name(fkeyid)='" & Me.strTable & "'", myConn)

            myDA.Fill(Tblsysforeignkeys)

            '*****************************************************

            'Bi tablonun kolonlarýný tblColumns adlý datatable a aldýk..
            For i As Integer = 0 To TblColumns.Rows.Count - 1
                'Kolon ismini listeye ekledik..
                Me.lstColumns.Items.Add(TblColumns.Rows(i).Item(0))

                'Kolon iliþkilimi diye kontrol ediyoruz,Tblsysforeignkeys datatable ile..
                For k As Integer = 0 To Tblsysforeignkeys.Rows.Count - 1
                    If TblColumns.Rows(i).Item(2) = Tblsysforeignkeys.Rows(k).Item(1) Then
                        CurrentColumn = Tblsysforeignkeys.Rows(k).Item(0)
                        Exit For
                    End If
                Next

                'Eger ilk nesne deðilse ve 5 in katlarý ise eklenecek nesne için 
                'alt satýr a geçilir ve X ilk haline getirilir..
                If index Mod 5 = 0 AndAlso index <> 0 Then
                    LocY += 50
                    LocX = 10
                End If

                'Kolon baþlýklarý için label eklenir..
                Dim LabelControl As New Label

                LabelControl.Size = New System.Drawing.Size(100, 20)
                LabelControl.Location = New System.Drawing.Point(LocX, LocY)
                LabelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                LabelControl.TextAlign = ContentAlignment.TopCenter
                LabelControl.Font = FontStyle

                'Eger sonunda ID yazan kolon varsa onun baþlýgýný yazarken 
                'ID ekini çýkarýr..
                If TblColumns.Rows(i)(0).ToString.EndsWith("ID") Then
                    LabelControl.Text = TblColumns.Rows(i)(0).ToString.Substring(0, Len(TblColumns.Rows(i)(0).ToString) - 2)
                Else
                    LabelControl.Text = TblColumns.Rows(i).Item(0).ToString
                End If

                'Eger þuan okunan kolon not null geçilemeyecek bi kolon ise
                'bunu TblNotNullColumns'dan kontrol edip baþlýnýn sonuna(*) 
                'konulur..
                For k As Integer = 0 To TblNotNullColumns.Rows.Count - 1
                    If TblColumns.Rows(i)(0).ToString = TblNotNullColumns.Rows(k)(0).ToString Then
                        LabelControl.Text &= "*"
                        LabelControl.ForeColor = Color.DarkRed
                    End If
                Next

                Me.Panel.Controls.Add(LabelControl)

                'Kolonun veri tipine gore datetimepicker,numericupdown 
                'yada textbox eklenir..
                If Not CurrentColumn = "" Then
                    'datetimepicker eklemek..
                    Dim combobox As New ComboBox

                    combobox.Name = TblColumns.Rows(i).Item(0)
                    combobox.Size = New System.Drawing.Size(100, 20)
                    combobox.Location = New System.Drawing.Point(LocX, LocY + 25)
                    combobox.DropDownStyle = ComboBoxStyle.DropDownList

                    Me.Panel.Controls.Add(combobox)
                    FillComboBox(combobox, CurrentColumn)
                Else
                    Select Case TblColumns.Rows(i).Item(1).ToString
                        Case "datetime", "smalldatetime"
                            'datetimepicker eklemek..
                            Dim DateTime As New myDateTimePicker

                            DateTime.Name = TblColumns.Rows(i).Item(0)
                            DateTime.Size = New System.Drawing.Size(100, 20)
                            DateTime.Location = New System.Drawing.Point(LocX, LocY + 25)
                            DateTime.Format = DateTimePickerFormat.Short
                            DateTime.ShowCheckBox = True
                            DateTime.ContextMenu = Me.cmnuQueryKosulDateTimePic
                            DateTime.Value = Now
                            DateTime.IsNullable = True

                            For k As Integer = 0 To TblNotNullColumns.Rows.Count - 1
                                If TblColumns.Rows(i)(0).ToString = TblNotNullColumns.Rows(k)(0).ToString Then
                                    DateTime.IsNullable = False
                                    Exit For
                                End If
                            Next

                            Me.Panel.Controls.Add(DateTime)
                            DateTime.Checked = False

                            AddHandler DateTime.MouseHover, AddressOf ReadControl
                        Case "bit"
                            'checkbox eklemek..
                            Dim chkbox As New myCheckBox

                            chkbox.Name = TblColumns.Rows(i).Item(0)
                            chkbox.Size = New System.Drawing.Size(100, 20)
                            chkbox.Location = New System.Drawing.Point(LocX, LocY + 25)
                            chkbox.FlatStyle = FlatStyle.Popup
                            chkbox.ThreeState = True
                            chkbox.ContextMenu = Me.cmnuQueryKosulCheckbox
                            chkbox.IsNullable = True

                            For k As Integer = 0 To TblNotNullColumns.Rows.Count - 1
                                If TblColumns.Rows(i)(0).ToString = TblNotNullColumns.Rows(k)(0).ToString Then
                                    chkbox.IsNullable = False
                                    Exit For
                                End If
                            Next

                            Me.Panel.Controls.Add(chkbox)
                            chkbox.CheckState = CheckState.Indeterminate

                            AddHandler chkbox.MouseHover, AddressOf ReadControl
                        Case Else
                            'Textbox eklemek..
                            Dim TextControl As New myTextbox

                            TextControl.Name = TblColumns.Rows(i).Item(0)
                            TextControl.Size = New System.Drawing.Size(100, 20)
                            TextControl.Location = New System.Drawing.Point(LocX, LocY + 25)
                            TextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                            TextControl.TextAlign = HorizontalAlignment.Center
                            TextControl.ContextMenu = Me.cmnuQueryKosulTextbox
                            TextControl.Text = Nothing
                            TextControl.IsNullable = True

                            For k As Integer = 0 To TblNotNullColumns.Rows.Count - 1

                                If TblColumns.Rows(i)(0).ToString = TblNotNullColumns.Rows(k)(0).ToString Then
                                    TextControl.IsNullable = False
                                    Exit For
                                End If
                            Next

                            Me.Panel.Controls.Add(TextControl)

                            AddHandler TextControl.MouseHover, AddressOf ReadControl
                    End Select
                End If

                'X degeri arttýrýlýr..
                LocX += 110
                'Nesne sayýsý arttýrýlýr..
                index += 1

                CurrentColumn = ""
            Next

        Catch exSql As SqlException
            MessageBox.Show(exSql.Message, "SQL HATA !")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !")
        End Try
    End Sub

    Private Sub cmnuQ_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQ_Insert.Click

        If Me.Panel.Controls.Count = 0 Then
            MessageBox.Show("Bir Tablo yada içinde kayýtlý alan olan bir Tablo seçiniz..", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'Kontrollerin Nullable durumlarýnýn kontrolu..
        'Eger boþ geçilemez bir kontrol boþ býrakýldýysa insert iþlemi iptal edilcek.
        For Each ctrl As Control In Me.Panel.Controls
            'myTextbox larýn kontrolu..
            If TypeOf ctrl Is myTextbox Then
                If CType(ctrl, myTextbox).IsNullable = False AndAlso CType(ctrl, myTextbox).Text.Length = 0 Then
                    Me.Err.SetError(ctrl, ctrl.Name & " insert iþlemi için boþ geçilemez..")
                    Exit Sub
                Else
                    Me.Err.SetError(ctrl, "")
                End If
                'myCheckbox larýn kontrolu..
            ElseIf TypeOf ctrl Is myCheckBox Then
                If CType(ctrl, myCheckBox).IsNullable = False AndAlso CType(ctrl, myCheckBox).CheckState = CheckState.Indeterminate Then
                    Me.Err.SetError(ctrl, ctrl.Name & " insert iþlemi için boþ geçilemez..")
                    Exit Sub
                Else
                    Me.Err.SetError(ctrl, "")
                End If
                'myDateTimePicker larýn kontrolu..
            ElseIf TypeOf ctrl Is myDateTimePicker Then
                If CType(ctrl, myDateTimePicker).IsNullable = False AndAlso CType(ctrl, myDateTimePicker).Checked = False Then
                    Me.Err.SetError(ctrl, ctrl.Name & " insert iþlemi için boþ geçilemez..")
                    Exit Sub
                Else
                    Me.Err.SetError(ctrl, "")
                End If
            End If
        Next

        Dim InsertQuery As String
        Dim TherePrimary As Boolean = False

        For i As Integer = 0 To Me.TblPrimaryColumns.Rows.Count - 1
            If Me.strTable = Me.TblPrimaryColumns.Rows(i)(0).tostring Then
                TherePrimary = True
            End If
        Next

        InsertQuery = "INSERT INTO " & Me.strDatabase & ".." & Me.strTable & "("

        For i As Integer = 0 To Me.TblColumns.Rows.Count - 1
            If Not (TherePrimary = True AndAlso i = 0) Then
                InsertQuery &= Me.TblColumns.Rows(i)(0).ToString & ","
            End If
        Next

        InsertQuery = InsertQuery.Substring(0, Len(InsertQuery) - 1)
        InsertQuery &= ") VALUES ("

        For i As Integer = 0 To Me.TblColumns.Rows.Count - 1
            If Not (TherePrimary = True AndAlso i = 0) Then
                InsertQuery &= "@" & Me.TblColumns.Rows(i)(0).ToString & ","
            End If
        Next

        InsertQuery = InsertQuery.Substring(0, Len(InsertQuery) - 1) & ")"

        MsgBox(InsertQuery)

    End Sub

    Private Sub cmnuQ_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQ_Update.Click
        If Me.Panel.Controls.Count = 0 Then
            MessageBox.Show("Bir Tablo yada içinde kayýtlý alan olan bir Tablo seçiniz..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim UpdateQuery As String

        UpdateQuery = "UPDATE " & Me.strDatabase & ".." & Me.strTable & " SET "

        For i As Integer = 1 To Me.TblColumns.Rows.Count - 1
            UpdateQuery &= Me.TblColumns.Rows(i)(0).ToString & "=@" & Me.TblColumns.Rows(i)(0).ToString & ","
        Next

        UpdateQuery = UpdateQuery.Substring(0, Len(UpdateQuery) - 1)
        UpdateQuery &= " WHERE " & Me.TblColumns.Rows(1)(0).ToString & "=@" & Me.TblColumns.Rows(1)(0).ToString

        MsgBox(UpdateQuery)
    End Sub

    Private Sub cmnuQ_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQ_Delete.Click
        If Me.Panel.Controls.Count = 0 Then
            MessageBox.Show("Bir Tablo yada içinde kayýtlý alan olan bir Tablo seçiniz..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim UpdateQuery As String

        DialogResult = MessageBox.Show(" adlý kayýtý silmek üzeresiniz!Devam etmek istiyor musunuz?", "Kayýtý Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            UpdateQuery = "DELETE FROM " & Me.strDatabase & ".." & Me.strTable & " WHERE " & Me.TblColumns.Rows(1)(0).ToString & "=@" & Me.TblColumns.Rows(1)(0).ToString

            MsgBox(UpdateQuery)
        End If

    End Sub

    Private Sub cmnuQ_AllDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQ_AllDelete.Click
        If Me.Panel.Controls.Count = 0 Then
            MessageBox.Show("Bir Tablo yada içinde kayýtlý alan olan bir Tablo seçiniz..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim UpdateQuery As String

        DialogResult = MessageBox.Show("Tüm kayýtlarý silmek üzeresiniz!Devam etmek istiyor musunuz?", "Tüm Kayýtlarý Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            UpdateQuery = "DELETE FROM " & Me.strDatabase & ".." & Me.strTable

            MsgBox(UpdateQuery)
        End If
    End Sub

    Private Sub cmnuQK_Esit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQK_Esit.Click, cmnuQK_Buyuk.Click, cmnuQK_BuyukEsit.Click, cmnuQK_EsitDegil.Click, cmnuQK_Kucuk.Click, cmnuQK_KucukEsit.Click, cmnuQK_Like.Click

        Dim Kosul As MenuItem = CType(sender, MenuItem)

        If TypeOf Me.CurrentControl Is myTextbox Then
            Dim ctrl As myTextbox = CType(Me.CurrentControl, myTextbox)
            If Not ctrl.Text = "" Then
                ctrl.Kosul = Kosul.Text
            Else
                ctrl.Kosul = ""
            End If
        End If
    End Sub

    Private Sub cmnuQK_CHK_Esit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQK_CHK_Esit.Click, cmnuQK_CHK_EsitDegil.Click

        Dim Kosul As MenuItem = CType(sender, MenuItem)

        If TypeOf Me.CurrentControl Is myDateTimePicker Then
            Dim ctrl As myDateTimePicker = CType(Me.CurrentControl, myDateTimePicker)
            If Not ctrl.Checked = False Then
                ctrl.Kosul = Kosul.Text
            Else
                ctrl.Kosul = ""
            End If
        End If

    End Sub

    Private Sub cmnuQK_DTP_Esit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuQK_DTP_Esit.Click, cmnuQK_DTP_Buyuk.Click, cmnuQK_DTP_BuyukEsit.Click, cmnuQK_DTP_EsitDegil.Click, cmnuQK_DTP_Kucuk.Click, cmnuQK_DTP_KucukEsit.Click

        Dim Kosul As MenuItem = CType(sender, MenuItem)

        If TypeOf Me.CurrentControl Is myCheckBox Then
            Dim ctrl As myCheckBox = CType(Me.CurrentControl, myCheckBox)
            If Not ctrl.CheckState = CheckState.Indeterminate Then
                ctrl.Kosul = Kosul.Text
            Else
                ctrl.Kosul = ""
            End If
        End If
    End Sub

    Private Sub btnSorgu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSorgu.Click
        Dim Query As String = Nothing

        For Each ctrl As Control In Me.Panel.Controls
            If TypeOf ctrl Is myTextbox Then
                Dim ctrl2 As myTextbox = CType(ctrl, myTextbox)
                'Kosul varsa ve Text boþ degilse..
                If Not ctrl2.Kosul = "" AndAlso _
                ctrl2.Text <> "" Then
                    Query &= ctrl2.name & ctrl2.Kosul & "'" & _
                    ctrl2.Text & "'" & " AND "
                    'Kosul varsa ve text boþsa..
                ElseIf Not ctrl2.Kosul = "" AndAlso _
                ctrl2.Text = "" Then
                    Query &= ctrl2.name & " is Null AND "
                    'Kosul yoksa ve text varsa..
                ElseIf ctrl2.Kosul = "" AndAlso _
                ctrl2.Text <> "" Then
                    Query &= ctrl2.name & "='" & ctrl2.Text & "'" & " AND "
                    'Kosul yoksa text yoksa..
                ElseIf ctrl2.Kosul = "" AndAlso _
                ctrl2.Text = "" Then
                    Query &= ctrl2.name & " is Null AND "
                End If
            ElseIf TypeOf ctrl Is myDateTimePicker Then
                Dim ctrl2 As myDateTimePicker = CType(ctrl, myDateTimePicker)
                'Kosul varsa ve Text boþ degilse..
                If Not ctrl2.Kosul = "" AndAlso _
                ctrl2.Value.ToShortDateString <> "" Then
                    Query &= ctrl2.name & ctrl2.Kosul & _
                    "'" & ctrl2.Value.ToShortDateString & "'" & " AND "
                    'Kosul varsa ve text boþsa..
                ElseIf Not ctrl2.Kosul = "" AndAlso _
                ctrl2.Value.ToShortDateString = "" Then
                    Query &= ctrl2.name & " is Null AND "
                    'Kosul yoksa ve text varsa..
                ElseIf ctrl2.Kosul = "" AndAlso _
                ctrl2.Value.ToShortDateString <> "" Then
                    Query &= ctrl2.name & "='" & ctrl2.Value.ToShortDateString & _
                    "'" & " AND "
                    'Kosul yoksa text yoksa..
                ElseIf ctrl2.Kosul = "" AndAlso _
                ctrl2.Value.ToShortDateString = "" Then
                    Query &= ctrl2.name & " is Null AND "
                End If
            ElseIf TypeOf ctrl Is myCheckBox Then
                Dim check As Integer
                Dim ctrl2 As myCheckBox = CType(ctrl, myCheckBox)
                check = ctrl2.CheckState
                'Kosul varsa ve Text boþ degilse..
                If Not ctrl2.Kosul = "" AndAlso _
                ctrl2.CheckState <> CheckState.Indeterminate Then
                    Query &= ctrl2.name & ctrl2.Kosul & check & " AND "
                    'Kosul varsa ve text boþsa..
                ElseIf Not ctrl2.Kosul = "" AndAlso _
                ctrl2.CheckState = CheckState.Indeterminate Then
                    Query &= ctrl2.name & " is Null AND "
                    'Kosul yoksa ve text varsa..
                ElseIf ctrl2.Kosul = "" AndAlso _
                ctrl2.CheckState <> CheckState.Indeterminate Then
                    Query &= ctrl2.name & "=" & check & " AND "
                    'Kosul yoksa text yoksa..
                ElseIf ctrl2.Kosul = "" AndAlso _
                ctrl2.CheckState = CheckState.Indeterminate Then
                    Query &= ctrl2.name & " is Null AND "
                End If
            End If
        Next

        Query = "SELECT * FROM " & Me.strDatabase & ".dbo.[" & Me.strTable & "] WHERE " & Query.Substring(0, Len(Query) - 5)

        Dim da As SqlDataAdapter = New SqlDataAdapter(Query, myConn)
        Dim dt As DataTable = New DataTable

        Try
            da.Fill(dt)
            Me.dgAraSonuc.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message.ToString)
        End Try

        'MsgBox(Query)
    End Sub

    'Textbox a yada diðer kontrollere çift týklama yapýlýnca iþleyecek sub..
    Public Sub ReadControl(ByVal sender As Object, ByVal e As EventArgs)
        Me.CurrentControl = sender
    End Sub


End Class
