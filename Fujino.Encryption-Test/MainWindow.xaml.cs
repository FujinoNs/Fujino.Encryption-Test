using System.Windows;

namespace Fujino.Encryption_Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, RoutedEventArgs e)
        {
            this.txt_textout1.Text = Fujino.Encryption.Encryption.EncryptString(this.txt_textin1.Text, this.txt_pass1.Text);

            #region 
            this.txt_pass2.Text = this.txt_pass1.Text;
            this.txt_textin2.Text = this.txt_textout1.Text;
            this.txt_textout1.ToolTip = this.txt_textout1.Text;
            this.txt_textin2.ToolTip = this.txt_textin2.Text;
            this.txt_textout2.Text = "";
            #endregion
        }

        private void btn_decrypt_Click(object sender, RoutedEventArgs e)
        {
            this.txt_textout2.Text = Fujino.Encryption.Encryption.DecryptString(this.txt_textin2.Text, this.txt_pass2.Text);
        }

        private void btn_encrypt_array_Click(object sender, RoutedEventArgs e)
        {
            byte[] keysaltarray = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 };
            this.txt_textout1.Text = Fujino.Encryption.Encryption.EncryptStringSaltArray(this.txt_textin1.Text, this.txt_pass1.Text, keysaltarray);

            #region 
            this.txt_pass2.Text = this.txt_pass1.Text;
            this.txt_textin2.Text = this.txt_textout1.Text;
            this.txt_textout1.ToolTip = this.txt_textout1.Text;
            this.txt_textin2.ToolTip = this.txt_textin2.Text;
            this.txt_textout2.Text = "";
            #endregion
        }

        private void btn_decrypt_array_Click(object sender, RoutedEventArgs e)
        {
            byte[] keysaltarray = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 };
            this.txt_textout2.Text = Fujino.Encryption.Encryption.DecryptStringSaltArray(this.txt_textin2.Text, this.txt_pass2.Text, keysaltarray);
        }
    }
}
