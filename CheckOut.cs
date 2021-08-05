using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo
{
    class CheckOut
    {
        public string ItemBorrowedId { get; set; }
        public string BorrowerId { get; set; }
        public DateTime CheckoutDateTime { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CheckinDateTime { get; set; }
        public ItemCondition CheckinCondition { get; set; }
        public string Comments { get; set; }

    }
}
