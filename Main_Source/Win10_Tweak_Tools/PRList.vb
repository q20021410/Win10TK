
Public Class PRList
    Private Sub PRlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnt = 0
        Dim uninstallNode As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
        Dim uninstallNode64 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall")


        If System.Environment.Is64BitOperatingSystem = True Then
            For Each subKeyName As String In uninstallNode64.GetSubKeyNames
                Dim subKey64 As Microsoft.Win32.RegistryKey = uninstallNode64.OpenSubKey(subKeyName)
                Dim displayName As String = subKey64.GetValue("DisplayName")
                Dim instdate As String = subKey64.GetValue("InstallDate")
                Dim uninst As String = subKey64.GetValue("UninstallString")
                Dim ListViewItem64 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {cnt, displayName + " (x64)", instdate, uninst})

                If displayName Is Nothing Then
                Else
                    P1.Items.Add(ListViewItem64)
                    cnt += 1
                End If
            Next
        Else
            For Each subKeyName As String In uninstallNode.GetSubKeyNames

                Dim subKey As Microsoft.Win32.RegistryKey = uninstallNode.OpenSubKey(subKeyName)


                Dim displayName As String = subKey.GetValue("DisplayName")
                Dim instdate As String = subKey.GetValue("InstallDate")
                Dim uninst As String = subKey.GetValue("UninstallString")

                Dim ListViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {cnt, displayName, instdate, uninst})

                If displayName Is Nothing Then
                Else
                    P1.Items.Add(ListViewItem)
                    cnt += 1
                End If
            Next
        End If





        'Dim moReturn As Management.ManagementObjectCollection
        'Dim moSearch As Management.ManagementObjectSearcher
        'Dim mo As Management.ManagementObject

        'moSearch = New Management.ManagementObjectSearcher("Select * from Win32_Product")

        'moReturn = moSearch.Get
        'Dim cnt = 0
        'For Each mo In moReturn
        '    Dim ListViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {cnt, mo("Name"), mo("InstallDate")})
        '    P1.Items.Add(ListViewItem)
        '    cnt += 1
        'Next
        'P1.BeginUpdate() 'This will ensure there is no odd visible changes to the control, use this

        'whenever you make changes To list controls, especially when filling out alot of data!

        'For m As Integer = 0 To P1.Columns.Count - 1 'For each column
        '    Dim a As Integer = 0
        '    Dim b As Integer = 0
        '    P1.Columns(m).Width = -1
        '    a = P1.Columns(m).Width
        '    P1.Columns(m).Width = -2
        '    b = P1.Columns(m).Width
        '    If a > b Then
        '        P1.Columns(m).Width = -1
        '    Else
        '        P1.Columns(m).Width = -2
        '    End If
        'Next m
        'P1.EndUpdate()
        'Info.Size = New Size(0, 0)
        'Info.Visible = False

    End Sub

    Private Sub lstvicon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles P1.DoubleClick
        'Label1.Text = P1.SelectedItems(0).SubItems(3).Text
        Select Case MessageBox.Show("정말로 " + P1.SelectedItems(0).SubItems(1).Text + "를 지우시겠습니까?", P1.SelectedItems(0).SubItems(1).Text + "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case vbYes
                If P1.SelectedItems(0).SubItems(3).Text Is Nothing Then
                    Shell(P1.SelectedItems(0).SubItems(3).Text)
                    Me.Controls.Clear() 'removes all the controls on the form
                    InitializeComponent() 'load all the controls again
                    PRlist_Load(e, e)
                    'MsgBox("Thank you for sending report", vbInformation, "")
                    Refresh()
                End If

            Case vbNo
                ' Other Code goes here
        End Select
    End Sub


    Private Sub F2_close_Click(sender As Object, e As EventArgs) Handles F2_close.Click
        Me.Close()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Select Case MessageBox.Show("정말로 " + P1.SelectedItems(0).SubItems(1).Text + "를 지우시겠습니까?", P1.SelectedItems(0).SubItems(1).Text + "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case vbYes
                Shell(P1.SelectedItems(0).SubItems(3).Text)
                Me.Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                PRlist_Load(e, e)
                'MsgBox("Thank you for sending report", vbInformation, "")
                Refresh()

            Case vbNo
                ' Other Code goes here
        End Select

    End Sub
End Class