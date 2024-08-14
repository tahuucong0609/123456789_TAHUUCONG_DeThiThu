namespace _123456789_TAHUUCONG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string infor1 = " Họ Và Tên: Tạ Hữu Công  \nMSSV: 54222320136 \nNgày Thi:14-8-2024 ";
            Infor.Text = infor1;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void Infor_Click(object sender, EventArgs e)
        {

        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "thông tin");
        }
    }
}
