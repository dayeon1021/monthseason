using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월을 입력하세요 : ");
            string input = Console.ReadLine();

            if (input == "3" || input == "03" || input == "3월" ||
               input == "4" || input == "04" || input == "4월" ||
               input == "5" || input == "05" || input == "5월")
            {
                Console.WriteLine("봄입니다~");
            }
            else if (input == "6" || input == "06" || input == "6월" ||
                        input == "7" || input == "07" || input == "7월" ||
                        input == "8" || input == "08" || input == "8월")
            {
                Console.WriteLine("여름입니다~");
            }
            else if (input == "9" || input == "09" || input == "9월" ||
                       input == "10" || input == "10" || input == "10월" ||
                       input == "11" || input == "11" || input == "11월")
            {
                Console.WriteLine("가을입니다~");
            }
            else if (input == "12" || input == "12" || input == "12월" ||
                      input == "1" || input == "01" || input == "1월" ||
                      input == "2" || input == "02" || input == "2월")
            {
                Console.WriteLine("겨울입니다~");
            }
            else
            {
                Console.WriteLine("잘못입력하셨습니다...!");
            }
        }
    }
}
