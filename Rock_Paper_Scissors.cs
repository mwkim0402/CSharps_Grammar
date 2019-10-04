using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0911
{
    class Game
    {
        private int winCount = 0;
        private int count = 0;
        public Game()
        {
        }
        public int countCheck
        {
            get { return count; }
            set { count = value; }
        }

        public int winCheck
        {
            get { return winCount; }
            set { winCount = value; }
        }

        // 1. 가위  2. 바위 3.보
        public void startGame(int userNum, int comNum)
        {
            // 사용자 가위
            if (userNum == 1)
            {
                if (comNum == 1)
                {
                    Console.WriteLine("결과 비겼습니다");
                }
                else if (comNum == 2)
                {
                    Console.WriteLine("졌습니다");
                    count += 1;
                }
                else if (comNum == 3)
                {
                    Console.WriteLine("이겼습니다");
                    this.winCount += 1;
                    count += 1;
                }
            }
            // 사용자 바위
            else if (userNum == 2)
            {
                if (comNum == 1)
                {
                    Console.WriteLine("이겼습니다");
                    this.winCount += 1;
                    count += 1;
                }
                else if (comNum == 2)
                {
                    Console.WriteLine("결과 비겼습니다");
                }
                else if (comNum == 3)
                {
                    Console.WriteLine("졌습니다");
                    count += 1;
                }
            }
            // 사용자 보
            else if (userNum == 3)
            {
                if (comNum == 1)
                {
                    Console.WriteLine("졌습니다");
                    count += 1;
                }
                else if (comNum == 2)
                {
                    Console.WriteLine("이겼습니다");
                    this.winCount += 1;
                    count += 1;
                }
                else if (comNum == 3)
                {
                    Console.WriteLine("결과 비겼습니다");
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int user = 0;
            Random ranCom = new Random();
            Game game = new Game();
            while (true)
            {
                try
                {
                    Console.WriteLine("1. 가위, 2.바위 3. 보");
                    Console.Write("선택 : ");
                    bool isNum = int.TryParse(Console.ReadLine(), out user);
                    if (!isNum){
                        throw new Exception();
                    }

                    if (user != 1 && user != 2 && user != 3)
                    {
                        throw new Exception();
                    }
                    int com = ranCom.Next(1, 4);                    
                    Console.WriteLine("나) {0} : {1} (컴", ChageStr(user), ChageStr(com));
                    game.startGame(user, com);
                    Console.WriteLine("승률 : {0}%", ((double)game.winCheck / game.countCheck) * 100);
                    Console.WriteLine("계속하시겠습니까? 1. 계속 2.종료");
                    if (int.Parse(Console.ReadLine()) == 2)
                    {
                        break;
                    }
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Warning : 1, 2, 3 중에 입력하여야 합니다");
                }

            }
        }
        static string ChageStr(int s)
        {
            if (s == 1)
            {
                return "가위";
            }
            else if (s == 2)
            {
                return "바위";
            }
            else
            {
                return "보";
            }
        }
    }
}
