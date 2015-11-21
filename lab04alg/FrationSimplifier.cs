using System;

namespace lab04alg {
    public class FrationSimplifier {
        public FrationSimplifier(int num, int denom) {
            Numerator = num;
            Denominator = denom;
            Normalize();
        }

        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        private void Normalize() {
            Reduce(GCD(Numerator, Denominator));
            Reduce(Math.Sign(Denominator));
            Numerator %= Denominator;
        }

        private int GCD(int a, int b) {
            while (b != 0) {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        private void Reduce(int x) {
            Numerator /= x;
            Denominator /= x;
        }

        override public string ToString() {
            return $"{Numerator}/{Denominator}";
        }
    }
}