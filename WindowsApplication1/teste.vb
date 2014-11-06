'Imports System
'Imports System.Drawing
'Imports System.ComponentModel
'Imports System.ComponentModel.Design
'Imports System.Windows.Forms
'Imports System.Runtime.InteropServices

'Public Class MdiClientWithoutScrollBars
'    Inherits NativeWindow
'    Implements IComponent
'    Implements IDisposable

'    Private FParentForm As Form
'    Private FMdiClient As MdiClient
'    Private FSite As ISite

'    Private Const WFNCCALCSIZE As Integer = 131
'    Private Const SB_BOTH As Integer = 3

'    <DllImport("user32.dll")> _
'    Private Shared Function ShowScrollBar(ByVal hWnd As IntPtr, ByVal wBar As Integer, ByVal bShow As Integer) As Integer
'    End Function

'    Public Sub New(ByVal TheParentForm As Form)
'        FSite = Nothing
'        FParentForm = TheParentForm
'        FMdiClient = Nothing
'        If Not FParentForm.IsMdiContainer Then FParentForm.IsMdiContainer = True
'        For a As Integer = 0 To FParentForm.Controls.Count - 1
'            FMdiClient = TryCast(FParentForm.Controls(a), MdiClient)
'            If FMdiClient IsNot Nothing Then
'                ReleaseHandle()
'                AssignHandle(FMdiClient.Handle)
'                Exit For
'            End If
'        Next
'    End Sub

'    Public Event Disposed As EventHandler Implements IComponent.Disposed

'    Public Property Site() As ISite Implements IComponent.Site
'        Get
'            Return FSite
'        End Get
'        Set(ByVal value As ISite)
'            FSite = value
'            If FSite Is Nothing Then
'                Return
'            End If
'        End Set
'    End Property

'    Public Sub Dispose() Implements IComponent.Dispose
'        Dispose(True)
'        GC.SuppressFinalize(Me)
'    End Sub

'    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            SyncLock Me
'                If FSite IsNot Nothing AndAlso FSite.Container IsNot Nothing Then
'                    FSite.Container.Remove(Me)
'                End If
'                RaiseEvent Disposed(Me, EventArgs.Empty)
'            End SyncLock
'        End If
'    End Sub

'    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
'        If m.Msg = WFNCCALCSIZE Then
'            ShowScrollBar(m.HWnd, SB_BOTH, 0)
'        End If
'        MyBase.WndProc(m)
'    End Sub

'End Class
