Public Class udtPotionBottle
    Private intID As Integer
    Private intFilledVolume As Integer
    Private strDateAsString As String
    Enum intDesired
        Volume = 1000
    End Enum
    Public Function getIntID()
        Return intID
    End Function
    Public Sub setIntID(ByVal value As Integer)
        intID = value
    End Sub
    Public Function getIntFilledVolume()
        Return intFilledVolume
    End Function
    Public Sub setIntFilledVolume(ByVal value As Integer)
        intFilledVolume = value
    End Sub
    Public Function getStrDateAsString()
        Return strDateAsString
    End Function
    Public Sub setStrDateAsString(ByVal value As String)
        strDateAsString = value
    End Sub

    Public Function displayString() As String
        Return intID & vbTab & intFilledVolume & vbTab & strDateAsString
    End Function
    Public Overrides Function ToString() As String
        Return createHistogram()
    End Function
    Private Function createHistogram() As String
        Dim strHistogram As String = "Feature Not yet implemented"

        Dim strCharToRepresentHistogram As String = "*"
        If (intDesired.Volume = intFilledVolume) Then
            strCharToRepresentHistogram = "="
        End If

        'Logic for the histogram
        Return "(" & intID & ")" & vbTab & intFilledVolume &
                vbTab & strHistogram
    End Function
    Public Sub New(intID As Integer,
                   intFilledVolume As Integer,
                   strDateAsString As String)
        If strDateAsString Is Nothing Then
            Throw New ArgumentNullException(NameOf(strDateAsString))
        End If

        Me.intID = intID
        Me.intFilledVolume = intFilledVolume
        Me.strDateAsString = strDateAsString
    End Sub
End Class
