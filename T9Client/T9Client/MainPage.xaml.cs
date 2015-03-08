// Author - Anu Sharma

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Threading;
using System.ServiceModel;
using T9Client.ServiceReference1;
using System.Text;


namespace T9Client
{
    /// <summary>
    /// Silverlight client. This is the controller class.
    /// </summary>
    public partial class MainPage : UserControl
    {

        System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        static System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        
        string textBoxText;
        String keyPresses;
        int count = 1;
        Model obj = new Model();
        static int counter = 0;
        static int counter1 = 0;
        static int counter2 = 0;
        static int counter3 = 0;
        static int counter4 = 0;
        static int counter5 = 0;
        static int counter6 = 0;
        static int counter7 = 0;
        

        /// <summary>
        /// Main Page constructor.
        /// Initializes component and sets timer interval.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            myDispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            myDispatcherTimer.Tick += new EventHandler(timer_tick);

            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(timer_handle);

        }


        /// <summary>
        /// Event handler of timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void timer_tick(object sender, EventArgs e)
        {
            myDispatcherTimer.Stop();

            counter = 0;
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;
            counter4 = 0;
            counter5 = 0;
            counter6 = 0;
            counter7 = 0;

        }

        /// <summary>
        /// Button1 click handler. Displays 1 in non predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {   
            if (checkBox1.IsChecked == false)
            {
                textBox.Text += "1";
                textBox.Focus();
                textBox.SelectionStart = textBox.Text.Length;
                
            }
        }

        /// <summary>
        /// Button 2 Click handler.
        /// Displays a, b, c, 1 in non predictive mode when number of times button clicked
        /// are 1,2,3,4 respectively.
        /// Stores 2 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void button2_Click(object sender, RoutedEventArgs e)
        {

            if (checkBox1.IsChecked == false)
            {

                counter++;

                if (counter == 1)
                {
                    textBoxText = "a";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "b";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                 }

                else if (counter == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "c";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "2";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }


            if (checkBox1.IsChecked == true)
            {
                keyPresses += "2";
                obj.getWords(keyPresses);
                
            }

        }


        /// <summary>
        /// Button 3 Click handler.
        /// Displays d, e, f, 2 in non predictive mode when number of times button clicked
        /// are 1,2,3,4 respectively.
        /// Stores 3 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
            if (checkBox1.IsChecked == false)
            {
                counter1++;

                if (counter1 == 1)
                {
                    textBoxText = "d";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter1 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "e";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter1 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "f";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter1 == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "3";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }


            if (checkBox1.IsChecked == true)
            {
                keyPresses += "3";
                obj.getWords(keyPresses);
            }

        }


        /// <summary>
        /// Button 4 Click handler.
        /// Displays g, h, i, 4 in non predictive mode when number of times button clicked
        /// are 1,2,3,4 respectively.
        /// Stores 4 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {
                counter2++;

                if (counter2 == 1)
                {
                    textBoxText = "g";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter2 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "h";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;

                }

                else if (counter2 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "i";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "4";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }

            if (checkBox1.IsChecked == true)
            {
                keyPresses += "4";
                obj.getWords(keyPresses);
            }

        }


        /// <summary>
        /// Button 5 Click handler.
        /// Displays j, k, l, 5 in non predictive mode when number of times button clicked
        /// are 1,2,3,4 respectively.
        /// Stores 5 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {

                counter3++;

                if (counter3 == 1)
                {
                    textBoxText = "j";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter3 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "k";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;

                }

                else if (counter3 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "l";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter3 == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "5";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }

            if (checkBox1.IsChecked == true)
            {
                keyPresses += "5";
                obj.getWords(keyPresses);
            }
        }


        /// <summary>
        /// Button 2 Click handler.
        /// Displays m, n, o, 6 in non predictive mode when number of times button clicked
        /// are 1,2,3,4 respectively.
        /// Stores 6 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {

                counter4++;

                if (counter4 == 1)
                {
                    textBoxText = "m";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter4 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "n";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;

                }

                else if (counter4 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "o";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter4 == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "6";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }


            if (checkBox1.IsChecked == true)
            {
                keyPresses += "6";
                obj.getWords(keyPresses);
            }
        }



        /// <summary>
        /// Button 7 Click handler.
        /// Displays p, q, r, s, 7 in non predictive mode when number of times button clicked
        /// are 1,2,3,4,5 respectively.
        /// Stores 7 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {

                counter5++;

                if (counter5 == 1)
                {

                    textBoxText = "p";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter5 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "q";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;

                }

                else if (counter5 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "r";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter5 == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "s";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter5 == 5)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "7";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }

            if (checkBox1.IsChecked == true)
            {

                keyPresses += "7";
                obj.getWords(keyPresses);
            }
        }


        /// <summary>
        /// Button 8 Click handler.
        /// Displays t, u, v, 8 in non predictive mode when number of times button clicked
        /// are 1,2,3,4 respectively.
        /// Stores 8 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {

                counter6++;

                if (counter6 == 1)
                {

                    textBoxText = "t";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter6 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "u";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;

                }

                else if (counter6 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "v";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter6 == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "8";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }


            if (checkBox1.IsChecked == true)
            {
                keyPresses += "8";
                obj.getWords(keyPresses);
             }
        }


        /// <summary>
        /// Button 9 Click handler.
        /// Displays w, x, y, z, 9 in non predictive mode when number of times button clicked
        /// are 1,2,3,4,5 respectively.
        /// Stores 9 as keyPress in predictive mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {

                counter7++;

                if (counter7 == 1)
                {
                    textBoxText = "w";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                    myDispatcherTimer.Start();
                }

                else if (counter7 == 2)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "x";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;

                }

                else if (counter7 == 3)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "y";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter7 == 4)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "z";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

                else if (counter7 == 5)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBoxText = "9";
                    textBox.Text = textBox.Text + textBoxText;
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }

            }

          if (checkBox1.IsChecked == true)
            {

                keyPresses += "9";
                obj.getWords(keyPresses);
            }
        }


        /// <summary>
        /// Button 0 Click handler.
        /// Displays 0 in non predictive mode on single click.
        /// Performs as a toggle function in predictive mode.
        /// It circulates to the next word choice that 
        /// can be assembled from the sequence of button presses so far.
        /// 
        /// Please make note that you have to Press this button to get the 
        /// predicted or valid word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {

                textBox.Text += "0";
                textBox.Focus();
                textBox.SelectionStart = textBox.Text.Length;
            }

            else
            {
                if (count < Model.result.Count)
                {
                    String prev = textBox.Text;
                    if (prev.Contains(" "))
                    {
                        String[] words = prev.Split(' ');
                        StringBuilder prefixWords = new StringBuilder("");
                        for (int i = 0; i < words.Length - 1; i++)
                        {
                            prefixWords.Append(words[i] + " ");
                        }
                        String newPrefix = prefixWords.ToString();
                        textBox.Text = newPrefix + Model.result[count];
                        textBox.Focus();
                        textBox.SelectionStart = textBox.Text.Length;
                        count++;
                   }
                    else
                    {
                        textBox.Text = Model.result[count];
                        textBox.Focus();
                        textBox.SelectionStart = textBox.Text.Length;
                        count++;
                    }
                }
                else
                    count = 0;
            }
        }

        /// <summary>
        /// This button handles backspaces.
        /// It deletes the most recent button press from the letter rows.
        /// Once the user enters a space, she or he may press a backspace
        /// to delete the space, and in addition to the space,
        /// the previous word is deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button11_Click(object sender, RoutedEventArgs e)
        {

            if (textBox.Text != "")
            {
                if (checkBox1.IsChecked == false)
                {
                    try
                    {
                        String str = textBox.Text;

                        str = str.Remove(str.Length - 1);
                        textBox.Text = str;
                        textBox.Focus();
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                    catch (Exception) { }

                }

                else
                {
                    String str = textBox.Text;
                    if (str[str.Length -1] == ' ')
                    {
                        String[] words = str.Split(' ');
                        StringBuilder prefixWords = new StringBuilder("");
                        for (int i = 0; i < words.Length - 2; i++)
                        {
                            prefixWords.Append(words[i] + " ");
                        }

                        String newPrefix = prefixWords.ToString();
                        textBox.Text = newPrefix;
                        textBox.Focus();
                        textBox.SelectionStart = textBox.Text.Length;
                        if (textBox.Text == "")
                            keyPresses = "";

                    }

                    else if (!string.IsNullOrEmpty(str) && str[str.Length - 1] == '-')
                    {
                        str = str.Remove(str.Length - 1);
                        textBox.Text = str;
                    
                    
                    }
                    else {
                       
                        str = str.Remove(str.Length - 1);
                        textBox.Text = str;
                       
                           char[] arr = keyPresses.ToCharArray();
                            keyPresses = "";
                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                 keyPresses += arr[i];
                            }

                            obj.getWords(keyPresses);
                        
                            textBox.Focus();
                            textBox.SelectionStart = textBox.Text.Length;
                            if (textBox.Text == "")
                                keyPresses = "";

                    }
                  }
            }

            else  {}
        }


        /// <summary>
        /// It is the space button.
        /// Appends space to the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                keyPresses = "";
                textBox.Text += " ";
                textBox.Focus();
                textBox.SelectionStart = textBox.Text.Length;
            }
            else
            {
               textBox.Text += " ";
               textBox.Focus();
               textBox.SelectionStart = textBox.Text.Length;
            }

        }


        /// <summary>
        /// Event handler for check box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                obj.invokeService();

            }
         }


        /// <summary>
        /// Event handler for text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /// <summary>
        /// This method is called after receiving the list of words from
        /// the Model class.
        /// </summary>
        public static void getWord() {

            timer.Start();
           
        }

        /// <summary>
        /// Event handler for the timer which sets the word in the textbox(in predictive mode) 
        /// after getting predicted word from Model class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void timer_handle(object sender, EventArgs e)
        {
            timer.Stop();

            String prev = textBox.Text;
            if (prev.Contains(" "))
            {
                String[] words = prev.Split(' ');
                StringBuilder prefixWords = new StringBuilder("");
                for (int i = 0; i < words.Length - 1; i++)
                {
                    prefixWords.Append(words[i] + " ");
                }
                String newPrefix = prefixWords.ToString();
                textBox.Text = newPrefix + Model.result[0];
                textBox.Focus();
                textBox.SelectionStart = textBox.Text.Length;

            }
            else
            {
                textBox.Text = Model.result[0];
                textBox.Focus();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    
    }
}
