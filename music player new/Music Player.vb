
Public Interface Media_Player
    Function Description() As String
End Interface

Public Class Component
    Implements Media_Player
    Public Function Description() As String Implements Media_Player.Description
        Return "Smart Media Player!! "
    End Function
End Class

Public MustInherit Class Decorator
    Implements Media_Player
    Protected media As Media_Player

    Public Sub New(c As Media_Player)
        media = c
    End Sub
    Public Function Description() As String Implements Media_Player.Description
        Return media.Description
    End Function
End Class
Public Class PlainRadio
    Implements Media_Player
    Public Function Description() As String Implements Media_Player.Description
        Return "Music Player , TV , Radio"
    End Function
End Class
Public Class Music
    Inherits Decorator
    Public Sub New(c As Media_Player)
        MyBase.New(c)
        Dim str As String = "Music Player , "
        Console.Write(str)
    End Sub
    Public Overloads Function Description() As String
        Return media.Description + ", Music"
    End Function
End Class
Public Class TV
    Inherits Decorator
    Public Sub New(c As Media_Player)
        MyBase.New(c)
        Dim str As String = "Television (TV) , "
        Console.Write(str)
    End Sub
    Public Overloads Function Description() As String
        Return media.Description + ", TV"
    End Function
End Class


