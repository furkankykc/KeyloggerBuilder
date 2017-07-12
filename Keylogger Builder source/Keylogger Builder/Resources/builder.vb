
Imports System.CodeDom.Compiler

Public Class builder

    Public Shared Sub gen(ByVal Output As String, ByVal Source As String)

        On Error Resume Next

        Dim Compiler As ICodeCompiler = (New VBCodeProvider).CreateCompiler()
        Dim Parameters As New CompilerParameters()
        Dim cResults As CompilerResults

        Parameters.GenerateExecutable = True
        Parameters.OutputAssembly = Output
        Parameters.ReferencedAssemblies.Add("System.dll")
        Parameters.ReferencedAssemblies.Add("System.Data.dll")
        Parameters.ReferencedAssemblies.Add("System.Drawing.dll")
        Parameters.ReferencedAssemblies.Add("System.Design.dll")
        Parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")

        Dim Version = New Dictionary(Of String, String)
        Version.Add("Windows", "v1.0")

        Parameters.EmbeddedResources.Add(Application.StartupPath & "\xyz.resources")

        Parameters.CompilerOptions = "/target:winexe"

        cResults = Compiler.CompileAssemblyFromSource(Parameters, Source)

        If cResults.Errors.Count > 0 Then
            For Each CompilerError In cResults.Errors
                MessageBox.Show("Error: " & CompilerError.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Next
        ElseIf cResults.Errors.Count = 0 Then

        End If

    End Sub

End Class

