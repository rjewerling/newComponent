using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WindowsFormsApp1 {

    public class Masks : Enume{

        private int id;
        private string mask;
        private string description;

        public Masks() {}

        public Masks() {}
    }
}


public class CountryType : Enumeration {
    public static CountryType UnitedStates => new(1, "United States");
    public static CountryType Canada => new(2, "Canada");

    public CountryType(int id, string name)
        : base(id, name) {
    }
}

Console.WriteLine(CountryType.UnitedStates); // "United States"