using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _1._1.DoubleList;

namespace _1._1
{
    class WILinkedList : ILinkedList
    {
        private Node head;
        private Node tail;

        public int Length { get; set;}
       
        public void AddNode(int value)
        {
            Node newNode = new Node { Value = 2 };
            newNode.Value = value;
            if (head == null)
                head = newNode;
            else
            {
                newNode.PrevNode = tail;
                tail.NextNode = newNode;
            }
            tail = newNode;
            Length++;
        }
        public void AddNodeAfter(Node node, int value)
        {
            Node current = head.NextNode;//переходим на адрес первого элемента списка
            while (current != tail && current != node)//если адрес текущего элемента не равен последнему
            {
                current = current.NextNode;//переходим на адресс сдедующего элемента
            }
            if (current != tail)//если адрес текущего элемента не равен последнему
            {
                current.NextNode = new()//создаем новый элемент
                {
                    Value = value,
                    PrevNode = current,//связываем созданный элемент с предыдущим и следующим
                    NextNode = current.NextNode
                };
            }
            else
            {
                throw new ArgumentException("Такого Узла нет в списке.", nameof(node));
            }
        }
        public Node FindNode(int searchValue)
        {
            Node current = head.NextNode;
            while (current != tail && current.Value != searchValue)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                return current;
            }
            else
            {
                return null;
            }
        }
        public int GetCount()
        {
            int count = 0;
            Node current = head.NextNode;//переходим на адрес первого элемента списка
            while (current != tail)//если принятое значение не равно последнему делаем шаг вперед
            {
                current = current.NextNode;
                count++;
            }
            return count;
        }
        public void RemoveNode(int index)
        {
            int count = 0;
            Node current = head.NextNode;//переходим на адрес первого элемента списка
            while (current != tail && count < index) // поиск удаляемого узла
            {
                current = current.NextNode;
                count++;
            }
            if (count == index)//если нашли удаляем
            {
                RemoveNode(current);
            }
            else
            {
                throw new ArgumentException("Узла с таким индексом нет в списке.", nameof(index));
               
            }
        }
        public void RemoveNode(Node node)
        {
            Node next = node.NextNode;
            Node prev = node.PrevNode;

            next.PrevNode = prev;
            prev.NextNode = next;
            node.NextNode = null;
            node.PrevNode = null;
        }
        public void PrintList()
        {
            string list = "";
            Node current = head;
            while (current != null)
            {
                list += $"{current.Value}";
                current = current.NextNode;
            }
            Console.WriteLine(list);
        }
    }
}