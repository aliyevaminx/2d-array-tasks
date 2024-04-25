////////////////////////////TASK1

//int[,] array =
//    {
//        {1022, 2148, 5105 },
//        { 321, 634, 638},
//        { 42, 52, 25}
//    };

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}


////////////////////////////TASK2

//int[,] array =
//    {
//        {1022, 2148, 5105 },
//        { 321, 634, 638},
//        { 42, 52, 25}
//    };

//int result = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        result += array[i, j];
//    }
//}
//Console.WriteLine(result);

////////////////////////////TASK3

//int[,] array =
//    {
//        {1022, 2148, 5105 },
//        { 321, 634, 638},
//        { 42, 52, 25}
//    };

//int result = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < 1; j++)
//    {
//        result += array[i, j];
//    }
//}
//Console.WriteLine(result);

////////////////////////////TASK4

//using System;

//int[,] array =
//{
//    {214, -251, 215 },
//    {512, 613, -532 },
//    {-24, 125, -582 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] < 0)
//        {
//            Console.WriteLine(array[i, j]);
//        }
//    }
//}

////////////////////////////TASK5


//int[,] array =
//{
//    {214, -251, 215 },
//    {512, 613, -532 },
//    {-24, 125, -582 },
//    {532, 274, 8932 }
//};

//int maxNumber = array[0, 0];
//int minNumber = array[0, 0];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (maxNumber < array[i, j])
//        {
//            maxNumber = array[i, j];
//        }
//        if (minNumber > array[i, j])
//        {
//            minNumber = array[i, j];
//        }
//    }
//}
//Console.WriteLine($"Max Number: {maxNumber}, Min Number: {minNumber}");

////////////////////////////TASK6

//int[,] array =
//{
//    {214, 0, 215 },
//    {512, 613, -532 },
//    {-24, 125, 0 },
//    {532, 274, -129 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] == 0)
//            array[i, j] = array[i, j];

//        else if (array[i, j] % 2 != 0 && array[i, j] > 0)
//            array[i, j] = 1;

//        else if (array[i, j] % 2 == 0 && array[i, j] > 0)
//            array[i, j] = 2;

//        else if (array[i, j] % 2 != 0 && array[i, j] < 0)
//            array[i, j] = -1;

//        //else if (array[i, j] % 2 == 0 && array[i, j] < 0)
//        //    array[i, j] = -2;

//        else
//        {
//            array[i, j] = -2;
//        }

//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK7

//int[,] array =
//{
//    {214, 0, 215 },
//    {512, 613, -532 },
//    {-24, 125, 0 },
//    {532, 274, 8932 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i == 1)
//        {
//            array[i, j] = 0;
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK8

//int[,] array =
//{
//    {214, 0, 215 },
//    {512, 613, -532 },
//    {-24, 125, 0 },
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j == 2)
//        {
//            array[i, j] = 0;
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK9


//int[,] array =
//{
//    {214, 0, 215 },
//    {512, 613, -532 },
//    {-24, 125, 0 },
//};

//int result = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = i; j < array.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            result += array[i, j];
//        }
//    }
//}
//Console.WriteLine(result);

////////////////////////////TASK10

//int[,] array =
//{
//    {214, 0, 0 },
//    {512, 613, -532 },
//    {-24, 125, 0 },
//};

//int result = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    result += array[i, array.GetLength(0) - 1 - i];
//}

//Console.WriteLine(result);

////////////////////////////TASK11 

//int[,] array =
//{
//    {214, 94, 596, 746, 957 },
//    {512, 613, -532, 752, 623 },
//    {-24, 125, 872, -215, 259 },
//    {32, -96, 122, 378, 23 },
//    {-746, 752, 214, -215, 596 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i > j)
//        {
//            array[i, j] = 0;
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK12

//int[,] array =
//{
//    {214, 0, 596, 746, 957 },
//    {512, 613, -532, 752, 0 },
//    {-24, 125, 872, -215, 259 },
//    {32, -96, 122, 378, 0 },
//    {-746, 752, 214, -215, 596 }
//};


//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i < j)
//        {
//            array[i, j] = 0;
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}


////////////////////////////TASK13

//int[,] arrays1 =
//{
//   {324, 746, 837, 827 },
//   {675, 937, 736, 293 },
//   {836, 903, 836, 837 }
//};
//int[,] arrays2 =
//{
//   {746, 132, 736, 984 },
//   {425, 274, 854, 325 },
//   {436, 743, 432, 956 }
//};

//int[,] arrays3 = new int[3, 4];

//for (int i = 0; i < arrays1.GetLength(0); i++)
//{
//    for (int j = 0; j < arrays1.GetLength(1); j++)
//    {
//        arrays3[i, j] = arrays1[i, j] + arrays2[i, j];
//        Console.Write(arrays3[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK14

//int[,] arrays =
//{
//   {324, 746, 837, 827 },
//   {675, 937, 736, 293 },
//   {836, 903, 836, 837 }
//};

//int result = 0;

//for (int i = 0; i < arrays.GetLength(0); i++)
//{
//    for (int j = 0; j < arrays.GetLength(1); j++)
//    {
//        result += arrays[i, j];
//    }
//    Console.WriteLine(result);
//    result = 0;
//}

////////////////////////////TASK15 

//int[,] arrays =
//{
//   {324, 746, 837, 827 },
//   {675, 937, 736, 293 },
//   {836, 903, 836, 837 }
//};

//int result = 0;

//for (int i = 0; i < arrays.GetLength(1); i++)
//{
//    for (int j = 0; j < arrays.GetLength(0); j++)
//    {
//        result += arrays[j, i];
//    }
//    Console.WriteLine(result);
//    result = 0;
//}

////////////////////////////TASK16

//int[,] array =
//{
//    {1, 2, 3, 4, 5, 6 }, //{1, 1, 2, 3, 4, 5} //{0, 0, 1, 2, 3, 4} //{0, 0, 0, 1, 2, 3} //{0, 0, 0, 0, 1, 2}
//    {1, 2, 3, 4, 5, 6 },
//    {1, 2, 3, 4, 5, 6 },
//    {1, 2, 3, 4, 5, 6 }
//};

//Console.WriteLine("Shift'i daxil edin(Max deyer 6):");
//int shift = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int k = 0; k < shift; k++)
//    {
//        for (int j = 1; j < array.GetLength(1); j++)
//        {
//            array[i, array.GetLength(1) - j] = array[i, array.GetLength(1) - j - 1];
//        }
//        array[i, k] = 0;
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK17

//int[,] arrays1 =
//{
//   {324, 746, 837, 827 },
//   {675, 937, 736, 293 },
//   {836, 903, 836, 837 }
//};
//int[,] arrays2 =
//{
//   {746, 132, 736, 984 },
//   {425, 274, 854, 325 },
//   {436, 743, 432, 956 }
//};

//int[,] arrays3 = new int[3, 4];

//for (int i = 0; i < arrays1.GetLength(0); i++)
//{
//    for (int j = 0; j < arrays1.GetLength(1); j++)
//    {
//        arrays3[i, j] = arrays1[i, j] * arrays2[i, j];
//        Console.Write(arrays3[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////////////////////////////TASK18

//int[,] array =
//{
//    {3, 52, 23, 90 },
//    {25, 61, 28, 29},
//    {42, 52, 95, 53 },
//};


//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        bool isPrimitive = true;
//        for (int x = 2; x < array[i, j]; x++)
//        {
//            if (array[i, j] % x == 0)
//            {
//                isPrimitive = false;
//            }
//        }
//        if (isPrimitive)
//        {
//            Console.WriteLine(array[i, j]);
//        }
//    }
//}