using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    public class ScienceMathLib : MathLib
    {
        public void Sine()
        {
            this.Result = System.Math.Sinh(FNum);
        }
        public void Cosine()
        {
            this.Result = System.Math.Cosh(FNum);
        }
        public void Tan()
        {
            this.Result = System.Math.Tanh(FNum);
        }
        public void Log()
        {
            this.Result = System.Math.Log(FNum);
        }
        public void OneDivByX()
        {
            this.Result = 1 / this.FNum;
        }
    }
}
