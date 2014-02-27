Imports System.Data.SqlClient

Public Class Form2
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnButon As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.btnButon = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(8, 8)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(224, 248)
        Me.TreeView1.TabIndex = 0
        '
        'btnButon
        '
        Me.btnButon.Location = New System.Drawing.Point(248, 8)
        Me.btnButon.Name = "btnButon"
        Me.btnButon.TabIndex = 1
        Me.btnButon.Text = "Button1"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 266)
        Me.Controls.Add(Me.btnButon)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myconn As SqlConnection = New SqlConnection("server=.\SQLEXPRESS;Database=master;Integrated Security=SSPI;")

        Dim myCmd As SqlCommand = New SqlCommand("select name from master.dbo.sysdatabases", myconn)

        Dim myDR As SqlDataReader

        myconn.Open()
        myDR = myCmd.ExecuteReader

        Do While myDR.Read
            Me.TreeView1.Nodes.Add(myDR.Item(0))
        Loop

        myDR.Close()

        myCmd = New SqlCommand("SELECT count(name) from master.dbo.sysdatabases", myconn)

        myDR = myCmd.ExecuteReader

        Dim ParentNode As Integer

        Do While myDR.Read
            ParentNode = myDR.Item(0)
        Loop

        myDR.Close()

        For i As Integer = 0 To ParentNode - 1
            myCmd = New SqlCommand("select name from " & Me.TreeView1.Nodes.Item(i).Text & ".dbo.sysobjects where xtype='U' and name<>'dtProperties'", myconn)

            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                If Not myDR.Item(0) = Nothing Then
                    Me.TreeView1.Nodes.Item(i).Nodes.Add(myDR.Item(0))
                End If
            Loop

            myDR.Close()
        Next

        myconn.Close()
    End Sub

    Private Sub btnButon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButon.Click

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Dim Path As String

        Path = Me.TreeView1.SelectedNode.FullPath.ToString

        Dim Ana, Cocuk As String

        If Not Me.TreeView1.SelectedNode.Index = -1 AndAlso Me.TreeView1.SelectedNode.Text <> Me.TreeView1.TopNode.Text Then
            Ana = Me.TreeView1.SelectedNode.Parent.Text
            Cocuk = Me.TreeView1.SelectedNode.Text
        Else
            Exit Sub
        End If

            MsgBox(Ana & vbCrLf & Cocuk)


        'If Not Me.TreeView1.SelectedNode.Index = -1 Then
        '    MsgBox(Me.TreeView1.TopNode.Text)
        '    If Not Me.TreeView1.SelectedNode.Text = Me.TreeView1.TopNode.Text Then
        '        MsgBox(Me.TreeView1.SelectedNode.Text)
        '    End If
        'End If

        'If Me.TreeView1.SelectedNode.GetNodeCount Then
        '    MsgBox("Ana Node")
        'Else
        '    MsgBox("Child Node")
        'End If
    End Sub
End Class
