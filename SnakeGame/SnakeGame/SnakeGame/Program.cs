using System;
using System.Threading;


namespace SnakeGame
{
    internal class Program
    {

        public Random rand = new Random();
        public ConsoleKeyInfo key = new ConsoleKeyInfo();
        int score, headX, headY, fruitX, fruitY, nTail;
        int times = 45;
        bool isSuperFruit = false;
        int[] tailX = new int[100];
        int[] tailY = new int[100];
        const int height = 20;
        const int width = 60;
        const int panel = 10;
        bool gameOver, reset, isprinted, horizontal, vertical;
        string dir, pre_dir;
        int renderTime = 200;
        int countSuper = 0;


       
        void ShowBanner()
        {
            Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("SNAKE GAME");
            Console.WriteLine("Press any key to play");
            Console.WriteLine("Press H to enter hard mode");

            Console.WriteLine("Press P to pause");
            Console.WriteLine("Press R to reset");
            Console.WriteLine("Press Q to quit");

            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.H) renderTime = 50;

            if (key.Key == ConsoleKey.Q) Environment.Exit(0);
        }

        void Setup()
        {
            dir = "RIGHT";
            pre_dir = "";
            score = 0;
            nTail = 0;
            gameOver = reset = isprinted = false;
            headX = 10; headY = 5;
            RandomFruit();
        }

        void RandomFruit()
        {
            fruitX = rand.Next(1, width - 1);
            fruitY = rand.Next(1, height - 1);
          

        }

        void Update()
        {
            while (!gameOver)
            {
                CheckInput();
                Logic();
                Render();
                if (reset) break;
              
                Thread.Sleep(renderTime);
              
            }
            if (gameOver)
            {
                Lose();
            }
        }

        void CheckInput()
        {
            while (Console.KeyAvailable) {
                key = Console.ReadKey(true);
                pre_dir = dir;
                switch (key.Key) {
                    case ConsoleKey.Q: Environment.Exit(0); break;
                    case ConsoleKey.S: dir = "STOP"; break;
                    case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.UpArrow: dir = "UP"; break;
                    case ConsoleKey.DownArrow: dir = "DOWN"; break;



                }
            }
        }

        void Logic()
        {
            int preX = tailX[0], preY = tailY[0];
            int tempX, tempY;

            if(fruitX == width/2 || fruitY == height/2)
            {
                RandomFruit();
            }

            if(score !=0 && times > 0 && score % 30 == 0)
            {
                isSuperFruit = true;
                times--;

            }

        
            if (times <= 0)
            {

                isSuperFruit = false;
          

            }


            if (dir != "STOP")
            {
                tailX[0] = headX; tailY[0] = headY;

                for (int i = 1; i < nTail; i++)
                {
                    tempX = tailX[i]; tempY = tailY[i];
                    tailX[i] = preX; tailY[i] = preY;
                    preX = tempX; preY = tempY;
                }
            }

            switch (dir)
            {
                case "RIGHT": headX++; break;
                case "LEFT": headX--; break;
                case "UP": headY--; break;
                case "DOWN": headY++; break;
                case "STOP":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Game Pause");
                            Console.WriteLine("Press S to unpause");
                            Console.WriteLine("Press R to reset");
                            Console.WriteLine("Press Q to quit");

                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Q)
                            {
                                Environment.Exit(0);
                            }
                            if (key.Key == ConsoleKey.R)
                            {
                                reset = true; break;
                            }
                            if (key.Key == ConsoleKey.S)
                            {
                                break;
                            }

                        }
                    }
                    dir = pre_dir; break;
            }

            if (headX < 0)
            {
                headX = width - 2;
            }else if (headX>= width - 1)
            {
                headX = 0;
            }

            if (headY <= 0)
            {
                headY = height - 2;
            }
            else if (headY >= height - 1)
            {
                headY = 1;
            }

            if (headX == width/2 || headY == height/2)
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }



            if (headX == fruitX && headY == fruitY)
            {
                if(isSuperFruit)
                {
                    nTail += 2;
                    countSuper++;
                }
                else
                {
                    nTail++;

                }
                score += 10;
                times = 45;

                isSuperFruit = false;
                RandomFruit();
            }

            if(((dir == "LEFT" && pre_dir != "UP") &&(dir == "LEFT" && pre_dir != "DOWN")) || 
                ((dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
            {
                    horizontal=true;
            }else horizontal=false;

            if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) ||
             ((dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
            {
                vertical = true;
            }
            else vertical = false;

            for(int i = 1; i < nTail; i++)
            {
                if(headX == tailX[i] && headY == tailY[i])
                {
                    if (horizontal || vertical) gameOver = false; else gameOver = true;
                }

                if (fruitX == tailX[i] && fruitY == tailY[i]) RandomFruit();
            }
        }

        void Render()
        {
            Console.SetCursorPosition(0,0);
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if (i == height/2)   //viền khung trên và dưới
                        Console.Write("-");
                    else if (j == width/2) //viền khung trái và phải
                        Console.Write("|");
                    else if (j == fruitX && i == fruitY && isSuperFruit) //hộp quả 
                        Console.Write("o");
                    else if (j == fruitX && i == fruitY ) //hộp quả 
                        Console.Write("*");
                    else if (j == headX && i == headY) //đầu con rắn
                        Console.Write("0");
                    else
                    {
                        isprinted = false;
                        for (int k = 0; k < nTail; k++)
                        {
                            if (j == tailX[k] && i == tailY[k])
                            {
                                Console.Write("$");
                                isprinted = true;
                                break;
                            }
                        }

                        if (!isprinted) Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your score: " + score);
            Console.WriteLine("Special fruits: " + countSuper);

            if (isSuperFruit)
            {
                Console.WriteLine("Time super fruit remaining: " + times);

            }
            else
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");

            }
        }

        void Lose()
        {
            Console.Clear();

            Console.WriteLine("Game over!");
            Console.WriteLine("Your score: " + (score *(1+ countSuper)));
            Console.WriteLine("Press R to reset");
            Console.WriteLine("Press Q to quit");

            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Q) Environment.Exit(0);
                if (key.Key == ConsoleKey.R) reset = true; break;

            }

        }

        static void Main(string[] args)
        {
            Program snakegame = new Program();
            snakegame.ShowBanner();
            while (true)
            {
                snakegame.Setup();
                snakegame.Update();
                Console.Clear(); 
            }
        }
    }
}
