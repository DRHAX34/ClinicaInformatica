﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.34014
'
'     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
'     o código for regenerado.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    'OBSERVAÇÃO: o arquivo é gerado automaticamente. Não o modifique diretamente. Para fazer alterações,
    ' ou se você encontrar erros de compilação neste arquivo, vá para o Designer de Projeto
    ' (vá para Propriedades do Projeto ou clique duas vezes no nó Meu Projeto em
    ' Gerenciador de Soluções) e faça as alterações na guia Aplicativo.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.ClinicaInformatica.Workspace
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateSplashScreen()
            Me.SplashScreen = Global.ClinicaInformatica.SplashAway
        End Sub
    End Class
End Namespace
