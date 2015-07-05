namespace Minesweeper
{
    public class Score
    {
        private string name;
        private int point;

        public Score()
        {

        }

        public Score(string name, int point) :
            this()
        {
            this.Name = name;
            this.Point = point;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Point
        {
            get
            {
                return this.point;
            }

            set
            {
                this.point = value;
            }
        }
    }
}
