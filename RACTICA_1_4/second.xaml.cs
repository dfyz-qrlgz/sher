using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RACTICA_1_4.libraryDataSetTableAdapters;

namespace RACTICA_1_4
{

    public partial class second : Window
    {
        booksTableAdapter books = new booksTableAdapter();
        authorsTableAdapter authors = new authorsTableAdapter();
        public second()
        {
            InitializeComponent();
            datagrid2.ItemsSource = books.GetData();

            Cmbox.ItemsSource = authors.GetData();
            Cmbox.DisplayMemberPath = "author_id";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            object BookId = (datagrid2.SelectedItem as DataRowView).Row[0];
            books.DeleteQuery(Convert.ToInt32(BookId));
            datagrid2.ItemsSource = books.GetData();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            books.InsertQuery(Convert.ToInt32(Bookid.Text), BkName.Text, Convert.ToInt32(Cmbox.Text), PubDate.Text);
            datagrid2.ItemsSource = books.GetData();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid2.SelectedItem != null)
            {
                object BookId = (datagrid2.SelectedItem as DataRowView).Row[0];

                books.UpdateQuery(Convert.ToInt32(Bookid.Text), (string)BkName.Text, Convert.ToInt32(Cmbox.Text), (string)PubDate.Text, Convert.ToInt32(BookId));
                datagrid2.ItemsSource = books.GetData();
            }

        }

        private void datagrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(datagrid2.SelectedItem != null)
            {
                Bookid.Text = (datagrid2.SelectedItem as DataRowView).Row[0].ToString();
                BkName.Text = (datagrid2.SelectedItem as DataRowView).Row[1].ToString();
                Cmbox.Text = (datagrid2.SelectedItem as DataRowView).Row[2].ToString();
                PubDate.Text = (datagrid2.SelectedItem as DataRowView).Row[3].ToString();
            }
        }
    }
}