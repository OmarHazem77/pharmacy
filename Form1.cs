namespace pharmacy
{
    public partial class Form1 : Form
    {
        Label id_lbl = new Label();
        Label price_lbl = new Label();
        Label quantity_lbl = new Label();

        TextBox id_txt = new TextBox();
        TextBox price_txt = new TextBox();
        TextBox quantity_txt = new TextBox();
        TextBox output = new TextBox();

        Button add = new Button();
        Button h_price = new Button();
        Button l_quantity = new Button();

        PictureBox p = new PictureBox();

        int[] ids = new int[100];
        int[] prices = new int[100];
        int[] quantities = new int[100];
        int index = 0;


        public Form1()
        {
            InitializeComponent();
            this.Text = "pharmacy application";
            this.Size = new System.Drawing.Size(750, 450);
            this.Controls.Add(id_lbl);
            this.Controls.Add(price_lbl);
            this.Controls.Add(quantity_lbl);
            this.Controls.Add(id_txt);
            this.Controls.Add(price_txt);
            this.Controls.Add(quantity_txt);
            this.Controls.Add(output);
            this.Controls.Add(add);
            this.Controls.Add(h_price);
            this.Controls.Add(l_quantity);
            this.Controls.Add(p);
            p.Image = Image.FromFile(@"C:\Users\Amr\Desktop\بتاع كله\f12 - front\pngfind.com-white-question-mark-icon-6865480.png");
            p.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id_lbl.Text = "ID : ";
            id_lbl.Location = new Point(20, 20);
            id_lbl.BackColor = Color.Transparent;

            price_lbl.Text = "Price : ";
            price_lbl.Location = new Point(20, 100);

            quantity_lbl.Text = "Quantity : ";
            quantity_lbl.Location = new Point(20, 180);

            id_txt.Location = new Point(250, 20);
            id_txt.Size = new Size(150, 50);

            price_txt.Location = new Point(250, 100);
            price_txt.Size = new Size(150, 50);

            quantity_txt.Location = new Point(250, 180);
            quantity_txt.Size = new Size(150, 50);

            output.Location = new Point(475, 340);
            output.Size = new Size(200, 50);
            output.ReadOnly = true;
            output.Multiline = true;
            output.ScrollBars = ScrollBars.Vertical;
            
            add.Location = new Point(300, 260);
            add.Size = new Size(60, 40);
            add.Text = "Add";
            add.Click += new EventHandler(add_btnClick);


            h_price.Location = new Point(20, 340);
            h_price.Size = new Size(150, 50);
            h_price.Text = "price higher that 1000";
            h_price.Click += new EventHandler(h_price_btnClick);

            l_quantity.Location = new Point(250, 340);
            l_quantity.Size = new Size(150, 50);
            l_quantity.Text = "Low Quantity (less than 10)";
            l_quantity.Click += new EventHandler(l_quantity_btnClick);

            p.Size = new Size(240, 240);
            p.Location = new Point(480, 45);


        }
        private void add_btnClick(object sender, EventArgs e)
        {
            int id = int.Parse(id_txt.Text);
            int price = int.Parse(price_txt.Text);
            int quantity = int.Parse(quantity_txt.Text);
            ids[index] = id;
            prices[index] = price;
            quantities[index] = quantity;
            index++;
            id_txt.Clear();
            price_txt.Clear();
            quantity_txt.Clear();




        }
        private void h_price_btnClick(object sender, EventArgs e)
        {

            output.Clear();
            for (int i = 0; i < index; i++)
            {
                if ( prices[i] > 1000)
                {
                    output.AppendText(ids[i].ToString()+" , ");
                    

                }
            }


        }
        private void l_quantity_btnClick(object sender, EventArgs e)
        {
            output.Clear();
            for (int i = 0; i < index; i++)
            {
                if (quantities[i] < 10)
                {
                    output.AppendText(ids[i].ToString()+" , ");

                }
            }
        }

    }
}