// //EJERCICIO 1 -----------------------------------------------------------------------------------

// //Pedir al usuario que ingrese la primera fracción
//             Console.Write("Ingrese la primera fracción (en el formato a/b): ");
//             string fraction1 = Console.ReadLine();
//             string[] fraction1Parts = fraction1.Split('/');
//             int numerator1 = Convert.ToInt32(fraction1Parts[0]);
//             int denominator1 = Convert.ToInt32(fraction1Parts[1]);

//             // Pedir al usuario que ingrese la segunda fracción
//             Console.Write("Ingrese la segunda fracción (en el formato a/b): ");
//             string fraction2 = Console.ReadLine();
//             string[] fraction2Parts = fraction2.Split('/');
//             int numerator2 = Convert.ToInt32(fraction2Parts[0]);
//             int denominator2 = Convert.ToInt32(fraction2Parts[1]);

//             // Pedir al usuario que ingrese el operador
//             Console.Write("Ingrese el operador (+, -, * o /): ");
//             char operatorChar = Console.ReadKey().KeyChar;
//             Console.WriteLine();

//             // Realizar la operación especificada
//             int resultNumerator = 0;
//             int resultDenominator = 0;
//             switch (operatorChar)
//             {
//                 case '+':
//                     resultNumerator = numerator1 * denominator2 + numerator2 * denominator1;
//                     resultDenominator = denominator1 * denominator2;
//                     break;
//                 case '-':
//                     resultNumerator = numerator1 * denominator2 - numerator2 * denominator1;
//                     resultDenominator = denominator1 * denominator2;
//                     break;
//                 case '*':
//                     resultNumerator = numerator1 * numerator2;
//                     resultDenominator = denominator1 * denominator2;
//                     break;
//                 case '/':
//                     if (numerator2 == 0)
//                     {
//                         Console.WriteLine("Error: No se puede dividir entre cero.");
//                         return;
//                     }
//                     resultNumerator = numerator1 * denominator2;
//                     resultDenominator = denominator1 * numerator2;
//                     break;
//                 default:
//                     Console.WriteLine("Error: Operador no válido.");
//                     return;
//             }
//             static int GCD(int a, int b)
//             {
//                 while (b != 0)
//             {
//                 int temp = b;
//                 b = a % b;
//                 a = temp;
//             }
//                 return a;
// }

//             // Simplificar la fracción resultante
//             int gcd = GCD(resultNumerator, resultDenominator);
//             resultNumerator /= gcd;
//             resultDenominator /= gcd;

//             // Mostrar el resultado al usuario
//             Console.WriteLine($"El resultado es: {resultNumerator}/{resultDenominator}");
// //---------------------------------------------------------------------------------------------------------------

// EJERCICIO 2 ------------------------------------------------------------------------------------------------------
// int start, end; // Declarar dos variables enteras para almacenar el inicio y el final del rango
// Random random = new Random(); // Crear una nueva instancia de la clase Random para generar números aleatorios
// int[] missingNumbers; // Declarar una matriz de enteros para almacenar los números faltantes en cada tabla
// int[] guesses; // Declarar una matriz de enteros para almacenar las suposiciones del usuario para los números faltantes
// bool allCorrect = false; // Declarar una variable booleana para llevar un registro de si todas las suposiciones son correctas

// // Pedir al usuario que ingrese el inicio y el final del rango
// Console.Write("Ingrese el número de inicio del rango: ");
// start = Convert.ToInt32(Console.ReadLine());

// Console.Write("Ingrese el número final del rango: ");
// end = Convert.ToInt32(Console.ReadLine());

// // Inicializar las matrices para almacenar los números faltantes y las suposiciones del usuario
// missingNumbers = new int[end - start + 1];
// guesses = new int[end - start + 1];

// // Generar tablas de multiplicar para cada número en el rango
// for (int i = start; i <= end; i++)
// {
//     Console.WriteLine("Tabla del " + i + ":");
//     // Elegir un número faltante aleatorio para esta tabla
//     missingNumbers[i - start] = random.Next(1, 11);
//     for (int j = 1; j <= 10; j++)
//     {
//         // Si el número actual es el número faltante, ocultarlo
//         if (j == missingNumbers[i - start])
//             Console.WriteLine(i + " x ? = " + (i * j));
//         else
//             Console.WriteLine(i + " x " + j + " = " + (i * j));
//     }
//     Console.WriteLine();
// }

// // Pedir al usuario que adivine los números faltantes hasta que todas las suposiciones sean correctas
// while (!allCorrect)
// {
//     allCorrect = true;
//     for (int i = start; i <= end; i++)
//     {
//         Console.Write("¿Cuál es el número faltante en la tabla del " + i + "? ");
//         guesses[i - start] = Convert.ToInt32(Console.ReadLine());
//         if (guesses[i - start] != missingNumbers[i - start])
//             allCorrect = false;
//     }
//     if (!allCorrect)
//         Console.WriteLine("Algunas respuestas son incorrectas. Inténtalo de nuevo.");
// }

// // Felicitar al usuario por adivinar correctamente todos los números faltantes
// Console.WriteLine("¡Felicidades! Has adivinado todos los números faltantes.");
// //------------------------------------------------------------------------------------------------------------------

//EJERCICIO 3---------------------------------------------------------------------------------------------------------
//  // Pedir al usuario que ingrese un número
//             Console.Write("Ingrese un número: ");
//             int number = Convert.ToInt32(Console.ReadLine());

//             // Verificar si el número es divisible entre 5
//             bool divisibleBy5 = number % 5 == 0;

//             // Verificar si el número no es divisible entre 2 ni 3
//             bool notDivisibleBy2Or3 = number % 2 != 0 && number % 3 != 0;

//             // Calcular la suma de los dígitos del número
//             int sumOfDigits = 0;
//             while (number > 0)
//             {
//                 sumOfDigits += number % 10;
//                 number /= 10;
//             }

//             // Verificar si la suma de los dígitos es mayor a 10
//             bool sumGreaterThan10 = sumOfDigits > 10;

//             // Determinar si el número es "especial"
//             bool isSpecial = divisibleBy5 && notDivisibleBy2Or3 && sumGreaterThan10;

//             // Mostrar el resultado al usuario
//             if (isSpecial)
//                 Console.WriteLine("El número ingresado es un número especial.");
//             else
//                 Console.WriteLine("El número ingresado no es un número especial.");
// //------------------------------------------------------------------------------------------------------------------

//EJERCICIO 4----------------------------------------------------------------------------------------------------------
string[] originalPhrase = new string[] { "perro","que","ladra","no","muerde" }; // Declara una matriz de cadenas para almacenar la frase original
string[] hiddenPhrase = new string[] { "_____", "que", "_____", "no", "_____" }; // Declara una matriz de cadenas para almacenar la frase con algunas palabras ocultas
List<string> hiddenWords = new List<string> { "perro", "ladra", "muerde" }; // Declara una lista de cadenas para almacenar las palabras ocultas
int attempts = 10; // Declara una variable entera para almacenar el número de intentos restantes del usuario

// Muestra la frase con las palabras ocultas al usuario
Console.WriteLine("Adivina las palabras ocultas en la frase:");
Console.WriteLine(string.Join(" ", hiddenPhrase));

// Mientras el usuario tenga intentos restantes y aún haya palabras ocultas por adivinar
while (attempts > 0 && hiddenWords.Count > 0)
{
    // Muestra el número de intentos restantes al usuario
    Console.WriteLine($"\nTienes {attempts} intentos restantes.");
    // Pide al usuario que ingrese una palabra
    Console.Write("Ingresa una palabra: ");
    string guess = Console.ReadLine();

    // Si la palabra ingresada por el usuario está en la lista de palabras ocultas
    if (hiddenWords.Contains(guess))
    {
        // Informa al usuario que su suposición es correcta
        Console.WriteLine("¡Correcto!");
        // Elimina la palabra adivinada de la lista de palabras ocultas
        hiddenWords.Remove(guess);

        // Actualiza la frase con las palabras ocultas para mostrar la palabra adivinada
        for (int i = 0; i < originalPhrase.Length; i++)
        {
            if (originalPhrase[i] == guess)
            {
                hiddenPhrase[i] = guess;
            }
        }

        // Muestra la frase actualizada al usuario
        Console.WriteLine("La frase ahora es:");
        Console.WriteLine(string.Join(" ", hiddenPhrase));
    }
    else
    {
        // Informa al usuario que su suposición es incorrecta y reduce el número de intentos restantes en uno
        Console.WriteLine("Incorrecto.");
        attempts--;
    }
}

// Si el usuario ha adivinado todas las palabras ocultas, felicítalo
if (hiddenWords.Count == 0)
{
    Console.WriteLine("\n¡Felicidades! Has adivinado todas las palabras.");
}
else
{
    // De lo contrario, informa al usuario que ha agotado todos sus intentos
    Console.WriteLine("\nLo siento, has agotado todos tus intentos. Mejor suerte la próxima vez.");
}
//------------------------------------------------------------------------------------------------------------------
