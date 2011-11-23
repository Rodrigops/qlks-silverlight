namespace Telerik.Reporting
{
    using System.Collections.Generic;

    public class Cars : List<Car>
    {
        public Cars()
        {
            Car car;
            car = new Car("Honda", "NSX GT", 2003, "http://www.telerik.com/images/reporting/cars/NSXGT_7.jpg"
				, new string[]{"Red","Blue","Black","Yellow","White"});
            this.Add(car);

            car = new Car("Nissan", "Skyline R34 GT-R", 2005, "http://www.telerik.com/images/reporting/cars/EVLR34_1.jpg"
				, new string[] { "Blue", "White" });
            this.Add(car);

            car = new Car("BMW", "M3", 2007, "http://www.telerik.com/images/reporting/cars//m3_2.jpg"
				, new string[] { "Red", "Black", "Yellow", "White" });
            this.Add(car);

            car = new Car("Mazda", "MX-5 SE", 2004, "http://www.telerik.com/images/reporting/cars/MX5_1.jpg"
				, new string[] { "Blue" });
            this.Add(car);

            car = new Car("Audi", "S4", 2006, "http://www.telerik.com/images/reporting/cars/S4_3.jpg"
				, new string[] { "Red", "Black", "White" });
            this.Add(car);

            car = new Car("Renault", "R5 Turbo", 2006, "http://www.telerik.com/images/reporting/cars/R5_2.jpg"
				, new string[] { "Red", "Blue", "Black", "Yellow" });
            this.Add(car);

            car = new Car("Lotus", "Exige", 2007, "http://www.telerik.com/images/reporting/cars/Exige_1.jpg"
				, new string[] { "Blue", "White" });
            this.Add(car);
        }
    }
}
