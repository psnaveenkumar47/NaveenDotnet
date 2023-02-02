using System;
namespace StudentException
{
     class MarksNegaticeException:Exception
    {
        public MarksNegaticeException():base(){}
        public MarksNegaticeException(string message):base(String.Format("Marks should be more than 0 ")){}
    }
}
