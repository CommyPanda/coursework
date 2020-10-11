using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovay1kurs
{
    class Position
    {
        private int x0, x1, x2, x3, x4, x5, x6, x7, S0, S1, S2, S3, y0, y1;

        //private bool[,] accessTree = new bool[31, 31];  

        public Position()
        {
            x0 = 100; x1 = 100; x2 = 100; x3 = 100; x4 = 100; x5 = 100; x6 = 100; x7 = 100;
            S0 = 1; S1 = 0; S2 = 0; S3 = 0;
            y0 = 0; y1 = 0;
        }
        public Position(Position prevPosition)
        {
            x0 = prevPosition.x0; x1 = prevPosition.x1; x2 = prevPosition.x2; x3 = prevPosition.x3; x4 = prevPosition.x4; x5 = prevPosition.x5; x6 = prevPosition.x6; x7 = prevPosition.x7;
            S0 = prevPosition.S0; S1 = prevPosition.S1; S2 = prevPosition.S2; S3 = prevPosition.S3;
            y0 = prevPosition.y0; y1 = prevPosition.y1;
        }

        public delegate bool ArrayOfTran();
        public void CheckAccessToTransition(ref bool[] AccessArray)
        {
            Position tmp = new Position(this);
            ArrayOfTran[] Transitions = new ArrayOfTran[]
            {
                tmp.T0, tmp.T1, tmp.T2, tmp.T3, tmp.T4, tmp.T5, tmp.T6, tmp.T7, tmp.T8, tmp.T9,
                tmp.T10, tmp.T11, tmp.T12, tmp.T13, tmp.T14, tmp.T15, tmp.T16, tmp.T17, tmp.T18, tmp.T19,
                tmp.T20, tmp.T21, tmp.T22, tmp.T23, tmp.T24, tmp.T25, tmp.T26, tmp.T27, tmp.T28, tmp.T29,
                tmp.T30, tmp.T31
            };

            

            for (int i = 0; i < 32; i++)
            {
                if (Transitions[i]())
                {
                    AccessArray[i] = true;
                    tmp = new Position(this);
                }
            }



        }
        public bool T0()
        {
            if (S0 - 1 >= 0 && x0 - 1 >= 0) 
            {
                x0--;
                S0--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T1()
        {
            if (S0 - 1 >= 0 && x1 - 1 >= 0) 
            {
                x1--;
                S0--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T2()
        {
            if (S0 - 1 >= 0 && x2 - 1 >= 0) 
            {
                x2--;
                S0--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T3()
        {
            if (S0 - 1 >= 0 && x3 - 1 >= 0) 
            {
                x3--;
                S0--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T4()
        {
            if (S0 - 1 >= 0 && x4 - 1 >= 0)
            {
                x4--;
                S0--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T5()
        {
            if (S0 - 1 >= 0 && x5 - 1 >= 0)
            {
                x5--;
                S0--;
                S1++;
                y1++;
                return true;
            }
            else return false;
        }
        public bool T6()
        {
            if (S0 - 1 >= 0 && x6 - 1 >= 0)
            {
                x6--;
                S0--;
                S2++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T7()
        {
            if (S0 - 1 >= 0 && x7 - 1 >= 0)
            {
                x7--;
                S0--;
                S3++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T8()
        {
            if (S1 - 1 >= 0 && x0 - 1 >= 0)
            {
                x0--;
                S1--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T9()
        {
            if (S1 - 1 >= 0 && x1 - 1 >= 0)
            {
                x1--;
                S1--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T10()
        {
            if (S1 - 1 >= 0 && x2 - 1 >= 0)
            {
                x2--;
                S1--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T11()
        {
            if (S1 - 1 >= 0 && x3 - 1 >= 0)
            {
                x3--;
                S1--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T12()
        {
            if (S1 - 1 >= 0 && x4 - 1 >= 0)
            {
                x4--;
                S1--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T13()
        {
            if (S1 - 1 >= 0 && x5 - 1 >= 0)
            {
                x5--;
                S1--;
                S1++;
                y1++;
                return true;
            }
            else return false;
        }
        public bool T14()
        {
            if (S1 - 1 >= 0 && x6 - 1 >= 0)
            {
                x6--;
                S1--;
                S2++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T15()
        {
            if (S1 - 1 >= 0 && x7 - 1 >= 0)
            {
                x7--;
                S1--;
                S3++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T16()
        {
            if (S2 - 1 >= 0 && x0 - 1 >= 0)
            {
                x0--;
                S2--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T17()
        {
            if (S2 - 1 >= 0 && x1 - 1 >= 0)
            {
                x1--;
                S2--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T18()
        {
            if (S2 - 1 >= 0 && x2 - 1 >= 0)
            {
                x2--;
                S2--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T19()
        {
            if (S2 - 1 >= 0 && x3 - 1 >= 0)
            {
                x3--;
                S2--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T20()
        {
            if (S2 - 1 >= 0 && x4 - 1 >= 0)
            {
                x4--;
                S2--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T21()
        {
            if (S2 - 1 >= 0 && x5 - 1 >= 0)
            {
                x5--;
                S2--;
                S1++;
                y1++;
                return true;
            }
            else return false;
        }
        public bool T22()
        {
            if (S2 - 1 >= 0 && x6 - 1 >= 0)
            {
                x6--;
                S2--;
                S2++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T23()
        {
            if (S2 - 1 >= 0 && x7 - 1 >= 0)
            {
                x7--;
                S2--;
                S3++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T24()
        {
            if (S3 - 1 >= 0 && x0 - 1 >= 0)
            {
                x0--;
                S3--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T25()
        {
            if (S3 - 1 >= 0 && x1 - 1 >= 0)
            {
                x1--;
                S3--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T26()
        {
            if (S3 - 1 >= 0 && x2 - 1 >= 0)
            {
                x2--;
                S3--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T27()
        {
            if (S3 - 1 >= 0 && x3 - 1 >= 0)
            {
                x3--;
                S3--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T28()
        {
            if (S3 - 1 >= 0 && x4 - 1 >= 0)
            {
                x4--;
                S3--;
                S0++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T29()
        {
            if (S3 - 1 >= 0 && x5 - 1 >= 0)
            {
                x5--;
                S3--;
                S1++;
                y1++;
                return true;
            }
            else return false;
        }
        public bool T30()
        {
            if (S3 - 1 >= 0 && x6 - 1 >= 0)
            {
                x6--;
                S3--;
                S2++;
                y0++;
                return true;
            }
            else return false;
        }
        public bool T31()
        {
            if (S3 - 1 >= 0 && x7 - 1 >= 0)
            {
                x7--;
                S3--;
                S3++;
                y0++;
                return true;
            }
            else return false;
        }

        public int Getx0()
        {
            return x0;
        }
        public int Getx1()
        {
            return x1;
        }
        public int Getx2()
        {
            return x2;
        }
        public int Getx3()
        {
            return x3;
        }
        public int Getx4()
        {
            return x4;
        }
        public int Getx5()
        {
            return x5;
        }
        public int Getx6()
        {
            return x6;
        }
        public int Getx7()
        {
            return x7;
        }

        public int GetS0()
        {
            return S0;
        }
        public int GetS1()
        {
            return S1;
        }
        public int GetS2()
        {
            return S3;
        }
        public int GetS3()
        {
            return S3;
        }

        public int Gety0()
        {
            return y0;
        }
        public int Gety1()
        {
            return y1;
        }
    }
}
