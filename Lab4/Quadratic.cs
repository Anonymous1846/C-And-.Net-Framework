using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Quadratic
    {
        private double sqaure_power, single_power, zero_power;
        //The Eqn is (Some Number)x^2+(Some Number)x^1+(Some Number)x^0
        public Quadratic()
        {
            sqaure_power = 0;
            single_power = 0;
            zero_power = 0;
        }
        public void setVal(double sq,double nq,double zq)
        {
            sqaure_power = sq;
            single_power = nq;
            zero_power = zq;
        }
       public double z_r()
        {
            return zero_power;
        }
        public double sq_r()
        {
            return sqaure_power;
        }
        public double s_r()
        {
            return single_power;
        }
        public double neg_root_of_quadratic()
        {
            double root;
            root = (-single_power + Math.Sqrt((Math.Pow(single_power, 2) -( 4 * sqaure_power * zero_power)))) / (2 * sqaure_power);
            return root;
        }
        public double pos_root_of_quadratic()
        {
            double root;
            root = (-single_power - Math.Sqrt((Math.Pow(single_power, 2) - (4 * sqaure_power * zero_power))))/(2 * sqaure_power);
            return root;
        }
    }
}
