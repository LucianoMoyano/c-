/* //Tipos de datos mas comunes. texto, numeros, buleanos, listas, objetos

string libro = "Historias de divan";
string tlf = "1550053555";
string color = "amarilo";

int entero = 100;
float numDecimal = 1.96f;

bool autorizado = true;
bool seleccionado = false;

// lista de numeros que no pueden cambiar de tamaño

int[] numeros = {2, 3, 4, 5, 6, 7};
Console.WriteLine(numeros[0]);

//lista de numeros que pueden cambiar de tamaño

List<int> numero = new List<int> {2, 3, 4, 5, 6, 7};
Console.WriteLine(string.Join(",", numeros[0]));

//listas de texto

string[] animales = {"perro", "gato", "tigre"};

//lista de datos mixtos

dynamic[] datosMixtos = {"texto", 69, true, "Andres"};

//Diccionario: colecciones que nos permiten guardar datos con par clave-valor(key-value)

Dictionary<int, string> jugadores  = new Dictionary<int, string>();
jugadores.Add(10, "Messi");
jugadores.Add(7, "Cristiano Ronaldo");
Console.WriteLine(jugadores[7]);

//Dictionary que mapee texto a texto

Dictionary<string, string> paises = new Dictionary<string, string>();
paises.Add("EC", "Ecuador");
paises.Add("AR", "Argentina");
paises.Add("BR", "Brasil");

//Dictionary de texto a lista de texto

Dictionary<string, string[]> emails = new Dictionary<string, string[]>();
string[] emailsMarcelo = {"marcelo@gmail.com"};
emails.Add("Marcelo", emailsMarcelo);
string[] emailsLeandro = {"leandro@gmail.com", "leandro@hotmail.com"};
emails.Add("Leandro", emailsLeandro);

//constantes, son las variables que no pueden cambiar su valor

const float pi = 3.14f;

//operadores aritmeticos

Console.WriteLine(2 + 3);
Console.WriteLine(2 - 3);
Console.WriteLine(2 * 3);
Console.WriteLine(2 / 3);

Console.WriteLine(4 == 4);
Console.WriteLine(4 == "4"); // no me va a dejar realizar la operación ya que c# es un lenguaje fuertemente tipado
Console.WriteLine(4 != 5);
Console.WriteLine(4 < 5);
Console.WriteLine(4 >= 5);

Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(false && false);

Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(false || false);

//------------

int sumar(int primero, int segundo)
{
    return primero + segundo;
}

int resultado = sumar(3, 4);
Console.WriteLine(resultado);

//void: es un procedimiento por el cual no devuelve un valor. Simplemente lo procesa
void multiplicar(int primero, int segundo)
{
    Console.WriteLine(primero * segundo);
}
multiplicar(entero, 2);

//imprimir el primer elemento de la lista "animales"
void imprimirPrimerElemento(string[] lista)
{
    Console.WriteLine(lista[0]);
}
imprimirPrimerElemento(animales);

//foreach()

string[] animals = {"perro", "gato", "tigre"};

foreach (var item in animals)
{
    Console.WriteLine(item);
}


int[] listaNumeros = {23, 45, 16, 37, 3, 99, 22};
foreach (var number in listaNumeros)
{   
    multiplicar(number, 2);
}

 */