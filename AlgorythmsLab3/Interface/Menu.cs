using System;
using System.Collections.Generic;
using System.Linq;
using AlgorythmsLab3.Menu;

namespace AlgorythmsLab3.Interface
{
    public class Menu
    {
        private readonly List<MenuItem> _items;

        public Menu(List<MenuItem> items)
        {
            _items = items;
        }

        public void Start()
        {
            bool canExit = false;
            do
            {
                DrawMenu();
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                switch (inputKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        MenuNext();
                        break;
                    case ConsoleKey.UpArrow:
                        MenuPrev();
                        break;
                    case ConsoleKey.Enter:
                        var select = _items.Find(item => item.IsSelected);
                        if (select.Title == "Exit") canExit = true;
                        else select.Execute();
                        break;
                }
            } while (!canExit);
        }

        private void MenuPrev()
        {
            ConsoleUtil.ClearScreen();
            MenuItem select = _items.First(item => item.IsSelected);
            int selectindex = _items.IndexOf(select);
            _items[selectindex].IsSelected = false;
            selectindex = selectindex == 0
                ? _items.Count - 1
                : --selectindex;
            _items[selectindex].IsSelected = true;
        }

        private void MenuNext()
        {
            ConsoleUtil.ClearScreen();
            MenuItem select = _items.First(item => item.IsSelected);
            int selectindex = _items.IndexOf(select);
            _items[selectindex].IsSelected = false;
            selectindex = selectindex == _items.Count - 1
                ? 0
                : ++selectindex;
            _items[selectindex].IsSelected = true;
        }

        private void DrawMenu()
        {
            ConsoleUtil.ClearScreen();
            foreach (var item in _items)
            {
                Console.BackgroundColor = item.IsSelected
                    ? ConsoleColor.DarkCyan
                    : ConsoleColor.Black;
                Console.WriteLine(item.Title);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}