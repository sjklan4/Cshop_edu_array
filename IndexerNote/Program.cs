using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
namespace IndexerAndIterator
{
    class IndexerAndInteratorDemo
    {
        class Car
        {
            private string[] names;  //필드
            
            //생성자
            public Car(int length)
            {
                names = new string[length];
            }

            // 인덱서
            public string this[int index]
            {
                get { return names[index]; }
                set { names[index] = value; }
            }
            // 반복기(이터레이터)
            public IEnumerator GetEnumerator() // 공식 : foreach문을 사용하기 위한.
            {
                for (int i = 0; i < names.Length; i++)
                {
                    yield return names[i];
                }
            }
        }

        class IndexrAndIterator 
        { 
            static void Main()
            {
                Car cars = new Car(3); //3개의 배열로 지정
                cars[0] = "CLA";
                cars[1] = "CLS";
                cars[2] = "AMG";

                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }

}
