using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo
{
    public abstract class Item
    {
        public string ItemId { get; set; }
        public int ItemType { get; set; }
        public int NumberOfCopies { get; set; }
        public CheckedInLocation Location { get; set; }

        //Age below which may not borrow
        public int AgeRestriction { get; set; }
        public int ItemCondition { get; set; }
        

    }
    public class CheckedInLocation
    {
        public string BranchName { get; set; }
        public string Aisle { get; set; }
        public string Shelf { get; set; }
        public int ItemCondition { get; set; }

    }


    enum ItemCondition
    {
        Good,
        Fair,
        Poor,
        Damaged,
        Unusable
    }

    enum ItemType
    {
        HardcoverBook,
        PaperbackBook,
        eBook,
        CD,
        DVD,
        Newspaper
    }


}