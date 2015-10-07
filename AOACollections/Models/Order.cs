using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AOACollections.Models
{
    public class Order
    {
        [DisplayName("Order Number")]
        public int ID { get; set; }

        [DisplayName("Movie Number")]
        public int MovieNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("User Name")]
        public int UserName { get; set; }

        public virtual Delivery Delivery { get; set; }

        public Order()
        {
            OrderDate = DateTime.Now;
        }
        
    }
}