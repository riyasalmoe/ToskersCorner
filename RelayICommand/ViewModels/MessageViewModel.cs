using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RelayICommand.ViewModels
{
    public class MessageViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }
        public RelayCommand MessageBoxCommand { get; private set; }
        public RelayCommand ConsoleLogCommand { get; private set; }

        public MessageViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                "Hello World!",
                "My Name is Riyas",
                "I love learning Commands",
                "I'm a message box",
                "I'm a console!"
            };

            MessageBoxCommand = new RelayCommand(DisplayInMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayInConsole, ConsoleCanUse);
        }

        public void DisplayInMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }

        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }

        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "I'm a console!")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "I'm a message box")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
