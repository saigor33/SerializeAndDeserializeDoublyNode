using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace createSerialize_DoublyNode
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        string path = @"C:\1.json";
        
        private void btn_addItems_Click(object sender, EventArgs e)
        {
            ListRandom newList = new ListRandom();
            for (int i = 0; i < 5; i++)
            {
                newList.addElementBack("Item_" + i);
            }

            tbx_Orig_listNode.Text = test_doublyNode(newList);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                newList.Serialize(stream);
            }
            using (StreamReader stream = new StreamReader(path, Encoding.Default))
            {
                tbx_serializeList.Text = stream.ReadToEnd();
            }


        }

        //метод проверки связей. Вывод в формате Item{<Значение Data>, 
        //<Значение Data след эл-та>, <Значение Data предыдущего эл-та>
        private string test_doublyNode(ListRandom list)
        {
            string testListValue = "";
            ListNode currentItem = list.Head;
           // MessageBox.Show(list.Count.ToString());
            for (int i = 0; i < list.Count; i++)
            {
                testListValue += "Item {Data: <" + currentItem.Data.ToString() + ">";

                if (currentItem.Previous == null)
                {
                    testListValue += "Previous(Data):<null> ";
                }
                else
                {
                    testListValue += "Previous(Data):<" + currentItem.Previous.Data + "> ";
                }

                if (currentItem.Next == null)
                {
                    testListValue += "Next(Data):<null> ";
                }
                else
                {
                    testListValue += "Next(Data):<" + currentItem.Next.Data + "> ";
                }

                if (currentItem.Random == null)
                {
                    testListValue += "Random(Data):<null> ";
                }
                else
                {
                    testListValue += "Random(Data):<" + currentItem.Random.Data + ">";
                }
                
                
                testListValue += "}\r\n";
                currentItem = currentItem.Next;
            }
            return testListValue;
        }


        private void btn_deserializeList_Click(object sender, EventArgs e)
        {
            ListRandom getList = new ListRandom();

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                byte[] arrStream = new byte[stream.Length];
                 stream.Read(arrStream, 0, arrStream.Length);
                 string str = "";
                 for (int i = 0; i < arrStream.Length; i++)
                 {
                     str += arrStream[i];
                 }
                 tbx_textFile.Text = str;
            }
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                getList.Deserialize(stream);
            }

            tbx_new_listNode.Text = test_doublyNode(getList);
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }
    }
}
