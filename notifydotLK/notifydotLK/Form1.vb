Imports System.Net

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Create the initial request 
            Dim Request As HttpWebRequest = HttpWebRequest.Create(goUrl.Text)
            Request.Proxy = Nothing  'Speeds up the request by setting proxies to nothing 
            Request.UserAgent = "Test"


            'Create the response and reader 
            Dim Response As HttpWebResponse = Request.GetResponse
            Dim ResponseStream As System.IO.Stream = Response.GetResponseStream

            'Create a new stream reader 
            Dim StreamReader As New System.IO.StreamReader(ResponseStream)
            Dim Data As String = StreamReader.ReadToEnd
            StreamReader.Close()


            'Display the data on the screen 
            urlResponseText.Text = Data

        Catch ex As Exception

            MsgBox("Inproper input!")
            goUrl.Text = "1"

        End Try

    End Sub

End Class
