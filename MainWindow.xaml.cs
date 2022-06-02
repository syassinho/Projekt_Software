using pppp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_The_Checkbox_12.Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_register.IsEnabled = false;
            ;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btn_register.IsEnabled = true;
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {

            if (text_name.Text == "Ahmad")
            {
                if (text_password.Password == "12345")
                {
                    lbl_anzeige.Content = "der Name und das Password sind rechtig";

                }
                else if (text_password.Password == "")
                {
                    lbl_anzeige.Content = "der Name ist rechtig und das Password muss angegeben werden ";
                }
                else
                {
                    lbl_anzeige.Content = "der Name ist rechtig";
                }

            }
            else if (text_name.Text == "ibrahem")
            {
                if (text_password.Password == "56789")
                {
                    lbl_anzeige.Content = "der Name und das Password sind rechtig";

                }
                else if (text_password.Password == "")
                {
                    lbl_anzeige.Content = "der Name ist rechtig und das Password muss angegeben werden ";
                }
                else
                {
                    lbl_anzeige.Content = "der Name ist rechtig und das Password ist Falsch";
                }
            }
            else
            {
                lbl_anzeige.Content = "der Name ist nicht vorhanden"; 
            }
        }
       

    }
  
}


