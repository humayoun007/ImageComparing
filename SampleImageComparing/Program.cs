using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleImageCompairing
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (Py.GIL())
            {
                dynamic ci = Py.Import("compare_images");
                dynamic compare_image = ci.CompareImage("images/messi_image.jpg", "images2/horse-animal.jpg");
                dynamic image_difference = compare_image.compare_image();
                String isMatchedObj =  Convert.ToString(image_difference);

                if (isMatchedObj.ToString().Equals("Matched"))
                {
                    Console.WriteLine("Matched");
                }

                Console.ReadKey();

                

            }
        }
    }
}
