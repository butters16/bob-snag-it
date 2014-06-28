Imports System.Runtime.InteropServices

Public Class SnagIt

    'TODO(User): Adjust for your environment.
    Private Shared ReadOnly BaseDirectory As String = "C:\Users\Administrator\Downloads\QC"
    Private Shared ReadOnly FirefoxClassName As String = "MozillaWindowClass" 'Found using Spy++.
    Private Shared ReadOnly IEClassName As String = "IEFrame" 'Found using Spy++.
    Private Shared ReadOnly DirectoryCreationWaitMs As Integer = 1000
    Private Shared ReadOnly BringWindowToTopWaitMs As Integer = 1000
    Private Shared ReadOnly MenuPopupWaitMs As Integer = 1000
    Private Shared ReadOnly DialogPopupWaitMs As Integer = 1000

    Private filename As String = ""

    Private Sub SnagItButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnagItButton.Click
        Setup()
        Save()
    End Sub

    Private Sub Setup()
        BuildFilename()
        EnsureDirectoryExistsForFilename()
    End Sub

    Private Sub BuildFilename()
        Dim siteId = Me.SiteIdNumericUpDown.Value.ToString
        Dim label = Me.LabelComboBox.Text
        Dim directory = My.Computer.FileSystem.CombinePath(BaseDirectory, siteId)
        filename = My.Computer.FileSystem.CombinePath(directory, siteId & "_" & label)
    End Sub

    Private Sub EnsureDirectoryExistsForFilename()
        Dim directory = My.Computer.FileSystem.GetParentPath(filename)
        If Not My.Computer.FileSystem.DirectoryExists(directory) Then
            My.Computer.FileSystem.CreateDirectory(directory)
            Threading.Thread.Sleep(DirectoryCreationWaitMs)
        End If
    End Sub

    Private Sub Save()
        BringWindowToTop(FirefoxClassName)
        FirefoxAbductionSaveImage()

        BringWindowToTop(Me.Handle) 'TODO(John Keith): Removing this causes IE window to not come to focus.

        BringWindowToTop(IEClassName)
        IEPageSave(fileTypeUpFromBottom:=2) 'Web Archive, single file (*.mht)
        IEPageSave(fileTypeUpFromBottom:=3) 'Webpage, complete (*.htm;*.html)
    End Sub

    Private Sub BringWindowToTop(ByVal windowClassName As String)
        Dim handle = FindWindow(windowClassName, vbNullString)
        BringWindowToTop(handle)
        Threading.Thread.Sleep(BringWindowToTopWaitMs)
    End Sub

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function FindWindow( _
         ByVal lpClassName As String, _
         ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function BringWindowToTop(ByVal hwnd As IntPtr) As Boolean
    End Function

    Private Sub FirefoxAbductionSaveImage()
        SendKeys.Send("%(f)") 'Request "File" menu.
        Threading.Thread.Sleep(MenuPopupWaitMs) 'Allow "File" menu to pop up.
        SendKeys.Send("s") 'Select "Save Page As Image...".
        Threading.Thread.Sleep(MenuPopupWaitMs) 'Allow Abduction! buttons to pop up.
        SendKeys.Send("%(s)") 'Press Abduction! "Save..." button.
        Threading.Thread.Sleep(DialogPopupWaitMs) 'Allow save dialog to pop up.
        SendKeys.Send("{ESC}") 'Abort save dialog, leaving "Save..." button with focus.
        Threading.Thread.Sleep(DialogPopupWaitMs) 'Allow save dialog to close.
        SendKeys.Send("{LEFT 2}") 'Focus on Abduction! "Select all" (no working shortcut, but it is 2 left of "Save..." button).
        SendKeys.Send("{ENTER}") 'Press Abduction! "Select all" button.
        SendKeys.Send("%(s)") 'Press Abduction! "Save..." button.
        Threading.Thread.Sleep(DialogPopupWaitMs) 'Allow save dialog to pop up.
        SendKeys.Send("%(n)") 'Focus on file name.
        SendKeys.Send(filename) 'Enter file name.
        SendKeys.Send("%(s)") 'Press "Save" button.
        Threading.Thread.Sleep(DialogPopupWaitMs) 'Allow save dialog to close.
    End Sub

    Private Sub IEPageSave(ByVal fileTypeUpFromBottom As Integer)
        SendKeys.Send("%(p)") 'Request "Page" menu.
        Threading.Thread.Sleep(MenuPopupWaitMs) 'Allow "Page" menu to pop up.
        SendKeys.Send("a") 'Select "Save As...".
        Threading.Thread.Sleep(DialogPopupWaitMs) 'Allow save dialog to pop up.
        SendKeys.Send("%(n)") 'Focus on "File name".
        SendKeys.Send(filename) 'Enter file name.
        SendKeys.Send("%(t)") 'Focus on "Save as type".
        SendKeys.Send("{DOWN 5}") 'Select the last type.
        SendKeys.Send("{UP " & fileTypeUpFromBottom & "}") 'Select desired type using relative position to last type.
        SendKeys.Send("{TAB}") 'Tab off save as type.
        SendKeys.Send("%(s)") 'Press "Save" button.
        Threading.Thread.Sleep(DialogPopupWaitMs) 'Allow save dialog to close.
    End Sub

End Class
