Module Module1
    Dim ndate = "[" + Now.ToString("yy-MM-dd hh:mm") + "] "
    Function GetOSInfo()
        Dim nowbit = ""

        If System.Environment.Is64BitOperatingSystem = True Then
            nowbit = "x64"
        Else
            nowbit = "x86"
        End If
        'gwmi -query "Select * from Win32_DiskPartition WHERE Index = 2" | Select-Object DiskIndex, @{Name="GPT";Expression={$_.Type.StartsWith("GPT")}}
        Dim bios As New System.Management.ManagementObjectSearcher("Select * from Win32_DiskPartition Where Index =1")
        Dim bios_mode As String = ""
        For Each st As Management.ManagementObject In bios.Get()
            bios_mode = CStr(st("Type"))
            'Form1.Log_Text.AddItem(bios_mode)
            If (Strings.Left(bios_mode, 3) = "GPT") Then
                bios_mode = "UEFI"
            Else
                bios_mode = "CSM/Legecy"
            End If

        Next

        Dim o As New System.Management.ManagementObjectSearcher("select * from Win32_OperatingSystem")
        Dim winv As String
        Dim rs As String = ""

        'Dim winver() As String = {" RS5", " RS4", " RS3", " RS2", " RS1", ""}
        For Each st As Management.ManagementObject In o.Get()
            winv = CStr(st("BuildNumber"))

            If (winv = 18362) Then
                rs = " 19H1"
            ElseIf (winv = 18898) Then
                rs = " 19H2_Test"
            ElseIf (winv = 17763) Then
                rs = " RS5"
            ElseIf (winv = 17134) Then
                rs = " RS4"
            ElseIf (winv = 16299) Then
                rs = " RS3"
            ElseIf (winv = 15063) Then
                rs = " RS2"
            ElseIf (winv = 14393) Then
                rs = " RS1"
            ElseIf (winv = 10586) Then
                rs = " "
            ElseIf (winv = 10240) Then
                rs = " "
            Else
                MessageBox.Show("Windows 10이 아닙니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
                Form1.Close()
            End If

            Dim win = " " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", Nothing) & rs &
                        "(OS Build " & winv & "." &
                        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "UBR", Nothing) & ", " & bios_mode & ")"

            Return My.Computer.Info.OSFullName & " " & nowbit & win
        Next

    End Function

    Function GetBIOS()
        Dim bios As New System.Management.ManagementObjectSearcher("Select * from Win32_DiskPartition Where Index=1")
        Dim bios_mode1 As String = ""
        For Each st As Management.ManagementObject In bios.Get()
            bios_mode1 = CStr(st("Type"))

            If (Strings.Left(bios_mode1, 1) = "GPT") Then
                bios_mode1 = "UEFI"
            Else
                bios_mode1 = "CSM/Legecy"
            End If

        Next
        Return bios_mode1
    End Function


    Function GetCPUInfo()
        Dim s As New System.Management.ManagementObjectSearcher("select * from Win32_Processor")
        Dim name, core, thread, vt
        For Each st As Management.ManagementObject In s.Get()
            name = CStr(st("Name"))
            core = CStr(st("NumberOfCores"))
            thread = CStr(st("NumberOfLogicalProcessors"))
            vt = CStr(st("VirtualizationFirmwareEnabled"))
        Next

        If (vt = True) Then
            vt = "VT-X 활성화"
        ElseIf (vt = False) Then
            vt = "VT-X 비활성화"
        Else
            vt = "Unknown"
        End If

        Return name + "(" + core + "C " + thread + "T / " + vt + ")"
    End Function

    Function GetMemInfo()
        Dim Physical = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 ^ 3, 1)
        Dim Virtual = Math.Round(My.Computer.Info.AvailableVirtualMemory / 1024 ^ 3, 1)
        Return (Physical & "GB (Virtual: " & Virtual & "GB)")
    End Function

    Function GetBoardInfo()
        Return (
        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardManufacturer", Nothing) & " " &
        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", Nothing) & " (" &
        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVersion", Nothing) & ", " &
        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSReleaseDate", Nothing) & ")")
    End Function

    Function GetSysDiskInfo()
        Dim Use = Math.Round((My.Computer.FileSystem.Drives.Item(0).TotalSize - My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace) / 1024 ^ 3, 1)
        Dim Total = Math.Round(My.Computer.FileSystem.Drives.Item(0).TotalSize / 1024 ^ 3, 1).ToString
        Dim Free = Math.Round(My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace / 1024 ^ 3, 1).ToString
        Dim nowper = Math.Round(Use / Total * 100, 1)
        Dim Avalible = 100 - nowper
        Return (Use & "GB / " & Total & "GB (Free: " & Free & "GB | " & Avalible & "%)")
    End Function

    Function GetVGAInfo()
        Dim s As New System.Management.ManagementObjectSearcher("select * from Win32_VideoController")
        For Each st As Management.ManagementObject In s.Get()
            Return CStr(st("Name")) & " (" & CStr(st("CurrentHorizontalResolution")) & "x" & CStr(st("CurrentVerticalResolution")) & "x" & CStr(st("CurrentRefreshRate")) & "hz, " & Math.Round(CStr(st("AdapterRAM")) / 1024 ^ 3, 1) & "GB, " & CStr(st("DriverVersion")) & ")"
        Next
    End Function

    Function SaveInfo()
        Dim aa = "사용중인 윈도우 버전: " + GetOSInfo() + vbCrLf + "사용중인 CPU: " + GetCPUInfo() + vbCrLf + "전체 메모리 : " + GetMemInfo() +
            vbCrLf + "사용중인 메인보드: " + GetBoardInfo() + vbCrLf + "그래픽 카드: " + GetVGAInfo() + vbCrLf + "시스템 파티션 : " + GetSysDiskInfo()
        Form1.infosave_Dialog.Filter = "TXT Files (*.txt*)|*.txt"
        Form1.infosave_Dialog.FileName = "[" + Now.ToString("yy-MM-dd") + "] Systeminfo"
        If Form1.infosave_Dialog.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            My.Computer.FileSystem.WriteAllText(Form1.infosave_Dialog.FileName, aa, True)
            Form1.Log_Text.AddItem(ndate + "[Complete] 시스템 정보를 저장 했습니다.")
        End If
    End Function

    Function GetSecureBootState() As String
        Dim sCommand As String = "C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe"
        Dim sArgs As String = "Confirm-SecureBootUEFI"
        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(sCommand, sArgs)
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = True
        Dim proc As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        Return proc.StandardOutput.ReadToEnd
    End Function

End Module
