using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace WordGuessing
{
    public partial class Label1 : Form
    {

        List<string> words = new List<string>
        { "computer", "science", "information", "technology", "programming", "digital", "monitor", "keyboard"};
        string newText;
        string guessword;
        int x = 0;

        public Label1()
        {
            InitializeComponent();
            setup();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            StringBuilder list = new StringBuilder(text);

            textBox1.Clear();

            if (words[x].ToLower() == text.ToLower()) {
                if (x < words.Count - 1)
                {
                MessageBox.Show("Your answer " + textBox1.Text + " is correct!");
                    text = "";
                    x += 1;
                    newText = Scramble(words[x]);
                    WordIdentifier.Text = newText;

                }

                else
                {
                    textBox1.Text = "you guess it all!";
                    WordIdentifier.Text = "XP";
                    MessageBox.Show("You have finish the game Congratulation!");
                    return;
                }
            }
            else if (guessword.ToLower() != text.ToLower())
            {
                MessageBox.Show("Your guess wrong: " + text + "\nTry Again.");
                listBox1.Items.Add(list);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void setup()
        {
                guessword = words[x];

                string gw = guessword;
                newText = Scramble(gw);
                WordIdentifier.Text = newText;
                


        }

        public String Scramble(String text)
        {
            return new string(text.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        private void cheat_Click(object sender, EventArgs e)
        {
            
            foreach (var item in words)
            {
                StringBuilder cheat = new StringBuilder(item);
                listBox2.Items.Add(cheat);
            }

            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
