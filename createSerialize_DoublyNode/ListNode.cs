using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace createSerialize_DoublyNode
{
    class ListNode
    {
        public ListNode Previous;
        public ListNode Next;
        public ListNode Random; // произвольный элемент внутри списка
        public string Data;

        public ListNode(string data)
        {
            Data = data;
        }
    }

    class ListRandom
    {
        public ListNode Head;
        public ListNode Tail;
        public int Count;

        /*public int Count
        {
            get { return count; }
            set { count = value; }
        }*/

        //добавление нового элемента в конец списка
        public void addElementBack(string data)
        {
            ListNode newItemListNode = new ListNode(data);
            if (Head == null)
            {
                Head = Tail = newItemListNode;
                Head.Random = Tail.Random = setRandomItem(new Random().Next(0, Count));
            }
            else
            {
                Tail.Next = newItemListNode;
                newItemListNode.Previous = Tail;
                Tail = newItemListNode;
                Tail.Random = setRandomItem(new Random().Next(0, Count));
            }
            Count++;
        }

        //установка связи со случайным элементом списка
        private ListNode setRandomItem(int rndIndexItem)
        {
            ListNode item = null;
            ListNode currentItem = Head;
            for (int i = 0; i < Count; i++)
            {
                if (i == rndIndexItem)
                {
                    item = currentItem;
                    //break;
                }
                currentItem = currentItem.Next;
            }
            return item;
        }

        //перебор всех полей у экземпляров и запись в файл
        public void Serialize(Stream s)
        {
            string dataSerialize = "";
            dataSerialize += "{ \r\n";
            dataSerialize += "\"ListRandom\":[ \r\n";
            int indexItem = 0;
            ListNode currentNode = Head;
            while (indexItem < Count)
            {
                dataSerialize += "{";
                dataSerialize += "\"Data\":\"" + currentNode.Data + "\",";

                int indexItemNext = indexItem + 1 < Count ? indexItem : -1; //проверяем на выход за пределы массива
                dataSerialize += "\"indexItemNext\":" + indexItemNext + ",";

                dataSerialize += "\"indexItemPrevious\":" + (indexItem - 1) + ",";

                { //поиск случайно элемента Random
                    int indexItemRandom = 0;
                    ListNode foreachItems = Head;
                    while (indexItemRandom < Count)
                    {
                        if (currentNode.Random != null)
                        {
                            if (currentNode.Random.Equals(foreachItems))
                            {
                                dataSerialize += "\"indexItemRandom\":" + indexItemRandom + "";
                            }
                        }
                        else
                        {
                            dataSerialize += "\"indexItemRandom\":-1";
                            break;
                        }
                        indexItemRandom++;
                        foreachItems = foreachItems.Next;
                    }
                }

                dataSerialize += "}";
                if (indexItem != Count - 1)
                {
                    dataSerialize += ",\r\n";
                }
                else
                {
                    dataSerialize += "\r\n";
                }

                currentNode = currentNode.Next;
                indexItem++;
            }

            dataSerialize += "] \r\n";
            dataSerialize += "}\r\n";



            byte[] arrStream = Encoding.Default.GetBytes(dataSerialize);
            s.Write(arrStream, 0, arrStream.Length);
        }

        //считывание данных из файла и востоновление двухсвязного списка
        public void Deserialize(Stream s)
        {
            byte[] arrStream = new byte[s.Length];
            s.Read(arrStream, 0, arrStream.Length);

            string textFile = Encoding.Default.GetString(arrStream);
            Dictionary<int, Dictionary<string, string>> valueFields = GetFieldsDictionary(textFile);

            int numItem = 0;
            while (numItem < valueFields.Count)
            {
                RecorvyList(valueFields[numItem]["Data"], Int32.Parse(valueFields[numItem]["indexItemRandom"]));
                numItem++;
            }
        }

        //Парсинг файла. Преобразование текста в словарь структуры "номер элемента", "название поля", "значение поля"
        private Dictionary<int, Dictionary<string, string>> GetFieldsDictionary(string textFile)
        {
            Dictionary<int, Dictionary<string, string>> valueFields = new Dictionary<int, Dictionary<string, string>>();

            int startPozList = textFile.IndexOf("[") + 1;
            int finishPozList = textFile.LastIndexOf("]");
            string textListNode = textFile.Substring(startPozList, finishPozList - startPozList);

            string[] textLineItemsListNode = textListNode.Split('\n');

            //i=1 т.к. первая строка осталась пустой после получения подстроки между  [startPozList] и [finishPozList]
            //text.Length-1 последняя строка аналогично
            for (int i = 1; i < textLineItemsListNode.Length - 1; i++)
            {
                int startPozItem = textLineItemsListNode[i].IndexOf("{") + 1;
                int finishPozItem = textLineItemsListNode[i].LastIndexOf("}");
                string textItemListNode = textLineItemsListNode[i].Substring(startPozItem, finishPozItem - startPozItem);

                string[] textFieldsItemListNode = textItemListNode.Split(',');
                Dictionary<string, string> valueDictionary = new Dictionary<string, string>();
                for (int j = 0; j < textFieldsItemListNode.Length; j++)
                {
                    string[] field = textFieldsItemListNode[j].Split(':');
                    valueDictionary.Add(field[0].Trim('"'), field[1].Trim('"'));
                }
                valueFields.Add(i - 1, valueDictionary); //i-1 сделаем отсчёт с 0
            }

            return valueFields;
        }

        //востоновление двухсвязного списка
        private void RecorvyList(string data, int indexRandomItem)
        {
            ListNode newItemListNode = new ListNode(data);
            if (Head == null)
            {
                Head = Tail = newItemListNode;
                Head.Random = Tail.Random = setRandomItem(indexRandomItem);
            }
            else
            {
                Tail.Next = newItemListNode;
                newItemListNode.Previous = Tail;
                Tail = newItemListNode;
                Tail.Random = setRandomItem(indexRandomItem);
            }
            Count++;
        }
    }

}
