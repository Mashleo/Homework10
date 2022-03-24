using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MyList : IList<MyItem>
    {
       
        
        
        public MyItem[] storage = new MyItem[20];


        int counter; //сколько уже есть в масииве
        public MyList()
        {
            counter = 0;
        }

        public MyItem this[int index] //индексатор для перебора кoлекции по индексу
        {
            get
            {
                return storage[index];
            }
            set
            {
                storage[index] = value;
            }
        }

        public int Count  //Получает число элементов, содержащихся в коллекции
        {
            get
            {
                return counter;
            }
        }

        public bool IsReadOnly { get { return false; } } 

        public void Add(MyItem item) //добаляем обьект
        {
            if (counter < storage.Length) //провекра не закончилось ли у нас место в контейнере, если закончилось то ничего не произойдет
            {
                storage[counter] = item;
                counter++;

            }
            
        }

        public void Clear() //очищает элементы колекции
        {
            for (int i = 0; i < counter; i++)
            {
                storage[i] = null;

            }
            counter = 0; 
        }
        public int IndexOf(MyItem item) // проверка по каому индексу находиться первый данный элемент
        {
            for (int i = 0; i < counter; i++) //проверем через фор есть ли такой элемент, если есть возвращаем его индекс, если нет, то возыравщем -1
            {
                if (storage[i] == item)
                {
                    return i;
                }

            }
            return -1; 

        }

        public bool Contains(MyItem item) //проверяет наличие данного элемента
        {
            return IndexOf(item) != -1; //вызвали поиск по индексу. и елси индекс какойто есть то значит вернет тру
        }

        public void CopyTo(MyItem[] array, int arrayIndex) //Копирует элементы коллекции в массив Array, начиная с указанного индекса массива Array
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(storage[i], arrayIndex);
            }
        }





        public void Insert(int index, MyItem item) //вставляеи по индексу элемнт
        {
            if ((counter + 1 <= storage.Length) && (index >= 0) && (index < counter))//проверка не выходим ли мы за пределы масиива  И индекс имеет смысл И проверем что мы именно вставляем внутрь а не добавляем с конца
            {
                counter++;
                for (int i = counter - 1; i > index; i--)
                {
                    storage[i] = storage[i - 1];
                }
                storage[index] = item;

            }
        }


        public void RemoveAt(int index) //удаялет по индексу если нет такого элемента то просто ничего не делает
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    storage[i] = storage[i + 1];
                    

                }
                storage[Count-1] = null;
                counter--;


            }
        }
        public bool Remove(MyItem item) //удаляем обьект по значению
        {
            
            RemoveAt(IndexOf(item));
            return true;  //Инлекс ОФ возвращает ИНТ с позицией. а ремув удаляет по позиции
        }
        public IEnumerator<MyItem> GetEnumerator() //это не ревлизовывваем
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator() //и эту шляпу не реализовываем
        {
            throw new NotImplementedException();
        }
    }
}
