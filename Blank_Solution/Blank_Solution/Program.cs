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


            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)


            {

                //5. Конвертирование бинарных кодов в байты фотографии.

                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);

                imageBytes[i] = binary;

            }

            textReader.Dispose();



            //7. Вывод байтов фотографии в файл C:\Temp\C#\ДЗ 2\image.png

            File.WriteAllBytes(@"C:\Temp\C#\HW_2\image.png", imageBytes);














            //3. Cоздание массива ImageBytes, который будет хранить данные типа bite (после конвертации).















            //6. Освобождение ресурсов, использованных объектом TextReader





        }
    }
}
