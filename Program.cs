class SimpleMath
{
  public class Program
  {
      public static void Main(string [] args)
      {

        int R = 10;
        
        Console.WriteLine($"the area is: {CalculateArea(R)}"); 
      }
      public static double CalculateArea(int Radius)
      {
        double Pi = Math.PI;
        double Area = Pi * Radius*Radius;
        return Area;
      }
       
  }
}
        // double firstSum = AddNumbers(12.7, 16.35);
        // Console.WriteLine($"firstsum = {firstSum}");

