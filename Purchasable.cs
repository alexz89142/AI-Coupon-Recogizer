using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponRecogizer
{
    internal class Purchasable
    {
        private Image itemPicture { get; set; }

        public Purchasable(Image userImage)
        {
            itemPicture = userImage;
        }
    }
}
