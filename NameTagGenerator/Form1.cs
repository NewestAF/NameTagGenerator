namespace NameTagGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Image backgroundImage;
        string[] names;

        private void chooseBackground_Click(object sender, EventArgs e)
        {            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "�̹��� ����";
                openFileDialog.Filter = "�̹��� ����(*.png)|*.png|��� ����(*.*)|*.*";
                openFileDialog.InitialDirectory = "c\\";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = openFileDialog.OpenFile();
                    backgroundImage = new Bitmap(openFileDialog.FileName);                    
                }

            }
        }

        private void chooseCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "CSV ����";
                openFileDialog.Filter = "csv ����(*.csv)|*.csv|��� ����(*.*)|*.*";
                openFileDialog.InitialDirectory = "c\\";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream csvStream = openFileDialog.OpenFile();
                    if (csvStream != null)
                    {
                        using (StreamReader sr = new StreamReader(csvStream))
                        {
                            while (!sr.EndOfStream)
                            {
                                string? line = sr.ReadLine();
                                string[]? split = line?.Split(',');

                                if (split?[0] == "�̸�")
                                {
                                    names = split;
                                    for (int i = 0; i < names.Length; i++)
                                    {
                                        Console.WriteLine(names[i]);
                                    }
                                }

                            }
                        }
                    }           
                }
            }
        }
    }
}