using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFCombobox
{
    public class ComboBoxViewModel
    {
        public List<string> NameCollection { get; set; }
        public List<Brush> BrushCollection { get; set; }
        public Dictionary<string,Brush> BrushCollection2 { get; set; }
        public ComboBoxViewModel()
        {
            NameCollection = new List<string>()
            {
                "Joe",
                "Jane",
                "Jerry",
                "Mary",
                "Larry"
            };

            BrushCollection = new List<Brush>()
            {
                Brushes.Red,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Orange
            };

            BrushCollection2 = new Dictionary<string, Brush>
            {
                { "Red", Brushes.Red },
                { "Yellow", Brushes.Yellow },
                { "Green", Brushes.Green },
                { "Blue", Brushes.Blue },
                { "Orange", Brushes.Orange }
            };
        }        
    }
}
