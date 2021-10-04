using System;

namespace UnitTestsOblOpg
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _shirtnumber;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name 
        {
            get { return _name; }
            set 
            {
                if (value == null) throw new ArgumentNullException("Name is null");
                if (value.Length < 4) throw new ArgumentException("Name must be 4 letters long");
                _name = value;
            }
        }
        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException("price", value, "price must be positive");
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get { return _shirtnumber; }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException("ShirtNumber", value, "shirtnumber cannot be lower than 1");
                if (value > 100) throw new ArgumentOutOfRangeException("ShirtNumber", value, "shirtnumber cannot be higher than 100");
                _shirtnumber = value;
            }
        }

        public FootballPlayer(int id, string name, int price, int shirtnumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtnumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
