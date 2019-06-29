<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.infosave_Dialog = New System.Windows.Forms.SaveFileDialog()
        Me.watch1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New Win10_Tweak_Tools.FormSkin()
        Me.FlatButton1 = New Win10_Tweak_Tools.FlatButton()
        Me.FlatLabel7 = New Win10_Tweak_Tools.FlatLabel()
        Me.Save_Log_B = New Win10_Tweak_Tools.FlatButton()
        Me.Usage_win = New Win10_Tweak_Tools.FlatStatusBar()
        Me.FlatClose1 = New Win10_Tweak_Tools.FlatClose()
        Me.FlatTabControl1 = New Win10_Tweak_Tools.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox1 = New Win10_Tweak_Tools.FlatGroupBox()
        Me.reboot = New Win10_Tweak_Tools.FlatLabel()
        Me.biosrun = New Win10_Tweak_Tools.FlatButton()
        Me.infosave = New Win10_Tweak_Tools.FlatButton()
        Me.Local_C = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel6 = New Win10_Tweak_Tools.FlatLabel()
        Me.VGA_Info = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel5 = New Win10_Tweak_Tools.FlatLabel()
        Me.BoardName = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel4 = New Win10_Tweak_Tools.FlatLabel()
        Me.totalram = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel3 = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel2 = New Win10_Tweak_Tools.FlatLabel()
        Me.Usecpu = New Win10_Tweak_Tools.FlatLabel()
        Me.Winver = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel1 = New Win10_Tweak_Tools.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatLabel8 = New Win10_Tweak_Tools.FlatLabel()
        Me.ie_changed = New Win10_Tweak_Tools.FlatButton()
        Me.FlatLabel10 = New Win10_Tweak_Tools.FlatLabel()
        Me.ie_start_pages = New Win10_Tweak_Tools.FlatTextBox()
        Me.ie_now_pages = New Win10_Tweak_Tools.FlatLabel()
        Me.FlatLabel9 = New Win10_Tweak_Tools.FlatLabel()
        Me.Sys_Log = New System.Windows.Forms.TabPage()
        Me.Log_Text = New Win10_Tweak_Tools.FlatListBox()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Sys_Log.SuspendLayout()
        Me.SuspendLayout()
        '
        'watch1
        '
        Me.watch1.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel7)
        Me.FormSkin1.Controls.Add(Me.Save_Log_B)
        Me.FormSkin1.Controls.Add(Me.Usage_win)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(800, 450)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Windows 10 Tweak Tools"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Orange
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(735, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(19, 18)
        Me.FlatButton1.TabIndex = 7
        Me.FlatButton1.Text = "I"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(205, 21)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(83, 13)
        Me.FlatLabel7.TabIndex = 12
        Me.FlatLabel7.Text = "Ver 1.0.0 (rev.2)"
        '
        'Save_Log_B
        '
        Me.Save_Log_B.BackColor = System.Drawing.Color.Transparent
        Me.Save_Log_B.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Save_Log_B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Log_B.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Log_B.Location = New System.Drawing.Point(757, 0)
        Me.Save_Log_B.Name = "Save_Log_B"
        Me.Save_Log_B.Rounded = False
        Me.Save_Log_B.Size = New System.Drawing.Size(19, 18)
        Me.Save_Log_B.TabIndex = 4
        Me.Save_Log_B.Text = "S"
        Me.Save_Log_B.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Usage_win
        '
        Me.Usage_win.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Usage_win.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Usage_win.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Usage_win.ForeColor = System.Drawing.Color.White
        Me.Usage_win.Location = New System.Drawing.Point(0, 427)
        Me.Usage_win.Name = "Usage_win"
        Me.Usage_win.RectColor = System.Drawing.Color.Aqua
        Me.Usage_win.ShowTimeDate = False
        Me.Usage_win.Size = New System.Drawing.Size(800, 23)
        Me.Usage_win.TabIndex = 3
        Me.Usage_win.Text = "Status Bar"
        Me.Usage_win.TextColor = System.Drawing.Color.White
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(779, 0)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 2
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Controls.Add(Me.Sys_Log)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 30)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 41)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(800, 388)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.FlatGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 350)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "시스템 정보"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.reboot)
        Me.FlatGroupBox1.Controls.Add(Me.biosrun)
        Me.FlatGroupBox1.Controls.Add(Me.infosave)
        Me.FlatGroupBox1.Controls.Add(Me.Local_C)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel6)
        Me.FlatGroupBox1.Controls.Add(Me.VGA_Info)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel5)
        Me.FlatGroupBox1.Controls.Add(Me.BoardName)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel4)
        Me.FlatGroupBox1.Controls.Add(Me.totalram)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.Usecpu)
        Me.FlatGroupBox1.Controls.Add(Me.Winver)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(781, 333)
        Me.FlatGroupBox1.TabIndex = 5
        '
        'reboot
        '
        Me.reboot.AutoSize = True
        Me.reboot.BackColor = System.Drawing.Color.Transparent
        Me.reboot.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.reboot.ForeColor = System.Drawing.Color.White
        Me.reboot.Location = New System.Drawing.Point(596, 282)
        Me.reboot.Name = "reboot"
        Me.reboot.Size = New System.Drawing.Size(0, 13)
        Me.reboot.TabIndex = 12
        '
        'biosrun
        '
        Me.biosrun.BackColor = System.Drawing.Color.Transparent
        Me.biosrun.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.biosrun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biosrun.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.biosrun.Location = New System.Drawing.Point(599, 298)
        Me.biosrun.Name = "biosrun"
        Me.biosrun.Rounded = True
        Me.biosrun.Size = New System.Drawing.Size(60, 32)
        Me.biosrun.TabIndex = 1
        Me.biosrun.Text = "바이오스"
        Me.biosrun.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'infosave
        '
        Me.infosave.BackColor = System.Drawing.Color.Transparent
        Me.infosave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.infosave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.infosave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infosave.Location = New System.Drawing.Point(665, 298)
        Me.infosave.Name = "infosave"
        Me.infosave.Rounded = True
        Me.infosave.Size = New System.Drawing.Size(111, 32)
        Me.infosave.TabIndex = 6
        Me.infosave.Text = "시스템 정보 저장"
        Me.infosave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Local_C
        '
        Me.Local_C.AutoSize = True
        Me.Local_C.BackColor = System.Drawing.Color.Transparent
        Me.Local_C.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Local_C.ForeColor = System.Drawing.Color.White
        Me.Local_C.Location = New System.Drawing.Point(67, 97)
        Me.Local_C.Name = "Local_C"
        Me.Local_C.Size = New System.Drawing.Size(34, 17)
        Me.Local_C.TabIndex = 11
        Me.Local_C.Text = "Free"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(6, 97)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(64, 17)
        Me.FlatLabel6.TabIndex = 4
        Me.FlatLabel6.Text = "Sys Disk :"
        '
        'VGA_Info
        '
        Me.VGA_Info.AutoSize = True
        Me.VGA_Info.BackColor = System.Drawing.Color.Transparent
        Me.VGA_Info.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VGA_Info.ForeColor = System.Drawing.Color.White
        Me.VGA_Info.Location = New System.Drawing.Point(67, 80)
        Me.VGA_Info.Name = "VGA_Info"
        Me.VGA_Info.Size = New System.Drawing.Size(34, 17)
        Me.VGA_Info.TabIndex = 6
        Me.VGA_Info.Text = "VGA"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(29, 79)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(41, 17)
        Me.FlatLabel5.TabIndex = 10
        Me.FlatLabel5.Text = "VGA :"
        '
        'BoardName
        '
        Me.BoardName.AutoSize = True
        Me.BoardName.BackColor = System.Drawing.Color.Transparent
        Me.BoardName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoardName.ForeColor = System.Drawing.Color.White
        Me.BoardName.Location = New System.Drawing.Point(66, 62)
        Me.BoardName.Name = "BoardName"
        Me.BoardName.Size = New System.Drawing.Size(44, 17)
        Me.BoardName.TabIndex = 9
        Me.BoardName.Text = "Board"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(19, 62)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(51, 17)
        Me.FlatLabel4.TabIndex = 8
        Me.FlatLabel4.Text = "Board :"
        '
        'totalram
        '
        Me.totalram.AutoSize = True
        Me.totalram.BackColor = System.Drawing.Color.Transparent
        Me.totalram.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalram.ForeColor = System.Drawing.Color.White
        Me.totalram.Location = New System.Drawing.Point(66, 45)
        Me.totalram.Name = "totalram"
        Me.totalram.Size = New System.Drawing.Size(37, 17)
        Me.totalram.TabIndex = 3
        Me.totalram.Text = "RAM"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(26, 45)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(44, 17)
        Me.FlatLabel3.TabIndex = 7
        Me.FlatLabel3.Text = "RAM :"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(30, 27)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(40, 17)
        Me.FlatLabel2.TabIndex = 6
        Me.FlatLabel2.Text = "CPU :"
        '
        'Usecpu
        '
        Me.Usecpu.AutoSize = True
        Me.Usecpu.BackColor = System.Drawing.Color.Transparent
        Me.Usecpu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usecpu.ForeColor = System.Drawing.Color.White
        Me.Usecpu.Location = New System.Drawing.Point(66, 27)
        Me.Usecpu.Name = "Usecpu"
        Me.Usecpu.Size = New System.Drawing.Size(33, 17)
        Me.Usecpu.TabIndex = 5
        Me.Usecpu.Text = "CPU"
        '
        'Winver
        '
        Me.Winver.AutoSize = True
        Me.Winver.BackColor = System.Drawing.Color.Transparent
        Me.Winver.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winver.ForeColor = System.Drawing.Color.White
        Me.Winver.Location = New System.Drawing.Point(66, 8)
        Me.Winver.Name = "Winver"
        Me.Winver.Size = New System.Drawing.Size(64, 17)
        Me.Winver.TabIndex = 4
        Me.Winver.Text = "Windows"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(38, 8)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(32, 17)
        Me.FlatLabel1.TabIndex = 3
        Me.FlatLabel1.Text = "OS :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "사용자 폴더"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 350)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "기타"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlatLabel8)
        Me.GroupBox1.Controls.Add(Me.ie_changed)
        Me.GroupBox1.Controls.Add(Me.FlatLabel10)
        Me.GroupBox1.Controls.Add(Me.ie_start_pages)
        Me.GroupBox1.Controls.Add(Me.ie_now_pages)
        Me.GroupBox1.Controls.Add(Me.FlatLabel9)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 92)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IE 설정"
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(6, 22)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(105, 13)
        Me.FlatLabel8.TabIndex = 0
        Me.FlatLabel8.Text = "IE 시작 페이지 설정:"
        '
        'ie_changed
        '
        Me.ie_changed.BackColor = System.Drawing.Color.Transparent
        Me.ie_changed.BaseColor = System.Drawing.Color.SandyBrown
        Me.ie_changed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ie_changed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ie_changed.Location = New System.Drawing.Point(263, 61)
        Me.ie_changed.Name = "ie_changed"
        Me.ie_changed.Rounded = False
        Me.ie_changed.Size = New System.Drawing.Size(50, 20)
        Me.ie_changed.TabIndex = 2
        Me.ie_changed.Text = "변경"
        Me.ie_changed.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(43, 68)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(209, 13)
        Me.FlatLabel10.TabIndex = 5
        Me.FlatLabel10.Text = "해당 기능은 시스템 재시작이 필요합니다."
        '
        'ie_start_pages
        '
        Me.ie_start_pages.BackColor = System.Drawing.Color.Transparent
        Me.ie_start_pages.Location = New System.Drawing.Point(113, 13)
        Me.ie_start_pages.MaxLength = 32767
        Me.ie_start_pages.Multiline = False
        Me.ie_start_pages.Name = "ie_start_pages"
        Me.ie_start_pages.ReadOnly = False
        Me.ie_start_pages.Size = New System.Drawing.Size(200, 29)
        Me.ie_start_pages.TabIndex = 1
        Me.ie_start_pages.Text = "https://www.naver.com"
        Me.ie_start_pages.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ie_start_pages.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ie_start_pages.UseSystemPasswordChar = False
        '
        'ie_now_pages
        '
        Me.ie_now_pages.AutoSize = True
        Me.ie_now_pages.BackColor = System.Drawing.Color.Transparent
        Me.ie_now_pages.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ie_now_pages.ForeColor = System.Drawing.Color.White
        Me.ie_now_pages.Location = New System.Drawing.Point(114, 45)
        Me.ie_now_pages.Name = "ie_now_pages"
        Me.ie_now_pages.Size = New System.Drawing.Size(13, 13)
        Me.ie_now_pages.TabIndex = 4
        Me.ie_now_pages.Text = "1"
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(43, 45)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(68, 13)
        Me.FlatLabel9.TabIndex = 3
        Me.FlatLabel9.Text = "현재 페이지:"
        '
        'Sys_Log
        '
        Me.Sys_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Sys_Log.Controls.Add(Me.Log_Text)
        Me.Sys_Log.Location = New System.Drawing.Point(4, 34)
        Me.Sys_Log.Name = "Sys_Log"
        Me.Sys_Log.Padding = New System.Windows.Forms.Padding(3)
        Me.Sys_Log.Size = New System.Drawing.Size(792, 350)
        Me.Sys_Log.TabIndex = 3
        Me.Sys_Log.Text = "로그"
        '
        'Log_Text
        '
        Me.Log_Text.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Log_Text.items = New String() {""}
        Me.Log_Text.Location = New System.Drawing.Point(0, 0)
        Me.Log_Text.Name = "Log_Text"
        Me.Log_Text.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Log_Text.Size = New System.Drawing.Size(792, 350)
        Me.Log_Text.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows 10 Tweak Tools"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Sys_Log.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatTabControl1 As FlatTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents Winver As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents Usecpu As FlatLabel
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents totalram As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents BoardName As FlatLabel
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents VGA_Info As FlatLabel
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents Usage_win As FlatStatusBar
    Friend WithEvents Local_C As FlatLabel
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents infosave As FlatButton
    Friend WithEvents infosave_Dialog As SaveFileDialog
    Friend WithEvents Save_Log_B As FlatButton
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents biosrun As FlatButton
    Friend WithEvents reboot As FlatLabel
    Friend WithEvents watch1 As Timer
    Friend WithEvents Sys_Log As TabPage
    Friend WithEvents Log_Text As FlatListBox
    Friend WithEvents ie_changed As FlatButton
    Friend WithEvents ie_start_pages As FlatTextBox
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents ie_now_pages As FlatLabel
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents FlatLabel10 As FlatLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatButton1 As FlatButton
End Class
