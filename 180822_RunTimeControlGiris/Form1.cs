using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180822_RunTimeControlGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void btn_Click(object sender, EventArgs e)
        {
           
            Button btn = new Button();
            btn.Text = sayac.ToString();
            Random rnd = new Random();
            btn.Width = 100;
            btn.Height = 50;
            int x=rnd.Next(0,this.ClientSize.Width-btn.Width);
            btn.Left = x;

            int y=rnd.Next(0,this.ClientSize.Height-btn.Height);
            btn.Top = y;
            btn.Click += Btn_Click;
            btn.BringToFront();
            this.Controls.Add(btn);
            sayac++;


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //tıklanan butonu algılama
            Button tiklanan = (Button)sender;
           // MessageBox.Show(tiklanan.Text);
           this.Controls.Remove(tiklanan);
            tiklanan.BringToFront();//tıklananı en öne getir.
            //tiklanan.SendToBack(); en arkaya atar.
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonOlustur(10);
        }
        void ButtonOlustur(int satirSayisi)
        {
            foreach (Control ctrl in this.Controls)
            {   
            
                if(ctrl is Button)
                {
                    this.Controls.Remove(ctrl);
                    
                }
            }
            //ilk döngü satır için işlem yapacak
            //10satırlık 20 kolonluk buton koleksiyonu oluşturacağız.
            for (int i = 0; i < satirSayisi; i++)
            {
                //ikinci döngümüz sütun için işlem yapacak
                for (int j = 0; j < 20; j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);
                    btn.Width = 50;
                    btn.Height = 20;
                    btn.Left += j * 50;
                    btn.Top = (i * 20) + 30;
                    this.Controls.Add(btn);

                }

            }
            this.Width = 50 * 20;
            this.Height = (satirSayisi * 20) + 80;
        }
        private void x20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ButtonOlustur(20);
        }
    }
}
