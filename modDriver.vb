Module modDriver
    Public lstTestList As New List(Of udtPotionBottle)
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
        modFileProcessing.readInputFile("Readings.txt")
        Console.WriteLine("Please enter the path and the name " +
                          "of the report to generate:")
        Console.ReadLine()
        modFileProcessing.writeReportToFile("output.txt")
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
    Private Sub configureConsole()

        Dim testObj As Console
        With testObj
            .ForegroundColor = ConsoleColor.White
            .BackgroundColor = ConsoleColor.Blue
            .WindowWidth = modConstants.getWidth()
            .WindowHeight = modConstants.getHeight
            .Title = modConstants.getTitle()
        End With
        Console.Clear()
    End Sub
End Module
