'
' Created by SharpDevelop.
' User: willy
' Date: 17/5/2022
' Time: 14:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
	Console.Write("Ingrese un Numero:")
	Dim n = Cint(Console.ReadLine())
	Dim A As Integer
	Dim B As Integer
	Dim C As Integer
	A = 1
	B = 1
	C = 1
	Dim Flag As Boolean = true
	
	Start:
		If Flag Then
			Console.Write("0, ")
		Else
			Console.Write("1, ")
			B =  B + 1
		End If
		
		A = A + 1
		
		If A <= n Then
			If B <= C Then
				Flag = False
			Else
				Flag = True
				C = C + 1
				B = 1
			End If
			
			GoTo Start
		Else
			GoTo Finish
		End If
	Finish:
		Console.WriteLine("")
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
