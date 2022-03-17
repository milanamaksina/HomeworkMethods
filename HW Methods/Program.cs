using HW_Methods;

int[,] array = TwoDimensionalArray.Generate2DArray(4,4);
TwoDimensionalArray.Write2DArray(array);
int[,] a = TwoDimensionalArray.Reflect(array);
TwoDimensionalArray.Write2DArray(a);