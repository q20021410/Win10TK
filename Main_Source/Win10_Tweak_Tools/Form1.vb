Imports System.Reflection
Imports System.Security

Public Class Form1
    Dim logcount = 0
    Dim rcheck = 0
    Dim rett As Double = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlatLabel7.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString()
        Log_Text.AddItem("[" + DateTime.Now.ToString("yy-MM-dd hh:mm:ss") + "] " + "[Info] 프로그램 최초 실행")
        Winver.Text = Module1.GetOSInfo()
        Usage_win.Text = "OS: " + Module1.GetOSInfo()
        Usecpu.Text = Module1.GetCPUInfo()
        totalram.Text = Module1.GetMemInfo()
        BoardName.Text = Module1.GetBoardInfo()
        VGA_Info.Text = Module1.GetVGAInfo()
        Local_C.Text = Module1.GetSysDiskInfo()

        Log_Text.AddItem("[" + DateTime.Now.ToString("yy-MM-dd hh:mm:ss") + "] " + "[Info] 시스템 정보 로딩 완료")
        'Log_Text.AddItem("- CPU Info: " + Usecpu.Text)
        'Log_Text.AddItem("- Installed RAM: " + totalram.Text)
        'Log_Text.AddItem("- MotherBaord: " + BoardName.Text)
        'Log_Text.AddItem("- Detected VGA: " + VGA_Info.Text)
        'Log_Text.AddItem("- System Disk Info: " + Local_C.Text)
        'Log_Text.AddItem("- Windows: " + Winver.Text)

        'Log_Text.AddItem(Module1.GetSecureBootState())

        'logcount = logcount + 7

        Dim readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", "Start Page", Nothing)
        ie_now_pages.Text = readValue
    End Sub

    Private Sub infosave_Click(sender As Object, e As EventArgs) Handles infosave.Click
        Module1.SaveInfo()
    End Sub

    Private Sub Save_Log_B_Click(sender As Object, e As EventArgs) Handles Save_Log_B.Click
        Dim i As Integer
        infosave_Dialog.Filter = "TXT Files (*.txt*)|*.txt"
        infosave_Dialog.FileName = "[" + Now.ToString("yy-MM-dd") + "] Log"

        Dim a = Log_Text.items.Count()

        If infosave_Dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As New IO.StreamWriter(infosave_Dialog.FileName, True)
            For i = 0 To Log_Text.items().Count - 1
                Log_Text.Text = Log_Text.items(i)
                MessageBox.Show(Log_Text.items(i))
            Next

            s.Close()
        End If

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles biosrun.Click
        If rcheck = 1 Then
            Log_Text.AddItem("[" + DateTime.Now.ToString("yy-MM-dd hh:mm:ss") + "] " + "BIOS 재시작 취소")
            watch1.Stop()
            Shell("Shutdown -a")
            MessageBox.Show("재시작을 취소하셨습니다.", "재시작 취소", MessageBoxButtons.OK, MessageBoxIcon.Information)
            rcheck = 0
            reboot.Text = ""
            biosrun.Text = "바이오스"
            rett = 10
        Else
            If Module1.GetBIOS() = "UEFI" Then
                Log_Text.AddItem("[" + DateTime.Now.ToString("yy-MM-dd hh:mm:ss") + "] " + "BIOS 재시작 실행")
                watch1.Start()
                Shell("Shutdown -r -fw -t 10")
                MessageBox.Show("10초 뒤 BIOS 모드로 시스템을 재시작 합니다.", "시스템 재시작", MessageBoxButtons.OK, MessageBoxIcon.Information)
                biosrun.Text = "취소"
                rcheck = 1
            Else
                MessageBox.Show("UEFI 모드가 아닌경우 사용할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If


    End Sub

    Private Sub watch1_Tick(sender As Object, e As EventArgs) Handles watch1.Tick

        rett = rett - 1
        Dim tem = rett
        reboot.Text = "시스템 재시작까지 " + CStr(tem) + "초 남았습니다."

        If tem = 0 Then
            reboot.Text = ""
            rett = 10
            watch1.Stop()
        End If


    End Sub

    Private Sub ie_changed_Click_1(sender As Object, e As EventArgs) Handles ie_changed.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", "Start Page", ie_start_pages.Text)
        Dim readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", "Start Page", Nothing)
        ie_now_pages.Text = readValue
        Log_Text.AddItem("[" + DateTime.Now.ToString("yy-MM-dd hh:mm:ss") + "] 시작 페이지 변경: " + ie_start_pages.Text)
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        PRList.Show()
    End Sub
End Class
