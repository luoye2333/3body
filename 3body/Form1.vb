Imports _3body.Star
Imports System.IO
Public Class Form1

	Public Shared body1, body2 As New Star ', body3
	Dim sw As StreamWriter

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim filename As String = CheckFileName()
		sw = New StreamWriter(filename)
		With body1
			.Location = New Dpoint(200.0, 200.0)
			.Velocity = New Dpoint(100.0, 0.0)
			.Mass = 5000
		End With
		With body2
			.Location = New Dpoint(200.0, 230.0)
			.Velocity = New Dpoint(-100.0, 0.0)
			.Mass = 5000
		End With
		Maintime.Interval = Tinteval * 1000

	End Sub


	Private Sub Maintime_Tick(sender As Object, e As EventArgs) Handles Maintime.Tick
		Dim iForce As Double
		Dim ifx, ify As Double
		Dim rx, ry As Double
		Dim r2 As Double
		rx = body1.Location.x - body2.Location.x
		ry = body1.Location.y - body2.Location.y
		r2 = rx ^ 2 + ry ^ 2
		iForce = g * body1.Mass * body2.Mass / r2
		'相互作用力
		ifx = iForce * rx / Math.Sqrt(r2)
		ify = iForce * ry / Math.Sqrt(r2)
		body1.Acceleration = New Dpoint(
		-ifx / body1.Mass, -ify / body1.Mass)
		'注意方向，假设b1在b2右下方，则rx> 0, ry > 0
		'对于b1来说加速度x，y均为负
		body2.Acceleration = New Dpoint(
		ifx / body2.Mass, ify / body2.Mass)
		body1.Cvel() : body1.Cloc()
		body2.Cvel() : body2.Cloc()
		'以上为数据中变化，以下实现显示变化
		b1.Location = New Point(Int(body1.Location.x),
								Int(body1.Location.y))
		b2.Location = New Point(Int(body2.Location.x),
								Int(body2.Location.y))
		'debug

		'saving
		sw.WriteLine(b1.Location.X & " " & b1.Location.Y)
		sw.WriteLine(b2.Location.X & " " & b2.Location.Y)
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Maintime.Enabled = Not Maintime.Enabled
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim a As New ZuangTai
		a.Show()
	End Sub

	Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
		sw.Close()
	End Sub



	Private Function CheckFileName() As String
		Dim k As Integer
		While File.Exists("轨迹记录" & k)
			k += 1
		End While
		Return "轨迹记录" & k & ".txt"
	End Function
End Class
