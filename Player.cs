using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe30
{
    internal class Player
    {
        private string _name;
        private int _healt;
        private int _atk;
        private decimal _money;

        public string Name
        { get { return _name; } }
        public int Healt
        { get { return _healt; } }
        public int Attak
        { get { return _atk; } }
        public decimal Money
        { get { return _money; } }

        public Player(string name, int healt, int atk, decimal money)
        {
            _name = name;
            _healt = healt;
            _atk = atk;
            _money = money;
        }



        public string ToString()
        {
            return $"Name: {_name}\r\nHealt: {_healt}\r\nAttack: {_atk}\r\nMoney: {_money}";
        }

        public void Geld(int einaus)
        {
            _money += einaus;
        }
    }
        
}
