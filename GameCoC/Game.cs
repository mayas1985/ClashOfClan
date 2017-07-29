using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCoC
{
    public class Game
    {
        public List<Fighter> Defense { get; set; }

        public List<Fighter> Invader { get; set; }

        public Game()
        {
            Defense = new List<Fighter>();
            Invader = new List<Fighter>();
        }
        public Winner Start()
        {
            Decimal defenseStrikeRequired = Invader.Sum(k => k.Health) / Defense.Sum(k => k.HitPoint);
            Decimal invaderStrikeRequired = Defense.Sum(k => k.Health) / Invader.Sum(k => k.HitPoint);
            if(defenseStrikeRequired < invaderStrikeRequired)
            {
                return Winner.Defense;
            }
            else
            {
                return Winner.Attack;
            }
        }
    }
    public enum Winner
    {
        Defense,
        Attack
    }
}
