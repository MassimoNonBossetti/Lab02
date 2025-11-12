using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EsprReg
    {
        private string input;
        private string espressione;

        public EsprReg(string input, string espressione)
        {
            
            SetEspressione(espressione);
            SetInput(input);
        }

         private void SetInput(string input)
        {
            this.input = input;
        }
        private void SetEspressione(string espressione)
        {
            this.input = espressione;
        }
        public bool testEspr()
        {
            bool isMatch = Regex.IsMatch(input, espressione);
            return isMatch;
        }
    }
}

