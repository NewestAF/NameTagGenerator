using System.Drawing.Text;

namespace NameTagGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image? _backgroundImage;
        private string[]? _names;
        private string _selectedFont;
        private int _fontSize = 12;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var fontName in GetInstalledFont())
            {
                fontSelect.Items.Add(fontName);
            }
        }

        private List<string> GetInstalledFont()
        {
            var installedFontCollection = new InstalledFontCollection();
            var fontList = new List<string>();

            foreach (var font in installedFontCollection.Families)
            {

                fontList.Add(font.Name);
            }

            return fontList;
        }

        private void chooseBackground_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "이미지 선택";
            openFileDialog.Filter = "이미지 파일(*.png)|*.png|모든 파일(*.*)|*.*";
            openFileDialog.InitialDirectory = "c\\";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            var fileStream = openFileDialog.OpenFile();
            _backgroundImage = new Bitmap(openFileDialog.FileName);
        }

        private void chooseCSV_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "CSV 선택";
            openFileDialog.Filter = "csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
            openFileDialog.InitialDirectory = "c\\";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var csvStream = openFileDialog.OpenFile();
            using var sr = new StreamReader(csvStream);
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var split = line?.Split(',');

                if (split?[0] != "이름")
                    return;
                _names = split;
                foreach (var s in _names)
                {
                    Console.WriteLine(s);
                }

            }

        }

        private void fontSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFont = (string) fontSelect.SelectedItem;
        }


    }
}
