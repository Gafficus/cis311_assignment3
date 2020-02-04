﻿Module modDriver
    Dim lstTestList As New List(Of udtPotionBottle)
    Enum enuConstructor
        intID
        intVolume
        strDate
    End Enum
    Sub Main()
        Dim testMax As Integer = Integer.MinValue
        Dim testMin As Integer = Integer.MaxValue
        configureConsole()
        Console.WriteLine("Please Enter the path and the name " +
                           "of the file containing the measurements:")
        Console.ReadLine()
        Console.WriteLine("Please enter the path and the name " +
                          "of the report to generate:")
        Console.ReadLine()
        readInputFile()
        For Each item As udtPotionBottle In lstTestList
            Console.WriteLine(item)
        Next
        For Each e As udtPotionBottle In lstTestList
            testMax = Math.Max(testMax, e.getIntFilledVolume())
            testMin = Math.Min(testMin, e.getIntFilledVolume())
        Next
        Console.WriteLine("Max: " & testMax & " Min: " & testMin)
        Console.ReadLine()
    End Sub
    Private Sub readInputFile()
        Dim objMyStreamReader As System.IO.StreamReader
        Dim strLineContents As String
        objMyStreamReader = System.IO.File.OpenText("Readings.txt")
        While Not (objMyStreamReader.EndOfStream)
            strLineContents = objMyStreamReader.ReadLine()
            Dim strContents() As String = Split(strLineContents, vbTab)
            lstTestList.Add(New udtPotionBottle(strContents(enuConstructor.intID),
                                                strContents(enuConstructor.intVolume),
                                                strContents(enuConstructor.strDate)))
        End While
        lstTestList.Sort(Function(aBottle, anotherBottle)
                             Return aBottle.getIntFilledVolume.CompareTo(anotherBottle.getIntFilledVolume)
                         End Function)
        objMyStreamReader.Close()
    End Sub
    Private Sub configureConsole()
        Const INTWINDOWWIDTH = 80
        Const INTWINDOWHEIGHT = 30
        Const STRWINDOWTITLE = "Snape Potion Manufacturing Quality Program"
        Dim testObj As Console
        With testObj
            .ForegroundColor = ConsoleColor.White
            .BackgroundColor = ConsoleColor.Blue
            .WindowWidth = INTWINDOWWIDTH
            .WindowHeight = INTWINDOWHEIGHT
            .Title = STRWINDOWTITLE
        End With
        'Console.ForegroundColor = ConsoleColor.White
        'Console.BackgroundColor = ConsoleColor.Blue
        'Console.WindowWidth = 80
        'Console.WindowHeight = 30
        'Console.Title = "Snape Potion Manufacturing Quality Program"
        Console.Clear()
    End Sub
End Module
