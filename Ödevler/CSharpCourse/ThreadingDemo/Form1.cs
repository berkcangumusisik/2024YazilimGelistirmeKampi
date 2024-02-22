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
 Thread bir iþ parçacýðýdýr. Bir iþ parçacýðý, bir programýn çalýþma zamanýnda bir iþi yapmak için kullanýlan bir yoludur.
 Ýþlemci, bir iþ parçacýðýný çalýþtýrmak için bir zaman dilimi ayýrýr. Bu zaman dilimi, iþ parçacýðýnýn çalýþtýðý süre boyunca iþlemciyi kullanýr.
 */
