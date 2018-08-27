using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Playground
    {
        public class Program {
            static int Main(string[] args) {
                var i = 1;
                try {
                    i -= 1;
                    try {

                        var j = 1 / i;
                    } catch (Exception ex) {

                        throw;
                    } finally {
                        i += 1;
                    }
                } catch (Exception ex) {
                    i++;

                } finally {
                    --i;

                }

                Console.WriteLine(i);
                Console.ReadKey();

            }
        }
}
