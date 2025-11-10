using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TikhomirovaKA.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {     
            int count = array.Count(a => a.Length > 6);
            string[] result = new string[count];
            int i = 0;       
            foreach (string word in array)
            {   
                if (word.Length > 6)
                {                       
                    result[i] = word;
                    i++;
                }
            }
            return result;
        }
    }
}
