namespace Advent_Of_Code_2021.Day1
{
    internal class Day1
    {
        static void CalculateIncrements (string[] args)
        {
            //string numbers = File.ReadAllText();



            string[] lines = File.ReadAllLines(@"C:\Users\Josh\source\repos\Advent Of Code 2021 Day 1\C:\Users\Josh\source\repos\Advent Of Code 2021 Day 1\Day1\TextFile1.txt");
            int lastNumber = 0;
            int lastSeqeuntialNumber = 0;
            int numberOfIncrements = 0;
            int numberOfSeqeuntialIncrements = 0;
            int currentIndex = 0;


            List<int> numberList = new();  // if number arrays length is 3 then go onto the next iteration

            //Replace first number in list with most recent number every iteration

            foreach (string line in lines)
            {


                int number = int.Parse(line);






                if (number > lastNumber && lastNumber != 0)
                {

                    numberOfIncrements++;
                }
                lastNumber = number;



                if (lines.Length > currentIndex + 2)
                {
                    int currentSequentialNumber = int.Parse(lines[currentIndex]) + int.Parse(lines[currentIndex + 1]) + int.Parse(lines[currentIndex + 2]);
                    if (currentSequentialNumber > lastSeqeuntialNumber)
                    {
                        numberOfSeqeuntialIncrements++;
                    }
                    lastSeqeuntialNumber = currentSequentialNumber;

                }
                else
                {
                    Console.WriteLine("Out of index");
                }






                currentIndex++;


            }



            Console.WriteLine(numberOfSeqeuntialIncrements);
            // get current iteration and add to an array with number in index infront of current iteration and number from that iteration
        }
    }
}