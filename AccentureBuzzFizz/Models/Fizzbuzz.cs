namespace AccentureFizzBuzz.Models
{
    public class Fizzbuzz
    {
        public List<string> fizzbuzzResolved = new();

        /// <summary>
        /// Default Constructor intializing the list to return
        /// </summary>
        public Fizzbuzz()
        {
            fizzbuzzResolved = new();
        }


        /// <summary>
        /// The Classic method returns the solution to the classic FizzBuzz problem as described in "Classic FizzBuzz"
        /// Method will return a list containing the classic Fizz buzz algorithm
        /// </summary>
        public void RunClassic()
        {
            for (var i = 1; i < 101; i++)
            {
                if (i % 15 == 0) fizzbuzzResolved.Add("FizzBuzz");
                else if (i % 3 == 0) fizzbuzzResolved.Add("Fizz");
                else if (i % 5 == 0) fizzbuzzResolved.Add("Buzz");
                else fizzbuzzResolved.Add(i.ToString());
            }

        }

        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// Its range is from -12(negative 12) through 145.
        /// For multiples of 3, prints "Fizz"
        /// For multiples of 7, prints "Buzz"
        /// For multiples of 38, prints "Bazz"
        /// Print the appropriate combination of tokens for any number that matches more than one of those rules
        /// Example 
        /// </summary>
        public void RunAdvanced()
        {
            for (var i = -12; i < 146; i++)
            {
                var lineToAdd = "";
                if (i % 3 == 0) lineToAdd += "Fizz";
                if (i % 7 == 0) lineToAdd += "Buzz";
                if (i % 38 == 0) lineToAdd += "Bazz";
                else if (lineToAdd.Equals(String.Empty)) lineToAdd += i.ToString();

                fizzbuzzResolved.Add(lineToAdd);
            }

        }

        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// Its range is from -12(negative 12) through 145.
        /// For multiples of 3, prints "Fizz"
        /// For multiples of 7, prints "Buzz"
        /// For multiples of 38, prints "Bazz"
        /// Print the appropriate combination of tokens for any number that matches more than one of those rules
        /// Example 
        /// </summary>
        public void CustomByRange(IDictionary<string,int> list, int start, int end)
        {


            for (var i = start; i < end; i++)
            {
                var lineToAdd = "";

                foreach (var item in list)
                {
                    if (i % item.Value == 0)
                    {
                        lineToAdd += item.Key;
                    }
                }
                foreach (var item in list)
                {
                    if (lineToAdd.Equals(String.Empty))
                    {
                        lineToAdd += i.ToString();
                    }
                }

                 fizzbuzzResolved.Add(lineToAdd);
            }

        }

        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// Its range is from -12(negative 12) through 145.
        /// For multiples of 3, prints "Fizz"
        /// For multiples of 7, prints "Buzz"
        /// For multiples of 38, prints "Bazz"
        /// Print the appropriate combination of tokens for any number that matches more than one of those rules
        /// Example 
        /// </summary>
        public void CustomSet(List<int> list, IDictionary<string, int> pairs )
        {

            foreach (var num in list)
            {
                var lineToAdd = "";

                foreach (var pair in pairs)
                {
                    if (num % pair.Value == 0)
                    {
                        lineToAdd += pair.Key;
                    }
                }
                foreach (var item in list)
                {
                    if (lineToAdd.Equals(String.Empty))
                    {
                        lineToAdd += num.ToString();
                    }
                }
             fizzbuzzResolved.Add(lineToAdd);

            }

        }

        /// <summary>
        /// Method returning current list value
        /// </summary>
        /// <returns>this.fizzbuzzResolved</returns>
        public List<string> GetList()
        {
            return fizzbuzzResolved;
        }


    }
}
