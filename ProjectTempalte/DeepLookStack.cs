using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProjectTempalte
{
    // TODO:
    // Это должен быть класс стека, у которого можно просмотреть не только верхний элемент, но и некоторые под ним.
    // Сначала реализуйте класс Stack, если вы этого еще не сделали. Используйте наследование.
    // Полностью копировать код или писать код, реализация которого уже есть в класс Stack, запрещено.
    class DeepLookStack<T> : Stack<T>
    {
        
        public DeepLookStack(int capacity = 20)
        {
            values = new T[capacity];
            size = 0;
        }

        public T Peek(int shift)
        {
            if (size > 0 && size > shift)
            {
                return values[size - shift - 1];
            }
            else
                throw new InvalidOperationException("стэк пуст"); // Заглушка
        }
    }
}
