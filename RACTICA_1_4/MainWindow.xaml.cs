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
using RACTICA_1_4.libraryDataSetTableAdapters;
using RACTICA_1_4;
using System.Data;
using System.Net;
using System.Xml.Linq;

namespace RACTICA_1_4
{
    public partial class MainWindow : Window
    {
        authorsTableAdapter authors = new authorsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = authors.GetData();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            second window = new second();
            window.ShowDialog();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string fString = Athid.Text;
            string sString = AthName.Text;
            string tString = AthMail.Text;

            if (fString != "" && sString != "" && tString != "")
            {
                authors.InsertQuery(Convert.ToInt32(Athid.Text), (string)AthName.Text, (string)AthMail.Text);
                datagrid.ItemsSource = authors.GetData();
            }
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedItem != null)
            {
            object Athid = (datagrid.SelectedItem as DataRowView).Row[0];
            object AthName = (datagrid.SelectedItem as DataRowView).Row[1];
            object AthMail = (datagrid.SelectedItem as DataRowView).Row[2];

            authors.DeleteQuery(Convert.ToInt32(Athid), (string)AthName, (string)AthMail);
            datagrid.ItemsSource = authors.GetData();
            }
            
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedItem != null)
            {
                object AthId = (datagrid.SelectedItem as DataRowView).Row[0];

                authors.UpdateQuery(Convert.ToInt32(Athid.Text), (string)AthName.Text, (string)AthMail.Text, Convert.ToInt32(Athid.Text));
                datagrid.ItemsSource = authors.GetData();
            }
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagrid.SelectedItem != null)
            {
                Athid.Text = (datagrid.SelectedItem as DataRowView).Row[0].ToString();
                AthName.Text = (datagrid.SelectedItem as DataRowView).Row[1].ToString();
                AthMail.Text = (datagrid.SelectedItem as DataRowView).Row[2].ToString();
            }
        }
    }
}