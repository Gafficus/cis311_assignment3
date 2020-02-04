Public Class udtPotionBottle
    Private intID As Integer
    Private intFilledVolume As Integer
    Private strDateAsString As String
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
        Return intID & vbTab & intFilledVolume & vbTab & strDateAsString
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
