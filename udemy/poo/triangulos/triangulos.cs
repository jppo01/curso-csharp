        class Triangulos {
            public double A=0;
            public double B=0;
            public double C=0; 

            //metodos
            public double Area()
            {
                double p = (A + B + C)/2.0;
                double a = Math.Sqrt(p*(p-A)*(p-B)*(p-C));

                return a;
            }
    }