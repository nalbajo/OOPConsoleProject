using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items;
        private Stack<string> stack;

        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }
        public void Add(Item item)
        {
            items.Add(item);
        }
        public void Remove(Item item)
        {
            items.Remove(item);
        }
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }
        public void UseAt(int index)
        {
            items[index].Use();
        }
        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu":        Menu();      break;
                    case "UseMenu":     UseMenu();   break;
                    case "DropMenu":    DropMenu();  break;
                    case "UseConfirm":               
                        break;
                    case "DropConfirm":
                        break;
                }
            }
        }
        private void Menu()
        {
            PrintAll();

            Console.WriteLine("1. 시용하기");
            Console.WriteLine("2. 버리기");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }
        private void UseMenu()
        {
            PrintAll();

            Console.WriteLine("사용할 아이템을 선택해주세요.");
            Console.WriteLine("뒤로가기는 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        private void DropMenu()
        {
            PrintAll();

            Console.WriteLine("버릴 아이템을 선택해주세요.");
            Console.WriteLine("뒤로가기는 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("======소유한 아이템======");
            if (items.Count == 0)
            {
                Console.WriteLine("           없음");
            }
            for (int i = 0; i < items.Count; i++ )
            {
                Console.WriteLine("{0}. {1}", i+1, items[i].name);
            }
            Console.WriteLine("=========================");
        }
    }
}
