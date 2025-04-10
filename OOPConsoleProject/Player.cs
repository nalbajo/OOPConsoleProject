﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Player
    {
        public Vector2 position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }

        public bool[,] map;

        private int curHP;
        public int CurHP { get { return curHP; } }

        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        private int power;
        public int Power { get { return power; } set { power = value; } }

        public int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
        }

        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }
        public void equip(int power)
        {
            Game.player.Power += power;
        }

        public void Print() // 플레이어 출력
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                case ConsoleKey.E:
                    inventory.Open();
                    break;
            }
        }

        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }
            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }




    }
}
