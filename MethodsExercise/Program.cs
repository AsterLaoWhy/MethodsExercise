namespace MethodsExercise
{
    public class Program
    {
        public static void Story()
        {
            Console.WriteLine("Please type a color");
            string color = Console.ReadLine();
            Console.WriteLine("Please type a name");
            string name = Console.ReadLine();
            Console.WriteLine("Please type an animal");
            string animal = Console.ReadLine();
            Console.WriteLine("Please type a band name");
            string bandName = Console.ReadLine();
            Console.WriteLine($"Once upon a time in the vibrant land of {color}, there lived a peculiar creature named {name}. " +
                $"This fantastical being was a blend of {animal} and {bandName}, creating a mesmerizing and unique existence.\r\n\r\n{name}" +
                $" was not your average {color} inhabitant. Its scales glowed with the hues of a thousand sunsets, reflecting the magical essence of the land. " +
                $"The creature had a mysterious aura, drawing curious gazes from all who encountered it.\r\n\r\nOne day, as {name} roamed the enchanted meadows, " +
                $"it stumbled upon a gathering of creatures from neighboring realms. Each one was as diverse as the next, representing the rich tapestry of the {color} world. " +
                $"There were talking trees, sparkling fireflies, and even airborne whales that soared through the skies.\r\n\r\nThe creatures welcomed {name} with open arms, " +
                $"enchanted by its extraordinary appearance. Together, they decided to embark on a quest to discover the fabled {bandName}, a legendary musical group whose melodies " +
                $"were said to have the power to unite all beings in harmony.\r\n\r\nTheir journey led them through valleys of shimmering crystals, across bridges made of rainbows, " +
                $"and into the heart of a forest where the trees whispered ancient tales. Along the way, {name} and its newfound friends encountered challenges that tested their courage " +
                $"and camaraderie.\r\n\r\nAs they approached the final destination, the air resonated with the distant tunes of the {bandName}. The closer they got, the stronger the " +
                $"vibrations became, echoing the unity that music brought to the {color} land. The legendary creatures danced under the starlit sky, their colorful forms blending into a " +
                $"mesmerizing display of joy and togetherness.\r\n\r\nIn the end, {name} realized that the true magic of the {color} land was not just in its fantastical inhabitants but" +
                $" in the connections forged through shared experiences. The melodies of the {bandName} served as a reminder that diversity, when celebrated, could create a harmonious " +
                $"symphony that echoed across the realms.\r\n\r\nAnd so, the tale of {name}, the {color} creature, became a cherished legend in the land, inspiring generations to come " +
                $"together in a kaleidoscope of unity and friendship.");
        }
        public static int add(int num1, int num2)
        {
            Console.WriteLine("Please type one number");
            try { num1 = int.Parse(Console.ReadLine()); }
            catch { num1 = 2; Console.WriteLine("Can't you just use a number? I decided this one is 2\n"); }
            Console.WriteLine("Please type the second number");
            try { num2 = int.Parse(Console.ReadLine()); }
            catch { num2 = 2; Console.WriteLine("Can't you just use a number? I decided this one is 2.\n"); }
            return num1 + num2;
        }
        public static int Multiply()// I don't get why you'd use params here when you could just do it this way 
        {
            int product = 1;
            Console.WriteLine("Please write a number, Once your are done, please press 'y'");
            string value = Console.ReadLine();
            while(value != "y" ||  value != "Y")
            {
                if (value =="y"||value=="Y")//I'm still not totally sure how I'd get the value to be checked without doing an if loop in the while loop for ability to do
                                            //infinite checks for longer product
                {
                    Console.WriteLine(product);
                    return product;
                }
                int val = int.Parse(value);
                product *= val;
                Console.WriteLine("Please write a number, Once your are done, please press 'y'");
                value = Console.ReadLine();
            }
            return product; 

           

        }
        static void Main(string[] args)
        {
            Story(); //Thank you ChatGPT for the beautiful story
            //Console.WriteLine("Hello, World!");
            Multiply();
        }
    }
}
