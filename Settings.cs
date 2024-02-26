using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public class Settings
    {
        public int RoundIndex { get; set; }
        public int TurnIndex { get; set; }
        public string CurrentPhrase { get; set; }
        public string CurrentCategory { get; set; }
        private Game gameInstance;

        public Settings(Game game)
        {
            RoundIndex = 0;
            TurnIndex = 0;
            gameInstance = game;
        }

        public void TurnChange()
        {

            if(TurnIndex == 3)
            {
                TurnIndex = 0;
                gameInstance.Invoke((MethodInvoker)delegate {
                    gameInstance.EnableBtn();
                    gameInstance.CheckboxChange();
                });
            }
            else
            {
                
                TurnIndex++;
                gameInstance.Invoke((MethodInvoker)delegate {
                    gameInstance.CheckboxChange();
                    gameInstance.BotRound();
                });
            }
        }
        public void RoundChange()
        {
            RoundIndex++;
            gameInstance.lblMoney1.Text = "0";
            gameInstance.lblMoney2.Text = "0";
            gameInstance.lblMoney3.Text = "0";
            gameInstance.lblMoney4.Text = "0";
            gameInstance.EnableBtn();
            gameInstance.Round();
            
        }
    }
}
