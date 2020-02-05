Module modFileProcessing
    Public Sub readInputFile(ByVal filePath As String)
        Dim objMyStreamReader As System.IO.StreamReader
        Dim strLineContents As String
        objMyStreamReader = System.IO.File.OpenText(filePath)
        While Not (objMyStreamReader.EndOfStream)
            strLineContents = objMyStreamReader.ReadLine()
            Dim strContents() As String = Split(strLineContents, vbTab)
            modDriver.lstTestList.Add(New udtPotionBottle(strContents(enuConstructor.intID),
                                                strContents(enuConstructor.intVolume),
                                                strContents(enuConstructor.strDate)))
        End While
        modDriver.lstTestList.Sort(Function(aBottle, anotherBottle)
                                       Return aBottle.getIntFilledVolume.CompareTo(anotherBottle.getIntFilledVolume)
                                   End Function)
        objMyStreamReader.Close()
    End Sub

    Public Sub writeReportToFile(ByVal filePath As String)

    End Sub
End Module
