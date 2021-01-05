Imports System.IO
Imports System.IO.File
Imports System.Text.Encoding
Imports System.Text.UnicodeEncoding

Public Class Form1
    Dim decimali1slave As New List(Of Integer)
    Dim decimali2slave As New List(Of Integer)
    Dim decimali3slave As New List(Of Integer)
    '_______________________________________     
    Dim decimali1master As New List(Of Integer)
    Dim decimali2master As New List(Of Integer)
    Dim decimali3master As New List(Of Integer)
    Dim playstatus As Boolean = True
    '_______________________________________    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MasterBin.Click
        masterfolder.Filter = "Binary | *.bin"
        masterfolder.Title = "Open Master File"
        'masterfolder.ShowHelp = True
        masterfolder.FileName = ""
        If masterfolder.ShowDialog = DialogResult.OK Then
            Dim fs As New FileStream(masterfolder.FileName, FileMode.Open)
            Dim binaryreader As New BinaryReader(fs)
            fs.Position = 0
            Dim bytes() As Byte = binaryreader.ReadBytes(fs.Length)
            Dim integers As String = BitConverter.ToString(bytes, 0)
            Dim replace As String = integers.Replace("-", "")
            Dim caratteri As Char() = replace
            '_______________________________________
            Dim interi As New List(Of String)
            Dim seconda As New List(Of String)
            Dim terza As New List(Of String)
            '_______________________________________

            For i As Integer = 0 To 95
                If i <= 31 Then
                    interi.Add(caratteri(i) + caratteri(i + 1))
                End If
                If (i > 31) And (i < 64) Then
                    seconda.Add(caratteri(i) + caratteri(i + 1))
                ElseIf i > 63 Then
                    terza.Add(caratteri(i) + caratteri(i + 1))
                End If
                i += 1
            Next i

            TextBox2.Text = "--> " + String.Join("", interi) + " <--" + vbCrLf _
                + "--> " + String.Join("", seconda) + " <--" + vbCrLf _
                + "--> " + String.Join("", terza) + " <--"
            binaryreader.Close()
            fs.Dispose()
            MasterSW.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SlaveBin.Click

        masterfolder.Filter = "Binary | *.bin"
        masterfolder.Title = "Open Slave File"
        'masterfolder.ShowHelp = True
        masterfolder.FileName = ""

        If masterfolder.ShowDialog = DialogResult.OK Then
            Dim fs As New FileStream(masterfolder.FileName, FileMode.Open)
            Dim binaryreader As New BinaryReader(fs)
            fs.Position = 0
            Dim bytes() As Byte = binaryreader.ReadBytes(fs.Length)
            Dim integers As String = BitConverter.ToString(bytes, 0)
            Dim replace As String = integers.Replace("-", "")
            Dim caratteri As Char() = replace
            TextBox3.Text = replace
            '_______________________________________
            Dim interi As New List(Of String)
            Dim seconda As New List(Of String)
            Dim terza As New List(Of String)
            '_______________________________________

            For i As Integer = 0 To 95
                If i <= 31 Then
                    interi.Add(caratteri(i) + caratteri(i + 1))
                End If
                If (i > 31) And (i < 64) Then
                    seconda.Add(caratteri(i) + caratteri(i + 1))
                ElseIf i > 63 Then
                    terza.Add(caratteri(i) + caratteri(i + 1))
                End If
                i += 1
            Next i

            TextBox3.Text = "--> " + String.Join("", interi) + " <--" + vbCrLf _
                + "--> " + String.Join("", seconda) + " <--" + vbCrLf _
                + "--> " + String.Join("", terza) + " <--"
            binaryreader.Close()
            fs.Dispose()
            SlaveSW.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MasterSW.Click
        Dim checksum, checksum2, checksum3, i, sum, sum2, sum3 As Integer
        Dim line(2000), formattazione, temp, temp2, temp3, intestazione, intestazione2, intestazione3, checksumhex, checksumhex2, checksumhex3 As String
        Dim stringtemp, stringtemp2, stringtemp3 As New List(Of String)

        masterfolder.Filter = "Hex | *.Hex"
        masterfolder.Title = "Open Hex File"
        masterfolder.FileName = ""
        'masterfolder.ShowHelp = True


        'leggo dal file .hex
        If masterfolder.ShowDialog = DialogResult.OK Then
            Dim reader = File.OpenText(masterfolder.FileName)
            Dim righe As Integer = File.ReadAllLines(masterfolder.FileName).Length - 1
            For i = 0 To righe
                line(i) = reader.ReadLine()
            Next i

            'ricavo il path di dove salvare i file
            Dim directory As String
            directory = Path.GetDirectoryName(masterfolder.FileName)
            'MsgBox(directory)

            intestazione = line(1001).Substring(1, 8)
            intestazione2 = line(1002).Substring(1, 8)
            intestazione3 = line(1003).Substring(1, 8)

            decimali1master.Clear()
            decimali2master.Clear()
            decimali3master.Clear()

            temp = intestazione + TextBox2.Text.ToString.Substring(4, 32)
            temp2 = intestazione2 + TextBox2.Text.ToString.Substring(46, 32)
            temp3 = intestazione3 + TextBox2.Text.ToString.Substring(88, 32)

            'calcolo checksum
            For i = 0 To 39
                stringtemp.Add(temp(i) + temp(i + 1))
                stringtemp2.Add(temp2(i) + temp2(i + 1))
                stringtemp3.Add(temp3(i) + temp3(i + 1))
                i += 1
            Next i

            For j As Integer = 0 To 19
                decimali1master.Add(Integer.Parse(stringtemp(j), Globalization.NumberStyles.HexNumber))
                decimali2master.Add(Integer.Parse(stringtemp2(j), Globalization.NumberStyles.HexNumber))
                decimali3master.Add(Integer.Parse(stringtemp3(j), Globalization.NumberStyles.HexNumber))
                sum = decimali1master(j) + sum
                sum2 = decimali2master(j) + sum2
                sum3 = decimali3master(j) + sum3
            Next j

            checksum = -(sum Mod 256)
            checksum = checksum + 256
            checksumhex = Hex(checksum)

            checksum2 = -(sum2 Mod 256)
            checksum2 = checksum2 + 256
            checksumhex2 = Hex(checksum2)

            checksum3 = -(sum3 Mod 256)
            checksum3 = checksum3 + 256
            checksumhex3 = Hex(checksum3)

            formattazione = "File Originale" + vbCrLf + "--------------------------------------------------------------------------------------" + vbCrLf + line(1001) + vbCrLf + line(1002) _
                     + vbCrLf + line(1003) + vbCrLf + "--------------------------------------------------------------------------------------" + vbCrLf + "File Aggiornato" + vbCrLf _
                     + "--------------------------------------------------------------------------------------" + vbCrLf + ":" + temp + checksumhex + vbCrLf + ":" + temp2 + checksumhex2 + vbCrLf _
                     + ":" + temp3 + checksumhex3 + vbCrLf + "--------------------------------------------------------------------------------------"
            TextBox5.Text = formattazione

            'creo il nuovo file .hex
            Dim writer As System.IO.StreamWriter
            writer = My.Computer.FileSystem.OpenTextFileWriter(directory + "\Master SW " + DateString + ".hex", False, ASCII)
            line(1001) = ":" + temp + checksumhex
            line(1002) = ":" + temp2 + checksumhex2
            line(1003) = ":" + temp3 + checksumhex3
            For i = 0 To righe
                writer.WriteLine(line(i))
            Next i

            'chiudo i due file
            writer.Close()
            reader.Close()
            'reader = File.OpenText(directory + "\Master SW " + DateString + ".hex")
            'righe = File.ReadAllLines(masterfolder.FileName).Length - 1
            'line(0) = reader.ReadLine()
            'MsgBox(line(0))

            MsgBox("Quest'uomo ha creato un file con successo in " + directory, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        MasterSW.Enabled = False
        SlaveSW.Enabled = False
        Try
            My.Computer.Audio.Play("\\Itvnr01fs3\alit_dept\ALIT_ENG_G\SCAMBI\Boasso\ost.wav")
            playstatus = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SlaveSW.Click

        Dim sum, sum2, sum3, checksum, checksum2, checksum3 As Integer
        Dim formattazione, intestazione, intestazione2, intestazione3, temp, temp2, temp3, checksumhex, checksumhex2, checksumhex3 As String
        Dim stringtemp, stringtemp2, stringtemp3 As New List(Of String)
        Dim i As Integer

        masterfolder.Filter = "Hex | *.Hex"
        masterfolder.Title = "Open Hex File"
        masterfolder.FileName = ""
        'masterfolder.ShowHelp = True


        If masterfolder.ShowDialog = DialogResult.OK Then
            Dim reader = File.OpenText(masterfolder.FileName)
            Dim line(2000) As String
            Dim righe As Integer = File.ReadAllLines(masterfolder.FileName).Length - 1
            For i = 0 To righe
                line(i) = reader.ReadLine()
            Next i

            'ricavo il path di dove salvare i file
            Dim directory As String
            directory = Path.GetDirectoryName(masterfolder.FileName)
            'MsgBox(directory)

            intestazione = line(1001).Substring(1, 8)
            intestazione2 = line(1002).Substring(1, 8)
            intestazione3 = line(1003).Substring(1, 8)

            decimali1master.Clear()
            decimali2master.Clear()
            decimali3master.Clear()

            temp = intestazione + TextBox3.Text.ToString.Substring(4, 32)
            temp2 = intestazione2 + TextBox3.Text.ToString.Substring(46, 32)
            temp3 = intestazione3 + TextBox3.Text.ToString.Substring(88, 32)

            'calcolo checksum
            For i = 0 To 39
                stringtemp.Add(temp(i) + temp(i + 1))
                stringtemp2.Add(temp2(i) + temp2(i + 1))
                stringtemp3.Add(temp3(i) + temp3(i + 1))
                i += 1
            Next i

            For j As Integer = 0 To 19
                decimali1slave.Add(Integer.Parse(stringtemp(j), Globalization.NumberStyles.HexNumber))
                decimali2slave.Add(Integer.Parse(stringtemp2(j), Globalization.NumberStyles.HexNumber))
                decimali3slave.Add(Integer.Parse(stringtemp3(j), Globalization.NumberStyles.HexNumber))
                sum = decimali1slave(j) + sum
                sum2 = decimali2slave(j) + sum2
                sum3 = decimali3slave(j) + sum3
            Next j

            checksum = -(sum Mod 256)
            checksum = checksum + 256
            checksumhex = Hex(checksum)

            checksum2 = -(sum2 Mod 256)
            checksum2 = checksum2 + 256
            checksumhex2 = Hex(checksum2)

            checksum3 = -(sum3 Mod 256)
            checksum3 = checksum3 + 256
            checksumhex3 = Hex(checksum3)

            formattazione = "File Originale" + vbCrLf + "--------------------------------------------------------------------------------------" + vbCrLf + line(1001) + vbCrLf + line(1002) _
                     + vbCrLf + line(1003) + vbCrLf + "--------------------------------------------------------------------------------------" + vbCrLf + "File Aggiornato" + vbCrLf _
                     + "--------------------------------------------------------------------------------------" + vbCrLf + ":" + temp + checksumhex + vbCrLf + ":" + temp2 + checksumhex2 + vbCrLf _
                     + ":" + temp3 + checksumhex3 + vbCrLf + "--------------------------------------------------------------------------------------"
            TextBox6.Text = formattazione

            'creo il nuovo file .hex
            Dim writer As System.IO.StreamWriter
            writer = My.Computer.FileSystem.OpenTextFileWriter(directory + "\Slave SW " + DateString + ".hex", False, ASCII)
            line(1001) = ":" + temp + checksumhex
            line(1002) = ":" + temp2 + checksumhex2
            line(1003) = ":" + temp3 + checksumhex3
            For i = 0 To righe
                writer.WriteLine(line(i))
            Next i

            'chiudo i due file
            writer.Close()
            reader.Close()
            MsgBox("Quest'uomo ha creato un file con successo in " + directory, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If playstatus = False Then
            Try
                My.Computer.Audio.Play("\\Itvnr01fs3\alit_dept\ALIT_ENG_G\SCAMBI\Boasso\ost.wav")
                playstatus = True
            Catch ex As Exception

            End Try
        Else
            Try
                My.Computer.Audio.Stop()
                playstatus = False
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class