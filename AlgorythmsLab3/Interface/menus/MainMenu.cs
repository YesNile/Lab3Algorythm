using System.Collections.Generic;
using AlgorythmsLab3.Interface.menus;

namespace AlgorythmsLab3.Interface
{
    public class MainMenu : Menu
    {
        public MainMenu() : base(title: "", items: new List<MenuItem>()
        {
            new StackMenu(),
            new ListMenu()
        })
        {
        }
    }
}