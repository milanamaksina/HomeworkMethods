using HW_Methods;




int[,] array = TwoDimensionalArray.Generate2DArray(5, 5);
TwoDimensionalArray.Write2DArray(array);
int[,] result = TwoDimensionalArray.Massiv(array);
TwoDimensionalArray.Write2DArray(result);