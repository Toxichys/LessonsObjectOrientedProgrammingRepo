namespace MyHomework_Lesson_7
{
    interface IFigure
    {
        public void MoveX(int x);
        public void MoveY(int y);
        public void ChangeColour(FigureColourEnum colour);
        public bool IsVisible();
    }
}
