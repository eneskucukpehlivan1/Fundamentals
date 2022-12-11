using System;
namespace SolidPrinciples.LiskovsSubstitution
{
	public class CanonPrinter : BasePrinter,IScan
	{
        public override void Print()
        {
            Console.WriteLine("Canon ile yazdırıldı.");
        }

        public void Scan()
        {
            Console.WriteLine("Canon ile taratıldı.");
        }
    }
}

