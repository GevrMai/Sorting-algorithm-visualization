namespace BubbleSort
{
    public partial class Form1 : Form
    {
        // array to sort
        private List<int> arrayToSort;

        // drawing tools
        private Bitmap bitmap;
        private Graphics? graphics;
        private Pen whitePen;
        private Pen redPen;
        private SolidBrush drawBrush;

        // pictuteBox options 
        private float MaxHeight = 790;
        private float MaxWidth = 1865;

        // rendering delay
        private int msDelay = 500;

        // x coordinate value
        private float CurrentX = 0;

        // Number of pixels per 1/Array.max 
        private float PixsPerOneHeight
        {
            get
            {
                return MaxHeight / arrayToSort.Max(x => x);
            }
        }

        // rectangle width
        private float RectangleWidth
        {
            get
            {
                return (MaxWidth / arrayToSort.Count) > 200 ? 200 : (MaxWidth / arrayToSort.Count);
            }
        }

        // determine the font size for labeling rectangles
        private Font font
        {
            get
            {
                if (arrayToSort.Count <= 15) return new Font("Century Gothic", 16);
                if (arrayToSort.Count <= 30) return new Font("Century Gothic", 14);
                if (arrayToSort.Count <= 50) return new Font("Century Gothic", 12);
                if (arrayToSort.Count <= 70) return new Font("Century Gothic", 10);
                if (arrayToSort.Count <= 90) return new Font("Century Gothic", 8);
                if (arrayToSort.Count <= 100) return new Font("Century Gothic", 6);

                return new Font("Century Gothic", 10);
            }
        }
        
        public Form1()
        {
            whitePen = new Pen(Color.FromKnownColor(KnownColor.WhiteSmoke), 2);
            redPen = new Pen(Color.FromKnownColor(KnownColor.Red), 2);
            drawBrush = new SolidBrush(Color.White);

            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            UpdateDrawing();
            arrayToSort = new();

            // Validation of entered data
            if (string.IsNullOrEmpty(userInput.Text))
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Enter an array";
                return;
            }

            errorLabel.Text = "";

            var input = userInput.Text.Trim().Split();

            foreach (var c in input)
            {
                if (int.TryParse(c, out int num))
                    arrayToSort.Add(num);
            }

            if (arrayToSort.Count > 0)
            {
                Draw();
                pictureBox.Image = bitmap;
            }
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (arrayToSort.Count > 0)
                BubbleSort();
        }

        // update picture
        private void UpdateDrawing()
        {
            bitmap = new Bitmap(1870, 795);
            graphics = Graphics.FromImage(bitmap);
            CurrentX = 0;

            // garbage collection for memory optimization
            GC.Collect();
        }

        private void DrawRectangle(int num, bool isRed = false)
        {
            var yForLabel = MaxHeight - (PixsPerOneHeight * num / 2);

            // Y value for label
            var yLabel = yForLabel > 760 ? MaxHeight - (PixsPerOneHeight * num) - 30 : yForLabel;

            PointF point = new PointF(CurrentX + (RectangleWidth / 2 - num.ToString().Length * 2), yLabel);

            graphics.DrawString($"{num}", font, drawBrush, point);

            if (isRed)  // draw the red rectangle
                graphics.DrawRectangle(redPen, CurrentX, MaxHeight - (PixsPerOneHeight * num), RectangleWidth, PixsPerOneHeight * num);
            else
                graphics.DrawRectangle(whitePen, CurrentX, MaxHeight - (PixsPerOneHeight * num), RectangleWidth, PixsPerOneHeight * num);

            CurrentX += RectangleWidth;
        }

        // draw the whole picture
        private void Draw(int? x = null, int? y = null)
        {
            for (int i = 0; i < arrayToSort.Count; i++)
            {
                if (i == x || i == y)   // red rectangle
                    DrawRectangle(arrayToSort[i], true);
                else
                    DrawRectangle(arrayToSort[i]);
            }
        }

        private async void BubbleSort()
        {
            acceptButton.Enabled = false;
            sortButton.Enabled = false;

            for (int i = 0; i < arrayToSort.Count - 1; i++)
                for (int j = 0; j < arrayToSort.Count - i - 1; j++)
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        UpdateDrawing();
                        Draw(j, j + 1);
                        pictureBox.Image = bitmap;
                        await Task.Delay(msDelay);

                        (arrayToSort[j], arrayToSort[j + 1]) = (arrayToSort[j + 1], arrayToSort[j]);
                        
                        UpdateDrawing();
                        Draw(j, j + 1);
                        pictureBox.Image = bitmap;
                        await Task.Delay(msDelay);
                    }

            await Task.Delay(1000);

            UpdateDrawing();
            Draw();
            pictureBox.Image = bitmap;

            errorLabel.Text = "Done";
            errorLabel.ForeColor = Color.WhiteSmoke;
            acceptButton.Enabled = true;
            sortButton.Enabled = true;
        }

        private async void msDelayButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(msDelayTextBox.Text, out int delay))
            {
                msDelay = delay;
                delayLabel.Text = "Done";
                await Task.Delay(1500);
                delayLabel.Text = "";
            }
        }
    }
}