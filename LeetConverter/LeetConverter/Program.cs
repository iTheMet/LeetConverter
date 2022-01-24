using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetConverter
{
    class Program
    {
        [STAThread]
        static void Main(String[] args)
        {
            string bufferIn = Clipboard.GetText(TextDataFormat.UnicodeText);
            string bufferOut = null;
            char[] slicedBuffer = bufferIn.ToLower().ToCharArray();

            for(int index = 0; index < slicedBuffer.Length; index++)
            {
                bufferOut = Primer.TranslateToLeet(bufferOut, slicedBuffer[index]);
            }

            Clipboard.Clear();
            Clipboard.SetText(bufferOut);

            /*Console.WriteLine($"текст: {bufferOut}");
            Console.ReadKey();*/
        }
    }
}
