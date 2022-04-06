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
                openFileDialog.Title = "이미지 선택";
                openFileDialog.Filter = "이미지 파일(*.png)|*.png|모든 파일(*.*)|*.*";
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
                openFileDialog.Title = "CSV 선택";
                openFileDialog.Filter = "csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
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

                                if (split?[0] == "이름")
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