// See https://aka.ms/new-console-template for more information


   MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

           myDictionary.Add("Engin", 123);
           myDictionary.Add("Veli", 231);
           myDictionary.Add("Çetin", 321);


        
        class MyDictionary<X, Y>
        {
            X[] Keys;
            Y[] Values;

            public MyDictionary()
            {
                Keys = new X[0];
                Values = new Y[0];
            }

            public void Add(X key, Y value)
            {
                X[] tempKeys = Keys;
                Y[] tempValues = Values;
                Keys = new X[Keys.Length + 1];
                Values = new Y[Values.Length + 1];

                for (int i = 0; i < tempKeys.Length; i++)
                {
                    Keys[i] = tempKeys[i];
                   Values[i] = tempValues[i];
                }

                // Yeni anahtar ve değeri ekle
               Keys[Keys.Length - 1] = key;
                Values[Values.Length - 1] = value;

                Console.WriteLine(key + " " + value);






    } 
        
        