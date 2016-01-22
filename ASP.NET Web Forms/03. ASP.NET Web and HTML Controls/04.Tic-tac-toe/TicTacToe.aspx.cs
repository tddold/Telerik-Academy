namespace _04.Tic_tac_toe
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;


    public partial class TicTacToe : Page
    {
        private string board;
        private string yourSign;
        private string computerSign;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.yourSign = "X";
            this.computerSign = "O";
            if (this.ViewState["currentBoard"] != null)
            {
                this.board = (string)ViewState["currentBoard"];
            }
            else
            {
                this.board = "---------";
            }
        }

        void Page_PreRender(object sender, EventArgs e)
        {
            ViewState.Add("currentBoard", this.board);
        }

        protected void ButtonTopLeft_Click(object sender, EventArgs e)
        {
            if (this.ButtonTopLeft.Text == "-")
            {
                this.ButtonTopLeft.Text = this.yourSign;
                this.ProcessGame(0);
            }
        }

        protected void ButtonTopCenter_Click(object sender, EventArgs e)
        {
            if (this.ButtonTopCenter.Text == "-")
            {
                this.ButtonTopCenter.Text = this.yourSign;
                this.ProcessGame(1);
            }
        }

        protected void ButtonTopRight_Click(object sender, EventArgs e)
        {
            if (this.ButtonTopRight.Text == "-")
            {
                this.ButtonTopRight.Text = this.yourSign;
                this.ProcessGame(2);
            }
        }

        protected void ButtonMiddleLeft_Click(object sender, EventArgs e)
        {
            if (this.ButtonMiddleLeft.Text == "-")
            {
                this.ButtonMiddleLeft.Text = this.yourSign;
                this.ProcessGame(3);
            }
        }

        protected void ButtonMiddleCenter_Click(object sender, EventArgs e)
        {
            if (this.ButtonMiddleCenter.Text == "-")
            {
                this.ButtonMiddleCenter.Text = this.yourSign;
                this.ProcessGame(4);
            }
        }

        protected void ButtonMiddleRight_Click(object sender, EventArgs e)
        {
            if (this.ButtonMiddleRight.Text == "-")
            {
                this.ButtonMiddleRight.Text = this.yourSign;
                this.ProcessGame(5);
            }
        }

        protected void ButtonBottomLeft_Click(object sender, EventArgs e)
        {
            if (this.ButtonBottomLeft.Text == "-")
            {
                this.ButtonBottomLeft.Text = this.yourSign;
                this.ProcessGame(6);
            }
        }

        protected void ButtonBottomCenter_Click(object sender, EventArgs e)
        {
            if (this.ButtonBottomCenter.Text == "-")
            {
                this.ButtonBottomCenter.Text = this.yourSign;
                this.ProcessGame(7);
            }
        }

        protected void ButtonBottomRight_Click(object sender, EventArgs e)
        {
            if (this.ButtonBottomRight.Text == "-")
            {
                this.ButtonBottomRight.Text = this.yourSign;
                this.ProcessGame(8);
            }
        }

        private void ProcessGame(int index)
        {
            char[] array = this.board.ToCharArray();
            array[index] = 'X';
            this.board = new string(array);

            if (this.GetResult() == "NotFinished")
            {
                this.ComputerMove();
                if (this.GetResult() != "NotFinished")
                {
                    this.result.Text = this.GetResult().ToString();
                    this.ViewState["currentBoard"] = null;
                }
            }
            else
            {
                this.result.Text = GetResult().ToString();
                this.ViewState["currentBoard"] = null;
            }
        }

        public string GetResult()
        {
            if ((this.board[0] == 'X' && this.board[1] == 'X' && this.board[2] == 'X') ||
                (this.board[3] == 'X' && this.board[4] == 'X' && this.board[5] == 'X') ||
                (this.board[6] == 'X' && this.board[7] == 'X' && this.board[8] == 'X') ||
                (this.board[0] == 'X' && this.board[3] == 'X' && this.board[6] == 'X') ||
                (this.board[1] == 'X' && this.board[4] == 'X' && this.board[7] == 'X') ||
                (this.board[2] == 'X' && this.board[5] == 'X' && this.board[8] == 'X') ||
                (this.board[0] == 'X' && this.board[4] == 'X' && this.board[8] == 'X') ||
                (this.board[2] == 'X' && this.board[4] == 'X' && this.board[6] == 'X'))
            {
                return "WonByX";
            }
            else if ((this.board[0] == 'O' && this.board[1] == 'O' && this.board[2] == 'O') ||
                    (this.board[3] == 'O' && this.board[4] == 'O' && this.board[5] == 'O') ||
                    (this.board[6] == 'O' && this.board[7] == 'O' && this.board[8] == 'O') ||
                    (this.board[0] == 'O' && this.board[3] == 'O' && this.board[6] == 'O') ||
                    (this.board[1] == 'O' && this.board[4] == 'O' && this.board[7] == 'O') ||
                    (this.board[2] == 'O' && this.board[5] == 'O' && this.board[8] == 'O') ||
                    (this.board[0] == 'O' && this.board[4] == 'O' && this.board[8] == 'O') ||
                    (this.board[2] == 'O' && this.board[4] == 'O' && this.board[6] == 'O'))
            {
                return "WonByO";
            }
            else if (!this.board.Contains("-"))
            {
                return "Draw";
            }
            else
            {
                return "NotFinished";
            }
        }

        private void ComputerMove()
        {
            Random rand = new Random();

            while (true)
            {
                var index = rand.Next(0, 9);
                if (this.board[index] == '-')
                {
                    char[] array = this.board.ToCharArray();
                    array[index] = 'O';
                    this.board = new string(array);
                    this.PrintComputerMove(index);
                    break;
                }
            }
        }

        private void PrintComputerMove(int index)
        {
            switch (index)
            {
                case 0: this.ButtonTopLeft.Text = this.computerSign; break;
                case 1: this.ButtonTopCenter.Text = this.computerSign; break;
                case 2: this.ButtonTopRight.Text = this.computerSign; break;
                case 3: this.ButtonMiddleLeft.Text = this.computerSign; break;
                case 4: this.ButtonMiddleCenter.Text = this.computerSign; break;
                case 5: this.ButtonMiddleLeft.Text = this.computerSign; break;
                case 6: this.ButtonBottomLeft.Text = this.computerSign; break;
                case 7: this.ButtonBottomCenter.Text = this.computerSign; break;
                case 8: this.ButtonBottomRight.Text = this.computerSign; break;

            }
        }

        protected void NewGame_Click(object sender, EventArgs e)
        {
            foreach (Control c in Page.Controls)
            {
                foreach (Control item in c.Controls)
                {
                    if (item is Button && item.ID != "NewGame")
                    {
                        ((Button)item).Text = "-";
                    }

                }
            }
            this.ViewState["currentBoard"] = null;
            this.board = "---------";
            this.result.Text = "";
        }
    }
}