Imports MySql.Data.MySqlClient
Imports System.IO
Public Class TransaksiForm
    Dim myDB As MySqlConnection
    Dim WithEvents FpVer As FlexCodeSDK.FinFPVer
    Dim WithEvents FpVerAmbil As FlexCodeSDK.FinFPVer
    Dim user_id As String
    Dim FpIndex As Byte
    Private strSql As String = String.Empty

    Private Sub TransaksiForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sServer As String = "101.50.3.175"
        'Dim sPort As Integer = 3306
        'Dim sUid As String = "berkahgl_absensi"
        'Dim sPasswd As String = "OLabsBERKAH#007"
        'Dim sDBase As String = "berkahgl_absensi"

        'If Not myDB Is Nothing Then myDB.Close()
        'Dim CnStr As String
        'CnStr = String.Format("server={0}; Port={1}; user id={2}; password={3}; database={4}; pooling=false", sServer, sPort.ToString, sUid, sPasswd, sDBase)

        'myDB = New MySqlConnection(CnStr)

        'Cursor.Hide()

        BtnVerifikasi.Enabled = False


        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=absensi_am"
        myDB.Open()
        If myDB.State = ConnectionState.Open Then
        Else
            MsgBox("Silahkan melakukan registrasi sidik jari dulu!")
        End If
    End Sub

    Private Sub ScanFingerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanFingerBtn.Click
        'ScanFingerBtn.Enabled = False

        FpVer = New FlexCodeSDK.FinFPVer
        FpVer.AddDeviceInfo("C800V001599", "8E9-362-D9A-3AB-CC6", "X5TD-85CE-2033-2088-AE38-27TX")

        Dim sqlCommand As New MySqlCommand
        sqlCommand.Connection = myDB
        sqlCommand.CommandText = "SELECT * FROM finger"
        Dim rd As MySqlDataReader
        rd = sqlCommand.ExecuteReader
        While rd.Read
            FpVer.FPLoad(rd.GetString(0), rd.GetString(1), rd.GetString(2), "YourSecretKey" & rd.GetString(0))
        End While
        FpVer.FPVerificationStart()
        rd.Close()

        FpVer.PictureSamplePath = My.Application.Info.DirectoryPath & "\FPTemp.BMP"
        FpVer.PictureSampleHeight = 2050
        FpVer.PictureSampleWidth = 1600
    End Sub

    Private Sub FpVer_FPVerificationID(ByVal ID As String, ByVal FingerNr As FlexCodeSDK.FingerNumber) Handles FpVer.FPVerificationID
        user_id = ID
        FpIndex = FingerNr
    End Sub

    Private Sub FpVer_FPVerificationStatus(ByVal Status As FlexCodeSDK.VerificationStatus) Handles FpVer.FPVerificationStatus
        If Status = FlexCodeSDK.VerificationStatus.v_OK Then
            BtnVerifikasi.Enabled = True

            Dim sqlCommand2 As New MySqlCommand
            sqlCommand2.Connection = myDB

            sqlCommand2.CommandText = "SELECT user_name FROM user WHERE user_id = '" & user_id & "'"
            Dim rd2 As MySqlDataReader
            rd2 = sqlCommand2.ExecuteReader
            rd2.Read()

            LblNama.Text = rd2.GetString(0)
            LblNIS.Text = user_id

            'TextBox1.Text = TextBox1.Text & vbNewLine & "ID: " & user_id & ", Name : " & rd2.GetString(0) & ", Finger Index : " & Str(FpIndex)

            rd2.Close()

            Dim sqlCommand3 As New MySqlCommand
            sqlCommand3.Connection = myDB
            sqlCommand3.CommandText = "SELECT nominal_simpanan FROM simpanan WHERE nis = '" & user_id & "'"
            Dim rd3 As MySqlDataReader
            rd3 = sqlCommand3.ExecuteReader
            rd3.Read()

            LblJumlahSimpanan.Text = rd3.GetString(0)

            user_id = ""
            rd3.Close()

            strSql = "SELECT photo FROM user WHERE user_id = @1"

            Using cmd As New MySqlCommand(strSql, myDB)
                With cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@1", LblNIS.Text) ' EmpID

                    Using dtr As MySqlDataReader = .ExecuteReader()
                        If dtr.HasRows Then
                            If dtr.Read() Then
                                Dim ms As New IO.MemoryStream(CType(dtr.Item("photo"), Byte()))
                                Photo.Image = Image.FromStream(ms) ' tampilkan gambarnya
                            End If
                        End If
                    End Using
                End With
            End Using


        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Then
            MsgBox("Data tidak ditemukan!", MsgBoxStyle.Critical, "Pengambilan data siswa gagal")
            LblNama.Text = ""
            LblNIS.Text = ""
            LblJumlahSimpanan.Text = ""
            Photo.Image = Nothing
            PictureBox1.Image = Nothing
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
            'TextBox1.Text = TextBox1.Text & vbNewLine & "Finger touch"
        Else
            'TextBox1.Text = TextBox1.Text & vbNewLine & "Result Status : " & Str(Status)
        End If
    End Sub

    Private Sub BtnVerifikasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerifikasi.Click
        FpVer.FPVerificationStop()
        Dim simpanan As Integer = Convert.ToInt32(LblJumlahSimpanan.Text)
        Dim pengambilan As Integer = Convert.ToInt32(BoxPengambilan.Text)
        If (pengambilan > simpanan) Then
            MsgBox("Nominal simpanan tidak mecukupi!", MsgBoxStyle.Critical, "Pengambilan gagal")
        Else
            FpVerAmbil = New FlexCodeSDK.FinFPVer
            FpVerAmbil.AddDeviceInfo("C800V001599", "8E9-362-D9A-3AB-CC6", "X5TD-85CE-2033-2088-AE38-27TX")

            Dim sqlCommand As New MySqlCommand
            sqlCommand.Connection = myDB
            sqlCommand.CommandText = "SELECT * FROM finger"
            Dim rd As MySqlDataReader
            rd = sqlCommand.ExecuteReader
            While rd.Read
                FpVerAmbil.FPLoad(rd.GetString(0), rd.GetString(1), rd.GetString(2), "YourSecretKey" & rd.GetString(0))
            End While
            FpVerAmbil.FPVerificationStart()
            rd.Close()

            FpVer.PictureSamplePath = My.Application.Info.DirectoryPath & "\FPTemp.BMP"
            FpVer.PictureSampleHeight = 2050
            FpVer.PictureSampleWidth = 1600
        End If
    End Sub
    Private Sub FpVerAmbil_FPVerificationID(ByVal ID As String, ByVal FingerNr As FlexCodeSDK.FingerNumber) Handles FpVerAmbil.FPVerificationID
        user_id = ID
        FpIndex = FingerNr
    End Sub

    Private Sub FpVerAmbil_FPVerificationStatus(ByVal Status As FlexCodeSDK.VerificationStatus) Handles FpVerAmbil.FPVerificationStatus
        If Status = FlexCodeSDK.VerificationStatus.v_OK And LblNIS.Text = user_id Then
            MsgBox("Pengambilan simpanan berhasil", MsgBoxStyle.Critical, "Terverivikasi")
            BtnVerifikasi.Enabled = False
            ScanFingerBtn.Enabled = True

            Dim simpanan As Integer = Convert.ToInt32(LblJumlahSimpanan.Text)
            Dim pengambilan As Integer = Convert.ToInt32(BoxPengambilan.Text)

            Dim nominal_simp As Integer
            nominal_simp = simpanan - pengambilan


            Dim sqlCommand2 As New MySqlCommand
            sqlCommand2.Connection = myDB

            sqlCommand2.CommandText = "INSERT INTO log_tarik(log_tarik_id, user_id, date, time, nominal_tarik) VALUES('','" & user_id & "', '" & Format(Now, "yyyy-MM-dd") & "', '" & Format(Now, "HH:mm:ss") & "','" & pengambilan & "')"
            sqlCommand2.ExecuteNonQuery()

            'sqlCommand2.CommandText = "INSERT INTO log_tmp(log_tmp_id, user_id, date, time) VALUES('','" & user_id & "', '" & Format(Now, "yyyy-MM-dd") & "', '" & Format(Now, "HH:mm:ss") & "')"
            'sqlCommand2.ExecuteNonQuery()

            sqlCommand2.CommandText = "UPDATE simpanan SET nominal_simpanan='" & nominal_simp & "' WHERE nis ='" & user_id & "'"
            sqlCommand2.ExecuteNonQuery()


            LblNama.Text = ""
            LblNIS.Text = ""
            LblJumlahSimpanan.Text = ""
            Photo.Image = Nothing
            PictureBox1.Image = Nothing

            FpVerAmbil.FPVerificationStop()
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Then
            MsgBox("Data tidak ditemukan!", MsgBoxStyle.Critical, "Pengambilan data siswa gagal")
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
            'TextBox1.Text = TextBox1.Text & vbNewLine & "Finger touch"
        Else
            'TextBox1.Text = TextBox1.Text & vbNewLine & "Result Status : " & Str(Status)
        End If
    End Sub

    Private Sub FpVer_FPVerificationImage() Handles FpVer.FPVerificationImage
        Dim imgFile As System.IO.FileStream = New System.IO.FileStream(My.Application.Info.DirectoryPath & "\FPTemp.BMP", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite)
        Dim fileBytes(imgFile.Length) As Byte
        imgFile.Read(fileBytes, 0, fileBytes.Length)
        imgFile.Close()
        Dim ms As System.IO.MemoryStream = New MemoryStream(fileBytes)
        PictureBox1.Image = Image.FromStream(ms)
    End Sub

    Private Sub FpVerAmbil_FPVerificationImage() Handles FpVerAmbil.FPVerificationImage
        Dim imgFile As System.IO.FileStream = New System.IO.FileStream(My.Application.Info.DirectoryPath & "\FPTemp.BMP", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite)
        Dim fileBytes(imgFile.Length) As Byte
        imgFile.Read(fileBytes, 0, fileBytes.Length)
        imgFile.Close()
        Dim ms As System.IO.MemoryStream = New MemoryStream(fileBytes)
        PictureBox1.Image = Image.FromStream(ms)
    End Sub

    Private Sub TextBoxScan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxScan.TextChanged

        If (TextBoxScan.TextLength = 12) Then

            Dim sqlCommand4 As New MySqlCommand
            sqlCommand4.Connection = myDB

            sqlCommand4.CommandText = "SELECT user_name FROM user WHERE user_id = '" & TextBoxScan.Text & "'"
            Dim rd4 As MySqlDataReader
            rd4 = sqlCommand4.ExecuteReader
            rd4.Read()

            LblNama.Text = rd4.GetString(0)
            LblNIS.Text = TextBoxScan.Text

            rd4.Close()

            Dim sqlCommand5 As New MySqlCommand
            sqlCommand5.Connection = myDB
            sqlCommand5.CommandText = "SELECT nominal_simpanan FROM simpanan WHERE nis = '" & TextBoxScan.Text & "'"
            Dim rd5 As MySqlDataReader
            rd5 = sqlCommand5.ExecuteReader
            rd5.Read()

            LblJumlahSimpanan.Text = rd5.GetString(0)

            user_id = ""
            rd5.Close()

            strSql = "SELECT photo FROM user WHERE user_id = @1"

            Using cmd As New MySqlCommand(strSql, myDB)
                With cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@1", LblNIS.Text) ' EmpID

                    Using dtr As MySqlDataReader = .ExecuteReader()
                        If dtr.HasRows Then
                            If dtr.Read() Then
                                Dim ms As New IO.MemoryStream(CType(dtr.Item("photo"), Byte()))
                                Photo.Image = Image.FromStream(ms) ' tampilkan gambarnya
                            End If
                        End If
                    End Using
                End With
            End Using
        End If
    End Sub

    Private Sub TextBoxVerifBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxVerifBarcode.TextChanged

        If (TextBoxVerifBarcode.TextLength = 12 And TextBoxVerifBarcode.Text = TextBoxScan.Text) Then

            Dim simpanan As Integer = Convert.ToInt32(LblJumlahSimpanan.Text)
            Dim pengambilan As Integer = Convert.ToInt32(BoxPengambilan.Text)
            If (pengambilan > simpanan) Then
                MsgBox("Nominal simpanan tidak mecukupi!", MsgBoxStyle.Critical, "Pengambilan gagal")
            ElseIf (LblNIS.Text = TextBoxVerifBarcode.Text) And (pengambilan <= simpanan) Then
                MsgBox("berhasil!", MsgBoxStyle.Critical, "Pengambilan berhasil")

                Dim simpanan2 As Integer = Convert.ToInt32(LblJumlahSimpanan.Text)
                Dim pengambilan2 As Integer = Convert.ToInt32(BoxPengambilan.Text)

                Dim nominal_simp As Integer
                nominal_simp = simpanan2 - pengambilan2

                Dim sqlCommand2 As New MySqlCommand
                sqlCommand2.Connection = myDB

                sqlCommand2.CommandText = "INSERT INTO log_tarik(log_tarik_id, user_id, date, time, nominal_tarik) VALUES('','" & TextBoxVerifBarcode.Text & "', '" & Format(Now, "yyyy-MM-dd") & "', '" & Format(Now, "HH:mm:ss") & "','" & pengambilan & "')"
                sqlCommand2.ExecuteNonQuery()

                'sqlCommand2.CommandText = "INSERT INTO log_tmp(log_tmp_id, user_id, date, time) VALUES('','" & user_id & "', '" & Format(Now, "yyyy-MM-dd") & "', '" & Format(Now, "HH:mm:ss") & "')"
                'sqlCommand2.ExecuteNonQuery()

                sqlCommand2.CommandText = "UPDATE simpanan SET nominal_simpanan='" & nominal_simp & "' WHERE nis ='" & TextBoxVerifBarcode.Text & "'"
                sqlCommand2.ExecuteNonQuery()

                LblNama.Text = ""
                LblNIS.Text = ""
                LblJumlahSimpanan.Text = ""
                Photo.Image = Nothing
                PictureBox1.Image = Nothing
                TextBoxVerifBarcode.Text = ""
                TextBoxScan.Text = ""
                BoxPengambilan.Text = ""

                MsgBox("Pengambilan simpanan berhasil", MsgBoxStyle.Critical, "Terverivikasi")
            End If
        End If
    End Sub


End Class
