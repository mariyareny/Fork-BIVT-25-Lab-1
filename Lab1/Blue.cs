namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0) || (a == 0 && b == 0))
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = (d != Math.Floor(d));
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);

            if (absD >= absF && absD >= absG)
            {
                answer = d;
            }
            else if (absF >= absD && absF >= absG)
            {
                answer = f;
            }
            else
            {
                answer = g;
            }
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) { answer = 0; }
            else if (x > 0) { answer = 1; }
            else { answer = x + 1; }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double circleDiameter = 2 * Math.Sqrt(circleS / Math.PI);
            double squareSide = Math.Sqrt(squareS);

            answer = circleDiameter <= squareSide;
            // end

            return answer;
        }
        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int A = a / 2;
            int B = b / 2;
            int C = c / 2;

            int total = A + B + C;

            if (total % 3 == 0)
            {
                int k = total / 3;
                if (k >= 1 && k <= a && k <= b && k <= c)
                    answer = true;
            }

            if (!answer)
            {
                total = A + B + C + 1;
                if (total % 3 == 0)
                {
                    int k = total / 3;
                    if (k >= 1 && k <= a && k <= b && k <= c && k <= C + 1)
                        answer = true;
                }
            }
            // end

            return answer;
        }
    }
}