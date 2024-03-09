namespace ExceptionalHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create radiuspotive to access set radius*/
            Circle Raiduspostive = new Circle();
            try
            {
                /*this is the first run wiht taking the radius postive*/
                Raiduspostive.SetRadius(3);
                Console.WriteLine(Raiduspostive.ToString());
            }
            catch (Exception ex)
            { 
                /*using the ex to dispakt the error message */
                Console.WriteLine("Error" + ex.Message);
            }
            /*Create radiusnegative to access set radius*/
            Circle Raidusnegative = new Circle();
            try
            {
                /*this is the second run and displating  error message by using my constrcutor that takes no arugument, 
                *here the value of the radius is shown by using two string method*/
                Raidusnegative.SetRadius(-4);
                Console.WriteLine(Raidusnegative.ToString());
            }
            catch (Exception ex)
            {
                /*Created an instance mymessage from My InvlaidRadiusException class*/
                InvalidRadiusException mymessgae = new InvalidRadiusException();
                Console.WriteLine(mymessgae.invalidradiusexpeection());
            }
            /*Create zero to access set radius*/
            Circle Raiduszero = new Circle();
            try
            {
                /*here is the third run and dsplaying the error message using the cosntrcutor that takes arugment 
                 here the arugemnt to the constructor  is given from our circle class by using the radius value*/
                Raiduszero.SetRadius(0);
                Console.WriteLine(Raiduszero.ToString());
            }
            catch (Exception ex)
            {
                /*Created an instance mymessage from My InvlaidRadiusException class*/
                InvalidRadiusException mymessgae = new InvalidRadiusException();
                Console.WriteLine(mymessgae.SecondConstructor(Raiduszero.Radius));
            }

        }
    }
    class Circle
    {
        public double Radius
        { 
            get;  set;
        }
        /*Creating an method that returns the value of radius if it grater than zero*/
        public double SetRadius(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
                return Radius;
            }
            else
            {
                throw new Exception("Invalid Radius Exception");
            }
        }
        /*To string method to display inforamtion*/
        public override string ToString()
        {
            return $"The value of the radius : {Radius}";
        }
    }
}
