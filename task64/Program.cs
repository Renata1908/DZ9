int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


void PrintToN(int n)
{
  if (n <= 0)
  {
    return;
  }
  else
  {
    Console.Write(n + " ");
    PrintToN(n - 1);
  }
}

int n = ReadNumber("Введите число N: ");
PrintToN(n);
