using AlgorythmsLab3.Structures.LinkedList;

namespace AlgorythmsLab3.Interface.functions.list
{
    public abstract class MenuItemList : MenuItem
    {
        protected LinkedList<int> List;
        protected MenuItemList(LinkedList<int> list,string title, bool isSelected = false) : base(title, isSelected)
        {
            List = list;
        }
    }
}