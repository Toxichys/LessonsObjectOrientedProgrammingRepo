using System;

namespace MyHomework_Lesson_7
{
    class ACoder : ICoder
    {
        public string Decode(string str)
        {
            return EncodeDecode(str, -1);
        }

        public string Encode(string str)
        {
            return EncodeDecode(str, 1);
        }
        private string EncodeDecode(string str, int move)
        {
            char[] arr_ru = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] arr_RU = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я' };
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int indexChar = Array.IndexOf(arr_ru, charArray[i]);
                if (indexChar != -1)
                {
                    indexChar = indexChar + move;
                    if (indexChar == arr_ru.Length)
                        charArray[i] = arr_ru[0];
                    else if (indexChar == -1)
                        charArray[i] = arr_ru[arr_ru.Length - 1];
                    else
                        charArray[i] = arr_ru[indexChar];
                }
                indexChar = Array.IndexOf(arr_RU, charArray[i]);
                if (indexChar != -1)
                {
                    indexChar = indexChar + move;
                    if (indexChar == arr_RU.Length)
                        charArray[i] = arr_RU[0];
                    else if (indexChar == -1)
                        charArray[i] = arr_RU[arr_RU.Length - 1];
                    else
                        charArray[i] = arr_RU[indexChar];
                }
            }
            return new string(charArray);
        }
    }
}
