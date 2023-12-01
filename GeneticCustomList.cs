using System.Drawing;

namespace Pain
{
    public class GeneticCustomList<T>
    {
        private List<T> elements;
        private int count;
        private int capacity=0; 

        
        public GeneticCustomList()
        {
            elements = new List<T>();
            count = 0;
           
        }
        public GeneticCustomList( int _capacity)
        {
            elements = new List<T>();
            count = 0;
            capacity = _capacity;
        }

        public int Count 
        {
            get { return count; }
        }
        public int Capacity
        {
            get { return capacity; }
        } 
       
        public void Add(T item)
        {
            elements.Add(item);

            if (elements.Count >= capacity)
            {
                if (capacity == 0)
                {
                    capacity = 4;
                }
                else
                {
                    capacity *= 2;
                }
            }
            elements[count] = item;
            count++;
        }
        public T Find (Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
            {
                if (match(elements[i]))
                {
                    return elements[i];
                }
            }
            return default(T); 
         
        }
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> resultList = new List<T>();
            for (int i = 0; i < count; i++)
            {
                if (match(elements[i]))
                {
                    resultList.Add(elements[i]);
                }
            }
            return resultList;
        }
        public bool Contains (T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(elements[i], item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
            {
                if (match(elements[i]))
                {
                    return true;
                }
            }
            return false;
        
    }
        public bool Remove(T item)
        {
            int indexToRemove = -1;

            
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(elements[i], item))
                {
                    indexToRemove = i;
                    break;
                }
            }

            
            if (indexToRemove == -1)
                return false;

            
            for (int i = indexToRemove; i < count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            
            count--;

            
            return true;
        }
    }
}
            
       