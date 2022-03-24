using System;

namespace ClassLibrary
{
    public class MyItem
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return $"Name - {name}, Age - {age}";
        }

    }
}
