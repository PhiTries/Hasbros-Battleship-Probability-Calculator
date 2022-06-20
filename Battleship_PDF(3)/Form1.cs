namespace Battleship_PDF_3_
{
    public partial class Form1 : Form
    {
        public string[] names = {"uxA1", "uxA2", "uxA3", "uxA4", "uxA5", "uxA6", "uxA7", "uxA8", "uxA9", "uxA10",
                                 "uxB1", "uxB2", "uxB3", "uxB4", "uxB5", "uxB6", "uxB7", "uxB8", "uxB9", "uxB10",
                                 "uxC1", "uxC2", "uxC3", "uxC4", "uxC5", "uxC6", "uxC7", "uxC8", "uxC9", "uxC10",
                                 "uxD1", "uxD2", "uxD3", "uxD4", "uxD5", "uxD6", "uxD7", "uxD8", "uxD9", "uxD10",
                                 "uxE1", "uxE2", "uxE3", "uxE4", "uxE5", "uxE6", "uxE7", "uxE8", "uxE9", "uxE10",
                                 "uxF1", "uxF2", "uxF3", "uxF4", "uxF5", "uxF6", "uxF7", "uxF8", "uxF9", "uxF10",
                                 "uxG1", "uxG2", "uxG3", "uxG4", "uxG5", "uxG6", "uxG7", "uxG8", "uxG9", "uxG10",
                                 "uxH1", "uxH2", "uxH3", "uxH4", "uxH5", "uxH6", "uxH7", "uxH8", "uxH9", "uxH10",
                                 "uxI1", "uxI2", "uxI3", "uxI4", "uxI5", "uxI6", "uxI7", "uxI8", "uxI9", "uxI10",
                                 "uxJ1", "uxJ2", "uxJ3", "uxJ4", "uxJ5", "uxJ6", "uxJ7", "uxJ8", "uxJ9", "uxJ10"};

        public string[] namesSimple = {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10",
                                       "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10",
                                       "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10",
                                       "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10",
                                       "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10",
                                       "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
                                       "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10",
                                       "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10",
                                       "I1", "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "I10",
                                       "J1", "J2", "J3", "J4", "J5", "J6", "J7", "J8", "J9", "J10"};

        public string[] oddParity = {"A1", "A3", "A5", "A7", "A9", "B2", "B4", "B6", "B8", "B10", "C1", "C3", "C5",
                                     "C7", "C9", "D2", "D4", "D6", "D8", "D10", "E1", "E3", "E5", "E7", "E9", "F2",
                                     "F4", "F6", "F8", "F10", "G1", "G3", "G5", "G7", "G9", "H2", "H4", "H6", "H8",
                                     "H10", "I1", "I3", "I5", "I7", "I9", "J2", "J4", "J6", "J8", "J10"};

        public string[] evenParity = {"A2", "A4", "A6", "A8", "A10", "B1", "B3", "B5", "B7", "B9", "C2", "C4", "C6",
                                      "C8", "C10", "D1", "D3", "D5", "D7", "D9", "E2", "E4", "E6", "E8", "E10", "F1",
                                      "F3", "F5", "F7", "F9", "G2", "G4", "G6", "G8", "G10", "H1", "H3", "H5", "H7", 
                                      "H9", "I2", "I4", "I6", "I8", "I10", "J1", "J3", "J5", "J7", "J9"};

        public string[] three1Parity = {"A1", "A4", "A7", "A10", "B2", "B5", "B8", "C3", "C6", "C9",
                                        "D1", "D4", "D7", "D10", "E2", "E5", "E8", "F3", "F6", "F9",
                                        "G1", "G4", "G7", "G10", "H2", "H5", "H8", "I3", "I6", "I9",
                                        "J1", "J4", "J7", "J10"};

        public string[] three2Parity = {"A2", "A5", "A8", "B3", "B6", "B9", "C1", "C4", "C7", "C10",
                                        "D2", "D5", "D8", "E3", "E6", "E9", "F1", "F4", "F7", "F10",
                                        "G2", "G5", "G8", "H3", "H6", "H9", "I1", "I4", "I7", "I10",
                                        "J2", "J5", "J8"};

        public string[] three3Parity = {"A1", "A4", "A7", "A10", "B3", "B6", "B9", "C2", "C5", "C8",
                                        "D1", "D4", "D7", "D10", "E3", "E6", "E9", "F2", "F5", "F8",
                                        "G1", "G4", "G7", "G10", "H3", "H6", "H9", "I2", "I5", "I8",
                                        "J1", "J4", "J7", "J10"};

        public string[] three4Parity = {"A2", "A5", "A8", "B1", "B4", "B7", "B10", "C3", "C6", "C9",
                                        "D2", "D5", "D8", "E1", "E4", "E7", "E10", "F3", "F6", "F9",
                                        "G2", "G5", "G8", "H1", "H4", "H7", "H10", "I3", "I6", "I9",
                                        "J2", "J5", "J8"};
        public int[,] data { get; set; } = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }};
        public int[,] PDF { get; set; } = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }};
        public int[,] Hit { get; set; } = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }};

        public bool parityTrue = false;
        public bool hitTrue = false;
        public bool toggleOn = false;
        public enum ParityType {Odd, Even, Hit, Special, None, three1, three2, three3, three4};
        public ParityType state = ParityType.None;

        public enum ComanderState {w, j, a, f, g, s, e, c, none};
        public ComanderState com = ComanderState.none;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string str = b.Text;
            string name = b.Name;
            string sname = name.Remove(0, 2);

            if(parityTrue == false)
            {
                parityTrue = true;
                foreach(string s in oddParity)
                {
                    if (name.Contains(s))
                    {
                        state = ParityType.Odd;
                        break;
                    }
                    else
                        state = ParityType.Even;
                }
                BoardColor_Update();
            } // determins pairity for the rest of game
            if (str == "\r\n" || str == "") 
            {
                int num = Int32.Parse(sname.Remove(0, 1)) - 1;
                char c = sname.Remove(1, 1).ToCharArray()[0];
                int num2 = c - 65;
                data[num, num2] = 1;
                b.Text = "X";
                if (state == ParityType.Odd && oddParity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.Even && evenParity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if(state == ParityType.three1 && three1Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three2 && three2Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three3 && three3Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three4 && three4Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else
                    b.BackColor = Color.LightGray;
            } // Colors buttons acording to active parity
            if (str == "X")
            {
                int num = Int32.Parse(sname.Remove(0, 1)) - 1;
                char c = sname.Remove(1, 1).ToCharArray()[0];
                int num2 = c - 65;
                data[num, num2] = 0;
                Hit[num, num2] = 1;


                b.Text = "O";
                b.BackColor = Color.Red;
            }
            if (str == "O")
            {
                int num = Int32.Parse(sname.Remove(0, 1)) - 1;
                char c = sname.Remove(1, 1).ToCharArray()[0];
                int num2 = c - 65;
                data[num, num2] = 1;
                Hit[num, num2] = 0; //no longer an active 'hit'

                b.Text = "S";

            }
            if(str == "S")
            {
                int num = Int32.Parse(sname.Remove(0, 1)) - 1;
                char c = sname.Remove(1, 1).ToCharArray()[0];
                int num2 = c - 65;
                data[num, num2] = 0;
                b.Text = "";

                //recolors square
                if (state == ParityType.Odd && oddParity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.Even && evenParity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three1 && three1Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three2 && three2Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three3 && three3Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else if (state == ParityType.three4 && three4Parity.Contains(sname))
                {
                    b.BackColor = Color.CornflowerBlue;
                }
                else
                    b.BackColor = Color.LightGray;

                /*
                 * change data[] to 1 here
                 * 
                 */
            }
            Calculate_PDF();
            //Show_Msg();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            parityTrue = false;
            state = ParityType.None;

            ToolStripMenuItem b = (ToolStripMenuItem)sender;
            string map = b.Name;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    data[i, j] = 0;
                }
            }

            switch (map)
            {
                case "classic":
                    break;

                case "montevideo":
                    data[4, 0] = data[5, 0] = data[6, 0] = data[7, 0] = data[8, 0] = data[9, 0] = 1;
                    data[5, 1] = data[6, 1] = data[7, 1] = data[8, 1] = data[9, 1] = 1;
                    data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = 1;
                    data[7, 6] = data[8, 6] = data[9, 6] = data[7, 7] = data[8, 7] = data[9, 7] = 1;
                    data[5, 8] = data[6, 8] = data[7, 8] = data[8, 8] = data[9, 8] = 1;
                    data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = data[9, 9] = 1;
                    break;

                case "maunsellForts":
                    data[9, 0] = data[9, 1] = data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = data[9, 6] = data[9, 7] = data[9, 8] = data[9, 9] = 1;
                    data[0, 0] = data[7, 0] = data[8, 0] = data[0, 1] = data[8, 1] = data[8, 2] = data[8, 3] = data[8, 4] = data[8, 5] = 1;
                    data[0, 6] = data[0, 7] = data[1, 7] = data[2, 7] = data[3, 7] = data[0, 8] = data[1, 8] = data[2, 8] = data[3, 8] = 1;
                    data[0, 9] = data[1, 9] = data[2, 9] = data[3, 9] = data[4, 9] = data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = 1;
                    break;

                case "balticSea":
                    data[9, 0] = data[9, 1] = data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = data[9, 6] = data[9, 7] = data[9, 8] = data[9, 9] = 1;
                    data[0, 0] = data[1, 0] = data[2, 0] = data[3, 0] = data[4, 0] = data[0, 1] = data[7, 6] = data[8, 6] = data[7, 7] = data[8, 7] = 1;
                    data[4, 8] = data[5, 8] = data[6, 8] = data[7, 8] = data[8, 8] = data[3, 9] = data[4, 9] = data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = 1;
                    break;

                case "straitOfGibralter":
                    data[9, 0] = data[9, 1] = data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = data[9, 6] = data[9, 7] = data[9, 8] = data[9, 9] = 1;
                    data[0, 9] = data[1, 9] = data[2, 9] = data[3, 9] = data[4, 9] = data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = 1;
                    data[8, 0] = data[8, 1] = data[8, 2] = data[6, 3] = data[7, 3] = data[8, 3] = data[5, 4] = data[6, 4] = data[7, 4] = data[8, 4] = 1;
                    data[7, 5] = data[8, 5] = 1;
                    break;

                case "fortStAngelo":
                    data[9, 0] = data[9, 1] = data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = data[9, 6] = data[9, 7] = data[9, 8] = data[9, 9] = 1;
                    data[0, 9] = data[1, 9] = data[2, 9] = data[3, 9] = data[4, 9] = data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = 1;
                    data[0, 0] = data[1, 0] = data[4, 3] = data[5, 3] = data[4, 4] = data[5, 4] = data[3, 8] = data[4, 8] = data[5, 8] = data[6, 8] = data[7, 8] = data[8, 8] = 1;
                    break;

                case "whiteCliffsOfDover":
                    data[9, 0] = data[9, 1] = data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = data[9, 6] = data[9, 7] = data[9, 8] = data[9, 9] = 1;
                    data[0, 9] = data[1, 9] = data[2, 9] = data[3, 9] = data[4, 9] = data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = 1;
                    data[3, 0] = data[4, 0] = data[5, 0] = data[0, 3] = data[8, 3] = data[0, 4] = data[8, 4] = data[0, 5] = data[8, 5] = data[3, 8] = data[4, 8] = data[5, 8] = 1;
                    break;

                case "colossusBay":
                    data[9, 0] = data[9, 1] = data[9, 2] = data[9, 3] = data[9, 4] = data[9, 5] = data[9, 6] = data[9, 7] = data[9, 8] = data[9, 9] = 1;
                    data[0, 9] = data[1, 9] = data[2, 9] = data[3, 9] = data[4, 9] = data[5, 9] = data[6, 9] = data[7, 9] = data[8, 9] = 1;
                    data[0, 0] = data[1, 0] = data[5, 0] = data[6, 0] = data[7, 0] = data[8, 0] = data[0, 1] = data[6, 1] = data[7, 1] = data[8, 1] = 1;
                    data[0, 2] = data[8, 2] = 1;
                    break;
            }

            BoardMarked_Update();
        }
        private void Comander_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem b = (ToolStripMenuItem)sender;
            string comander = b.Name;
            Ship1.Enabled = true;
            Ship2.Enabled = true;
            Ship3.Enabled = true;
            Ship4.Enabled = true;
            Ship5.Enabled = true;
            Ship1.BackColor = Color.Transparent;
            Ship2.BackColor = Color.Transparent;
            Ship3.BackColor = Color.Transparent;
            Ship4.BackColor = Color.Transparent;
            Ship5.BackColor = Color.Transparent;

            switch (comander)
            {
                case "williamKarslake":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a3;
                    Ship4.Image = Properties.Resources.a4;
                    Ship5.Image = Properties.Resources.a5;
                    com = ComanderState.w;
                    break;

                case "johannesSchmidt":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a3;
                    Ship4.Image = Properties.Resources.a15;
                    Ship5.Image = Properties.Resources.a16;
                    com = ComanderState.j;
                    break;

                case "astridStormur":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a12;
                    Ship4.Image = Properties.Resources.a13;
                    Ship5.Image = Properties.Resources.a14;
                    com = ComanderState.a;
                    break;

                case "frenchGuy":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a12;
                    Ship4.Image = Properties.Resources.a10;
                    Ship5.Image = Properties.Resources.a11;
                    com = ComanderState.f;
                    break;

                case "giuseppeFerrara":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a3;
                    Ship4.Image = Properties.Resources.a8;
                    Ship5.Image = Properties.Resources.a9;
                    com = ComanderState.g;
                    break;

                case "sirPhillipWade":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a3;
                    Ship4.Image = Properties.Resources.a6;
                    Ship5.Image = Properties.Resources.a7;
                    com = ComanderState.s;
                    break;

                case "euryleia":
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a2;
                    Ship3.Image = Properties.Resources.a3;
                    Ship4.Image = Properties.Resources.a4;
                    Ship5.Image = Properties.Resources.a1;
                    com = ComanderState.e;
                    break;

                default:
                    Ship1.Image = Properties.Resources.a2;
                    Ship2.Image = Properties.Resources.a12;
                    Ship3.Image = Properties.Resources.a12;
                    Ship4.Image = Properties.Resources.a8;
                    Ship5.Image = Properties.Resources.a1;
                    com = ComanderState.c;
                    break;

            }//loads images currently (needs to load ships too)
        }
        public void BoardColor_Update() // will be used to update the color for pdf
        {
            if (state == ParityType.Odd)
            {
                foreach (string s in oddParity)
                {
                    switch (s)
                    {
                        case "A1":
                            if (data[0, 0] != 1 && Hit[0, 0] != 1)
                                uxA1.BackColor = Color.CornflowerBlue;
                            break;
                        case "A3":
                            if (data[2, 0] != 1 && Hit[2, 0] != 1)
                                uxA3.BackColor = Color.CornflowerBlue;
                            break;
                        case "A5":
                            if (data[4, 0] != 1 && Hit[4, 0] != 1)
                                uxA5.BackColor = Color.CornflowerBlue;
                            break;
                        case "A7":
                            if (data[6, 0] != 1 && Hit[6, 0] != 1)
                                uxA7.BackColor = Color.CornflowerBlue;
                            break;
                        case "A9":
                            if (data[8, 0] != 1 && Hit[8, 0] != 1)
                                uxA9.BackColor = Color.CornflowerBlue;
                            break;

                        case "B2":
                            if (data[1, 1] != 1 && Hit[1, 1] != 1)
                                uxB2.BackColor = Color.CornflowerBlue;
                            break;
                        case "B4":
                            if (data[3, 1] != 1 && Hit[3, 1] != 1)
                                uxB4.BackColor = Color.CornflowerBlue;
                            break;
                        case "B6":
                            if (data[5, 1] != 1 && Hit[5, 1] != 1)
                                uxB6.BackColor = Color.CornflowerBlue;
                            break;
                        case "B8":
                            if (data[7, 1] != 1 && Hit[7, 1] != 1)
                                uxB8.BackColor = Color.CornflowerBlue;
                            break;
                        case "B10":
                            if (data[9, 1] != 1 && Hit[9, 1] != 1)
                                uxB10.BackColor = Color.CornflowerBlue;
                            break;

                        case "C1":
                            if (data[0, 2] != 1 && Hit[0, 2] != 1)
                                uxC1.BackColor = Color.CornflowerBlue;
                            break;
                        case "C3":
                            if (data[2, 2] != 1 && Hit[2, 2] != 1)
                                uxC3.BackColor = Color.CornflowerBlue;
                            break;
                        case "C5":
                            if (data[4, 2] != 1 && Hit[4, 2] != 1)
                                uxC5.BackColor = Color.CornflowerBlue;
                            break;
                        case "C7":
                            if (data[6, 2] != 1 && Hit[6, 2] != 1)
                                uxC7.BackColor = Color.CornflowerBlue;
                            break;
                        case "C9":
                            if (data[8, 2] != 1 && Hit[8, 2] != 1)
                                uxC9.BackColor = Color.CornflowerBlue;
                            break;

                        case "D2":
                            if (data[1, 3] != 1 && Hit[1, 3] != 1)
                                uxD2.BackColor = Color.CornflowerBlue;
                            break;
                        case "D4":
                            if (data[3, 3] != 1 && Hit[3, 3] != 1)
                                uxD4.BackColor = Color.CornflowerBlue;
                            break;
                        case "D6":
                            if (data[5, 3] != 1 && Hit[5, 3] != 1)
                                uxD6.BackColor = Color.CornflowerBlue;
                            break;
                        case "D8":
                            if (data[7, 3] != 1 && Hit[7, 3] != 1)
                                uxD8.BackColor = Color.CornflowerBlue;
                            break;
                        case "D10":
                            if (data[9, 3] != 1 && Hit[9, 3] != 1)
                                uxD10.BackColor = Color.CornflowerBlue;
                            break;

                        case "E1":
                            if (data[0, 4] != 1 && Hit[0, 4] != 1)
                                uxE1.BackColor = Color.CornflowerBlue;
                            break;
                        case "E3":
                            if (data[2, 4] != 1 && Hit[2, 4] != 1)
                                uxE3.BackColor = Color.CornflowerBlue;
                            break;
                        case "E5":
                            if (data[4, 4] != 1 && Hit[4, 4] != 1)
                                uxE5.BackColor = Color.CornflowerBlue;
                            break;
                        case "E7":
                            if (data[6, 4] != 1 && Hit[6, 4] != 1)
                                uxE7.BackColor = Color.CornflowerBlue;
                            break;
                        case "E9":
                            if (data[8, 4] != 1 && Hit[8, 4] != 1)
                                uxE9.BackColor = Color.CornflowerBlue;
                            break;

                        case "F2":
                            if (data[1, 5] != 1 && Hit[1, 5] != 1)
                                uxF2.BackColor = Color.CornflowerBlue;
                            break;
                        case "F4":
                            if (data[3, 5] != 1 && Hit[3, 5] != 1)
                                uxF4.BackColor = Color.CornflowerBlue;
                            break;
                        case "F6":
                            if (data[5, 5] != 1 && Hit[5, 5] != 1)
                                uxF6.BackColor = Color.CornflowerBlue;
                            break;
                        case "F8":
                            if (data[7, 5] != 1 && Hit[7, 5] != 1)
                                uxF8.BackColor = Color.CornflowerBlue;
                            break;
                        case "F10":
                            if (data[9, 5] != 1 && Hit[9, 5] != 1)
                                uxF10.BackColor = Color.CornflowerBlue;
                            break;

                        case "G1":
                            if (data[0, 6] != 1 && Hit[0, 6] != 1)
                                uxG1.BackColor = Color.CornflowerBlue;
                            break;
                        case "G3":
                            if (data[2, 6] != 1 && Hit[2, 6] != 1)
                                uxG3.BackColor = Color.CornflowerBlue;
                            break;
                        case "G5":
                            if (data[4, 6] != 1 && Hit[4, 6] != 1)
                                uxG5.BackColor = Color.CornflowerBlue;
                            break;
                        case "G7":
                            if (data[6, 6] != 1 && Hit[6, 6] != 1)
                                uxG7.BackColor = Color.CornflowerBlue;
                            break;
                        case "G9":
                            if (data[8, 6] != 1 && Hit[8, 6] != 1)
                                uxG9.BackColor = Color.CornflowerBlue;
                            break;

                        case "H2":
                            if (data[1, 7] != 1 && Hit[1, 7] != 1)
                                uxH2.BackColor = Color.CornflowerBlue;
                            break;
                        case "H4":
                            if (data[3, 7] != 1 && Hit[3, 7] != 1)
                                uxH4.BackColor = Color.CornflowerBlue;
                            break;
                        case "H6":
                            if (data[5, 7] != 1 && Hit[5, 7] != 1)
                                uxH6.BackColor = Color.CornflowerBlue;
                            break;
                        case "H8":
                            if (data[7, 7] != 1 && Hit[7, 7] != 1)
                                uxH8.BackColor = Color.CornflowerBlue;
                            break;
                        case "H10":
                            if (data[9, 7] != 1 && Hit[9, 7] != 1)
                                uxH10.BackColor = Color.CornflowerBlue;
                            break;

                        case "I1":
                            if (data[0, 8] != 1 && Hit[0, 8] != 1)
                                uxI1.BackColor = Color.CornflowerBlue;
                            break;
                        case "I3":
                            if (data[2, 8] != 1 && Hit[2, 8] != 1)
                                uxI3.BackColor = Color.CornflowerBlue;
                            break;
                        case "I5":
                            if (data[4, 8] != 1 && Hit[4, 8] != 1)
                                uxI5.BackColor = Color.CornflowerBlue;
                            break;
                        case "I7":
                            if (data[6, 8] != 1 && Hit[6, 8] != 1)
                                uxI7.BackColor = Color.CornflowerBlue;
                            break;
                        case "I9":
                            if (data[8, 8] != 1 && Hit[8, 8] != 1)
                                uxI9.BackColor = Color.CornflowerBlue;
                            break;

                        case "J2":
                            if (data[1, 9] != 1 && Hit[1, 9] != 1)
                                uxJ2.BackColor = Color.CornflowerBlue;
                            break;
                        case "J4":
                            if (data[3, 9] != 1 && Hit[3, 9] != 1)
                                uxJ4.BackColor = Color.CornflowerBlue;
                            break;
                        case "J6":
                            if (data[5, 9] != 1 && Hit[5, 9] != 1)
                                uxJ6.BackColor = Color.CornflowerBlue;
                            break;
                        case "J8":
                            if (data[7, 9] != 1 && Hit[7, 9] != 1)
                                uxJ8.BackColor = Color.CornflowerBlue;
                            break;
                        case "J10":
                            if (data[9, 9] != 1 && Hit[9, 9] != 1)
                                uxJ10.BackColor = Color.CornflowerBlue;
                            break;
                    }
                }
            }
            else if(state == ParityType.Even)
            {
                foreach (string s in evenParity)
                {
                    
                    switch (s)
                    {
                        case "A2":
                            if (data[1, 0] != 1 && Hit[1, 0] != 1)
                                uxA2.BackColor = Color.CornflowerBlue;
                            break;
                        case "A4":
                            if (data[3, 0] != 1 && Hit[3, 0] != 1)
                                uxA4.BackColor = Color.CornflowerBlue;
                            break;
                        case "A6":
                            if (data[5, 0] != 1 && Hit[5, 0] != 1)
                                uxA6.BackColor = Color.CornflowerBlue;
                            break;
                        case "A8":
                            if (data[7, 0] != 1 && Hit[7, 0] != 1)
                                uxA8.BackColor = Color.CornflowerBlue;
                            break;
                        case "A10":
                            if (data[9, 0] != 1 && Hit[9, 0] != 1)
                                uxA10.BackColor = Color.CornflowerBlue;
                            break;

                        case "B1":
                            if (data[0, 1] != 1 && Hit[0, 1] != 1)
                                uxB1.BackColor = Color.CornflowerBlue;
                            break;
                        case "B3":
                            if (data[2, 1] != 1 && Hit[2, 1] != 1)
                                uxB3.BackColor = Color.CornflowerBlue;
                            break;
                        case "B5":
                            if (data[4, 1] != 1 && Hit[4, 1] != 1)
                                uxB5.BackColor = Color.CornflowerBlue;
                            break;
                        case "B7":
                            if (data[6, 1] != 1 && Hit[6, 1] != 1)
                                uxB7.BackColor = Color.CornflowerBlue;
                            break;
                        case "B9":
                            if (data[8, 1] != 1 && Hit[8, 1] != 1)
                                uxB9.BackColor = Color.CornflowerBlue;
                            break;

                        case "C2":
                            if (data[1, 2] != 1 && Hit[1, 2] != 1)
                                uxC2.BackColor = Color.CornflowerBlue;
                            break;
                        case "C4":
                            if (data[3, 2] != 1 && Hit[3, 2] != 1)
                                uxC4.BackColor = Color.CornflowerBlue;
                            break;
                        case "C6":
                            if (data[5, 2] != 1 && Hit[5, 2] != 1)
                                uxC6.BackColor = Color.CornflowerBlue;
                            break;
                        case "C8":
                            if (data[7, 2] != 1 && Hit[7, 2] != 1)
                                uxC8.BackColor = Color.CornflowerBlue;
                            break;
                        case "C10":
                            if (data[9, 2] != 1 && Hit[9, 2] != 1)
                                uxC10.BackColor = Color.CornflowerBlue;
                            break;

                        case "D1":
                            if (data[0, 3] != 1 && Hit[0, 3] != 1)
                                uxD1.BackColor = Color.CornflowerBlue;
                            break;
                        case "D3":
                            if (data[2, 3] != 1 && Hit[2, 3] != 1)
                                uxD3.BackColor = Color.CornflowerBlue;
                            break;
                        case "D5":
                            if (data[4, 3] != 1 && Hit[4, 3] != 1)
                                uxD5.BackColor = Color.CornflowerBlue;
                            break;
                        case "D7":
                            if (data[6, 3] != 1 && Hit[6, 3] != 1)
                                uxD7.BackColor = Color.CornflowerBlue;
                            break;
                        case "D9":
                            if (data[8, 3] != 1 && Hit[8, 3] != 1)
                                uxD9.BackColor = Color.CornflowerBlue;
                            break;

                        case "E2":
                            if (data[1, 4] != 1 && Hit[1, 4] != 1)
                                uxE2.BackColor = Color.CornflowerBlue;
                            break;
                        case "E4":
                            if (data[3, 4] != 1 && Hit[3, 4] != 1)
                                uxE4.BackColor = Color.CornflowerBlue;
                            break;
                        case "E6":
                            if (data[5, 4] != 1 && Hit[5, 4] != 1)
                                uxE6.BackColor = Color.CornflowerBlue;
                            break;
                        case "E8":
                            if (data[7, 4] != 1 && Hit[7, 4] != 1)
                                uxE8.BackColor = Color.CornflowerBlue;
                            break;
                        case "E10":
                            if (data[9, 4] != 1 && Hit[9, 4] != 1)
                                uxE10.BackColor = Color.CornflowerBlue;
                            break;

                        case "F1":
                            if (data[0, 5] != 1 && Hit[0, 5] != 1)
                                uxF1.BackColor = Color.CornflowerBlue;
                            break;
                        case "F3":
                            if (data[2, 5] != 1 && Hit[2, 5] != 1)
                                uxF3.BackColor = Color.CornflowerBlue;
                            break;
                        case "F5":
                            if (data[4, 5] != 1 && Hit[4, 5] != 1)
                                uxF5.BackColor = Color.CornflowerBlue;
                            break;
                        case "F7":
                            if (data[6, 5] != 1 && Hit[6, 5] != 1)
                                uxF7.BackColor = Color.CornflowerBlue;
                            break;
                        case "F9":
                            if (data[8, 5] != 1 && Hit[8, 5] != 1)
                                uxF9.BackColor = Color.CornflowerBlue;
                            break;

                        case "G2":
                            if (data[1, 6] != 1 && Hit[1, 6] != 1)
                                uxG2.BackColor = Color.CornflowerBlue;
                            break;
                        case "G4":
                            if (data[3, 6] != 1 && Hit[3, 6] != 1)
                                uxG4.BackColor = Color.CornflowerBlue;
                            break;
                        case "G6":
                            if (data[5, 6] != 1 && Hit[5, 6] != 1)
                                uxG6.BackColor = Color.CornflowerBlue;
                            break;
                        case "G8":
                            if (data[7, 6] != 1 && Hit[7, 6] != 1)
                                uxG8.BackColor = Color.CornflowerBlue;
                            break;
                        case "G10":
                            if (data[9, 6] != 1 && Hit[9, 6] != 1)
                                uxG10.BackColor = Color.CornflowerBlue;
                            break;

                        case "H1":
                            if (data[0, 7] != 1 && Hit[0, 7] != 1)
                                uxH1.BackColor = Color.CornflowerBlue;
                            break;
                        case "H3":
                            if (data[2, 7] != 1 && Hit[2, 7] != 1)
                                uxH3.BackColor = Color.CornflowerBlue;
                            break;
                        case "H5":
                            if (data[4, 7] != 1 && Hit[4, 7] != 1)
                                uxH5.BackColor = Color.CornflowerBlue;
                            break;
                        case "H7":
                            if (data[6, 7] != 1 && Hit[6, 7] != 1)
                                uxH7.BackColor = Color.CornflowerBlue;
                            break;
                        case "H9":
                            if (data[8, 7] != 1 && Hit[8, 7] != 1)
                                uxH9.BackColor = Color.CornflowerBlue;
                            break;

                        case "I2":
                            if (data[1, 8] != 1 && Hit[1, 8] != 1)
                                uxI2.BackColor = Color.CornflowerBlue;
                            break;
                        case "I4":
                            if (data[3, 8] != 1 && Hit[3, 8] != 1)
                                uxI4.BackColor = Color.CornflowerBlue;
                            break;
                        case "I6":
                            if (data[5, 8] != 1 && Hit[5, 8] != 1)
                                uxI6.BackColor = Color.CornflowerBlue;
                            break;
                        case "I8":
                            if (data[7, 8] != 1 && Hit[7, 8] != 1)
                                uxI8.BackColor = Color.CornflowerBlue;
                            break;
                        case "I10":
                            if (data[9, 8] != 1 && Hit[9, 8] != 1)
                                uxI10.BackColor = Color.CornflowerBlue;
                            break;

                        case "J1":
                            if (data[0, 9] != 1 && Hit[0, 9] != 1)
                                uxJ1.BackColor = Color.CornflowerBlue;
                            break;
                        case "J3":
                            if (data[2, 9] != 1 && Hit[2, 9] != 1)
                                uxJ3.BackColor = Color.CornflowerBlue;
                            break;
                        case "J5":
                            if (data[4, 9] != 1 && Hit[4, 9] != 1)
                                uxJ5.BackColor = Color.CornflowerBlue;
                            break;
                        case "J7":
                            if (data[6, 9] != 1 && Hit[6, 9] != 1)
                                uxJ7.BackColor = Color.CornflowerBlue;
                            break;
                        case "J9":
                            if (data[8, 9] != 1 && Hit[8, 9] != 1)
                                uxJ9.BackColor = Color.CornflowerBlue;
                            break;
                    }

                }
            }
            else if (state == ParityType.three1)
            {
                foreach (string s in three1Parity)
                {

                    switch (s)
                    {
                        case "A1":
                            if (data[0, 0] != 1 && Hit[0, 0] != 1)
                                uxA1.BackColor = Color.CornflowerBlue;
                            break;
                        case "A4":
                            if (data[3, 0] != 1 && Hit[3, 0] != 1)
                                uxA4.BackColor = Color.CornflowerBlue;
                            break;
                        case "A7":
                            if (data[6, 0] != 1 && Hit[6, 0] != 1)
                                uxA7.BackColor = Color.CornflowerBlue;
                            break;
                        case "A10":
                            if (data[9, 0] != 1 && Hit[9, 0] != 1)
                                uxA10.BackColor = Color.CornflowerBlue;
                            break;

                        case "B2":
                            if (data[1, 1] != 1 && Hit[1, 1] != 1)
                                uxB2.BackColor = Color.CornflowerBlue;
                            break;
                        case "B5":
                            if (data[4, 1] != 1 && Hit[4, 1] != 1)
                                uxB5.BackColor = Color.CornflowerBlue;
                            break;
                        case "B8":
                            if (data[7, 1] != 1 && Hit[7, 1] != 1)
                                uxB8.BackColor = Color.CornflowerBlue;
                            break;

                        case "C3":
                            if (data[2, 2] != 1 && Hit[2, 2] != 1)
                                uxC3.BackColor = Color.CornflowerBlue;
                            break;
                        case "C6":
                            if (data[5, 2] != 1 && Hit[5, 2] != 1)
                                uxC6.BackColor = Color.CornflowerBlue;
                            break;
                        case "C9":
                            if (data[8, 2] != 1 && Hit[8, 2] != 1)
                                uxC9.BackColor = Color.CornflowerBlue;
                            break;

                        case "D1":
                            if (data[0, 3] != 1 && Hit[0, 3] != 1)
                                uxD1.BackColor = Color.CornflowerBlue;
                            break;
                        case "D4":
                            if (data[3, 3] != 1 && Hit[3, 3] != 1)
                                uxD4.BackColor = Color.CornflowerBlue;
                            break;
                        case "D7":
                            if (data[6, 3] != 1 && Hit[6, 3] != 1)
                                uxD7.BackColor = Color.CornflowerBlue;
                            break;
                        case "D10":
                            if (data[9, 3] != 1 && Hit[9, 3] != 1)
                                uxD10.BackColor = Color.CornflowerBlue;
                            break;

                        case "E2":
                            if (data[1, 4] != 1 && Hit[1, 4] != 1)
                                uxE2.BackColor = Color.CornflowerBlue;
                            break;
                        case "E5":
                            if (data[4, 4] != 1 && Hit[4, 4] != 1)
                                uxE5.BackColor = Color.CornflowerBlue;
                            break;
                        case "E8":
                            if (data[7, 4] != 1 && Hit[7, 4] != 1)
                                uxE8.BackColor = Color.CornflowerBlue;
                            break;

                        case "F3":
                            if (data[2, 5] != 1 && Hit[2, 5] != 1)
                                uxF3.BackColor = Color.CornflowerBlue;
                            break;
                        case "F6":
                            if (data[5, 5] != 1 && Hit[5, 5] != 1)
                                uxF6.BackColor = Color.CornflowerBlue;
                            break;
                        case "F9":
                            if (data[8, 5] != 1 && Hit[8, 5] != 1)
                                uxF9.BackColor = Color.CornflowerBlue;
                            break;

                        case "G1":
                            if (data[0, 6] != 1 && Hit[0, 6] != 1)
                                uxG1.BackColor = Color.CornflowerBlue;
                            break;
                        case "G4":
                            if (data[3, 6] != 1 && Hit[3, 6] != 1)
                                uxG4.BackColor = Color.CornflowerBlue;
                            break;
                        case "G7":
                            if (data[6, 6] != 1 && Hit[6, 6] != 1)
                                uxG7.BackColor = Color.CornflowerBlue;
                            break;
                        case "G10":
                            if (data[9, 6] != 1 && Hit[9, 6] != 1)
                                uxG10.BackColor = Color.CornflowerBlue;
                            break;

                        case "H2":
                            if (data[1, 7] != 1 && Hit[1, 7] != 1)
                                uxH2.BackColor = Color.CornflowerBlue;
                            break;
                        case "H5":
                            if (data[4, 7] != 1 && Hit[4, 7] != 1)
                                uxH5.BackColor = Color.CornflowerBlue;
                            break;
                        case "H8":
                            if (data[7, 7] != 1 && Hit[7, 7] != 1)
                                uxH8.BackColor = Color.CornflowerBlue;
                            break;

                        case "I3":
                            if (data[2, 8] != 1 && Hit[2, 8] != 1)
                                uxI3.BackColor = Color.CornflowerBlue;
                            break;
                        case "I6":
                            if (data[5, 8] != 1 && Hit[5, 8] != 1)
                                uxI6.BackColor = Color.CornflowerBlue;
                            break;
                        case "I9":
                            if (data[8, 8] != 1 && Hit[8, 8] != 1)
                                uxI9.BackColor = Color.CornflowerBlue;
                            break;

                        case "J1":
                            if (data[0, 9] != 1 && Hit[0, 9] != 1)
                                uxJ1.BackColor = Color.CornflowerBlue;
                            break;
                        case "J4":
                            if (data[3, 9] != 1 && Hit[3, 9] != 1)
                                uxJ4.BackColor = Color.CornflowerBlue;
                            break;
                        case "J7":
                            if (data[6, 9] != 1 && Hit[6, 9] != 1)
                                uxJ7.BackColor = Color.CornflowerBlue;
                            break;
                        case "J10":
                            if (data[9, 9] != 1 && Hit[9, 9] != 1)
                                uxJ10.BackColor = Color.CornflowerBlue;
                            break;
                    }

                }
            }
            else if (state == ParityType.three2)
            {
                foreach (string s in three2Parity)
                {

                    switch (s)
                    {
                        case "A2":
                            if (data[1, 0] != 1 && Hit[1, 0] != 1)
                                uxA2.BackColor = Color.CornflowerBlue;
                            break;
                        case "A5":
                            if (data[4, 0] != 1 && Hit[4, 0] != 1)
                                uxA5.BackColor = Color.CornflowerBlue;
                            break;
                        case "A8":
                            if (data[7, 0] != 1 && Hit[7, 0] != 1)
                                uxA8.BackColor = Color.CornflowerBlue;
                            break;

                        case "B3":
                            if (data[2, 1] != 1 && Hit[2, 1] != 1)
                                uxB3.BackColor = Color.CornflowerBlue;
                            break;
                        case "B6":
                            if (data[5, 1] != 1 && Hit[5, 1] != 1)
                                uxB6.BackColor = Color.CornflowerBlue;
                            break;
                        case "B9":
                            if (data[8, 1] != 1 && Hit[8, 1] != 1)
                                uxB9.BackColor = Color.CornflowerBlue;
                            break;

                        case "C1":
                            if (data[0, 2] != 1 && Hit[0, 2] != 1)
                                uxC1.BackColor = Color.CornflowerBlue;
                            break;
                        case "C4":
                            if (data[3, 2] != 1 && Hit[3, 2] != 1)
                                uxC4.BackColor = Color.CornflowerBlue;
                            break;
                        case "C7":
                            if (data[6, 2] != 1 && Hit[6, 2] != 1)
                                uxC7.BackColor = Color.CornflowerBlue;
                            break;
                        case "C10":
                            if (data[9, 2] != 1 && Hit[9, 2] != 1)
                                uxC10.BackColor = Color.CornflowerBlue;
                            break;

                        case "D2":
                            if (data[1, 3] != 1 && Hit[1, 3] != 1)
                                uxD2.BackColor = Color.CornflowerBlue;
                            break;
                        case "D5":
                            if (data[4, 3] != 1 && Hit[4, 3] != 1)
                                uxD5.BackColor = Color.CornflowerBlue;
                            break;
                        case "D8":
                            if (data[7, 3] != 1 && Hit[7, 3] != 1)
                                uxD8.BackColor = Color.CornflowerBlue;
                            break;

                        case "E3":
                            if (data[2, 4] != 1 && Hit[2, 4] != 1)
                                uxE3.BackColor = Color.CornflowerBlue;
                            break;
                        case "E6":
                            if (data[5, 4] != 1 && Hit[5, 4] != 1)
                                uxE6.BackColor = Color.CornflowerBlue;
                            break;
                        case "E9":
                            if (data[8, 4] != 1 && Hit[8, 4] != 1)
                                uxE9.BackColor = Color.CornflowerBlue;
                            break;

                        case "F1":
                            if (data[0, 5] != 1 && Hit[0, 5] != 1)
                                uxF1.BackColor = Color.CornflowerBlue;
                            break;
                        case "F4":
                            if (data[3, 5] != 1 && Hit[3, 5] != 1)
                                uxF4.BackColor = Color.CornflowerBlue;
                            break;
                        case "F7":
                            if (data[6, 5] != 1 && Hit[6, 5] != 1)
                                uxF7.BackColor = Color.CornflowerBlue;
                            break;
                        case "F10":
                            if (data[9, 5] != 1 && Hit[9, 5] != 1)
                                uxF10.BackColor = Color.CornflowerBlue;
                            break;

                        case "G2":
                            if (data[1, 6] != 1 && Hit[1, 6] != 1)
                                uxG2.BackColor = Color.CornflowerBlue;
                            break;
                        case "G5":
                            if (data[4, 6] != 1 && Hit[4, 6] != 1)
                                uxG5.BackColor = Color.CornflowerBlue;
                            break;
                        case "G8":
                            if (data[7, 6] != 1 && Hit[7, 6] != 1)
                                uxG8.BackColor = Color.CornflowerBlue;
                            break;

                        case "H3":
                            if (data[2, 7] != 1 && Hit[2, 7] != 1)
                                uxH3.BackColor = Color.CornflowerBlue;
                            break;
                        case "H6":
                            if (data[5, 7] != 1 && Hit[5, 7] != 1)
                                uxH6.BackColor = Color.CornflowerBlue;
                            break;
                        case "H9":
                            if (data[8, 7] != 1 && Hit[8, 7] != 1)
                                uxH9.BackColor = Color.CornflowerBlue;
                            break;

                        case "I1":
                            if (data[0, 8] != 1 && Hit[0, 8] != 1)
                                uxI1.BackColor = Color.CornflowerBlue;
                            break;
                        case "I4":
                            if (data[3, 8] != 1 && Hit[3, 8] != 1)
                                uxI4.BackColor = Color.CornflowerBlue;
                            break;
                        case "I7":
                            if (data[6, 8] != 1 && Hit[6, 8] != 1)
                                uxI7.BackColor = Color.CornflowerBlue;
                            break;
                        case "I10":
                            if (data[9, 8] != 1 && Hit[9, 8] != 1)
                                uxI10.BackColor = Color.CornflowerBlue;
                            break;

                        case "J2":
                            if (data[1, 9] != 1 && Hit[1, 9] != 1)
                                uxJ2.BackColor = Color.CornflowerBlue;
                            break;
                        case "J5":
                            if (data[4, 9] != 1 && Hit[4, 9] != 1)
                                uxJ5.BackColor = Color.CornflowerBlue;
                            break;
                        case "J8":
                            if (data[7, 9] != 1 && Hit[7, 9] != 1)
                                uxJ8.BackColor = Color.CornflowerBlue;
                            break;
                    }

                }
            }
            else if (state == ParityType.three3)
            {
                foreach (string s in three3Parity)
                {

                    switch (s)
                    {
                        case "A1":
                            if (data[0, 0] != 1 && Hit[0, 0] != 1)
                                uxA1.BackColor = Color.CornflowerBlue;
                            break;
                        case "A4":
                            if (data[3, 0] != 1 && Hit[3, 0] != 1)
                                uxA4.BackColor = Color.CornflowerBlue;
                            break;
                        case "A7":
                            if (data[6, 0] != 1 && Hit[6, 0] != 1)
                                uxA7.BackColor = Color.CornflowerBlue;
                            break;
                        case "A10":
                            if (data[9, 0] != 1 && Hit[9, 0] != 1)
                                uxA10.BackColor = Color.CornflowerBlue;
                            break;

                        case "B3":
                            if (data[2, 1] != 1 && Hit[2, 1] != 1)
                                uxB3.BackColor = Color.CornflowerBlue;
                            break;
                        case "B6":
                            if (data[5, 1] != 1 && Hit[5, 1] != 1)
                                uxB6.BackColor = Color.CornflowerBlue;
                            break;
                        case "B9":
                            if (data[8, 1] != 1 && Hit[8, 1] != 1)
                                uxB9.BackColor = Color.CornflowerBlue;
                            break;

                        case "C2":
                            if (data[1, 2] != 1 && Hit[1, 2] != 1)
                                uxC2.BackColor = Color.CornflowerBlue;
                            break;
                        case "C5":
                            if (data[4, 2] != 1 && Hit[4, 2] != 1)
                                uxC5.BackColor = Color.CornflowerBlue;
                            break;
                        case "C8":
                            if (data[7, 2] != 1 && Hit[7, 2] != 1)
                                uxC8.BackColor = Color.CornflowerBlue;
                            break;

                        case "D1":
                            if (data[0, 3] != 1 && Hit[0, 3] != 1)
                                uxD1.BackColor = Color.CornflowerBlue;
                            break;
                        case "D4":
                            if (data[3, 3] != 1 && Hit[3, 3] != 1)
                                uxD4.BackColor = Color.CornflowerBlue;
                            break;
                        case "D7":
                            if (data[6, 3] != 1 && Hit[6, 3] != 1)
                                uxD7.BackColor = Color.CornflowerBlue;
                            break;
                        case "D10":
                            if (data[9, 3] != 1 && Hit[9, 3] != 1)
                                uxD10.BackColor = Color.CornflowerBlue;
                            break;

                        case "E3":
                            if (data[2, 4] != 1 && Hit[2, 4] != 1)
                                uxE3.BackColor = Color.CornflowerBlue;
                            break;
                        case "E6":
                            if (data[5, 4] != 1 && Hit[5, 4] != 1)
                                uxE6.BackColor = Color.CornflowerBlue;
                            break;
                        case "E9":
                            if (data[8, 4] != 1 && Hit[8, 4] != 1)
                                uxE9.BackColor = Color.CornflowerBlue;
                            break;

                        case "F2":
                            if (data[1, 5] != 1 && Hit[1, 5] != 1)
                                uxF2.BackColor = Color.CornflowerBlue;
                            break;
                        case "F5":
                            if (data[4, 5] != 1 && Hit[4, 5] != 1)
                                uxF5.BackColor = Color.CornflowerBlue;
                            break;
                        case "F8":
                            if (data[7, 5] != 1 && Hit[7, 5] != 1)
                                uxF8.BackColor = Color.CornflowerBlue;
                            break;

                        case "G1":
                            if (data[0, 6] != 1 && Hit[0, 6] != 1)
                                uxG1.BackColor = Color.CornflowerBlue;
                            break;
                        case "G4":
                            if (data[3, 6] != 1 && Hit[3, 6] != 1)
                                uxG4.BackColor = Color.CornflowerBlue;
                            break;
                        case "G7":
                            if (data[6, 6] != 1 && Hit[6, 6] != 1)
                                uxG7.BackColor = Color.CornflowerBlue;
                            break;
                        case "G10":
                            if (data[9, 6] != 1 && Hit[9, 6] != 1)
                                uxG10.BackColor = Color.CornflowerBlue;
                            break;

                        case "H3":
                            if (data[2, 7] != 1 && Hit[2, 7] != 1)
                                uxH3.BackColor = Color.CornflowerBlue;
                            break;
                        case "H6":
                            if (data[5, 7] != 1 && Hit[5, 7] != 1)
                                uxH6.BackColor = Color.CornflowerBlue;
                            break;
                        case "H9":
                            if (data[8, 7] != 1 && Hit[8, 7] != 1)
                                uxH9.BackColor = Color.CornflowerBlue;
                            break;

                        case "I2":
                            if (data[1, 8] != 1 && Hit[1, 8] != 1)
                                uxI2.BackColor = Color.CornflowerBlue;
                            break;
                        case "I5":
                            if (data[4, 8] != 1 && Hit[4, 8] != 1)
                                uxI5.BackColor = Color.CornflowerBlue;
                            break;
                        case "I8":
                            if (data[7, 8] != 1 && Hit[7, 8] != 1)
                                uxI8.BackColor = Color.CornflowerBlue;
                            break;

                        case "J1":
                            if (data[0, 9] != 1 && Hit[0, 9] != 1)
                                uxJ1.BackColor = Color.CornflowerBlue;
                            break;
                        case "J4":
                            if (data[3, 9] != 1 && Hit[3, 9] != 1)
                                uxJ4.BackColor = Color.CornflowerBlue;
                            break;
                        case "J7":
                            if (data[6, 9] != 1 && Hit[6, 9] != 1)
                                uxJ7.BackColor = Color.CornflowerBlue;
                            break;
                        case "J10":
                            if (data[9, 9] != 1 && Hit[9, 9] != 1)
                                uxJ10.BackColor = Color.CornflowerBlue;
                            break;
                    }

                }
            }
            else if (state == ParityType.three4)
            {
                foreach (string s in three4Parity)
                {

                    switch (s)
                    {
                        case "A2":
                            if (data[1, 0] != 1 && Hit[1, 0] != 1)
                                uxA2.BackColor = Color.CornflowerBlue;
                            break;
                        case "A5":
                            if (data[4, 0] != 1 && Hit[4, 0] != 1)
                                uxA5.BackColor = Color.CornflowerBlue;
                            break;
                        case "A8":
                            if (data[7, 0] != 1 && Hit[7, 0] != 1)
                                uxA8.BackColor = Color.CornflowerBlue;
                            break;

                        case "B1":
                            if (data[0, 1] != 1 && Hit[0, 1] != 1)
                                uxB1.BackColor = Color.CornflowerBlue;
                            break;
                        case "B4":
                            if (data[3, 1] != 1 && Hit[3, 1] != 1)
                                uxB4.BackColor = Color.CornflowerBlue;
                            break;
                        case "B7":
                            if (data[6, 1] != 1 && Hit[6, 1] != 1)
                                uxB7.BackColor = Color.CornflowerBlue;
                            break;
                        case "B10":
                            if (data[9, 1] != 1 && Hit[9, 1] != 1)
                                uxB10.BackColor = Color.CornflowerBlue;
                            break;

                        case "C3":
                            if (data[2, 2] != 1 && Hit[2, 2] != 1)
                                uxC3.BackColor = Color.CornflowerBlue;
                            break;
                        case "C6":
                            if (data[5, 2] != 1 && Hit[5, 2] != 1)
                                uxC6.BackColor = Color.CornflowerBlue;
                            break;
                        case "C9":
                            if (data[8, 2] != 1 && Hit[8, 2] != 1)
                                uxC9.BackColor = Color.CornflowerBlue;
                            break;

                        case "D2":
                            if (data[1, 3] != 1 && Hit[1, 3] != 1)
                                uxD2.BackColor = Color.CornflowerBlue;
                            break;
                        case "D5":
                            if (data[4, 3] != 1 && Hit[4, 3] != 1)
                                uxD5.BackColor = Color.CornflowerBlue;
                            break;
                        case "D8":
                            if (data[7, 3] != 1 && Hit[7, 3] != 1)
                                uxD8.BackColor = Color.CornflowerBlue;
                            break;

                        case "E1":
                            if (data[0, 4] != 1 && Hit[0, 4] != 1)
                                uxE1.BackColor = Color.CornflowerBlue;
                            break;
                        case "E4":
                            if (data[3, 4] != 1 && Hit[3, 4] != 1)
                                uxE4.BackColor = Color.CornflowerBlue;
                            break;
                        case "E7":
                            if (data[6, 4] != 1 && Hit[6, 4] != 1)
                                uxE7.BackColor = Color.CornflowerBlue;
                            break;
                        case "E10":
                            if (data[9, 4] != 1 && Hit[9, 4] != 1)
                                uxE10.BackColor = Color.CornflowerBlue;
                            break;

                        case "F3":
                            if (data[2, 5] != 1 && Hit[2, 5] != 1)
                                uxF3.BackColor = Color.CornflowerBlue;
                            break;
                        case "F6":
                            if (data[5, 5] != 1 && Hit[5, 5] != 1)
                                uxF6.BackColor = Color.CornflowerBlue;
                            break;
                        case "F9":
                            if (data[8, 5] != 1 && Hit[8, 5] != 1)
                                uxF9.BackColor = Color.CornflowerBlue;
                            break;

                        case "G2":
                            if (data[1, 6] != 1 && Hit[1, 6] != 1)
                                uxG2.BackColor = Color.CornflowerBlue;
                            break;
                        case "G5":
                            if (data[4, 6] != 1 && Hit[4, 6] != 1)
                                uxG5.BackColor = Color.CornflowerBlue;
                            break;
                        case "G8":
                            if (data[7, 6] != 1 && Hit[7, 6] != 1)
                                uxG8.BackColor = Color.CornflowerBlue;
                            break;

                        case "H1":
                            if (data[0, 7] != 1 && Hit[0, 7] != 1)
                                uxH1.BackColor = Color.CornflowerBlue;
                            break;
                        case "H4":
                            if (data[3, 7] != 1 && Hit[3, 7] != 1)
                                uxH4.BackColor = Color.CornflowerBlue;
                            break;
                        case "H7":
                            if (data[6, 7] != 1 && Hit[6, 7] != 1)
                                uxH7.BackColor = Color.CornflowerBlue;
                            break;
                        case "H10":
                            if (data[9, 7] != 1 && Hit[9, 7] != 1)
                                uxH10.BackColor = Color.CornflowerBlue;
                            break;

                        case "I3":
                            if (data[2, 8] != 1 && Hit[2, 8] != 1)
                                uxI3.BackColor = Color.CornflowerBlue;
                            break;
                        case "I6":
                            if (data[5, 8] != 1 && Hit[5, 8] != 1)
                                uxI6.BackColor = Color.CornflowerBlue;
                            break;
                        case "I9":
                            if (data[8, 8] != 1 && Hit[8, 8] != 1)
                                uxI9.BackColor = Color.CornflowerBlue;
                            break;

                        case "J2":
                            if (data[1, 9] != 1 && Hit[1, 9] != 1)
                                uxJ2.BackColor = Color.CornflowerBlue;
                            break;
                        case "J5":
                            if (data[4, 9] != 1 && Hit[4, 9] != 1)
                                uxJ5.BackColor = Color.CornflowerBlue;
                            break;
                        case "J8":
                            if (data[7, 9] != 1 && Hit[7, 9] != 1)
                                uxJ8.BackColor = Color.CornflowerBlue;
                            break;
                    }

                }
            }

        }
        public void BoardMarked_Update() // will be used to update the markers for pdf
        {

            int i = 0;
            int j = 0;
            foreach (string s in names)
            {
                if (i > 9)
                {
                    i = 0;
                    j++;
                }
                if (data[i, j] == 1)
                {
                    switch (s)
                    {
                        case "uxA1":
                            uxA1.BackColor = Color.Black;
                            break;
                        case "uxA2":
                            uxA2.BackColor = Color.Black;
                            break;
                        case "uxA3":
                            uxA3.BackColor = Color.Black;
                            break;
                        case "uxA4":
                            uxA4.BackColor = Color.Black;
                            break;
                        case "uxA5":
                            uxA5.BackColor = Color.Black;
                            break;
                        case "uxA6":
                            uxA6.BackColor = Color.Black;
                            break;
                        case "uxA7":
                            uxA7.BackColor = Color.Black;
                            break;
                        case "uxA8":
                            uxA8.BackColor = Color.Black;
                            break;
                        case "uxA9":
                            uxA9.BackColor = Color.Black;
                            break;
                        case "uxA10":
                            uxA10.BackColor = Color.Black;
                            break;

                        case "uxB1":
                            uxB1.BackColor = Color.Black;
                            break;
                        case "uxB2":
                            uxB2.BackColor = Color.Black;
                            break;
                        case "uxB3":
                            uxB3.BackColor = Color.Black;
                            break;
                        case "uxB4":
                            uxB4.BackColor = Color.Black;
                            break;
                        case "uxB5":
                            uxB5.BackColor = Color.Black;
                            break;
                        case "uxB6":
                            uxB6.BackColor = Color.Black;
                            break;
                        case "uxB7":
                            uxB7.BackColor = Color.Black;
                            break;
                        case "uxB8":
                            uxB8.BackColor = Color.Black;
                            break;
                        case "uxB9":
                            uxB9.BackColor = Color.Black;
                            break;
                        case "uxB10":
                            uxB10.BackColor = Color.Black;
                            break;

                        case "uxC1":
                            uxC1.BackColor = Color.Black;
                            break;
                        case "uxC2":
                            uxC2.BackColor = Color.Black;
                            break;
                        case "uxC3":
                            uxC3.BackColor = Color.Black;
                            break;
                        case "uxC4":
                            uxC4.BackColor = Color.Black;
                            break;
                        case "uxC5":
                            uxC5.BackColor = Color.Black;
                            break;
                        case "uxC6":
                            uxC6.BackColor = Color.Black;
                            break;
                        case "uxC7":
                            uxC7.BackColor = Color.Black;
                            break;
                        case "uxC8":
                            uxC8.BackColor = Color.Black;
                            break;
                        case "uxC9":
                            uxC9.BackColor = Color.Black;
                            break;
                        case "uxC10":
                            uxC10.BackColor = Color.Black; ;
                            break;

                        case "uxD1":
                            uxD1.BackColor = Color.Black;
                            break;
                        case "uxD2":
                            uxD2.BackColor = Color.Black;
                            break;
                        case "uxD3":
                            uxD3.BackColor = Color.Black;
                            break;
                        case "uxD4":
                            uxD4.BackColor = Color.Black;
                            break;
                        case "uxD5":
                            uxD5.BackColor = Color.Black;
                            break;
                        case "uxD6":
                            uxD6.BackColor = Color.Black;
                            break;
                        case "uxD7":
                            uxD7.BackColor = Color.Black;
                            break;
                        case "uxD8":
                            uxD8.BackColor = Color.Black;
                            break;
                        case "uxD9":
                            uxD9.BackColor = Color.Black;
                            break;
                        case "uxD10":
                            uxD10.BackColor = Color.Black;
                            break;

                        case "uxE1":
                            uxE1.BackColor = Color.Black;
                            break;
                        case "uxE2":
                            uxE2.BackColor = Color.Black;
                            break;
                        case "uxE3":
                            uxE3.BackColor = Color.Black;
                            break;
                        case "uxE4":
                            uxE4.BackColor = Color.Black;
                            break;
                        case "uxE5":
                            uxE5.BackColor = Color.Black;
                            break;
                        case "uxE6":
                            uxE6.BackColor = Color.Black;
                            break;
                        case "uxE7":
                            uxE7.BackColor = Color.Black;
                            break;
                        case "uxE8":
                            uxE8.BackColor = Color.Black;
                            break;
                        case "uxE9":
                            uxE9.BackColor = Color.Black;
                            break;
                        case "uxE10":
                            uxE10.BackColor = Color.Black;
                            break;

                        case "uxF1":
                            uxF1.BackColor = Color.Black;
                            break;
                        case "uxF2":
                            uxF2.BackColor = Color.Black;
                            break;
                        case "uxF3":
                            uxF3.BackColor = Color.Black;
                            break;
                        case "uxF4":
                            uxF4.BackColor = Color.Black;
                            break;
                        case "uxF5":
                            uxF5.BackColor = Color.Black;
                            break;
                        case "uxF6":
                            uxF6.BackColor = Color.Black;
                            break;
                        case "uxF7":
                            uxF7.BackColor = Color.Black;
                            break;
                        case "uxF8":
                            uxF8.BackColor = Color.Black;
                            break;
                        case "uxF9":
                            uxF9.BackColor = Color.Black;
                            break;
                        case "uxF10":
                            uxF10.BackColor = Color.Black;
                            break;

                        case "uxG1":
                            uxG1.BackColor = Color.Black;
                            break;
                        case "uxG2":
                            uxG2.BackColor = Color.Black;
                            break;
                        case "uxG3":
                            uxG3.BackColor = Color.Black;
                            break;
                        case "uxG4":
                            uxG4.BackColor = Color.Black;
                            break;
                        case "uxG5":
                            uxG5.BackColor = Color.Black;
                            break;
                        case "uxG6":
                            uxG6.BackColor = Color.Black;
                            break;
                        case "uxG7":
                            uxG7.BackColor = Color.Black;
                            break;
                        case "uxG8":
                            uxG8.BackColor = Color.Black;
                            break;
                        case "uxG9":
                            uxG9.BackColor = Color.Black;
                            break;
                        case "uxG10":
                            uxG10.BackColor = Color.Black;
                            break;

                        case "uxH1":
                            uxH1.BackColor = Color.Black;
                            break;
                        case "uxH2":
                            uxH2.BackColor = Color.Black;
                            break;
                        case "uxH3":
                            uxH3.BackColor = Color.Black;
                            break;
                        case "uxH4":
                            uxH4.BackColor = Color.Black;
                            break;
                        case "uxH5":
                            uxH5.BackColor = Color.Black;
                            break;
                        case "uxH6":
                            uxH6.BackColor = Color.Black;
                            break;
                        case "uxH7":
                            uxH7.BackColor = Color.Black;
                            break;
                        case "uxH8":
                            uxH8.BackColor = Color.Black;
                            break;
                        case "uxH9":
                            uxH9.BackColor = Color.Black;
                            break;
                        case "uxH10":
                            uxH10.BackColor = Color.Black;
                            break;

                        case "uxI1":
                            uxI1.BackColor = Color.Black;
                            break;
                        case "uxI2":
                            uxI2.BackColor = Color.Black;
                            break;
                        case "uxI3":
                            uxI3.BackColor = Color.Black;
                            break;
                        case "uxI4":
                            uxI4.BackColor = Color.Black;
                            break;
                        case "uxI5":
                            uxI5.BackColor = Color.Black;
                            break;
                        case "uxI6":
                            uxI6.BackColor = Color.Black;
                            break;
                        case "uxI7":
                            uxI7.BackColor = Color.Black;
                            break;
                        case "uxI8":
                            uxI8.BackColor = Color.Black;
                            break;
                        case "uxI9":
                            uxI9.BackColor = Color.Black;
                            break;
                        case "uxI10":
                            uxI10.BackColor = Color.Black;
                            break;

                        case "uxJ1":
                            uxJ1.BackColor = Color.Black;
                            break;
                        case "uxJ2":
                            uxJ2.BackColor = Color.Black;
                            break;
                        case "uxJ3":
                            uxJ3.BackColor = Color.Black;
                            break;
                        case "uxJ4":
                            uxJ4.BackColor = Color.Black;
                            break;
                        case "uxJ5":
                            uxJ5.BackColor = Color.Black;
                            break;
                        case "uxJ6":
                            uxJ6.BackColor = Color.Black;
                            break;
                        case "uxJ7":
                            uxJ7.BackColor = Color.Black;
                            break;
                        case "uxJ8":
                            uxJ8.BackColor = Color.Black;
                            break;
                        case "uxJ9":
                            uxJ9.BackColor = Color.Black;
                            break;
                        case "uxJ10":
                            uxJ10.BackColor = Color.Black;
                            break;






                    }// Oh God Don't Look
                }
                if (data[i, j] == 0)
                {
                    switch (s)
                    {
                        case "uxA1":
                            uxA1.BackColor = Color.LightGray;
                            uxA1.Text = "";
                            break;
                        case "uxA2":
                            uxA2.BackColor = Color.LightGray;
                            uxA2.Text = "";
                            break;;
                        case "uxA3":
                            uxA3.BackColor = Color.LightGray;
                            uxA3.Text = "";
                            break;
                        case "uxA4":
                            uxA4.BackColor = Color.LightGray;
                            uxA4.Text = "";
                            break;
                        case "uxA5":
                            uxA5.BackColor = Color.LightGray;
                            uxA5.Text = "";
                            break;
                        case "uxA6":
                            uxA6.BackColor = Color.LightGray;
                            uxA6.Text = "";
                            break;
                        case "uxA7":
                            uxA7.BackColor = Color.LightGray;
                            uxA7.Text = "";
                            break;
                        case "uxA8":
                            uxA8.BackColor = Color.LightGray;
                            uxA8.Text = "";
                            break;
                        case "uxA9":
                            uxA9.BackColor = Color.LightGray;
                            uxA9.Text = "";
                            break;
                        case "uxA10":
                            uxA10.BackColor = Color.LightGray;
                            uxA10.Text = "";
                            break;

                        case "uxB1":
                            uxB1.BackColor = Color.LightGray;
                            uxB1.Text = "";
                            break;
                        case "uxB2":
                            uxB2.BackColor = Color.LightGray;
                            uxB2.Text = "";
                            break;
                        case "uxB3":
                            uxB3.BackColor = Color.LightGray;
                            uxB3.Text = "";
                            break;
                        case "uxB4":
                            uxB4.BackColor = Color.LightGray;
                            uxB4.Text = "";
                            break;
                        case "uxB5":
                            uxB5.BackColor = Color.LightGray;
                            uxB5.Text = "";
                            break;
                        case "uxB6":
                            uxB6.BackColor = Color.LightGray;
                            uxB6.Text = "";
                            break;
                        case "uxB7":
                            uxB7.BackColor = Color.LightGray;
                            uxB7.Text = "";
                            break;
                        case "uxB8":
                            uxB8.BackColor = Color.LightGray;
                            uxB8.Text = "";
                            break;
                        case "uxB9":
                            uxB9.BackColor = Color.LightGray;
                            uxB9.Text = "";
                            break;
                        case "uxB10":
                            uxB10.BackColor = Color.LightGray;
                            uxB10.Text = "";
                            break;

                        case "uxC1":
                            uxC1.BackColor = Color.LightGray;
                            uxC1.Text = "";
                            break;
                        case "uxC2":
                            uxC2.BackColor = Color.LightGray;
                            uxC2.Text = "";
                            break;
                        case "uxC3":
                            uxC3.BackColor = Color.LightGray;
                            uxC3.Text = "";
                            break;
                        case "uxC4":
                            uxC4.BackColor = Color.LightGray;
                            uxC4.Text = "";
                            break;
                        case "uxC5":
                            uxC5.BackColor = Color.LightGray;
                            uxC5.Text = "";
                            break;
                        case "uxC6":
                            uxC6.BackColor = Color.LightGray;
                            uxC6.Text = "";
                            break;
                        case "uxC7":
                            uxC7.BackColor = Color.LightGray;
                            uxC7.Text = "";
                            break;
                        case "uxC8":
                            uxC8.BackColor = Color.LightGray;
                            uxC8.Text = "";
                            break;
                        case "uxC9":
                            uxC9.BackColor = Color.LightGray;
                            uxC9.Text = "";
                            break;
                        case "uxC10":
                            uxC10.BackColor = Color.LightGray;
                            uxC10.Text = "";
                            break;

                        case "uxD1":
                            uxD1.BackColor = Color.LightGray;
                            uxD1.Text = "";
                            break;
                        case "uxD2":
                            uxD2.BackColor = Color.LightGray;
                            uxD2.Text = "";
                            break;
                        case "uxD3":
                            uxD3.BackColor = Color.LightGray;
                            uxD3.Text = "";
                            break;
                        case "uxD4":
                            uxD4.BackColor = Color.LightGray;
                            uxD4.Text = "";
                            break;
                        case "uxD5":
                            uxD5.BackColor = Color.LightGray;
                            uxD5.Text = "";
                            break;
                        case "uxD6":
                            uxD6.BackColor = Color.LightGray;
                            uxD6.Text = "";
                            break;
                        case "uxD7":
                            uxD7.BackColor = Color.LightGray;
                            uxD7.Text = "";
                            break;
                        case "uxD8":
                            uxD8.BackColor = Color.LightGray;
                            uxD8.Text = "";
                            break;
                        case "uxD9":
                            uxD9.BackColor = Color.LightGray;
                            uxD9.Text = "";
                            break;
                        case "uxD10":
                            uxD10.BackColor = Color.LightGray;
                            uxD10.Text = "";
                            break;

                        case "uxE1":
                            uxE1.BackColor = Color.LightGray;
                            uxE1.Text = "";
                            break;
                        case "uxE2":
                            uxE2.BackColor = Color.LightGray;
                            uxE2.Text = "";
                            break;
                        case "uxE3":
                            uxE3.BackColor = Color.LightGray;
                            uxE3.Text = "";
                            break;
                        case "uxE4":
                            uxE4.BackColor = Color.LightGray;
                            uxE4.Text = "";
                            break;
                        case "uxE5":
                            uxE5.BackColor = Color.LightGray;
                            uxE5.Text = "";
                            break;
                        case "uxE6":
                            uxE6.BackColor = Color.LightGray;
                            uxE6.Text = "";
                            break;
                        case "uxE7":
                            uxE7.BackColor = Color.LightGray;
                            uxE7.Text = "";
                            break;
                        case "uxE8":
                            uxE8.BackColor = Color.LightGray;
                            uxE8.Text = "";
                            break;
                        case "uxE9":
                            uxE9.BackColor = Color.LightGray;
                            uxE9.Text = "";
                            break;
                        case "uxE10":
                            uxE10.BackColor = Color.LightGray;
                            uxE10.Text = "";
                            break;

                        case "uxF1":
                            uxF1.BackColor = Color.LightGray;
                            uxF1.Text = "";
                            break;
                        case "uxF2":
                            uxF2.BackColor = Color.LightGray;
                            uxF2.Text = "";
                            break;
                        case "uxF3":
                            uxF3.BackColor = Color.LightGray;
                            uxF3.Text = "";
                            break;
                        case "uxF4":
                            uxF4.BackColor = Color.LightGray;
                            uxF4.Text = "";
                            break;
                        case "uxF5":
                            uxF5.BackColor = Color.LightGray;
                            uxF5.Text = "";
                            break;
                        case "uxF6":
                            uxF6.BackColor = Color.LightGray;
                            uxF6.Text = "";
                            break;
                        case "uxF7":
                            uxF7.BackColor = Color.LightGray;
                            uxF7.Text = "";
                            break;
                        case "uxF8":
                            uxF8.BackColor = Color.LightGray;
                            uxF8.Text = "";
                            break;
                        case "uxF9":
                            uxF9.BackColor = Color.LightGray;
                            uxF9.Text = "";
                            break;
                        case "uxF10":
                            uxF10.BackColor = Color.LightGray;
                            uxF10.Text = "";
                            break;

                        case "uxG1":
                            uxG1.BackColor = Color.LightGray;
                            uxG1.Text = "";
                            break;
                        case "uxG2":
                            uxG2.BackColor = Color.LightGray;
                            uxG2.Text = "";
                            break;
                        case "uxG3":
                            uxG3.BackColor = Color.LightGray;
                            uxG3.Text = "";
                            break;
                        case "uxG4":
                            uxG4.BackColor = Color.LightGray;
                            uxG4.Text = "";
                            break;
                        case "uxG5":
                            uxG5.BackColor = Color.LightGray;
                            uxG5.Text = "";
                            break;
                        case "uxG6":
                            uxG6.BackColor = Color.LightGray;
                            uxG6.Text = "";
                            break;
                        case "uxG7":
                            uxG7.BackColor = Color.LightGray;
                            uxG7.Text = "";
                            break;
                        case "uxG8":
                            uxG8.BackColor = Color.LightGray;
                            uxG8.Text = "";
                            break;
                        case "uxG9":
                            uxG9.BackColor = Color.LightGray;
                            uxG9.Text = "";
                            break;
                        case "uxG10":
                            uxG10.BackColor = Color.LightGray;
                            uxG10.Text = "";
                            break;

                        case "uxH1":
                            uxH1.BackColor = Color.LightGray;
                            uxH1.Text = "";
                            break;
                        case "uxH2":
                            uxH2.BackColor = Color.LightGray;
                            uxH2.Text = "";
                            break;
                        case "uxH3":
                            uxH3.BackColor = Color.LightGray;
                            uxH3.Text = "";
                            break;
                        case "uxH4":
                            uxH4.BackColor = Color.LightGray;
                            uxH4.Text = "";
                            break;
                        case "uxH5":
                            uxH5.BackColor = Color.LightGray;
                            uxH5.Text = "";
                            break;
                        case "uxH6":
                            uxH6.BackColor = Color.LightGray;
                            uxH6.Text = "";
                            break;
                        case "uxH7":
                            uxH7.BackColor = Color.LightGray;
                            uxH7.Text = "";
                            break;
                        case "uxH8":
                            uxH8.BackColor = Color.LightGray;
                            uxH8.Text = "";
                            break;
                        case "uxH9":
                            uxH9.BackColor = Color.LightGray;
                            uxH9.Text = "";
                            break;
                        case "uxH10":
                            uxH10.BackColor = Color.LightGray;
                            uxH10.Text = "";
                            break;

                        case "uxI1":
                            uxI1.BackColor = Color.LightGray;
                            uxI1.Text = "";
                            break;
                        case "uxI2":
                            uxI2.BackColor = Color.LightGray;
                            uxI2.Text = "";
                            break;
                        case "uxI3":
                            uxI3.BackColor = Color.LightGray;
                            uxI3.Text = "";
                            break;
                        case "uxI4":
                            uxI4.BackColor = Color.LightGray;
                            uxI4.Text = "";
                            break;
                        case "uxI5":
                            uxI5.BackColor = Color.LightGray;
                            uxI5.Text = "";
                            break;
                        case "uxI6":
                            uxI6.BackColor = Color.LightGray;
                            uxI6.Text = "";
                            break;
                        case "uxI7":
                            uxI7.BackColor = Color.LightGray; ;
                            uxI7.Text = "";
                            break;
                        case "uxI8":
                            uxI8.BackColor = Color.LightGray;
                            uxI8.Text = "";
                            break;
                        case "uxI9":
                            uxI9.BackColor = Color.LightGray;
                            uxI9.Text = "";
                            break;
                        case "uxI10":
                            uxI10.BackColor = Color.LightGray;
                            uxI10.Text = "";
                            break;

                        case "uxJ1":
                            uxJ1.BackColor = Color.LightGray;
                            uxJ1.Text = "";
                            break;
                        case "uxJ2":
                            uxJ2.BackColor = Color.LightGray;
                            uxJ2.Text = "";
                            break;
                        case "uxJ3":
                            uxJ3.BackColor = Color.LightGray;
                            uxJ3.Text = "";
                            break;
                        case "uxJ4":
                            uxJ4.BackColor = Color.LightGray;
                            uxJ4.Text = "";
                            break;
                        case "uxJ5":
                            uxJ5.BackColor = Color.LightGray;
                            uxJ5.Text = "";
                            break;
                        case "uxJ6":
                            uxJ6.BackColor = Color.LightGray;
                            uxJ6.Text = "";
                            break;
                        case "uxJ7":
                            uxJ7.BackColor = Color.LightGray;
                            uxJ7.Text = "";
                            break;
                        case "uxJ8":
                            uxJ8.BackColor = Color.LightGray;
                            uxJ8.Text = "";
                            break;
                        case "uxJ9":
                            uxJ9.BackColor = Color.LightGray;
                            uxJ9.Text = "";
                            break;
                        case "uxJ10":
                            uxJ10.BackColor = Color.LightGray;
                            uxJ10.Text = "";
                            break;
                    }// Oh God Don't Look
                }
                i++;
            }
        }
        public void Calculate_PDF()
        {
            for(int m = 0; m < 10; m++)
            {
                for(int k = 0; k < 10; k++)
                {
                    PDF[m, k] = 0;
                }
            }


            switch(com) // add ship image illimnation logic and other ship PDF... can't handle found logic
            {
                case ComanderState.c:
                    for (int i = 0; i < 10; i++)
                    {
                        for(int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j+1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++) 
                    {
                        for (int j = 0; j < 10; j++) 
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 3) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 3, j] += 1;
                            }
                        }
                    }//  4 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 3) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  4 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 4) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && data[i + 4, j] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 3, j] += 1;
                                PDF[i + 4, j] += 1;
                            }
                        }
                    }//  5 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 4) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && data[i, j + 4] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                                PDF[i, j + 4] += 1;
                            }
                        }
                    }//  5 x 1 ship O2
                    break;
                case ComanderState.w:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i , j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0  && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  zig-zag ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  zig-zag ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 2) < 10 && (i + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 2] == 0 && data[i + 2, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i + 2, j + 2] += 1;
                            }
                        }
                    }//  Largecorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j + 2] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 2, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 2, j + 2] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  Largecorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 2, j + 2] += 1;
                            }
                        }
                    }//  Largecorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i , j + 1] == 0 && data[i , j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  Largecorner ship O4
                    break;
                case ComanderState.j:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  ReverseZig-Zag ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  ReverseZig-Zag ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  Block ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  Block ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  Block ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  Block ship O4
                    break;
                case ComanderState.a:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 1) < 10 && (i + 2) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  T ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  T ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  T ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 1, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  T ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 3) < 10 && (i + 1) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  weird ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 3, j + 1] += 1;
                            }
                        }
                    }//  weird ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 3, j + 1] += 1;
                            }
                        }
                    }//  weird ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  weird ship O3
                    break;
                case ComanderState.f:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  3 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 2) < 10 && (i + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  L ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  L ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  L ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  L ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 3) < 10 && (i + 1) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i + 1, j + 3] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i + 1, j + 3] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  Big Reverse L ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 3, j + 1] += 1;
                            }
                        }
                    }//  Big Reverse L  ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  Big Reverse L  ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 3, j] += 1;
                                PDF[i + 3, j + 1] += 1;
                            }
                        }
                    }//  Big Reverse L  ship O4
                    break;
                case ComanderState.g:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 3) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 3, j] += 1;
                            }
                        }
                    }//  4 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 3) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  4 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 2) < 10 && (i + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                            }
                        }
                    }//  Big T ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j + 2] == 0 && data[i + 2, j] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 2, j + 2] += 1;
                                PDF[i + 2, j] += 1;
                            }
                        }
                    }//  Big T ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && data[i + 2, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i + 2, j + 2] += 1;
                            }
                        }
                    }//  Big T ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  Big T ship O4
                    break;
                case ComanderState.s:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  Reverse L ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  Reverse L ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  Reverse L ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  Reverse L ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                            }
                        }
                    }//  Big f ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 3, j] += 1;
                            }
                        }
                    }//  Big f ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i + 1, j + 3] == 0 && data[i, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 1, j + 2] += 1;
                                PDF[i + 1, j + 3] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  Big f ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                                PDF[i + 3, j + 1] += 1;
                            }
                        }
                    }//  Big f ship O4
                    break;
                case ComanderState.e:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship2.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i, j + 1] += 1;
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                            }
                        }
                    }//  zig-zag ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 1, j + 1] += 1;
                                PDF[i + 2, j + 1] += 1;
                            }
                        }
                    }//  zig-zag ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 4) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && data[i + 4, j] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i + 1, j] += 1;
                                PDF[i + 2, j] += 1;
                                PDF[i + 3, j] += 1;
                                PDF[i + 4, j] += 1;
                            }
                        }
                    }//  5 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 4) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && data[i, j + 4] == 0 && Ship5.Enabled == true)
                            {
                                PDF[i, j] += 1;
                                PDF[i, j + 1] += 1;
                                PDF[i, j + 2] += 1;
                                PDF[i, j + 3] += 1;
                                PDF[i, j + 4] += 1;
                            }
                        }
                    }//  5 x 1 ship O2
                    break;
                default:
                    break;
            }
            Highlight_PDF();
        }
        public void Highlight_PDF()
        {
            Button_Color_Correction();
            BoardColor_Update();
            
            int[] check = To1DArray(PDF);
            Array.Sort(check);
            Array.Reverse(check);
            string[] positions = new string[500];
            Color[] c = {Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.Purple};

            int m = 0;
            for (int g = 0; g < 5; g++)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (PDF[i, j].Equals(check[m]))
                        {
                            char letter = (char)(j + 65);
                            char number = (char)(i + 49);
                            char[] chars = { letter, number,};
                            string s = new string(chars);
                            if (number == ':')
                            {
                                s = letter + "10";
                            }
                            positions[m] = s;
                            if(m < 99)
                                m++;
                        }
                    }
                }
            }


            int t = 0;
            for (int l = 0; l < 5; l++)
            {
                if (t > 100)
                    t = 0;
                if(state == ParityType.Odd)
                {
                    switch (positions[t])
                    {
                        case "A1":
                            if (data[0, 0] != 1)
                                uxA1.BackColor = c[l];
                            break;
                        case "A3":
                            if (data[2, 0] != 1)
                                uxA3.BackColor = c[l];
                            break;
                        case "A5":
                            if (data[4, 0] != 1)
                                uxA5.BackColor = c[l];
                            break;
                        case "A7":
                            if (data[6, 0] != 1)
                                uxA7.BackColor = c[l];
                            break;
                        case "A9":
                            if (data[8, 0] != 1)
                                uxA9.BackColor = c[l];
                            break;

                        case "B2":
                            if (data[1, 1] != 1)
                                uxB2.BackColor = c[l];
                            break;
                        case "B4":
                            if (data[3, 1] != 1)
                                uxB4.BackColor = c[l];
                            break;
                        case "B6":
                            if (data[5, 1] != 1)
                                uxB6.BackColor = c[l];
                            break;
                        case "B8":
                            if (data[7, 1] != 1)
                                uxB8.BackColor = c[l];
                            break;
                        case "B10":
                            if (data[9, 1] != 1)
                                uxB10.BackColor = c[l];
                            break;

                        case "C1":
                            if (data[0, 2] != 1)
                                uxC1.BackColor = c[l];
                            break;
                        case "C3":
                            if (data[2, 2] != 1)
                                uxC3.BackColor = c[l];
                            break;
                        case "C5":
                            if (data[4, 2] != 1)
                                uxC5.BackColor = c[l];
                            break;
                        case "C7":
                            if (data[6, 2] != 1)
                                uxC7.BackColor = c[l];
                            break;
                        case "C9":
                            if (data[8, 2] != 1)
                                uxC9.BackColor = c[l];
                            break;

                        case "D2":
                            if (data[1, 3] != 1)
                                uxD2.BackColor = c[l];
                            break;
                        case "D4":
                            if (data[3, 3] != 1)
                                uxD4.BackColor = c[l];
                            break;
                        case "D6":
                            if (data[5, 3] != 1)
                                uxD6.BackColor = c[l];
                            break;
                        case "D8":
                            if (data[7, 3] != 1)
                                uxD8.BackColor = c[l];
                            break;
                        case "D10":
                            if (data[9, 3] != 1)
                                uxD10.BackColor = c[l];
                            break;

                        case "E1":
                            if (data[0, 4] != 1)
                                uxE1.BackColor = c[l];
                            break;
                        case "E3":
                            if (data[2, 4] != 1)
                                uxE3.BackColor = c[l];
                            break;
                        case "E5":
                            if (data[4, 4] != 1)
                                uxE5.BackColor = c[l];
                            break;
                        case "E7":
                            if (data[6, 4] != 1)
                                uxE7.BackColor = c[l];
                            break;
                        case "E9":
                            if (data[8, 4] != 1)
                                uxE9.BackColor = c[l];
                            break;

                        case "F2":
                            if (data[1, 5] != 1)
                                uxF2.BackColor = c[l];
                            break;
                        case "F4":
                            if (data[3, 5] != 1)
                                uxF4.BackColor = c[l];
                            break;
                        case "F6":
                            if (data[5, 5] != 1)
                                uxF6.BackColor = c[l];
                            break;
                        case "F8":
                            if (data[7, 5] != 1)
                                uxF8.BackColor = c[l];
                            break;
                        case "F10":
                            if (data[9, 5] != 1)
                                uxF10.BackColor = c[l];
                            break;

                        case "G1":
                            if (data[0, 6] != 1)
                                uxG1.BackColor = c[l];
                            break;
                        case "G3":
                            if (data[2, 6] != 1)
                                uxG3.BackColor = c[l];
                            break;
                        case "G5":
                            if (data[4, 6] != 1)
                                uxG5.BackColor = c[l];
                            break;
                        case "G7":
                            if (data[6, 6] != 1)
                                uxG7.BackColor = c[l];
                            break;
                        case "G9":
                            if (data[8, 6] != 1)
                                uxG9.BackColor = c[l];
                            break;

                        case "H2":
                            if (data[1, 7] != 1)
                                uxH2.BackColor = c[l];
                            break;
                        case "H4":
                            if (data[3, 7] != 1)
                                uxH4.BackColor = c[l];
                            break;
                        case "H6":
                            if (data[5, 7] != 1)
                                uxH6.BackColor = c[l];
                            break;
                        case "H8":
                            if (data[7, 7] != 1)
                                uxH8.BackColor = c[l];
                            break;
                        case "H10":
                            if (data[9, 7] != 1)
                                uxH10.BackColor = c[l];
                            break;

                        case "I1":
                            if (data[0, 8] != 1)
                                uxI1.BackColor = c[l];
                            break;
                        case "I3":
                            if (data[2, 8] != 1)
                                uxI3.BackColor = c[l];
                            break;
                        case "I5":
                            if (data[4, 8] != 1)
                                uxI5.BackColor = c[l];
                            break;
                        case "I7":
                            if (data[6, 8] != 1)
                                uxI7.BackColor = c[l];
                            break;
                        case "I9":
                            if (data[8, 8] != 1)
                                uxI9.BackColor = c[l];
                            break;

                        case "J2":
                            if (data[1, 9] != 1)
                                uxJ2.BackColor = c[l];
                            break;
                        case "J4":
                            if (data[3, 9] != 1)
                                uxJ4.BackColor = c[l];
                            break;
                        case "J6":
                            if (data[5, 9] != 1)
                                uxJ6.BackColor = c[l];
                            break;
                        case "J8":
                            if (data[7, 9] != 1)
                                uxJ8.BackColor = c[l];
                            break;
                        case "J10":
                            if (data[9, 9] != 1)
                                uxJ10.BackColor = c[l];
                            break;
                        default:
                            l--;
                            break;
                            
                    }
                    t++;
                }
                if(state == ParityType.Even)
                {
                    switch (positions[t])
                    {
                        case "A2":
                            if (data[1, 0] != 1)
                                uxA2.BackColor = c[l];
                            break;
                        case "A4":
                            if (data[3, 0] != 1)
                                uxA4.BackColor = c[l];
                            break;
                        case "A6":
                            if (data[4, 0] != 1)
                                uxA6.BackColor = c[l];
                            break;
                        case "A8":
                            if (data[5, 0] != 1)
                                uxA8.BackColor = c[l];
                            break;
                        case "A10":
                            if (data[9, 0] != 1)
                                uxA10.BackColor = c[l];
                            break;

                        case "B1":
                            if (data[0, 1] != 1)
                                uxB1.BackColor = c[l];
                            break;
                        case "B3":
                            if (data[2, 1] != 1)
                                uxB3.BackColor = c[l];
                            break;
                        case "B5":
                            if (data[4, 1] != 1)
                                uxB5.BackColor = c[l];
                            break;
                        case "B7":
                            if (data[6, 1] != 1)
                                uxB7.BackColor = c[l];
                            break;
                        case "B9":
                            if (data[8, 1] != 1)
                                uxB9.BackColor = c[l];
                            break;

                        case "C2":
                            if (data[1, 2] != 1)
                                uxC2.BackColor = c[l];
                            break;
                        case "C4":
                            if (data[3, 2] != 1)
                                uxC4.BackColor = c[l];
                            break;
                        case "C6":
                            if (data[5, 2] != 1)
                                uxC6.BackColor = c[l];
                            break;
                        case "C8":
                            if (data[7, 2] != 1)
                                uxC8.BackColor = c[l];
                            break;
                        case "C10":
                            if (data[9, 2] != 1)
                                uxC10.BackColor = c[l];
                            break;

                        case "D1":
                            if (data[0, 3] != 1)
                                uxD1.BackColor = c[l];
                            break;
                        case "D3":
                            if (data[2, 3] != 1)
                                uxD3.BackColor = c[l];
                            break;
                        case "D5":
                            if (data[4, 3] != 1)
                                uxD5.BackColor = c[l];
                            break;
                        case "D7":
                            if (data[6, 3] != 1)
                                uxD7.BackColor = c[l];
                            break;
                        case "D9":
                            if (data[8, 3] != 1)
                                uxD9.BackColor = c[l];
                            break;

                        case "E2":
                            if (data[1, 4] != 1)
                                uxE2.BackColor = c[l];
                            break;
                        case "E4":
                            if (data[3, 4] != 1)
                                uxE4.BackColor = c[l];
                            break;
                        case "E6":
                            if (data[5, 4] != 1)
                                uxE6.BackColor = c[l];
                            break;
                        case "E8":
                            if (data[7, 4] != 1)
                                uxE8.BackColor = c[l];
                            break;
                        case "E10":
                            if (data[9, 4] != 1)
                                uxE10.BackColor = c[l];
                            break;

                        case "F1":
                            if (data[0, 5] != 1)
                                uxF1.BackColor = c[l];
                            break;
                        case "F3":
                            if (data[2, 5] != 1)
                                uxF3.BackColor = c[l];
                            break;
                        case "F5":
                            if (data[4, 5] != 1)
                                uxF5.BackColor = c[l];
                            break;
                        case "F7":
                            if (data[6, 5] != 1)
                                uxF7.BackColor = c[l];
                            break;
                        case "F9":
                            if (data[8, 5] != 1)
                                uxF9.BackColor = c[l];
                            break;

                        case "G2":
                            if (data[1, 6] != 1)
                                uxG2.BackColor = c[l];
                            break;
                        case "G4":
                            if (data[3, 6] != 1)
                                uxG4.BackColor = c[l];
                            break;
                        case "G6":
                            if (data[5, 6] != 1)
                                uxG6.BackColor = c[l];
                            break;
                        case "G8":
                            if (data[7, 6] != 1)
                                uxG8.BackColor = c[l];
                            break;
                        case "G10":
                            if (data[9, 6] != 1)
                                uxG10.BackColor = c[l];
                            break;

                        case "H1":
                            if (data[0, 7] != 1)
                                uxH1.BackColor = c[l];
                            break;
                        case "H3":
                            if (data[2, 7] != 1)
                                uxH3.BackColor = c[l];
                            break;
                        case "H5":
                            if (data[4, 7] != 1)
                                uxH5.BackColor = c[l];
                            break;
                        case "H7":
                            if (data[6, 7] != 1)
                                uxH7.BackColor = c[l];
                            break;
                        case "H9":
                            if (data[8, 7] != 1)
                                uxH9.BackColor = c[l];
                            break;

                        case "I2":
                            if (data[1, 8] != 1)
                                uxI2.BackColor = c[l];
                            break;
                        case "I4":
                            if (data[3, 8] != 1)
                                uxI4.BackColor = c[l];
                            break;
                        case "I6":
                            if (data[5, 8] != 1)
                                uxI6.BackColor = c[l];
                            break;
                        case "I8":
                            if (data[7, 8] != 1)
                                uxI8.BackColor = c[l];
                            break;
                        case "I10":
                            if (data[9, 8] != 1)
                                uxI10.BackColor = c[l];
                            break;

                        case "J1":
                            if (data[0, 9] != 1)
                                uxJ1.BackColor = c[l];
                            break;
                        case "J3":
                            if (data[2, 9] != 1)
                                uxJ3.BackColor = c[l];
                            break;
                        case "J5":
                            if (data[4, 9] != 1)
                                uxJ5.BackColor = c[l];
                            break;
                        case "J7":
                            if (data[6, 9] != 1)
                                uxJ7.BackColor = c[l];
                            break;
                        case "J9":
                            if (data[8, 9] != 1)
                                uxJ9.BackColor = c[l];
                            break;
                        default:
                            l--;
                            break;
                    }
                    t++;
                }
                if (state == ParityType.three1)
                {
                    switch (positions[t])
                    {
                        case "A1":
                            if (data[0, 0] != 1 && Hit[0, 0] != 1)
                                uxA1.BackColor = c[l];
                            break;
                        case "A4":
                            if (data[3, 0] != 1 && Hit[3, 0] != 1)
                                uxA4.BackColor = c[l];
                            break;
                        case "A7":
                            if (data[6, 0] != 1 && Hit[6, 0] != 1)
                                uxA7.BackColor = c[l];
                            break;
                        case "A10":
                            if (data[9, 0] != 1 && Hit[9, 0] != 1)
                                uxA10.BackColor = c[l];
                            break;

                        case "B2":
                            if (data[1, 1] != 1 && Hit[1, 1] != 1)
                                uxB2.BackColor = c[l];
                            break;
                        case "B5":
                            if (data[4, 1] != 1 && Hit[4, 1] != 1)
                                uxB5.BackColor = c[l];
                            break;
                        case "B8":
                            if (data[7, 1] != 1 && Hit[7, 1] != 1)
                                uxB8.BackColor = c[l];
                            break;

                        case "C3":
                            if (data[2, 2] != 1 && Hit[2, 2] != 1)
                                uxC3.BackColor = c[l];
                            break;
                        case "C6":
                            if (data[5, 2] != 1 && Hit[5, 2] != 1)
                                uxC6.BackColor = c[l];
                            break;
                        case "C9":
                            if (data[8, 2] != 1 && Hit[8, 2] != 1)
                                uxC9.BackColor = c[l];
                            break;

                        case "D1":
                            if (data[0, 3] != 1 && Hit[0, 3] != 1)
                                uxD1.BackColor = c[l];
                            break;
                        case "D4":
                            if (data[3, 3] != 1 && Hit[3, 3] != 1)
                                uxD4.BackColor = c[l];
                            break;
                        case "D7":
                            if (data[6, 3] != 1 && Hit[6, 3] != 1)
                                uxD7.BackColor = c[l];
                            break;
                        case "D10":
                            if (data[9, 3] != 1 && Hit[9, 3] != 1)
                                uxD10.BackColor = c[l];
                            break;

                        case "E2":
                            if (data[1, 4] != 1 && Hit[1, 4] != 1)
                                uxE2.BackColor = c[l];
                            break;
                        case "E5":
                            if (data[4, 4] != 1 && Hit[4, 4] != 1)
                                uxE5.BackColor = c[l];
                            break;
                        case "E8":
                            if (data[7, 4] != 1 && Hit[7, 4] != 1)
                                uxE8.BackColor = c[l];
                            break;

                        case "F3":
                            if (data[2, 5] != 1 && Hit[2, 5] != 1)
                                uxF3.BackColor = c[l];
                            break;
                        case "F6":
                            if (data[5, 5] != 1 && Hit[5, 5] != 1)
                                uxF6.BackColor = c[l];
                            break;
                        case "F9":
                            if (data[8, 5] != 1 && Hit[8, 5] != 1)
                                uxF9.BackColor = c[l];
                            break;

                        case "G1":
                            if (data[0, 6] != 1 && Hit[0, 6] != 1)
                                uxG1.BackColor = c[l];
                            break;
                        case "G4":
                            if (data[3, 6] != 1 && Hit[3, 6] != 1)
                                uxG4.BackColor = c[l];
                            break;
                        case "G7":
                            if (data[6, 6] != 1 && Hit[6, 6] != 1)
                                uxG7.BackColor = c[l];
                            break;
                        case "G10":
                            if (data[9, 6] != 1 && Hit[9, 6] != 1)
                                uxG10.BackColor = c[l];
                            break;

                        case "H2":
                            if (data[1, 7] != 1 && Hit[1, 7] != 1)
                                uxH2.BackColor = c[l];
                            break;
                        case "H5":
                            if (data[4, 7] != 1 && Hit[4, 7] != 1)
                                uxH5.BackColor = c[l];
                            break;
                        case "H8":
                            if (data[7, 7] != 1 && Hit[7, 7] != 1)
                                uxH8.BackColor = c[l];
                            break;

                        case "I3":
                            if (data[2, 8] != 1 && Hit[2, 8] != 1)
                                uxI3.BackColor = c[l];
                            break;
                        case "I6":
                            if (data[5, 8] != 1 && Hit[5, 8] != 1)
                                uxI6.BackColor = c[l];
                            break;
                        case "I9":
                            if (data[8, 8] != 1 && Hit[8, 8] != 1)
                                uxI9.BackColor = c[l];
                            break;

                        case "J1":
                            if (data[0, 9] != 1 && Hit[0, 9] != 1)
                                uxJ1.BackColor = c[l];
                            break;
                        case "J4":
                            if (data[3, 9] != 1 && Hit[3, 9] != 1)
                                uxJ4.BackColor = c[l];
                            break;
                        case "J7":
                            if (data[6, 9] != 1 && Hit[6, 9] != 1)
                                uxJ7.BackColor = c[l];
                            break;
                        case "J10":
                            if (data[9, 9] != 1 && Hit[9, 9] != 1)
                                uxJ10.BackColor = c[l];
                            break;
                        default:
                            l--;
                            break;
                    }
                    t++;
                }
                if (state == ParityType.three2)
                {
                    switch (positions[t])
                    {
                        case "A2":
                            if (data[1, 0] != 1 && Hit[1, 0] != 1)
                                uxA2.BackColor = c[l];
                            break;
                        case "A5":
                            if (data[4, 0] != 1 && Hit[4, 0] != 1)
                                uxA5.BackColor = c[l];
                            break;
                        case "A8":
                            if (data[7, 0] != 1 && Hit[7, 0] != 1)
                                uxA8.BackColor = c[l];
                            break;

                        case "B3":
                            if (data[2, 1] != 1 && Hit[2, 1] != 1)
                                uxB3.BackColor = c[l];
                            break;
                        case "B6":
                            if (data[5, 1] != 1 && Hit[5, 1] != 1)
                                uxB6.BackColor = c[l];
                            break;
                        case "B9":
                            if (data[8, 1] != 1 && Hit[8, 1] != 1)
                                uxB9.BackColor = c[l];
                            break;

                        case "C1":
                            if (data[0, 2] != 1 && Hit[0, 2] != 1)
                                uxC1.BackColor = c[l];
                            break;
                        case "C4":
                            if (data[3, 2] != 1 && Hit[3, 2] != 1)
                                uxC4.BackColor = c[l];
                            break;
                        case "C7":
                            if (data[6, 2] != 1 && Hit[6, 2] != 1)
                                uxC7.BackColor = c[l];
                            break;
                        case "C10":
                            if (data[9, 2] != 1 && Hit[9, 2] != 1)
                                uxC10.BackColor = c[l];
                            break;

                        case "D2":
                            if (data[1, 3] != 1 && Hit[1, 3] != 1)
                                uxD2.BackColor = c[l];
                            break;
                        case "D5":
                            if (data[4, 3] != 1 && Hit[4, 3] != 1)
                                uxD5.BackColor = c[l];
                            break;
                        case "D8":
                            if (data[7, 3] != 1 && Hit[7, 3] != 1)
                                uxD8.BackColor = c[l];
                            break;

                        case "E3":
                            if (data[2, 4] != 1 && Hit[2, 4] != 1)
                                uxE3.BackColor = c[l];
                            break;
                        case "E6":
                            if (data[5, 4] != 1 && Hit[5, 4] != 1)
                                uxE6.BackColor = c[l];
                            break;
                        case "E9":
                            if (data[8, 4] != 1 && Hit[8, 4] != 1)
                                uxE9.BackColor = c[l];
                            break;

                        case "F1":
                            if (data[0, 5] != 1 && Hit[0, 5] != 1)
                                uxF1.BackColor = c[l];
                            break;
                        case "F4":
                            if (data[3, 5] != 1 && Hit[3, 5] != 1)
                                uxF4.BackColor = c[l];
                            break;
                        case "F7":
                            if (data[6, 5] != 1 && Hit[6, 5] != 1)
                                uxF7.BackColor = c[l];
                            break;
                        case "F10":
                            if (data[9, 5] != 1 && Hit[9, 5] != 1)
                                uxF10.BackColor = c[l];
                            break;

                        case "G2":
                            if (data[1, 6] != 1 && Hit[1, 6] != 1)
                                uxG2.BackColor = c[l];
                            break;
                        case "G5":
                            if (data[4, 6] != 1 && Hit[4, 6] != 1)
                                uxG5.BackColor = c[l];
                            break;
                        case "G8":
                            if (data[7, 6] != 1 && Hit[7, 6] != 1)
                                uxG8.BackColor = c[l];
                            break;

                        case "H3":
                            if (data[2, 7] != 1 && Hit[2, 7] != 1)
                                uxH3.BackColor = c[l];
                            break;
                        case "H6":
                            if (data[5, 7] != 1 && Hit[5, 7] != 1)
                                uxH6.BackColor = c[l];
                            break;
                        case "H9":
                            if (data[8, 7] != 1 && Hit[8, 7] != 1)
                                uxH9.BackColor = c[l];
                            break;

                        case "I1":
                            if (data[0, 8] != 1 && Hit[0, 8] != 1)
                                uxI1.BackColor = c[l];
                            break;
                        case "I4":
                            if (data[3, 8] != 1 && Hit[3, 8] != 1)
                                uxI4.BackColor = c[l];
                            break;
                        case "I7":
                            if (data[6, 8] != 1 && Hit[6, 8] != 1)
                                uxI7.BackColor = c[l];
                            break;
                        case "I10":
                            if (data[9, 8] != 1 && Hit[9, 8] != 1)
                                uxI10.BackColor = c[l];
                            break;

                        case "J2":
                            if (data[1, 9] != 1 && Hit[1, 9] != 1)
                                uxJ2.BackColor = c[l];
                            break;
                        case "J5":
                            if (data[4, 9] != 1 && Hit[4, 9] != 1)
                                uxJ5.BackColor = c[l];
                            break;
                        case "J8":
                            if (data[7, 9] != 1 && Hit[7, 9] != 1)
                                uxJ8.BackColor = c[l];
                            break;
                        default:
                            l--;
                            break;
                    }
                    t++;
                }
                if (state == ParityType.three3)
                {
                    switch (positions[t])
                    {
                        case "A1":
                            if (data[0, 0] != 1 && Hit[0, 0] != 1)
                                uxA1.BackColor = c[l];
                            break;
                        case "A4":
                            if (data[3, 0] != 1 && Hit[3, 0] != 1)
                                uxA4.BackColor = c[l];
                            break;
                        case "A7":
                            if (data[6, 0] != 1 && Hit[6, 0] != 1)
                                uxA7.BackColor = c[l];
                            break;
                        case "A10":
                            if (data[9, 0] != 1 && Hit[9, 0] != 1)
                                uxA10.BackColor = c[l];
                            break;

                        case "B3":
                            if (data[2, 1] != 1 && Hit[2, 1] != 1)
                                uxB3.BackColor = c[l];
                            break;
                        case "B6":
                            if (data[5, 1] != 1 && Hit[5, 1] != 1)
                                uxB6.BackColor = c[l];
                            break;
                        case "B9":
                            if (data[8, 1] != 1 && Hit[8, 1] != 1)
                                uxB9.BackColor = c[l];
                            break;

                        case "C2":
                            if (data[1, 2] != 1 && Hit[1, 2] != 1)
                                uxC2.BackColor = c[l];
                            break;
                        case "C5":
                            if (data[4, 2] != 1 && Hit[4, 2] != 1)
                                uxC5.BackColor = c[l];
                            break;
                        case "C8":
                            if (data[7, 2] != 1 && Hit[7, 2] != 1)
                                uxC8.BackColor = c[l];
                            break;

                        case "D1":
                            if (data[0, 3] != 1 && Hit[0, 3] != 1)
                                uxD1.BackColor = c[l];
                            break;
                        case "D4":
                            if (data[3, 3] != 1 && Hit[3, 3] != 1)
                                uxD4.BackColor = c[l];
                            break;
                        case "D7":
                            if (data[6, 3] != 1 && Hit[6, 3] != 1)
                                uxD7.BackColor = c[l];
                            break;
                        case "D10":
                            if (data[9, 3] != 1 && Hit[9, 3] != 1)
                                uxD10.BackColor = c[l];
                            break;

                        case "E3":
                            if (data[2, 4] != 1 && Hit[2, 4] != 1)
                                uxE3.BackColor = c[l];
                            break;
                        case "E6":
                            if (data[5, 4] != 1 && Hit[5, 4] != 1)
                                uxE6.BackColor = c[l];
                            break;
                        case "E9":
                            if (data[8, 4] != 1 && Hit[8, 4] != 1)
                                uxE9.BackColor = c[l];
                            break;

                        case "F2":
                            if (data[1, 5] != 1 && Hit[1, 5] != 1)
                                uxF2.BackColor = c[l];
                            break;
                        case "F5":
                            if (data[4, 5] != 1 && Hit[4, 5] != 1)
                                uxF5.BackColor = c[l];
                            break;
                        case "F8":
                            if (data[7, 5] != 1 && Hit[7, 5] != 1)
                                uxF8.BackColor = c[l];
                            break;

                        case "G1":
                            if (data[0, 6] != 1 && Hit[0, 6] != 1)
                                uxG1.BackColor = c[l];
                            break;
                        case "G4":
                            if (data[3, 6] != 1 && Hit[3, 6] != 1)
                                uxG4.BackColor = c[l];
                            break;
                        case "G7":
                            if (data[6, 6] != 1 && Hit[6, 6] != 1)
                                uxG7.BackColor = c[l];
                            break;
                        case "G10":
                            if (data[9, 6] != 1 && Hit[9, 6] != 1)
                                uxG10.BackColor = c[l];
                            break;

                        case "H3":
                            if (data[2, 7] != 1 && Hit[2, 7] != 1)
                                uxH3.BackColor = c[l];
                            break;
                        case "H6":
                            if (data[5, 7] != 1 && Hit[5, 7] != 1)
                                uxH6.BackColor = c[l];
                            break;
                        case "H9":
                            if (data[8, 7] != 1 && Hit[8, 7] != 1)
                                uxH9.BackColor = c[l];
                            break;

                        case "I2":
                            if (data[1, 8] != 1 && Hit[1, 8] != 1)
                                uxI2.BackColor = c[l];
                            break;
                        case "I5":
                            if (data[4, 8] != 1 && Hit[4, 8] != 1)
                                uxI5.BackColor = c[l];
                            break;
                        case "I8":
                            if (data[7, 8] != 1 && Hit[7, 8] != 1)
                                uxI8.BackColor = c[l];
                            break;

                        case "J1":
                            if (data[0, 9] != 1 && Hit[0, 9] != 1)
                                uxJ1.BackColor = c[l];
                            break;
                        case "J4":
                            if (data[3, 9] != 1 && Hit[3, 9] != 1)
                                uxJ4.BackColor = c[l];
                            break;
                        case "J7":
                            if (data[6, 9] != 1 && Hit[6, 9] != 1)
                                uxJ7.BackColor = c[l];
                            break;
                        case "J10":
                            if (data[9, 9] != 1 && Hit[9, 9] != 1)
                                uxJ10.BackColor = c[l];
                            break;
                        default:
                            l--;
                            break;
                    }
                    t++;
                }
                if (state == ParityType.three4)
                {
                    switch (positions[t])
                    {
                        case "A2":
                            if (data[1, 0] != 1 && Hit[1, 0] != 1)
                                uxA2.BackColor = c[l];
                            break;
                        case "A5":
                            if (data[4, 0] != 1 && Hit[4, 0] != 1)
                                uxA5.BackColor = c[l];
                            break;
                        case "A8":
                            if (data[7, 0] != 1 && Hit[7, 0] != 1)
                                uxA8.BackColor = c[l];
                            break;

                        case "B1":
                            if (data[0, 1] != 1 && Hit[0, 1] != 1)
                                uxB1.BackColor = c[l];
                            break;
                        case "B4":
                            if (data[3, 1] != 1 && Hit[3, 1] != 1)
                                uxB4.BackColor = c[l];
                            break;
                        case "B7":
                            if (data[6, 1] != 1 && Hit[6, 1] != 1)
                                uxB7.BackColor = c[l];
                            break;
                        case "B10":
                            if (data[9, 1] != 1 && Hit[9, 1] != 1)
                                uxB10.BackColor = c[l];
                            break;

                        case "C3":
                            if (data[2, 2] != 1 && Hit[2, 2] != 1)
                                uxC3.BackColor = c[l];
                            break;
                        case "C6":
                            if (data[5, 2] != 1 && Hit[5, 2] != 1)
                                uxC6.BackColor = c[l];
                            break;
                        case "C9":
                            if (data[8, 2] != 1 && Hit[8, 2] != 1)
                                uxC9.BackColor = c[l]; ;
                            break;

                        case "D2":
                            if (data[1, 3] != 1 && Hit[1, 3] != 1)
                                uxD2.BackColor = c[l];
                            break;
                        case "D5":
                            if (data[4, 3] != 1 && Hit[4, 3] != 1)
                                uxD5.BackColor = c[l];
                            break;
                        case "D8":
                            if (data[7, 3] != 1 && Hit[7, 3] != 1)
                                uxD8.BackColor = c[l];
                            break;

                        case "E1":
                            if (data[0, 4] != 1 && Hit[0, 4] != 1)
                                uxE1.BackColor = c[l];
                            break;
                        case "E4":
                            if (data[3, 4] != 1 && Hit[3, 4] != 1)
                                uxE4.BackColor = c[l];
                            break;
                        case "E7":
                            if (data[6, 4] != 1 && Hit[6, 4] != 1)
                                uxE7.BackColor = c[l];
                            break;
                        case "E10":
                            if (data[9, 4] != 1 && Hit[9, 4] != 1)
                                uxE10.BackColor = c[l];
                            break;

                        case "F3":
                            if (data[2, 5] != 1 && Hit[2, 5] != 1)
                                uxF3.BackColor = c[l];
                            break;
                        case "F6":
                            if (data[5, 5] != 1 && Hit[5, 5] != 1)
                                uxF6.BackColor = c[l];
                            break;
                        case "F9":
                            if (data[8, 5] != 1 && Hit[8, 5] != 1)
                                uxF9.BackColor = c[l];
                            break;

                        case "G2":
                            if (data[1, 6] != 1 && Hit[1, 6] != 1)
                                uxG2.BackColor = c[l];
                            break;
                        case "G5":
                            if (data[4, 6] != 1 && Hit[4, 6] != 1)
                                uxG5.BackColor = c[l];
                            break;
                        case "G8":
                            if (data[7, 6] != 1 && Hit[7, 6] != 1)
                                uxG8.BackColor = c[l];
                            break;

                        case "H1":
                            if (data[0, 7] != 1 && Hit[0, 7] != 1)
                                uxH1.BackColor = c[l];
                            break;
                        case "H4":
                            if (data[3, 7] != 1 && Hit[3, 7] != 1)
                                uxH4.BackColor = c[l];
                            break;
                        case "H7":
                            if (data[6, 7] != 1 && Hit[6, 7] != 1)
                                uxH7.BackColor = c[l];
                            break;
                        case "H10":
                            if (data[9, 7] != 1 && Hit[9, 7] != 1)
                                uxH10.BackColor = c[l];
                            break;

                        case "I3":
                            if (data[2, 8] != 1 && Hit[2, 8] != 1)
                                uxI3.BackColor = c[l];
                            break;
                        case "I6":
                            if (data[5, 8] != 1 && Hit[5, 8] != 1)
                                uxI6.BackColor = c[l];
                            break;
                        case "I9":
                            if (data[8, 8] != 1 && Hit[8, 8] != 1)
                                uxI9.BackColor = c[l];
                            break;

                        case "J2":
                            if (data[1, 9] != 1 && Hit[1, 9] != 1)
                                uxJ2.BackColor = c[l];
                            break;
                        case "J5":
                            if (data[4, 9] != 1 && Hit[4, 9] != 1)
                                uxJ5.BackColor = c[l];
                            break;
                        case "J8":
                            if (data[7, 9] != 1 && Hit[7, 9] != 1)
                                uxJ8.BackColor = c[l];
                            break;
                        default:
                            l--;
                            break;
                    }
                    t++;
                }
            }

            int temp = 0;
            for (int p = 0; p < 10; p++)
            {
                for (int n = 0; n < 10; n++)
                {
                    if (Hit[p, n] == 1)
                    {
                        temp++;                    
                    }
                }
            }
            if (temp >= 1)
            {
                hitTrue = true;
                Calcualte_Hit();
                Hit_To_PDF();


                int[] ca = To1DArray(PDF);
                Array.Sort(ca);
                Array.Reverse(ca);

                m = 0;
                for (int g = 0; g < 5; g++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (PDF[i, j].Equals(ca[m]))
                            {
                                char letter = (char)(j + 65);
                                char number = (char)(i + 49);
                                char[] chars = { letter, number, };
                                string s = new string(chars);
                                if (number == ':')
                                {
                                    s = letter + "10";
                                }
                                positions[m] = s;
                                if (m < 99)
                                    m++;
                            }
                        }
                    }
                }
            }
            else
                hitTrue = false;

            if (hitTrue == true && toggleOn == false)
            {
                switch (positions[0])
                {
                    case "A1":
                        if (Hit[0, 0] != 1)
                            uxA1.BackColor = Color.MediumVioletRed;
                        break;
                    case "A3":
                        if (Hit[2, 0] != 1)
                            uxA3.BackColor = Color.MediumVioletRed;
                        break;
                    case "A5":
                        if (Hit[4, 0] != 1)
                            uxA5.BackColor = Color.MediumVioletRed;
                        break;
                    case "A7":
                        if (Hit[6, 0] != 1)
                            uxA7.BackColor = Color.MediumVioletRed;
                        break;
                    case "A9":
                        if (Hit[8, 0] != 1)
                            uxA9.BackColor = Color.MediumVioletRed;
                        break;

                    case "B2":
                        if (Hit[1, 1] != 1)
                            uxB2.BackColor = Color.MediumVioletRed;
                        break;
                    case "B4":
                        if (Hit[3, 1] != 1)
                            uxB4.BackColor = Color.MediumVioletRed;
                        break;
                    case "B6":
                        if (Hit[5, 1] != 1)
                            uxB6.BackColor = Color.MediumVioletRed;
                        break;
                    case "B8":
                        if (Hit[7, 1] != 1)
                            uxB8.BackColor = Color.MediumVioletRed;
                        break;
                    case "B10":
                        if (Hit[9, 1] != 1)
                            uxB10.BackColor = Color.MediumVioletRed;
                        break;

                    case "C1":
                        if (Hit[0, 2] != 1)
                            uxC1.BackColor = Color.MediumVioletRed;
                        break;
                    case "C3":
                        if (Hit[2, 2] != 1)
                            uxC3.BackColor = Color.MediumVioletRed;
                        break;
                    case "C5":
                        if (Hit[4, 2] != 1)
                            uxC5.BackColor = Color.MediumVioletRed;
                        break;
                    case "C7":
                        if (Hit[6, 2] != 1)
                            uxC7.BackColor = Color.MediumVioletRed;
                        break;
                    case "C9":
                        if (Hit[8, 2] != 1)
                            uxC9.BackColor = Color.MediumVioletRed;
                        break;

                    case "D2":
                        if (Hit[1, 3] != 1)
                            uxD2.BackColor = Color.MediumVioletRed;
                        break;
                    case "D4":
                        if (Hit[3, 3] != 1)
                            uxD4.BackColor = Color.MediumVioletRed;
                        break;
                    case "D6":
                        if (Hit[5, 3] != 1)
                            uxD6.BackColor = Color.MediumVioletRed;
                        break;
                    case "D8":
                        if (Hit[7, 3] != 1)
                            uxD8.BackColor = Color.MediumVioletRed;
                        break;
                    case "D10":
                        if (Hit[9, 3] != 1)
                            uxD10.BackColor = Color.MediumVioletRed;
                        break;

                    case "E1":
                        if (Hit[0, 4] != 1)
                            uxE1.BackColor = Color.MediumVioletRed;
                        break;
                    case "E3":
                        if (Hit[2, 4] != 1)
                            uxE3.BackColor = Color.MediumVioletRed;
                        break;
                    case "E5":
                        if (Hit[4, 4] != 1)
                            uxE5.BackColor = Color.MediumVioletRed;
                        break;
                    case "E7":
                        if (Hit[6, 4] != 1)
                            uxE7.BackColor = Color.MediumVioletRed;
                        break;
                    case "E9":
                        if (Hit[8, 4] != 1)
                            uxE9.BackColor = Color.MediumVioletRed;
                        break;

                    case "F2":
                        if (Hit[1, 5] != 1)
                            uxF2.BackColor = Color.MediumVioletRed;
                        break;
                    case "F4":
                        if (Hit[3, 5] != 1)
                            uxF4.BackColor = Color.MediumVioletRed;
                        break;
                    case "F6":
                        if (Hit[5, 5] != 1)
                            uxF6.BackColor = Color.MediumVioletRed;
                        break;
                    case "F8":
                        if (Hit[7, 5] != 1)
                            uxF8.BackColor = Color.MediumVioletRed;
                        break;
                    case "F10":
                        if (Hit[9, 5] != 1)
                            uxF10.BackColor = Color.MediumVioletRed;
                        break;
                    case "G1":
                        if (Hit[0, 6] != 1)
                            uxG1.BackColor = Color.MediumVioletRed;
                        break;
                    case "G3":
                        if (Hit[2, 6] != 1)
                            uxG3.BackColor = Color.MediumVioletRed;
                        break;
                    case "G5":
                        if (Hit[4, 6] != 1)
                            uxG5.BackColor = Color.MediumVioletRed;
                        break;
                    case "G7":
                        if (Hit[6, 6] != 1)
                            uxG7.BackColor = Color.MediumVioletRed;
                        break;
                    case "G9":
                        if (Hit[8, 6] != 1)
                            uxG9.BackColor = Color.MediumVioletRed;
                        break;

                    case "H2":
                        if (Hit[1, 7] != 1)
                            uxH2.BackColor = Color.MediumVioletRed;
                        break;
                    case "H4":
                        if (Hit[3, 7] != 1)
                            uxH4.BackColor = Color.MediumVioletRed;
                        break;
                    case "H6":
                        if (Hit[5, 7] != 1)
                            uxH6.BackColor = Color.MediumVioletRed;
                        break;
                    case "H8":
                        if (Hit[7, 7] != 1)
                            uxH8.BackColor = Color.MediumVioletRed;
                        break;
                    case "H10":
                        if (Hit[9, 7] != 1)
                            uxH10.BackColor = Color.MediumVioletRed;
                        break;

                    case "I1":
                        if (Hit[0, 8] != 1)
                            uxI1.BackColor = Color.MediumVioletRed;
                        break;
                    case "I3":
                        if (Hit[2, 8] != 1)
                            uxI3.BackColor = Color.MediumVioletRed;
                        break;
                    case "I5":
                        if (Hit[4, 8] != 1)
                            uxI5.BackColor = Color.MediumVioletRed;
                        break;
                    case "I7":
                        if (Hit[6, 8] != 1)
                            uxI7.BackColor = Color.MediumVioletRed;
                        break;
                    case "I9":
                        if (Hit[8, 8] != 1)
                            uxI9.BackColor = Color.MediumVioletRed;
                        break;

                    case "J2":
                        if (Hit[1, 9] != 1)
                            uxJ2.BackColor = Color.MediumVioletRed;
                        break;
                    case "J4":
                        if (Hit[3, 9] != 1)
                            uxJ4.BackColor = Color.MediumVioletRed;
                        break;
                    case "J6":
                        if (Hit[5, 9] != 1)
                            uxJ6.BackColor = Color.MediumVioletRed;
                        break;
                    case "J8":
                        if (Hit[7, 9] != 1)
                            uxJ8.BackColor = Color.MediumVioletRed;
                        break;
                    case "J10":
                        if (Hit[9, 9] != 1)
                            uxJ10.BackColor = Color.MediumVioletRed;
                        break;
                    case "A2":
                        if (Hit[1, 0] != 1)
                            uxA2.BackColor = Color.MediumVioletRed;
                        break;
                    case "A4":
                        if (Hit[3, 0] != 1)
                            uxA4.BackColor = Color.MediumVioletRed;
                        break;
                    case "A6":
                        if (Hit[4, 0] != 1)
                            uxA6.BackColor = Color.MediumVioletRed;
                        break;
                    case "A8":
                        if (Hit[5, 0] != 1)
                            uxA8.BackColor = Color.MediumVioletRed;
                        break;
                    case "A10":
                        if (Hit[9, 0] != 1)
                            uxA10.BackColor = Color.MediumVioletRed;
                        break;

                    case "B1":
                        if (Hit[0, 1] != 1)
                            uxB1.BackColor = Color.MediumVioletRed;
                        break;
                    case "B3":
                        if (Hit[2, 1] != 1)
                            uxB3.BackColor = Color.MediumVioletRed;
                        break;
                    case "B5":
                        if (Hit[4, 1] != 1)
                            uxB5.BackColor = Color.MediumVioletRed;
                        break;
                    case "B7":
                        if (Hit[6, 1] != 1)
                            uxB7.BackColor = Color.MediumVioletRed;
                        break;
                    case "B9":
                        if (Hit[8, 1] != 1)
                            uxB9.BackColor = Color.MediumVioletRed;
                        break;

                    case "C2":
                        if (Hit[1, 2] != 1)
                            uxC2.BackColor = Color.MediumVioletRed;
                        break;
                    case "C4":
                        if (Hit[3, 2] != 1)
                            uxC4.BackColor = Color.MediumVioletRed;
                        break;
                    case "C6":
                        if (Hit[5, 2] != 1)
                            uxC6.BackColor = Color.MediumVioletRed;
                        break;
                    case "C8":
                        if (Hit[7, 2] != 1)
                            uxC8.BackColor = Color.MediumVioletRed;
                        break;
                    case "C10":
                        if (Hit[9, 2] != 1)
                            uxC10.BackColor = Color.MediumVioletRed;
                        break;

                    case "D1":
                        if (Hit[0, 3] != 1)
                            uxD1.BackColor = Color.MediumVioletRed;
                        break;
                    case "D3":
                        if (Hit[2, 3] != 1)
                            uxD3.BackColor = Color.MediumVioletRed;
                        break;
                    case "D5":
                        if (Hit[4, 3] != 1)
                            uxD5.BackColor = Color.MediumVioletRed;
                        break;
                    case "D7":
                        if (Hit[6, 3] != 1)
                            uxD7.BackColor = Color.MediumVioletRed;
                        break;
                    case "D9":
                        if (Hit[8, 3] != 1)
                            uxD9.BackColor = Color.MediumVioletRed;
                        break;

                    case "E2":
                        if (Hit[1, 4] != 1)
                            uxE2.BackColor = Color.MediumVioletRed;
                        break;
                    case "E4":
                        if (Hit[3, 4] != 1)
                            uxE4.BackColor = Color.MediumVioletRed;
                        break;
                    case "E6":
                        if (Hit[5, 4] != 1)
                            uxE6.BackColor = Color.MediumVioletRed;
                        break;
                    case "E8":
                        if (Hit[7, 4] != 1)
                            uxE8.BackColor = Color.MediumVioletRed;
                        break;
                    case "E10":
                        if (Hit[9, 4] != 1)
                            uxE10.BackColor = Color.MediumVioletRed;
                        break;

                    case "F1":
                        if (Hit[0, 5] != 1)
                            uxF1.BackColor = Color.MediumVioletRed;
                        break;
                    case "F3":
                        if (Hit[2, 5] != 1)
                            uxF3.BackColor = Color.MediumVioletRed;
                        break;
                    case "F5":
                        if (Hit[4, 5] != 1)
                            uxF5.BackColor = Color.MediumVioletRed;
                        break;
                    case "F7":
                        if (Hit[6, 5] != 1)
                            uxF7.BackColor = Color.MediumVioletRed;
                        break;
                    case "F9":
                        if (Hit[8, 5] != 1)
                            uxF9.BackColor = Color.MediumVioletRed;
                        break;

                    case "G2":
                        if (Hit[1, 6] != 1)
                            uxG2.BackColor = Color.MediumVioletRed;
                        break;
                    case "G4":
                        if (Hit[3, 6] != 1)
                            uxG4.BackColor = Color.MediumVioletRed;
                        break;
                    case "G6":
                        if (Hit[5, 6] != 1)
                            uxG6.BackColor = Color.MediumVioletRed;
                        break;
                    case "G8":
                        if (Hit[7, 6] != 1)
                            uxG8.BackColor = Color.MediumVioletRed;
                        break;
                    case "G10":
                        if (Hit[9, 6] != 1)
                            uxG10.BackColor = Color.MediumVioletRed;
                        break;

                    case "H1":
                        if (Hit[0, 7] != 1)
                            uxH1.BackColor = Color.MediumVioletRed;
                        break;
                    case "H3":
                        if (Hit[2, 7] != 1)
                            uxH3.BackColor = Color.MediumVioletRed;
                        break;
                    case "H5":
                        if (Hit[4, 7] != 1)
                            uxH5.BackColor = Color.MediumVioletRed;
                        break;
                    case "H7":
                        if (Hit[6, 7] != 1)
                            uxH7.BackColor = Color.MediumVioletRed;
                        break;
                    case "H9":
                        if (Hit[8, 7] != 1)
                            uxH9.BackColor = Color.MediumVioletRed;
                        break;

                    case "I2":
                        if (Hit[1, 8] != 1)
                            uxI2.BackColor = Color.MediumVioletRed;
                        break;
                    case "I4":
                        if (Hit[3, 8] != 1)
                            uxI4.BackColor = Color.MediumVioletRed;
                        break;
                    case "I6":
                        if (Hit[5, 8] != 1)
                            uxI6.BackColor = Color.MediumVioletRed;
                        break;
                    case "I8":
                        if (Hit[7, 8] != 1)
                            uxI8.BackColor = Color.MediumVioletRed;
                        break;
                    case "I10":
                        if (Hit[9, 8] != 1)
                            uxI10.BackColor = Color.MediumVioletRed;
                        break;

                    case "J1":
                        if (Hit[0, 9] != 1)
                            uxJ1.BackColor = Color.MediumVioletRed;
                        break;
                    case "J3":
                        if (Hit[2, 9] != 1)
                            uxJ3.BackColor = Color.MediumVioletRed;
                        break;
                    case "J5":
                        if (Hit[4, 9] != 1)
                            uxJ5.BackColor = Color.MediumVioletRed;
                        break;
                    case "J7":
                        if (Hit[6, 9] != 1)
                            uxJ7.BackColor = Color.MediumVioletRed;
                        break;
                    case "J9":
                        if (Hit[8, 9] != 1)
                            uxJ9.BackColor = Color.MediumVioletRed;
                        break;
                }
            }
            
            //Show_Msg();
        }
        public void Calcualte_Hit()
        {
            switch (com) // add ship image illimnation logic and other ship PDF... can't handle found logic
            {
                case ComanderState.c:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 3) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 3, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 3, j] += 1;
                                }
                            }
                        }
                    }//  4 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 3) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  4 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 4) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && data[i + 4, j] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 3, j] == 1 || Hit[i + 4, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 3, j] += 1;
                                    PDF[i + 4, j] += 1;
                                }
                            }
                        }
                    }//  5 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 4) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && data[i, j + 4] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1 || Hit[i, j + 4] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                    PDF[i, j + 4] += 1;
                                }
                            }
                        }
                    }//  5 x 1 ship O2
                    break;
                case ComanderState.w:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 && Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  zig-zag ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  zig-zag ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 2) < 10 && (i + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 2] == 0 && data[i + 2, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i + 2, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i + 2, j + 2] += 1;
                                }
                            }
                        }
                    }//  Largecorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j + 2] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 2, j] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 2, j + 2] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 2, j + 2] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  Largecorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 2, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 2, j + 2] += 1;
                                }
                            }
                        }
                    }//  Largecorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  Largecorner ship O4
                    break;
                case ComanderState.j:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 && Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  ReverseZig-Zag ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  ReverseZig-Zag ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  Block ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  Block ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  Block ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  Block ship O4
                    break;
                case ComanderState.a:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 1) < 10 && (i + 2) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  T ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  T ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  T ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 1, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  T ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 3) < 10 && (i + 1) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  weird ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 3, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 3, j + 1] += 1;
                                }
                            }
                        }
                    }//  weird ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 3, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 3, j + 1] += 1;
                                }
                            }
                        }
                    }//  weird ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  weird ship O3
                    break;
                case ComanderState.f:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 2) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship2.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  3 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 2) < 10 && (i + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  L ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  L ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  L ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  L ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 3) < 10 && (i + 1) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i + 1, j + 3] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i + 1, j + 3] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i + 1, j + 3] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  Big Reverse L ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 3, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 3, j + 1] += 1;
                                }
                            }
                        }
                    }//  Big Reverse L  ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  Big Reverse L  ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 3, j] == 1 || Hit[i + 3, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 3, j] += 1;
                                    PDF[i + 3, j + 1] += 1;
                                }
                            }
                        }
                    }//  Big Reverse L  ship O4
                    break;
                case ComanderState.g:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 && Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 3) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 3, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 3, j] += 1;
                                }
                            }
                        }
                    }//  4 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 3) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  4 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((j + 2) < 10 && (i + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                }
                            }
                        }
                    }//  Big T ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 2, j + 2] == 0 && data[i + 2, j] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 2, j + 2] == 1 || Hit[i + 2, j] == 1)
                                {
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 2, j + 2] += 1;
                                    PDF[i + 2, j] += 1;
                                }
                            }
                        }
                    }//  Big T ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && data[i + 2, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i, j + 2] == 1 || Hit[i + 2, j + 2] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i + 2, j + 2] += 1;
                                }
                            }
                        }
                    }//  Big T ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  Big T ship O4
                    break;
                case ComanderState.s:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 && Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  Reverse L ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  Reverse L ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  Reverse L ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  Reverse L ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                }
                            }
                        }
                    }//  Big f ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 3, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 3, j] += 1;
                                }
                            }
                        }
                    }//  Big f ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 3) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 1, j + 2] == 0 && data[i + 1, j + 3] == 0 && data[i, j + 2] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 1, j + 2] == 1 || Hit[i + 1, j + 3] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 1, j + 2] += 1;
                                    PDF[i + 1, j + 3] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  Big f ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 3) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && data[i + 3, j + 1] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1 || Hit[i + 3, j + 1] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                    PDF[i + 3, j + 1] += 1;
                                }
                            }
                        }
                    }//  Big f ship O4
                    break;
                case ComanderState.e:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && data[i, j + 1] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 1) < 10 && data[i + 1, j] == 0 && Ship1.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                }
                            }
                        }
                    }//  2 x 1 ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 1) < 10 && (i + 1) < 10 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 && Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O3
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i, j + 1] == 0 && Ship3.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i, j + 1] += 1;
                                }
                            }
                        }
                    }//  smallcorner ship O4
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 1) < 10 && (j + 2) < 10 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1)
                                {
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                }
                            }
                        }
                    }//  zig-zag ship O1
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if ((i + 2) < 10 && (j + 1) < 10 && data[i, j] == 0 && data[i + 1, j] == 0 && data[i + 1, j + 1] == 0 && data[i + 2, j + 1] == 0 && Ship4.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i + 1, j] == 1 || Hit[i + 1, j + 1] == 1 || Hit[i + 2, j + 1] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 1, j + 1] += 1;
                                    PDF[i + 2, j + 1] += 1;
                                }
                            }
                        }
                    }//  zig-zag ship O2
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (i + 4) < 10 && data[i + 1, j] == 0 && data[i + 2, j] == 0 && data[i + 3, j] == 0 && data[i + 4, j] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1  || Hit[i + 1, j] == 1 || Hit[i + 2, j] == 1 || Hit[i + 3, j] == 1 || Hit[i + 4, j] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i + 1, j] += 1;
                                    PDF[i + 2, j] += 1;
                                    PDF[i + 3, j] += 1;
                                    PDF[i + 4, j] += 1;
                                }
                            }
                        }
                    }//  5 x 1 ship O1 
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (data[i, j] == 0 && (j + 4) < 10 && data[i, j + 1] == 0 && data[i, j + 2] == 0 && data[i, j + 3] == 0 && data[i, j + 4] == 0 && Ship5.Enabled == true)
                            {
                                if (Hit[i, j] == 1 || Hit[i, j + 1] == 1 || Hit[i, j + 2] == 1 || Hit[i, j + 3] == 1 || Hit[i, j + 4] == 1)
                                {
                                    PDF[i, j] += 1;
                                    PDF[i, j + 1] += 1;
                                    PDF[i, j + 2] += 1;
                                    PDF[i, j + 3] += 1;
                                    PDF[i, j + 4] += 1;
                                }
                            }
                        }
                    }//  5 x 1 ship O2
                    break;
                default:
                    break;
            }
        }
        public void Hit_To_PDF()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (Hit[i, j] == 1)
                        PDF[i, j] = 0;
                }
            }
        }
        public void Check_Parity()
        {
            if (com == ComanderState.w && Ship1.Enabled == false && Ship2.Enabled == false && Ship3.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.j && Ship1.Enabled == false && Ship2.Enabled == false && Ship3.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.a && Ship1.Enabled == false && Ship2.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.f && Ship1.Enabled == false && Ship2.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.g && Ship1.Enabled == false && Ship2.Enabled == false && Ship3.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.s && Ship1.Enabled == false && Ship2.Enabled == false && Ship3.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.e && Ship1.Enabled == false && Ship2.Enabled == false && Ship3.Enabled == false)
            {
                WhichOne();
            }
            if (com == ComanderState.c && Ship1.Enabled == false)
            {
                WhichOne();
            }
        }
        public void WhichOne()
        {
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (data[i, j] == 1)
                    {
                        if (j == 0)
                        {
                            if(i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score1++;
                                score3++;
                            }
                            else
                            {
                                score2++;
                                score4++;
                            }
                        }//row 1
                        if (j == 1)
                        {
                            if(i == 1 || i == 4 || i ==7)
                            {
                                score1++;
                                score4++;
                            }
                            if(i == 2 || i == 5 || i == 8)
                            {
                                score2++;
                                score3++;
                            }
                        }
                        if (j == 2)
                        {
                            if(i == 2 || i == 5 || i == 8)
                            {
                                score1++;
                            }
                            if (i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score2++;
                                score4++;
                            }
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score3++;
                            }
                        }
                        if (j == 3)
                        {
                            if(i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score1++;
                                score3++;
                            }
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score2++;
                                score4++;
                            }

                        }
                        if (j == 4)
                        {
                            if(i == 1 || i == 4 || i == 7)
                            {
                                score1++;
                            }
                            if (i == 2 || i == 5 || i == 8)
                            {
                                score2++;
                                score3++;
                            }
                            if (i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score4++;
                            }
                        }
                        if (j == 5)
                        {
                            if(i == 2 || i == 5 || i == 8)
                            {
                                score1++;
                                score4++;
                            }
                            if (i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score2++;
                            }
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score3++;
                            }
                        }
                        if (j == 6)
                        {
                            if(i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score1++;
                                score3++;
                            }
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score2++;
                                score4++;
                            }
                        }
                        if (j == 7)
                        {
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score1++;
                            }
                            if (i == 2 || i == 5 || i == 8)
                            {
                                score2++;
                                score3++;
                            }
                            if (i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score4++;
                            }
                        }
                        if (j == 8)
                        {
                            if (i == 2 || i == 5 || i == 8)
                            {
                                score1++;
                                score4++;
                            }
                            if (i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score2++;
                            }
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score3++;
                            }
                        }
                        if (j == 9)
                        {
                            if (i == 0 || i == 3 || i == 6 || i == 9)
                            {
                                score1++;
                                score3++;
                            }
                            if (i == 1 || i == 4 || i == 7)
                            {
                                score2++;
                                score4++;
                            }
                        }
                    }
                }
            }

            if(score1 >= score2 && score1 >= score3 && score1 >= score4)
            {
                state = ParityType.three1;
            }
            else if(score2 >= score1 && score2 >= score3 && score2 >= score4)
            {
                state = ParityType.three2;
            }
            else if (score3 >= score1 && score3 >= score2 && score3 >= score4)
            {
                state = ParityType.three3;
            }
            else if (score4 >= score1 && score4 >= score2 && score4 >= score3)
            {
                state = ParityType.three4;
            }
        }
        public void Image_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            string name = p.Name;

            switch(name)
            {
                case "Ship1":
                    Ship1.Enabled = false;
                    Ship1.BackColor = Color.DimGray;
                    break;
                case "Ship2":
                    Ship2.Enabled = false;
                    Ship2.BackColor = Color.DimGray;
                    break;
                case "Ship3":
                    Ship3.Enabled = false;
                    Ship3.BackColor = Color.DimGray;
                    break;
                case "Ship4":
                    Ship4.Enabled = false;
                    Ship4.BackColor = Color.DimGray;
                    break;
                case "Ship5":
                    Ship5.Enabled = false;
                    Ship5.BackColor = Color.DimGray;
                    break;
            }
            Check_Parity();
            Button_Color_Correction();
            Calculate_PDF();
        }
        public void Button_Color_Correction()
        {
            if(uxA1.BackColor != Color.Black && uxA1.Text != "O" && uxA1.Text != "S")
            {
                uxA1.BackColor = Color.LightGray;
                if(uxA1.Text == "X")
                    uxA1.BackColor = Color.CornflowerBlue;
            }
            if (uxA2.BackColor != Color.Black && uxA2.Text != "O" && uxA2.Text != "S")
            {
                uxA2.BackColor = Color.LightGray;
                if (uxA2.Text == "X")
                    uxA2.BackColor = Color.CornflowerBlue;
            }
            if (uxA3.BackColor != Color.Black && uxA3.Text != "O" && uxA3.Text != "S")
            {
                uxA3.BackColor = Color.LightGray;
                if (uxA3.Text == "X")
                    uxA3.BackColor = Color.CornflowerBlue;
            }
            if (uxA4.BackColor != Color.Black && uxA4.Text != "O" && uxA4.Text != "S")
            {
                uxA4.BackColor = Color.LightGray;
                if (uxA4.Text == "X")
                    uxA4.BackColor = Color.CornflowerBlue;
            }
            if (uxA5.BackColor != Color.Black && uxA5.Text != "O" && uxA5.Text != "S")
            {
                uxA5.BackColor = Color.LightGray;
                if (uxA5.Text == "X")
                    uxA5.BackColor = Color.CornflowerBlue;
            }
            if (uxA6.BackColor != Color.Black && uxA6.Text != "O" && uxA6.Text != "S")
            {
                uxA6.BackColor = Color.LightGray;
                if (uxA6.Text == "X")
                    uxA6.BackColor = Color.CornflowerBlue;
            }
            if (uxA7.BackColor != Color.Black && uxA7.Text != "O" && uxA7.Text != "S")
            {
                uxA7.BackColor = Color.LightGray;
                if (uxA7.Text == "X")
                    uxA7.BackColor = Color.CornflowerBlue;
            }
            if (uxA8.BackColor != Color.Black && uxA8.Text != "O" && uxA8.Text != "S")
            {
                uxA8.BackColor = Color.LightGray;
                if (uxA8.Text == "X")
                    uxA8.BackColor = Color.CornflowerBlue;
            }
            if (uxA9.BackColor != Color.Black && uxA9.Text != "O" && uxA9.Text != "S")
            {
                uxA9.BackColor = Color.LightGray;
                if (uxA9.Text == "X")
                    uxA9.BackColor = Color.CornflowerBlue;
            }
            if (uxA10.BackColor != Color.Black && uxA10.Text != "O" && uxA10.Text != "S")
            {
                uxA10.BackColor = Color.LightGray;
                if (uxA10.Text == "X")
                    uxA10.BackColor = Color.CornflowerBlue;
            }

            if (uxB1.BackColor != Color.Black && uxB1.Text != "O" && uxB1.Text != "S")
            {
                uxB1.BackColor = Color.LightGray;
                if (uxB1.Text == "X")
                    uxB1.BackColor = Color.CornflowerBlue;
            }
            if (uxB2.BackColor != Color.Black && uxB2.Text != "O" && uxB2.Text != "S")
            {
                uxB2.BackColor = Color.LightGray;
                if (uxB2.Text == "X")
                    uxB2.BackColor = Color.CornflowerBlue;
            }
            if (uxB3.BackColor != Color.Black && uxB3.Text != "O" && uxB3.Text != "S")
            {
                uxB3.BackColor = Color.LightGray;
                if (uxB3.Text == "X")
                    uxB3.BackColor = Color.CornflowerBlue;
            }
            if (uxB4.BackColor != Color.Black && uxB4.Text != "O" && uxB4.Text != "S")
            {
                uxB4.BackColor = Color.LightGray;
                if (uxB4.Text == "X")
                    uxB4.BackColor = Color.CornflowerBlue;
            }
            if (uxB5.BackColor != Color.Black && uxB5.Text != "O" && uxB5.Text != "S")
            {
                uxB5.BackColor = Color.LightGray;
                if (uxB5.Text == "X")
                    uxB5.BackColor = Color.CornflowerBlue;
            }
            if (uxB6.BackColor != Color.Black && uxB6.Text != "O" && uxB6.Text != "S")
            {
                uxB6.BackColor = Color.LightGray;
                if (uxB6.Text == "X")
                    uxB6.BackColor = Color.CornflowerBlue;
            }
            if (uxB7.BackColor != Color.Black && uxB7.Text != "O" && uxB7.Text != "S")
            {
                uxB7.BackColor = Color.LightGray;
                if (uxB7.Text == "X")
                    uxB7.BackColor = Color.CornflowerBlue;
            }
            if (uxB8.BackColor != Color.Black && uxB8.Text != "O" && uxB8.Text != "S")
            {
                uxB8.BackColor = Color.LightGray;
                if (uxB8.Text == "X")
                    uxB8.BackColor = Color.CornflowerBlue;
            }
            if (uxB9.BackColor != Color.Black && uxB9.Text != "O" && uxB9.Text != "S")
            {
                uxB9.BackColor = Color.LightGray;
                if (uxB9.Text == "X")
                    uxB9.BackColor = Color.CornflowerBlue;
            }
            if (uxB10.BackColor != Color.Black && uxB10.Text != "O" && uxB10.Text != "S")
            {
                uxB10.BackColor = Color.LightGray;
                if (uxB10.Text == "X")
                    uxB10.BackColor = Color.CornflowerBlue;
            }

            if (uxC1.BackColor != Color.Black && uxC1.Text != "O" && uxC1.Text != "S")
            {
                uxC1.BackColor = Color.LightGray;
                if (uxC1.Text == "X")
                    uxC1.BackColor = Color.CornflowerBlue;
            }
            if (uxC2.BackColor != Color.Black && uxC2.Text != "O" && uxC2.Text != "S")
            {
                uxC2.BackColor = Color.LightGray;
                if (uxC2.Text == "X")
                    uxC2.BackColor = Color.CornflowerBlue;
            }
            if (uxC3.BackColor != Color.Black && uxC3.Text != "O" && uxC3.Text != "S")
            {
                uxC3.BackColor = Color.LightGray;
                if (uxC3.Text == "X")
                    uxC3.BackColor = Color.CornflowerBlue;
            }
            if (uxC4.BackColor != Color.Black && uxC4.Text != "O" && uxC4.Text != "S")
            {
                uxC4.BackColor = Color.LightGray;
                if (uxC4.Text == "X")
                    uxC4.BackColor = Color.CornflowerBlue;
            }
            if (uxC5.BackColor != Color.Black && uxC5.Text != "O" && uxC5.Text != "S")
            {
                uxC5.BackColor = Color.LightGray;
                if (uxC5.Text == "X")
                    uxC5.BackColor = Color.CornflowerBlue;
            }
            if (uxC6.BackColor != Color.Black && uxC6.Text != "O" && uxC6.Text != "S")
            {
                uxC6.BackColor = Color.LightGray;
                if (uxC6.Text == "X")
                    uxC6.BackColor = Color.CornflowerBlue;
            }
            if (uxC7.BackColor != Color.Black && uxC7.Text != "O" && uxC7.Text != "S")
            {
                uxC7.BackColor = Color.LightGray;
                if (uxC7.Text == "X")
                    uxC7.BackColor = Color.CornflowerBlue;
            }
            if (uxC8.BackColor != Color.Black && uxC8.Text != "O" && uxC8.Text != "S")
            {
                uxC8.BackColor = Color.LightGray;
                if (uxC8.Text == "X")
                    uxC8.BackColor = Color.CornflowerBlue;
            }
            if (uxC9.BackColor != Color.Black && uxC9.Text != "O" && uxC9.Text != "S")
            {
                uxC9.BackColor = Color.LightGray;
                if (uxC9.Text == "X")
                    uxC9.BackColor = Color.CornflowerBlue;
            }
            if (uxC10.BackColor != Color.Black && uxC10.Text != "O" && uxC10.Text != "S")
            {
                uxC10.BackColor = Color.LightGray;
                if (uxC10.Text == "X")
                    uxC10.BackColor = Color.CornflowerBlue;
            }

            if (uxD1.BackColor != Color.Black && uxD1.Text != "O" && uxD1.Text != "S")
            {
                uxD1.BackColor = Color.LightGray;
                if (uxD1.Text == "X")
                    uxD1.BackColor = Color.CornflowerBlue;
            }
            if (uxD2.BackColor != Color.Black && uxD2.Text != "O" && uxD2.Text != "S")
            {
                uxD2.BackColor = Color.LightGray;
                if (uxD2.Text == "X")
                    uxD2.BackColor = Color.CornflowerBlue;
            }
            if (uxD3.BackColor != Color.Black && uxD3.Text != "O" && uxD3.Text != "S")
            {
                uxD3.BackColor = Color.LightGray;
                if (uxD3.Text == "X")
                    uxD3.BackColor = Color.CornflowerBlue;
            }
            if (uxD4.BackColor != Color.Black && uxD4.Text != "O" && uxD4.Text != "S")
            {
                uxD4.BackColor = Color.LightGray;
                if (uxD4.Text == "X")
                    uxD4.BackColor = Color.CornflowerBlue;
            }
            if (uxD5.BackColor != Color.Black && uxD5.Text != "O" && uxD5.Text != "S")
            {
                uxD5.BackColor = Color.LightGray;
                if (uxD5.Text == "X")
                    uxD5.BackColor = Color.CornflowerBlue;
            }
            if (uxD6.BackColor != Color.Black && uxD6.Text != "O" && uxD6.Text != "S")
            {
                uxD6.BackColor = Color.LightGray;
                if (uxD6.Text == "X")
                    uxD6.BackColor = Color.CornflowerBlue;
            }
            if (uxD7.BackColor != Color.Black && uxD7.Text != "O" && uxD7.Text != "S")
            {
                uxD7.BackColor = Color.LightGray;
                if (uxD7.Text == "X")
                    uxD7.BackColor = Color.CornflowerBlue;
            }
            if (uxD8.BackColor != Color.Black && uxD8.Text != "O" && uxD8.Text != "S")
            {
                uxD8.BackColor = Color.LightGray;
                if (uxD8.Text == "X")
                    uxD8.BackColor = Color.CornflowerBlue;
            }
            if (uxD9.BackColor != Color.Black && uxD9.Text != "O" && uxD9.Text != "S")
            {
                uxD9.BackColor = Color.LightGray;
                if (uxD9.Text == "X")
                    uxD9.BackColor = Color.CornflowerBlue;
            }
            if (uxD10.BackColor != Color.Black && uxD10.Text != "O" && uxD10.Text != "S")
            {
                uxD10.BackColor = Color.LightGray;
                if (uxD10.Text == "X")
                    uxD10.BackColor = Color.CornflowerBlue;
            }

            if (uxE1.BackColor != Color.Black && uxE1.Text != "O" && uxE1.Text != "S")
            {
                uxE1.BackColor = Color.LightGray;
                if (uxE1.Text == "X")
                    uxE1.BackColor = Color.CornflowerBlue;
            }
            if (uxE2.BackColor != Color.Black && uxE2.Text != "O" && uxE2.Text != "S")
            {
                uxE2.BackColor = Color.LightGray;
                if (uxE2.Text == "X")
                    uxE2.BackColor = Color.CornflowerBlue;
            }
            if (uxE3.BackColor != Color.Black && uxE3.Text != "O" && uxE3.Text != "S")
            {
                uxE3.BackColor = Color.LightGray;
                if (uxE3.Text == "X")
                    uxE3.BackColor = Color.CornflowerBlue;
            }
            if (uxE4.BackColor != Color.Black && uxE4.Text != "O" && uxE4.Text != "S")
            {
                uxE4.BackColor = Color.LightGray;
                if (uxE4.Text == "X")
                    uxE4.BackColor = Color.CornflowerBlue;
            }
            if (uxE5.BackColor != Color.Black && uxE5.Text != "O" && uxE5.Text != "S")
            {
                uxE5.BackColor = Color.LightGray;
                if (uxE5.Text == "X")
                    uxE5.BackColor = Color.CornflowerBlue;
            }
            if (uxE6.BackColor != Color.Black && uxE6.Text != "O" && uxE6.Text != "S")
            {
                uxE6.BackColor = Color.LightGray;
                if (uxE6.Text == "X")
                    uxE6.BackColor = Color.CornflowerBlue;
            }
            if (uxE7.BackColor != Color.Black && uxE7.Text != "O" && uxE7.Text != "S")
            {
                uxE7.BackColor = Color.LightGray;
                if (uxE7.Text == "X")
                    uxE7.BackColor = Color.CornflowerBlue;
            }
            if (uxE8.BackColor != Color.Black && uxE8.Text != "O" && uxE8.Text != "S")
            {
                uxE8.BackColor = Color.LightGray;
                if (uxE8.Text == "X")
                    uxE8.BackColor = Color.CornflowerBlue;
            }
            if (uxE9.BackColor != Color.Black && uxE9.Text != "O" && uxE9.Text != "S")
            {
                uxE9.BackColor = Color.LightGray;
                if (uxE9.Text == "X")
                    uxE9.BackColor = Color.CornflowerBlue;
            }
            if (uxE10.BackColor != Color.Black && uxE10.Text != "O" && uxE10.Text != "S")
            {
                uxE10.BackColor = Color.LightGray;
                if (uxE10.Text == "X")
                    uxE10.BackColor = Color.CornflowerBlue;
            }

            if (uxF1.BackColor != Color.Black && uxF1.Text != "O" && uxF1.Text != "S")
            {
                uxF1.BackColor = Color.LightGray;
                if (uxF1.Text == "X")
                    uxF1.BackColor = Color.CornflowerBlue;
            }
            if (uxF2.BackColor != Color.Black && uxF2.Text != "O" && uxF2.Text != "S")
            {
                uxF2.BackColor = Color.LightGray;
                if (uxF2.Text == "X")
                    uxF2.BackColor = Color.CornflowerBlue;
            }
            if (uxF3.BackColor != Color.Black && uxF3.Text != "O" && uxF3.Text != "S")
            {
                uxF3.BackColor = Color.LightGray;
                if (uxF3.Text == "X")
                    uxF3.BackColor = Color.CornflowerBlue;
            }
            if (uxF4.BackColor != Color.Black && uxF4.Text != "O" && uxF4.Text != "S")
            {
                uxF4.BackColor = Color.LightGray;
                if (uxF4.Text == "X")
                    uxF4.BackColor = Color.CornflowerBlue;
            }
            if (uxF5.BackColor != Color.Black && uxF5.Text != "O" && uxF5.Text != "S")
            {
                uxF5.BackColor = Color.LightGray;
                if (uxF5.Text == "X")
                    uxF5.BackColor = Color.CornflowerBlue;
            }
            if (uxF6.BackColor != Color.Black && uxF6.Text != "O" && uxF6.Text != "S")
            {
                uxF6.BackColor = Color.LightGray;
                if (uxF6.Text == "X")
                    uxF6.BackColor = Color.CornflowerBlue;
            }
            if (uxF7.BackColor != Color.Black && uxF7.Text != "O" && uxF7.Text != "S")
            {
                uxF7.BackColor = Color.LightGray;
                if (uxF7.Text == "X")
                    uxF7.BackColor = Color.CornflowerBlue;
            }
            if (uxF8.BackColor != Color.Black && uxF8.Text != "O" && uxF8.Text != "S")
            {
                uxF8.BackColor = Color.LightGray;
                if (uxF8.Text == "X")
                    uxF8.BackColor = Color.CornflowerBlue;
            }
            if (uxF9.BackColor != Color.Black && uxF9.Text != "O" && uxF9.Text != "S")
            {
                uxF9.BackColor = Color.LightGray;
                if (uxF9.Text == "X")
                    uxF9.BackColor = Color.CornflowerBlue;
            }
            if (uxF10.BackColor != Color.Black && uxF10.Text != "O" && uxF10.Text != "S")
            {
                uxF10.BackColor = Color.LightGray;
                if (uxF10.Text == "X")
                    uxF10.BackColor = Color.CornflowerBlue;
            }

            if (uxG1.BackColor != Color.Black && uxG1.Text != "O" && uxG1.Text != "S")
            {
                uxG1.BackColor = Color.LightGray;
                if (uxG1.Text == "X")
                    uxG1.BackColor = Color.CornflowerBlue;
            }
            if (uxG2.BackColor != Color.Black && uxG2.Text != "O" && uxG2.Text != "S")
            {
                uxG2.BackColor = Color.LightGray;
                if (uxG2.Text == "X")
                    uxG2.BackColor = Color.CornflowerBlue;
            }
            if (uxG3.BackColor != Color.Black && uxG3.Text != "O" && uxG3.Text != "S")
            {
                uxG3.BackColor = Color.LightGray;
                if (uxG3.Text == "X")
                    uxG3.BackColor = Color.CornflowerBlue;
            }
            if (uxG4.BackColor != Color.Black && uxG4.Text != "O" && uxG4.Text != "S")
            {
                uxG4.BackColor = Color.LightGray;
                if (uxG4.Text == "X")
                    uxG4.BackColor = Color.CornflowerBlue;
            }
            if (uxG5.BackColor != Color.Black && uxG5.Text != "O" && uxG5.Text != "S")
            {
                uxG5.BackColor = Color.LightGray;
                if (uxG5.Text == "X")
                    uxG5.BackColor = Color.CornflowerBlue;
            }
            if (uxG6.BackColor != Color.Black && uxG6.Text != "O" && uxG6.Text != "S")
            {
                uxG6.BackColor = Color.LightGray;
                if (uxG6.Text == "X")
                    uxG6.BackColor = Color.CornflowerBlue;
            }
            if (uxG7.BackColor != Color.Black && uxG7.Text != "O" && uxG7.Text != "S")
            {
                uxG7.BackColor = Color.LightGray;
                if (uxG7.Text == "X")
                    uxG7.BackColor = Color.CornflowerBlue;
            }
            if (uxG8.BackColor != Color.Black && uxG8.Text != "O" && uxG8.Text != "S")
            {
                uxG8.BackColor = Color.LightGray;
                if (uxG8.Text == "X")
                    uxG8.BackColor = Color.CornflowerBlue;
            }
            if (uxG9.BackColor != Color.Black && uxG9.Text != "O" && uxG9.Text != "S")
            {
                uxG9.BackColor = Color.LightGray;
                if (uxG9.Text == "X")
                    uxG9.BackColor = Color.CornflowerBlue;
            }
            if (uxG10.BackColor != Color.Black && uxG10.Text != "O" && uxG10.Text != "S")
            {
                uxG10.BackColor = Color.LightGray;
                if (uxG10.Text == "X")
                    uxG10.BackColor = Color.CornflowerBlue;
            }

            if (uxH1.BackColor != Color.Black && uxH1.Text != "O" && uxH1.Text != "S")
            {
                uxH1.BackColor = Color.LightGray;
                if (uxH1.Text == "X")
                    uxH1.BackColor = Color.CornflowerBlue;
            }
            if (uxH2.BackColor != Color.Black && uxH2.Text != "O" && uxH2.Text != "S")
            {
                uxH2.BackColor = Color.LightGray;
                if (uxH2.Text == "X")
                    uxH2.BackColor = Color.CornflowerBlue;
            }
            if (uxH3.BackColor != Color.Black && uxH3.Text != "O" && uxH3.Text != "S")
            {
                uxH3.BackColor = Color.LightGray;
                if (uxH3.Text == "X")
                    uxH3.BackColor = Color.CornflowerBlue;
            }
            if (uxH4.BackColor != Color.Black && uxH4.Text != "O" && uxH4.Text != "S")
            {
                uxH4.BackColor = Color.LightGray;
                if (uxH4.Text == "X")
                    uxH4.BackColor = Color.CornflowerBlue;
            }
            if (uxH5.BackColor != Color.Black && uxH5.Text != "O" && uxH5.Text != "S")
            {
                uxH5.BackColor = Color.LightGray;
                if (uxH5.Text == "X")
                    uxH5.BackColor = Color.CornflowerBlue;
            }
            if (uxH6.BackColor != Color.Black && uxH6.Text != "O" && uxH6.Text != "S")
            {
                uxH6.BackColor = Color.LightGray;
                if (uxH6.Text == "X")
                    uxH6.BackColor = Color.CornflowerBlue;
            }
            if (uxH7.BackColor != Color.Black && uxH7.Text != "O" && uxH7.Text != "S")
            {
                uxH7.BackColor = Color.LightGray;
                if (uxH7.Text == "X")
                    uxH7.BackColor = Color.CornflowerBlue;
            }
            if (uxH8.BackColor != Color.Black && uxH8.Text != "O" && uxH8.Text != "S")
            {
                uxH8.BackColor = Color.LightGray;
                if (uxH8.Text == "X")
                    uxH8.BackColor = Color.CornflowerBlue;
            }
            if (uxH9.BackColor != Color.Black && uxH9.Text != "O" && uxH9.Text != "S")
            {
                uxH9.BackColor = Color.LightGray;
                if (uxH9.Text == "X")
                    uxH9.BackColor = Color.CornflowerBlue;
            }
            if (uxH10.BackColor != Color.Black && uxH10.Text != "O" && uxH10.Text != "S")
            {
                uxH10.BackColor = Color.LightGray;
                if (uxH10.Text == "X")
                    uxH10.BackColor = Color.CornflowerBlue;
            }

            if (uxI1.BackColor != Color.Black && uxI1.Text != "O" && uxI1.Text != "S")
            {
                uxI1.BackColor = Color.LightGray;
                if (uxI1.Text == "X")
                    uxI1.BackColor = Color.CornflowerBlue;
            }
            if (uxI2.BackColor != Color.Black && uxI2.Text != "O" && uxI2.Text != "S")
            {
                uxI2.BackColor = Color.LightGray;
                if (uxI2.Text == "X")
                    uxI2.BackColor = Color.CornflowerBlue;
            }
            if (uxI3.BackColor != Color.Black && uxI3.Text != "O" && uxI3.Text != "S")
            {
                uxI3.BackColor = Color.LightGray;
                if (uxI3.Text == "X")
                    uxI3.BackColor = Color.CornflowerBlue;
            }
            if (uxI4.BackColor != Color.Black && uxI4.Text != "O" && uxI4.Text != "S")
            {
                uxI4.BackColor = Color.LightGray;
                if (uxI4.Text == "X")
                    uxI4.BackColor = Color.CornflowerBlue;
            }
            if (uxI5.BackColor != Color.Black && uxI5.Text != "O" && uxI5.Text != "S")
            {
                uxI5.BackColor = Color.LightGray;
                if (uxI5.Text == "X")
                    uxI5.BackColor = Color.CornflowerBlue;
            }
            if (uxI6.BackColor != Color.Black && uxI6.Text != "O" && uxI6.Text != "S")
            {
                uxI6.BackColor = Color.LightGray;
                if (uxI6.Text == "X")
                    uxI6.BackColor = Color.CornflowerBlue;
            }
            if (uxI7.BackColor != Color.Black && uxI7.Text != "O" && uxI7.Text != "S")
            {
                uxI7.BackColor = Color.LightGray;
                if (uxI7.Text == "X")
                    uxI7.BackColor = Color.CornflowerBlue;
            }
            if (uxI8.BackColor != Color.Black && uxI8.Text != "O" && uxI8.Text != "S")
            {
                uxI8.BackColor = Color.LightGray;
                if (uxI8.Text == "X")
                    uxI8.BackColor = Color.CornflowerBlue;
            }
            if (uxI9.BackColor != Color.Black && uxI9.Text != "O" && uxI9.Text != "S")
            {
                uxI9.BackColor = Color.LightGray;
                if (uxI9.Text == "X")
                    uxI9.BackColor = Color.CornflowerBlue;
            }
            if (uxI10.BackColor != Color.Black && uxI10.Text != "O" && uxI10.Text != "S")
            {
                uxI10.BackColor = Color.LightGray;
                if (uxI10.Text == "X")
                    uxI10.BackColor = Color.CornflowerBlue;
            }

            if (uxJ1.BackColor != Color.Black && uxJ1.Text != "O" && uxJ1.Text != "S")
            {
                uxJ1.BackColor = Color.LightGray;
                if (uxJ1.Text == "X")
                    uxJ1.BackColor = Color.CornflowerBlue;
            }
            if (uxJ2.BackColor != Color.Black && uxJ2.Text != "O" && uxJ2.Text != "S")
            {
                uxJ2.BackColor = Color.LightGray;
                if (uxJ2.Text == "X")
                    uxJ2.BackColor = Color.CornflowerBlue;
            }
            if (uxJ3.BackColor != Color.Black && uxJ3.Text != "O" && uxJ3.Text != "S")
            {
                uxJ3.BackColor = Color.LightGray;
                if (uxJ3.Text == "X")
                    uxJ3.BackColor = Color.CornflowerBlue;
            }
            if (uxJ4.BackColor != Color.Black && uxJ4.Text != "O" && uxJ4.Text != "S")
            {
                uxJ4.BackColor = Color.LightGray;
                if (uxJ4.Text == "X")
                    uxJ4.BackColor = Color.CornflowerBlue;
            }
            if (uxJ5.BackColor != Color.Black && uxJ5.Text != "O" && uxJ5.Text != "S")
            {
                uxJ5.BackColor = Color.LightGray;
                if (uxJ5.Text == "X")
                    uxJ5.BackColor = Color.CornflowerBlue;
            }
            if (uxJ6.BackColor != Color.Black && uxJ6.Text != "O" && uxJ6.Text != "S")
            {
                uxJ6.BackColor = Color.LightGray;
                if (uxJ6.Text == "X")
                    uxJ6.BackColor = Color.CornflowerBlue;
            }
            if (uxJ7.BackColor != Color.Black && uxJ7.Text != "O" && uxJ7.Text != "S")
            {
                uxJ7.BackColor = Color.LightGray;
                if (uxJ7.Text == "X")
                    uxJ7.BackColor = Color.CornflowerBlue;
            }
            if (uxJ8.BackColor != Color.Black && uxJ8.Text != "O" && uxJ8.Text != "S")
            {
                uxJ8.BackColor = Color.LightGray;
                if (uxJ8.Text == "X")
                    uxJ8.BackColor = Color.CornflowerBlue;
            }
            if (uxJ9.BackColor != Color.Black && uxJ9.Text != "O" && uxJ9.Text != "S")
            {
                uxJ9.BackColor = Color.LightGray;
                if (uxJ9.Text == "X")
                    uxJ9.BackColor = Color.CornflowerBlue;
            }
            if (uxJ10.BackColor != Color.Black && uxJ10.Text != "O" && uxJ10.Text != "S")
            {
                uxJ10.BackColor = Color.LightGray;
                if (uxJ10.Text == "X")
                    uxJ10.BackColor = Color.CornflowerBlue;
            }
        }

        public void Show_Msg()
        {
            /*
            MessageBox.Show(data[0, 0] + " " + data[1, 0] + " " + data[2, 0] + " " + data[3, 0] + " " + data[4, 0] + " " + data[5, 0] + " " + data[6, 0] + " " + data[7, 0] + " " + data[8, 0] + " " + data[9, 0] + "\n" +
                            data[0, 1] + " " + data[1, 1] + " " + data[2, 1] + " " + data[3, 1] + " " + data[4, 1] + " " + data[5, 1] + " " + data[6, 1] + " " + data[7, 1] + " " + data[8, 1] + " " + data[9, 1] + "\n" +
                            data[0, 2] + " " + data[1, 2] + " " + data[2, 2] + " " + data[3, 2] + " " + data[4, 2] + " " + data[5, 2] + " " + data[6, 2] + " " + data[7, 2] + " " + data[8, 2] + " " + data[9, 2] + "\n" +
                            data[0, 3] + " " + data[1, 3] + " " + data[2, 3] + " " + data[3, 3] + " " + data[4, 3] + " " + data[5, 3] + " " + data[6, 3] + " " + data[7, 3] + " " + data[8, 3] + " " + data[9, 3] + "\n" +
                            data[0, 4] + " " + data[1, 4] + " " + data[2, 4] + " " + data[3, 4] + " " + data[4, 4] + " " + data[5, 4] + " " + data[6, 4] + " " + data[7, 4] + " " + data[8, 4] + " " + data[9, 4] + "\n" +
                            data[0, 5] + " " + data[1, 5] + " " + data[2, 5] + " " + data[3, 5] + " " + data[4, 5] + " " + data[5, 5] + " " + data[6, 5] + " " + data[7, 5] + " " + data[8, 5] + " " + data[9, 5] + "\n" +
                            data[0, 6] + " " + data[1, 6] + " " + data[2, 6] + " " + data[3, 6] + " " + data[4, 6] + " " + data[5, 6] + " " + data[6, 6] + " " + data[7, 6] + " " + data[8, 6] + " " + data[9, 6] + "\n" +
                            data[0, 7] + " " + data[1, 7] + " " + data[2, 7] + " " + data[3, 7] + " " + data[4, 7] + " " + data[5, 7] + " " + data[6, 7] + " " + data[7, 7] + " " + data[8, 7] + " " + data[9, 7] + "\n" +
                            data[0, 8] + " " + data[1, 8] + " " + data[2, 8] + " " + data[3, 8] + " " + data[4, 8] + " " + data[5, 8] + " " + data[6, 8] + " " + data[7, 8] + " " + data[8, 8] + " " + data[9, 8] + "\n" +
                            data[0, 9] + " " + data[1, 9] + " " + data[2, 9] + " " + data[3, 9] + " " + data[4, 9] + " " + data[5, 9] + " " + data[6, 9] + " " + data[7, 9] + " " + data[8, 9] + " " + data[9, 9]);
            */
            MessageBox.Show(PDF[0, 0] + " " + PDF[1, 0] + " " + PDF[2, 0] + " " + PDF[3, 0] + " " + PDF[4, 0] + " " + PDF[5, 0] + " " + PDF[6, 0] + " " + PDF[7, 0] + " " + PDF[8, 0] + " " + PDF[9, 0] + "\n" +
                            PDF[0, 1] + " " + PDF[1, 1] + " " + PDF[2, 1] + " " + PDF[3, 1] + " " + PDF[4, 1] + " " + PDF[5, 1] + " " + PDF[6, 1] + " " + PDF[7, 1] + " " + PDF[8, 1] + " " + PDF[9, 1] + "\n" +
                            PDF[0, 2] + " " + PDF[1, 2] + " " + PDF[2, 2] + " " + PDF[3, 2] + " " + PDF[4, 2] + " " + PDF[5, 2] + " " + PDF[6, 2] + " " + PDF[7, 2] + " " + PDF[8, 2] + " " + PDF[9, 2] + "\n" +
                            PDF[0, 3] + " " + PDF[1, 3] + " " + PDF[2, 3] + " " + PDF[3, 3] + " " + PDF[4, 3] + " " + PDF[5, 3] + " " + PDF[6, 3] + " " + PDF[7, 3] + " " + PDF[8, 3] + " " + PDF[9, 3] + "\n" +
                            PDF[0, 4] + " " + PDF[1, 4] + " " + PDF[2, 4] + " " + PDF[3, 4] + " " + PDF[4, 4] + " " + PDF[5, 4] + " " + PDF[6, 4] + " " + PDF[7, 4] + " " + PDF[8, 4] + " " + PDF[9, 4] + "\n" +
                            PDF[0, 5] + " " + PDF[1, 5] + " " + PDF[2, 5] + " " + PDF[3, 5] + " " + PDF[4, 5] + " " + PDF[5, 5] + " " + PDF[6, 5] + " " + PDF[7, 5] + " " + PDF[8, 5] + " " + PDF[9, 5] + "\n" +
                            PDF[0, 6] + " " + PDF[1, 6] + " " + PDF[2, 6] + " " + PDF[3, 6] + " " + PDF[4, 6] + " " + PDF[5, 6] + " " + PDF[6, 6] + " " + PDF[7, 6] + " " + PDF[8, 6] + " " + PDF[9, 6] + "\n" +
                            PDF[0, 7] + " " + PDF[1, 7] + " " + PDF[2, 7] + " " + PDF[3, 7] + " " + PDF[4, 7] + " " + PDF[5, 7] + " " + PDF[6, 7] + " " + PDF[7, 7] + " " + PDF[8, 7] + " " + PDF[9, 7] + "\n" +
                            PDF[0, 8] + " " + PDF[1, 8] + " " + PDF[2, 8] + " " + PDF[3, 8] + " " + PDF[4, 8] + " " + PDF[5, 8] + " " + PDF[6, 8] + " " + PDF[7, 8] + " " + PDF[8, 8] + " " + PDF[9, 8] + "\n" +
                            PDF[0, 9] + " " + PDF[1, 9] + " " + PDF[2, 9] + " " + PDF[3, 9] + " " + PDF[4, 9] + " " + PDF[5, 9] + " " + PDF[6, 9] + " " + PDF[7, 9] + " " + PDF[8, 9] + " " + PDF[9, 9]);
            
        }
        static int[] To1DArray(int[,] input)
        {
            // Step 1: get total size of 2D array, and allocate 1D array.
            int size = input.Length;
            int[] result = new int[size];

            // Step 2: copy 2D array elements into a 1D array.
            int write = 0;
            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                for (int z = 0; z <= input.GetUpperBound(1); z++)
                {
                    result[write++] = input[i, z];
                }
            }
            // Step 3: return the new array.
            return result;
        }

        private void williamKarslakeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } //Don't touch

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }//Don't touch

        private void label1_Click(object sender, EventArgs e)
        {

        }//Don't touch

        private void Ship1_Click(object sender, EventArgs e)
        {

        }//Don't touch

        private void shotBestGuessToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleOn == false)
                toggleOn = true;
            else
                toggleOn = false;
        }
    }
}