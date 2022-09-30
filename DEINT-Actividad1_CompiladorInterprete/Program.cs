// See https://aka.ms/new-console-template for more information

//ACTIVIDAD 1

String cadena = "(2+[3-12]*{8/3})";

Console.WriteLine("Cadena a analizar: " + cadena + "\n");

Stack<Char> pila = new();

Console.WriteLine("¿Cadena correcta? -> " + ComprobarCadena());

Boolean ComprobarCadena() {

    for (int i = 0; i < cadena.Length; i++)
    {
        if (cadena[i].Equals('{') || cadena[i].Equals('}') || cadena[i].Equals('[') || cadena[i].Equals(']') || cadena[i].Equals('(') || cadena[i].Equals(')'))
        {
            if (cadena[i].Equals('(') || cadena[i].Equals('[') || cadena[i].Equals('{'))
            {

                pila.Push(cadena[i]);

            }
            else
            {

                if (pila.Count == 0)
                {
                    return false;
                }
                else if (pila.Peek().Equals(obtenerSimboloOpuesto(cadena[i])))
                {
                    pila.Pop();
                }

            }
        }

    }

    if (pila.Count == 0)
    {
        return true;
    }
    else {
        return false;
    }
}

char obtenerSimboloOpuesto(Char caracter)
{
    Char tempCaracter = ' ';

    if (caracter.Equals(')'))
    {
        tempCaracter = '(';
    }
    else if (caracter.Equals(']'))
    {
        tempCaracter = '[';
    }
    else if (caracter.Equals('}')) {
        tempCaracter = '{';
    }

    return tempCaracter;

}