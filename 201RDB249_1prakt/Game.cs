using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201RDB249_1prakt
{
    public class Game
    {
        private String skaitVirkne;
        private int minimizerScore;
        private int maximizerScore;

        public Game(String xskaitVirkne, int xminimizerScore, int xmaximizerScore)
        {
            skaitVirkne = xskaitVirkne;
            minimizerScore = xminimizerScore;
            maximizerScore = xmaximizerScore;
        }

        public void setMinimScore(int xminimizerScore)
        {
            minimizerScore = xminimizerScore;
        }
        public void setMaximScore(int xmaximizerScore)
        {
            maximizerScore = xmaximizerScore;
        }
        public void setskaitVirkne(String xskaitVirkne)
        {
            skaitVirkne = xskaitVirkne;
        }

        public String getskaitVirkne()
        {
            return skaitVirkne;
        }
        public int getMinimScore()
        {
            return minimizerScore;
        }
        public int getMaximScore()
        {
            return maximizerScore;
        }
    }


}
