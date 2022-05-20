open System

module calculadora = 
  let suma x y = x+y
  let resta x y = x-y
  let multi x y = x*y
  let dividir x y = x/y
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("Calculando.............")
    Console.WriteLine("Introduzca dos numeros")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let sumares = calculadora.suma valor1 valor2
    Console.WriteLine("La suma de sus dos numeros es: "+ sumares.ToString())
    let restares = calculadora.resta valor1 valor2
    Console.WriteLine("La resta de sus dos numeros es: "+ restares.ToString())
    let multires = calculadora.multi valor1 valor2
    Console.WriteLine("La multipliacion de sus dos numeros es: "+ multires.ToString())
    let divres = calculadora.dividir valor1 valor2
    Console.WriteLine("La division de sus dos numeros es: "+ divres.ToString())
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero