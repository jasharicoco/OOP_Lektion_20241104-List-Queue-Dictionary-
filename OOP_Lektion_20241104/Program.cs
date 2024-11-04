namespace OOP_Lektion_20241104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T>
            List<string> fruits = new List<string> { "Äpple", "Banan", "Citron", "Päron", "Passionsfrukt", "Kiwi", "Mango", "Drakfrukt" };


            // Lägg till element
            fruits.Add("Dadel");
            fruits.Insert(7, "Ananas"); // Lägg till på specifik indexplats


            // Ta bort element
            var /* eller var */ removedSuccess = fruits.Remove("Banan"); // Returnerar true eller false
            Console.WriteLine(removedSuccess);

            fruits.Remove("Banan");
            fruits.RemoveAt(0);         // Tar bort 0
            fruits.RemoveRange(0, 2);   // Tar bort 0 till 2
            fruits.RemoveAll(fruit => fruit.Length < 6); // Tar bort alla element med mindre än 6 bokstäver (lambda-expression)


            // Sök och hämta element
            int citronIndex = fruits.IndexOf("Citron");
            Console.WriteLine(citronIndex);

            bool ananasExists = fruits.Contains("Ananas");
            Console.WriteLine(ananasExists);


            // Sortera listan
            fruits.Sort();


            // Filtrera och skapa en ny lista
            var longFruits = fruits.FindAll(fruits => fruits.Length > 5);


            // Några andra användbara medlemmar
            Console.WriteLine($"Antal frukter i listan: {fruits.Count}");
            Console.WriteLine($"Frukter: {string.Join(", ", fruits)}");


            Console.WriteLine("\n\n");


            // Queue<T>
            Queue<string> customerQ = new Queue<string>();


            // Lägga till kunder i kön
            customerQ.Enqueue("Kalle");     // Först in i kön
            customerQ.Enqueue("Aslan");     // Andra in i kön
            customerQ.Enqueue("Gretel");    // Tredje in i kön
            customerQ.Enqueue("Thunberg");  // Fjärde in i kön


            // Titta på nästa kund att ta bort
            string nextCustomer = customerQ.Peek();
            Console.WriteLine($"Nästa kund: {nextCustomer}");


            // Ta bort och returnera nästa kund
            string serveCustomer = customerQ.Dequeue();
            Console.WriteLine($"Nu betjänas: {serveCustomer}");

            /* Skillnaden mellan Peek() och Dequeue() är att i Peek så kollar vi bara vem som är näst i kön
             * medans i Dequeue så både "kollar" vi och "tar bort" samtidigt. */

            Console.WriteLine(customerQ.Peek()); // Kalle har fått hjälp och nu är Aslan näst i kön


            // Kontrollera om en kund finns i kön
            bool aslanExists = customerQ.Contains("Aslan");
            Console.WriteLine(aslanExists);
            string tryCustomer;
            var notEmptyQueue = customerQ.TryDequeue(out tryCustomer);

            Console.WriteLine(tryCustomer); // Aslan står i kö
            Console.WriteLine(notEmptyQueue); // True or false beroende på om någon står i kö


            // Gör om till array
            string[] customerArray = customerQ.ToArray();

            Console.WriteLine($"Antal kunder i kön: {customerQ.Count}");


            Console.WriteLine("\n\n");


            // Stack<T>
            Stack<int> numberStack = new Stack<int>();


            // Lägg till element på stacken
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);


            // Titta på det översta elementet utan att ta bort det
            int topElement = numberStack.Peek();
            Console.WriteLine($"Översta elementet: {topElement}");


            // Ta bort och returnera det översta elementet
            int poppedElement = numberStack.Pop();
            Console.WriteLine($"Poppat element: {poppedElement}");


            // Kontrollera om ett element finns i listan
            bool twentyExists = numberStack.Contains(20);


            // Konvertera stack till array
            var intArray = numberStack.ToArray();

            Console.WriteLine($"Antal nummer i kön: {numberStack.Count}");


            // Dictionary<T>
            Dictionary<string, int> ages = new Dictionary<string, int>();


            // Lägg till element (strängen är key, inten är value)
            ages.Add("Anna", 24);
            ages.Add("Konrad", 45);
            ages.Add("Kenta", 77);
            ages.Add("Philip", 14);


            // Uppdatera värde
            ages["Anna"] = 25;


            // Försök att hämta ett värde säkert
            if (ages.TryGetValue("Cecilia", out int ceciliasAge))
            {
                Console.WriteLine($"Cecilias ålder är: {ceciliasAge}");
            }
            else
            {
                Console.WriteLine("Cecilia finns inte i vår Dictionary.");
            }


            // Ta bort ett element
            ages.Remove("Konrad");

            foreach (var kvp in ages) //kvp = KeyValuePair<string,int>
            {
                Console.WriteLine($"{kvp.Key} är {kvp.Value} år gammal.");
            }

            Console.WriteLine($"Det finns {ages.Count} element i vår Dictionary.");


            // Anta att vi vill ändra "Anna" till "Annie"
            if (ages.TryGetValue("Anna", out int age))
            {
                ages.Remove("Anna");    // Ta bort den gamla nyckeln
                ages.Add("Annie", age); // Lägg till den nya nyckeln med samma värde
            }



        }
    }
}