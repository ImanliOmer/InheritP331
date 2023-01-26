using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceP331
{
    internal class ExpertDocumentProgram:ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document openend Saved in pdf format");
        }
    }
}
