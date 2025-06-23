namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            
            // output the length of state
            Console.WriteLine("Length of state is " + state.Length);
            
            // Concatenate the contents of city and landmark * don't forget to add a space
            Console.WriteLine(city +  ", " + landmark);

            // output the first character of county
            Console.WriteLine(country.Substring(0, 1));
            //Console.WriteLine(country.ToCharArray().ElementAt(0));

            // output a concatenation of the first and last characters of city
            Console.WriteLine(city.Substring(0, 1) + city.Substring(city.Length - 1, 1));

            // output the substring of landmark starting at c and outputting to the end
            Console.WriteLine(landmark.Substring(landmark.IndexOf('c')));

            // output the substring of country starting at the first S and ending at the first A
            //Console.WriteLine(country.Substring(country.IndexOf('S'), 10));
            string firstSub = country.Substring(country.IndexOf('S'));
            Console.WriteLine(firstSub.Substring(0, firstSub.IndexOf('A')));

            // output the position of f in California
            Console.WriteLine(state.IndexOf('f')); 
                
                
            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels




            // Show your evidence of the program running in the Readme file
        }
    }
}
