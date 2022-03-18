using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMW_Generics
{
    public class HerosTable<T>
    {
        public T[] Legend { get; set; }

        public HerosTable(T[] arrayNum)
        {
            Legend = arrayNum;
        }

        public HerosTable(int choosenSize)
        {
            Legend = new T[choosenSize];
        }

        public void Set(T index, int knight)
        {
            Legend[knight] = index;
        }

        public void Delete(int index1)
        {
            Legend[index1] = default;
        }

        public int KnightsCounter(int counter)
        {
            counter = 0;
            foreach (T fighter in Legend)
            {
                if (fighter != null)
                    counter++;
            }
            return counter;
        }
        //Finding How Many Active Knights 
        public int HowManyActiveKnights()
        {
            int activeKnights = 0;
            for (int i = 0; i < Legend.Length; i++)
            {
                if(Legend[i] != null)
                {
                    activeKnights++;
                }
            }
            return activeKnights;
        }

        //Indexer
        public T this[int indexer]
        {
            get
            {
                if (HowManyActiveKnights() == 0)
                    return default;
                else if (indexer <= Legend.Length - 1)
                {
                    if (Legend[indexer] == null)
                    {
                        for (int i = indexer - 1; i >= 0; i--)
                        {
                            if (Legend[i] != null)
                                return Legend[i];
                        }
                        return default;
                    }
                    else
                        return Legend[indexer];
                }
                return Legend[indexer];
            }
        }
    }
}
