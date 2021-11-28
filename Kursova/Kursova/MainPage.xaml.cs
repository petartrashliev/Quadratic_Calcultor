using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kursova
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Button Click Event Handler
        void OnButtonClicked(object sender, EventArgs args)
        {
            
            var A = double.Parse(a_1.Text);
            var B = double.Parse(b_1.Text);
            var C = double.Parse(c_1.Text);

            
            double ans1 = (-1 * B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
            double ans2 = (-1 * B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
            double ans3 = Math.Pow(B, 2) - 4 * A * C;


            ans1 = Math.Round(ans1, 2);
            ans2 = Math.Round(ans2, 2);
            ans3 = Math.Round(ans3, 2);

            if (ans3<0)

            {   r_1.Text = ans3.ToString();
                r_2.Text = "D < 0, the roots do not exist or the roots are imaginary.";
                x_1.Text = "   --- ";
                x_2.Text = "   --- ";
            }

            if (ans3 == 0)

            {
                r_1.Text = ans3.ToString();
                r_2.Text = "D = 0, the roots are real and equal.";
                x_1.Text = ans1.ToString();
                x_2.Text = ans2.ToString();
            }


            if (ans3 > 0)
            {
               r_1.Text = ans3.ToString();
               r_2.Text = "D > 0, the roots are real and distinct";
               x_1.Text = ans1.ToString();
               x_2.Text = ans2.ToString();
               
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            r_1.Text = String.Empty;
            r_2.Text = String.Empty;
            x_1.Text = String.Empty;
            x_2.Text = String.Empty;

            a_1.Text = String.Empty;
            b_1.Text = String.Empty;
            c_1.Text = String.Empty;


        }
    }
}
