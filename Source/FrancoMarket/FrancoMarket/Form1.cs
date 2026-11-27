using merluzzi;

namespace FrancoMarket
{
    public partial class Form1 : Form
    {
        public Banco banco;
        public int req;
        public string nome;
        public float lunghezza;
        public float peso;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banco = new Banco();
        }

        public void Display(List<Merluzzo> mer)
        {
            flowLayoutPanel1.Controls.Clear();

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            foreach (Merluzzo m in mer)
            {
                Panel pee = new Panel { Size = new Size(500, 70), BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(5), BackColor = Color.White };

                Label abel = new Label { Text = $"Saluta il merluzzo N. {m.numerator}, si chiama {m.Nome}, pesa {m.peso} kg ed è lungo {m.lunghezza} cm", AutoSize = true, Location = new Point(10, 25), Font = new Font("Arial", 10) };

                pee.Controls.Add(abel);
                flowLayoutPanel1.Controls.Add(pee);
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (req == 0 && !string.IsNullOrEmpty(nome) && lunghezza > 0 && peso > 0)
            {
                banco.merluzzi.Add(new Merluzzo(nome, lunghezza, peso, banco.merluzzi.Count + 1));
            }
            else if (req > 0 && req <= banco.merluzzi.Count && !string.IsNullOrEmpty(nome) && lunghezza > 0 && peso > 0)
            {
                banco.merluzzi[req - 1].updateData(nome, lunghezza, peso, req);
            }
            //remove merluzzo
            else if (req > 0 && req <= banco.merluzzi.Count && string.IsNullOrEmpty(nome) && lunghezza == 0 && peso == 0)
            {
                banco.merluzzi.RemoveAt(req - 1);
            }
            else
            {
                MessageBox.Show("Errore!!");
                return;
            }
            Display(banco.merluzzi);
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            nome = NameBox.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            req = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            lunghezza = (float)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            peso = (float)numericUpDown3.Value;
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(SFD.FileName))
                    {
                        foreach (Merluzzo m in banco.merluzzi)
                        {
                            sw.WriteLine($"{m.numerator},{m.Nome},{m.lunghezza},{m.peso}");
                        }
                    }
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    banco.merluzzi.Clear();
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 4)
                            {
                                int n = int.Parse(parts[0]);
                                string nome = parts[1];
                                float lunghezza = float.Parse(parts[2]);
                                float peso = float.Parse(parts[3]);
                                banco.merluzzi.Add(new Merluzzo(nome, lunghezza, peso, n));
                            }
                        }
                    }
                    Display(banco.merluzzi);
                }
            }
        }
    }


    public class Banco
    {
        public List<Merluzzo> merluzzi = new List<Merluzzo>();
    }
}
