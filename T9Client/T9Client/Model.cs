//Author- Anu Sharma
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using T9Client.ServiceReference1;

namespace T9Client
{

    /// <summary>
    /// Model class. It performs all the interaction with the server.
    /// </summary>
    public class Model
    {
       
        public static List<String> result;
        Service1Client proxy = new Service1Client();


        /// <summary>
        /// This method loads the dictionary by calling 
        /// loadDictionaryAsync().
        /// </summary>
        public void invokeService()
        {
            proxy.loadDictionaryAsync();
        }

        /// <summary>
        /// This method get words by calling getPredictiveTextAsync().
        /// </summary>
        /// <param name="str"></param>
        public void getWords(String str)
        {
            proxy.getPredictiveTextCompleted += proxy_getPredictiveTextCompleted;
            proxy.getPredictiveTextAsync(str);

        }
        /// <summary>
        /// This is the event handler for getPredictiveTextCompleted();
        /// This method sends the words received from the server to the Controller class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void proxy_getPredictiveTextCompleted(object sender, getPredictiveTextCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                result.Add("Error in Server");

            }
            else
            {
                System.Collections.ObjectModel.ObservableCollection<String> words = e.Result;

                result = words.ToList<String>();

                MainPage.getWord();
            }
        }
    }
}
