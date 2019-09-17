using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessModels
{
    class OrderReminder
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public DateTime ExpirationData { get; set; }

        OrderReminder()
        {

        }
        OrderReminder(int id, int libraryId, DateTime expData)
        {
            Id = id;
            LibraryId = libraryId;
            ExpirationData = expData;
        }
        public string ShowReminder()
        {
            if (ExpirationData > DateTime.Now)
            {
                return string.Format("Order №{0} are expired {1} days ago!", LibraryId, (DateTime.Now - ExpirationData).Days);
            }
            else
            {
                return string.Format("Order №{0} to expire {1} days left.", LibraryId, (ExpirationData - DateTime.Now).Days);
            }
        }
    }
}
