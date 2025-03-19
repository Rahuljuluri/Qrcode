namespace barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox.Image = barcode.Draw(txtBarcode.Text, 50);
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw QRcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox.Image = QRcode.Draw(txtQRcode.Text, 50);
        }
    }
}
