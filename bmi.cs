using System;




namespace BMI
{

    class Program
    {
        public static string overweight(float bmi)
        {
            if(bmi < 18.5) {
                return "You are under weight";
                    }
            else if(bmi >= 18.5 && bmi < 24.9){
                return "You are in a healthy weight range";

            }
            else if(bmi >= 25 && bmi < 29.9)
            {
                return "You are overweight";
            }
            else
            {
                return "I'm sorry but you are obese";
            }
            
            }
            public static void Main(string[] args)
        {
            Console.WriteLine("Enter Weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            float height = Convert.ToSingle(Console.ReadLine());
            float bmi = weight / (height * height);
      
            string str = overweight(bmi);
            Console.WriteLine(str + ". Your bmi is "+ Convert.ToInt32(bmi));
           

        }
    }
 
}

