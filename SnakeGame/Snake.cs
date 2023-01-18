namespace SnakeGame
{
    public class Snake : ISnake
    {

        public Snake()
        {
            Setup();
        }

        private int snakeX;
        private int snakeY;
        private int fruitX;
        private int fruitY;
        private int[] tailX = new int[10];
        private int[] tailY = new int[10];
        private int tailCount = 0;
        private Keys direction = Keys.Stop;
        private static int Height { get => 20; }
        private static int Width { get => 20; }
        private readonly char arenaChar = 'H';
        private readonly char snake = 'O';
        private readonly char snakeTail = 'o';

        private bool gameOver;
        private char key;

        public void Start()
        {
            while (!gameOver)
            {
                Draw();
                Input();
                Logic();
                if (gameOver)
                    GameEnd();
            }
        }

        private void GameEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou lose.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Setup()
        {
            gameOver = false;
            Random rnd = new Random();
            snakeX = Width / 2;
            snakeY = Height / 2;
            fruitX = rnd.Next(1, Width - 1);
            fruitY = rnd.Next(1, Height - 1);
            tailX = new int[100];
            tailY = new int[100];
            tailCount = 0;
        }

        public void Draw()
        {
            Console.Clear();
            for (int x = 0; x < Width; x++)
            {
                Console.Write(arenaChar);
            }
            Console.WriteLine();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (x == 0 || x == Width - 1)
                    {
                        Console.Write(arenaChar);
                    }
                    else if (x == snakeX && y == snakeY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(snake);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (x == fruitX && y == fruitY)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        bool noDraw = false;
                        for (int i = 0; i < tailCount; i++)
                        {
                            if (tailX[i] == x && tailY[i] == y)
                            {
                                Console.Write(snakeTail);
                                noDraw = true;
                            }
                        }
                        if (!noDraw)
                        {
                            Console.Write(' ');
                        }
                    }
                }
                Console.WriteLine();
            }

            for (int x = 0; x < Width; x++)
            {
                Console.Write(arenaChar);
            }
            Thread.Sleep(30);
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                this.key = Console.ReadKey().KeyChar;
                KeyCheck(key);
            }

        }

        public void KeyCheck(char key)
        {
            switch (key)
            {
                case 'w':
                    direction = Keys.Up;
                    break;
                case 'a':
                    direction = Keys.Left;
                    break;
                case 'd':
                    direction = Keys.Right;
                    break;
                case 's':
                    direction = Keys.Down;
                    break;
                default:
                    direction = Keys.Stop;
                    break;
            }
        }

        public void Logic()
        {
            int prevX = tailX[0];
            int prevY = tailY[0];
            int prev2X, prev2Y;
            tailX[0] = snakeX;
            tailY[0] = snakeY;
            for (int i = 1; i < tailCount; i++)
            {
                prev2X = tailX[i];
                prev2Y = tailY[i];
                tailX[i] = prevX;
                tailY[i] = prevY;
                prevX = prev2X;
                prevY = prev2Y;
            }

            Random r = new Random();
            switch (direction)
            {
                case Keys.Up:
                    snakeY--;
                    break;
                case Keys.Down:
                    snakeY++;
                    break;
                case Keys.Right:
                    snakeX++;
                    break;
                case Keys.Left:
                    snakeX--;
                    break;
            }
            if (snakeX == fruitX && snakeY == fruitY)
            {
                fruitX = r.Next(1, Width - 1);
                fruitY = r.Next(1, Height - 1);
                tailCount++;
            }

            if(snakeX == Width - 1 && direction == Keys.Right)
            {
                snakeX = Width - (Width - 1);
            }
            if(snakeX == (Width - (Width - 1)) && direction == Keys.Left)
            {
                snakeX = Width - 1;
            }
            if(snakeY == Height - 1 && direction == Keys.Down)
            {
                snakeY = Height - (Height - 1);
            }
            if(snakeY == (Height - (Height - 1)) && direction == Keys.Up)
            {
                snakeY = Height - 1;
            }
            for (int i = 1; i < tailX.Length; i++)
            {
                if (snakeX == tailX[i] && snakeY == tailY[i] && snakeX != tailX[tailX.Length - 1] || snakeX == tailX[i] && snakeY == tailY[i] && snakeY != tailY[tailY.Length - 1])
                {
                    gameOver = true;
                }
            }
        }
    }
}