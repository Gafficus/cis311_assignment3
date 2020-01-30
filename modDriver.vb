Module modDriver

    Sub Main()
        configureConsole()
        Console.WriteLine("Please Enter the path and the name " +
                           "of the file containing the measurements:")
        Console.ReadLine()
        Console.WriteLine("Please enter the path and the name " +
                          "of the report to generate:")
        Console.ReadLine()
    End Sub

    Private Sub configureConsole()
        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WindowWidth = 80
        Console.WindowHeight = 30
        Console.Title = "Snape Potion Manufacturing Quality Program"
    End Sub
End Module
