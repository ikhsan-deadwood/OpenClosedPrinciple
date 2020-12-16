using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponWithOCP
{
    class CouponWithCashback : Coupon
    {
        public double discNominal;

        public CouponWithCashback(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }

    }
}
