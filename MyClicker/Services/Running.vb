Module Running
  Public Function AlreadyRunning() As Boolean
    ' Get our process name.
    Dim my_proc As Process = Process.GetCurrentProcess
    Dim my_name As String = my_proc.ProcessName

    ' Get information about processes with this name.
    Dim procs() As Process =
        Process.GetProcessesByName(my_name)

    ' If there is only one, it's us.
    If procs.Length = 1 Then Return False

    ' If there is more than one process,
    ' see if one has a StartTime before ours.
    Dim i As Integer
    For i = 0 To procs.Length - 1
      If procs(i).StartTime < my_proc.StartTime Then _
            Return True
    Next i

    ' If we get here, we were first.
    Return False
  End Function
End Module
