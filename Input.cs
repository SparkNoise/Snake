using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Wczytanie wszystkich przycisków
        private static Hashtable keyTable = new Hashtable();

        //Sprawdzenie czy dany klawisz jest wciśnięty
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //Wykryj, czy naciśnięty jest przycisk klawiatury.
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
