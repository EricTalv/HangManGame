using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class Form1 : Form
    {


        //List all pictures
        enum HangState
        {
            Waiting,
            Pillar,
            Rope,
            Head,
            Body,
            RightLeg,
            LeftLeg,
            LeftHand,
            RightHand,
            Lost,
            Win,
        }

        // Holds currnent word characters
        List<Label> labels = new List<Label>();
        // Word under consideration
        public string currentWord { get; set; }
        // Default character for hidden word letters
        public string DefaultChar { get { return "__"; } }
        // Current hangstate, used specially to repaint panel grphics
        private HangState CurrentHangState = HangState.Waiting;
        // HangState enum size
        public int HangStateSize { get { return (Enum.GetValues(typeof(HangState)).Length - 1); } }
        //Set Alphabet array
        string Alphabet = "ABCDEFGHIJKLMNOPQRSŠZŽTUVWÕÄÖÜXY";
        //Wins
        int Wins = 0;
        //Losts
        int Lost = 0;

        public Form1()
        {
            InitializeComponent();

            KeyBoard();
       
        }

        private void B_StartGame_Click(object sender, EventArgs e)
        {
            //if (P_KeyBoard.Enabled)
            //    if (MessageBox.Show("Game in progress, wanna start again?", "Game in progress", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            //        return;

            P_KeyBoard.Enabled = true;
            ResetControls();
            ReadWords();
            AddLabels();
        }

        private void KeyBoard()
        {
            Button[] KeyboardButtons = new Button[32];
            int buttonsPerLine = 8;
            int buttonsPerRow = 4;

            double ButtonWidth = P_KeyBoard.Width / buttonsPerLine;
            ButtonWidth = Math.Floor(ButtonWidth);

            double ButtonHeight = P_KeyBoard.Height / buttonsPerRow;
            ButtonHeight = Math.Floor(ButtonHeight);

            int topAmount = 0;
            int leftAmount = Convert.ToInt32(ButtonWidth);

            int j = 0;
            for (int i = 0; i < KeyboardButtons.Length; i++)
            {
                if (j >= buttonsPerLine)
                {
                    topAmount += Convert.ToInt32(ButtonHeight);
                    j = 0;
                }
                KeyboardButtons[i] = new Button()
                {
                    Width = Convert.ToInt32(ButtonWidth),
                    Height = Convert.ToInt32(ButtonHeight),
                    Top = topAmount,
                    Left = leftAmount * j,
                    Text = i.ToString(),
                    BackColor = Color.WhiteSmoke
                };
                KeyboardButtons[i].Click += ClickFunctions_Click;
                P_KeyBoard.Controls.Add(KeyboardButtons[i]);
                j++;
            }
            for (int i = 0; i < KeyboardButtons.Length; i++)
            {
                KeyboardButtons[i].Text = Alphabet[i].ToString();
            }

            P_KeyBoard.Enabled = false;

        }

        private void ClickFunctions_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            char charClicked = b.Text.ToCharArray()[0];
            b.Enabled = false;

            if ((currentWord = currentWord.ToUpper()).Contains(charClicked))
            {
                // char is there (right guess)
                L_Info.Text = "Hea Valik!";
                L_Info.ForeColor = Color.Green;
                b.BackColor = Color.LawnGreen;
                char[] charArray = currentWord.ToCharArray();
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (charArray[i] == charClicked)
                        labels[i].Text = charClicked.ToString();
                }

                // Winning condition               
                if (labels.Where(x => x.Text.Equals(DefaultChar)).Any())
                    return;

                CurrentHangState = HangState.Win;
                Wins++;
                L_Wins.Text = Wins.ToString();
                L_Info.ForeColor = Color.Green;
                L_Info.Text = "Võitsid!";
                P_KeyBoard.Enabled = false;

            }
            else
            {
                //WrongGuess
                L_Info.Text = "Halb Valik...";
                L_Info.ForeColor = Color.Maroon;
                b.BackColor = Color.Red;
                if (CurrentHangState != HangState.Lost)
                    CurrentHangState++;
                L_TryCount.Text = (HangStateSize - (int)CurrentHangState).ToString();
                L_WrongCount.Text += string.IsNullOrWhiteSpace(L_WrongCount.Text) ? charClicked.ToString() : "," + charClicked;
                L_WrongCount.ForeColor = Color.Red;

                PBX_Pics.Invalidate();

                if (CurrentHangState == HangState.Lost)
                {
                    Lost++;
                    L_Lost.Text = Lost.ToString();
                    L_Info.Text = "Kaotasid...";
                    L_Info.ForeColor = Color.Maroon;
                    P_KeyBoard.Enabled = false;

                    //Reveal the word
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (labels[i].Text.Equals(DefaultChar))
                        {
                            labels[i].Text = currentWord[i].ToString();
                            labels[i].ForeColor = Color.Red;
                        }
                    }
                }
            }


        }

        private void ResetControls()
        {

            P_KeyBoard.Controls.Clear();
            KeyBoard();
            CurrentHangState = HangState.Waiting;
            PBX_Pics.Invalidate();
            L_WrongCount.Text = "";
            L_Info.Text = "";
            P_KeyBoard.Enabled = true;
        }

        private void AddLabels()
        {
            // Adding word to labels and labels to panel
            P_LabelPanel.Controls.Clear();
            labels.Clear();
            char[] wordChars = currentWord.ToCharArray();
            int len = wordChars.Length;
            int refer = P_LabelPanel.Width / len;
            for (int i = 0; i < len; i++)
            {
                Label l = new Label();
                l.Text = DefaultChar;
                l.Location = new Point(10 + i * refer, P_LabelPanel.Height - 30);
                l.Parent = P_LabelPanel;
                l.Font = new Font(FontFamily.GenericMonospace, 15, FontStyle.Italic | FontStyle.Bold);
                l.BringToFront();
                labels.Add(l);
            }

            // Writing text boxes 
            L_WordLength.Text = len.ToString();
            L_TryCount.Text = HangStateSize.ToString();

        }

        private void ReadWords()
        {
            string filePath = Path.Combine(Path.GetDirectoryName
            (System.Reflection.Assembly.GetExecutingAssembly().Location), "Words.txt");
            using (TextReader tr = new StreamReader(filePath, Encoding.ASCII))
            {
                Random r = new Random();
                var allWords = tr.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                currentWord = allWords[r.Next(0, allWords.Length - 1)]; // currentWord is public variable
            }
        }

        private void ReportStatus(string StatusMessage)
        {
            if ((StatusMessage != null) && (StatusMessage != String.Empty))
            {
                SSL_Status.Text = StatusMessage;
            }
        }

        private void PBX_Pics_Paint(object sender, PaintEventArgs e)
        {
            if (CurrentHangState >= HangState.Waiting)
            {
                PBX_Pics.Image = Properties.Resources.WaitingPlate;
            }

            if (CurrentHangState >= HangState.Pillar)
            {
                PBX_Pics.Image = HangManGame.Properties.Resources.NewFirst;
            }

            if (CurrentHangState >= HangState.Rope)
            {
                PBX_Pics.Image = Properties.Resources.NewSecond;
            }

            if (CurrentHangState >= HangState.Head)
            {
                PBX_Pics.Image = Properties.Resources.NewThird;
            }

            if (CurrentHangState >= HangState.Body)
            {
                PBX_Pics.Image = Properties.Resources.NewFourth;
            }

            if (CurrentHangState >= HangState.RightLeg)
            {
                PBX_Pics.Image = Properties.Resources.NewFifth;

            }

            if (CurrentHangState >= HangState.LeftLeg)
            {
                PBX_Pics.Image = Properties.Resources.NewSixth;
            }

            if (CurrentHangState >= HangState.LeftHand)
            {
                PBX_Pics.Image = Properties.Resources.NewSeventh;
            }

            if (CurrentHangState >= HangState.RightHand)
            {
                PBX_Pics.Image = Properties.Resources.NewEigth;
            }

            if (CurrentHangState >= HangState.Lost)
            {
                PBX_Pics.Image = Properties.Resources.NewNineth;
            }

            if (CurrentHangState >= HangState.Win)
            {
                PBX_Pics.Image = Properties.Resources.NewTenth;
            }
        }

        private void SSL_RevealWord_Click(object sender, EventArgs e)
        {
            if (SSL_RevealWord.Text == "Show Word")
            {
                SSL_RevealWord.Text = currentWord;
            }
            else
            {
                SSL_RevealWord.Text = "Show Word";
            }
        }

        private void SSL_HangState_Click(object sender, EventArgs e)
        {

        }
    }
}

