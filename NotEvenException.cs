using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenException
{
    class NotAnEvenException : ApplicationException
    {
        NotAnEvenException(string errorMessage) : base(errorMessage)
        {
            
        } 

        
    }
}
