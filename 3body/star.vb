Public Class Star
	Public Structure Dpoint
		Public x As Double
		Public y As Double
		Public Sub New(v1 As Double, v2 As Double)
			x = v1
			y = v2
		End Sub
	End Structure
	'矢量声明，3维时需更改

	Private locus As Dpoint
	Private veloc As Dpoint
	Private accel As Dpoint
	Private mas As Double

	Property Location As Dpoint
		Get
			Return locus
		End Get
		Set(value As Dpoint)
			locus = value
		End Set
	End Property
	Property Velocity As Dpoint
		Get
			Return veloc
		End Get
		Set(value As Dpoint)
			veloc = value
		End Set
	End Property
	Property Acceleration As Dpoint
		Get
			Return accel
		End Get
		Set(value As Dpoint)
			accel = value
		End Set
	End Property
	Property Mass As Double
		Get
			Return mas
		End Get
		Set(value As Double)
			mas = value
		End Set
	End Property

	Public Sub Cvel()
		veloc.x += accel.x * Tinteval
		veloc.y += accel.y * Tinteval
	End Sub
	Public Sub Cloc()
		'每一段时间元内视为匀加速
		's=vt+0.5at^2
		locus.x += veloc.x * Tinteval + 0.5 * accel.x * (Tinteval ^ 2)
		locus.y += veloc.y * Tinteval + 0.5 * accel.y * (Tinteval ^ 2)
	End Sub
End Class
