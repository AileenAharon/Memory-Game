using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// $G$ SFN-009 (+10) Bonus: pictures in buttons

namespace UserInterface
{
    public class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            MemoryGameForm memoryGame = new MemoryGameForm();
            memoryGame.ShowDialog();
        }
    }
}
