using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201RDB249_1prakt
{
    public class AI
    {
        public AI()
        {
        }

        public List<Path> TakeTwo(bool isMaxTurn, Game game)
        {
            List<Path> result = new List<Path>();

            char[] charArr = game.getskaitVirkne().ToCharArray();
            bool found = false;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('2'))
                {
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                result.Add(new Path(2, -2));
                return result;
            }

            if (game.getskaitVirkne().Length == 1)
            {
                if (game.getMaximScore() > game.getMinimScore()) result.Add(new Path(2,1));
                if (game.getMaximScore() < game.getMinimScore()) result.Add(new Path(2, -1));
                if (game.getMaximScore() == game.getMinimScore()) result.Add(new Path(2, 0));
                return result;
                //game end
            }

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('2'))
                {
                    charArr[i] = '0';
                    break;
                }
            }

            String res = "";
            for (int i = 0; i < charArr.Length; i++)
            {
                if (!charArr[i].Equals('0'))
                {
                    res += charArr[i];
                }
            }
            if (isMaxTurn == true) game.setMaximScore(game.getMaximScore()-2);
            if (isMaxTurn == false) game.setMinimScore(game.getMinimScore() - 2);
            game.setskaitVirkne(res);
            
            return Minimax(!isMaxTurn, game);
        }

        public List<Path> TakeThree(bool isMaxTurn, Game game)
        {
            List<Path> result = new List<Path>();

            char[] charArr = game.getskaitVirkne().ToCharArray();
            bool found = false;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('3'))
                {
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                result.Add(new Path(3, -2));
                return result;
            }

            if (game.getskaitVirkne().Length == 1)
            {
                if (game.getMaximScore() > game.getMinimScore()) result.Add(new Path(3, 1));
                if (game.getMaximScore() < game.getMinimScore()) result.Add(new Path(3, -1));
                if (game.getMaximScore() == game.getMinimScore()) result.Add(new Path(3, 0));
                return result;
                //game end
            }

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('3'))
                {
                    charArr[i] = '0';
                    break;
                }
            }
            String res = "";
            for (int i = 0; i < charArr.Length; i++)
            {
                if (!charArr[i].Equals('0'))
                {
                    res += charArr[i];
                }
            }
            if (isMaxTurn == true) game.setMaximScore(game.getMaximScore() - 3);
            if (isMaxTurn == false) game.setMinimScore(game.getMinimScore() - 3);
            game.setskaitVirkne(res);
            
            return Minimax(!isMaxTurn, game);
        }

        public List<Path> Minimax(bool isMaxTurn, Game game )
        {
            List<Path> path = new List<Path>();
            List<Path> tmpPath = new List<Path>();
            Game gameCopy = game;
            for (int i = 0; i<2; i++)
            {
                if (i == 0)
                {
                    tmpPath = TakeTwo(isMaxTurn, gameCopy);
                    path.Add(tmpPath.First());
                }
                if (i == 1)
                {
                    tmpPath = TakeThree(isMaxTurn, gameCopy);
                    path.Add(tmpPath.First());
                }
            }

            List<Path> result = new List<Path>();
            if (path.First().Value == -2)
            {
                result.Add(new Path(3, path.Last().Value));
                return result;
            }
                
            if (path.Last().Value == -2)
            {
                result.Add(new Path(2, path.First().Value));
                return result;
            }
                

            if (isMaxTurn == true)
            {
                if (path.First().Value >= path.Last().Value)
                {
                    result.Add(new Path(2, path.First().Value));
                }
                if (path.First().Value < path.Last().Value)
                {
                    result.Add(new Path(3, path.Last().Value));
                }
                return result;
            }
            if (path.First().Value <= path.Last().Value)
            {
                result.Add(new Path(2, path.First().Value));
            }
            if (path.First().Value > path.Last().Value)
            {
                result.Add(new Path(3, path.Last().Value));
            }
            return result;



        }
    }
}
