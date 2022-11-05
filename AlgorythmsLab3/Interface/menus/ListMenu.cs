using System;
using System.Collections.Generic;

namespace AlgorythmsLab3.Interface.menus
{
    public class ListMenu : Menu
    {
        public ListMenu(bool isSelected = false) : base(title: "Лист", items: new List<MenuItem>() { }, isSelected: isSelected)
        {
        }
    }
}