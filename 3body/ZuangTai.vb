﻿Public Class ZuangTai
	Private Sub Stime_Tick(sender As Object, e As EventArgs) Handles Stime.Tick
		Label17.Text = CStr(Form1.body1.Mass）
		Label18.Text = CStr(Form1.body2.Mass）
		'Label19.Text = CStr(Form1.body3.Mass）
		Label4.Text = CStr(Form1.body1.Location.x） + vbCrLf + CStr(Form1.body1.Location.y）
		Label5.Text = CStr(Form1.body2.Location.x） + vbCrLf + CStr(Form1.body2.Location.y）
		'Label6.Text = CStr(Form1.body3.Location.X） + vbCrLf + CStr(Form1.body3.Location.Y）
		Label7.Text = CStr(Form1.body1.Velocity.x） + vbCrLf + CStr(Form1.body1.Velocity.y）
		Label8.Text = CStr(Form1.body2.Velocity.x） + vbCrLf + CStr(Form1.body2.Velocity.y）
		'Label9.Text = CStr(Form1.body3.Velocity.X） + vbCrLf + CStr(Form1.body3.Velocity.Y）
		Label14.Text = CStr(Form1.body1.Acceleration.x） + vbCrLf + CStr(Form1.body1.Acceleration.y）
		Label15.Text = CStr(Form1.body2.Acceleration.x） + vbCrLf + CStr(Form1.body2.Acceleration.y）
		'Label16.Text = CStr(Form1.body3.Acceleration.X） + vbCrLf +CStr( Form1.body3.Acceleration.Y）
	End Sub

	Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Stime.Enabled = True
	End Sub

	Private Sub Status_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Stime.Enabled = False
	End Sub
End Class