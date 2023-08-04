namespace simpleclasses
{
    class program
    {
        static void Main(String[] args)
        {
            car mycar = new car();
            mycar.make = "oldmobile";
            mycar.model = "cutlas supreme";
            mycar.year = 1986;
            mycar.color = "silver";

            Console.WriteLine("{0} {1} {2} {3}", mycar.make, mycar.model, mycar.year, mycar.color);
            //decimal value = determinemarketvalue(mycar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:c}", mycar.determinemarketvalue());
            Console.ReadLine();
        }
        private static decimal determinemarketvalue(car car)
        {
            decimal carvalue = 100.0M;
            return carvalue;
        }
    }
    class car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }

        public decimal determinemarketvalue()
        {
            decimal carvalue;
            if (year > 1990)
                carvalue = 10000;
            else
                carvalue = 2000;

            return carvalue;
        }
    }
}
