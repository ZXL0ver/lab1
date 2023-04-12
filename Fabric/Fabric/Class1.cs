using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fabric
{
    public class Taxi
    {
        public string type;
        public int id, loong;
        public Taxi()
        {
            type = "car";
        }
        public Taxi(string p)
        {
            type = p;
        }
    }
    public class City
    {
        public string name, color;
        public int size, price;

        public City()
        {
            size = 1;
        }
        public City(int p)
        {
            size = p;
        }

    }
    public class Driver
    {
        public int speed, stars;
        public string name;
        public Driver()
        {
            speed = 1;
        }
        public Driver(int p)
        {
            speed = p;
        }
        
    }
    public abstract class AbstractLevel
    {
        public Taxi tax;
        public City city;
        public Driver driver;
        public abstract Taxi createTaxi();
        public abstract City createCity();
        public abstract Driver createDriver();
        public abstract void Play();
    }

    public class FirstTaxi : Taxi
    {
        public FirstTaxi()
        {
            type = "car";
            id = 1;
        }
    }
    public class SecondTaxi : Taxi
    {
        public SecondTaxi()
        {

            type = "bicycle";
            id = 2;
        }
    }
    public class ThirdTaxi : Taxi
    {
        public ThirdTaxi()
        {

            type = "moped";
            id = 3;
        }
    }
    public class FirstCity : City
    {
        public FirstCity()
        {
            price = 300;
            name = "Kuiv";
            size = 9;
        }
    }
    public class SecondCity : City
    {
        public SecondCity()
        {

            price = 250;
            name = "Lviv";
            size = 8;
        }
    }
    public class ThirdCity : City
    {
        public ThirdCity()
        {
            price = 200;
            name = "Odesa";
            size = 7;
        }
    }
    public class FirstDriver : Driver
    {
        public FirstDriver()
        {
            stars = 1;
            speed = 1;
            name = "bad driver";
        }
    }
    public class SecondDriver : Driver
    {
        public SecondDriver()
        {
            stars = 2;
            speed = 6;
            name = "normal driver";

        }
    }
    public class ThirdDriver : Driver
    {
        public ThirdDriver()
        {
            stars = 3;
            speed = 10;
            name = "best driver";

        }
    }

    public class First : AbstractLevel
    { 
        public override Taxi createTaxi()
        {
            return new FirstTaxi();
        }
        public override City createCity()
        {
            return new FirstCity();
        }
        public override Driver createDriver()
        {
            return new FirstDriver();
        }
        public override void Play()
        {
            tax = createTaxi();
            city = createCity();
            driver = createDriver();
        }
    }
    public class Second: AbstractLevel
    {
        public override Taxi createTaxi()
        {
            return new SecondTaxi();
        }
        public override City createCity()
        {
            return new SecondCity();
        }
        public override Driver createDriver()
        {
            return new SecondDriver();
        }
        public override void Play()
        {
            tax = createTaxi();
            city = createCity();
            driver = createDriver();
        }
    }
    public class Third : AbstractLevel
    {
        public override Taxi createTaxi()
        {
            return new ThirdTaxi();
        }
        public override City createCity()
        {
            return new ThirdCity();
        }
        public override Driver createDriver()
        {
            return new ThirdDriver();
        }
        public override void Play()
        {
            tax = createTaxi();
            city = createCity();
            driver = createDriver();
        }
    }
}
