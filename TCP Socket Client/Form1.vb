Imports System.Net, System.Net.Sockets

Public Class Form1
    Inherits System.Windows.Forms.Form



    Dim byteData(1023) As Byte

    Dim clientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Dim ipAddress As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim ipEndPoint As IPEndPoint = New IPEndPoint(ipAddress, 8800)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub OnConnect(ByVal ar As IAsyncResult)

        Try
            clientSocket.EndConnect(ar)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)

        Catch ex As Exception


        End Try
       
    End Sub
    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            Dim client As Socket = ar.AsyncState
            client.EndReceive(ar)
            Dim bytesRec As Byte() = byteData
            Dim message As String = System.Text.ASCIIEncoding.ASCII.GetString(bytesRec)
            Read(message)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
            Array.Clear(byteData, 0, byteData.Length)

        Catch ex As Exception
            MsgBox("Ops, something went wrong. Please try again later")
            End

        End Try
        
    End Sub
    Delegate Sub _Read(ByVal msg As String)
    Public socketinfo As String

    Private Sub Read(ByVal msg As String)
        If InvokeRequired Then
            Invoke(New _Read(AddressOf Read), msg)
            Exit Sub
        End If

        If msg.StartsWith("socketinformation") Then

            Dim MessageArray() As String
            MessageArray = msg.Split("|")
            socketinfo = MessageArray(1)

        ElseIf msg.StartsWith("usernameapproved") Then
            UsernameLabel.Text = UsernameTextbox.Text & " is available!"
            UsernameLabel.ForeColor = Color.Green
            SubmitButton.Enabled = True
            ReplyTextField.Enabled = True
            TakeUsername.Enabled = False
            UsernameTextbox.Enabled = False

            Update.Enabled = True


        ElseIf msg.StartsWith("usernamenotapproved") Then
        UsernameLabel.Text = UsernameTextbox.Text & " is not available"
        UsernameLabel.ForeColor = Color.Red


        ElseIf msg.StartsWith("usernameupdate") Then
        'Do nothing
        ElseIf msg.StartsWith("heartbeat") Then
        'Do nothing
        ElseIf msg.StartsWith("usersonline") Then


        Dim MessageArray() As String
        MessageArray = msg.Split("|")
        Dim username As String = MessageArray(1)
            ListViewOnline.Items.Add(username)

        Else

        RichTextBox1.Text = "" & msg


        '  RichTextBox1.Text &= msg

        End If


    End Sub

   
    Private Sub Send(ByVal msg As String, ByVal client As Socket)
        Try
            Dim sendBytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(msg)

            client.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), client)
        Catch ex As Exception

        End Try


    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        Dim client As Socket = ar.AsyncState
        client.EndSend(ar)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub TakeUsername_Click(sender As Object, e As EventArgs) Handles TakeUsername.Click
        Try
            clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)
            Send("username|" & UsernameTextbox.Text & "|" & socketinfo, clientSocket)

        Catch ex As Exception

            Application.Restart()

        End Try


    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If ReplyTextField.Text = "" Then

        Else
            Send(UsernameTextbox.Text & "# " & ReplyTextField.Text, clientSocket)
            ReplyTextField.Text = ""

        End If


    End Sub

    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles Update.Tick
        Try
            Send("update", clientSocket)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Alive_Tick(sender As Object, e As EventArgs)
        Send("alive", clientSocket)
    End Sub

   
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Size = New System.Drawing.Size(100, 100)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Send("usersonline|" & socketinfo, clientSocket)

    End Sub
End Class
