#Region "imports"
Imports PureComponents.NicePanel
Imports System
Imports System.Data
Imports System.Data.SqlClient

#End Region

Public Class Form1
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
    Friend WithEvents NicePanel2 As PureComponents.NicePanel.NicePanel
    Friend WithEvents cmbDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents NicePanel3 As PureComponents.NicePanel.NicePanel
    Friend WithEvents cmbTables As System.Windows.Forms.ComboBox
    Friend WithEvents NicePanel4 As PureComponents.NicePanel.NicePanel
    Friend WithEvents lstColumns As System.Windows.Forms.ListBox
    Friend WithEvents QueryPanel As PureComponents.NicePanel.NicePanel
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents cmnuQueryKosulu As System.Windows.Forms.ContextMenu
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ContainerImage1 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage11 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage12 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle6 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle6 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle11 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle12 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage2 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage1 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage2 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle1 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle1 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle1 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle2 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage3 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage3 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage4 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle2 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle2 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle3 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle4 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage4 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage5 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage6 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle3 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle3 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle5 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle6 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage5 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage7 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage8 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle4 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle4 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle7 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle8 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage6 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage9 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage10 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle5 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle5 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle9 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle10 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Me.NicePanel1 = New PureComponents.NicePanel.NicePanel
        Me.NicePanel6 = New PureComponents.NicePanel.NicePanel
        Me.dgAraSonuc = New System.Windows.Forms.DataGrid
        Me.QueryPanel = New PureComponents.NicePanel.NicePanel
        Me.Panel = New System.Windows.Forms.Panel
        Me.btnAra = New System.Windows.Forms.Button
        Me.NicePanel4 = New PureComponents.NicePanel.NicePanel
        Me.lstColumns = New System.Windows.Forms.ListBox
        Me.NicePanel3 = New PureComponents.NicePanel.NicePanel
        Me.cmbTables = New System.Windows.Forms.ComboBox
        Me.NicePanel2 = New PureComponents.NicePanel.NicePanel
        Me.cmbDatabases = New System.Windows.Forms.ComboBox
        Me.cmnuQueryKosulu = New System.Windows.Forms.ContextMenu
        Me.cmnuQK_Esit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_EsitDegil = New System.Windows.Forms.MenuItem
        Me.cmnuQK_Kucuk = New System.Windows.Forms.MenuItem
        Me.cmnuQK_Buyuk = New System.Windows.Forms.MenuItem
        Me.cmnuQK_BuyukEsit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_KucukEsit = New System.Windows.Forms.MenuItem
        Me.cmnuQK_Like = New System.Windows.Forms.MenuItem
        Me.NicePanel1.SuspendLayout()
        Me.NicePanel6.SuspendLayout()
        CType(Me.dgAraSonuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QueryPanel.SuspendLayout()
        Me.NicePanel4.SuspendLayout()
        Me.NicePanel3.SuspendLayout()
        Me.NicePanel2.SuspendLayout()
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
        Me.NicePanel1.Controls.Add(Me.NicePanel6)
        Me.NicePanel1.Controls.Add(Me.QueryPanel)
        Me.NicePanel1.Controls.Add(Me.NicePanel4)
        Me.NicePanel1.Controls.Add(Me.NicePanel3)
        Me.NicePanel1.Controls.Add(Me.NicePanel2)
        Me.NicePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        HeaderImage11.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage11.Image = Nothing
        Me.NicePanel1.FooterImage = HeaderImage11
        Me.NicePanel1.FooterText = "PureComponents NicePanel for .NET WinForms V1.0."
        Me.NicePanel1.ForeColor = System.Drawing.Color.Black
        HeaderImage12.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage12.Image = Nothing
        Me.NicePanel1.HeaderImage = HeaderImage12
        Me.NicePanel1.HeaderText = "...::: WIN QUERY BUILDING :::..."
        Me.NicePanel1.IsExpanded = True
        Me.NicePanel1.Location = New System.Drawing.Point(0, 0)
        Me.NicePanel1.MouseMoveTarget = PureComponents.NicePanel.MouseMoveTarget.Form
        Me.NicePanel1.Name = "NicePanel1"
        Me.NicePanel1.OriginalFooterVisible = True
        Me.NicePanel1.OriginalHeight = 0
        Me.NicePanel1.Size = New System.Drawing.Size(816, 613)
        ContainerStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle6.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle6.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle6.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle6.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle6.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle6.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle6.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle6.ForeColor = System.Drawing.Color.Black
        ContainerStyle6.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle6.ContainerStyle = ContainerStyle6
        PanelHeaderStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle11.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle11.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle11.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle11.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle11.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle11.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle11.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle6.FooterStyle = PanelHeaderStyle11
        PanelHeaderStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle12.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle12.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle12.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle12.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle12.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle12.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle12.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle12.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelHeaderStyle12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        PanelStyle6.HeaderStyle = PanelHeaderStyle12
        Me.NicePanel1.Style = PanelStyle6
        Me.NicePanel1.TabIndex = 0
        '
        'NicePanel6
        '
        Me.NicePanel6.BackColor = System.Drawing.Color.Transparent
        ContainerImage2.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage2.Image = Nothing
        ContainerImage2.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage2.Transparency = 50
        Me.NicePanel6.ContainerImage = ContainerImage2
        Me.NicePanel6.ContextMenuButton = False
        Me.NicePanel6.Controls.Add(Me.dgAraSonuc)
        HeaderImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage1.Image = Nothing
        Me.NicePanel6.FooterImage = HeaderImage1
        Me.NicePanel6.FooterText = ""
        Me.NicePanel6.ForeColor = System.Drawing.Color.Black
        HeaderImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage2.Image = Nothing
        Me.NicePanel6.HeaderImage = HeaderImage2
        Me.NicePanel6.HeaderText = "ARAMA SONUÇLARI"
        Me.NicePanel6.IsExpanded = True
        Me.NicePanel6.Location = New System.Drawing.Point(224, 48)
        Me.NicePanel6.Name = "NicePanel6"
        Me.NicePanel6.OriginalFooterVisible = True
        Me.NicePanel6.OriginalHeight = 0
        Me.NicePanel6.Size = New System.Drawing.Size(584, 200)
        ContainerStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(221, Byte), Integer))
        ContainerStyle1.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle1.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle1.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle1.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(152, Byte), Integer))
        ContainerStyle1.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle1.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle1.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle1.ForeColor = System.Drawing.Color.Black
        ContainerStyle1.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle1.ContainerStyle = ContainerStyle1
        PanelHeaderStyle1.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle1.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle1.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle1.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle1.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle1.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle1.FooterStyle = PanelHeaderStyle1
        PanelHeaderStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle2.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle2.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle2.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle2.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle2.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PanelHeaderStyle2.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle1.HeaderStyle = PanelHeaderStyle2
        Me.NicePanel6.Style = PanelStyle1
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
        Me.dgAraSonuc.Size = New System.Drawing.Size(568, 128)
        Me.dgAraSonuc.TabIndex = 0
        '
        'QueryPanel
        '
        Me.QueryPanel.BackColor = System.Drawing.Color.Transparent
        ContainerImage3.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage3.Image = Nothing
        ContainerImage3.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage3.Transparency = 50
        Me.QueryPanel.ContainerImage = ContainerImage3
        Me.QueryPanel.ContextMenuButton = False
        Me.QueryPanel.Controls.Add(Me.Panel)
        Me.QueryPanel.Controls.Add(Me.btnAra)
        HeaderImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage3.Image = Nothing
        Me.QueryPanel.FooterImage = HeaderImage3
        Me.QueryPanel.FooterText = ""
        Me.QueryPanel.ForeColor = System.Drawing.Color.Black
        HeaderImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage4.Image = Nothing
        Me.QueryPanel.HeaderImage = HeaderImage4
        Me.QueryPanel.HeaderText = "QUERY STRING"
        Me.QueryPanel.IsExpanded = True
        Me.QueryPanel.Location = New System.Drawing.Point(224, 256)
        Me.QueryPanel.Name = "QueryPanel"
        Me.QueryPanel.OriginalFooterVisible = True
        Me.QueryPanel.OriginalHeight = 0
        Me.QueryPanel.Size = New System.Drawing.Size(584, 328)
        ContainerStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(221, Byte), Integer))
        ContainerStyle2.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle2.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle2.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle2.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(152, Byte), Integer))
        ContainerStyle2.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle2.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle2.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle2.ForeColor = System.Drawing.Color.Black
        ContainerStyle2.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle2.ContainerStyle = ContainerStyle2
        PanelHeaderStyle3.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle3.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle3.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle3.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle3.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle3.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle3.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle2.FooterStyle = PanelHeaderStyle3
        PanelHeaderStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle4.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle4.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle4.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle4.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle4.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PanelHeaderStyle4.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle2.HeaderStyle = PanelHeaderStyle4
        Me.QueryPanel.Style = PanelStyle2
        Me.QueryPanel.TabIndex = 3
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.Location = New System.Drawing.Point(8, 48)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(568, 256)
        Me.Panel.TabIndex = 0
        '
        'btnAra
        '
        Me.btnAra.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAra.Location = New System.Drawing.Point(408, 8)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(120, 23)
        Me.btnAra.TabIndex = 1
        Me.btnAra.Text = "ARAMA YAP!"
        '
        'NicePanel4
        '
        Me.NicePanel4.BackColor = System.Drawing.Color.Transparent
        ContainerImage4.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage4.Image = Nothing
        ContainerImage4.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage4.Transparency = 50
        Me.NicePanel4.ContainerImage = ContainerImage4
        Me.NicePanel4.ContextMenuButton = False
        Me.NicePanel4.Controls.Add(Me.lstColumns)
        HeaderImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage5.Image = Nothing
        Me.NicePanel4.FooterImage = HeaderImage5
        Me.NicePanel4.FooterText = ""
        Me.NicePanel4.ForeColor = System.Drawing.Color.Black
        HeaderImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage6.Image = Nothing
        Me.NicePanel4.HeaderImage = HeaderImage6
        Me.NicePanel4.HeaderText = "COLUMNS"
        Me.NicePanel4.IsExpanded = True
        Me.NicePanel4.Location = New System.Drawing.Point(8, 256)
        Me.NicePanel4.Name = "NicePanel4"
        Me.NicePanel4.OriginalFooterVisible = True
        Me.NicePanel4.OriginalHeight = 0
        Me.NicePanel4.Size = New System.Drawing.Size(208, 328)
        ContainerStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(221, Byte), Integer))
        ContainerStyle3.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle3.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle3.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle3.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle3.FadeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(152, Byte), Integer))
        ContainerStyle3.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle3.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle3.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle3.ForeColor = System.Drawing.Color.Black
        ContainerStyle3.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle3.ContainerStyle = ContainerStyle3
        PanelHeaderStyle5.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle5.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle5.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle5.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle5.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle5.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle5.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle3.FooterStyle = PanelHeaderStyle5
        PanelHeaderStyle6.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle6.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle6.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle6.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle6.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle6.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle6.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle6.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PanelHeaderStyle6.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle3.HeaderStyle = PanelHeaderStyle6
        Me.NicePanel4.Style = PanelStyle3
        Me.NicePanel4.TabIndex = 2
        '
        'lstColumns
        '
        Me.lstColumns.Location = New System.Drawing.Point(8, 48)
        Me.lstColumns.Name = "lstColumns"
        Me.lstColumns.Size = New System.Drawing.Size(192, 251)
        Me.lstColumns.TabIndex = 0
        '
        'NicePanel3
        '
        Me.NicePanel3.BackColor = System.Drawing.Color.Transparent
        ContainerImage5.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage5.Image = Nothing
        ContainerImage5.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage5.Transparency = 50
        Me.NicePanel3.ContainerImage = ContainerImage5
        Me.NicePanel3.ContextMenuButton = False
        Me.NicePanel3.Controls.Add(Me.cmbTables)
        HeaderImage7.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage7.Image = Nothing
        Me.NicePanel3.FooterImage = HeaderImage7
        Me.NicePanel3.FooterText = ""
        Me.NicePanel3.ForeColor = System.Drawing.Color.Black
        HeaderImage8.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage8.Image = Nothing
        Me.NicePanel3.HeaderImage = HeaderImage8
        Me.NicePanel3.HeaderText = "TABLES"
        Me.NicePanel3.IsExpanded = True
        Me.NicePanel3.Location = New System.Drawing.Point(8, 152)
        Me.NicePanel3.Name = "NicePanel3"
        Me.NicePanel3.OriginalFooterVisible = True
        Me.NicePanel3.OriginalHeight = 0
        Me.NicePanel3.Size = New System.Drawing.Size(208, 96)
        ContainerStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(221, Byte), Integer))
        ContainerStyle4.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle4.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle4.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle4.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle4.FadeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(152, Byte), Integer))
        ContainerStyle4.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle4.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle4.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle4.ForeColor = System.Drawing.Color.Black
        ContainerStyle4.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle4.ContainerStyle = ContainerStyle4
        PanelHeaderStyle7.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle7.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle7.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle7.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle7.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle7.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle7.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle7.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle4.FooterStyle = PanelHeaderStyle7
        PanelHeaderStyle8.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle8.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle8.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle8.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle8.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle8.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle8.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle8.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PanelHeaderStyle8.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle4.HeaderStyle = PanelHeaderStyle8
        Me.NicePanel3.Style = PanelStyle4
        Me.NicePanel3.TabIndex = 1
        '
        'cmbTables
        '
        Me.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTables.Location = New System.Drawing.Point(8, 48)
        Me.cmbTables.Name = "cmbTables"
        Me.cmbTables.Size = New System.Drawing.Size(184, 21)
        Me.cmbTables.Sorted = True
        Me.cmbTables.TabIndex = 1
        '
        'NicePanel2
        '
        Me.NicePanel2.BackColor = System.Drawing.Color.Transparent
        ContainerImage6.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage6.Image = Nothing
        ContainerImage6.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage6.Transparency = 50
        Me.NicePanel2.ContainerImage = ContainerImage6
        Me.NicePanel2.ContextMenuButton = False
        Me.NicePanel2.Controls.Add(Me.cmbDatabases)
        HeaderImage9.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage9.Image = Nothing
        Me.NicePanel2.FooterImage = HeaderImage9
        Me.NicePanel2.FooterText = ""
        Me.NicePanel2.ForeColor = System.Drawing.Color.Black
        HeaderImage10.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage10.Image = Nothing
        Me.NicePanel2.HeaderImage = HeaderImage10
        Me.NicePanel2.HeaderText = "DATABASES"
        Me.NicePanel2.IsExpanded = True
        Me.NicePanel2.Location = New System.Drawing.Point(8, 48)
        Me.NicePanel2.Name = "NicePanel2"
        Me.NicePanel2.OriginalFooterVisible = True
        Me.NicePanel2.OriginalHeight = 0
        Me.NicePanel2.Size = New System.Drawing.Size(208, 96)
        ContainerStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(221, Byte), Integer))
        ContainerStyle5.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle5.BorderColor = System.Drawing.Color.DarkGreen
        ContainerStyle5.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle5.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle5.FadeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(152, Byte), Integer))
        ContainerStyle5.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle5.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle5.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle5.ForeColor = System.Drawing.Color.Black
        ContainerStyle5.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle5.ContainerStyle = ContainerStyle5
        PanelHeaderStyle9.BackColor = System.Drawing.Color.ForestGreen
        PanelHeaderStyle9.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle9.FadeColor = System.Drawing.Color.LightGreen
        PanelHeaderStyle9.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle9.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle9.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle9.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle9.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle5.FooterStyle = PanelHeaderStyle9
        PanelHeaderStyle10.BackColor = System.Drawing.Color.DarkSeaGreen
        PanelHeaderStyle10.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(184, Byte), Integer))
        PanelHeaderStyle10.FadeColor = System.Drawing.Color.DarkGreen
        PanelHeaderStyle10.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle10.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle10.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle10.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle10.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PanelHeaderStyle10.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle5.HeaderStyle = PanelHeaderStyle10
        Me.NicePanel2.Style = PanelStyle5
        Me.NicePanel2.TabIndex = 0
        '
        'cmbDatabases
        '
        Me.cmbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDatabases.Location = New System.Drawing.Point(8, 48)
        Me.cmbDatabases.Name = "cmbDatabases"
        Me.cmbDatabases.Size = New System.Drawing.Size(184, 21)
        Me.cmbDatabases.Sorted = True
        Me.cmbDatabases.TabIndex = 1
        '
        'cmnuQueryKosulu
        '
        Me.cmnuQueryKosulu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuQK_Esit, Me.cmnuQK_EsitDegil, Me.cmnuQK_Kucuk, Me.cmnuQK_Buyuk, Me.cmnuQK_BuyukEsit, Me.cmnuQK_KucukEsit, Me.cmnuQK_Like})
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
        Me.cmnuQK_BuyukEsit.Text = "=>"
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
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 613)
        Me.Controls.Add(Me.NicePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.NicePanel1.ResumeLayout(False)
        Me.NicePanel6.ResumeLayout(False)
        CType(Me.dgAraSonuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QueryPanel.ResumeLayout(False)
        Me.NicePanel4.ResumeLayout(False)
        Me.NicePanel3.ResumeLayout(False)
        Me.NicePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Yerel Degiskenler"
    Private myConnStr As String
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myDR As SqlDataReader
#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConnStr = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=SSPI;"

        myConn = New SqlConnection
        myConn.ConnectionString = myConnStr

        myCmd = New SqlCommand
        myCmd.Connection = myConn
        myCmd.CommandType = CommandType.Text
        'sysdatabases tablosundan database isimlerini combobox a aktardýk..
        myCmd.CommandText = "SELECT name FROM sysdatabases"

        Dim myDR As SqlDataReader

        myConn.Open()
        myDR = myCmd.ExecuteReader

        Do While myDR.Read
            Me.cmbDatabases.Items.Add(myDR.Item("name"))
        Loop

        myConn.Close()

    End Sub

    Private Sub cmbDatabases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDatabases.SelectedIndexChanged

        'Birinci yol: 
        'ChangeDatabase komutunu kullanmak ama bunun için baðlantýyý 
        'onceden acmak gerekir..
        'myConn.Open()
        'myConn.ChangeDatabase(Me.cmbDatabases.SelectedItem.ToString)

        'Ýkinci Yol :
        myConnStr = "Data Source=.\SQLEXPRESS;Initial Catalog=" & Me.cmbDatabases.Text & ";Integrated Security=SSPI;"

        myConn = New SqlConnection
        myConn.ConnectionString = myConnStr

        myCmd = New SqlCommand
        myCmd.Connection = myConn
        myCmd.CommandType = CommandType.Text
        'sysobjects tablosundan database isimlerini combobox a aktardýk..
        myCmd.CommandText = "SELECT name,xtype FROM sysObjects where xtype='U' and name<>'dtProperties'"

        Dim myDR As SqlDataReader

        Me.cmbTables.Items.Clear()

        myConn.Open()
        myDR = myCmd.ExecuteReader

        Do While myDR.Read
            Me.cmbTables.Items.Add(myDR.Item("name"))
        Loop

        myConn.Close()
    End Sub

    Private Sub cmbTables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTables.SelectedIndexChanged

        'Location X,Y ilk deger belirlenir ve kaç tane nesne kondugunu sayan bir 
        'index degiskeni ve baþlýklar için font degiskenleri girilir..
        Dim LocX As Integer = 10
        Dim LocY As Integer = 10
        Dim index As Integer = 0
        Dim FontStyle As Font = Me.QueryPanel.Style.HeaderStyle.Font
        Dim CurrentColumn As String = ""

        myConnStr = "Data Source=.\SQLEXPRESS;Initial Catalog=" & Me.cmbDatabases.Text & ";Integrated Security=SSPI;"

        myConn = New SqlConnection
        myConn.ConnectionString = myConnStr

        'myCmd = New SqlCommand
        'myCmd.Connection = myConn
        'myCmd.CommandType = CommandType.Text
        'syscolumns tablosundan database isimlerini listbox a aktardýk..
        'myCmd.CommandText = "SELECT syscolumns.name,systypes.name,syscolumns.colorder FROM syscolumns,systypes WHERE syscolumns.id=object_id('" & Me.cmbDatabases.Text & ".." & Me.cmbTables.Text & "') AND syscolumns.xtype=systypes.xtype AND systypes.xtype=systypes.xusertype ORDER BY syscolumns.colorder"

        'Dim myDR As SqlDataReader

        Me.lstColumns.Items.Clear()
        'Panel içindeki nesneler silinir..
        Me.Panel.Controls.Clear()

        Dim TblColumns As New DataTable

        Dim myDA As New SqlDataAdapter("SELECT syscolumns.name,systypes.name,syscolumns.colorder FROM syscolumns,systypes WHERE syscolumns.id=object_id('" & Me.cmbDatabases.Text & ".." & Me.cmbTables.Text & "') AND syscolumns.xtype=systypes.xtype AND systypes.xtype=systypes.xusertype ORDER BY syscolumns.colorder", myConn)

        myDA.Fill(TblColumns)

        Dim Tblsysforeignkeys As New DataTable

        myDA = New SqlDataAdapter("select object_name(rkeyid),fkey from sysforeignkeys where object_name(fkeyid)='" & Me.cmbTables.SelectedItem.ToString & "'", myConn)

        myDA.Fill(Tblsysforeignkeys)

        'myConn.Open()
        'myDR = myCmd.ExecuteReader

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
                        Dim DateTime As New DateTimePicker

                        DateTime.Name = TblColumns.Rows(i).Item(0)
                        DateTime.Size = New System.Drawing.Size(100, 20)
                        DateTime.Location = New System.Drawing.Point(LocX, LocY + 25)
                        DateTime.Format = DateTimePickerFormat.Short
                        DateTime.ShowCheckBox = True
                        DateTime.Value = Now

                        Me.Panel.Controls.Add(DateTime)
                        DateTime.Checked = False
                    Case "bit"
                        'checkbox eklemek..
                        Dim chkbox As New CheckBox

                        chkbox.Name = TblColumns.Rows(i).Item(0)
                        chkbox.Size = New System.Drawing.Size(100, 20)
                        chkbox.Location = New System.Drawing.Point(LocX, LocY + 25)
                        chkbox.FlatStyle = FlatStyle.Popup
                        chkbox.ThreeState = True

                        Me.Panel.Controls.Add(chkbox)
                        chkbox.CheckState = CheckState.Indeterminate
                    Case Else
                        'Textbox eklemek..
                        Dim TextControl As New TextBox

                        TextControl.Name = TblColumns.Rows(i).Item(0)
                        TextControl.Size = New System.Drawing.Size(100, 20)
                        TextControl.Location = New System.Drawing.Point(LocX, LocY + 25)
                        TextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                        TextControl.TextAlign = HorizontalAlignment.Center
                        TextControl.Text = Nothing

                        Me.Panel.Controls.Add(TextControl)
                End Select
            End If

            'X degeri arttýrýlýr..
            LocX += 110
            'Nesne sayýsý arttýrýlýr..
            index += 1

            CurrentColumn = ""
        Next

    End Sub

    Public Sub FillComboBox(ByVal cmd As ComboBox, ByVal TableName As String)
        Dim Columns(1) As String
        Dim i As Integer = 0

        cmd.Items.Clear()
        myConn.Open()
        myConn.ChangeDatabase(Me.cmbDatabases.SelectedItem.ToString)

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
            WhereString = "SELECT * FROM [" & Me.cmbTables.SelectedItem.ToString & "]" & WhereString
        Else
            WhereString = "SELECT * FROM [" & Me.cmbTables.SelectedItem.ToString & "]"
        End If

        Dim myDA As New SqlDataAdapter(WhereString, myConn)
        Dim myDT As New DataTable
        myDA.Fill(myDT)
        Me.dgAraSonuc.DataSource = myDT
    End Sub
End Class
