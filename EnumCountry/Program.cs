using System;
enum Country
{
    India = 1,
    Australia,
    US,
    UK,
    China,
    Japan,
    Canada,
    Brazil,
    Spain
}
public class EnumCountries
{    
    public static void Main(string[] args)
    {
            bool choice1 = true;
            while (choice1)
            {
                Console.WriteLine("Choose the country to find language");
                Console.WriteLine("1. India\n2. Australia\n3. US\n4. UK\n5. China\n6. Japan\n7. Canada\n8. Brazil\n9. Spain\n10. Exit");
                Console.WriteLine("Please Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                Country c = (Country)choice;
                switch (c)
                {
                    case Country.India:
                        Console.WriteLine("The Language In India is Hindi");
                        break;
                    case Country.Australia:
                        Console.WriteLine("The Language In Australia is English");
                        break;
                    case Country.US:
                        Console.WriteLine("The Language In US is English");
                        break;
                    case Country.UK:
                        Console.WriteLine("The Language In UK is English");
                        break;
                    case Country.China:
                        Console.WriteLine("The Language In China is Chinese");
                        break;
                    case Country.Japan:
                        Console.WriteLine("The Language In Japan is Japanese");
                        break;
                    case Country.Canada:
                        Console.WriteLine("The Language In Canada is English");
                        break;
                    case Country.Brazil:
                        Console.WriteLine("The Language In Brazil is Portuguese");
                        break;
                    case Country.Spain:
                        Console.WriteLine("The Language In Spain is Spanish");
                        break;
                    default:
                        choice1 = false;
                        break;
                }
            }
        

    }
}

