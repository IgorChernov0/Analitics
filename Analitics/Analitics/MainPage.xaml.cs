using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Analitics
{
    public partial class MainPage : ContentPage
    {
        double i = 0;
        public MainPage()
        {
            InitializeComponent();
            Nal.IsEnabled = false;
            Termianl.IsEnabled = false;

        }
        private void Bodo_4_Clicked(object sender, EventArgs e)
        {
            i += 266;

            Count.Text = Convert.ToString(i);
        }
        private void Bodo_6_Clicked(object sender, EventArgs e)
        {
            i += 399;

            Count.Text = Convert.ToString(i);
        }

        private void Termianl_Clicked(object sender, EventArgs e)
        {
            string text = EdiT.Text;
            double rez = Convert.ToDouble(text);
            double count = rez * 0.02;
            i += rez - count;
            Count.Text = Convert.ToString(i);
            EdiT.Text = "";
        }
        private void Bodo_5_Clicked(object sender, EventArgs e)
        {
            i += 332.5;

            Count.Text = Convert.ToString(i);
        }

        private void Bodo_7_Clicked(object sender, EventArgs e)
        {
            i += 532;

            Count.Text = Convert.ToString(i);
        }
        private void Bodo_8_Clicked(object sender, EventArgs e)
        {
            i += 665;

            Count.Text = Convert.ToString(i);
        }
        private void Bodo_9_Clicked(object sender, EventArgs e)
        {
            i += 798;

            Count.Text = Convert.ToString(i);
        }
        private void Nal_Clicked(object sender, EventArgs e)
        {
            string text = EdiT.Text;
            double rez = Convert.ToDouble(text);
            i += rez;
            Count.Text = Convert.ToString(i);
            EdiT.Text = "";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Count.Text = "";
            i = 0;
        }



        private void EdiT_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EdiT.Text == "")
            {

                Termianl.IsEnabled = false;
                Nal.IsEnabled = false;
            }
            else
            {
                Termianl.IsEnabled = true;
                Nal.IsEnabled = true;

            }
        }
    }
}
