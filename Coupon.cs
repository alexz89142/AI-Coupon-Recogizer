using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponRecogizer
{
    internal class Coupon
    {
        public Image couponImage { get; set; }
        public int couponBarcode { get; set; }
        public Coupon(Image[] userImages)
        {
            couponImage = userImages[0];

            /*
                userImages will be an array containing either 1 or 2 images, depending on whether the barcode is on the back of the coupon or not
                The image with barcode will always be the second one
            */
            if (userImages.Length == 1)
            {
                couponBarcode = generateBarcode(userImages[0]);
            }
            else {
                couponBarcode = generateBarcode(userImages[1]);
            }
        }

        public int generateBarcode(Image couponImage)
        {
            int barcodeNumber;

            barcodeNumber = 0;/* Will scan barcode image and convert to number */
            return barcodeNumber;
        }

    }
}
