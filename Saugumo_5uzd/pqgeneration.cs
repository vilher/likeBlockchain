
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Saugumo_5uzd
{
    class pqgeneration
    {
        private BigInteger p;
        private BigInteger q;
        private BigInteger e;

        Random rGen = new Random();
        private bool pb, qb;
        private BigInteger mightBePrime(int N)
        {

            BigInteger a = rGen.Next(2, N - 1);
            return a;
        }
        private bool isPirminis(BigInteger n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) k++;
            }
            if (k == 2) return true;
            else { return false; }

        }
        private void checking(BigInteger r)
        {
            if (pb == false)
            {
                pb = true;
                this.p = r;
            }
            else if (qb == false)
            {
                qb = true;
                this.q = r;
            }
        }

        public pqgeneration()
        {
            BigInteger r = mightBePrime(100);
            BigInteger rb = r;
            pb = false;
            qb = false;
            while (pb == false || qb == false)
            {
                if (isPirminis(r))
                {
                    checking(r);

                }
                else if (isPirminis(rb))
                {
                    checking(rb);
                }
                rb--;
                r++;

            }

        }
        public BigInteger getP()
        {
            return this.p;
        }
        public BigInteger getQ()
        {
            return this.q;
        }
        public BigInteger getN()
        {
            return p * q;
        }
        public BigInteger getE()
        {
            return e;
        }
        public BigInteger getfn()
        {
            return (p - 1) * (q - 1);
        }
        private bool iseuklidoAlgorithm(BigInteger a, BigInteger b)
        {

            while (a > 0 && b > 0)
            {
                if (a > b) a = a % b;
                else { b = b % a; }

            }
            if (a + b == 1) return true;
            else { return false; }
        }

        public void findE()
        {

            pb = true;
            BigInteger i = 0;
            while (pb)
            {
                i = rGen.Next(1, (int)getfn());
                if (iseuklidoAlgorithm(i, getfn())) pb = false;

            }
            e = i;
        }
        public BigInteger privatusRaktas()
        {

            pb = true;
            BigInteger k = 1;
            BigInteger temp = (p - 1) * (q - 1);
            while (pb)
            {
                k++;
                if (((k * getE()) % temp) == 1)
                {
                    pb = false;
                }
            }
            Console.WriteLine("e= " + getE() + "d= " + k + " p= " + p + " q= " + q + "fn= " + temp);
            return k;
        }
        public BigInteger encryptionKeyFind(int n)
        {
            pb = true;

            for (int i = 0; i <= n; i++)
            {
                if (isPirminis(i))
                {
                    for (int j = 0; j <= n / 2; j++)
                    {
                        if (isPirminis(j))
                        {
                            if (i * j == n)
                            {
                                this.p = i;
                                this.q = j;

                                j = (int)n;
                                i = (int)n;

                            }


                        }
                    }

                }
            }
            return privatusRaktas();
        }
        public int[] getKodas(string text)
        {
            int[] temp = new int[text.Length];
            char t;
            for (int i = 0; i < text.Length; i++)
            {
                t = text[i];
                temp[i] = (int)t;
                Console.WriteLine(temp[i]);
            }

            return temp;
        }
    }
}
