using TicTacToeLib.Model;

namespace TicTacToeWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Game _game;
        public Form1()
        {
            this.Text = "Tic Tac Toe Game";
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Player player1 = new Player("Player1", MarkType.X);
            Player player2 = new Player("Player2", MarkType.O);

            _game = new Game(board, analyzer, new Player[] { player2, player1 });

            int cellSize = 100;
            int formWidth = cellSize * 3;
            int formHeight = cellSize * 3;

            this.ClientSize = new Size(formWidth, formHeight);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Text = $"{i * 3 + j}";
                    button.Size = new Size(100, 100);
                    button.Location = new Point(j * 100, i * 100);
                    button.Font = new Font("Arial", 36);
                    button.Click += new EventHandler(button_Click);
                    Controls.Add(button);
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int cellPosition = int.Parse(button.Text);
            _game.Play(cellPosition);

            MessageBox.Show($"Current player: {_game.CurrentPlayer.Name}, Current player Mark: {_game.CurrentPlayer.Mark}, " +
                $"Has Marked Cell: {cellPosition}\nStatus: {_game.Status}");

            if (_game.Status == ResultType.Win)
            {
                string winnerName = _game.CurrentPlayer.Name;
                MessageBox.Show($"{winnerName} won the game!", "Game Over", MessageBoxButtons.OK);
                Application.Exit();
            }
            else if (_game.Status == ResultType.Draw)
            {
                MessageBox.Show("Game is a draw!", "Game Over", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}