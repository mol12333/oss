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
using System.Collections;
using Microsoft.Win32;
using Microsoft.VisualBasic;

namespace lab_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

           SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            } 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void lbMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_clouse_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_clouse_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_clouse_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_clouse_4(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_clouse_5(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_clouse_6(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_vich1(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tb1.Text);
            Random rnd1 = new Random();
            int number;
            lb1.Items.Clear();
            lb1.Items.Add("Массив:");
            for (index = 0; index < itemCount; index++)
            {
                
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lb1.Items.Add(number);
            }
            int rez = 0;
            for (index = 1; index < itemCount - 1; index++)
            {
                if (((int)myAL[index] > (int)myAL[index + 1]) && ((int)myAL[index] > (int)myAL[index - 1]))
                    rez++;
                
            }
            lb1.Items.Add("Количество элементов больше соседей:");
            lb1.Items.Add(rez);
        }
        private void Button_vich2(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tb2.Text);
            Random rnd1 = new Random();
            int number;
            lb2.Items.Clear();
            lb2.Items.Add("Массив:");
            for (index = 0; index < itemCount; index++)

            {

                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lb2.Items.Add(number);
            }
            lb2.Items.Add("Элемент больше 25:");
            for (index = 0; index < itemCount; index++)
            {
                if ((int)myAL[index] > 25)
                {
                    lb2.Items.Add(index+1);
                    break;
                }

            }
           
        }
        private void Button_vich3(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tb3.Text);
            Random rnd1 = new Random();
            int number;
            lb3.Items.Clear();
            lb3.Items.Add("Массив:");
            for (index = 0; index < itemCount; index++)

            {

                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lb3.Items.Add(number);
            }
            
            int sum = 0;
            for (index = 0; index < itemCount; index++)
            {
                if ((int)myAL[index] > (int)myAL[1])
                {
                    sum = sum + (int)myAL[index];
                    
                   
                }
               
            }
            lb3.Items.Add("Сумма равна:");
            lb3.Items.Add(sum);
        }
        private void Button_vich4(object sender, RoutedEventArgs e)
        {
            string r = Microsoft.VisualBasic.Interaction.InputBox("Введите k:");
           
            int k = Convert.ToInt32(r);
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tb4.Text);
            Random rnd1 = new Random();
            int number;
            lb4.Items.Clear();
            lb4.Items.Add("Массив:");
            for (index = 0; index < itemCount; index++)

            {

                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lb4.Items.Add(number);
            }
            
            lb4.Items.Add("Элемент больше k:");
            for (index = 0; index < itemCount; index++)
            {
                if ((int)myAL[index] > k)
                {
                    lb4.Items.Add(index + 1);
                    break;
                }

            }
        }
        private void Button_vich5(object sender, RoutedEventArgs e)
        {
            string r = Microsoft.VisualBasic.Interaction.InputBox("Введите k:");

            int k = Convert.ToInt32(r);
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tb5.Text);
            Random rnd1 = new Random();
            int number;
            lb5.Items.Clear();
            lb5.Items.Add("Массив:");
            for (index = 0; index < itemCount; index++)

            {

                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lb5.Items.Add(number);
            }

            int sum = 0;
            for (index = 0; index < itemCount; index++)
            {
                if ((int)myAL[index] > (int)myAL[k-1])
                {
                    sum = sum +(int)myAL[index];
                   
                }

            }
            lb5.Items.Add("Сумма чисел больше k-того элемента:");
            lb5.Items.Add(sum);
        }
            private void Button_vich6(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tb6.Text);
            Random rnd1 = new Random();
            int number;
            lb6.Items.Clear();
            lb6.Items.Add("Массив:");
            for (index = 0; index < itemCount; index++)
            {

                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lb6.Items.Add(number);
            }
            lb6.Items.Add("Элементы больше соседей:");
            for (index = 1; index < itemCount - 1; index++)
            {
                if (((int)myAL[index] > (int)myAL[index + 1]) && ((int)myAL[index] > (int)myAL[index - 1]))
                    lb6.Items.Add(myAL[index]);

            }
            
        }

        private void Button_sohr1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lb1.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }
        private void Button_sohr2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lb2.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }
        private void Button_sohr3(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lb3.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }
        private void Button_sohr4(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lb4.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }
        private void Button_sohr5(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lb5.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }
        private void Button_sohr6(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lb6.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }
    }
}
