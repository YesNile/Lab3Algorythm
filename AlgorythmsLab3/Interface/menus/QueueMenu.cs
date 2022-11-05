using System.Collections.Generic;

namespace AlgorythmsLab3.Interface.menus
{
    public class QueueMenu : Menu
    {
        public QueueMenu(bool isSelected = false) : base(title: "Очередь", isSelected: isSelected, items: new List<MenuItem>()
        {
            
        })
        {
        }
    }
}