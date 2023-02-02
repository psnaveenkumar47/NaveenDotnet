using System;

namespace StudentException
{
    public class MarksOverException:Exception
    {
       
            public MarksOverException() : base() { }
            public MarksOverException(string message) : base(String.Format("Marks should be Less Than 100 ")) { }
    }
}
