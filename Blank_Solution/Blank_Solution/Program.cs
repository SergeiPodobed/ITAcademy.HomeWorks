using System;
using System.IO;

namespace HW._02
{
    class Program
    {

        static void Main(string[] args)
        {

            //1. Обращаемся к файлу по следующему пути: C:\Temp\C#\HW_2\image.txt

            System.IO.StreamReader textReader = new StreamReader(@"C:\Temp\C#\HW_2\image.txt", true);

            //2. Считываем текст из файла до конца

            string textReaderResult = textReader.ReadToEnd();

            //3. Разделяем на символы прочитанный текст.

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            //4. Создание массива бинарных чисел.


            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            //5. Запускаем цикл, преобразующий бинарные коды в фото


            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)


            {

                //6. Конвертируем бинарные коды в байты фотографии.

                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);

                imageBytes[i] = binary;

            }

            //7. Освобождение ресурсов, использованных объектом TextReader

            textReader.Dispose();



            //8. Вывод байтов фотографии в файл C:\Temp\C#\ДЗ 2\image.png

            File.WriteAllBytes(@"C:\Temp\C#\HW_2\image.png", imageBytes);













        }
    }
}
