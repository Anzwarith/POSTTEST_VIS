Public Module ModPerpus
    Public dataBuku(99, 1) As String
    Public jumlah As Integer

    Public Sub TambahBuku(ByVal judul As String,
                          ByVal genre As String,
                          ByRef total As Integer)
        If total < dataBuku.GetLength(0) Then
            dataBuku(total, 0) = judul
            dataBuku(total, 1) = genre
            total += 1
        End If
    End Sub

    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlah - 1
            If dataBuku(i, 0).ToLower.Contains(judul.ToLower) Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module