using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Text;

namespace NameTagGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap? _backgroundImage;
        private string[]? _names;
        private Font _selectedFont = DefaultFont;
        private Color _selectedColor= Color.Black;
        private void Form1_Load(object sender, EventArgs e)
        {

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
            using var sr = new StreamReader(csvStream, Encoding.Default, true);
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var split = line?.Split(',');

                if (split?[0] != "이름표")
                    return;
                _names = split;
            }

        }

        private void selectFont_Click(object sender, EventArgs e)
        {
            using var fontDialog = new FontDialog();

            fontDialog.ShowColor = true;

            fontDialog.Font = _selectedFont;
            fontDialog.Color = _selectedColor;

            if (fontDialog.ShowDialog() != DialogResult.OK) 
                return;
            _selectedFont = fontDialog.Font;
            _selectedColor = fontDialog.Color;
        }

        private void test_Click(object sender, EventArgs e)
        {
            if (_backgroundImage == null) return;

            var exampleImage = Make_NameTag((Bitmap) _backgroundImage.Clone(), "이름표", _selectedFont);

            var width = exampleImage.Width;
            var height = exampleImage.Height;
            var fixedHeight = 500 * (double)height / width;

            exampleBox.Image = new Bitmap(exampleImage, 
                new Size(500, (int) Math.Round(fixedHeight)));

        }
        private void save_Click(object sender, EventArgs e)
        {
            if (_names == null || _backgroundImage == null) return;

            using var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() != DialogResult.OK) return;

            for (var i = 0; i < _names.Length; i++)
            {
                Save_NameTag(new Bitmap(_backgroundImage), _names[i], folderDialog.SelectedPath, _selectedFont, i);
            }
        }
        private void Save_NameTag(Bitmap image, string name, string path, Font font, int number)
        {
            Make_NameTag(image, name, font).Save(path + "\\" + number + ".png");
        }

        private Bitmap Make_NameTag(Bitmap image, string name, Font font)
        {
            //TO DO
            var graphics = Graphics.FromImage(image);

            var rectangleF = new RectangleF(0, 0, image.Width, image.Height);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            graphics.DrawString(name, _selectedFont, Brushes.Black, rectangleF, format);

            graphics.Flush();

            return image;
        }

        
    }
}
