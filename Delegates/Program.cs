using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Program
    {
        static void Main(string[] args)
          {
            var processor = new PhotoProcessor();
            var filters  =new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            //filterHandler += filters.RemoveRedEveFilter;

             processor.Process("photo.jpg",filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("apply removeredeye");
        }
    }
}
