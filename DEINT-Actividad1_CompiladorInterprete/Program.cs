// See https://aka.ms/new-console-template for more information

//ACTIVIDAD 1

String cadena = "(2+[3-12]*{8/3})";

Console.WriteLine(cadena);

List<Char> lista = new List<Char>();
Stack<Char> pila = new Stack<Char>();

foreach (Char c in cadena) {
    if (c.Equals("{") || c.Equals("}") || c.Equals("[") || c.Equals("]") || c.Equals("(") || c.Equals(")")) { 
        lista.Add(c);
    }
}

Console.WriteLine(ComprobarCadena());

int ComprobarCadena() {

    Char temp;

    for (int i = 0; i < pila.Count; i++)
    {

        if (lista[i].Equals('(') || lista[i].Equals('[') || lista[i].Equals('{'))
        {

            pila.Push(lista[i]);

        }
        else {
            if (pila.Pop().Equals(obtenerSimboloOpuesto())) { 
            
            }
        }

    }

    return 0;
}

char obtenerSimboloOpuesto()
{
    throw new NotImplementedException();
}