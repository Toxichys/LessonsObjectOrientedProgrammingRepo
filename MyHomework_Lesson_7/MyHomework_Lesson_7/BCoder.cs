using System;

namespace MyHomework_Lesson_7
{
    class BCoder : ICoder
    {
        public string Decode(string str)
        {
            return EncodeDecode(str);
        }

        public string Encode(string str)
        {
            return EncodeDecode(str);
        }
        private string EncodeDecode(string str)
        {
            char[] arr_ru = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] arr_RU = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я' };
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int indexChar = Array.IndexOf(arr_ru, charArray[i]);
                if (indexChar != -1)
                    charArray[i] = arr_ru[arr_ru.Length - 1 - indexChar];
                indexChar = Array.IndexOf(arr_RU, charArray[i]);
                if (indexChar != -1)
                    charArray[i] = arr_RU[arr_RU.Length - 1 - indexChar];
            }
            return new string(charArray);
        }
    }
}
