namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Process 1 started");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Process 2 started");
        }
    }
}

/*
 Thread bir i� par�ac���d�r. Bir i� par�ac���, bir program�n �al��ma zaman�nda bir i�i yapmak i�in kullan�lan bir yoludur.
 ��lemci, bir i� par�ac���n� �al��t�rmak i�in bir zaman dilimi ay�r�r. Bu zaman dilimi, i� par�ac���n�n �al��t��� s�re boyunca i�lemciyi kullan�r.
 */
