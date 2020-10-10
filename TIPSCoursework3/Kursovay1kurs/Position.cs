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

        
        public void CheckAccessToTransition(ref bool[] AccessArray)
        {
            Func<bool>[] Transitions = new Func<bool>[32];

            Transitions[0] = T0;
            Transitions[1] = T1;
            Transitions[2] = T2;
            Transitions[3] = T3;
            Transitions[4] = T4;
            Transitions[5] = T5;
            Transitions[6] = T6;
            Transitions[7] = T7;
            Transitions[8] = T8;
            Transitions[9] = T9;

            Transitions[10] = T10;
            Transitions[11] = T11;
            Transitions[12] = T12;
            Transitions[13] = T13;
            Transitions[14] = T14;
            Transitions[15] = T15;
            Transitions[16] = T16;
            Transitions[17] = T17;
            Transitions[18] = T18;
            Transitions[19] = T19;

            Transitions[20] = T20;
            Transitions[21] = T21;
            Transitions[22] = T22;
            Transitions[23] = T23;
            Transitions[24] = T24;
            Transitions[25] = T25;
            Transitions[26] = T26;
            Transitions[27] = T27;
            Transitions[28] = T28;
            Transitions[29] = T29;

            Transitions[30] = T30;
            Transitions[31] = T31;

            for (int i = 0; i < 32; i++)
            {
                Position tmp = this.Clone();

                if (tmp.Transitions[i]())
                {
                    AccessArray[0] = true;
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
