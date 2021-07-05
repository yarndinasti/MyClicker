Module KeyPress
  Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
  Const KeyDownBit As Integer = &H8000

  Public Function KeyPressIs(keys As Integer()) As Boolean
    If keys.Length = 1 Then
      Return (GetAsyncKeyState(keys(0)) And KeyDownBit) = KeyDownBit
    End If


    Return (GetAsyncKeyState(keys(0)) And KeyDownBit) = KeyDownBit AndAlso
        (GetAsyncKeyState(keys(1)) And KeyDownBit) = KeyDownBit

    'Return (GetAsyncKeyState(key1) And KeyDownBit) = KeyDownBit AndAlso
    '    ((GetAsyncKeyState(key2) And KeyDownBit) = KeyDownBit AndAlso
    '    (GetAsyncKeyState(key3) And KeyDownBit) = KeyDownBit)
  End Function
End Module
