namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando y asignando variable en dos pasos
            string saludo;
            saludo = "Bienvenido";

            //declarando y asignando valor a la variable en un solo paso
            string nombre = "Camila Fimbres";

            //concatenando con el operador + (no recomendado)
            string saludoCompleto = "saludoCompleto: "+saludo + " " + nombre + "...!!";
            Console.WriteLine(saludoCompleto);
            
            //concatenando utilizando string.format
            string saludoCompleto2 = string.Format("saludoCompleto2: {0} {1}...!!",saludo,nombre);
            Console.WriteLine( saludoCompleto2);

            //concatenando con interpolacion de texto
            string saludoCompleto3 = $"saludoCompleto3: {saludo} {nombre}...!!";
            Console.WriteLine( saludoCompleto3);
                
        }
    }
}
