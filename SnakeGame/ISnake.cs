namespace SnakeGame
{
    internal interface ISnake
    {
        void Start();
        void Setup();
        void Draw();
        void Input();
        void KeyCheck(char key);
        void Logic();
    }
}
