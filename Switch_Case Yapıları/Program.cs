namespace Switch_Case_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Günler için sayı giriniz");
            int number = Convert.ToInt32(Console.ReadLine());
            string dayOfWeek = number switch
            {
                1 => "Sunday",
                2=>"Monday",
                3=>"Tuesday",
                4=>"Wednesday",
                5 =>"Thursday",
                6=>"Friday",
                7=>"Saturday",
                _=>"Invalid Input",
            };
            Console.WriteLine(dayOfWeek);
            Console.ReadLine();




            //switch (number)
            //{
            //    case 1:
            //        dayOfWeek = "Sunday";
            //        break;
            //        case 2:
            //        dayOfWeek = "Monday";
            //        break;
            //        case 3:
            //        dayOfWeek = "Tuesday";
            //        break;
            //        case 4:
            //        dayOfWeek = "Wednesday";
            //        break;
            //        case 5:
            //        dayOfWeek = "Thursday";
            //        break;
            //        case 6:
            //        dayOfWeek = "Friday";
            //        break;
            //        case 7:
            //        dayOfWeek = "Saturday";
            //        break;

            //    default:
            //        dayOfWeek = "Invalid input";
            //        break;
            //}





        }
    }
}