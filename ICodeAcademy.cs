using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8aprel.home
{
    internal interface ICodeAcademy
    {
        string CodeEmail { get; set; } 
        void GenerateEmail(); 
    }
}
