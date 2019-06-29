<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PRList
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FormSkin1 = New Win10_Tweak_Tools.FormSkin()
        Me.FlatButton1 = New Win10_Tweak_Tools.FlatButton()
        Me.F2_close = New Win10_Tweak_Tools.FlatButton()
        Me.P1 = New System.Windows.Forms.ListView()
        Me.idx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.instdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Uninstall = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.F2_close)
        Me.FormSkin1.Controls.Add(Me.P1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(650, 400)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Programs Installed List"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Maroon
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(585, 375)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(62, 21)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "제거"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'F2_close
        '
        Me.F2_close.BackColor = System.Drawing.Color.Transparent
        Me.F2_close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.F2_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.F2_close.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2_close.Location = New System.Drawing.Point(628, 0)
        Me.F2_close.Name = "F2_close"
        Me.F2_close.Rounded = False
        Me.F2_close.Size = New System.Drawing.Size(19, 18)
        Me.F2_close.TabIndex = 3
        Me.F2_close.Text = "X"
        Me.F2_close.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'P1
        '
        Me.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idx, Me.pname, Me.instdate, Me.Uninstall})
        Me.P1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1.FullRowSelect = True
        Me.P1.GridLines = True
        Me.P1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.P1.HoverSelection = True
        Me.P1.Location = New System.Drawing.Point(3, 54)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(644, 318)
        Me.P1.TabIndex = 2
        Me.P1.UseCompatibleStateImageBehavior = False
        Me.P1.View = System.Windows.Forms.View.Details
        '
        'idx
        '
        Me.idx.Text = "Idx."
        Me.idx.Width = 48
        '
        'pname
        '
        Me.pname.Text = "Name"
        Me.pname.Width = 483
        '
        'instdate
        '
        Me.instdate.Text = "InstallDate"
        Me.instdate.Width = 96
        '
        'Uninstall
        '
        Me.Uninstall.Text = "Uninstall"
        Me.Uninstall.Width = 0
        '
        'PRList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 400)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PRList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRList"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents idx As ColumnHeader
    Friend WithEvents pname As ColumnHeader
    Friend WithEvents instdate As ColumnHeader
    Friend WithEvents F2_close As FlatButton
    Friend WithEvents Uninstall As ColumnHeader
    Protected Friend WithEvents P1 As ListView
    Friend WithEvents FlatButton1 As FlatButton
End Class
