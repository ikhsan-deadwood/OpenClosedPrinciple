using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponWithOCP
{
    public abstract class Coupon
    {
        public abstract double calculate(double originPrice);

    }
}
