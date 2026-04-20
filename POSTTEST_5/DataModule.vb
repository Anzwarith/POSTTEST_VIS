Imports MySqlConnector

Module DataModule

    Public Function GetAllBooking() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
        "SELECT booking.id_booking, booking.nama_pelanggan, booking.nomor_hp, 
        lapangan.nama_lapangan, booking.tanggal_booking, booking.durasi, booking.total_harga 
        FROM booking 
        INNER JOIN lapangan ON booking.id_lapangan = lapangan.id_lapangan 
        ORDER BY booking.id_booking DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchBooking(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_booking, nama_pelanggan, nomor_hp, lapangan, tanggal_booking, durasi, total_harga FROM booking WHERE id_booking = @id OR nama_pelanggan LIKE @nama ORDER BY id_booking DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", keyword)
                    da.SelectCommand.Parameters.AddWithValue("@nama", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetAllLapangan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM lapangan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil lapangan: " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function SimpanBooking(nama As String, hp As String, idLapangan As Integer, tanggal As String, durasi As String, total As String) As Boolean
        Try
            Dim query As String = "INSERT INTO booking (nama_pelanggan, nomor_hp, id_lapangan, tanggal_booking, durasi, total_harga) VALUES (@nama, @hp, @lapangan, @tanggal, @durasi, @total)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@lapangan", idLapangan)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahBooking(id As String, nama As String, hp As String, idLapangan As Integer, tanggal As String, durasi As String, total As String) As Boolean
        Try
            Dim query As String = "UPDATE booking SET nama_pelanggan=@nama, nomor_hp=@hp, id_lapangan=@lapangan, tanggal_booking=@tanggal, durasi=@durasi, total_harga=@total WHERE id_booking=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@lapangan", idLapangan)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@total", total)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusBooking(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM booking WHERE id_booking = @id_booking"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_booking", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module