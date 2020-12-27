using System;
using System.Collections.Generic;
using System.Text;

namespace ChartSample
{
    public class ViewModel
    {
        public List<Person> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Person>()
            {
                new Person { Year = 2010, Product = 200 },
                new Person { Year = 2011, Product = 400 },
                new Person { Year = 2012, Product = 250 },
                new Person { Year = 2013, Product = 500 },
                new Person { Year = 2014, Product = 150 },
                new Person { Year = 2015, Product = 375 },

            };
        }
    }
}
