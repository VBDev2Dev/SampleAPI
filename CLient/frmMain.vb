Public Class frmMain
	 Dim rc As New RestSharp.RestClient(My.Settings.API)
	 Private Async Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		  Dim movies = Await GetMovies()
		  MovieBindingSource.DataSource = movies
	 End Sub

	 Async Function GetMovies() As Task(Of List(Of Movie))
		  Await Task.Delay(2000)
		  Dim rq As New RestSharp.RestRequest("Movies")
		  Dim resp = Await rc.ExecuteTaskAsync(Of List(Of Movie))(rq)
		  Return resp.Data
	 End Function

End Class
