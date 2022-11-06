using System.Collections.Generic;
using AlgorythmsLab3.Interface.functions.stack;

namespace AlgorythmsLab3.Interface.menus
{
    public class StackMenu : Menu
    {
        public StackMenu(bool isSelected = false) : base(title: "Стэк", isSelected: isSelected, items: new List<MenuItem>()
        {
            new ConvertToRpn(true),
            new ConvertFromRpn()
        })
        {
        }
    }
}