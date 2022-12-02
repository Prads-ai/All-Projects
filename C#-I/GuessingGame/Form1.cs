namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        int cpuGuess;
        int userGuess;
        int attempt = 0;
        public GuessingGame()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            loadGame();
            processGame(userGuess);
        }
        /* This method initialize the basic control needed to play the game. 
         *It also accept and convert the user input to an integer. 
         */
        public void loadGame() {
        
            userGuessInput.Enabled = true;
            userGuessInput.Focus();
            string input = userGuessInput.Text;
            userGuess = Int32.Parse(input);
            startBtn.Enabled = false;
        
        }
      // This method generate a random number between 1 to 100 and return an integer.
        public int computerGuess() { 
        
            Random rand = new Random();
            cpuGuess = rand.Next(1, 100);
            return cpuGuess;
        }
        // This method check the match between the user input and the random number chosen by the cpu.
        public void processGame(int userGuess) {

            cpuGuess = computerGuess();
            if (userGuess == cpuGuess)
            {
                MessageBox.Show("You won !" + cpuGuess.ToString());
                attempt = 0;
            }
            else {
            
                MessageBox.Show($"You lost the cpu guess was {cpuGuess}");
                userGuessInput.Text = "";
                startBtn.Text = "Guess Again";
                showOrHide();
                attempt++;
                totalAttemptLbl.Text ="Total Attempt(s) : " +  attempt.ToString();
            }
        }
        private void GuessingGame_Load(object sender, EventArgs e)
        {
                startBtn.Enabled = false;
        }
       // This method blocks the user from pressing the guess button before entering a value.
        public void showOrHide() {
            if (userGuessInput.Text.Length != 0)
            {
                startBtn.Enabled = true;
            }
            else
            {
                startBtn.Enabled = false;
            }
        }
        private void userGuessInput_TextChanged(object sender, EventArgs e)
        {
            showOrHide();
        }
    }
}
