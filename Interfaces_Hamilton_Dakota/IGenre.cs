using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Hamilton_Dakota
{   
    /// <summary>
    /// Follows the Instructions of the Program and Gets and Sets the Values
    /// </summary>
    interface IGenre
    {
        
        public string ESRB { get; set; }
        
        public string Genre {get; set;}
        
        public string Title {get; set;}

        public string Describe();
    }
}
